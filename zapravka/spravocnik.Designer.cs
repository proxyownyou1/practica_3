namespace zapravka
{
    partial class spravocnik
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.zapravkaDataSet = new zapravka.zapravkaDataSet();
            this.sprav_postavBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sprav_postavTableAdapter = new zapravka.zapravkaDataSetTableAdapters.sprav_postavTableAdapter();
            this.tableAdapterManager = new zapravka.zapravkaDataSetTableAdapters.TableAdapterManager();
            this.sprav_postavDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.zapravkaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sprav_postavBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sprav_postavDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // zapravkaDataSet
            // 
            this.zapravkaDataSet.DataSetName = "zapravkaDataSet";
            this.zapravkaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sprav_postavBindingSource
            // 
            this.sprav_postavBindingSource.DataMember = "sprav_postav";
            this.sprav_postavBindingSource.DataSource = this.zapravkaDataSet;
            // 
            // sprav_postavTableAdapter
            // 
            this.sprav_postavTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.sprav_postavTableAdapter = this.sprav_postavTableAdapter;
            this.tableAdapterManager.UpdateOrder = zapravka.zapravkaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.vid_toplivaTableAdapter = null;
            this.tableAdapterManager.ychet_ostTableAdapter = null;
            // 
            // sprav_postavDataGridView
            // 
            this.sprav_postavDataGridView.AutoGenerateColumns = false;
            this.sprav_postavDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sprav_postavDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.sprav_postavDataGridView.DataSource = this.sprav_postavBindingSource;
            this.sprav_postavDataGridView.Location = new System.Drawing.Point(12, 12);
            this.sprav_postavDataGridView.Name = "sprav_postavDataGridView";
            this.sprav_postavDataGridView.Size = new System.Drawing.Size(300, 426);
            this.sprav_postavDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "kod_postav";
            this.dataGridViewTextBoxColumn1.HeaderText = "Код поставщика";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Название";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // spravocnik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 450);
            this.Controls.Add(this.sprav_postavDataGridView);
            this.Name = "spravocnik";
            this.Text = "spravocnik";
            this.Load += new System.EventHandler(this.spravocnik_Load);
            ((System.ComponentModel.ISupportInitialize)(this.zapravkaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sprav_postavBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sprav_postavDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private zapravkaDataSet zapravkaDataSet;
        private System.Windows.Forms.BindingSource sprav_postavBindingSource;
        private zapravkaDataSetTableAdapters.sprav_postavTableAdapter sprav_postavTableAdapter;
        private zapravkaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView sprav_postavDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}