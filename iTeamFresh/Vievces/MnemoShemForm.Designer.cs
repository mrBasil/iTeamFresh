namespace iTeamFresh.Vievces
{
    partial class MnemoShemForm
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
            this.lb_weight = new System.Windows.Forms.Label();
            this.btn_greenOut = new System.Windows.Forms.Button();
            this.btn_redOut = new System.Windows.Forms.Button();
            this.btn_redIn = new System.Windows.Forms.Button();
            this.btn_greenIn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_weight
            // 
            this.lb_weight.AutoSize = true;
            this.lb_weight.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_weight.ForeColor = System.Drawing.Color.Black;
            this.lb_weight.Location = new System.Drawing.Point(153, 11);
            this.lb_weight.Name = "lb_weight";
            this.lb_weight.Size = new System.Drawing.Size(123, 55);
            this.lb_weight.TabIndex = 0;
            this.lb_weight.Text = "ВЕС";
            this.lb_weight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lb_weight.Click += new System.EventHandler(this.lb_weight_Click);
            // 
            // btn_greenOut
            // 
            this.btn_greenOut.Image = global::iTeamFresh.Properties.Resources.серый1;
            this.btn_greenOut.Location = new System.Drawing.Point(7, 71);
            this.btn_greenOut.Name = "btn_greenOut";
            this.btn_greenOut.Size = new System.Drawing.Size(57, 60);
            this.btn_greenOut.TabIndex = 2;
            this.btn_greenOut.UseVisualStyleBackColor = true;
            this.btn_greenOut.Click += new System.EventHandler(this.btn_greenOut_Click);
            // 
            // btn_redOut
            // 
            this.btn_redOut.Image = global::iTeamFresh.Properties.Resources.серый1;
            this.btn_redOut.Location = new System.Drawing.Point(7, 11);
            this.btn_redOut.Name = "btn_redOut";
            this.btn_redOut.Size = new System.Drawing.Size(57, 60);
            this.btn_redOut.TabIndex = 3;
            this.btn_redOut.UseVisualStyleBackColor = true;
            this.btn_redOut.Click += new System.EventHandler(this.btn_redOut_Click);
            // 
            // btn_redIn
            // 
            this.btn_redIn.Image = global::iTeamFresh.Properties.Resources.серый1;
            this.btn_redIn.Location = new System.Drawing.Point(384, 11);
            this.btn_redIn.Name = "btn_redIn";
            this.btn_redIn.Size = new System.Drawing.Size(57, 60);
            this.btn_redIn.TabIndex = 4;
            this.btn_redIn.UseVisualStyleBackColor = true;
            this.btn_redIn.Click += new System.EventHandler(this.btn_redIn_Click);
            // 
            // btn_greenIn
            // 
            this.btn_greenIn.Image = global::iTeamFresh.Properties.Resources.серый1;
            this.btn_greenIn.Location = new System.Drawing.Point(384, 71);
            this.btn_greenIn.Name = "btn_greenIn";
            this.btn_greenIn.Size = new System.Drawing.Size(57, 60);
            this.btn_greenIn.TabIndex = 5;
            this.btn_greenIn.UseVisualStyleBackColor = true;
            this.btn_greenIn.Click += new System.EventHandler(this.btn_greenIn_Click);
            // 
            // MnemoShemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 140);
            this.Controls.Add(this.btn_greenIn);
            this.Controls.Add(this.btn_redIn);
            this.Controls.Add(this.btn_redOut);
            this.Controls.Add(this.btn_greenOut);
            this.Controls.Add(this.lb_weight);
            this.Name = "MnemoShemForm";
            this.Text = "Мнемосхема";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_weight;
        private System.Windows.Forms.Button btn_greenOut;
        private System.Windows.Forms.Button btn_redOut;
        private System.Windows.Forms.Button btn_redIn;
        private System.Windows.Forms.Button btn_greenIn;
    }
}