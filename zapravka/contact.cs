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
    public partial class contact : Form
    {
        public contact()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            string url = "https://vk.com/club175457457";
            System.Diagnostics.Process.Start(url);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            string url = "https://www.ru.shell/";
            System.Diagnostics.Process.Start(url);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            string url = "https://www.ru.shell/";
            System.Diagnostics.Process.Start(url);
        }
    }
}
