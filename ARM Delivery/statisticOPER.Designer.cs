namespace ARM_Delivery
{
    partial class statisticOPER
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(statisticOPER));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.aRMDataSet1 = new ARM_Delivery.ARMDataSet1();
            this.выручкаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.выручкаTableAdapter = new ARM_Delivery.ARMDataSet1TableAdapters.ВыручкаTableAdapter();
            this.кодDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.выручкаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.операторDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aRMDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.выручкаBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Location = new System.Drawing.Point(500, 78);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 88);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Прочее";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(9, 48);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(185, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Выход в меню";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(9, 19);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(185, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Помощь";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Location = new System.Drawing.Point(500, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 60);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Работа с отчетами";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(9, 19);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(185, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Добавить отчет";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодDataGridViewTextBoxColumn,
            this.датаDataGridViewTextBoxColumn,
            this.выручкаDataGridViewTextBoxColumn,
            this.операторDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.выручкаBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(470, 351);
            this.dataGridView1.TabIndex = 6;
            // 
            // aRMDataSet1
            // 
            this.aRMDataSet1.DataSetName = "ARMDataSet1";
            this.aRMDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // выручкаBindingSource
            // 
            this.выручкаBindingSource.DataMember = "Выручка";
            this.выручкаBindingSource.DataSource = this.aRMDataSet1;
            // 
            // выручкаTableAdapter
            // 
            this.выручкаTableAdapter.ClearBeforeFill = true;
            // 
            // кодDataGridViewTextBoxColumn
            // 
            this.кодDataGridViewTextBoxColumn.DataPropertyName = "Код";
            this.кодDataGridViewTextBoxColumn.HeaderText = "Код";
            this.кодDataGridViewTextBoxColumn.Name = "кодDataGridViewTextBoxColumn";
            this.кодDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // датаDataGridViewTextBoxColumn
            // 
            this.датаDataGridViewTextBoxColumn.DataPropertyName = "Дата";
            this.датаDataGridViewTextBoxColumn.HeaderText = "Дата";
            this.датаDataGridViewTextBoxColumn.Name = "датаDataGridViewTextBoxColumn";
            this.датаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // выручкаDataGridViewTextBoxColumn
            // 
            this.выручкаDataGridViewTextBoxColumn.DataPropertyName = "Выручка";
            this.выручкаDataGridViewTextBoxColumn.HeaderText = "Выручка";
            this.выручкаDataGridViewTextBoxColumn.Name = "выручкаDataGridViewTextBoxColumn";
            this.выручкаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // операторDataGridViewTextBoxColumn
            // 
            this.операторDataGridViewTextBoxColumn.DataPropertyName = "Оператор";
            this.операторDataGridViewTextBoxColumn.HeaderText = "Оператор";
            this.операторDataGridViewTextBoxColumn.Name = "операторDataGridViewTextBoxColumn";
            this.операторDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // statisticOPER
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 399);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "statisticOPER";
            this.Text = "Статистика";
            this.Activated += new System.EventHandler(this.statisticOPER_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.statisticOPER_FormClosed);
            this.Load += new System.EventHandler(this.statisticOPER_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aRMDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.выручкаBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private ARMDataSet1 aRMDataSet1;
        private System.Windows.Forms.BindingSource выручкаBindingSource;
        private ARMDataSet1TableAdapters.ВыручкаTableAdapter выручкаTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn выручкаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn операторDataGridViewTextBoxColumn;
    }
}