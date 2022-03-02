namespace iTeamFresh.Vievces
{
    partial class CargoDirectoryForm
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
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cargoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aRTICLENUMBERDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dIRTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRICEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cARGOSENDERLINKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cARGORECIPIENTLINKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cARGOCARRIERLINKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cARGOSUPPLIERLINKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOTEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cargoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(30, 31);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 0;
            this.btn_add.Text = "add*";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(111, 31);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 1;
            this.btn_save.Text = "Save*";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(192, 31);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 23);
            this.btn_delete.TabIndex = 2;
            this.btn_delete.Text = "Delete*";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.nAMEDataGridViewTextBoxColumn,
            this.aRTICLENUMBERDataGridViewTextBoxColumn,
            this.dIRTDataGridViewTextBoxColumn,
            this.pRICEDataGridViewTextBoxColumn,
            this.cARGOSENDERLINKDataGridViewTextBoxColumn,
            this.cARGORECIPIENTLINKDataGridViewTextBoxColumn,
            this.cARGOCARRIERLINKDataGridViewTextBoxColumn,
            this.cARGOSUPPLIERLINKDataGridViewTextBoxColumn,
            this.nOTEDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.cargoBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(30, 63);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(788, 298);
            this.dataGridView1.TabIndex = 3;
            // 
            // cargoBindingSource
            // 
            this.cargoBindingSource.DataSource = typeof(DataBase.Cargo);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.Width = 50;
            // 
            // nAMEDataGridViewTextBoxColumn
            // 
            this.nAMEDataGridViewTextBoxColumn.DataPropertyName = "NAME";
            this.nAMEDataGridViewTextBoxColumn.HeaderText = "NAME";
            this.nAMEDataGridViewTextBoxColumn.Name = "nAMEDataGridViewTextBoxColumn";
            // 
            // aRTICLENUMBERDataGridViewTextBoxColumn
            // 
            this.aRTICLENUMBERDataGridViewTextBoxColumn.DataPropertyName = "ARTICLE_NUMBER";
            this.aRTICLENUMBERDataGridViewTextBoxColumn.HeaderText = "ARTICLE_NUMBER";
            this.aRTICLENUMBERDataGridViewTextBoxColumn.Name = "aRTICLENUMBERDataGridViewTextBoxColumn";
            // 
            // dIRTDataGridViewTextBoxColumn
            // 
            this.dIRTDataGridViewTextBoxColumn.DataPropertyName = "DIRT";
            this.dIRTDataGridViewTextBoxColumn.HeaderText = "DIRT";
            this.dIRTDataGridViewTextBoxColumn.Name = "dIRTDataGridViewTextBoxColumn";
            // 
            // pRICEDataGridViewTextBoxColumn
            // 
            this.pRICEDataGridViewTextBoxColumn.DataPropertyName = "PRICE";
            this.pRICEDataGridViewTextBoxColumn.HeaderText = "PRICE";
            this.pRICEDataGridViewTextBoxColumn.Name = "pRICEDataGridViewTextBoxColumn";
            // 
            // cARGOSENDERLINKDataGridViewTextBoxColumn
            // 
            this.cARGOSENDERLINKDataGridViewTextBoxColumn.DataPropertyName = "CARGO_SENDER_LINK";
            this.cARGOSENDERLINKDataGridViewTextBoxColumn.HeaderText = "CARGO_SENDER_LINK";
            this.cARGOSENDERLINKDataGridViewTextBoxColumn.Name = "cARGOSENDERLINKDataGridViewTextBoxColumn";
            this.cARGOSENDERLINKDataGridViewTextBoxColumn.Visible = false;
            // 
            // cARGORECIPIENTLINKDataGridViewTextBoxColumn
            // 
            this.cARGORECIPIENTLINKDataGridViewTextBoxColumn.DataPropertyName = "CARGO_RECIPIENT_LINK";
            this.cARGORECIPIENTLINKDataGridViewTextBoxColumn.HeaderText = "CARGO_RECIPIENT_LINK";
            this.cARGORECIPIENTLINKDataGridViewTextBoxColumn.Name = "cARGORECIPIENTLINKDataGridViewTextBoxColumn";
            this.cARGORECIPIENTLINKDataGridViewTextBoxColumn.Visible = false;
            // 
            // cARGOCARRIERLINKDataGridViewTextBoxColumn
            // 
            this.cARGOCARRIERLINKDataGridViewTextBoxColumn.DataPropertyName = "CARGO_CARRIER_LINK";
            this.cARGOCARRIERLINKDataGridViewTextBoxColumn.HeaderText = "CARGO_CARRIER_LINK";
            this.cARGOCARRIERLINKDataGridViewTextBoxColumn.Name = "cARGOCARRIERLINKDataGridViewTextBoxColumn";
            this.cARGOCARRIERLINKDataGridViewTextBoxColumn.Visible = false;
            // 
            // cARGOSUPPLIERLINKDataGridViewTextBoxColumn
            // 
            this.cARGOSUPPLIERLINKDataGridViewTextBoxColumn.DataPropertyName = "CARGO_SUPPLIER_LINK";
            this.cARGOSUPPLIERLINKDataGridViewTextBoxColumn.HeaderText = "CARGO_SUPPLIER_LINK";
            this.cARGOSUPPLIERLINKDataGridViewTextBoxColumn.Name = "cARGOSUPPLIERLINKDataGridViewTextBoxColumn";
            this.cARGOSUPPLIERLINKDataGridViewTextBoxColumn.Visible = false;
            // 
            // nOTEDataGridViewTextBoxColumn
            // 
            this.nOTEDataGridViewTextBoxColumn.DataPropertyName = "NOTE";
            this.nOTEDataGridViewTextBoxColumn.HeaderText = "NOTE";
            this.nOTEDataGridViewTextBoxColumn.Name = "nOTEDataGridViewTextBoxColumn";
            this.nOTEDataGridViewTextBoxColumn.Width = 300;
            // 
            // CargoDirectoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_add);
            this.Name = "CargoDirectoryForm";
            this.Text = "CargoDirectoryForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cargoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource cargoBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aRTICLENUMBERDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dIRTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRICEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cARGOSENDERLINKDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cARGORECIPIENTLINKDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cARGOCARRIERLINKDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cARGOSUPPLIERLINKDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOTEDataGridViewTextBoxColumn;
    }
}