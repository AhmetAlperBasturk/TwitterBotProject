using DemoLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System.Threading;

namespace WinFormUI
{
    
        public partial class PeopleForm : Form
    {
        List<PersonModel> people = new List<PersonModel>();

        public PeopleForm()
        {
            InitializeComponent(); //Partial Classı çağırır.

            LoadPeopleList(); //PeopleList i çağırır.
        }
        private void LoadPeopleList()
        {
            people = SqliteDataAccess.LoadPeople(); //kaydedilmiş kişileri çağırır.

            WireUpPeopleList(); //WireUpPeopleList i çağırır.
        }
        
        private void WireUpPeopleList()
        {
            listAccountsBox.DataSource = null; 
            listAccountsBox.DataSource = people;
            listAccountsBox.DisplayMember = "FullName";
        }

        private void refreshListButton_Click(object sender, EventArgs e)
        {
            LoadPeopleList(); //PeopleList i yeniler. 
            System.Windows.Forms.MessageBox.Show("Liste Yenilendi.");
        }
        
        private void addPersonButton_Click(object sender, EventArgs e)
        {
            PersonModel p = new PersonModel();
            
            p.FirstName = userName.Text;
            p.LastName = sifre.Text;
            
            SqliteDataAccess.SavePerson(p);
            System.Windows.Forms.MessageBox.Show("Yeni Kullanıcı Kaydedildi.");

            userName.Text = "";
            sifre.Text = "";
        }

        ChromeDriver driver;
        private void button1_Click(object sender, EventArgs e)
        {
            driver = new ChromeDriver();

            driver.Navigate().GoToUrl("https://twitter.com/login");
            Thread.Sleep(1000);
            
            var user_name = driver.FindElementByXPath("/html/body/div/div/div/div[2]/main/div/div/div[2]/form/div/div[1]/label/div/div[2]/div/input");
            user_name.SendKeys(userName.Text); // Kullanıcı Adını gönderiyoruz.
            Thread.Sleep(1000);

            var password = driver.FindElementByXPath("/html/body/div/div/div/div[2]/main/div/div/div[2]/form/div/div[2]/label/div/div[2]/div/input");
            password.SendKeys(sifre.Text); // Şifreyi gönderiyoruz
            Thread.Sleep(1000);

            var login = driver.FindElementByXPath("/html/body/div/div/div/div[2]/main/div/div/div[2]/form/div/div[3]/div/div");
            login.Click();// log in tuşuna basıyoruz
            // Giriş Tamamlandı.
            Thread.Sleep(3000);

                var input = driver.FindElementByXPath("/html/body/div/div/div/div[2]/main/div/div/div/div[1]/div/div[2]/div/div[2]/div[1]/div/div/div/div[2]/div[1]/div/div/div/div/div/div/div/div/label/div[1]/div/div/div/div/div[2]/div/div/div/div");
                input.Click(); // Tweet yazacağımız yere tıklıyoruz.
                var text = driver.FindElementByXPath("/html/body/div/div/div/div[2]/main/div/div/div/div[1]/div/div[2]/div/div[2]/div[1]/div/div/div/div[2]/div[1]/div/div/div/div/div/div/div/div/label/div[1]/div/div/div/div/div[2]/div/div/div/div");
                text.SendKeys(richTextBox1.Text); // Tweet metininin gönderiyoruz.
                Thread.Sleep(3000);

                var tweet = driver.FindElementByXPath("/html/body/div/div/div/div[2]/main/div/div/div/div/div/div[2]/div/div[2]/div[1]/div/div/div/div[2]/div[3]/div/div/div[2]/div[3]");
                tweet.Click(); // Tweetle
            System.Windows.Forms.MessageBox.Show("Başarıyla Tweet Atıldı.");
        }
        
        private void PeopleForm_Load(object sender, EventArgs e)
        {
           
        }
      
        private void addPersonHeader_Click(object sender, EventArgs e)
        {

        }

        private void listPeopleHeader_Click(object sender, EventArgs e)
        {

        }

        private void userNameLabel_Click(object sender, EventArgs e)
        {
           
        }

        private void passwordLabel_Click(object sender, EventArgs e)
        {

        }

        private void listAccountsBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        
        private void sifre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
