
namespace Encryption
{
    partial class EncryptedText
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
            this.textBoxPlaintext = new System.Windows.Forms.TextBox();
            this.labelPlaintext = new System.Windows.Forms.Label();
            this.buttonParentSave = new System.Windows.Forms.Button();
            this.buttonParentLoad = new System.Windows.Forms.Button();
            this.buttonParentClear = new System.Windows.Forms.Button();
            this.buttonEncryptedClear = new System.Windows.Forms.Button();
            this.buttonEncryptedLoad = new System.Windows.Forms.Button();
            this.buttonEncryptedSave = new System.Windows.Forms.Button();
            this.labelCiphertext = new System.Windows.Forms.Label();
            this.textBoxCiphertext = new System.Windows.Forms.TextBox();
            this.labelKey = new System.Windows.Forms.Label();
            this.textBoxKey = new System.Windows.Forms.TextBox();
            this.buttonKeyGen = new System.Windows.Forms.Button();
            this.buttonAction = new System.Windows.Forms.Button();
            this.radioButtonEncrypt = new System.Windows.Forms.RadioButton();
            this.radioButtonXOR = new System.Windows.Forms.RadioButton();
            this.saveFileDialogParent = new System.Windows.Forms.SaveFileDialog();
            this.saveFileDialogEncrypted = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialogParent = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialogEncrypted = new System.Windows.Forms.OpenFileDialog();
            this.buttonKeySave = new System.Windows.Forms.Button();
            this.buttonKeyLoad = new System.Windows.Forms.Button();
            this.buttonKeyClear = new System.Windows.Forms.Button();
            this.saveFileDialogKey = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialogKey = new System.Windows.Forms.OpenFileDialog();
            this.radioButtonDES = new System.Windows.Forms.RadioButton();
            this.radioButtonDecrypt = new System.Windows.Forms.RadioButton();
            this.checkBoxWriteKey = new System.Windows.Forms.CheckBox();
            this.radioButtonRSA = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxRSAn = new System.Windows.Forms.TextBox();
            this.textBoxRSAe = new System.Windows.Forms.TextBox();
            this.textBoxRSAd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonRSAkey = new System.Windows.Forms.Button();
            this.buttonRSA_load_d = new System.Windows.Forms.Button();
            this.buttonRSA_save_d = new System.Windows.Forms.Button();
            this.buttonRSA_load_n = new System.Windows.Forms.Button();
            this.buttonRSA_save_n = new System.Windows.Forms.Button();
            this.buttonRSA_load_e = new System.Windows.Forms.Button();
            this.buttonRSA_save_e = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.saveFileDialogRSAn = new System.Windows.Forms.SaveFileDialog();
            this.saveFileDialogRSAe = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialogRSAn = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialogRSAd = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialogRSAe = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialogRSAd = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxPlaintext
            // 
            this.textBoxPlaintext.Location = new System.Drawing.Point(56, 132);
            this.textBoxPlaintext.Multiline = true;
            this.textBoxPlaintext.Name = "textBoxPlaintext";
            this.textBoxPlaintext.Size = new System.Drawing.Size(528, 454);
            this.textBoxPlaintext.TabIndex = 0;
            this.textBoxPlaintext.Text = "Encrypt this text.";
            // 
            // labelPlaintext
            // 
            this.labelPlaintext.AutoSize = true;
            this.labelPlaintext.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPlaintext.Location = new System.Drawing.Point(270, 43);
            this.labelPlaintext.Name = "labelPlaintext";
            this.labelPlaintext.Size = new System.Drawing.Size(98, 27);
            this.labelPlaintext.TabIndex = 1;
            this.labelPlaintext.Text = "Plaintext";
            // 
            // buttonParentSave
            // 
            this.buttonParentSave.Location = new System.Drawing.Point(56, 86);
            this.buttonParentSave.Name = "buttonParentSave";
            this.buttonParentSave.Size = new System.Drawing.Size(172, 33);
            this.buttonParentSave.TabIndex = 2;
            this.buttonParentSave.Text = "Save";
            this.buttonParentSave.UseVisualStyleBackColor = true;
            this.buttonParentSave.Click += new System.EventHandler(this.buttonParentSave_Click);
            // 
            // buttonParentLoad
            // 
            this.buttonParentLoad.Location = new System.Drawing.Point(234, 86);
            this.buttonParentLoad.Name = "buttonParentLoad";
            this.buttonParentLoad.Size = new System.Drawing.Size(172, 33);
            this.buttonParentLoad.TabIndex = 3;
            this.buttonParentLoad.Text = "Load";
            this.buttonParentLoad.UseVisualStyleBackColor = true;
            this.buttonParentLoad.Click += new System.EventHandler(this.buttonParentLoad_Click);
            // 
            // buttonParentClear
            // 
            this.buttonParentClear.Location = new System.Drawing.Point(412, 86);
            this.buttonParentClear.Name = "buttonParentClear";
            this.buttonParentClear.Size = new System.Drawing.Size(172, 33);
            this.buttonParentClear.TabIndex = 4;
            this.buttonParentClear.Text = "Clear";
            this.buttonParentClear.UseVisualStyleBackColor = true;
            this.buttonParentClear.Click += new System.EventHandler(this.buttonParentClear_Click);
            // 
            // buttonEncryptedClear
            // 
            this.buttonEncryptedClear.Location = new System.Drawing.Point(1046, 86);
            this.buttonEncryptedClear.Name = "buttonEncryptedClear";
            this.buttonEncryptedClear.Size = new System.Drawing.Size(172, 33);
            this.buttonEncryptedClear.TabIndex = 9;
            this.buttonEncryptedClear.Text = "Clear";
            this.buttonEncryptedClear.UseVisualStyleBackColor = true;
            this.buttonEncryptedClear.Click += new System.EventHandler(this.buttonEncryptedClear_Click);
            // 
            // buttonEncryptedLoad
            // 
            this.buttonEncryptedLoad.Location = new System.Drawing.Point(868, 86);
            this.buttonEncryptedLoad.Name = "buttonEncryptedLoad";
            this.buttonEncryptedLoad.Size = new System.Drawing.Size(172, 33);
            this.buttonEncryptedLoad.TabIndex = 8;
            this.buttonEncryptedLoad.Text = "Load";
            this.buttonEncryptedLoad.UseVisualStyleBackColor = true;
            this.buttonEncryptedLoad.Click += new System.EventHandler(this.buttonEncryptedLoad_Click);
            // 
            // buttonEncryptedSave
            // 
            this.buttonEncryptedSave.Location = new System.Drawing.Point(690, 86);
            this.buttonEncryptedSave.Name = "buttonEncryptedSave";
            this.buttonEncryptedSave.Size = new System.Drawing.Size(172, 33);
            this.buttonEncryptedSave.TabIndex = 7;
            this.buttonEncryptedSave.Text = "Save";
            this.buttonEncryptedSave.UseVisualStyleBackColor = true;
            this.buttonEncryptedSave.Click += new System.EventHandler(this.buttonEncryptedSave_Click);
            // 
            // labelCiphertext
            // 
            this.labelCiphertext.AutoSize = true;
            this.labelCiphertext.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCiphertext.Location = new System.Drawing.Point(894, 43);
            this.labelCiphertext.Name = "labelCiphertext";
            this.labelCiphertext.Size = new System.Drawing.Size(114, 27);
            this.labelCiphertext.TabIndex = 6;
            this.labelCiphertext.Text = "Ciphertext";
            // 
            // textBoxCiphertext
            // 
            this.textBoxCiphertext.Location = new System.Drawing.Point(690, 132);
            this.textBoxCiphertext.Multiline = true;
            this.textBoxCiphertext.Name = "textBoxCiphertext";
            this.textBoxCiphertext.ReadOnly = true;
            this.textBoxCiphertext.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxCiphertext.Size = new System.Drawing.Size(528, 454);
            this.textBoxCiphertext.TabIndex = 5;
            // 
            // labelKey
            // 
            this.labelKey.AutoSize = true;
            this.labelKey.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelKey.Location = new System.Drawing.Point(32, 35);
            this.labelKey.Name = "labelKey";
            this.labelKey.Size = new System.Drawing.Size(42, 19);
            this.labelKey.TabIndex = 11;
            this.labelKey.Text = "Key:";
            // 
            // textBoxKey
            // 
            this.textBoxKey.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxKey.Location = new System.Drawing.Point(92, 32);
            this.textBoxKey.Name = "textBoxKey";
            this.textBoxKey.ReadOnly = true;
            this.textBoxKey.Size = new System.Drawing.Size(135, 27);
            this.textBoxKey.TabIndex = 12;
            // 
            // buttonKeyGen
            // 
            this.buttonKeyGen.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonKeyGen.Location = new System.Drawing.Point(36, 71);
            this.buttonKeyGen.Name = "buttonKeyGen";
            this.buttonKeyGen.Size = new System.Drawing.Size(376, 30);
            this.buttonKeyGen.TabIndex = 13;
            this.buttonKeyGen.Text = "DES key generation";
            this.buttonKeyGen.UseVisualStyleBackColor = true;
            this.buttonKeyGen.Click += new System.EventHandler(this.buttonKeyGen_Click);
            // 
            // buttonAction
            // 
            this.buttonAction.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAction.Location = new System.Drawing.Point(850, 725);
            this.buttonAction.Name = "buttonAction";
            this.buttonAction.Size = new System.Drawing.Size(369, 41);
            this.buttonAction.TabIndex = 14;
            this.buttonAction.Text = "OK";
            this.buttonAction.UseVisualStyleBackColor = true;
            this.buttonAction.Click += new System.EventHandler(this.buttonAction_Click);
            // 
            // radioButtonEncrypt
            // 
            this.radioButtonEncrypt.AutoSize = true;
            this.radioButtonEncrypt.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonEncrypt.Location = new System.Drawing.Point(22, 35);
            this.radioButtonEncrypt.Name = "radioButtonEncrypt";
            this.radioButtonEncrypt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.radioButtonEncrypt.Size = new System.Drawing.Size(83, 23);
            this.radioButtonEncrypt.TabIndex = 15;
            this.radioButtonEncrypt.TabStop = true;
            this.radioButtonEncrypt.Text = "Encrypt";
            this.radioButtonEncrypt.UseVisualStyleBackColor = true;
            // 
            // radioButtonXOR
            // 
            this.radioButtonXOR.AutoSize = true;
            this.radioButtonXOR.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonXOR.Location = new System.Drawing.Point(27, 35);
            this.radioButtonXOR.Name = "radioButtonXOR";
            this.radioButtonXOR.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radioButtonXOR.Size = new System.Drawing.Size(69, 23);
            this.radioButtonXOR.TabIndex = 16;
            this.radioButtonXOR.TabStop = true;
            this.radioButtonXOR.Text = " XOR";
            this.radioButtonXOR.UseVisualStyleBackColor = true;
            // 
            // openFileDialogParent
            // 
            this.openFileDialogParent.FileName = "openFileDialog1";
            // 
            // openFileDialogEncrypted
            // 
            this.openFileDialogEncrypted.FileName = "openFileDialog1";
            // 
            // buttonKeySave
            // 
            this.buttonKeySave.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonKeySave.Location = new System.Drawing.Point(36, 107);
            this.buttonKeySave.Name = "buttonKeySave";
            this.buttonKeySave.Size = new System.Drawing.Size(113, 33);
            this.buttonKeySave.TabIndex = 17;
            this.buttonKeySave.Text = "Save";
            this.buttonKeySave.UseVisualStyleBackColor = true;
            this.buttonKeySave.Click += new System.EventHandler(this.buttonKeySave_Click);
            // 
            // buttonKeyLoad
            // 
            this.buttonKeyLoad.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonKeyLoad.Location = new System.Drawing.Point(169, 107);
            this.buttonKeyLoad.Name = "buttonKeyLoad";
            this.buttonKeyLoad.Size = new System.Drawing.Size(113, 33);
            this.buttonKeyLoad.TabIndex = 18;
            this.buttonKeyLoad.Text = "Load";
            this.buttonKeyLoad.UseVisualStyleBackColor = true;
            this.buttonKeyLoad.Click += new System.EventHandler(this.buttonKeyLoad_Click);
            // 
            // buttonKeyClear
            // 
            this.buttonKeyClear.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonKeyClear.Location = new System.Drawing.Point(299, 107);
            this.buttonKeyClear.Name = "buttonKeyClear";
            this.buttonKeyClear.Size = new System.Drawing.Size(113, 33);
            this.buttonKeyClear.TabIndex = 19;
            this.buttonKeyClear.Text = "Clear";
            this.buttonKeyClear.UseVisualStyleBackColor = true;
            this.buttonKeyClear.Click += new System.EventHandler(this.buttonKeyClear_Click);
            // 
            // openFileDialogKey
            // 
            this.openFileDialogKey.FileName = "openFileDialog1";
            // 
            // radioButtonDES
            // 
            this.radioButtonDES.AutoSize = true;
            this.radioButtonDES.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonDES.Location = new System.Drawing.Point(27, 64);
            this.radioButtonDES.Name = "radioButtonDES";
            this.radioButtonDES.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radioButtonDES.Size = new System.Drawing.Size(69, 23);
            this.radioButtonDES.TabIndex = 20;
            this.radioButtonDES.TabStop = true;
            this.radioButtonDES.Text = "  DES";
            this.radioButtonDES.UseVisualStyleBackColor = true;
            // 
            // radioButtonDecrypt
            // 
            this.radioButtonDecrypt.AutoSize = true;
            this.radioButtonDecrypt.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonDecrypt.Location = new System.Drawing.Point(22, 64);
            this.radioButtonDecrypt.Name = "radioButtonDecrypt";
            this.radioButtonDecrypt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.radioButtonDecrypt.Size = new System.Drawing.Size(85, 23);
            this.radioButtonDecrypt.TabIndex = 21;
            this.radioButtonDecrypt.TabStop = true;
            this.radioButtonDecrypt.Text = "Decrypt";
            this.radioButtonDecrypt.UseVisualStyleBackColor = true;
            // 
            // checkBoxWriteKey
            // 
            this.checkBoxWriteKey.AutoSize = true;
            this.checkBoxWriteKey.Location = new System.Drawing.Point(276, 36);
            this.checkBoxWriteKey.Name = "checkBoxWriteKey";
            this.checkBoxWriteKey.Size = new System.Drawing.Size(104, 23);
            this.checkBoxWriteKey.TabIndex = 24;
            this.checkBoxWriteKey.Text = "Write key";
            this.checkBoxWriteKey.UseVisualStyleBackColor = true;
            this.checkBoxWriteKey.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // radioButtonRSA
            // 
            this.radioButtonRSA.AutoSize = true;
            this.radioButtonRSA.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonRSA.Location = new System.Drawing.Point(27, 93);
            this.radioButtonRSA.Name = "radioButtonRSA";
            this.radioButtonRSA.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radioButtonRSA.Size = new System.Drawing.Size(69, 23);
            this.radioButtonRSA.TabIndex = 25;
            this.radioButtonRSA.TabStop = true;
            this.radioButtonRSA.Text = "  RSA";
            this.radioButtonRSA.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonXOR);
            this.groupBox1.Controls.Add(this.radioButtonRSA);
            this.groupBox1.Controls.Add(this.radioButtonDES);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(850, 596);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 123);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Encryption algorithm";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButtonEncrypt);
            this.groupBox2.Controls.Add(this.radioButtonDecrypt);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(1072, 596);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(147, 123);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Operation";
            // 
            // textBoxRSAn
            // 
            this.textBoxRSAn.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxRSAn.Location = new System.Drawing.Point(37, 75);
            this.textBoxRSAn.Name = "textBoxRSAn";
            this.textBoxRSAn.ReadOnly = true;
            this.textBoxRSAn.Size = new System.Drawing.Size(135, 27);
            this.textBoxRSAn.TabIndex = 28;
            // 
            // textBoxRSAe
            // 
            this.textBoxRSAe.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxRSAe.Location = new System.Drawing.Point(37, 108);
            this.textBoxRSAe.Name = "textBoxRSAe";
            this.textBoxRSAe.ReadOnly = true;
            this.textBoxRSAe.Size = new System.Drawing.Size(135, 27);
            this.textBoxRSAe.TabIndex = 29;
            // 
            // textBoxRSAd
            // 
            this.textBoxRSAd.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxRSAd.Location = new System.Drawing.Point(37, 141);
            this.textBoxRSAd.Name = "textBoxRSAd";
            this.textBoxRSAd.ReadOnly = true;
            this.textBoxRSAd.Size = new System.Drawing.Size(135, 27);
            this.textBoxRSAd.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(9, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 19);
            this.label1.TabIndex = 31;
            this.label1.Text = "n:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(9, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 19);
            this.label2.TabIndex = 32;
            this.label2.Text = "e:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(9, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 19);
            this.label3.TabIndex = 33;
            this.label3.Text = "d:";
            // 
            // buttonRSAkey
            // 
            this.buttonRSAkey.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRSAkey.Location = new System.Drawing.Point(13, 33);
            this.buttonRSAkey.Name = "buttonRSAkey";
            this.buttonRSAkey.Size = new System.Drawing.Size(327, 34);
            this.buttonRSAkey.TabIndex = 34;
            this.buttonRSAkey.Text = "RSA key\'s generation";
            this.buttonRSAkey.UseVisualStyleBackColor = true;
            this.buttonRSAkey.Click += new System.EventHandler(this.buttonRSAkey_Click);
            // 
            // buttonRSA_load_d
            // 
            this.buttonRSA_load_d.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRSA_load_d.Location = new System.Drawing.Point(266, 140);
            this.buttonRSA_load_d.Name = "buttonRSA_load_d";
            this.buttonRSA_load_d.Size = new System.Drawing.Size(74, 28);
            this.buttonRSA_load_d.TabIndex = 40;
            this.buttonRSA_load_d.Text = "Load";
            this.buttonRSA_load_d.UseVisualStyleBackColor = true;
            this.buttonRSA_load_d.Click += new System.EventHandler(this.buttonRSA_load_d_Click);
            // 
            // buttonRSA_save_d
            // 
            this.buttonRSA_save_d.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRSA_save_d.Location = new System.Drawing.Point(186, 140);
            this.buttonRSA_save_d.Name = "buttonRSA_save_d";
            this.buttonRSA_save_d.Size = new System.Drawing.Size(74, 27);
            this.buttonRSA_save_d.TabIndex = 39;
            this.buttonRSA_save_d.Text = "Save";
            this.buttonRSA_save_d.UseVisualStyleBackColor = true;
            this.buttonRSA_save_d.Click += new System.EventHandler(this.buttonRSA_save_d_Click);
            // 
            // buttonRSA_load_n
            // 
            this.buttonRSA_load_n.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRSA_load_n.Location = new System.Drawing.Point(266, 75);
            this.buttonRSA_load_n.Name = "buttonRSA_load_n";
            this.buttonRSA_load_n.Size = new System.Drawing.Size(74, 27);
            this.buttonRSA_load_n.TabIndex = 42;
            this.buttonRSA_load_n.Text = "Load";
            this.buttonRSA_load_n.UseVisualStyleBackColor = true;
            this.buttonRSA_load_n.Click += new System.EventHandler(this.buttonRSA_load_n_Click);
            // 
            // buttonRSA_save_n
            // 
            this.buttonRSA_save_n.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRSA_save_n.Location = new System.Drawing.Point(186, 75);
            this.buttonRSA_save_n.Name = "buttonRSA_save_n";
            this.buttonRSA_save_n.Size = new System.Drawing.Size(74, 27);
            this.buttonRSA_save_n.TabIndex = 41;
            this.buttonRSA_save_n.Text = "Save";
            this.buttonRSA_save_n.UseVisualStyleBackColor = true;
            this.buttonRSA_save_n.Click += new System.EventHandler(this.buttonRSA_save_n_Click);
            // 
            // buttonRSA_load_e
            // 
            this.buttonRSA_load_e.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRSA_load_e.Location = new System.Drawing.Point(266, 107);
            this.buttonRSA_load_e.Name = "buttonRSA_load_e";
            this.buttonRSA_load_e.Size = new System.Drawing.Size(74, 27);
            this.buttonRSA_load_e.TabIndex = 44;
            this.buttonRSA_load_e.Text = "Load";
            this.buttonRSA_load_e.UseVisualStyleBackColor = true;
            this.buttonRSA_load_e.Click += new System.EventHandler(this.buttonRSA_load_e_Click);
            // 
            // buttonRSA_save_e
            // 
            this.buttonRSA_save_e.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRSA_save_e.Location = new System.Drawing.Point(186, 107);
            this.buttonRSA_save_e.Name = "buttonRSA_save_e";
            this.buttonRSA_save_e.Size = new System.Drawing.Size(74, 27);
            this.buttonRSA_save_e.TabIndex = 43;
            this.buttonRSA_save_e.Text = "Save";
            this.buttonRSA_save_e.UseVisualStyleBackColor = true;
            this.buttonRSA_save_e.Click += new System.EventHandler(this.buttonRSA_save_e_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.labelKey);
            this.groupBox3.Controls.Add(this.textBoxKey);
            this.groupBox3.Controls.Add(this.buttonKeyGen);
            this.groupBox3.Controls.Add(this.buttonKeySave);
            this.groupBox3.Controls.Add(this.buttonKeyLoad);
            this.groupBox3.Controls.Add(this.buttonKeyClear);
            this.groupBox3.Controls.Add(this.checkBoxWriteKey);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox3.Location = new System.Drawing.Point(56, 596);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(426, 152);
            this.groupBox3.TabIndex = 45;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "DES Key";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.buttonRSAkey);
            this.groupBox4.Controls.Add(this.textBoxRSAn);
            this.groupBox4.Controls.Add(this.buttonRSA_save_d);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.buttonRSA_load_e);
            this.groupBox4.Controls.Add(this.buttonRSA_load_d);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.textBoxRSAe);
            this.groupBox4.Controls.Add(this.buttonRSA_save_n);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.buttonRSA_save_e);
            this.groupBox4.Controls.Add(this.buttonRSA_load_n);
            this.groupBox4.Controls.Add(this.textBoxRSAd);
            this.groupBox4.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox4.Location = new System.Drawing.Point(498, 592);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(346, 174);
            this.groupBox4.TabIndex = 46;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "RSA Key\'s";
            // 
            // openFileDialogRSAn
            // 
            this.openFileDialogRSAn.FileName = "openFileDialog1";
            // 
            // openFileDialogRSAe
            // 
            this.openFileDialogRSAe.FileName = "openFileDialog1";
            // 
            // openFileDialogRSAd
            // 
            this.openFileDialogRSAd.FileName = "openFileDialog1";
            // 
            // EncryptedText
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1337, 1055);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonAction);
            this.Controls.Add(this.buttonEncryptedClear);
            this.Controls.Add(this.buttonEncryptedLoad);
            this.Controls.Add(this.buttonEncryptedSave);
            this.Controls.Add(this.labelCiphertext);
            this.Controls.Add(this.textBoxCiphertext);
            this.Controls.Add(this.buttonParentClear);
            this.Controls.Add(this.buttonParentLoad);
            this.Controls.Add(this.buttonParentSave);
            this.Controls.Add(this.labelPlaintext);
            this.Controls.Add(this.textBoxPlaintext);
            this.Name = "EncryptedText";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Работа с текстом";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxPlaintext;
        private System.Windows.Forms.Label labelPlaintext;
        private System.Windows.Forms.Button buttonParentSave;
        private System.Windows.Forms.Button buttonParentLoad;
        private System.Windows.Forms.Button buttonParentClear;
        private System.Windows.Forms.Button buttonEncryptedClear;
        private System.Windows.Forms.Button buttonEncryptedLoad;
        private System.Windows.Forms.Button buttonEncryptedSave;
        private System.Windows.Forms.Label labelCiphertext;
        private System.Windows.Forms.TextBox textBoxCiphertext;
        private System.Windows.Forms.Label labelKey;
        private System.Windows.Forms.TextBox textBoxKey;
        private System.Windows.Forms.Button buttonKeyGen;
        private System.Windows.Forms.Button buttonAction;
        private System.Windows.Forms.RadioButton radioButtonEncrypt;
        private System.Windows.Forms.RadioButton radioButtonXOR;
        private System.Windows.Forms.SaveFileDialog saveFileDialogParent;
        private System.Windows.Forms.SaveFileDialog saveFileDialogEncrypted;
        private System.Windows.Forms.OpenFileDialog openFileDialogParent;
        private System.Windows.Forms.OpenFileDialog openFileDialogEncrypted;
        private System.Windows.Forms.Button buttonKeySave;
        private System.Windows.Forms.Button buttonKeyLoad;
        private System.Windows.Forms.Button buttonKeyClear;
        private System.Windows.Forms.SaveFileDialog saveFileDialogKey;
        private System.Windows.Forms.OpenFileDialog openFileDialogKey;
        private System.Windows.Forms.RadioButton radioButtonDES;
        private System.Windows.Forms.RadioButton radioButtonDecrypt;
        private System.Windows.Forms.CheckBox checkBoxWriteKey;
        private System.Windows.Forms.RadioButton radioButtonRSA;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxRSAn;
        private System.Windows.Forms.TextBox textBoxRSAe;
        private System.Windows.Forms.TextBox textBoxRSAd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonRSAkey;
        private System.Windows.Forms.Button buttonRSA_load_d;
        private System.Windows.Forms.Button buttonRSA_save_d;
        private System.Windows.Forms.Button buttonRSA_load_n;
        private System.Windows.Forms.Button buttonRSA_save_n;
        private System.Windows.Forms.Button buttonRSA_load_e;
        private System.Windows.Forms.Button buttonRSA_save_e;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.SaveFileDialog saveFileDialogRSAn;
        private System.Windows.Forms.SaveFileDialog saveFileDialogRSAe;
        private System.Windows.Forms.OpenFileDialog openFileDialogRSAn;
        private System.Windows.Forms.SaveFileDialog saveFileDialogRSAd;
        private System.Windows.Forms.OpenFileDialog openFileDialogRSAe;
        private System.Windows.Forms.OpenFileDialog openFileDialogRSAd;
    }
}

