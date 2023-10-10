using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kasauygulama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double bakiye;

        private void Form1_Load(object sender, EventArgs e)
        {
            bakiye = 0;
            lblBakiye.Text = "bakiye: " + bakiye.ToString() + "₺";
        }

        private void btnYatir_Click(object sender, EventArgs e)
        {
            double yatirilacaktutar=Convert.ToDouble(txtTutar.Text);
            bakiye += yatirilacaktutar;
            lblBakiye.Text = "bakiye: " + bakiye.ToString() + "₺";
        }

        private void btnCek_Click(object sender, EventArgs e)
        {
            double cekilecektutar = Convert.ToDouble(txtTutar.Text);
            if (cekilecektutar <= bakiye)
            {
                bakiye -= cekilecektutar;
            }
            else
            {
                MessageBox.Show("YETERSİZ BAKİYE");
            }


            lblBakiye.Text = "bakiye: " + bakiye.ToString() + "₺";
        }
    }
}
