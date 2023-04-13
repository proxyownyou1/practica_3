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
    public partial class toplivo : Form
    {
        public toplivo()
        {
            InitializeComponent();
        }

        private void vid_toplivaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.vid_toplivaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.zapravkaDataSet);

        }

        private void toplivo_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "zapravkaDataSet.vid_topliva". При необходимости она может быть перемещена или удалена.
            this.vid_toplivaTableAdapter.Fill(this.zapravkaDataSet.vid_topliva);

        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {

        }

        private void сохранитьToolStripButton_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.vid_toplivaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.zapravkaDataSet);
        }
    }
}
