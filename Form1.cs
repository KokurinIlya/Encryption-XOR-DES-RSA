using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

using System.IO;

namespace Encryption
{
    public partial class EncryptedText : Form
    {
        public EncryptedText()
        {
            InitializeComponent();
        }

        public String EnText;
        public String KeyText;
        public String KeyTextn;
        public String KeyTexte;
        public String KeyTextd;

        private void buttonParentSave_Click(object sender, EventArgs e)
        {
            if (saveFileDialogParent.ShowDialog() == DialogResult.OK)
            {
                String filePath;
                filePath = saveFileDialogParent.FileName;
                StreamWriter file = new StreamWriter(filePath, true);
                file.Write(textBoxPlaintext.Text);
                file.Close();
                MessageBox.Show(this, "Файл успешно сохранён", "Сообщение", MessageBoxButtons.OK);
            }
        }
        private void buttonParentLoad_Click(object sender, EventArgs e)
        {
            if (openFileDialogParent.ShowDialog() == DialogResult.OK)
            {
                String filePath;
                filePath = openFileDialogParent.FileName;
                StreamReader file = new StreamReader(filePath);
                String TextParent = file.ReadToEnd();
                file.Close();
                textBoxPlaintext.Text = TextParent;
                MessageBox.Show(this, "Файл успешно загружен", "Сообщение", MessageBoxButtons.OK);
            }
        }
        private void buttonParentClear_Click(object sender, EventArgs e)
        {
            textBoxPlaintext.Text = "";
        }
        private void buttonEncryptedSave_Click(object sender, EventArgs e)
        {
            if (saveFileDialogEncrypted.ShowDialog() == DialogResult.OK)
            {
                String filePath;
                filePath = saveFileDialogEncrypted.FileName;
                StreamWriter file = new StreamWriter(filePath, true);
                file.Write(EnText);
                file.Close();
                MessageBox.Show(this, "Файл успешно сохранён", "Сообщение", MessageBoxButtons.OK);
            }
        }
        private void buttonEncryptedLoad_Click(object sender, EventArgs e)
        {
            if (openFileDialogEncrypted.ShowDialog() == DialogResult.OK)
            {
                EnText = "";
                String filePath;
                filePath = openFileDialogEncrypted.FileName;
                StreamReader file = new StreamReader(filePath);
                EnText = file.ReadToEnd();
                file.Close();
                textBoxCiphertext.Text = EnText;
                MessageBox.Show(this, "Файл успешно загружен", "Сообщение", MessageBoxButtons.OK);
            }
        }
        private void buttonEncryptedClear_Click(object sender, EventArgs e)
        {
            textBoxCiphertext.Text = "";
        }


        private void buttonKeyGen_Click(object sender, EventArgs e)
        {
            Random randomKeyElement = new Random();
            StringBuilder key = new StringBuilder();
            
            for (int i = 0; i < 8; i++)
            {
                key.Append((char)randomKeyElement.Next(0, 255));
            }

            KeyText = key.ToString();
            textBoxKey.Text = KeyText;
        }

        private void buttonAction_Click(object sender, EventArgs e)
        {
            if (radioButtonXOR.Checked && radioButtonEncrypt.Checked)
            {
                String ParentText = textBoxPlaintext.Text ;
                String Key = textBoxKey.Text;

                int blockSize = Key.Length;

                StringBuilder EncryptedText = new StringBuilder();


                for (int i = 0; i < ParentText.Length; i++)
                {
                    EncryptedText.Append((char)(ParentText[i] ^ Key[i % blockSize]));
                }

                EnText = "";
                EnText = EncryptedText.ToString();
                textBoxCiphertext.Text = EnText;
            }
            else if (radioButtonXOR.Checked && radioButtonDecrypt.Checked)
            {
                String EncryptedText = textBoxCiphertext.Text;
                String Key = textBoxKey.Text;

                int blockSize = Key.Length;

                StringBuilder ParentText = new StringBuilder();


                for (int i = 0; i < EncryptedText.Length; i++)
                {
                    ParentText.Append((char)(EncryptedText[i] ^ Key[i % blockSize]));
                }

                textBoxPlaintext.Text = ParentText.ToString();
            }
            else if (radioButtonDES.Checked && radioButtonEncrypt.Checked)
            {
                String ParentText = textBoxPlaintext.Text;
                String ParentKey;
                if (checkBoxWriteKey.Checked)
                {
                    ParentKey = textBoxKey.Text;
                }
                else
                {
                    ParentKey = KeyText;
                }
                int len = (ParentKey.Length - ParentText.Length % ParentKey.Length) % ParentKey.Length;
                for (int i = 0; i < len; i++)
                {
                    ParentText += " ";
                }
                EnText = "";
                EnText = DES.Des(ParentText, ParentKey);
                textBoxCiphertext.Text = EnText; //DES.Des(ParentText, ParentKey);
            }
            else if (radioButtonDES.Checked && radioButtonDecrypt.Checked)
            {
                //String EncryptedText = textBoxCiphertext.Text;
                String ParentKey;
                if (checkBoxWriteKey.Checked)
                {
                    ParentKey = textBoxKey.Text;
                }
                else
                {
                    ParentKey = KeyText;
                }
                //int len = (ParentKey.Length - EncryptedText.Length % ParentKey.Length) % ParentKey.Length;
                //for (int i = 0; i < len; i++)
                //{
                //    EncryptedText += " ";
                //}
                textBoxPlaintext.Text = DES.DesRev(EnText, ParentKey);
            }
            else if (radioButtonRSA.Checked && radioButtonEncrypt.Checked)
            {
                String eKey = textBoxRSAe.Text;
                String nKey = textBoxRSAn.Text;
                String ParentText = textBoxPlaintext.Text;
                EnText = "";
                EnText = RSA.RSAEncrypt(ParentText, eKey, nKey);
                textBoxCiphertext.Text = EnText;
            }
            else if (radioButtonRSA.Checked && radioButtonDecrypt.Checked)
            {
                String nKey = textBoxRSAn.Text;
                String dKey = textBoxRSAd.Text;
                //String CipherText = textBoxCiphertext.Text;
                textBoxPlaintext.Text = RSA.RSADecrypt(EnText, dKey, nKey);
            }
        }

        private void buttonKeySave_Click(object sender, EventArgs e)
        {
            if (saveFileDialogKey.ShowDialog() == DialogResult.OK)
            {
                if (checkBoxWriteKey.Checked)
                {
                    KeyText = textBoxKey.Text;
                }
                String filePath;
                filePath = saveFileDialogKey.FileName;
                StreamWriter file = new StreamWriter(filePath, true);
                file.Write(KeyText);
                file.Close();
                MessageBox.Show(this, "Ключ успешно сохранён", "Сообщение", MessageBoxButtons.OK);
            }
        }
        private void buttonKeyLoad_Click(object sender, EventArgs e)
        {
            if (openFileDialogKey.ShowDialog() == DialogResult.OK)
            {
                KeyText = "";
                String filePath;
                filePath = openFileDialogKey.FileName;
                StreamReader file = new StreamReader(filePath);
                KeyText = file.ReadToEnd();
                file.Close();
                textBoxKey.Text = KeyText;
                MessageBox.Show(this, "Ключ успешно загружен", "Сообщение", MessageBoxButtons.OK);
            }
        }
        private void buttonKeyClear_Click(object sender, EventArgs e)
        {
            textBoxKey.Text = "";
            KeyText = "";
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxWriteKey.Checked)
            {
                textBoxKey.ReadOnly = false;
                buttonKeyGen.Enabled = false;
            }
            else
            {
                textBoxKey.ReadOnly = true;
                buttonKeyGen.Enabled = true;
            }
        }

        private void buttonRSAkey_Click(object sender, EventArgs e)
        {
            textBoxRSAn.Text = "";
            textBoxRSAe.Text = "";
            textBoxRSAd.Text = "";
            Random random = new Random();
            uint p,q,n,eKey,dKey;

            do
            {
                //тесты Ферма
                do
                {
                    p = (uint)(random.Next(32768, 65536));
                } while (!RSA.FermatPrimalityTest(p));
                do
                {
                    q = (uint)(random.Next(32768, 65536));
                } while (!RSA.FermatPrimalityTest(q));

                n = p * q;
                uint Phi = (p - 1) * (q - 1);//Функция Эйлера 

                //генерируем e
                do
                {
                    eKey = (uint)random.Next(0, int.MaxValue);
                } while (RSA.GCD(eKey, Phi) != 1);

                dKey = RSA.Extend_GCD(eKey, Phi);
            } while (dKey>=n);
            KeyTextn = n.ToString();
            KeyTexte = eKey.ToString();
            KeyTextd = dKey.ToString();

            textBoxRSAn.Text = KeyTextn;
            textBoxRSAe.Text = KeyTexte;
            textBoxRSAd.Text = KeyTextd;
        }

        private void buttonRSA_load_n_Click(object sender, EventArgs e)
        {
            if (openFileDialogRSAn.ShowDialog() == DialogResult.OK)
            {
                KeyTextn = "";
                String filePath;
                filePath = openFileDialogRSAn.FileName;
                StreamReader file = new StreamReader(filePath);
                KeyTextn = file.ReadToEnd();
                file.Close();
                textBoxRSAn.Text = KeyTextn;
                MessageBox.Show(this, "Ключ успешно загружен", "Сообщение", MessageBoxButtons.OK);
            }
        }

        private void buttonRSA_load_e_Click(object sender, EventArgs e)
        {
            if (openFileDialogRSAe.ShowDialog() == DialogResult.OK)
            {
                KeyTexte = "";
                String filePath;
                filePath = openFileDialogRSAe.FileName;
                StreamReader file = new StreamReader(filePath);
                KeyTexte = file.ReadToEnd();
                file.Close();
                textBoxRSAe.Text = KeyTexte;
                MessageBox.Show(this, "Ключ успешно загружен", "Сообщение", MessageBoxButtons.OK);
            }
        }

        private void buttonRSA_load_d_Click(object sender, EventArgs e)
        {
            if (openFileDialogRSAd.ShowDialog() == DialogResult.OK)
            {
                KeyTextd = "";
                String filePath;
                filePath = openFileDialogRSAd.FileName;
                StreamReader file = new StreamReader(filePath);
                KeyTextd = file.ReadToEnd();
                file.Close();
                textBoxRSAd.Text = KeyTextd;
                MessageBox.Show(this, "Ключ успешно загружен", "Сообщение", MessageBoxButtons.OK);
            }
        }

        private void buttonRSA_save_n_Click(object sender, EventArgs e)
        {
            if (saveFileDialogRSAn.ShowDialog() == DialogResult.OK)
            {
                KeyTextn = textBoxRSAn.Text;
                String filePath;
                filePath = saveFileDialogRSAn.FileName;
                StreamWriter file = new StreamWriter(filePath, true);
                file.Write(KeyTextn);
                file.Close();
                MessageBox.Show(this, "Ключ успешно сохранён", "Сообщение", MessageBoxButtons.OK);
            }
        }

        private void buttonRSA_save_e_Click(object sender, EventArgs e)
        {
            if (saveFileDialogRSAe.ShowDialog() == DialogResult.OK)
            {
                KeyTexte = textBoxRSAe.Text;
                String filePath;
                filePath = saveFileDialogRSAe.FileName;
                StreamWriter file = new StreamWriter(filePath, true);
                file.Write(KeyTexte);
                file.Close();
                MessageBox.Show(this, "Ключ успешно сохранён", "Сообщение", MessageBoxButtons.OK);
            }
            
        }

        private void buttonRSA_save_d_Click(object sender, EventArgs e)
        {
            if (saveFileDialogRSAd.ShowDialog() == DialogResult.OK)
            {
                KeyTextd = textBoxRSAd.Text;
                String filePath;
                filePath = saveFileDialogRSAd.FileName;
                StreamWriter file = new StreamWriter(filePath, true);
                file.Write(KeyTextd);
                file.Close();
                MessageBox.Show(this, "Ключ успешно сохранён", "Сообщение", MessageBoxButtons.OK);
            }
        }
    }
}
