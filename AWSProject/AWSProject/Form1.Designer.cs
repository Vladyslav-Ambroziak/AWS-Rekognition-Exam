namespace AWSProject
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.listEmotionPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.analyzeURL_button = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.localImg_label = new System.Windows.Forms.Label();
            this.URLImg_textBox = new System.Windows.Forms.TextBox();
            this.selectFile_button = new System.Windows.Forms.Button();
            this.analyzeLocal_button = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.listEmotionPanel);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(821, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(444, 683);
            this.panel1.TabIndex = 0;
            // 
            // listEmotionPanel
            // 
            this.listEmotionPanel.Location = new System.Drawing.Point(38, 126);
            this.listEmotionPanel.Name = "listEmotionPanel";
            this.listEmotionPanel.Size = new System.Drawing.Size(374, 489);
            this.listEmotionPanel.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(31, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "EMOTION:";
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox.ImageLocation = "";
            this.pictureBox.Location = new System.Drawing.Point(156, 26);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(500, 500);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // analyzeURL_button
            // 
            this.analyzeURL_button.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.analyzeURL_button.Location = new System.Drawing.Point(253, 636);
            this.analyzeURL_button.Name = "analyzeURL_button";
            this.analyzeURL_button.Size = new System.Drawing.Size(140, 33);
            this.analyzeURL_button.TabIndex = 2;
            this.analyzeURL_button.Text = "Analyze URL";
            this.analyzeURL_button.UseVisualStyleBackColor = true;
            this.analyzeURL_button.Click += new System.EventHandler(this.analyzeURL_button_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.localImg_label);
            this.panel3.Location = new System.Drawing.Point(135, 556);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(505, 21);
            this.panel3.TabIndex = 3;
            // 
            // localImg_label
            // 
            this.localImg_label.AutoSize = true;
            this.localImg_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.localImg_label.Location = new System.Drawing.Point(2, 1);
            this.localImg_label.Name = "localImg_label";
            this.localImg_label.Size = new System.Drawing.Size(0, 15);
            this.localImg_label.TabIndex = 0;
            // 
            // URLImg_textBox
            // 
            this.URLImg_textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.URLImg_textBox.Location = new System.Drawing.Point(135, 596);
            this.URLImg_textBox.Name = "URLImg_textBox";
            this.URLImg_textBox.Size = new System.Drawing.Size(632, 20);
            this.URLImg_textBox.TabIndex = 4;
            // 
            // selectFile_button
            // 
            this.selectFile_button.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.selectFile_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.selectFile_button.Location = new System.Drawing.Point(661, 556);
            this.selectFile_button.Name = "selectFile_button";
            this.selectFile_button.Size = new System.Drawing.Size(106, 21);
            this.selectFile_button.TabIndex = 5;
            this.selectFile_button.Text = "Select file";
            this.selectFile_button.UseVisualStyleBackColor = false;
            this.selectFile_button.Click += new System.EventHandler(this.selectFile_button_Click);
            // 
            // analyzeLocal_button
            // 
            this.analyzeLocal_button.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.analyzeLocal_button.Location = new System.Drawing.Point(413, 636);
            this.analyzeLocal_button.Name = "analyzeLocal_button";
            this.analyzeLocal_button.Size = new System.Drawing.Size(140, 33);
            this.analyzeLocal_button.TabIndex = 7;
            this.analyzeLocal_button.Text = "Analyze local file";
            this.analyzeLocal_button.UseVisualStyleBackColor = true;
            this.analyzeLocal_button.Click += new System.EventHandler(this.analyzeLocal_button_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(43, 596);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "URL image:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(43, 558);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Local image:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.analyzeLocal_button);
            this.Controls.Add(this.selectFile_button);
            this.Controls.Add(this.URLImg_textBox);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.analyzeURL_button);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "AWS Rekognition";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel listEmotionPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button analyzeURL_button;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox URLImg_textBox;
        private System.Windows.Forms.Button selectFile_button;
        private System.Windows.Forms.Label localImg_label;
        private System.Windows.Forms.Button analyzeLocal_button;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

