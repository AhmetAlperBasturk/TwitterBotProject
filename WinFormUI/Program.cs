using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormUI
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            System.Windows.Forms.MessageBox.Show("Uygulamaya Giriş Yapılıyor.");
            Application.EnableVisualStyles();    // Görsel stili aktive ediyor.
            Application.SetCompatibleTextRenderingDefault(false);  //Boolean yapısıyla true olsaydı GDI+ tabanlı kullanacakken bu haliyle GDI tabanlı text renderer kullanıyor.
            Application.Run(new PeopleForm());   //PeopleForm.cs i çalıştırır.
            System.Windows.Forms.MessageBox.Show("Başarıyla Çıkış Yaptınız.");
        }
    }
}
// örnek id: b10162967454  //
// örnek şif: AEC123456789 //