namespace ARM_Delivery
{
    partial class Form6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.отзывыBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.aRMDataSet1 = new ARM_Delivery.ARMDataSet1();
            this.отзывыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aRMDataSet = new ARM_Delivery.ARMDataSet();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.отзывыTableAdapter = new ARM_Delivery.ARMDataSetTableAdapters.ОтзывыTableAdapter();
            this.отзывыTableAdapter1 = new ARM_Delivery.ARMDataSet1TableAdapters.ОтзывыTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.отзывыBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aRMDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.отзывыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aRMDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewCheckBoxColumn2});
            this.dataGridView1.DataSource = this.отзывыBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(659, 271);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Код";
            this.dataGridViewTextBoxColumn1.HeaderText = "Код";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ФИО";
            this.dataGridViewTextBoxColumn2.HeaderText = "ФИО";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Отзыв";
            this.dataGridViewTextBoxColumn3.HeaderText = "Отзыв";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Дата";
            this.dataGridViewTextBoxColumn4.HeaderText = "Дата";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "Статус отзыва";
            this.dataGridViewCheckBoxColumn1.HeaderText = "Статус отзыва";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            // 
            // dataGridViewCheckBoxColumn2
            // 
            this.dataGridViewCheckBoxColumn2.DataPropertyName = "Статус проверки";
            this.dataGridViewCheckBoxColumn2.HeaderText = "Статус проверки";
            this.dataGridViewCheckBoxColumn2.Name = "dataGridViewCheckBoxColumn2";
            // 
            // отзывыBindingSource1
            // 
            this.отзывыBindingSource1.DataMember = "Отзывы";
            this.отзывыBindingSource1.DataSource = this.aRMDataSet1;
            // 
            // aRMDataSet1
            // 
            this.aRMDataSet1.DataSetName = "ARMDataSet1";
            this.aRMDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // отзывыBindingSource
            // 
            this.отзывыBindingSource.DataMember = "Отзывы";
            this.отзывыBindingSource.DataSource = this.aRMDataSet;
            // 
            // aRMDataSet
            // 
            this.aRMDataSet.DataSetName = "ARMDataSet";
            this.aRMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(441, 299);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(153, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Выход в меню";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(95, 299);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(153, 23);
            this.button4.TabIndex = 4;
            this.button4.Text = "Помощь";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // отзывыTableAdapter
            // 
            this.отзывыTableAdapter.ClearBeforeFill = true;
            // 
            // отзывыTableAdapter1
            // 
            this.отзывыTableAdapter1.ClearBeforeFill = true;
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 336);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form6";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Отзывы";
            this.Load += new System.EventHandler(this.Form6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.отзывыBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aRMDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.отзывыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aRMDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фИОDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn отзывDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn статусОтзываDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn статусПроверкиDataGridViewCheckBoxColumn;
        private System.Windows.Forms.Button button4;
        private ARMDataSet aRMDataSet;
        private System.Windows.Forms.BindingSource отзывыBindingSource;
        private ARMDataSetTableAdapters.ОтзывыTableAdapter отзывыTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn2;
        private ARMDataSet1 aRMDataSet1;
        private System.Windows.Forms.BindingSource отзывыBindingSource1;
        private ARMDataSet1TableAdapters.ОтзывыTableAdapter отзывыTableAdapter1;
    }
}