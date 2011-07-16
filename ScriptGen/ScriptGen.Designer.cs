namespace Util
{
    partial class frmScriptGen
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtServer = new System.Windows.Forms.TextBox();
            this.txtTableName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtExcludeField = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmdGenerate = new System.Windows.Forms.Button();
            this.cmdCancel = new System.Windows.Forms.Button();
            this.cmdFolder = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.grpConnection = new System.Windows.Forms.GroupBox();
            this.txtProvider = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDatabase = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblConnectionDetails = new System.Windows.Forms.Label();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtWhereClause = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.grpConnection.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 43);
            this.label1.MaximumSize = new System.Drawing.Size(70, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Server";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtServer
            // 
            this.txtServer.Location = new System.Drawing.Point(88, 40);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(176, 20);
            this.txtServer.TabIndex = 10;
            // 
            // txtTableName
            // 
            this.txtTableName.Location = new System.Drawing.Point(95, 4);
            this.txtTableName.Name = "txtTableName";
            this.txtTableName.Size = new System.Drawing.Size(176, 20);
            this.txtTableName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 7);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "TableName";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtExcludeField
            // 
            this.txtExcludeField.Location = new System.Drawing.Point(95, 30);
            this.txtExcludeField.Name = "txtExcludeField";
            this.txtExcludeField.Size = new System.Drawing.Size(176, 20);
            this.txtExcludeField.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 33);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Fields to Exclude";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(95, 56);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(156, 20);
            this.txtPath.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 59);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Output Path";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cmdGenerate
            // 
            this.cmdGenerate.Location = new System.Drawing.Point(64, 184);
            this.cmdGenerate.Name = "cmdGenerate";
            this.cmdGenerate.Size = new System.Drawing.Size(75, 23);
            this.cmdGenerate.TabIndex = 7;
            this.cmdGenerate.Text = "&Generate";
            this.cmdGenerate.UseVisualStyleBackColor = true;
            this.cmdGenerate.Click += new System.EventHandler(this.cmdGenerate_Click);
            // 
            // cmdCancel
            // 
            this.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdCancel.Location = new System.Drawing.Point(158, 184);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(75, 23);
            this.cmdCancel.TabIndex = 8;
            this.cmdCancel.Text = "&Cancel";
            this.cmdCancel.UseVisualStyleBackColor = true;
            this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
            // 
            // cmdFolder
            // 
            this.cmdFolder.Location = new System.Drawing.Point(257, 55);
            this.cmdFolder.Name = "cmdFolder";
            this.cmdFolder.Size = new System.Drawing.Size(24, 23);
            this.cmdFolder.TabIndex = 4;
            this.cmdFolder.Text = "...";
            this.cmdFolder.UseVisualStyleBackColor = true;
            this.cmdFolder.Click += new System.EventHandler(this.cmdFolder_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(48, 134);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblStatus.Size = new System.Drawing.Size(43, 13);
            this.lblStatus.TabIndex = 11;
            this.lblStatus.Text = "Status :";
            // 
            // grpConnection
            // 
            this.grpConnection.Controls.Add(this.txtProvider);
            this.grpConnection.Controls.Add(this.label9);
            this.grpConnection.Controls.Add(this.txtPassword);
            this.grpConnection.Controls.Add(this.label8);
            this.grpConnection.Controls.Add(this.txtUserName);
            this.grpConnection.Controls.Add(this.label7);
            this.grpConnection.Controls.Add(this.txtDatabase);
            this.grpConnection.Controls.Add(this.label6);
            this.grpConnection.Controls.Add(this.txtServer);
            this.grpConnection.Controls.Add(this.label1);
            this.grpConnection.Location = new System.Drawing.Point(12, 167);
            this.grpConnection.Name = "grpConnection";
            this.grpConnection.Size = new System.Drawing.Size(274, 143);
            this.grpConnection.TabIndex = 12;
            this.grpConnection.TabStop = false;
            this.grpConnection.Text = "Connection Details";
            this.grpConnection.Visible = false;
            // 
            // txtProvider
            // 
            this.txtProvider.Location = new System.Drawing.Point(88, 18);
            this.txtProvider.Name = "txtProvider";
            this.txtProvider.Size = new System.Drawing.Size(176, 20);
            this.txtProvider.TabIndex = 9;
            this.txtProvider.TextChanged += new System.EventHandler(this.txtProvider_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(38, 18);
            this.label9.MaximumSize = new System.Drawing.Size(70, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Provider";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(88, 117);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(176, 20);
            this.txtPassword.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(31, 120);
            this.label8.MaximumSize = new System.Drawing.Size(70, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Password";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(88, 91);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(176, 20);
            this.txtUserName.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 94);
            this.label7.MaximumSize = new System.Drawing.Size(70, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "User Name";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtDatabase
            // 
            this.txtDatabase.Location = new System.Drawing.Point(88, 65);
            this.txtDatabase.Name = "txtDatabase";
            this.txtDatabase.Size = new System.Drawing.Size(176, 20);
            this.txtDatabase.TabIndex = 11;
            this.txtDatabase.TextChanged += new System.EventHandler(this.txtDatabase_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 68);
            this.label6.MaximumSize = new System.Drawing.Size(70, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Database";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblConnectionDetails
            // 
            this.lblConnectionDetails.AutoSize = true;
            this.lblConnectionDetails.Location = new System.Drawing.Point(-3, 147);
            this.lblConnectionDetails.Name = "lblConnectionDetails";
            this.lblConnectionDetails.Size = new System.Drawing.Size(112, 13);
            this.lblConnectionDetails.TabIndex = 13;
            this.lblConnectionDetails.Text = "+ Connection Property";
            this.lblConnectionDetails.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblConnectionDetails.Click += new System.EventHandler(this.lblConnectionDetails_Click);
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(95, 82);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(176, 20);
            this.txtFileName.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(37, 85);
            this.label10.Name = "label10";
            this.label10.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label10.Size = new System.Drawing.Size(54, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "File Name";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtWhereClause
            // 
            this.txtWhereClause.Location = new System.Drawing.Point(95, 108);
            this.txtWhereClause.Name = "txtWhereClause";
            this.txtWhereClause.Size = new System.Drawing.Size(176, 20);
            this.txtWhereClause.TabIndex = 6;
            this.txtWhereClause.TextChanged += new System.EventHandler(this.txtWhereClause_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(19, 111);
            this.label11.Name = "label11";
            this.label11.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label11.Size = new System.Drawing.Size(74, 13);
            this.label11.TabIndex = 16;
            this.label11.Text = "Where Clause";
            this.label11.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // frmScriptGen
            // 
            this.AcceptButton = this.cmdGenerate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cmdCancel;
            this.ClientSize = new System.Drawing.Size(301, 321);
            this.Controls.Add(this.txtWhereClause);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtFileName);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblConnectionDetails);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.cmdFolder);
            this.Controls.Add(this.cmdCancel);
            this.Controls.Add(this.cmdGenerate);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtExcludeField);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTableName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.grpConnection);
            this.MaximizeBox = false;
            this.Name = "frmScriptGen";
            this.Text = "Script Generator";
            this.Load += new System.EventHandler(this.frmScriptGen_Load);
            this.grpConnection.ResumeLayout(false);
            this.grpConnection.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtServer;
        private System.Windows.Forms.TextBox txtTableName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtExcludeField;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button cmdGenerate;
        private System.Windows.Forms.Button cmdCancel;
        private System.Windows.Forms.Button cmdFolder;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.GroupBox grpConnection;
        private System.Windows.Forms.TextBox txtDatabase;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtProvider;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblConnectionDetails;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtWhereClause;
        private System.Windows.Forms.Label label11;
    }
}

