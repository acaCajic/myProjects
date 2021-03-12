using projekat_forme_izgled;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    public partial class Loading : Form
    {
        int vr;
        string stri;
        string sifra;
        string korisinicko_ime;
        public Loading(int i, string s,string sifraaa,string korisnicki,Formlogin f1)
        {
            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
            f1.Hide();
            this.CenterToScreen();
            pictureBox1.Image=Image.FromFile("tenor.gif");
            timer1.Start();
            vr = i;
            stri = s;
            sifra = sifraaa;
            korisinicko_ime = korisnicki;
           //NEMOJ DA GA DIZES PREKO TRED , NECE ONDA SNAPSHOT I IZVESTAJ !!!! MORA PREKO TIMER!!!!
           // var t = new Thread(() => Application.Run(new Form1(this)));
           // t.Start();
            //var t = new Thread(() => { SaveFileDialog sfd = new SaveFileDialog(); Application.Run(new Form1(vr, stri, sifra, korisinicko_ime, this, sfd)); });
          // t.Start();
           


        }
        public void zatvoriSe()
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Form1 f = new Form1(vr,stri,sifra,korisinicko_ime,this);
            f.ShowDialog();
        }
      /*  private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            this.Hide();
            Form1 f = new Form1(vr, stri,sifra,korisinicko_ime);
            f.Show();
        }*/
    }
}
