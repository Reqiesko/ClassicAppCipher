
namespace Lab2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.openFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inputFromFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveResultsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveSourceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutProgrammToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.incodeText = new System.Windows.Forms.TextBox();
            this.outText = new System.Windows.Forms.TextBox();
            this.incodeButton = new System.Windows.Forms.Button();
            this.decodeButton = new System.Windows.Forms.Button();
            this.cipher = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.keyText = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Шифр Плейфера",
            "ROT13"});
            this.comboBox1.Location = new System.Drawing.Point(53, 29);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(120, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFileToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.aboutProgrammToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(526, 24);
            this.menuStrip1.TabIndex = 25;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // openFileToolStripMenuItem
            // 
            this.openFileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inputFromFileToolStripMenuItem});
            this.openFileToolStripMenuItem.Name = "openFileToolStripMenuItem";
            this.openFileToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.openFileToolStripMenuItem.Text = "Open";
            // 
            // inputFromFileToolStripMenuItem
            // 
            this.inputFromFileToolStripMenuItem.Name = "inputFromFileToolStripMenuItem";
            this.inputFromFileToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.inputFromFileToolStripMenuItem.Text = "Input From File";
            this.inputFromFileToolStripMenuItem.Click += new System.EventHandler(this.inputFromFileToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveResultsToolStripMenuItem,
            this.saveSourceToolStripMenuItem});
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // saveResultsToolStripMenuItem
            // 
            this.saveResultsToolStripMenuItem.Name = "saveResultsToolStripMenuItem";
            this.saveResultsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveResultsToolStripMenuItem.Text = "Save Results";
            this.saveResultsToolStripMenuItem.Click += new System.EventHandler(this.saveResultsToolStripMenuItem_Click);
            // 
            // saveSourceToolStripMenuItem
            // 
            this.saveSourceToolStripMenuItem.Name = "saveSourceToolStripMenuItem";
            this.saveSourceToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveSourceToolStripMenuItem.Text = "Save Source";
            this.saveSourceToolStripMenuItem.Click += new System.EventHandler(this.saveSourceToolStripMenuItem_Click);
            // 
            // aboutProgrammToolStripMenuItem
            // 
            this.aboutProgrammToolStripMenuItem.Name = "aboutProgrammToolStripMenuItem";
            this.aboutProgrammToolStripMenuItem.Size = new System.Drawing.Size(112, 20);
            this.aboutProgrammToolStripMenuItem.Text = "About Programm";
            this.aboutProgrammToolStripMenuItem.Click += new System.EventHandler(this.aboutProgrammToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // incodeText
            // 
            this.incodeText.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.incodeText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.incodeText.Location = new System.Drawing.Point(12, 61);
            this.incodeText.Multiline = true;
            this.incodeText.Name = "incodeText";
            this.incodeText.Size = new System.Drawing.Size(233, 114);
            this.incodeText.TabIndex = 26;
            this.incodeText.TextChanged += new System.EventHandler(this.incodeText_TextChanged);
            this.incodeText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.incodeText_KeyPress);
            // 
            // outText
            // 
            this.outText.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.outText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.outText.Location = new System.Drawing.Point(264, 61);
            this.outText.Multiline = true;
            this.outText.Name = "outText";
            this.outText.ReadOnly = true;
            this.outText.Size = new System.Drawing.Size(233, 114);
            this.outText.TabIndex = 27;
            // 
            // incodeButton
            // 
            this.incodeButton.Location = new System.Drawing.Point(12, 181);
            this.incodeButton.Name = "incodeButton";
            this.incodeButton.Size = new System.Drawing.Size(75, 23);
            this.incodeButton.TabIndex = 28;
            this.incodeButton.Text = "Incode";
            this.incodeButton.UseVisualStyleBackColor = true;
            this.incodeButton.Click += new System.EventHandler(this.incodeButton_Click);
            // 
            // decodeButton
            // 
            this.decodeButton.Location = new System.Drawing.Point(93, 181);
            this.decodeButton.Name = "decodeButton";
            this.decodeButton.Size = new System.Drawing.Size(75, 23);
            this.decodeButton.TabIndex = 29;
            this.decodeButton.Text = "Decode";
            this.decodeButton.UseVisualStyleBackColor = true;
            this.decodeButton.Click += new System.EventHandler(this.decodeButton_Click);
            // 
            // cipher
            // 
            this.cipher.AutoSize = true;
            this.cipher.Location = new System.Drawing.Point(9, 32);
            this.cipher.Name = "cipher";
            this.cipher.Size = new System.Drawing.Size(37, 13);
            this.cipher.TabIndex = 31;
            this.cipher.Text = "Cipher";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(204, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "Key Word";
            // 
            // keyText
            // 
            this.keyText.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.keyText.Location = new System.Drawing.Point(264, 27);
            this.keyText.MaxLength = 25;
            this.keyText.Name = "keyText";
            this.keyText.Size = new System.Drawing.Size(197, 20);
            this.keyText.TabIndex = 33;
            this.keyText.TextChanged += new System.EventHandler(this.keyText_TextChanged);
            this.keyText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.keyText_KeyPress);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.CreatePrompt = true;
            this.saveFileDialog1.InitialDirectory = "\\:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 223);
            this.Controls.Add(this.keyText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cipher);
            this.Controls.Add(this.decodeButton);
            this.Controls.Add(this.incodeButton);
            this.Controls.Add(this.outText);
            this.Controls.Add(this.incodeText);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.comboBox1);
            this.Name = "Form1";
            this.Text = "Лабораторная №2, Нерадовский Артемий, 494 группа";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem openFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inputFromFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveResultsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveSourceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutProgrammToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.TextBox incodeText;
        private System.Windows.Forms.TextBox outText;
        private System.Windows.Forms.Button incodeButton;
        private System.Windows.Forms.Button decodeButton;
        private System.Windows.Forms.Label cipher;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox keyText;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

