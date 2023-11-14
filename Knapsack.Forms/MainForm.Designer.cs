namespace Knapsack.Forms;

partial class MainForm
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        tableLayoutPanel1 = new TableLayoutPanel();
        tableLayoutPanel2 = new TableLayoutPanel();
        processResultBox = new GroupBox();
        tableLayoutPanel7 = new TableLayoutPanel();
        textBoxProcessedOutput = new RichTextBox();
        tableLayoutPanel8 = new TableLayoutPanel();
        buttonSaveText = new Button();
        textToProcessBox = new GroupBox();
        tableLayoutPanel11 = new TableLayoutPanel();
        textBoxTextToProcess = new RichTextBox();
        tableLayoutPanel12 = new TableLayoutPanel();
        buttonCipher = new Button();
        buttonDecipher = new Button();
        buttonOpenText = new Button();
        tableLayoutPanel4 = new TableLayoutPanel();
        keyGenerationBox = new GroupBox();
        tableLayoutPanel9 = new TableLayoutPanel();
        buttonGenerateKeys = new Button();
        superSequenceSizeUpDown = new NumericUpDown();
        groupBoxPublicKey = new GroupBox();
        textBoxPublicKey = new RichTextBox();
        groupBoxPrivateKey = new GroupBox();
        textBoxPrivateKey = new RichTextBox();
        openTextFileDialog = new OpenFileDialog();
        saveTextFileDialog = new SaveFileDialog();
        tableLayoutPanel1.SuspendLayout();
        tableLayoutPanel2.SuspendLayout();
        processResultBox.SuspendLayout();
        tableLayoutPanel7.SuspendLayout();
        tableLayoutPanel8.SuspendLayout();
        textToProcessBox.SuspendLayout();
        tableLayoutPanel11.SuspendLayout();
        tableLayoutPanel12.SuspendLayout();
        tableLayoutPanel4.SuspendLayout();
        keyGenerationBox.SuspendLayout();
        tableLayoutPanel9.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)superSequenceSizeUpDown).BeginInit();
        groupBoxPublicKey.SuspendLayout();
        groupBoxPrivateKey.SuspendLayout();
        SuspendLayout();
        // 
        // tableLayoutPanel1
        // 
        tableLayoutPanel1.ColumnCount = 1;
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
        tableLayoutPanel1.Dock = DockStyle.Fill;
        tableLayoutPanel1.Location = new Point(0, 0);
        tableLayoutPanel1.Name = "tableLayoutPanel1";
        tableLayoutPanel1.RowCount = 1;
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
        tableLayoutPanel1.Size = new Size(1217, 358);
        tableLayoutPanel1.TabIndex = 0;
        // 
        // tableLayoutPanel2
        // 
        tableLayoutPanel2.ColumnCount = 3;
        tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 31.11111F));
        tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 34.4444427F));
        tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 34.4444427F));
        tableLayoutPanel2.Controls.Add(processResultBox, 0, 0);
        tableLayoutPanel2.Controls.Add(textToProcessBox, 0, 0);
        tableLayoutPanel2.Controls.Add(tableLayoutPanel4, 0, 0);
        tableLayoutPanel2.Dock = DockStyle.Fill;
        tableLayoutPanel2.Location = new Point(3, 3);
        tableLayoutPanel2.Name = "tableLayoutPanel2";
        tableLayoutPanel2.RowCount = 1;
        tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        tableLayoutPanel2.Size = new Size(1211, 352);
        tableLayoutPanel2.TabIndex = 0;
        // 
        // processResultBox
        // 
        processResultBox.Controls.Add(tableLayoutPanel7);
        processResultBox.Dock = DockStyle.Fill;
        processResultBox.Font = new Font("Bahnschrift SemiBold", 10F, FontStyle.Bold, GraphicsUnit.Point);
        processResultBox.Location = new Point(796, 3);
        processResultBox.Name = "processResultBox";
        processResultBox.Size = new Size(412, 346);
        processResultBox.TabIndex = 4;
        processResultBox.TabStop = false;
        processResultBox.Text = "Processed Output";
        // 
        // tableLayoutPanel7
        // 
        tableLayoutPanel7.ColumnCount = 1;
        tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        tableLayoutPanel7.Controls.Add(textBoxProcessedOutput, 0, 0);
        tableLayoutPanel7.Controls.Add(tableLayoutPanel8, 0, 1);
        tableLayoutPanel7.Dock = DockStyle.Fill;
        tableLayoutPanel7.Location = new Point(3, 24);
        tableLayoutPanel7.Name = "tableLayoutPanel7";
        tableLayoutPanel7.RowCount = 2;
        tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 82F));
        tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 18F));
        tableLayoutPanel7.Size = new Size(406, 319);
        tableLayoutPanel7.TabIndex = 0;
        // 
        // textBoxProcessedOutput
        // 
        textBoxProcessedOutput.BackColor = SystemColors.GradientInactiveCaption;
        textBoxProcessedOutput.Dock = DockStyle.Fill;
        textBoxProcessedOutput.Font = new Font("Bahnschrift", 9F, FontStyle.Regular, GraphicsUnit.Point);
        textBoxProcessedOutput.Location = new Point(3, 3);
        textBoxProcessedOutput.Name = "textBoxProcessedOutput";
        textBoxProcessedOutput.ReadOnly = true;
        textBoxProcessedOutput.Size = new Size(400, 255);
        textBoxProcessedOutput.TabIndex = 1;
        textBoxProcessedOutput.Text = "";
        // 
        // tableLayoutPanel8
        // 
        tableLayoutPanel8.ColumnCount = 1;
        tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
        tableLayoutPanel8.Controls.Add(buttonSaveText, 0, 0);
        tableLayoutPanel8.Dock = DockStyle.Fill;
        tableLayoutPanel8.Location = new Point(3, 264);
        tableLayoutPanel8.Name = "tableLayoutPanel8";
        tableLayoutPanel8.RowCount = 1;
        tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
        tableLayoutPanel8.Size = new Size(400, 52);
        tableLayoutPanel8.TabIndex = 2;
        // 
        // buttonSaveText
        // 
        buttonSaveText.BackColor = Color.MediumSeaGreen;
        buttonSaveText.Dock = DockStyle.Fill;
        buttonSaveText.Font = new Font("Bahnschrift SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point);
        buttonSaveText.ForeColor = SystemColors.ButtonHighlight;
        buttonSaveText.Location = new Point(3, 3);
        buttonSaveText.Name = "buttonSaveText";
        buttonSaveText.Size = new Size(394, 46);
        buttonSaveText.TabIndex = 0;
        buttonSaveText.Text = "Save";
        buttonSaveText.UseVisualStyleBackColor = false;
        buttonSaveText.Click += ButtonSaveTextClick;
        // 
        // textToProcessBox
        // 
        textToProcessBox.Controls.Add(tableLayoutPanel11);
        textToProcessBox.Dock = DockStyle.Fill;
        textToProcessBox.Font = new Font("Bahnschrift SemiBold", 10F, FontStyle.Bold, GraphicsUnit.Point);
        textToProcessBox.Location = new Point(379, 3);
        textToProcessBox.Name = "textToProcessBox";
        textToProcessBox.Size = new Size(411, 346);
        textToProcessBox.TabIndex = 3;
        textToProcessBox.TabStop = false;
        textToProcessBox.Text = "Text to Process";
        // 
        // tableLayoutPanel11
        // 
        tableLayoutPanel11.ColumnCount = 1;
        tableLayoutPanel11.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        tableLayoutPanel11.Controls.Add(textBoxTextToProcess, 0, 0);
        tableLayoutPanel11.Controls.Add(tableLayoutPanel12, 0, 1);
        tableLayoutPanel11.Dock = DockStyle.Fill;
        tableLayoutPanel11.Location = new Point(3, 24);
        tableLayoutPanel11.Name = "tableLayoutPanel11";
        tableLayoutPanel11.RowCount = 2;
        tableLayoutPanel11.RowStyles.Add(new RowStyle(SizeType.Percent, 82F));
        tableLayoutPanel11.RowStyles.Add(new RowStyle(SizeType.Percent, 18F));
        tableLayoutPanel11.Size = new Size(405, 319);
        tableLayoutPanel11.TabIndex = 2;
        // 
        // textBoxTextToProcess
        // 
        textBoxTextToProcess.BackColor = SystemColors.GradientInactiveCaption;
        textBoxTextToProcess.Dock = DockStyle.Fill;
        textBoxTextToProcess.Font = new Font("Bahnschrift", 9F, FontStyle.Regular, GraphicsUnit.Point);
        textBoxTextToProcess.Location = new Point(3, 3);
        textBoxTextToProcess.Name = "textBoxTextToProcess";
        textBoxTextToProcess.Size = new Size(399, 255);
        textBoxTextToProcess.TabIndex = 0;
        textBoxTextToProcess.Text = "";
        // 
        // tableLayoutPanel12
        // 
        tableLayoutPanel12.ColumnCount = 3;
        tableLayoutPanel12.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
        tableLayoutPanel12.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
        tableLayoutPanel12.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
        tableLayoutPanel12.Controls.Add(buttonCipher, 1, 0);
        tableLayoutPanel12.Controls.Add(buttonDecipher, 2, 0);
        tableLayoutPanel12.Controls.Add(buttonOpenText, 0, 0);
        tableLayoutPanel12.Dock = DockStyle.Fill;
        tableLayoutPanel12.Location = new Point(3, 264);
        tableLayoutPanel12.Name = "tableLayoutPanel12";
        tableLayoutPanel12.RowCount = 1;
        tableLayoutPanel12.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        tableLayoutPanel12.Size = new Size(399, 52);
        tableLayoutPanel12.TabIndex = 1;
        // 
        // buttonCipher
        // 
        buttonCipher.BackColor = Color.DarkCyan;
        buttonCipher.Dock = DockStyle.Fill;
        buttonCipher.Font = new Font("Bahnschrift SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point);
        buttonCipher.ForeColor = SystemColors.ButtonHighlight;
        buttonCipher.Location = new Point(135, 3);
        buttonCipher.Name = "buttonCipher";
        buttonCipher.Size = new Size(126, 46);
        buttonCipher.TabIndex = 0;
        buttonCipher.Text = "Cipher";
        buttonCipher.UseVisualStyleBackColor = false;
        buttonCipher.Click += ButtonCipherClick;
        // 
        // buttonDecipher
        // 
        buttonDecipher.BackColor = Color.DarkCyan;
        buttonDecipher.Dock = DockStyle.Fill;
        buttonDecipher.Font = new Font("Bahnschrift SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point);
        buttonDecipher.ForeColor = SystemColors.ButtonHighlight;
        buttonDecipher.Location = new Point(267, 3);
        buttonDecipher.Name = "buttonDecipher";
        buttonDecipher.Size = new Size(129, 46);
        buttonDecipher.TabIndex = 1;
        buttonDecipher.Text = "Decipher";
        buttonDecipher.UseVisualStyleBackColor = false;
        buttonDecipher.Click += ButtonDecipherClick;
        // 
        // buttonOpenText
        // 
        buttonOpenText.BackColor = Color.LightSeaGreen;
        buttonOpenText.Dock = DockStyle.Fill;
        buttonOpenText.Font = new Font("Bahnschrift SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point);
        buttonOpenText.ForeColor = SystemColors.ButtonHighlight;
        buttonOpenText.Location = new Point(3, 3);
        buttonOpenText.Name = "buttonOpenText";
        buttonOpenText.Size = new Size(126, 46);
        buttonOpenText.TabIndex = 2;
        buttonOpenText.Text = "Open";
        buttonOpenText.UseVisualStyleBackColor = false;
        buttonOpenText.Click += ButtonOpenTextClick;
        // 
        // tableLayoutPanel4
        // 
        tableLayoutPanel4.ColumnCount = 1;
        tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        tableLayoutPanel4.Controls.Add(keyGenerationBox, 0, 0);
        tableLayoutPanel4.Controls.Add(groupBoxPublicKey, 0, 1);
        tableLayoutPanel4.Controls.Add(groupBoxPrivateKey, 0, 2);
        tableLayoutPanel4.Dock = DockStyle.Fill;
        tableLayoutPanel4.Location = new Point(3, 3);
        tableLayoutPanel4.Name = "tableLayoutPanel4";
        tableLayoutPanel4.RowCount = 3;
        tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 24F));
        tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 38F));
        tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 38F));
        tableLayoutPanel4.Size = new Size(370, 346);
        tableLayoutPanel4.TabIndex = 1;
        // 
        // keyGenerationBox
        // 
        keyGenerationBox.Controls.Add(tableLayoutPanel9);
        keyGenerationBox.Dock = DockStyle.Fill;
        keyGenerationBox.Font = new Font("Bahnschrift SemiBold", 10F, FontStyle.Bold, GraphicsUnit.Point);
        keyGenerationBox.Location = new Point(3, 3);
        keyGenerationBox.Name = "keyGenerationBox";
        keyGenerationBox.Size = new Size(364, 77);
        keyGenerationBox.TabIndex = 2;
        keyGenerationBox.TabStop = false;
        keyGenerationBox.Text = "Key Generation";
        // 
        // tableLayoutPanel9
        // 
        tableLayoutPanel9.ColumnCount = 2;
        tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 65F));
        tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
        tableLayoutPanel9.Controls.Add(buttonGenerateKeys, 0, 0);
        tableLayoutPanel9.Controls.Add(superSequenceSizeUpDown, 1, 0);
        tableLayoutPanel9.Dock = DockStyle.Fill;
        tableLayoutPanel9.Location = new Point(3, 24);
        tableLayoutPanel9.Name = "tableLayoutPanel9";
        tableLayoutPanel9.RowCount = 1;
        tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
        tableLayoutPanel9.Size = new Size(358, 50);
        tableLayoutPanel9.TabIndex = 2;
        // 
        // buttonGenerateKeys
        // 
        buttonGenerateKeys.BackColor = Color.LightSeaGreen;
        buttonGenerateKeys.Dock = DockStyle.Fill;
        buttonGenerateKeys.Font = new Font("Bahnschrift SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point);
        buttonGenerateKeys.ForeColor = SystemColors.ButtonHighlight;
        buttonGenerateKeys.Location = new Point(3, 3);
        buttonGenerateKeys.Name = "buttonGenerateKeys";
        buttonGenerateKeys.Size = new Size(226, 44);
        buttonGenerateKeys.TabIndex = 3;
        buttonGenerateKeys.Text = "Generate";
        buttonGenerateKeys.UseVisualStyleBackColor = false;
        buttonGenerateKeys.Click += ButtonGenerateKeysClick;
        // 
        // superSequenceSizeUpDown
        // 
        superSequenceSizeUpDown.BackColor = SystemColors.GradientInactiveCaption;
        superSequenceSizeUpDown.Dock = DockStyle.Fill;
        superSequenceSizeUpDown.Location = new Point(235, 3);
        superSequenceSizeUpDown.Name = "superSequenceSizeUpDown";
        superSequenceSizeUpDown.Size = new Size(120, 28);
        superSequenceSizeUpDown.TabIndex = 4;
        superSequenceSizeUpDown.TextAlign = HorizontalAlignment.Center;
        superSequenceSizeUpDown.Value = new decimal(new int[] { 2, 0, 0, 0 });
        superSequenceSizeUpDown.ValueChanged += SuperSequenceSizeUpDownValueChanged;
        // 
        // groupBoxPublicKey
        // 
        groupBoxPublicKey.Controls.Add(textBoxPublicKey);
        groupBoxPublicKey.Dock = DockStyle.Fill;
        groupBoxPublicKey.Font = new Font("Bahnschrift SemiBold", 10F, FontStyle.Bold, GraphicsUnit.Point);
        groupBoxPublicKey.Location = new Point(3, 86);
        groupBoxPublicKey.Name = "groupBoxPublicKey";
        groupBoxPublicKey.Size = new Size(364, 125);
        groupBoxPublicKey.TabIndex = 3;
        groupBoxPublicKey.TabStop = false;
        groupBoxPublicKey.Text = "Public Key";
        // 
        // textBoxPublicKey
        // 
        textBoxPublicKey.BackColor = SystemColors.GradientInactiveCaption;
        textBoxPublicKey.Dock = DockStyle.Fill;
        textBoxPublicKey.Font = new Font("Bahnschrift", 9F, FontStyle.Regular, GraphicsUnit.Point);
        textBoxPublicKey.Location = new Point(3, 24);
        textBoxPublicKey.Name = "textBoxPublicKey";
        textBoxPublicKey.Size = new Size(358, 98);
        textBoxPublicKey.TabIndex = 1;
        textBoxPublicKey.Text = "";
        // 
        // groupBoxPrivateKey
        // 
        groupBoxPrivateKey.Controls.Add(textBoxPrivateKey);
        groupBoxPrivateKey.Dock = DockStyle.Fill;
        groupBoxPrivateKey.Font = new Font("Bahnschrift SemiBold", 10F, FontStyle.Bold, GraphicsUnit.Point);
        groupBoxPrivateKey.Location = new Point(3, 217);
        groupBoxPrivateKey.Name = "groupBoxPrivateKey";
        groupBoxPrivateKey.Size = new Size(364, 126);
        groupBoxPrivateKey.TabIndex = 4;
        groupBoxPrivateKey.TabStop = false;
        groupBoxPrivateKey.Text = "Private Key";
        // 
        // textBoxPrivateKey
        // 
        textBoxPrivateKey.BackColor = SystemColors.GradientInactiveCaption;
        textBoxPrivateKey.Dock = DockStyle.Fill;
        textBoxPrivateKey.Font = new Font("Bahnschrift", 9F, FontStyle.Regular, GraphicsUnit.Point);
        textBoxPrivateKey.Location = new Point(3, 24);
        textBoxPrivateKey.Name = "textBoxPrivateKey";
        textBoxPrivateKey.Size = new Size(358, 99);
        textBoxPrivateKey.TabIndex = 1;
        textBoxPrivateKey.Text = "";
        // 
        // openTextFileDialog
        // 
        openTextFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
        // 
        // saveTextFileDialog
        // 
        saveTextFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
        // 
        // MainForm
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.Azure;
        ClientSize = new Size(1217, 358);
        Controls.Add(tableLayoutPanel1);
        Name = "MainForm";
        Text = "MainForm";
        Load += MainForm_Load;
        tableLayoutPanel1.ResumeLayout(false);
        tableLayoutPanel2.ResumeLayout(false);
        processResultBox.ResumeLayout(false);
        tableLayoutPanel7.ResumeLayout(false);
        tableLayoutPanel8.ResumeLayout(false);
        textToProcessBox.ResumeLayout(false);
        tableLayoutPanel11.ResumeLayout(false);
        tableLayoutPanel12.ResumeLayout(false);
        tableLayoutPanel4.ResumeLayout(false);
        keyGenerationBox.ResumeLayout(false);
        tableLayoutPanel9.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)superSequenceSizeUpDown).EndInit();
        groupBoxPublicKey.ResumeLayout(false);
        groupBoxPrivateKey.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion

    private TableLayoutPanel tableLayoutPanel1;
    private TableLayoutPanel tableLayoutPanel2;
    private TableLayoutPanel tableLayoutPanel4;
    private GroupBox keyGenerationBox;
    private TableLayoutPanel tableLayoutPanel9;
    private OpenFileDialog openTextFileDialog;
    private SaveFileDialog saveTextFileDialog;
    private Button buttonGenerateKeys;
    private NumericUpDown superSequenceSizeUpDown;
    private GroupBox groupBoxPublicKey;
    private RichTextBox textBoxPublicKey;
    private GroupBox groupBoxPrivateKey;
    private RichTextBox textBoxPrivateKey;
    private GroupBox processResultBox;
    private TableLayoutPanel tableLayoutPanel7;
    private RichTextBox textBoxProcessedOutput;
    private TableLayoutPanel tableLayoutPanel8;
    private Button buttonSaveText;
    private GroupBox textToProcessBox;
    private TableLayoutPanel tableLayoutPanel11;
    private RichTextBox textBoxTextToProcess;
    private TableLayoutPanel tableLayoutPanel12;
    private Button buttonCipher;
    private Button buttonDecipher;
    private Button buttonOpenText;
}