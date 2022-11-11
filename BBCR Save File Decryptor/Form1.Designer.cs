namespace BBCR_Save_File_Decryptor
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
            this.DecryptGroup = new System.Windows.Forms.GroupBox();
            this.SelectFilePathButton = new System.Windows.Forms.Button();
            this.DecryptButton = new System.Windows.Forms.Button();
            this.PathHintLabel = new System.Windows.Forms.Label();
            this.PathTextBox = new System.Windows.Forms.TextBox();
            this.SaveLocationHint = new System.Windows.Forms.Label();
            this.EncryptGroup = new System.Windows.Forms.GroupBox();
            this.HintDecodedFileLocation = new System.Windows.Forms.Label();
            this.PathTextBoxEncrypt = new System.Windows.Forms.TextBox();
            this.OpenBtnEncrypt = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DecryptGroup.SuspendLayout();
            this.EncryptGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // DecryptGroup
            // 
            this.DecryptGroup.Controls.Add(this.SaveLocationHint);
            this.DecryptGroup.Controls.Add(this.SelectFilePathButton);
            this.DecryptGroup.Controls.Add(this.DecryptButton);
            this.DecryptGroup.Controls.Add(this.PathHintLabel);
            this.DecryptGroup.Controls.Add(this.PathTextBox);
            this.DecryptGroup.Location = new System.Drawing.Point(12, 12);
            this.DecryptGroup.Name = "DecryptGroup";
            this.DecryptGroup.Size = new System.Drawing.Size(425, 112);
            this.DecryptGroup.TabIndex = 0;
            this.DecryptGroup.TabStop = false;
            this.DecryptGroup.Text = "Decrypt";
            // 
            // SelectFilePathButton
            // 
            this.SelectFilePathButton.Location = new System.Drawing.Point(344, 34);
            this.SelectFilePathButton.Name = "SelectFilePathButton";
            this.SelectFilePathButton.Size = new System.Drawing.Size(75, 20);
            this.SelectFilePathButton.TabIndex = 3;
            this.SelectFilePathButton.Text = "Open...";
            this.SelectFilePathButton.UseVisualStyleBackColor = true;
            this.SelectFilePathButton.Click += new System.EventHandler(this.selectPathClick);
            // 
            // DecryptButton
            // 
            this.DecryptButton.Location = new System.Drawing.Point(6, 60);
            this.DecryptButton.Name = "DecryptButton";
            this.DecryptButton.Size = new System.Drawing.Size(102, 23);
            this.DecryptButton.TabIndex = 2;
            this.DecryptButton.Text = "Decrypt!";
            this.DecryptButton.UseVisualStyleBackColor = true;
            this.DecryptButton.Click += new System.EventHandler(this.DecryptButton_Click);
            // 
            // PathHintLabel
            // 
            this.PathHintLabel.AutoSize = true;
            this.PathHintLabel.Location = new System.Drawing.Point(3, 18);
            this.PathHintLabel.Name = "PathHintLabel";
            this.PathHintLabel.Size = new System.Drawing.Size(101, 13);
            this.PathHintLabel.TabIndex = 1;
            this.PathHintLabel.Text = "Path to the save file";
            // 
            // PathTextBox
            // 
            this.PathTextBox.Location = new System.Drawing.Point(6, 34);
            this.PathTextBox.Name = "PathTextBox";
            this.PathTextBox.Size = new System.Drawing.Size(332, 20);
            this.PathTextBox.TabIndex = 0;
            // 
            // SaveLocationHint
            // 
            this.SaveLocationHint.AutoSize = true;
            this.SaveLocationHint.Location = new System.Drawing.Point(6, 86);
            this.SaveLocationHint.Name = "SaveLocationHint";
            this.SaveLocationHint.Size = new System.Drawing.Size(290, 13);
            this.SaveLocationHint.TabIndex = 4;
            this.SaveLocationHint.Text = "Decrypted save file can be located in application\'s directory!";
            // 
            // EncryptGroup
            // 
            this.EncryptGroup.Controls.Add(this.label3);
            this.EncryptGroup.Controls.Add(this.label2);
            this.EncryptGroup.Controls.Add(this.label1);
            this.EncryptGroup.Controls.Add(this.button1);
            this.EncryptGroup.Controls.Add(this.OpenBtnEncrypt);
            this.EncryptGroup.Controls.Add(this.PathTextBoxEncrypt);
            this.EncryptGroup.Controls.Add(this.HintDecodedFileLocation);
            this.EncryptGroup.Location = new System.Drawing.Point(12, 131);
            this.EncryptGroup.Name = "EncryptGroup";
            this.EncryptGroup.Size = new System.Drawing.Size(425, 160);
            this.EncryptGroup.TabIndex = 1;
            this.EncryptGroup.TabStop = false;
            this.EncryptGroup.Text = "Encrypt";
            // 
            // HintDecodedFileLocation
            // 
            this.HintDecodedFileLocation.AutoSize = true;
            this.HintDecodedFileLocation.Location = new System.Drawing.Point(3, 20);
            this.HintDecodedFileLocation.Name = "HintDecodedFileLocation";
            this.HintDecodedFileLocation.Size = new System.Drawing.Size(298, 13);
            this.HintDecodedFileLocation.TabIndex = 0;
            this.HintDecodedFileLocation.Text = "Path to the decoded save file, default is usually good enough.";
            // 
            // PathTextBoxEncrypt
            // 
            this.PathTextBoxEncrypt.Location = new System.Drawing.Point(6, 36);
            this.PathTextBoxEncrypt.Name = "PathTextBoxEncrypt";
            this.PathTextBoxEncrypt.Size = new System.Drawing.Size(332, 20);
            this.PathTextBoxEncrypt.TabIndex = 1;
            // 
            // OpenBtnEncrypt
            // 
            this.OpenBtnEncrypt.Location = new System.Drawing.Point(344, 33);
            this.OpenBtnEncrypt.Name = "OpenBtnEncrypt";
            this.OpenBtnEncrypt.Size = new System.Drawing.Size(75, 23);
            this.OpenBtnEncrypt.TabIndex = 2;
            this.OpenBtnEncrypt.Text = "Open...";
            this.OpenBtnEncrypt.UseVisualStyleBackColor = true;
            this.OpenBtnEncrypt.Click += new System.EventHandler(this.OpenBtnEncrypt_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 63);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Encrypt";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Pressing this button will overwrite your current save file.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(274, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Please, make a backup before overwriting your save file.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(370, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "If you want to write save data elsewhere, change the path in decrypt section,";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 301);
            this.Controls.Add(this.EncryptGroup);
            this.Controls.Add(this.DecryptGroup);
            this.Name = "Form1";
            this.Text = "BBCR Save file decryptor/encryptor";
            this.DecryptGroup.ResumeLayout(false);
            this.DecryptGroup.PerformLayout();
            this.EncryptGroup.ResumeLayout(false);
            this.EncryptGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox DecryptGroup;
        private System.Windows.Forms.Button SelectFilePathButton;
        private System.Windows.Forms.Button DecryptButton;
        private System.Windows.Forms.Label PathHintLabel;
        private System.Windows.Forms.TextBox PathTextBox;
        private System.Windows.Forms.Label SaveLocationHint;
        private System.Windows.Forms.GroupBox EncryptGroup;
        private System.Windows.Forms.Button OpenBtnEncrypt;
        private System.Windows.Forms.TextBox PathTextBoxEncrypt;
        private System.Windows.Forms.Label HintDecodedFileLocation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
    }
}

