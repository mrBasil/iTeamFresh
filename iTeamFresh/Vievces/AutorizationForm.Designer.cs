namespace iTeamFresh.Vievces
{
    partial class AutorizationForm
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
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btn_logIn = new System.Windows.Forms.Button();
            this.cb_logIn = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(35, 64);
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '#';
            this.textBox2.Size = new System.Drawing.Size(153, 20);
            this.textBox2.TabIndex = 1;
            this.textBox2.Text = "Password*";
            // 
            // btn_logIn
            // 
            this.btn_logIn.Location = new System.Drawing.Point(35, 90);
            this.btn_logIn.Name = "btn_logIn";
            this.btn_logIn.Size = new System.Drawing.Size(153, 23);
            this.btn_logIn.TabIndex = 2;
            this.btn_logIn.Text = "logIn*";
            this.btn_logIn.UseVisualStyleBackColor = true;
            this.btn_logIn.Click += new System.EventHandler(this.btn_logIn_Click);
            // 
            // cb_logIn
            // 
            this.cb_logIn.FormattingEnabled = true;
            this.cb_logIn.Location = new System.Drawing.Point(35, 37);
            this.cb_logIn.Name = "cb_logIn";
            this.cb_logIn.Size = new System.Drawing.Size(153, 21);
            this.cb_logIn.TabIndex = 3;
            // 
            // AutorizationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(220, 148);
            this.Controls.Add(this.cb_logIn);
            this.Controls.Add(this.btn_logIn);
            this.Controls.Add(this.textBox2);
            this.Name = "AutorizationForm";
            this.Text = "AutorizationForm*";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btn_logIn;
        private System.Windows.Forms.ComboBox cb_logIn;
    }
}