using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vampir_Köylü_Version_1._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random random = new Random();

        // Players - Vampires - Villagers
        List<string> players = new List<string>();
        List<string> vampires = new List<string>();
        List<string> villagers = new List<string>();
        string mailSender = "";
        string mailSenderPassword = "";

        string[] mailExtensions = { "@gmail.com", "@hotmail.com", "@outlook.com" };

        // Number of vampires and players
        int numbersOfVampires = 0;
        int numbersOfPlayers = 0;

        // Determine game time
        int second = 0;
        int minute = 0;

        // Select Vampires and Villagers
        public void SelectVampiresAndVillagers()
        {
            // Select Vampires
            for (int i = 0; i < numbersOfVampires; i++)
            {
                int randomIndex = random.Next(0, players.Count);

                while (vampires.Contains(players[randomIndex]))
                {
                    randomIndex = random.Next(0, players.Count);
                }
                vampires.Add(players[randomIndex]);
            }

            // Select Villagers
            foreach (var player in players)
            {
                if (!vampires.Contains(player))
                {
                    villagers.Add(player);
                }
            }
        }

        // Select Players
        public void SelectPlayers()
        {
            foreach (var player in PlayersLstBox.Items)
            {
                players.Add(player.ToString());
            }
        }

        // Shuffle Players
        public void ShufflePlayers()
        {
            int n = players.Count;
            while (n > 1)
            {
                n--;
                int k = random.Next(n + 1);
                string value = players[k];
                players[k] = players[n];
                players[n] = value;
            }
        }

        // Clear Lists
        public void ClearLists()
        {
            players.Clear();
            villagers.Clear();
            vampires.Clear();
        }

        // Control Numbers of Players and Vampires
        public bool ControlNumbersOfPlayersAndVampires()
        {
            numbersOfPlayers = PlayersLstBox.Items.Count;
            numbersOfVampires = (int)NumberOfVampiresNumericUpDown.Value;

            if (numbersOfPlayers >= 3 && numbersOfVampires > 0 && numbersOfVampires <= numbersOfPlayers / 2)
            {
                return true;
            }

            else if (numbersOfPlayers < 3)
            {
                MessageBox.Show("Oyuncu sayısı 3 ten az olamaz !");
            }

            else if (numbersOfVampires <= 0)
            {
                MessageBox.Show("Vampir sayısı 1 den az olamaz !");
            }

            else
            {
                MessageBox.Show("Vampir sayısı oyuncu sayısının yarısından fazla olamaz !");
            }

            return false;
        }

        // It controls mailSender information 
        public bool ControlOfMailSenderInformation()
        {
            if (((mailSender != null && mailSender != "") && (mailSenderPassword != null && mailSenderPassword != "")))
            {
                return true;
            }

            else
            {
                MessageBox.Show("Mail gönderen adres ve parola bilgisi boş bırakılamaz !");
                return false;
            }
        }

        // Function controls mail adress. Is it valid or not ? 
        // If mail is valid, it is added to players
        public void MailAdressControl(string mailAddress)
        {
            if (PlayersLstBox.Items.Contains(mailAddress)) // is it already registered ?
            {
                MessageBox.Show("Bu mail adresi daha önce eklenmiş.");
            }

            else // is it valid ?
            {
                bool flag = false;
                foreach (var extension in mailExtensions)
                {
                    if (mailAddress.Contains(extension)) // extension control
                    {
                        PlayersLstBox.Items.Add(mailAddress); // mail added to list box
                        PlayerMailAddressTxtBox.Clear();
                        flag = true;
                        break;
                    }
                }

                if (!flag)
                {
                    MessageBox.Show("Lütfen geçerli bir mail adresi giriniz !");
                }

            }
        }

        // Determine Mail Sender
        public void DetermineMailSender(string mailAddress, string password)
        {
            bool flag = false;
            foreach (var extension in mailExtensions)
            {
                if (mailAddress.Contains(extension)) // extension control
                {
                    mailSender = mailAddress; // determine mailSender
                    mailSenderPassword = password; // mailSender password

                    mailSenderPasswordTbox.Clear();
                    MessageBox.Show("Mail gönderecek adres belirlendi !");

                    flag = true;
                    break;
                }
            }

            if (!flag)
            {
                MessageBox.Show("Lütfen geçerli bir mail adresi giriniz !");
            }
        }

        //Send Mail to Vampires
        public void SendMailToVampires()
        {
            try
            {
                MailMessage message = new MailMessage();
                SmtpClient client = new SmtpClient();
                client.Credentials = new System.Net.NetworkCredential(mailSender, mailSenderPassword);
                client.Port = 587;
                client.Host = "smtp.gmail.com";
                client.EnableSsl = true;

                foreach (var vampire in vampires)
                {
                    message.To.Add(vampire);
                }

                message.From = new MailAddress(mailSender);
                message.Subject = "Vampir Köylü Oyunu";
                message.Body = "Sen bir vampirsin !";
                client.Send(message);
                MessageBox.Show("Vampirlere mail gonderildi");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Send Mail to Villagers
        public void SendMailToVillagers()
        {
            try
            {
                foreach (var villager in villagers)
                {
                    MailMessage message = new MailMessage();
                    SmtpClient client = new SmtpClient();
                    client.Credentials = new System.Net.NetworkCredential(mailSender, mailSenderPassword);
                    client.Port = 587;
                    client.Host = "smtp.gmail.com";
                    client.EnableSsl = true;

                    message.To.Add(villager);
                    message.From = new MailAddress(mailSender);
                    message.Subject = "Vampir Köylü Oyunu";
                    message.Body = "Sen bir köylüsün !";
                    client.Send(message);
                }
                MessageBox.Show("Köylülere mail gonderildi");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Game Function
        public void Game()
        {
            ClearLists();
            if (ControlNumbersOfPlayersAndVampires() && ControlOfMailSenderInformation())
            {
                SelectPlayers();
                ShufflePlayers();
                SelectVampiresAndVillagers();
                SendMailToVampires();
                SendMailToVillagers();
                MessageBox.Show("Oyun Başladı !!!");
            }
        }

        // Play Game Button
        private void PlayBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Game();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Add Player's mail address
        private void AddPlayerMailAdressBtn_Click(object sender, EventArgs e)
        {
            try
            {
                MailAdressControl(PlayerMailAddressTxtBox.Text.Trim());

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Delete selected player from list box
        private void DeletePlayersLstBoxSelectedItemBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int deletedIndex = PlayersLstBox.SelectedIndex;

                if (deletedIndex == -1)
                {
                    MessageBox.Show("Silinecek oyuncuyu seçmediniz !");
                }
                else
                {
                    PlayersLstBox.Items.RemoveAt(deletedIndex);
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        // Clear PlayersListBox
        private void ClearPlayersLstBoxBtn_Click(object sender, EventArgs e)
        {
            try
            {
                PlayersLstBox.Items.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        // Timer for Game
        private void ClockTimer_Tick(object sender, EventArgs e)
        {
            if (minute < 10)
            {
                MinuteLbl.Text = "0" + minute.ToString();
            }
            else
            {
                MinuteLbl.Text = minute.ToString();
            }

            if (second < 10)
            {
                SecondLbl.Text = "0" + second.ToString();
            }
            else
            {
                SecondLbl.Text = second.ToString();
            }

            second -= 1;

            if (second < 0)
            {
                minute -= 1;
                second += 60;
            }

            if (minute == -1)
            {
                ClockTimer.Stop();
                MinuteLbl.Text = "00";
                SecondLbl.Text = "00";
                MessageBox.Show("Süre Doldu !");
            }
        }

        private void StartTimerBtn_Click(object sender, EventArgs e)
        {
            if ((int)MinuteNumericUpDown.Value <= 0)
            {
                MessageBox.Show("Oylama süresi en az 1 dakika olmalıdır !");
            }

            else
            {
                minute = (int)MinuteNumericUpDown.Value;
                ClockTimer.Start();
            }
        }

        // Add Mail Sender Information Button
        private void AddMailSenderBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (mailSenderTxtBox.Text.Trim() != null && mailSenderTxtBox.Text.Trim() != "" &&
                    mailSenderPasswordTbox.Text.Trim() != null && mailSenderPasswordTbox.Text.Trim() != "")
                {
                    DetermineMailSender(mailSenderTxtBox.Text.Trim(), mailSenderPasswordTbox.Text.Trim());
                }

                else
                {
                    MessageBox.Show("Mail atan adres ve ona ait parola boş bırakılamaz !");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Reset Timer Button
        private void ResetTimerButton_Click(object sender, EventArgs e)
        {
            minute = 0;
            second = 0;

            MinuteLbl.Text = "00";
            SecondLbl.Text = "00";
            ClockTimer.Stop();
        }
    }
}
