using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void kapatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void bT709ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 aFormu = new Form2();
            aFormu.ShowDialog();
        }

        private void ortalamaDeğerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 aFormu = new Form3();
            aFormu.ShowDialog();
        }

        private void lumaYöntemiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 aFormu = new Form4();
            aFormu.ShowDialog();
        }

        private void açıklıkYöntemiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 aFormu = new Form5();
            aFormu.ShowDialog();
        }

        private void kanalÇıkarmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 aFormu = new Form6();
            aFormu.ShowDialog();
        }
    }
}
