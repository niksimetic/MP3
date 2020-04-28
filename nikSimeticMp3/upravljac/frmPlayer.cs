using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace upravljac
{
    public partial class frmPlayer : Form
    {
        public frmPlayer()
        {
            InitializeComponent();
        }
        
        PlayerKontrola Muzika = new PlayerKontrola();

        private void BtnStop_Click(object sender, EventArgs e)
        {
            Muzika.Stop();
        }

        private void BtnPlay_Click(object sender, EventArgs e)
        {
            Muzika.Play();
        }

        private void BtnPause_Click(object sender, EventArgs e)
        {
            Muzika.Pause();
        }

        private void BtnBackward_Click(object sender, EventArgs e)
        {
            Muzika.Backward();
        }

        private void BtnForward_Click(object sender, EventArgs e)
        {
            Muzika.Forward();
        }

        private void btnStop_Click_1(object sender, EventArgs e)
        {
            Muzika.Stop();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Mp3 Files|*.mp3";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    Muzika.open(ofd.FileName);
                }
            }
        }
    }
}
