using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtYarisi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int birinciatsolauzaklik, ikinciatsolauzaklik, ucuncuatsolauzaklik;

        Random rnd = new Random();

        private void Form1_Load(object sender, EventArgs e)
        {
            birinciatsolauzaklik = pc1.Left;
            ikinciatsolauzaklik = pc2.Left;
            ucuncuatsolauzaklik = pc3.Left;
        }

        private void btnYarisiStart_Click(object sender, EventArgs e)
        {
            timer1.Start();

            //1) formun sağ tarafına bitiş çizgisi eklenecek ve 1. bitiren at mb iler kullanıcıya bildirecek. yarışma bittiğinde tüm atlar duracak.
            //2) Yarışı sıfırla butonu eklenecek ve tıklandığında sistem en başa dönecek.
            //3) sol üste köşeden label olacak ve o labelda anlık olarak hangi at önde bilgisi verilecek. örn( 1. Kulvardaki ŞahBatur önde götürüyor gibi)


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pc1.Left += rnd.Next(1, 20);
            pc2.Left += rnd.Next(1, 20);
            pc3.Left += rnd.Next(1, 20);

            int birinciatingenisligi = pc1.Width;
            int ikinciatingenisligi = pc2.Width;
            int ücüncüatingenisligi = pc3.Width;
        }

       
    }
}
