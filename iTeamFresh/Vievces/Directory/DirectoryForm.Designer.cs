
namespace iTeamFresh.Vievces.Directory
{
    partial class DirectoryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DirectoryForm));
            this.tsControlPanel = new System.Windows.Forms.ToolStrip();
            this.tsbAdd = new System.Windows.Forms.ToolStripButton();
            this.tsbEdit = new System.Windows.Forms.ToolStripButton();
            this.tsbDel = new System.Windows.Forms.ToolStripButton();
            this.dgvDirectory = new System.Windows.Forms.DataGridView();
            this.tsControlPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDirectory)).BeginInit();
            this.SuspendLayout();
            // 
            // tsControlPanel
            // 
            this.tsControlPanel.ImageScalingSize = new System.Drawing.Size(25, 25);
            this.tsControlPanel.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbAdd,
            this.tsbEdit,
            this.tsbDel});
            this.tsControlPanel.Location = new System.Drawing.Point(0, 0);
            this.tsControlPanel.Name = "tsControlPanel";
            this.tsControlPanel.Size = new System.Drawing.Size(570, 25);
            this.tsControlPanel.TabIndex = 0;
            this.tsControlPanel.Text = "tsControlPanel";
            // 
            // tsbAdd
            // 
            this.tsbAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbAdd.Image = ((System.Drawing.Image)(resources.GetObject("tsbAdd.Image")));
            this.tsbAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAdd.Name = "tsbAdd";
            this.tsbAdd.Size = new System.Drawing.Size(33, 22);
            this.tsbAdd.Text = "Add";
            this.tsbAdd.Click += new System.EventHandler(this.tsbAdd_Click);
            // 
            // tsbEdit
            // 
            this.tsbEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbEdit.Image = ((System.Drawing.Image)(resources.GetObject("tsbEdit.Image")));
            this.tsbEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEdit.Name = "tsbEdit";
            this.tsbEdit.Size = new System.Drawing.Size(31, 22);
            this.tsbEdit.Text = "Edit";
            // 
            // tsbDel
            // 
            this.tsbDel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbDel.Image = ((System.Drawing.Image)(resources.GetObject("tsbDel.Image")));
            this.tsbDel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDel.Name = "tsbDel";
            this.tsbDel.Size = new System.Drawing.Size(28, 22);
            this.tsbDel.Text = "Del";
            // 
            // dgvDirectory
            // 
            this.dgvDirectory.AllowUserToAddRows = false;
            this.dgvDirectory.AllowUserToDeleteRows = false;
            this.dgvDirectory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDirectory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDirectory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDirectory.Location = new System.Drawing.Point(0, 25);
            this.dgvDirectory.MultiSelect = false;
            this.dgvDirectory.Name = "dgvDirectory";
            this.dgvDirectory.ReadOnly = true;
            this.dgvDirectory.RowHeadersVisible = false;
            this.dgvDirectory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDirectory.Size = new System.Drawing.Size(570, 425);
            this.dgvDirectory.TabIndex = 1;
            // 
            // DirectoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 450);
            this.Controls.Add(this.dgvDirectory);
            this.Controls.Add(this.tsControlPanel);
            this.Name = "DirectoryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "DirectoryForm";
            this.tsControlPanel.ResumeLayout(false);
            this.tsControlPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDirectory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsControlPanel;
        private System.Windows.Forms.DataGridView dgvDirectory;
        private System.Windows.Forms.ToolStripButton tsbAdd;
        private System.Windows.Forms.ToolStripButton tsbEdit;
        private System.Windows.Forms.ToolStripButton tsbDel;
    }
}