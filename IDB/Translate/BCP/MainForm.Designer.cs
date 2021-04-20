﻿namespace IDB.Translate.BCP
{
    partial class MainForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.label1 = new System.Windows.Forms.Label();
			this.txtConnectionString = new System.Windows.Forms.TextBox();
			this.btnExport = new System.Windows.Forms.Button();
			this.txtExportDirectory = new System.Windows.Forms.TextBox();
			this.btnExportDirectory = new System.Windows.Forms.Button();
			this.btnClose = new System.Windows.Forms.Button();
			this.btnValidate = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.comboBoxVaultVersion = new System.Windows.Forms.ComboBox();
			this.progressBarTask = new System.Windows.Forms.ProgressBar();
			this.labelProgressTask = new System.Windows.Forms.Label();
			this.progressBarTotal = new System.Windows.Forms.ProgressBar();
			this.labelProgressTotal = new System.Windows.Forms.Label();
			this.DisableConfigurationExportCheckBox = new System.Windows.Forms.CheckBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(14, 22);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(174, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "SQL Database Connection String";
			// 
			// txtConnectionString
			// 
			this.txtConnectionString.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtConnectionString.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtConnectionString.Location = new System.Drawing.Point(17, 40);
			this.txtConnectionString.Name = "txtConnectionString";
			this.txtConnectionString.Size = new System.Drawing.Size(462, 22);
			this.txtConnectionString.TabIndex = 1;
			this.txtConnectionString.Text = "Server=(local)\\AUTODESKVAULT;Database=Load;Trusted_Connection=True;";
			// 
			// btnExport
			// 
			this.btnExport.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btnExport.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnExport.Location = new System.Drawing.Point(17, 249);
			this.btnExport.Name = "btnExport";
			this.btnExport.Size = new System.Drawing.Size(463, 27);
			this.btnExport.TabIndex = 6;
			this.btnExport.Text = "Create BCP Package";
			this.btnExport.UseVisualStyleBackColor = true;
			this.btnExport.Click += new System.EventHandler(this.BtnExport_Click);
			// 
			// txtExportDirectory
			// 
			this.txtExportDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtExportDirectory.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtExportDirectory.Location = new System.Drawing.Point(17, 135);
			this.txtExportDirectory.Name = "txtExportDirectory";
			this.txtExportDirectory.Size = new System.Drawing.Size(409, 22);
			this.txtExportDirectory.TabIndex = 3;
			this.txtExportDirectory.Text = "C:\\TEMP\\BCP Package Directory";
			// 
			// btnExportDirectory
			// 
			this.btnExportDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnExportDirectory.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnExportDirectory.Location = new System.Drawing.Point(434, 135);
			this.btnExportDirectory.Name = "btnExportDirectory";
			this.btnExportDirectory.Size = new System.Drawing.Size(47, 25);
			this.btnExportDirectory.TabIndex = 4;
			this.btnExportDirectory.Text = "...";
			this.btnExportDirectory.UseVisualStyleBackColor = true;
			this.btnExportDirectory.Click += new System.EventHandler(this.BtnExportDirectory_Click);
			// 
			// btnClose
			// 
			this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnClose.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnClose.Location = new System.Drawing.Point(376, 393);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(105, 27);
			this.btnClose.TabIndex = 7;
			this.btnClose.Text = "Close";
			this.btnClose.UseVisualStyleBackColor = true;
			this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
			// 
			// btnValidate
			// 
			this.btnValidate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btnValidate.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnValidate.Location = new System.Drawing.Point(15, 177);
			this.btnValidate.Name = "btnValidate";
			this.btnValidate.Size = new System.Drawing.Size(463, 27);
			this.btnValidate.TabIndex = 5;
			this.btnValidate.Text = "Validate Database";
			this.btnValidate.UseVisualStyleBackColor = true;
			this.btnValidate.Click += new System.EventHandler(this.btnValidate_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(14, 117);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(111, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "BCP Export Directory";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(14, 69);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(78, 15);
			this.label3.TabIndex = 8;
			this.label3.Text = "Vault Version";
			// 
			// comboBoxVaultVersion
			// 
			this.comboBoxVaultVersion.FormattingEnabled = true;
			this.comboBoxVaultVersion.Items.AddRange(new object[] {
            "2020",
            "2019",
            "2018",
            "2017"});
			this.comboBoxVaultVersion.Location = new System.Drawing.Point(17, 89);
			this.comboBoxVaultVersion.Name = "comboBoxVaultVersion";
			this.comboBoxVaultVersion.Size = new System.Drawing.Size(462, 23);
			this.comboBoxVaultVersion.TabIndex = 9;
			this.comboBoxVaultVersion.Text = "2020";
			// 
			// progressBarTask
			// 
			this.progressBarTask.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.progressBarTask.Location = new System.Drawing.Point(17, 336);
			this.progressBarTask.Name = "progressBarTask";
			this.progressBarTask.Size = new System.Drawing.Size(463, 27);
			this.progressBarTask.Step = 1;
			this.progressBarTask.TabIndex = 10;
			// 
			// labelProgressTask
			// 
			this.labelProgressTask.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.labelProgressTask.AutoSize = true;
			this.labelProgressTask.Location = new System.Drawing.Point(14, 366);
			this.labelProgressTask.Name = "labelProgressTask";
			this.labelProgressTask.Size = new System.Drawing.Size(0, 15);
			this.labelProgressTask.TabIndex = 11;
			// 
			// progressBarTotal
			// 
			this.progressBarTotal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.progressBarTotal.Location = new System.Drawing.Point(17, 301);
			this.progressBarTotal.Name = "progressBarTotal";
			this.progressBarTotal.Size = new System.Drawing.Size(463, 27);
			this.progressBarTotal.Step = 1;
			this.progressBarTotal.TabIndex = 12;
			// 
			// labelProgressTotal
			// 
			this.labelProgressTotal.AutoSize = true;
			this.labelProgressTotal.Location = new System.Drawing.Point(17, 284);
			this.labelProgressTotal.Name = "labelProgressTotal";
			this.labelProgressTotal.Size = new System.Drawing.Size(89, 15);
			this.labelProgressTotal.TabIndex = 13;
			this.labelProgressTotal.Text = "Progress Total:";
			// 
			// DisableConfigurationExportCheckBox
			// 
			this.DisableConfigurationExportCheckBox.AutoSize = true;
			this.DisableConfigurationExportCheckBox.Enabled = false;
			this.DisableConfigurationExportCheckBox.Location = new System.Drawing.Point(20, 225);
			this.DisableConfigurationExportCheckBox.Margin = new System.Windows.Forms.Padding(2);
			this.DisableConfigurationExportCheckBox.Name = "DisableConfigurationExportCheckBox";
			this.DisableConfigurationExportCheckBox.Size = new System.Drawing.Size(182, 19);
			this.DisableConfigurationExportCheckBox.TabIndex = 14;
			this.DisableConfigurationExportCheckBox.Text = "Disable Configuration Export";
			this.DisableConfigurationExportCheckBox.UseVisualStyleBackColor = true;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnClose;
			this.ClientSize = new System.Drawing.Size(511, 434);
			this.Controls.Add(this.DisableConfigurationExportCheckBox);
			this.Controls.Add(this.labelProgressTotal);
			this.Controls.Add(this.progressBarTotal);
			this.Controls.Add(this.labelProgressTask);
			this.Controls.Add(this.progressBarTask);
			this.Controls.Add(this.comboBoxVaultVersion);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.btnValidate);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.btnExportDirectory);
			this.Controls.Add(this.txtExportDirectory);
			this.Controls.Add(this.btnExport);
			this.Controls.Add(this.txtConnectionString);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.Text = "IDB.Translate.BCP";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtConnectionString;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.TextBox txtExportDirectory;
        private System.Windows.Forms.Button btnExportDirectory;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnValidate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxVaultVersion;
        private System.Windows.Forms.ProgressBar progressBarTask;
        private System.Windows.Forms.Label labelProgressTask;
        private System.Windows.Forms.ProgressBar progressBarTotal;
        private System.Windows.Forms.Label labelProgressTotal;
        private System.Windows.Forms.CheckBox DisableConfigurationExportCheckBox;
    }
}

