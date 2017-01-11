namespace IB_lab2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Key_tb = new System.Windows.Forms.TextBox();
            this.S_tb = new System.Windows.Forms.TextBox();
            this.Generate_key_btn = new System.Windows.Forms.Button();
            this.Load_key_btn = new System.Windows.Forms.Button();
            this.Generate_s_btn = new System.Windows.Forms.Button();
            this.Load_s_btn = new System.Windows.Forms.Button();
            this.Load_file_btn1 = new System.Windows.Forms.Button();
            this.File_path = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.шифровкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Encrypt_btn = new System.Windows.Forms.ToolStripMenuItem();
            this.Decrypt_btn = new System.Windows.Forms.ToolStripMenuItem();
            this.About_btn = new System.Windows.Forms.ToolStripMenuItem();
            this.tb_filename = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ключ (key)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Синхропосылка (S)";
            // 
            // Key_tb
            // 
            this.Key_tb.Location = new System.Drawing.Point(115, 69);
            this.Key_tb.Name = "Key_tb";
            this.Key_tb.ReadOnly = true;
            this.Key_tb.Size = new System.Drawing.Size(244, 20);
            this.Key_tb.TabIndex = 2;
            // 
            // S_tb
            // 
            this.S_tb.Location = new System.Drawing.Point(115, 95);
            this.S_tb.Name = "S_tb";
            this.S_tb.ReadOnly = true;
            this.S_tb.Size = new System.Drawing.Size(244, 20);
            this.S_tb.TabIndex = 3;
            // 
            // Generate_key_btn
            // 
            this.Generate_key_btn.Location = new System.Drawing.Point(366, 64);
            this.Generate_key_btn.Name = "Generate_key_btn";
            this.Generate_key_btn.Size = new System.Drawing.Size(94, 23);
            this.Generate_key_btn.TabIndex = 4;
            this.Generate_key_btn.Text = "Сгенерировать";
            this.Generate_key_btn.UseVisualStyleBackColor = true;
            this.Generate_key_btn.Click += new System.EventHandler(this.Generate_key_btn_Click);
            // 
            // Load_key_btn
            // 
            this.Load_key_btn.Location = new System.Drawing.Point(466, 64);
            this.Load_key_btn.Name = "Load_key_btn";
            this.Load_key_btn.Size = new System.Drawing.Size(75, 23);
            this.Load_key_btn.TabIndex = 5;
            this.Load_key_btn.Text = "Загрузить";
            this.Load_key_btn.UseVisualStyleBackColor = true;
            // 
            // Generate_s_btn
            // 
            this.Generate_s_btn.Location = new System.Drawing.Point(366, 93);
            this.Generate_s_btn.Name = "Generate_s_btn";
            this.Generate_s_btn.Size = new System.Drawing.Size(94, 23);
            this.Generate_s_btn.TabIndex = 6;
            this.Generate_s_btn.Text = "Сгенерировать";
            this.Generate_s_btn.UseVisualStyleBackColor = true;
            this.Generate_s_btn.Click += new System.EventHandler(this.Generate_s_btn_Click);
            // 
            // Load_s_btn
            // 
            this.Load_s_btn.Location = new System.Drawing.Point(466, 93);
            this.Load_s_btn.Name = "Load_s_btn";
            this.Load_s_btn.Size = new System.Drawing.Size(75, 23);
            this.Load_s_btn.TabIndex = 7;
            this.Load_s_btn.Text = "Загрузить";
            this.Load_s_btn.UseVisualStyleBackColor = true;
            // 
            // Load_file_btn1
            // 
            this.Load_file_btn1.Location = new System.Drawing.Point(366, 28);
            this.Load_file_btn1.Name = "Load_file_btn1";
            this.Load_file_btn1.Size = new System.Drawing.Size(93, 23);
            this.Load_file_btn1.TabIndex = 8;
            this.Load_file_btn1.Text = "Выбрать файл";
            this.Load_file_btn1.UseVisualStyleBackColor = true;
            this.Load_file_btn1.Click += new System.EventHandler(this.Load_file_btn_Click);
            // 
            // File_path
            // 
            this.File_path.AutoSize = true;
            this.File_path.Location = new System.Drawing.Point(126, 79);
            this.File_path.Name = "File_path";
            this.File_path.Size = new System.Drawing.Size(0, 13);
            this.File_path.TabIndex = 10;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.шифровкаToolStripMenuItem,
            this.About_btn});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(559, 24);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // шифровкаToolStripMenuItem
            // 
            this.шифровкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Encrypt_btn,
            this.Decrypt_btn});
            this.шифровкаToolStripMenuItem.Name = "шифровкаToolStripMenuItem";
            this.шифровкаToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.шифровкаToolStripMenuItem.Text = "Шифровка";
            // 
            // Encrypt_btn
            // 
            this.Encrypt_btn.Name = "Encrypt_btn";
            this.Encrypt_btn.Size = new System.Drawing.Size(157, 22);
            this.Encrypt_btn.Text = "Зашифровать";
            this.Encrypt_btn.Click += new System.EventHandler(this.Encrypt_btn_Click_1);
            // 
            // Decrypt_btn
            // 
            this.Decrypt_btn.Name = "Decrypt_btn";
            this.Decrypt_btn.Size = new System.Drawing.Size(157, 22);
            this.Decrypt_btn.Text = "Расшифровать";
            this.Decrypt_btn.Click += new System.EventHandler(this.Decrypt_btn_Click_1);
            // 
            // About_btn
            // 
            this.About_btn.Name = "About_btn";
            this.About_btn.Size = new System.Drawing.Size(94, 20);
            this.About_btn.Text = "О программе";
            this.About_btn.Click += new System.EventHandler(this.About_btn_Click_1);
            // 
            // tb_filename
            // 
            this.tb_filename.Enabled = false;
            this.tb_filename.HideSelection = false;
            this.tb_filename.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tb_filename.Location = new System.Drawing.Point(116, 30);
            this.tb_filename.Name = "tb_filename";
            this.tb_filename.ReadOnly = true;
            this.tb_filename.Size = new System.Drawing.Size(244, 20);
            this.tb_filename.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(76, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Путь:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(112, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(326, 39);
            this.label4.TabIndex = 17;
            this.label4.Text = "Желательно выбирать файл с текстом на английском языке. \r\nШифрование и расшифровк" +
    "а файлов на русском языке \r\nможет происходить некорректно.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 175);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_filename);
            this.Controls.Add(this.File_path);
            this.Controls.Add(this.Load_file_btn1);
            this.Controls.Add(this.Load_s_btn);
            this.Controls.Add(this.Generate_s_btn);
            this.Controls.Add(this.Load_key_btn);
            this.Controls.Add(this.Generate_key_btn);
            this.Controls.Add(this.S_tb);
            this.Controls.Add(this.Key_tb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Алгоритм ГОСТ 28147";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Key_tb;
        private System.Windows.Forms.TextBox S_tb;
        private System.Windows.Forms.Button Generate_key_btn;
        private System.Windows.Forms.Button Load_key_btn;
        private System.Windows.Forms.Button Generate_s_btn;
        private System.Windows.Forms.Button Load_s_btn;
        private System.Windows.Forms.Button Load_file_btn1;
        private System.Windows.Forms.Label File_path;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem шифровкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Encrypt_btn;
        private System.Windows.Forms.ToolStripMenuItem Decrypt_btn;
        private System.Windows.Forms.ToolStripMenuItem About_btn;
        private System.Windows.Forms.TextBox tb_filename;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

