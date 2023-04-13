using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zapravka
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void топливоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toplivo tp = new toplivo();
            tp.Show();
        }

        private void видыТопливаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            vidtopliva vd=  new vidtopliva();
            vd.Show();
        }

        private void справочникToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            spravocnik sp = new spravocnik();
            sp.Show();
        }

        private void редактированиеСсправочникаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            redaktsprav rs = new redaktsprav();
            rs.Show();  
        }

        private void учетToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            uch uh = new uch();
            uh.Show();
             
        }

        private void контактыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            contact ct = new contact();
            ct.Show();
        }
    }
}
