namespace FolderBrowser
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.debugInstructionsLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.helloWorldLabel = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lstPliki = new System.Windows.Forms.ListBox();
            this.btnSplitInoiceDesc = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel1.LinkColor = System.Drawing.Color.Navy;
            this.linkLabel1.Location = new System.Drawing.Point(1054, 1289);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(572, 37);
            this.linkLabel1.TabIndex = 0;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Prawa autorskie: Przemys³aw Polañski";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // debugInstructionsLabel
            // 
            this.debugInstructionsLabel.AutoSize = true;
            this.debugInstructionsLabel.BackColor = System.Drawing.SystemColors.Control;
            this.debugInstructionsLabel.ForeColor = System.Drawing.Color.Black;
            this.debugInstructionsLabel.Location = new System.Drawing.Point(114, 194);
            this.debugInstructionsLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.debugInstructionsLabel.Name = "debugInstructionsLabel";
            this.debugInstructionsLabel.Size = new System.Drawing.Size(284, 37);
            this.debugInstructionsLabel.TabIndex = 1;
            this.debugInstructionsLabel.Text = "Folder z fakturami:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Location = new System.Drawing.Point(10, 908);
            this.button1.Margin = new System.Windows.Forms.Padding(6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(559, 80);
            this.button1.TabIndex = 2;
            this.button1.Text = "1. Wska¿ plik \"Opisy faktur.pdf\"";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // helloWorldLabel
            // 
            this.helloWorldLabel.AutoSize = true;
            this.helloWorldLabel.BackColor = System.Drawing.Color.Transparent;
            this.helloWorldLabel.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.helloWorldLabel.ForeColor = System.Drawing.Color.DarkBlue;
            this.helloWorldLabel.Location = new System.Drawing.Point(737, 46);
            this.helloWorldLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.helloWorldLabel.Name = "helloWorldLabel";
            this.helloWorldLabel.Size = new System.Drawing.Size(1033, 101);
            this.helloWorldLabel.TabIndex = 3;
            this.helloWorldLabel.Text = "Generator Opisów Faktur";
            this.helloWorldLabel.Click += new System.EventHandler(this.helloWorldLabel_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Info;
            this.textBox1.Location = new System.Drawing.Point(443, 191);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(2038, 44);
            this.textBox1.TabIndex = 4;
            // 
            // lstPliki
            // 
            this.lstPliki.BackColor = System.Drawing.SystemColors.Info;
            this.lstPliki.FormattingEnabled = true;
            this.lstPliki.ItemHeight = 37;
            this.lstPliki.Location = new System.Drawing.Point(43, 284);
            this.lstPliki.Name = "lstPliki";
            this.lstPliki.Size = new System.Drawing.Size(2438, 485);
            this.lstPliki.TabIndex = 6;
            this.lstPliki.SelectedIndexChanged += new System.EventHandler(this.lstPliki_SelectedIndexChanged);
            // 
            // btnSplitInoiceDesc
            // 
            this.btnSplitInoiceDesc.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSplitInoiceDesc.Location = new System.Drawing.Point(10, 1016);
            this.btnSplitInoiceDesc.Name = "btnSplitInoiceDesc";
            this.btnSplitInoiceDesc.Size = new System.Drawing.Size(559, 80);
            this.btnSplitInoiceDesc.TabIndex = 7;
            this.btnSplitInoiceDesc.Text = "2. Podziel plik z opisami faktur";
            this.btnSplitInoiceDesc.UseVisualStyleBackColor = false;
            this.btnSplitInoiceDesc.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button3.Location = new System.Drawing.Point(10, 1121);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(559, 80);
            this.button3.TabIndex = 8;
            this.button3.Text = "3. Po³¹cz faktury z ich opisami";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(594, 849);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 40);
            this.label1.TabIndex = 9;
            this.label1.Text = "Instrukcja:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(597, 926);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1834, 37);
            this.label2.TabIndex = 10;
            this.label2.Text = "1. Wska¿ folder w którym znajduje siê plik PDF z opisami faktur np. Opis.pdf (jeœ" +
    "li go nie ma to przetwórz plik MS Word do PDF.";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(597, 1034);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1826, 37);
            this.label3.TabIndex = 11;
            this.label3.Text = "2. Upewnij siê, ¿e jest jeden plik PDF z opisem faktur. Kliknij aby wyodrêbniæ od" +
    "dzielny opis do ka¿dej faktury w folderze \"Opisy\"";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(597, 1139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(1719, 37);
            this.label4.TabIndex = 12;
            this.label4.Text = "3. Scal wyodrêbnione opisy z fakturami klikaj¹c \"Po³¹cz fakury z opisami\". Progra" +
    "m utworzy katalog \"Faktury z opisami\"";
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(2781, 1557);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnSplitInoiceDesc);
            this.Controls.Add(this.lstPliki);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.helloWorldLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.debugInstructionsLabel);
            this.Controls.Add(this.linkLabel1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MinimumSize = new System.Drawing.Size(2772, 1660);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kod do przysz³oœci - Generator Opisów Faktur";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label debugInstructionsLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label helloWorldLabel;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox lstPliki;
        private System.Windows.Forms.Button btnSplitInoiceDesc;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ImageList imageList1;
    }
}

