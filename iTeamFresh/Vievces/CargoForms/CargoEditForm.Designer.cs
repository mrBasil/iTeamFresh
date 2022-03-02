namespace iTeamFresh.Vievces
{
    partial class CargoEditForm
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
            this.lb_name = new System.Windows.Forms.Label();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.lb_articul = new System.Windows.Forms.Label();
            this.textBox_articul = new System.Windows.Forms.TextBox();
            this.lb_dirt = new System.Windows.Forms.Label();
            this.textBox_dirt = new System.Windows.Forms.TextBox();
            this.lb_price = new System.Windows.Forms.Label();
            this.textBox_price = new System.Windows.Forms.TextBox();
            this.lb_sender = new System.Windows.Forms.Label();
            this.comboBox_sender = new System.Windows.Forms.ComboBox();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lb_recipient = new System.Windows.Forms.Label();
            this.comboBox_recipient = new System.Windows.Forms.ComboBox();
            this.lb_carrier = new System.Windows.Forms.Label();
            this.comboBox_carrier = new System.Windows.Forms.ComboBox();
            this.lb_suplier = new System.Windows.Forms.Label();
            this.comboBox_suplier = new System.Windows.Forms.ComboBox();
            this.lb_note = new System.Windows.Forms.Label();
            this.textBox_note = new System.Windows.Forms.TextBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_name
            // 
            this.lb_name.AutoSize = true;
            this.lb_name.Location = new System.Drawing.Point(27, 23);
            this.lb_name.Name = "lb_name";
            this.lb_name.Size = new System.Drawing.Size(37, 13);
            this.lb_name.TabIndex = 0;
            this.lb_name.Text = "name*";
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(70, 20);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(100, 20);
            this.textBox_name.TabIndex = 1;
            // 
            // lb_articul
            // 
            this.lb_articul.AutoSize = true;
            this.lb_articul.Location = new System.Drawing.Point(25, 50);
            this.lb_articul.Name = "lb_articul";
            this.lb_articul.Size = new System.Drawing.Size(39, 13);
            this.lb_articul.TabIndex = 2;
            this.lb_articul.Text = "articul*";
            // 
            // textBox_articul
            // 
            this.textBox_articul.Location = new System.Drawing.Point(70, 47);
            this.textBox_articul.Name = "textBox_articul";
            this.textBox_articul.Size = new System.Drawing.Size(100, 20);
            this.textBox_articul.TabIndex = 3;
            // 
            // lb_dirt
            // 
            this.lb_dirt.AutoSize = true;
            this.lb_dirt.Location = new System.Drawing.Point(18, 81);
            this.lb_dirt.Name = "lb_dirt";
            this.lb_dirt.Size = new System.Drawing.Size(47, 13);
            this.lb_dirt.TabIndex = 4;
            this.lb_dirt.Text = "dirt in %*";
            // 
            // textBox_dirt
            // 
            this.textBox_dirt.Location = new System.Drawing.Point(71, 74);
            this.textBox_dirt.Name = "textBox_dirt";
            this.textBox_dirt.Size = new System.Drawing.Size(100, 20);
            this.textBox_dirt.TabIndex = 5;
            // 
            // lb_price
            // 
            this.lb_price.AutoSize = true;
            this.lb_price.Location = new System.Drawing.Point(30, 109);
            this.lb_price.Name = "lb_price";
            this.lb_price.Size = new System.Drawing.Size(34, 13);
            this.lb_price.TabIndex = 6;
            this.lb_price.Text = "price*";
            // 
            // textBox_price
            // 
            this.textBox_price.Location = new System.Drawing.Point(71, 106);
            this.textBox_price.Name = "textBox_price";
            this.textBox_price.Size = new System.Drawing.Size(100, 20);
            this.textBox_price.TabIndex = 7;
            // 
            // lb_sender
            // 
            this.lb_sender.AutoSize = true;
            this.lb_sender.Location = new System.Drawing.Point(19, 141);
            this.lb_sender.Name = "lb_sender";
            this.lb_sender.Size = new System.Drawing.Size(46, 13);
            this.lb_sender.TabIndex = 8;
            this.lb_sender.Text = "sender *";
            // 
            // comboBox_sender
            // 
            this.comboBox_sender.DataSource = this.clientBindingSource;
            this.comboBox_sender.DisplayMember = "NAME";
            this.comboBox_sender.FormattingEnabled = true;
            this.comboBox_sender.Location = new System.Drawing.Point(71, 138);
            this.comboBox_sender.Name = "comboBox_sender";
            this.comboBox_sender.Size = new System.Drawing.Size(367, 21);
            this.comboBox_sender.TabIndex = 9;
            this.comboBox_sender.ValueMember = "ID";
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataSource = typeof(DataBase.Client);
            // 
            // lb_recipient
            // 
            this.lb_recipient.AutoSize = true;
            this.lb_recipient.Location = new System.Drawing.Point(14, 177);
            this.lb_recipient.Name = "lb_recipient";
            this.lb_recipient.Size = new System.Drawing.Size(51, 13);
            this.lb_recipient.TabIndex = 10;
            this.lb_recipient.Text = "recipient*";
            // 
            // comboBox_recipient
            // 
            this.comboBox_recipient.DataSource = this.clientBindingSource;
            this.comboBox_recipient.DisplayMember = "NAME";
            this.comboBox_recipient.FormattingEnabled = true;
            this.comboBox_recipient.Location = new System.Drawing.Point(71, 174);
            this.comboBox_recipient.Name = "comboBox_recipient";
            this.comboBox_recipient.Size = new System.Drawing.Size(367, 21);
            this.comboBox_recipient.TabIndex = 11;
            this.comboBox_recipient.ValueMember = "ID";
            // 
            // lb_carrier
            // 
            this.lb_carrier.AutoSize = true;
            this.lb_carrier.Location = new System.Drawing.Point(24, 212);
            this.lb_carrier.Name = "lb_carrier";
            this.lb_carrier.Size = new System.Drawing.Size(40, 13);
            this.lb_carrier.TabIndex = 12;
            this.lb_carrier.Text = "carrier*";
            // 
            // comboBox_carrier
            // 
            this.comboBox_carrier.DataSource = this.clientBindingSource;
            this.comboBox_carrier.DisplayMember = "NAME";
            this.comboBox_carrier.FormattingEnabled = true;
            this.comboBox_carrier.Location = new System.Drawing.Point(71, 209);
            this.comboBox_carrier.Name = "comboBox_carrier";
            this.comboBox_carrier.Size = new System.Drawing.Size(367, 21);
            this.comboBox_carrier.TabIndex = 13;
            this.comboBox_carrier.ValueMember = "ID";
            // 
            // lb_suplier
            // 
            this.lb_suplier.AutoSize = true;
            this.lb_suplier.Location = new System.Drawing.Point(24, 249);
            this.lb_suplier.Name = "lb_suplier";
            this.lb_suplier.Size = new System.Drawing.Size(41, 13);
            this.lb_suplier.TabIndex = 14;
            this.lb_suplier.Text = "suplier*";
            // 
            // comboBox_suplier
            // 
            this.comboBox_suplier.DataSource = this.clientBindingSource;
            this.comboBox_suplier.DisplayMember = "NAME";
            this.comboBox_suplier.FormattingEnabled = true;
            this.comboBox_suplier.Location = new System.Drawing.Point(71, 246);
            this.comboBox_suplier.Name = "comboBox_suplier";
            this.comboBox_suplier.Size = new System.Drawing.Size(367, 21);
            this.comboBox_suplier.TabIndex = 15;
            this.comboBox_suplier.ValueMember = "ID";
            // 
            // lb_note
            // 
            this.lb_note.AutoSize = true;
            this.lb_note.Location = new System.Drawing.Point(32, 286);
            this.lb_note.Name = "lb_note";
            this.lb_note.Size = new System.Drawing.Size(32, 13);
            this.lb_note.TabIndex = 16;
            this.lb_note.Text = "note*";
            // 
            // textBox_note
            // 
            this.textBox_note.Location = new System.Drawing.Point(71, 283);
            this.textBox_note.Multiline = true;
            this.textBox_note.Name = "textBox_note";
            this.textBox_note.Size = new System.Drawing.Size(367, 119);
            this.textBox_note.TabIndex = 17;
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(282, 415);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 18;
            this.btn_save.Text = "save*";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(363, 415);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 19;
            this.btn_cancel.Text = "cancel*";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // CargoEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 450);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.textBox_note);
            this.Controls.Add(this.lb_note);
            this.Controls.Add(this.comboBox_suplier);
            this.Controls.Add(this.lb_suplier);
            this.Controls.Add(this.comboBox_carrier);
            this.Controls.Add(this.lb_carrier);
            this.Controls.Add(this.comboBox_recipient);
            this.Controls.Add(this.lb_recipient);
            this.Controls.Add(this.comboBox_sender);
            this.Controls.Add(this.lb_sender);
            this.Controls.Add(this.textBox_price);
            this.Controls.Add(this.lb_price);
            this.Controls.Add(this.textBox_dirt);
            this.Controls.Add(this.lb_dirt);
            this.Controls.Add(this.textBox_articul);
            this.Controls.Add(this.lb_articul);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.lb_name);
            this.Name = "CargoEditForm";
            this.Text = "CargoEditForm";
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_name;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.Label lb_articul;
        private System.Windows.Forms.TextBox textBox_articul;
        private System.Windows.Forms.Label lb_dirt;
        private System.Windows.Forms.TextBox textBox_dirt;
        private System.Windows.Forms.Label lb_price;
        private System.Windows.Forms.TextBox textBox_price;
        private System.Windows.Forms.Label lb_sender;
        private System.Windows.Forms.ComboBox comboBox_sender;
        private System.Windows.Forms.Label lb_recipient;
        private System.Windows.Forms.ComboBox comboBox_recipient;
        private System.Windows.Forms.Label lb_carrier;
        private System.Windows.Forms.ComboBox comboBox_carrier;
        private System.Windows.Forms.Label lb_suplier;
        private System.Windows.Forms.ComboBox comboBox_suplier;
        private System.Windows.Forms.Label lb_note;
        private System.Windows.Forms.TextBox textBox_note;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.BindingSource clientBindingSource;
    }
}