using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
namespace Util
{
    public partial class frmScriptGen : Form
    {
        const int BUFFER = 10;
        ScriptGenerator _scriptCreator;
        public frmScriptGen()
        {
            InitializeComponent();
        }

       
        private void lblConnectionDetails_Click(object sender, EventArgs e)
        {
            if (grpConnection.Visible == false)
            {
                lblConnectionDetails.Text = lblConnectionDetails.Text.Replace('+', '-');
                grpConnection.Visible = true;
                PlaceButtonOnConnectionClick();
            }
            else
            {
                lblConnectionDetails.Text = lblConnectionDetails.Text.Replace('-', '+');
                grpConnection.Visible = false;
                PlaceButtonDefault();
            }
            
        }
        private void Generate()
        {
            _scriptCreator = new ScriptGenerator();
            _scriptCreator.ConnectionString = ConnectionString();
            string whereClause = String.Empty;
            string fileName = String.Empty;
            fileName = txtPath.Text + "\\" + txtFileName.Text;
            if (txtExcludeField.Text.Trim() != String.Empty)
                _scriptCreator.ColumnToExclude = String.Format(",{0},",txtExcludeField.Text.Trim());
            if (txtWhereClause.Text.Trim() != String.Empty)
                whereClause = txtWhereClause.Text.Trim();
            _scriptCreator.GenerateInsertStatement(txtTableName.Text.Trim(), whereClause, fileName);
            _scriptCreator = null;

        }
        private void cmdGenerate_Click(object sender, EventArgs e)
        {
            try
            {
                lblStatus.Text = "Status : Processing";
                this.Cursor = Cursors.WaitCursor;
                lblStatus.Update();
                Generate();
                lblStatus.Text = "Status : Completed";
                
            }
            catch (Exception ex)
            {
                lblStatus.Text = String.Format("Status : Errored {0}", ex.Message);
            }
            lblStatus.Update();
            this.Cursor = Cursors.Default;
        }
        private void PlaceButtonOnConnectionClick()
        {
            cmdGenerate.Top = grpConnection.Bottom + BUFFER;
            this.Height += grpConnection.Height + cmdGenerate.Height - BUFFER * 2;
            cmdCancel.Top = cmdGenerate.Top;
        }
        private void PlaceButtonDefault()
        {
            cmdGenerate.Top = lblConnectionDetails.Bottom + BUFFER;
            cmdCancel.Top = cmdGenerate.Top;
            this.Height = cmdGenerate.Bottom + cmdGenerate.Height + BUFFER*2;
        }
        private void frmScriptGen_Load(object sender, EventArgs e)
        {
            PlaceButtonDefault();
            PopulateControls();
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void PopulateControls()
        {
            txtProvider.Text = ConfigurationManager.AppSettings["Provider"];
            txtServer.Text = ConfigurationManager.AppSettings["ServerName"];
            txtDatabase.Text = ConfigurationManager.AppSettings["DatabaseName"];
            txtUserName.Text = ConfigurationManager.AppSettings["User"];
            txtPassword.Text = ConfigurationManager.AppSettings["Password"];
            txtFileName.Text = ConfigurationManager.AppSettings["FileName"];
            txtPath.Text = ConfigurationManager.AppSettings["Path"];
        }
        private string ConnectionString()
        {
            return String.Format("Provider={0};Server={1};Database={2};Uid={3};Pwd={4};",
                txtProvider.Text,txtServer.Text,txtDatabase.Text,
                txtUserName.Text,txtPassword.Text);
        }

        private void cmdFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.Description = "Select the Output Directory";
            fbd.SelectedPath = ".";
            fbd.ShowDialog(this);
            txtPath.Text = fbd.SelectedPath;
            fbd.Dispose();
        }

        private void txtWhereClause_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtProvider_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDatabase_TextChanged(object sender, EventArgs e)
        {

        }

    }
    
}