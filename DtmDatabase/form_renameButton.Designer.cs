namespace DtmDatabase
{
    partial class form_renameButton
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
            this.textBox = new System.Windows.Forms.TextBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.radioButton_containButton = new System.Windows.Forms.RadioButton();
            this.radioButton_post1 = new System.Windows.Forms.RadioButton();
            this.radioButton_post2 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(13, 13);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(287, 20);
            this.textBox.TabIndex = 0;
            this.textBox.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(225, 141);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 1;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(144, 141);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 2;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // radioButton_containButton
            // 
            this.radioButton_containButton.AutoSize = true;
            this.radioButton_containButton.Location = new System.Drawing.Point(13, 40);
            this.radioButton_containButton.Name = "radioButton_containButton";
            this.radioButton_containButton.Size = new System.Drawing.Size(74, 17);
            this.radioButton_containButton.TabIndex = 3;
            this.radioButton_containButton.TabStop = true;
            this.radioButton_containButton.Text = "Menu Phụ";
            this.radioButton_containButton.UseVisualStyleBackColor = true;
            this.radioButton_containButton.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioButton_post1
            // 
            this.radioButton_post1.AutoSize = true;
            this.radioButton_post1.Location = new System.Drawing.Point(13, 64);
            this.radioButton_post1.Name = "radioButton_post1";
            this.radioButton_post1.Size = new System.Drawing.Size(79, 17);
            this.radioButton_post1.TabIndex = 4;
            this.radioButton_post1.TabStop = true;
            this.radioButton_post1.Text = "Giao diện 1";
            this.radioButton_post1.UseVisualStyleBackColor = true;
            this.radioButton_post1.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioButton_post2
            // 
            this.radioButton_post2.AutoSize = true;
            this.radioButton_post2.Location = new System.Drawing.Point(13, 88);
            this.radioButton_post2.Name = "radioButton_post2";
            this.radioButton_post2.Size = new System.Drawing.Size(79, 17);
            this.radioButton_post2.TabIndex = 5;
            this.radioButton_post2.TabStop = true;
            this.radioButton_post2.Text = "Giao diện 2";
            this.radioButton_post2.UseVisualStyleBackColor = true;
            this.radioButton_post2.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // form_renameButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 176);
            this.Controls.Add(this.radioButton_post2);
            this.Controls.Add(this.radioButton_post1);
            this.Controls.Add(this.radioButton_containButton);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.textBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "form_renameButton";
            this.Text = "form_renameButton";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.RadioButton radioButton_containButton;
        private System.Windows.Forms.RadioButton radioButton_post1;
        private System.Windows.Forms.RadioButton radioButton_post2;
    }
}