using Knapsack.Library;
using System.Numerics;
using System.Text;

namespace Knapsack.Forms;

public partial class MainForm : Form
{
    private int _superSequenceSize = 2;
    private KnapsackKeyPair? _keyPair;

    public MainForm()
    {
        InitializeComponent();
    }

    private void MainForm_Load(object sender, EventArgs e)
    {
    }

    private void ButtonCipherClick(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(textBoxPublicKey.Text))
        {
            ShowWarningBox("Public key must be filled. ");
            return;
        }

        KnapsackCipher cipher = new(GetPublicKey());
        textBoxProcessedOutput.Text = cipher.Encrypt(textBoxTextToProcess.Text);
    }

    private BigInteger[] GetPublicKey()
    {
        var tokens = textBoxPublicKey.Text.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        LinkedList<BigInteger> bigIntegers = new();
        foreach (var token in tokens)
            bigIntegers.AddLast(BigInteger.Parse(token));

        return bigIntegers.ToArray();
    }

    private void ButtonDecipherClick(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(textBoxPrivateKey.Text))
        {
            ShowWarningBox("Private key must be filled. ");
            return;
        }

        var privateKey = GetPrivateKey();
        KnapsackDecipher decipher = new(privateKey);
        textBoxProcessedOutput.Text = decipher.Decrypt(textBoxTextToProcess.Text);
    }

    private KnapsackPrivateKey GetPrivateKey()
    {
        var tokens = textBoxPrivateKey.Text.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        LinkedList<BigInteger> superSequence = new();
        for (int i = 0; i < tokens.Length - 2; i++)
            superSequence.AddLast(BigInteger.Parse(tokens[i]));

        KnapsackPrivateKey privateKey = new(
            superSequence.ToArray(),
            BigInteger.Parse(tokens[^1]),
            BigInteger.Parse(tokens[^2]));
        return privateKey;
    }

    private void ButtonSaveTextClick(object sender, EventArgs e)
    {
        if (saveTextFileDialog.ShowDialog() == DialogResult.OK)
        {
            string filePath = saveTextFileDialog.FileName;
            string textToSave = textBoxProcessedOutput.Text;

            try
            {
                File.WriteAllText(filePath, textToSave);
                ShowSuccessBox("Text saved to file successfully!");
            }
            catch (IOException ex)
            {
                ShowErrorBox($"An error occurred while saving the file: {ex.Message}");
            }
        }
    }

    private void SuperSequenceSizeUpDownValueChanged(object sender, EventArgs e)
    {
        int newSuperSequenceSize = (int)superSequenceSizeUpDown.Value;
        if (newSuperSequenceSize < 2
            || newSuperSequenceSize > 150)
        {
            ShowWarningBox("Super sequence size must be greater than 2 and less than 150.");
            superSequenceSizeUpDown.Value = _superSequenceSize;
            return;
        }

        _superSequenceSize = newSuperSequenceSize;
    }

    private void ButtonGenerateKeysClick(object sender, EventArgs e)
    {
        var keyGenerator = new KnapsackKeyGenerator(
            new SuperSequenceGenerator(_superSequenceSize));
        _keyPair = keyGenerator.GetKnapsackKeyPair();
        StringBuilder textBuilder = new();
        foreach (var number in _keyPair.PublicKey)
            textBuilder.Append($"{number} ");

        textBoxPublicKey.Text = textBuilder.ToString();
        textBuilder.Clear();
        foreach (var number in _keyPair.PrivateKey.SuperSequence)
            textBuilder.Append($"{number} ");

        textBuilder.Append($"{_keyPair.PrivateKey.Factor} ");
        textBuilder.Append($"{_keyPair.PrivateKey.Modulo} ");
        textBoxPrivateKey.Text = textBuilder.ToString();
    }

    private void ButtonOpenTextClick(object sender, EventArgs e)
    {
        if (openTextFileDialog.ShowDialog() == DialogResult.OK)
        {
            string selectedFile = openTextFileDialog.FileName;
            try
            {
                string fileContent = File.ReadAllText(selectedFile);
                textBoxTextToProcess.Text = fileContent;
            }
            catch (IOException ex)
            {
                ShowErrorBox($"An error occurred while reading the file: {ex.Message}");
            }
        }
    }

    private static void ShowWarningBox(string text)
    {
        MessageBox.Show(text + "\nMake sure of it and try again.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
    }

    private static void ShowErrorBox(string text)
    {
        MessageBox.Show(text, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }

    private static void ShowSuccessBox(string text)
    {
        MessageBox.Show(text, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

}
