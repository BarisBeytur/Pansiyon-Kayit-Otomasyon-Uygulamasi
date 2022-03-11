using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ay_Cicegi_Pansiyon_Uygulaması_V1
{
    public partial class FrmAnaForm : Form
    {
        public FrmAnaForm()
        {
            InitializeComponent();
        }

        private void AdminGiris_Click(object sender, EventArgs e)
        {
            AdminGiriş fr = new AdminGiriş();
            fr.Show();
            this.Hide();

        }

        private void YeniMusteri_Click(object sender, EventArgs e)
        {
            FrmYeniMusteri fr = new FrmYeniMusteri();   
            fr.Show();
         

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmOdalar oda = new FrmOdalar();    
            oda.Show();

        }

        private void FrmAnaForm_Load(object sender, EventArgs e)
        {

        }

        private void BtnMusteriler_Click(object sender, EventArgs e)
        {
            FrmMusteriler fr = new FrmMusteriler();
            fr.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Ayçiçeği Pansiyon Kayıt Uygulaması / 2022 - Istanbul \n\n\nGeliştirici: Barış Beytur - beyturbaris@gmail.com");
        }
    }
}
