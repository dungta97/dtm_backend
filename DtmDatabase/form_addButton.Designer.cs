namespace DtmDatabase
{
    partial class form_addButton
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
            this.radioButton_containButton = new System.Windows.Forms.RadioButton();
            this.radioButton_containPost1 = new System.Windows.Forms.RadioButton();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.textBox = new System.Windows.Forms.TextBox();
            this.radioButton_containPost2 = new System.Windows.Forms.RadioButton();
            this.button_chooseBackground = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // radioButton_containButton
            // 
            this.radioButton_containButton.AutoSize = true;
            this.radioButton_containButton.Location = new System.Drawing.Point(12, 39);
            this.radioButton_containButton.Name = "radioButton_containButton";
            this.radioButton_containButton.Size = new System.Drawing.Size(73, 17);
            this.radioButton_containButton.TabIndex = 0;
            this.radioButton_containButton.TabStop = true;
            this.radioButton_containButton.Text = "Menu phụ";
            this.radioButton_containButton.UseVisualStyleBackColor = true;
            this.radioButton_containButton.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioButton_containPost1
            // 
            this.radioButton_containPost1.AutoSize = true;
            this.radioButton_containPost1.Location = new System.Drawing.Point(12, 63);
            this.radioButton_containPost1.Name = "radioButton_containPost1";
            this.radioButton_containPost1.Size = new System.Drawing.Size(115, 17);
            this.radioButton_containPost1.TabIndex = 1;
            this.radioButton_containPost1.TabStop = true;
            this.radioButton_containPost1.Text = "Chứa bài viết loại 1";
            this.radioButton_containPost1.UseVisualStyleBackColor = true;
            this.radioButton_containPost1.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(183, 196);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 2;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.OK_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(264, 196);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 3;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(13, 13);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(241, 20);
            this.textBox.TabIndex = 4;
            this.textBox.Text = "new button";
            this.textBox.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // radioButton_containPost2
            // 
            this.radioButton_containPost2.AutoSize = true;
            this.radioButton_containPost2.Location = new System.Drawing.Point(12, 87);
            this.radioButton_containPost2.Name = "radioButton_containPost2";
            this.radioButton_containPost2.Size = new System.Drawing.Size(115, 17);
            this.radioButton_containPost2.TabIndex = 5;
            this.radioButton_containPost2.TabStop = true;
            this.radioButton_containPost2.Text = "Chứa bài viết loại 2";
            this.radioButton_containPost2.UseVisualStyleBackColor = true;
            this.radioButton_containPost2.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // button_chooseBackground
            // 
            this.button_chooseBackground.Location = new System.Drawing.Point(12, 111);
            this.button_chooseBackground.Name = "button_chooseBackground";
            this.button_chooseBackground.Size = new System.Drawing.Size(75, 23);
            this.button_chooseBackground.TabIndex = 6;
            this.button_chooseBackground.Text = "Ảnh nền";
            this.button_chooseBackground.UseVisualStyleBackColor = true;
            this.button_chooseBackground.Click += new System.EventHandler(this.button_chooseBackground_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(134, 40);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(205, 150);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 7;
            this.pictureBox.TabStop = false;
            // 
            // form_addButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 231);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.button_chooseBackground);
            this.Controls.Add(this.radioButton_containPost2);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.radioButton_containPost1);
            this.Controls.Add(this.radioButton_containButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "form_addButton";
            this.Text = "Add Button";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButton_containButton;
        private System.Windows.Forms.RadioButton radioButton_containPost1;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.RadioButton radioButton_containPost2;
        private System.Windows.Forms.Button button_chooseBackground;
        private System.Windows.Forms.PictureBox pictureBox;
    }
}