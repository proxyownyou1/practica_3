using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace zapravka
{
    public partial class uch : Form
    {
        public uch()
        {
            InitializeComponent();
        }

        private void ychet_ostBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.ychet_ostBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.zapravkaDataSet);

        }

        private void uch_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "zapravkaDataSet.vid_topliva". При необходимости она может быть перемещена или удалена.
            this.vid_toplivaTableAdapter.Fill(this.zapravkaDataSet.vid_topliva);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "zapravkaDataSet.ychet_ost". При необходимости она может быть перемещена или удалена.
            this.ychet_ostTableAdapter.Fill(this.zapravkaDataSet.ychet_ost);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "zapravkaDataSet.vid_topliva". При необходимости она может быть перемещена или удалена.
            this.vid_toplivaTableAdapter.Fill(this.zapravkaDataSet.vid_topliva);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "zapravkaDataSet.ychet_ost". При необходимости она может быть перемещена или удалена.
            this.ychet_ostTableAdapter.Fill(this.zapravkaDataSet.ychet_ost);



            // создать объект подключения
            SqlConnection conn = new SqlConnection(connection.con);
            try
            {
                conn.Open();//открыть подключение
                string query = "SELECT kod_ycheta,data,obiem_dnya,obiem_prod,name,cost,kod_postav FROM [dbo].[ychet_ost] JOIN [dbo].[vid_topliva] ON [dbo].[ychet_ost].kod_vidatopl = [dbo].[vid_topliva].kod_vida";

                SqlCommand cmd = new SqlCommand(query, conn);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows == false)
                { MessageBox.Show("данные не найдены!"); }
                else
                {
                    while (reader.Read())
                    {
                        dataGridView1.Rows.Add(reader[0], reader[1], reader[2], reader[3], reader[4], reader[5], reader[6]);
                    }

                }
                reader.Close();
                conn.Close();//закрыть подключение
            }
            catch
            {
                MessageBox.Show("Ошибка!");
            }
        }

        private void ychet_ostBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.ychet_ostBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.zapravkaDataSet);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private DataGridViewColumn COl;
        private void button3_Click(object sender, EventArgs e)
        {
            COl = new DataGridViewColumn();
            switch (listBox1.SelectedIndex)
            {
                case 0:
                    COl = Column1;
                    break;
                case 1:
                    COl = Column2;
                    break;
                case 2:
                    COl = Column3;
                    break;
                case 3:
                    COl = Column4;
                    break;
                case 4:
                    COl = Column5;
                    break;
                case 5:
                    COl = Column6;
                    break;
                case 6:
                    COl = Column7;
                    break;

            }
            if (radioButton1.Checked)
                dataGridView1.Sort(COl, System.ComponentModel.ListSortDirection.Ascending);
            else
                dataGridView1.Sort(COl, System.ComponentModel.ListSortDirection.Descending);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int m = dataGridView1.ColumnCount;
            int n = dataGridView1.RowCount;
            var application = new Excel.Application();
            application.SheetsInNewWorkbook = 1;
            Excel.Workbook workbook = application.Workbooks.Add(Type.Missing);

            Excel.Worksheet worksheet = application.Worksheets.Item[1];
            worksheet.Name = "Ведомость";

            for (int i = 0, j = 1; i < m; i++, j++)
            {
                worksheet.Cells[1, j] = dataGridView1.Columns[i].HeaderCell.Value;
            }

            for (int i = 0, j = 1; i < m; i++, j++)
            {
                for (int p = 0, v = 2; p < n; p++, v++)
                {
                    worksheet.Cells[v, j] = dataGridView1[i, p].Value;

                }
            }
            application.Visible = true;
        }
    }
    }

