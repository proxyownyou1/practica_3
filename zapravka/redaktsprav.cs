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
    public partial class redaktsprav : Form
    {
        public redaktsprav()
        {
            InitializeComponent();
        }

        private void sprav_postavBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.sprav_postavBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.zapravkaDataSet);

        }

        private void redaktsprav_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "zapravkaDataSet.sprav_postav". При необходимости она может быть перемещена или удалена.
            this.sprav_postavTableAdapter.Fill(this.zapravkaDataSet.sprav_postav);

        }
    }
}
