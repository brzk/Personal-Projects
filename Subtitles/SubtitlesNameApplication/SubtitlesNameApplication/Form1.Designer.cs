namespace SubtitlesNameApplication
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
            this.VideoNameTextBox = new System.Windows.Forms.TextBox();
            this.dictionaryTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.changeButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.editSubtitleFileTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.sourceSubtitleFileTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // VideoNameTextBox
            // 
            this.VideoNameTextBox.Location = new System.Drawing.Point(145, 114);
            this.VideoNameTextBox.Name = "VideoNameTextBox";
            this.VideoNameTextBox.Size = new System.Drawing.Size(100, 22);
            this.VideoNameTextBox.TabIndex = 1;
            // 
            // dictionaryTextBox
            // 
            this.dictionaryTextBox.Location = new System.Drawing.Point(107, 173);
            this.dictionaryTextBox.Name = "dictionaryTextBox";
            this.dictionaryTextBox.Size = new System.Drawing.Size(241, 22);
            this.dictionaryTextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Video Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Dictionaty";
            // 
            // changeButton
            // 
            this.changeButton.Location = new System.Drawing.Point(315, 252);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(75, 23);
            this.changeButton.TabIndex = 5;
            this.changeButton.Text = "Change";
            this.changeButton.UseVisualStyleBackColor = true;
            this.changeButton.Click += new System.EventHandler(this.changeButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(40, 263);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Shift";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(145, 263);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(113, 38);
            this.button2.TabIndex = 7;
            this.button2.Text = "Copy Time";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Edit Subtitle File";
            // 
            // editSubtitleFileTextBox
            // 
            this.editSubtitleFileTextBox.Location = new System.Drawing.Point(151, 25);
            this.editSubtitleFileTextBox.Name = "editSubtitleFileTextBox";
            this.editSubtitleFileTextBox.Size = new System.Drawing.Size(239, 22);
            this.editSubtitleFileTextBox.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Source Subtitle File";
            // 
            // sourceSubtitleFileTextBox
            // 
            this.sourceSubtitleFileTextBox.Location = new System.Drawing.Point(151, 61);
            this.sourceSubtitleFileTextBox.Name = "sourceSubtitleFileTextBox";
            this.sourceSubtitleFileTextBox.Size = new System.Drawing.Size(239, 22);
            this.sourceSubtitleFileTextBox.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 338);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.sourceSubtitleFileTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.editSubtitleFileTextBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.changeButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dictionaryTextBox);
            this.Controls.Add(this.VideoNameTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox VideoNameTextBox;
        private System.Windows.Forms.TextBox dictionaryTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button changeButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox editSubtitleFileTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox sourceSubtitleFileTextBox;
    }
}

