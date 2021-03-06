﻿using System;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using IDB.Core;
using log4net;

namespace IDB.Discover.Vault
{
    public partial class MainForm : Form
    {
        private static readonly ILog Log = LogManager.GetLogger("IDBDiscoverVault");

        public MainForm()
        {
            InitializeLogging();
            InitializeComponent();

            txtConnectionString.Text = Settings.IdbConnectionString;
            txtVaultConnection.Text = Settings.VaultConnectionString;
            txtKnowledgeVaultConnectionString.Text = Settings.KnowledgeVaultConnectionString;
        }

        private void InitializeLogging()
        {
            var thisAssembly = Assembly.GetExecutingAssembly();
            var fi = new FileInfo(thisAssembly.Location + ".log4net");
            log4net.Config.XmlConfigurator.Configure(fi);

            Log.Info($"powerLoad {Assembly.GetExecutingAssembly().GetName().Name} v{Assembly.GetExecutingAssembly().GetName().Version}");
        }

        private void OnBtnTransferClick(object sender, EventArgs e)
        {
            try
            {
                string loadConnectionString = txtConnectionString.Text;
                string vaultConnectionString = txtVaultConnection.Text;
                string knowledgeVaultConnectionString = txtVaultConnection.Text;
                VaultDbExtractor.Transfer(vaultConnectionString, knowledgeVaultConnectionString, loadConnectionString);

                Log.Info("Successfully transferred target Vault behaviors to IDB");
                MessageBox.Show(
                    "Successfully transferred target Vault behaviors to IDB", 
                    "IDB.Discover.Vault", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message, ex);
                MessageBox.Show(
                    ex.Message, 
                    "IDB.Discover.Vault",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        private void OnBtnCloseClick(object sender, EventArgs e)
        {
            Close();
        }

        private void OnTxtConnectionStringTextChanged(object sender, EventArgs e)
        {
            Settings.IdbConnectionString = txtConnectionString.Text;
            
        }

        private void OnTxtVaultConnectionTextChanged(object sender, EventArgs e)
        {
            Settings.VaultConnectionString = txtVaultConnection.Text;
        }

        private void OnTxtKnowledgeVaultConnectionStringTextChanged(object sender, EventArgs e)
        {
            Settings.KnowledgeVaultConnectionString = txtKnowledgeVaultConnectionString.Text;
        }
    }
}