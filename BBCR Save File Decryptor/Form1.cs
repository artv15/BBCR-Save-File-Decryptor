using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UnityCipher;

namespace BBCR_Save_File_Decryptor
{
    public partial class Form1 : Form
    {
        private OpenFileDialog openFileDialog = new OpenFileDialog();

        public Form1()
        {
            InitializeComponent();
            PathTextBoxEncrypt.Text = Directory.GetCurrentDirectory() + @"\decryptedSave.txt";
        }

        private void selectPathClick(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                PathTextBox.Text = openFileDialog.FileName;
            }
        }

        private void DecryptButton_Click(object sender, EventArgs e)
        {
            if (PathTextBox.Text != "")
            {
                try
                {
                    string fileData = RijndaelEncryption.Decrypt(File.ReadAllText(PathTextBox.Text), "!UnassignedFile");
                    File.WriteAllText(Directory.GetCurrentDirectory() + @"\decryptedSave.txt", fileData);
                    MessageBox.Show($"Success! Decrypted save file can be located at {Directory.GetCurrentDirectory() + @"\decryptedSave.txt"}", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An exception occured during save file decryption! Exception: {ex.Message}.", "Oops!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void OpenBtnEncrypt_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                PathTextBoxEncrypt.Text = openFileDialog.FileName;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (PathTextBoxEncrypt.Text != "")
            {
                try
                {
                    string saveText = RijndaelEncryption.Encrypt(File.ReadAllText(PathTextBoxEncrypt.Text), "!UnassignedFile");
                    File.WriteAllText(PathTextBox.Text, saveText);
                    MessageBox.Show($"Success! Encrypted save file can be located at {PathTextBoxEncrypt.Text}", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An exception occured during save file encryption! Exception: {ex.Message}.", "Oops!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
