namespace iTeamFresh.Vievces
{
    partial class SettingsForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.indicatorPage = new System.Windows.Forms.TabPage();
            this.lb_com_ind_settings = new System.Windows.Forms.Label();
            this.lb_prot_indic_settings = new System.Windows.Forms.Label();
            this.lb_time_stab_ind_settings = new System.Windows.Forms.Label();
            this.num_time_stab = new System.Windows.Forms.NumericUpDown();
            this.btn_save_indic_settings = new System.Windows.Forms.Button();
            this.comboBox_Idic_prot = new System.Windows.Forms.ComboBox();
            this.comboBox_com_budeRate = new System.Windows.Forms.ComboBox();
            this.comboBox_com = new System.Windows.Forms.ComboBox();
            this.IOPage = new System.Windows.Forms.TabPage();
            this.lb_device_IO = new System.Windows.Forms.Label();
            this.lb_com_IO = new System.Windows.Forms.Label();
            this.btn_save_IO = new System.Windows.Forms.Button();
            this.comboBox_device_IO = new System.Windows.Forms.ComboBox();
            this.comboBox_BuadeRate_IO = new System.Windows.Forms.ComboBox();
            this.comboBox_com_IO = new System.Windows.Forms.ComboBox();
            this.ScoreboardPage = new System.Windows.Forms.TabPage();
            this.DataBasePage = new System.Windows.Forms.TabPage();
            this.FirmPage = new System.Windows.Forms.TabPage();
            this.SettingsPage = new System.Windows.Forms.TabPage();
            this.CameraPage = new System.Windows.Forms.TabPage();
            this.RFIDPage = new System.Windows.Forms.TabPage();
            this.comboBox_ScoreB_Com = new System.Windows.Forms.ComboBox();
            this.comboBox_ScoreBorde_buadeRate = new System.Windows.Forms.ComboBox();
            this.comboBox_ScoreBoard_prot = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_path = new System.Windows.Forms.TextBox();
            this.btn_file = new System.Windows.Forms.Button();
            this.btn_save_DB_page = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.indicatorPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_time_stab)).BeginInit();
            this.IOPage.SuspendLayout();
            this.ScoreboardPage.SuspendLayout();
            this.DataBasePage.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.indicatorPage);
            this.tabControl1.Controls.Add(this.IOPage);
            this.tabControl1.Controls.Add(this.ScoreboardPage);
            this.tabControl1.Controls.Add(this.DataBasePage);
            this.tabControl1.Controls.Add(this.FirmPage);
            this.tabControl1.Controls.Add(this.SettingsPage);
            this.tabControl1.Controls.Add(this.CameraPage);
            this.tabControl1.Controls.Add(this.RFIDPage);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(581, 425);
            this.tabControl1.TabIndex = 0;
            // 
            // indicatorPage
            // 
            this.indicatorPage.Controls.Add(this.lb_com_ind_settings);
            this.indicatorPage.Controls.Add(this.lb_prot_indic_settings);
            this.indicatorPage.Controls.Add(this.lb_time_stab_ind_settings);
            this.indicatorPage.Controls.Add(this.num_time_stab);
            this.indicatorPage.Controls.Add(this.btn_save_indic_settings);
            this.indicatorPage.Controls.Add(this.comboBox_Idic_prot);
            this.indicatorPage.Controls.Add(this.comboBox_com_budeRate);
            this.indicatorPage.Controls.Add(this.comboBox_com);
            this.indicatorPage.Location = new System.Drawing.Point(4, 22);
            this.indicatorPage.Name = "indicatorPage";
            this.indicatorPage.Padding = new System.Windows.Forms.Padding(3);
            this.indicatorPage.Size = new System.Drawing.Size(573, 399);
            this.indicatorPage.TabIndex = 0;
            this.indicatorPage.Text = "indicator*";
            this.indicatorPage.UseVisualStyleBackColor = true;
            // 
            // lb_com_ind_settings
            // 
            this.lb_com_ind_settings.AutoSize = true;
            this.lb_com_ind_settings.Location = new System.Drawing.Point(78, 39);
            this.lb_com_ind_settings.Name = "lb_com_ind_settings";
            this.lb_com_ind_settings.Size = new System.Drawing.Size(49, 13);
            this.lb_com_ind_settings.TabIndex = 7;
            this.lb_com_ind_settings.Text = "com pot*";
            this.lb_com_ind_settings.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lb_prot_indic_settings
            // 
            this.lb_prot_indic_settings.AutoSize = true;
            this.lb_prot_indic_settings.Location = new System.Drawing.Point(78, 82);
            this.lb_prot_indic_settings.Name = "lb_prot_indic_settings";
            this.lb_prot_indic_settings.Size = new System.Drawing.Size(49, 13);
            this.lb_prot_indic_settings.TabIndex = 6;
            this.lb_prot_indic_settings.Text = "protocol*";
            this.lb_prot_indic_settings.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lb_time_stab_ind_settings
            // 
            this.lb_time_stab_ind_settings.AutoSize = true;
            this.lb_time_stab_ind_settings.Location = new System.Drawing.Point(71, 121);
            this.lb_time_stab_ind_settings.Name = "lb_time_stab_ind_settings";
            this.lb_time_stab_ind_settings.Size = new System.Drawing.Size(56, 13);
            this.lb_time_stab_ind_settings.TabIndex = 5;
            this.lb_time_stab_ind_settings.Text = "time_stab*";
            this.lb_time_stab_ind_settings.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // num_time_stab
            // 
            this.num_time_stab.Location = new System.Drawing.Point(153, 121);
            this.num_time_stab.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.num_time_stab.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_time_stab.Name = "num_time_stab";
            this.num_time_stab.Size = new System.Drawing.Size(39, 20);
            this.num_time_stab.TabIndex = 4;
            this.num_time_stab.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btn_save_indic_settings
            // 
            this.btn_save_indic_settings.Location = new System.Drawing.Point(492, 370);
            this.btn_save_indic_settings.Name = "btn_save_indic_settings";
            this.btn_save_indic_settings.Size = new System.Drawing.Size(75, 23);
            this.btn_save_indic_settings.TabIndex = 3;
            this.btn_save_indic_settings.Text = "Save*";
            this.btn_save_indic_settings.UseVisualStyleBackColor = true;
            this.btn_save_indic_settings.Click += new System.EventHandler(this.btn_save_indic_settings_Click);
            // 
            // comboBox_Idic_prot
            // 
            this.comboBox_Idic_prot.FormattingEnabled = true;
            this.comboBox_Idic_prot.Location = new System.Drawing.Point(153, 79);
            this.comboBox_Idic_prot.Name = "comboBox_Idic_prot";
            this.comboBox_Idic_prot.Size = new System.Drawing.Size(173, 21);
            this.comboBox_Idic_prot.TabIndex = 2;
            // 
            // comboBox_com_budeRate
            // 
            this.comboBox_com_budeRate.FormattingEnabled = true;
            this.comboBox_com_budeRate.Location = new System.Drawing.Point(234, 39);
            this.comboBox_com_budeRate.Name = "comboBox_com_budeRate";
            this.comboBox_com_budeRate.Size = new System.Drawing.Size(92, 21);
            this.comboBox_com_budeRate.TabIndex = 1;
            // 
            // comboBox_com
            // 
            this.comboBox_com.FormattingEnabled = true;
            this.comboBox_com.Location = new System.Drawing.Point(153, 39);
            this.comboBox_com.Name = "comboBox_com";
            this.comboBox_com.Size = new System.Drawing.Size(75, 21);
            this.comboBox_com.TabIndex = 0;
            // 
            // IOPage
            // 
            this.IOPage.Controls.Add(this.lb_device_IO);
            this.IOPage.Controls.Add(this.lb_com_IO);
            this.IOPage.Controls.Add(this.btn_save_IO);
            this.IOPage.Controls.Add(this.comboBox_device_IO);
            this.IOPage.Controls.Add(this.comboBox_BuadeRate_IO);
            this.IOPage.Controls.Add(this.comboBox_com_IO);
            this.IOPage.Location = new System.Drawing.Point(4, 22);
            this.IOPage.Name = "IOPage";
            this.IOPage.Padding = new System.Windows.Forms.Padding(3);
            this.IOPage.Size = new System.Drawing.Size(573, 399);
            this.IOPage.TabIndex = 1;
            this.IOPage.Text = "IOPage*";
            this.IOPage.UseVisualStyleBackColor = true;
            // 
            // lb_device_IO
            // 
            this.lb_device_IO.AutoSize = true;
            this.lb_device_IO.Location = new System.Drawing.Point(163, 73);
            this.lb_device_IO.Name = "lb_device_IO";
            this.lb_device_IO.Size = new System.Drawing.Size(42, 13);
            this.lb_device_IO.TabIndex = 5;
            this.lb_device_IO.Text = "Devicr*";
            // 
            // lb_com_IO
            // 
            this.lb_com_IO.AutoSize = true;
            this.lb_com_IO.Location = new System.Drawing.Point(137, 32);
            this.lb_com_IO.Name = "lb_com_IO";
            this.lb_com_IO.Size = new System.Drawing.Size(68, 13);
            this.lb_com_IO.TabIndex = 4;
            this.lb_com_IO.Text = "ComPort_IO*";
            // 
            // btn_save_IO
            // 
            this.btn_save_IO.Location = new System.Drawing.Point(492, 370);
            this.btn_save_IO.Name = "btn_save_IO";
            this.btn_save_IO.Size = new System.Drawing.Size(75, 23);
            this.btn_save_IO.TabIndex = 3;
            this.btn_save_IO.Text = "save";
            this.btn_save_IO.UseVisualStyleBackColor = true;
            this.btn_save_IO.Click += new System.EventHandler(this.btn_save_IO_Click);
            // 
            // comboBox_device_IO
            // 
            this.comboBox_device_IO.FormattingEnabled = true;
            this.comboBox_device_IO.Location = new System.Drawing.Point(245, 70);
            this.comboBox_device_IO.Name = "comboBox_device_IO";
            this.comboBox_device_IO.Size = new System.Drawing.Size(121, 21);
            this.comboBox_device_IO.TabIndex = 2;
            // 
            // comboBox_BuadeRate_IO
            // 
            this.comboBox_BuadeRate_IO.FormattingEnabled = true;
            this.comboBox_BuadeRate_IO.Location = new System.Drawing.Point(372, 29);
            this.comboBox_BuadeRate_IO.Name = "comboBox_BuadeRate_IO";
            this.comboBox_BuadeRate_IO.Size = new System.Drawing.Size(121, 21);
            this.comboBox_BuadeRate_IO.TabIndex = 1;
            // 
            // comboBox_com_IO
            // 
            this.comboBox_com_IO.FormattingEnabled = true;
            this.comboBox_com_IO.Location = new System.Drawing.Point(245, 29);
            this.comboBox_com_IO.Name = "comboBox_com_IO";
            this.comboBox_com_IO.Size = new System.Drawing.Size(121, 21);
            this.comboBox_com_IO.TabIndex = 0;
            // 
            // ScoreboardPage
            // 
            this.ScoreboardPage.Controls.Add(this.label1);
            this.ScoreboardPage.Controls.Add(this.comboBox_ScoreBoard_prot);
            this.ScoreboardPage.Controls.Add(this.comboBox_ScoreBorde_buadeRate);
            this.ScoreboardPage.Controls.Add(this.comboBox_ScoreB_Com);
            this.ScoreboardPage.Location = new System.Drawing.Point(4, 22);
            this.ScoreboardPage.Name = "ScoreboardPage";
            this.ScoreboardPage.Size = new System.Drawing.Size(573, 399);
            this.ScoreboardPage.TabIndex = 2;
            this.ScoreboardPage.Text = "ScoreboardPage*";
            this.ScoreboardPage.UseVisualStyleBackColor = true;
            // 
            // DataBasePage
            // 
            this.DataBasePage.Controls.Add(this.btn_save_DB_page);
            this.DataBasePage.Controls.Add(this.btn_file);
            this.DataBasePage.Controls.Add(this.tb_path);
            this.DataBasePage.Location = new System.Drawing.Point(4, 22);
            this.DataBasePage.Name = "DataBasePage";
            this.DataBasePage.Size = new System.Drawing.Size(573, 399);
            this.DataBasePage.TabIndex = 3;
            this.DataBasePage.Text = "DataBasePage*";
            this.DataBasePage.UseVisualStyleBackColor = true;
            // 
            // FirmPage
            // 
            this.FirmPage.Location = new System.Drawing.Point(4, 22);
            this.FirmPage.Name = "FirmPage";
            this.FirmPage.Size = new System.Drawing.Size(573, 399);
            this.FirmPage.TabIndex = 4;
            this.FirmPage.Text = "FirmPage*";
            this.FirmPage.UseVisualStyleBackColor = true;
            // 
            // SettingsPage
            // 
            this.SettingsPage.Location = new System.Drawing.Point(4, 22);
            this.SettingsPage.Name = "SettingsPage";
            this.SettingsPage.Size = new System.Drawing.Size(573, 399);
            this.SettingsPage.TabIndex = 5;
            this.SettingsPage.Text = "SettingsPage*";
            this.SettingsPage.UseVisualStyleBackColor = true;
            // 
            // CameraPage
            // 
            this.CameraPage.Location = new System.Drawing.Point(4, 22);
            this.CameraPage.Name = "CameraPage";
            this.CameraPage.Size = new System.Drawing.Size(573, 399);
            this.CameraPage.TabIndex = 6;
            this.CameraPage.Text = "CameraPage*";
            this.CameraPage.UseVisualStyleBackColor = true;
            // 
            // RFIDPage
            // 
            this.RFIDPage.Location = new System.Drawing.Point(4, 22);
            this.RFIDPage.Name = "RFIDPage";
            this.RFIDPage.Size = new System.Drawing.Size(573, 399);
            this.RFIDPage.TabIndex = 7;
            this.RFIDPage.Text = "RFIDPage*";
            this.RFIDPage.UseVisualStyleBackColor = true;
            // 
            // comboBox_ScoreB_Com
            // 
            this.comboBox_ScoreB_Com.FormattingEnabled = true;
            this.comboBox_ScoreB_Com.Location = new System.Drawing.Point(252, 62);
            this.comboBox_ScoreB_Com.Name = "comboBox_ScoreB_Com";
            this.comboBox_ScoreB_Com.Size = new System.Drawing.Size(71, 21);
            this.comboBox_ScoreB_Com.TabIndex = 0;
            // 
            // comboBox_ScoreBorde_buadeRate
            // 
            this.comboBox_ScoreBorde_buadeRate.FormattingEnabled = true;
            this.comboBox_ScoreBorde_buadeRate.Items.AddRange(new object[] {
            "9600",
            "19200",
            "38400",
            "4800",
            "57600",
            "115200"});
            this.comboBox_ScoreBorde_buadeRate.Location = new System.Drawing.Point(329, 62);
            this.comboBox_ScoreBorde_buadeRate.Name = "comboBox_ScoreBorde_buadeRate";
            this.comboBox_ScoreBorde_buadeRate.Size = new System.Drawing.Size(121, 21);
            this.comboBox_ScoreBorde_buadeRate.TabIndex = 1;
            // 
            // comboBox_ScoreBoard_prot
            // 
            this.comboBox_ScoreBoard_prot.FormattingEnabled = true;
            this.comboBox_ScoreBoard_prot.Location = new System.Drawing.Point(252, 102);
            this.comboBox_ScoreBoard_prot.Name = "comboBox_ScoreBoard_prot";
            this.comboBox_ScoreBoard_prot.Size = new System.Drawing.Size(121, 21);
            this.comboBox_ScoreBoard_prot.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(202, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Вкладка в разработке";
            // 
            // tb_path
            // 
            this.tb_path.Location = new System.Drawing.Point(23, 102);
            this.tb_path.Name = "tb_path";
            this.tb_path.Size = new System.Drawing.Size(526, 20);
            this.tb_path.TabIndex = 0;
            // 
            // btn_file
            // 
            this.btn_file.Location = new System.Drawing.Point(219, 128);
            this.btn_file.Name = "btn_file";
            this.btn_file.Size = new System.Drawing.Size(75, 23);
            this.btn_file.TabIndex = 1;
            this.btn_file.Text = "File*";
            this.btn_file.UseVisualStyleBackColor = true;
            this.btn_file.Click += new System.EventHandler(this.btn_file_Click);
            // 
            // btn_save_DB_page
            // 
            this.btn_save_DB_page.Location = new System.Drawing.Point(495, 373);
            this.btn_save_DB_page.Name = "btn_save_DB_page";
            this.btn_save_DB_page.Size = new System.Drawing.Size(75, 23);
            this.btn_save_DB_page.TabIndex = 2;
            this.btn_save_DB_page.Text = "Save*";
            this.btn_save_DB_page.UseVisualStyleBackColor = true;
            this.btn_save_DB_page.Click += new System.EventHandler(this.btn_save_DB_page_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "SettingsForm";
            this.Text = "SettingsForm*";
            this.tabControl1.ResumeLayout(false);
            this.indicatorPage.ResumeLayout(false);
            this.indicatorPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_time_stab)).EndInit();
            this.IOPage.ResumeLayout(false);
            this.IOPage.PerformLayout();
            this.ScoreboardPage.ResumeLayout(false);
            this.ScoreboardPage.PerformLayout();
            this.DataBasePage.ResumeLayout(false);
            this.DataBasePage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage indicatorPage;
        private System.Windows.Forms.TabPage IOPage;
        private System.Windows.Forms.TabPage ScoreboardPage;
        private System.Windows.Forms.TabPage DataBasePage;
        private System.Windows.Forms.TabPage FirmPage;
        private System.Windows.Forms.TabPage SettingsPage;
        private System.Windows.Forms.TabPage CameraPage;
        private System.Windows.Forms.TabPage RFIDPage;
        private System.Windows.Forms.Button btn_save_indic_settings;
        private System.Windows.Forms.ComboBox comboBox_Idic_prot;
        private System.Windows.Forms.ComboBox comboBox_com_budeRate;
        private System.Windows.Forms.ComboBox comboBox_com;
        private System.Windows.Forms.NumericUpDown num_time_stab;
        private System.Windows.Forms.Label lb_com_ind_settings;
        private System.Windows.Forms.Label lb_prot_indic_settings;
        private System.Windows.Forms.Label lb_time_stab_ind_settings;
        private System.Windows.Forms.Label lb_device_IO;
        private System.Windows.Forms.Label lb_com_IO;
        private System.Windows.Forms.Button btn_save_IO;
        private System.Windows.Forms.ComboBox comboBox_device_IO;
        private System.Windows.Forms.ComboBox comboBox_BuadeRate_IO;
        private System.Windows.Forms.ComboBox comboBox_com_IO;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_ScoreBoard_prot;
        private System.Windows.Forms.ComboBox comboBox_ScoreBorde_buadeRate;
        private System.Windows.Forms.ComboBox comboBox_ScoreB_Com;
        private System.Windows.Forms.Button btn_file;
        private System.Windows.Forms.TextBox tb_path;
        private System.Windows.Forms.Button btn_save_DB_page;
    }
}