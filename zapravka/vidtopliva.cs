using Microsoft.Office.Core;
using Microsoft.Office.Interop.Excel;
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
using System.Windows.Forms.VisualStyles;
using DataTable = System.Data.DataTable;

namespace zapravka
{
    public partial class vidtopliva : Form
    {
        public vidtopliva()
        {
            InitializeComponent();
        }

        private void vid_toplivaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.vid_toplivaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.zapravkaDataSet);

        }

        private void vidtopliva_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "zapravkaDataSet.vid_topliva". При необходимости она может быть перемещена или удалена.
            this.vid_toplivaTableAdapter.Fill(this.zapravkaDataSet.vid_topliva);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Определение названия колонки, по которой нужно сортировать данные
            string columnName = "dataGridViewTextBoxColumn3";

            // Получение ссылки на колонку в DataGridView
            DataGridViewColumn column = vid_toplivaDataGridView.Columns[columnName];

            // Установка направления сортировки
            ListSortDirection direction = ListSortDirection.Ascending;

            // Сортировка данных в DataGridView по выбранной колонке и направлению
            vid_toplivaDataGridView.Sort(column, direction);
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
           

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connection.con);
            {
                conn.Open();
                string query = "SELECT * FROM [dbo].[vid_topliva] WHERE cost > @cost";
                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@cost", textBox1.Text);

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable fuelTypesDataTable = new DataTable();
                adapter.Fill(fuelTypesDataTable);

                vid_toplivaDataGridView.DataSource = fuelTypesDataTable;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connection.con);
            {
                conn.Open();
                string query = "SELECT cost FROM [dbo].[vid_topliva] WHERE cost < @cost";
                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@cost", textBox1.Text);

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable fuelTypesDataTable = new DataTable();
                adapter.Fill(fuelTypesDataTable);

                vid_toplivaDataGridView.DataSource = fuelTypesDataTable;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            radioButton1.Enabled = true;
            radioButton2.Enabled = true;






        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connection.con);
            {
                conn.Open();
                string query = "SELECT * FROM [dbo].[vid_topliva] WHERE cost > 0";
                SqlCommand command = new SqlCommand(query, conn);
                

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable fuelTypesDataTable = new DataTable();
                adapter.Fill(fuelTypesDataTable);

                vid_toplivaDataGridView.DataSource = fuelTypesDataTable;
            }
        }
    }
}
