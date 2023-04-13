namespace zapravka
{
    partial class uch
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
            System.Windows.Forms.Label kod_vidatoplLabel;
            System.Windows.Forms.Label kod_ychetaLabel;
            System.Windows.Forms.Label dataLabel;
            System.Windows.Forms.Label obiem_dnyaLabel;
            System.Windows.Forms.Label obiem_prodLabel;
            System.Windows.Forms.Label costLabel;
            this.zapravkaDataSet = new zapravka.zapravkaDataSet();
            this.ychet_ostBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ychet_ostTableAdapter = new zapravka.zapravkaDataSetTableAdapters.ychet_ostTableAdapter();
            this.tableAdapterManager = new zapravka.zapravkaDataSetTableAdapters.TableAdapterManager();
            this.kod_vidatoplComboBox = new System.Windows.Forms.ComboBox();
            this.vidtoplivaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vid_toplivaTableAdapter = new zapravka.zapravkaDataSetTableAdapters.vid_toplivaTableAdapter();
            this.ychet_ostBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.kod_ychetaTextBox = new System.Windows.Forms.TextBox();
            this.dataTextBox = new System.Windows.Forms.TextBox();
            this.obiem_dnyaTextBox = new System.Windows.Forms.TextBox();
            this.obiem_prodTextBox = new System.Windows.Forms.TextBox();
            this.costComboBox = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.button3 = new System.Windows.Forms.Button();
            kod_vidatoplLabel = new System.Windows.Forms.Label();
            kod_ychetaLabel = new System.Windows.Forms.Label();
            dataLabel = new System.Windows.Forms.Label();
            obiem_dnyaLabel = new System.Windows.Forms.Label();
            obiem_prodLabel = new System.Windows.Forms.Label();
            costLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.zapravkaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ychet_ostBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vidtoplivaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ychet_ostBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // zapravkaDataSet
            // 
            this.zapravkaDataSet.DataSetName = "zapravkaDataSet";
            this.zapravkaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ychet_ostBindingSource
            // 
            this.ychet_ostBindingSource.DataMember = "ychet_ost";
            this.ychet_ostBindingSource.DataSource = this.zapravkaDataSet;
            // 
            // ychet_ostTableAdapter
            // 
            this.ychet_ostTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.sprav_postavTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = zapravka.zapravkaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.vid_toplivaTableAdapter = this.vid_toplivaTableAdapter;
            this.tableAdapterManager.ychet_ostTableAdapter = this.ychet_ostTableAdapter;
            // 
            // kod_vidatoplLabel
            // 
            kod_vidatoplLabel.AutoSize = true;
            kod_vidatoplLabel.Location = new System.Drawing.Point(18, 8);
            kod_vidatoplLabel.Name = "kod_vidatoplLabel";
            kod_vidatoplLabel.Size = new System.Drawing.Size(70, 13);
            kod_vidatoplLabel.TabIndex = 1;
            kod_vidatoplLabel.Text = "Вид топлива";
            // 
            // kod_vidatoplComboBox
            // 
            this.kod_vidatoplComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ychet_ostBindingSource, "kod_vidatopl", true));
            this.kod_vidatoplComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.vidtoplivaBindingSource, "kod_vida", true));
            this.kod_vidatoplComboBox.DataSource = this.vidtoplivaBindingSource;
            this.kod_vidatoplComboBox.DisplayMember = "name";
            this.kod_vidatoplComboBox.FormattingEnabled = true;
            this.kod_vidatoplComboBox.Location = new System.Drawing.Point(92, 5);
            this.kod_vidatoplComboBox.Name = "kod_vidatoplComboBox";
            this.kod_vidatoplComboBox.Size = new System.Drawing.Size(121, 21);
            this.kod_vidatoplComboBox.TabIndex = 2;
            this.kod_vidatoplComboBox.ValueMember = "name";
            // 
            // vidtoplivaBindingSource
            // 
            this.vidtoplivaBindingSource.DataMember = "vid_topliva";
            this.vidtoplivaBindingSource.DataSource = this.zapravkaDataSet;
            // 
            // vid_toplivaTableAdapter
            // 
            this.vid_toplivaTableAdapter.ClearBeforeFill = true;
            // 
            // ychet_ostBindingSource1
            // 
            this.ychet_ostBindingSource1.DataMember = "FK_ychet_ost_vid_topliva";
            this.ychet_ostBindingSource1.DataSource = this.vidtoplivaBindingSource;
            // 
            // kod_ychetaLabel
            // 
            kod_ychetaLabel.AutoSize = true;
            kod_ychetaLabel.Location = new System.Drawing.Point(23, 35);
            kod_ychetaLabel.Name = "kod_ychetaLabel";
            kod_ychetaLabel.Size = new System.Drawing.Size(56, 13);
            kod_ychetaLabel.TabIndex = 3;
            kod_ychetaLabel.Text = "Код учета";
            // 
            // kod_ychetaTextBox
            // 
            this.kod_ychetaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ychet_ostBindingSource1, "kod_ycheta", true));
            this.kod_ychetaTextBox.Location = new System.Drawing.Point(92, 32);
            this.kod_ychetaTextBox.Name = "kod_ychetaTextBox";
            this.kod_ychetaTextBox.Size = new System.Drawing.Size(100, 20);
            this.kod_ychetaTextBox.TabIndex = 4;
            // 
            // dataLabel
            // 
            dataLabel.AutoSize = true;
            dataLabel.Location = new System.Drawing.Point(55, 61);
            dataLabel.Name = "dataLabel";
            dataLabel.Size = new System.Drawing.Size(33, 13);
            dataLabel.TabIndex = 5;
            dataLabel.Text = "Дата";
            // 
            // dataTextBox
            // 
            this.dataTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ychet_ostBindingSource1, "data", true));
            this.dataTextBox.Location = new System.Drawing.Point(92, 58);
            this.dataTextBox.Name = "dataTextBox";
            this.dataTextBox.Size = new System.Drawing.Size(100, 20);
            this.dataTextBox.TabIndex = 6;
            // 
            // obiem_dnyaLabel
            // 
            obiem_dnyaLabel.AutoSize = true;
            obiem_dnyaLabel.Location = new System.Drawing.Point(-1, 87);
            obiem_dnyaLabel.Name = "obiem_dnyaLabel";
            obiem_dnyaLabel.Size = new System.Drawing.Size(108, 13);
            obiem_dnyaLabel.TabIndex = 7;
            obiem_dnyaLabel.Text = "Обьем поступления";
            // 
            // obiem_dnyaTextBox
            // 
            this.obiem_dnyaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ychet_ostBindingSource1, "obiem_dnya", true));
            this.obiem_dnyaTextBox.Location = new System.Drawing.Point(113, 84);
            this.obiem_dnyaTextBox.Name = "obiem_dnyaTextBox";
            this.obiem_dnyaTextBox.Size = new System.Drawing.Size(100, 20);
            this.obiem_dnyaTextBox.TabIndex = 8;
            // 
            // obiem_prodLabel
            // 
            obiem_prodLabel.AutoSize = true;
            obiem_prodLabel.Location = new System.Drawing.Point(4, 113);
            obiem_prodLabel.Name = "obiem_prodLabel";
            obiem_prodLabel.Size = new System.Drawing.Size(82, 13);
            obiem_prodLabel.TabIndex = 9;
            obiem_prodLabel.Text = "Обьем продаж";
            // 
            // obiem_prodTextBox
            // 
            this.obiem_prodTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ychet_ostBindingSource1, "obiem_prod", true));
            this.obiem_prodTextBox.Location = new System.Drawing.Point(92, 110);
            this.obiem_prodTextBox.Name = "obiem_prodTextBox";
            this.obiem_prodTextBox.Size = new System.Drawing.Size(100, 20);
            this.obiem_prodTextBox.TabIndex = 10;
            // 
            // costLabel
            // 
            costLabel.AutoSize = true;
            costLabel.Location = new System.Drawing.Point(56, 139);
            costLabel.Name = "costLabel";
            costLabel.Size = new System.Drawing.Size(33, 13);
            costLabel.TabIndex = 11;
            costLabel.Text = "Цена";
            // 
            // costComboBox
            // 
            this.costComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vidtoplivaBindingSource, "cost", true));
            this.costComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.ychet_ostBindingSource, "kod_vidatopl", true));
            this.costComboBox.DataSource = this.vidtoplivaBindingSource;
            this.costComboBox.DisplayMember = "cost";
            this.costComboBox.FormattingEnabled = true;
            this.costComboBox.Location = new System.Drawing.Point(92, 136);
            this.costComboBox.Name = "costComboBox";
            this.costComboBox.Size = new System.Drawing.Size(121, 21);
            this.costComboBox.TabIndex = 12;
            this.costComboBox.ValueMember = "cost";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dataGridView1.Location = new System.Drawing.Point(26, 191);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(742, 288);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Код учета";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Дата";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Обьем поступления";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Обьем продаж";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Название ";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Цена";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Код поставщика";
            this.Column7.Name = "Column7";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1051, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 39);
            this.button1.TabIndex = 14;
            this.button1.Text = "В главное меню";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1051, 87);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 39);
            this.button2.TabIndex = 15;
            this.button2.Text = "Экспорт ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Location = new System.Drawing.Point(966, 191);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 189);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Сортировка";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "Код учета",
            "Дата",
            "Обьем поступления",
            "Обьем продаж",
            "Название ",
            "Цена",
            "Код поставщика"});
            this.listBox1.Location = new System.Drawing.Point(14, 19);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 17;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(19, 118);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(109, 17);
            this.radioButton1.TabIndex = 18;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "По возрастанию";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(19, 141);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(93, 17);
            this.radioButton2.TabIndex = 19;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "По убыванию";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(35, 160);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(141, 23);
            this.button3.TabIndex = 20;
            this.button3.Text = "Сортировать";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // uch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1280, 561);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(costLabel);
            this.Controls.Add(this.costComboBox);
            this.Controls.Add(obiem_prodLabel);
            this.Controls.Add(this.obiem_prodTextBox);
            this.Controls.Add(obiem_dnyaLabel);
            this.Controls.Add(this.obiem_dnyaTextBox);
            this.Controls.Add(dataLabel);
            this.Controls.Add(this.dataTextBox);
            this.Controls.Add(kod_ychetaLabel);
            this.Controls.Add(this.kod_ychetaTextBox);
            this.Controls.Add(kod_vidatoplLabel);
            this.Controls.Add(this.kod_vidatoplComboBox);
            this.Name = "uch";
            this.Text = "Учет";
            this.Load += new System.EventHandler(this.uch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.zapravkaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ychet_ostBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vidtoplivaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ychet_ostBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private zapravkaDataSet zapravkaDataSet;
        private System.Windows.Forms.BindingSource ychet_ostBindingSource;
        private zapravkaDataSetTableAdapters.ychet_ostTableAdapter ychet_ostTableAdapter;
        private zapravkaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private zapravkaDataSetTableAdapters.vid_toplivaTableAdapter vid_toplivaTableAdapter;
        private System.Windows.Forms.ComboBox kod_vidatoplComboBox;
        private System.Windows.Forms.BindingSource vidtoplivaBindingSource;
        private System.Windows.Forms.BindingSource ychet_ostBindingSource1;
        private System.Windows.Forms.TextBox kod_ychetaTextBox;
        private System.Windows.Forms.TextBox dataTextBox;
        private System.Windows.Forms.TextBox obiem_dnyaTextBox;
        private System.Windows.Forms.TextBox obiem_prodTextBox;
        private System.Windows.Forms.ComboBox costComboBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}