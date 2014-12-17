using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Otel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        BosOdalar bos;
        MusteriAra musteri;
        DoluOdalar dolu;


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void boşOdalarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (bos == null || bos.IsDisposed)
            {
                bos = new BosOdalar();
                bos.MdiParent = this;
                bos.Show();
            }
            else
            {
                bos.Focus();
            }

            bos.WindowState = FormWindowState.Maximized;
        }

        private void doluOdalarToolStripMenuItem_Click(object sender, EventArgs e)
        {


            if (dolu == null || bos.IsDisposed)
            {
                dolu = new DoluOdalar();
                dolu.MdiParent = this;
                dolu.Show();
            }
            else
            {
                dolu.Focus();
            }

            dolu.WindowState = FormWindowState.Maximized;


        }

        private void müşteriAraToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            if (musteri == null || musteri.IsDisposed)
            {
                musteri = new MusteriAra();
                musteri.MdiParent = this;
                musteri.Show();
            }
            else
            {
                musteri.Focus();
            }

            musteri.WindowState = FormWindowState.Maximized;



        }
    }
}
