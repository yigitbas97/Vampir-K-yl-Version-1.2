namespace Vampir_Köylü_Version_1._2
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.PlayBtn = new System.Windows.Forms.Button();
            this.SettingsGroupBox = new System.Windows.Forms.GroupBox();
            this.ClockPictureBox = new System.Windows.Forms.PictureBox();
            this.StartTimerBtn = new System.Windows.Forms.Button();
            this.Seperate = new System.Windows.Forms.Label();
            this.SecondLbl = new System.Windows.Forms.Label();
            this.MinuteLbl = new System.Windows.Forms.Label();
            this.MinuteNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.TimeLbl = new System.Windows.Forms.Label();
            this.ClearPlayersLstBoxBtn = new System.Windows.Forms.Button();
            this.DeletePlayersLstBoxSelectedItemBtn = new System.Windows.Forms.Button();
            this.NumberOfVampiresNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.NumberOfVampiresLbl = new System.Windows.Forms.Label();
            this.PlayersLstBox = new System.Windows.Forms.ListBox();
            this.AddPlayerMailAdressBtn = new System.Windows.Forms.Button();
            this.PlayerMailAddressTxtBox = new System.Windows.Forms.TextBox();
            this.PlayerMailAddressLbl = new System.Windows.Forms.Label();
            this.FooterLbl = new System.Windows.Forms.Label();
            this.ClockTimer = new System.Windows.Forms.Timer(this.components);
            this.mailSenderTxtBox = new System.Windows.Forms.TextBox();
            this.mailSenderLbl = new System.Windows.Forms.Label();
            this.AddMailSenderBtn = new System.Windows.Forms.Button();
            this.mailSenderPasswordTbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ResetTimerButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SettingsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClockPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinuteNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumberOfVampiresNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.PlayBtn);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(327, 289);
            this.panel1.TabIndex = 0;
            // 
            // PlayBtn
            // 
            this.PlayBtn.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayBtn.Location = new System.Drawing.Point(185, 242);
            this.PlayBtn.Name = "PlayBtn";
            this.PlayBtn.Size = new System.Drawing.Size(110, 37);
            this.PlayBtn.TabIndex = 0;
            this.PlayBtn.Text = "Oyuna Başla";
            this.PlayBtn.UseVisualStyleBackColor = true;
            this.PlayBtn.Click += new System.EventHandler(this.PlayBtn_Click);
            // 
            // SettingsGroupBox
            // 
            this.SettingsGroupBox.Controls.Add(this.ResetTimerButton);
            this.SettingsGroupBox.Controls.Add(this.label1);
            this.SettingsGroupBox.Controls.Add(this.mailSenderPasswordTbox);
            this.SettingsGroupBox.Controls.Add(this.AddMailSenderBtn);
            this.SettingsGroupBox.Controls.Add(this.mailSenderLbl);
            this.SettingsGroupBox.Controls.Add(this.mailSenderTxtBox);
            this.SettingsGroupBox.Controls.Add(this.ClockPictureBox);
            this.SettingsGroupBox.Controls.Add(this.StartTimerBtn);
            this.SettingsGroupBox.Controls.Add(this.Seperate);
            this.SettingsGroupBox.Controls.Add(this.SecondLbl);
            this.SettingsGroupBox.Controls.Add(this.MinuteLbl);
            this.SettingsGroupBox.Controls.Add(this.MinuteNumericUpDown);
            this.SettingsGroupBox.Controls.Add(this.TimeLbl);
            this.SettingsGroupBox.Controls.Add(this.ClearPlayersLstBoxBtn);
            this.SettingsGroupBox.Controls.Add(this.DeletePlayersLstBoxSelectedItemBtn);
            this.SettingsGroupBox.Controls.Add(this.NumberOfVampiresNumericUpDown);
            this.SettingsGroupBox.Controls.Add(this.NumberOfVampiresLbl);
            this.SettingsGroupBox.Controls.Add(this.PlayersLstBox);
            this.SettingsGroupBox.Controls.Add(this.AddPlayerMailAdressBtn);
            this.SettingsGroupBox.Controls.Add(this.PlayerMailAddressTxtBox);
            this.SettingsGroupBox.Controls.Add(this.PlayerMailAddressLbl);
            this.SettingsGroupBox.Location = new System.Drawing.Point(333, 0);
            this.SettingsGroupBox.Name = "SettingsGroupBox";
            this.SettingsGroupBox.Size = new System.Drawing.Size(544, 289);
            this.SettingsGroupBox.TabIndex = 1;
            this.SettingsGroupBox.TabStop = false;
            this.SettingsGroupBox.Text = "Ayarlar";
            // 
            // ClockPictureBox
            // 
            this.ClockPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("ClockPictureBox.Image")));
            this.ClockPictureBox.Location = new System.Drawing.Point(321, 51);
            this.ClockPictureBox.Name = "ClockPictureBox";
            this.ClockPictureBox.Size = new System.Drawing.Size(208, 116);
            this.ClockPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ClockPictureBox.TabIndex = 20;
            this.ClockPictureBox.TabStop = false;
            // 
            // StartTimerBtn
            // 
            this.StartTimerBtn.Location = new System.Drawing.Point(321, 173);
            this.StartTimerBtn.Name = "StartTimerBtn";
            this.StartTimerBtn.Size = new System.Drawing.Size(208, 23);
            this.StartTimerBtn.TabIndex = 18;
            this.StartTimerBtn.Text = "Süreyi Başlat";
            this.StartTimerBtn.UseVisualStyleBackColor = true;
            this.StartTimerBtn.Click += new System.EventHandler(this.StartTimerBtn_Click);
            // 
            // Seperate
            // 
            this.Seperate.AutoSize = true;
            this.Seperate.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Seperate.Location = new System.Drawing.Point(404, 223);
            this.Seperate.Name = "Seperate";
            this.Seperate.Size = new System.Drawing.Size(42, 63);
            this.Seperate.TabIndex = 16;
            this.Seperate.Text = ":";
            // 
            // SecondLbl
            // 
            this.SecondLbl.AutoSize = true;
            this.SecondLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SecondLbl.Location = new System.Drawing.Point(442, 223);
            this.SecondLbl.Name = "SecondLbl";
            this.SecondLbl.Size = new System.Drawing.Size(87, 63);
            this.SecondLbl.TabIndex = 15;
            this.SecondLbl.Text = "00";
            // 
            // MinuteLbl
            // 
            this.MinuteLbl.AutoSize = true;
            this.MinuteLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MinuteLbl.Location = new System.Drawing.Point(320, 223);
            this.MinuteLbl.Name = "MinuteLbl";
            this.MinuteLbl.Size = new System.Drawing.Size(87, 63);
            this.MinuteLbl.TabIndex = 14;
            this.MinuteLbl.Text = "00";
            // 
            // MinuteNumericUpDown
            // 
            this.MinuteNumericUpDown.Location = new System.Drawing.Point(394, 25);
            this.MinuteNumericUpDown.Name = "MinuteNumericUpDown";
            this.MinuteNumericUpDown.Size = new System.Drawing.Size(135, 20);
            this.MinuteNumericUpDown.TabIndex = 13;
            // 
            // TimeLbl
            // 
            this.TimeLbl.AutoSize = true;
            this.TimeLbl.Location = new System.Drawing.Point(318, 27);
            this.TimeLbl.Name = "TimeLbl";
            this.TimeLbl.Size = new System.Drawing.Size(70, 13);
            this.TimeLbl.TabIndex = 12;
            this.TimeLbl.Text = "Oyun Süresi :";
            // 
            // ClearPlayersLstBoxBtn
            // 
            this.ClearPlayersLstBoxBtn.Location = new System.Drawing.Point(167, 256);
            this.ClearPlayersLstBoxBtn.Name = "ClearPlayersLstBoxBtn";
            this.ClearPlayersLstBoxBtn.Size = new System.Drawing.Size(140, 23);
            this.ClearPlayersLstBoxBtn.TabIndex = 11;
            this.ClearPlayersLstBoxBtn.Text = "Tüm Oyuncuları Sil";
            this.ClearPlayersLstBoxBtn.UseVisualStyleBackColor = true;
            this.ClearPlayersLstBoxBtn.Click += new System.EventHandler(this.ClearPlayersLstBoxBtn_Click);
            // 
            // DeletePlayersLstBoxSelectedItemBtn
            // 
            this.DeletePlayersLstBoxSelectedItemBtn.Location = new System.Drawing.Point(15, 256);
            this.DeletePlayersLstBoxSelectedItemBtn.Name = "DeletePlayersLstBoxSelectedItemBtn";
            this.DeletePlayersLstBoxSelectedItemBtn.Size = new System.Drawing.Size(140, 23);
            this.DeletePlayersLstBoxSelectedItemBtn.TabIndex = 10;
            this.DeletePlayersLstBoxSelectedItemBtn.Text = "Seçili Oyuncuyu Sil";
            this.DeletePlayersLstBoxSelectedItemBtn.UseVisualStyleBackColor = true;
            this.DeletePlayersLstBoxSelectedItemBtn.Click += new System.EventHandler(this.DeletePlayersLstBoxSelectedItemBtn_Click);
            // 
            // NumberOfVampiresNumericUpDown
            // 
            this.NumberOfVampiresNumericUpDown.Location = new System.Drawing.Point(122, 25);
            this.NumberOfVampiresNumericUpDown.Name = "NumberOfVampiresNumericUpDown";
            this.NumberOfVampiresNumericUpDown.Size = new System.Drawing.Size(185, 20);
            this.NumberOfVampiresNumericUpDown.TabIndex = 7;
            // 
            // NumberOfVampiresLbl
            // 
            this.NumberOfVampiresLbl.AutoSize = true;
            this.NumberOfVampiresLbl.Location = new System.Drawing.Point(41, 25);
            this.NumberOfVampiresLbl.Name = "NumberOfVampiresLbl";
            this.NumberOfVampiresLbl.Size = new System.Drawing.Size(75, 13);
            this.NumberOfVampiresLbl.TabIndex = 6;
            this.NumberOfVampiresLbl.Text = "Vampir Sayısı :";
            // 
            // PlayersLstBox
            // 
            this.PlayersLstBox.FormattingEnabled = true;
            this.PlayersLstBox.Location = new System.Drawing.Point(15, 155);
            this.PlayersLstBox.Name = "PlayersLstBox";
            this.PlayersLstBox.Size = new System.Drawing.Size(292, 95);
            this.PlayersLstBox.TabIndex = 3;
            // 
            // AddPlayerMailAdressBtn
            // 
            this.AddPlayerMailAdressBtn.Location = new System.Drawing.Point(218, 126);
            this.AddPlayerMailAdressBtn.Name = "AddPlayerMailAdressBtn";
            this.AddPlayerMailAdressBtn.Size = new System.Drawing.Size(89, 23);
            this.AddPlayerMailAdressBtn.TabIndex = 2;
            this.AddPlayerMailAdressBtn.Text = "Oyuncu Ekle";
            this.AddPlayerMailAdressBtn.UseVisualStyleBackColor = true;
            this.AddPlayerMailAdressBtn.Click += new System.EventHandler(this.AddPlayerMailAdressBtn_Click);
            // 
            // PlayerMailAddressTxtBox
            // 
            this.PlayerMailAddressTxtBox.Location = new System.Drawing.Point(122, 48);
            this.PlayerMailAddressTxtBox.Name = "PlayerMailAddressTxtBox";
            this.PlayerMailAddressTxtBox.Size = new System.Drawing.Size(185, 20);
            this.PlayerMailAddressTxtBox.TabIndex = 1;
            // 
            // PlayerMailAddressLbl
            // 
            this.PlayerMailAddressLbl.AutoSize = true;
            this.PlayerMailAddressLbl.Location = new System.Drawing.Point(12, 51);
            this.PlayerMailAddressLbl.Name = "PlayerMailAddressLbl";
            this.PlayerMailAddressLbl.Size = new System.Drawing.Size(104, 13);
            this.PlayerMailAddressLbl.TabIndex = 0;
            this.PlayerMailAddressLbl.Text = "Oyuncu Mail Adresi :";
            // 
            // FooterLbl
            // 
            this.FooterLbl.AutoSize = true;
            this.FooterLbl.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FooterLbl.Location = new System.Drawing.Point(238, 294);
            this.FooterLbl.Name = "FooterLbl";
            this.FooterLbl.Size = new System.Drawing.Size(502, 22);
            this.FooterLbl.TabIndex = 2;
            this.FooterLbl.Text = "Vampir Köylü V1.2 - Yiğit Baş © 2020 - Tüm Hakları Saklıdır.";
            // 
            // ClockTimer
            // 
            this.ClockTimer.Interval = 1000;
            this.ClockTimer.Tick += new System.EventHandler(this.ClockTimer_Tick);
            // 
            // mailSenderTxtBox
            // 
            this.mailSenderTxtBox.Location = new System.Drawing.Point(122, 74);
            this.mailSenderTxtBox.Name = "mailSenderTxtBox";
            this.mailSenderTxtBox.Size = new System.Drawing.Size(185, 20);
            this.mailSenderTxtBox.TabIndex = 21;
            // 
            // mailSenderLbl
            // 
            this.mailSenderLbl.AutoSize = true;
            this.mailSenderLbl.Location = new System.Drawing.Point(28, 77);
            this.mailSenderLbl.Name = "mailSenderLbl";
            this.mailSenderLbl.Size = new System.Drawing.Size(87, 13);
            this.mailSenderLbl.TabIndex = 22;
            this.mailSenderLbl.Text = "Mail Atan Adres :";
            // 
            // AddMailSenderBtn
            // 
            this.AddMailSenderBtn.Location = new System.Drawing.Point(122, 126);
            this.AddMailSenderBtn.Name = "AddMailSenderBtn";
            this.AddMailSenderBtn.Size = new System.Drawing.Size(90, 23);
            this.AddMailSenderBtn.TabIndex = 23;
            this.AddMailSenderBtn.Text = "Gönderici Ekle";
            this.AddMailSenderBtn.UseVisualStyleBackColor = true;
            this.AddMailSenderBtn.Click += new System.EventHandler(this.AddMailSenderBtn_Click);
            // 
            // mailSenderPasswordTbox
            // 
            this.mailSenderPasswordTbox.Location = new System.Drawing.Point(122, 100);
            this.mailSenderPasswordTbox.Name = "mailSenderPasswordTbox";
            this.mailSenderPasswordTbox.Size = new System.Drawing.Size(185, 20);
            this.mailSenderPasswordTbox.TabIndex = 24;
            this.mailSenderPasswordTbox.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Mail Atan Adres Şifre :";
            // 
            // ResetTimerButton
            // 
            this.ResetTimerButton.Location = new System.Drawing.Point(321, 202);
            this.ResetTimerButton.Name = "ResetTimerButton";
            this.ResetTimerButton.Size = new System.Drawing.Size(208, 23);
            this.ResetTimerButton.TabIndex = 26;
            this.ResetTimerButton.Text = "Süreyi Sıfırla";
            this.ResetTimerButton.UseVisualStyleBackColor = true;
            this.ResetTimerButton.Click += new System.EventHandler(this.ResetTimerButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(883, 325);
            this.Controls.Add(this.FooterLbl);
            this.Controls.Add(this.SettingsGroupBox);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Vampir Köylü Version 1.2";
            this.panel1.ResumeLayout(false);
            this.SettingsGroupBox.ResumeLayout(false);
            this.SettingsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClockPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinuteNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumberOfVampiresNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox SettingsGroupBox;
        private System.Windows.Forms.Button AddPlayerMailAdressBtn;
        private System.Windows.Forms.Label PlayerMailAddressLbl;
        private System.Windows.Forms.ListBox PlayersLstBox;
        private System.Windows.Forms.Button PlayBtn;
        private System.Windows.Forms.Label NumberOfVampiresLbl;
        private System.Windows.Forms.Label FooterLbl;
        private System.Windows.Forms.NumericUpDown NumberOfVampiresNumericUpDown;
        private System.Windows.Forms.TextBox PlayerMailAddressTxtBox;
        private System.Windows.Forms.Button ClearPlayersLstBoxBtn;
        private System.Windows.Forms.Button DeletePlayersLstBoxSelectedItemBtn;
        private System.Windows.Forms.Label Seperate;
        private System.Windows.Forms.Label SecondLbl;
        private System.Windows.Forms.Label MinuteLbl;
        private System.Windows.Forms.NumericUpDown MinuteNumericUpDown;
        private System.Windows.Forms.Label TimeLbl;
        private System.Windows.Forms.Timer ClockTimer;
        private System.Windows.Forms.Button StartTimerBtn;
        private System.Windows.Forms.PictureBox ClockPictureBox;
        private System.Windows.Forms.Label mailSenderLbl;
        private System.Windows.Forms.TextBox mailSenderTxtBox;
        private System.Windows.Forms.Button AddMailSenderBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox mailSenderPasswordTbox;
        private System.Windows.Forms.Button ResetTimerButton;
    }
}

