namespace WinFormUI
{
    partial class PeopleForm
    {
        
        private System.ComponentModel.IContainer components = null;

        
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PeopleForm));
            this.userNameLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.userName = new System.Windows.Forms.TextBox();
            this.sifre = new System.Windows.Forms.TextBox();
            this.addPersonHeader = new System.Windows.Forms.Label();
            this.listPeopleHeader = new System.Windows.Forms.Label();
            this.listAccountsBox = new System.Windows.Forms.ListBox();
            this.addPersonButton = new System.Windows.Forms.Button();
            this.refreshListButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
           
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Location = new System.Drawing.Point(46, 101);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(151, 29);
            this.userNameLabel.TabIndex = 0;
            this.userNameLabel.Text = "Kullanıcı Adı:";
            this.userNameLabel.Click += new System.EventHandler(this.userNameLabel_Click);
           
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(46, 190);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(63, 29);
            this.passwordLabel.TabIndex = 1;
            this.passwordLabel.Text = "Şifre";
            this.passwordLabel.Click += new System.EventHandler(this.passwordLabel_Click);
            
            this.userName.Location = new System.Drawing.Point(52, 137);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(234, 35);
            this.userName.TabIndex = 2;
            
            this.sifre.Location = new System.Drawing.Point(52, 226);
            this.sifre.Name = "sifre";
            this.sifre.PasswordChar = '*';
            this.sifre.Size = new System.Drawing.Size(234, 35);
            this.sifre.TabIndex = 3;
            this.sifre.TextChanged += new System.EventHandler(this.sifre_TextChanged);
            
            this.addPersonHeader.AutoSize = true;
            this.addPersonHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPersonHeader.Location = new System.Drawing.Point(67, 42);
            this.addPersonHeader.Name = "addPersonHeader";
            this.addPersonHeader.Size = new System.Drawing.Size(130, 39);
            this.addPersonHeader.TabIndex = 4;
            this.addPersonHeader.Text = "Bilgiler";
            this.addPersonHeader.Click += new System.EventHandler(this.addPersonHeader_Click);
            
            this.listPeopleHeader.AutoSize = true;
            this.listPeopleHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listPeopleHeader.Location = new System.Drawing.Point(401, 42);
            this.listPeopleHeader.Name = "listPeopleHeader";
            this.listPeopleHeader.Size = new System.Drawing.Size(239, 39);
            this.listPeopleHeader.TabIndex = 5;
            this.listPeopleHeader.Text = "Hesap Listesi";
            this.listPeopleHeader.Click += new System.EventHandler(this.listPeopleHeader_Click);
          
            this.listAccountsBox.FormattingEnabled = true;
            this.listAccountsBox.ItemHeight = 29;
            this.listAccountsBox.Location = new System.Drawing.Point(348, 101);
            this.listAccountsBox.Name = "listAccountsBox";
            this.listAccountsBox.Size = new System.Drawing.Size(332, 352);
            this.listAccountsBox.TabIndex = 6;
            this.listAccountsBox.SelectedIndexChanged += new System.EventHandler(this.listAccountsBox_SelectedIndexChanged);
           
            this.addPersonButton.Location = new System.Drawing.Point(52, 299);
            this.addPersonButton.Name = "addPersonButton";
            this.addPersonButton.Size = new System.Drawing.Size(234, 69);
            this.addPersonButton.TabIndex = 7;
            this.addPersonButton.Text = "Hesap Ekle";
            this.addPersonButton.UseVisualStyleBackColor = true;
            this.addPersonButton.Click += new System.EventHandler(this.addPersonButton_Click);
           
            this.refreshListButton.Location = new System.Drawing.Point(52, 387);
            this.refreshListButton.Name = "refreshListButton";
            this.refreshListButton.Size = new System.Drawing.Size(234, 69);
            this.refreshListButton.TabIndex = 8;
            this.refreshListButton.Text = "Listeyi Yenile";
            this.refreshListButton.UseVisualStyleBackColor = true;
            this.refreshListButton.Click += new System.EventHandler(this.refreshListButton_Click);
          
            this.button1.Location = new System.Drawing.Point(52, 476);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(234, 69);
            this.button1.TabIndex = 9;
            this.button1.Text = "Paylaş";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            
            this.richTextBox1.Location = new System.Drawing.Point(712, 101);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(371, 352);
            this.richTextBox1.TabIndex = 11;
            this.richTextBox1.Text = "";
            
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(847, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 39);
            this.label1.TabIndex = 12;
            this.label1.Text = "Tweet";
            
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1277, 605);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.refreshListButton);
            this.Controls.Add(this.addPersonButton);
            this.Controls.Add(this.listAccountsBox);
            this.Controls.Add(this.listPeopleHeader);
            this.Controls.Add(this.addPersonHeader);
            this.Controls.Add(this.sifre);
            this.Controls.Add(this.userName);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.userNameLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.Name = "PeopleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Twitter Login";
            this.Load += new System.EventHandler(this.PeopleForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox userName;
        private System.Windows.Forms.TextBox sifre;
        private System.Windows.Forms.Label addPersonHeader;
        private System.Windows.Forms.Label listPeopleHeader;
        private System.Windows.Forms.ListBox listAccountsBox;
        private System.Windows.Forms.Button addPersonButton;
        private System.Windows.Forms.Button refreshListButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label1;
    }
}

