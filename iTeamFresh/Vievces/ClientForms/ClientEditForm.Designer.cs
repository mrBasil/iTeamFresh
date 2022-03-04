namespace iTeamFresh.Vievces.ClientForms
{
    partial class ClientEditForm
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
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.lb_name = new System.Windows.Forms.Label();
            this.lb_adress = new System.Windows.Forms.Label();
            this.textBox_adress = new System.Windows.Forms.TextBox();
            this.lb_inn = new System.Windows.Forms.Label();
            this.textBox_inn = new System.Windows.Forms.TextBox();
            this.lb_KPP = new System.Windows.Forms.Label();
            this.textBox_KPP = new System.Windows.Forms.TextBox();
            this.lb_egrul = new System.Windows.Forms.Label();
            this.textBox_egrul = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_note = new System.Windows.Forms.TextBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(84, 12);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(100, 20);
            this.textBox_name.TabIndex = 0;
            // 
            // lb_name
            // 
            this.lb_name.AutoSize = true;
            this.lb_name.Location = new System.Drawing.Point(20, 19);
            this.lb_name.Name = "lb_name";
            this.lb_name.Size = new System.Drawing.Size(37, 13);
            this.lb_name.TabIndex = 1;
            this.lb_name.Text = "name*";
            // 
            // lb_adress
            // 
            this.lb_adress.AutoSize = true;
            this.lb_adress.Location = new System.Drawing.Point(15, 41);
            this.lb_adress.Name = "lb_adress";
            this.lb_adress.Size = new System.Drawing.Size(42, 13);
            this.lb_adress.TabIndex = 2;
            this.lb_adress.Text = "adress*";
            // 
            // textBox_adress
            // 
            this.textBox_adress.Location = new System.Drawing.Point(84, 38);
            this.textBox_adress.Name = "textBox_adress";
            this.textBox_adress.Size = new System.Drawing.Size(100, 20);
            this.textBox_adress.TabIndex = 3;
            // 
            // lb_inn
            // 
            this.lb_inn.AutoSize = true;
            this.lb_inn.Location = new System.Drawing.Point(32, 67);
            this.lb_inn.Name = "lb_inn";
            this.lb_inn.Size = new System.Drawing.Size(25, 13);
            this.lb_inn.TabIndex = 4;
            this.lb_inn.Text = "inn*";
            // 
            // textBox_inn
            // 
            this.textBox_inn.Location = new System.Drawing.Point(84, 64);
            this.textBox_inn.Name = "textBox_inn";
            this.textBox_inn.Size = new System.Drawing.Size(100, 20);
            this.textBox_inn.TabIndex = 5;
            // 
            // lb_KPP
            // 
            this.lb_KPP.AutoSize = true;
            this.lb_KPP.Location = new System.Drawing.Point(25, 93);
            this.lb_KPP.Name = "lb_KPP";
            this.lb_KPP.Size = new System.Drawing.Size(32, 13);
            this.lb_KPP.TabIndex = 6;
            this.lb_KPP.Text = "KPP*";
            // 
            // textBox_KPP
            // 
            this.textBox_KPP.Location = new System.Drawing.Point(84, 90);
            this.textBox_KPP.Name = "textBox_KPP";
            this.textBox_KPP.Size = new System.Drawing.Size(100, 20);
            this.textBox_KPP.TabIndex = 7;
            // 
            // lb_egrul
            // 
            this.lb_egrul.AutoSize = true;
            this.lb_egrul.Location = new System.Drawing.Point(23, 119);
            this.lb_egrul.Name = "lb_egrul";
            this.lb_egrul.Size = new System.Drawing.Size(34, 13);
            this.lb_egrul.TabIndex = 8;
            this.lb_egrul.Text = "egrul*";
            // 
            // textBox_egrul
            // 
            this.textBox_egrul.Location = new System.Drawing.Point(84, 116);
            this.textBox_egrul.Name = "textBox_egrul";
            this.textBox_egrul.Size = new System.Drawing.Size(100, 20);
            this.textBox_egrul.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "note*";
            // 
            // textBox_note
            // 
            this.textBox_note.Location = new System.Drawing.Point(84, 145);
            this.textBox_note.Multiline = true;
            this.textBox_note.Name = "textBox_note";
            this.textBox_note.Size = new System.Drawing.Size(504, 269);
            this.textBox_note.TabIndex = 11;
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(396, 420);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 12;
            this.btn_save.Text = "save*";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(477, 420);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 13;
            this.btn_cancel.Text = "cancel*";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // ClientEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 450);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.textBox_note);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_egrul);
            this.Controls.Add(this.lb_egrul);
            this.Controls.Add(this.textBox_KPP);
            this.Controls.Add(this.lb_KPP);
            this.Controls.Add(this.textBox_inn);
            this.Controls.Add(this.lb_inn);
            this.Controls.Add(this.textBox_adress);
            this.Controls.Add(this.lb_adress);
            this.Controls.Add(this.lb_name);
            this.Controls.Add(this.textBox_name);
            this.Name = "ClientEditForm";
            this.Text = "ClientEditForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.Label lb_name;
        private System.Windows.Forms.Label lb_adress;
        private System.Windows.Forms.TextBox textBox_adress;
        private System.Windows.Forms.Label lb_inn;
        private System.Windows.Forms.TextBox textBox_inn;
        private System.Windows.Forms.Label lb_KPP;
        private System.Windows.Forms.TextBox textBox_KPP;
        private System.Windows.Forms.Label lb_egrul;
        private System.Windows.Forms.TextBox textBox_egrul;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_note;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_cancel;
    }
}