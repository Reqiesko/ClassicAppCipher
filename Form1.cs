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
using System.Text.RegularExpressions;

namespace Lab2
{
    enum method
    {
        playfair,
        rot
    };
    public partial class Form1 : Form
    {
        Playfair incodePlayfair = new();
        ROT13 incodeRot = new();
        public Form1()
        {
            InitializeComponent();
            incodeText.Enabled = false;
            incodeButton.Enabled = false;
            decodeButton.Enabled = false;
            keyText.Enabled = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            keyText.Clear();
            incodeText.Enabled = true;
            incodeButton.Enabled = true;
            decodeButton.Enabled = true;
            int var = comboBox1.SelectedIndex;
            switch (var)
            {
                case (int)method.playfair:
                    keyText.Enabled = true;
                    break;
                case (int)method.rot:
                    keyText.Enabled = false;
                    break;
            }

        }
        public const string alphabet = "АБВГДЕЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";
        private void incodeButton_Click(object sender, EventArgs e)
        {
            outText.Clear();
            int var = comboBox1.SelectedIndex;
            string key = keyText.Text;
            string text = incodeText.Text;
            string cipherText = "";
            try
            {
                switch (var)
                {
                    case (int)method.playfair:
                        cipherText = incodePlayfair.Incode(text, key);
                        break;
                    case (int)method.rot:
                        cipherText = incodeRot.Incode(text);
                        break;
                }
                outText.Text += cipherText;
            }
            catch
            {
                MessageBox.Show("Only Latin is available");
            }
        }
        
        private void decodeButton_Click(object sender, EventArgs e)
        {
            outText.Clear();
            int var = comboBox1.SelectedIndex;
            string key = keyText.Text;
            string text = incodeText.Text;
            string cipherText = "";
            try
            {
                switch (var)
                {
                    case (int)method.playfair:
                        cipherText = incodePlayfair.Decode(text, key);
                        break;
                    case (int)method.rot:
                        cipherText = incodeRot.Decode(text);
                        break;
                }
                outText.Text += cipherText;
            }
            catch
            {
                MessageBox.Show("Only Latin is available");
            }
        }

        private void keyText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 'A' && e.KeyChar <= 'Z') || (e.KeyChar >= 'a' && e.KeyChar <= 'z') || (e.KeyChar == ' ') || e.KeyChar == (char)Keys.Back)
            {
            }
            else
            {
                e.Handled = true;
            }
        }

        private void incodeText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 'A' && e.KeyChar <= 'Z') || (e.KeyChar >= 'a' && e.KeyChar <= 'z') || (e.KeyChar == ' ') || e.KeyChar == (char)Keys.Back)
            {
            }
            else
            {
                e.Handled = true;
            }
        }

        private void inputFromFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool check = false;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                incodeText.Clear();
                StreamReader sr = new StreamReader(openFileDialog1.FileName);
                string tempStr = sr.ReadToEnd();
                Regex regNum = new Regex(@"[\d]"); 
                Match num = regNum.Match(tempStr);
                Regex regRU = new Regex(@"[А-Яа-я]");
                Match textRu = regRU.Match(tempStr);
                for (int i = 0; i < tempStr.Length; i++)
                { 
                    if (num.Success)
                    {
                        MessageBox.Show("Invalid file");
                        check = true;
                        break;
                    }
                    if (textRu.Success)
                    {
                        MessageBox.Show("Invalid file");
                        check = true;
                        break;
                    }
                    num = num.NextMatch();
                    textRu = textRu.NextMatch();
                }
                if (!check) incodeText.Text += tempStr;
                sr.Close();
            }
        }

        private void keyText_TextChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < keyText.Text.Length; i++)
            {
                if (alphabet.Contains(keyText.Text[i]))
                {
                    MessageBox.Show("Only Latin is available");
                    keyText.Clear();
                    break;
                }
            }
        }

        private void incodeText_TextChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < incodeText.Text.Length; i++)
            {
                if (alphabet.Contains(incodeText.Text[i]))
                {
                    MessageBox.Show("Only Latin is available");
                    incodeText.Clear();
                    break;
                }
            }
        }

        private void saveResultsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sr = new StreamWriter(saveFileDialog1.FileName);
                sr.Write(outText.Text);
                sr.Close();
            }
        }

        private void saveSourceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sr = new StreamWriter(saveFileDialog1.FileName);
                sr.Write(incodeText.Text);
                sr.Close();
            }
        }

        private void aboutProgrammToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
               "Автор: Нерадовский Артемий, 494 группа. \nПрограмма позволяет шифровать и дешифровать сообщения методами Плейфера и ROT13.",
               "About Programm",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
