namespace ConfigModifier
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
            this.cbSTI1ALL = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bBrowse = new System.Windows.Forms.Button();
            this.tbConfigValues = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbSTI1Job = new System.Windows.Forms.CheckBox();
            this.cbSTI1CM = new System.Windows.Forms.CheckBox();
            this.cbSTI1CD = new System.Windows.Forms.CheckBox();
            this.lbSites = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbConfigs = new System.Windows.Forms.ListBox();
            this.bGenerate = new System.Windows.Forms.Button();
            this.tbResult = new System.Windows.Forms.TextBox();
            this.bSearch = new System.Windows.Forms.Button();
            this.bDuplicate = new System.Windows.Forms.Button();
            this.bCopyFrom = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.bOpenSettings = new System.Windows.Forms.Button();
            this.bOpenSolution = new System.Windows.Forms.Button();
            this.bCopyTo = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbSTI1ALL
            // 
            this.cbSTI1ALL.AutoSize = true;
            this.cbSTI1ALL.Location = new System.Drawing.Point(6, 19);
            this.cbSTI1ALL.Name = "cbSTI1ALL";
            this.cbSTI1ALL.Size = new System.Drawing.Size(37, 17);
            this.cbSTI1ALL.TabIndex = 0;
            this.cbSTI1ALL.Text = "All";
            this.cbSTI1ALL.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Config value file :";
            // 
            // bBrowse
            // 
            this.bBrowse.Location = new System.Drawing.Point(479, 131);
            this.bBrowse.Name = "bBrowse";
            this.bBrowse.Size = new System.Drawing.Size(61, 23);
            this.bBrowse.TabIndex = 70;
            this.bBrowse.Text = "Browse";
            this.bBrowse.UseVisualStyleBackColor = true;
            // 
            // tbConfigValues
            // 
            this.tbConfigValues.Location = new System.Drawing.Point(105, 133);
            this.tbConfigValues.Name = "tbConfigValues";
            this.tbConfigValues.ReadOnly = true;
            this.tbConfigValues.Size = new System.Drawing.Size(368, 20);
            this.tbConfigValues.TabIndex = 60;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbSTI1Job);
            this.groupBox1.Controls.Add(this.cbSTI1CM);
            this.groupBox1.Controls.Add(this.cbSTI1CD);
            this.groupBox1.Controls.Add(this.cbSTI1ALL);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(92, 113);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Environment";
            // 
            // cbSTI1Job
            // 
            this.cbSTI1Job.AutoSize = true;
            this.cbSTI1Job.Location = new System.Drawing.Point(6, 88);
            this.cbSTI1Job.Name = "cbSTI1Job";
            this.cbSTI1Job.Size = new System.Drawing.Size(43, 17);
            this.cbSTI1Job.TabIndex = 30;
            this.cbSTI1Job.Text = "Job";
            this.cbSTI1Job.UseVisualStyleBackColor = true;
            // 
            // cbSTI1CM
            // 
            this.cbSTI1CM.AutoSize = true;
            this.cbSTI1CM.Location = new System.Drawing.Point(6, 65);
            this.cbSTI1CM.Name = "cbSTI1CM";
            this.cbSTI1CM.Size = new System.Drawing.Size(42, 17);
            this.cbSTI1CM.TabIndex = 20;
            this.cbSTI1CM.Text = "CM";
            this.cbSTI1CM.UseVisualStyleBackColor = true;
            // 
            // cbSTI1CD
            // 
            this.cbSTI1CD.AutoSize = true;
            this.cbSTI1CD.Location = new System.Drawing.Point(6, 42);
            this.cbSTI1CD.Name = "cbSTI1CD";
            this.cbSTI1CD.Size = new System.Drawing.Size(41, 17);
            this.cbSTI1CD.TabIndex = 10;
            this.cbSTI1CD.Text = "CD";
            this.cbSTI1CD.UseVisualStyleBackColor = true;
            // 
            // lbSites
            // 
            this.lbSites.FormattingEnabled = true;
            this.lbSites.Location = new System.Drawing.Point(6, 19);
            this.lbSites.Name = "lbSites";
            this.lbSites.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbSites.Size = new System.Drawing.Size(105, 82);
            this.lbSites.TabIndex = 40;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbSites);
            this.groupBox2.Location = new System.Drawing.Point(110, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(117, 113);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Markets";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbConfigs);
            this.groupBox3.Location = new System.Drawing.Point(233, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(241, 113);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Configuration files";
            // 
            // lbConfigs
            // 
            this.lbConfigs.FormattingEnabled = true;
            this.lbConfigs.Location = new System.Drawing.Point(6, 19);
            this.lbConfigs.Name = "lbConfigs";
            this.lbConfigs.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbConfigs.Size = new System.Drawing.Size(229, 82);
            this.lbConfigs.Sorted = true;
            this.lbConfigs.TabIndex = 50;
            // 
            // bGenerate
            // 
            this.bGenerate.Location = new System.Drawing.Point(480, 102);
            this.bGenerate.Name = "bGenerate";
            this.bGenerate.Size = new System.Drawing.Size(60, 23);
            this.bGenerate.TabIndex = 80;
            this.bGenerate.Text = "Generate";
            this.bGenerate.UseVisualStyleBackColor = true;
            // 
            // tbResult
            // 
            this.tbResult.BackColor = System.Drawing.Color.Black;
            this.tbResult.ForeColor = System.Drawing.Color.White;
            this.tbResult.Location = new System.Drawing.Point(12, 164);
            this.tbResult.Multiline = true;
            this.tbResult.Name = "tbResult";
            this.tbResult.ReadOnly = true;
            this.tbResult.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbResult.Size = new System.Drawing.Size(663, 226);
            this.tbResult.TabIndex = 81;
            // 
            // bSearch
            // 
            this.bSearch.Location = new System.Drawing.Point(480, 19);
            this.bSearch.Name = "bSearch";
            this.bSearch.Size = new System.Drawing.Size(60, 23);
            this.bSearch.TabIndex = 82;
            this.bSearch.Text = "Search";
            this.bSearch.UseVisualStyleBackColor = true;
            // 
            // bDuplicate
            // 
            this.bDuplicate.Location = new System.Drawing.Point(480, 48);
            this.bDuplicate.Name = "bDuplicate";
            this.bDuplicate.Size = new System.Drawing.Size(60, 23);
            this.bDuplicate.TabIndex = 83;
            this.bDuplicate.Text = "Duplicate";
            this.bDuplicate.UseVisualStyleBackColor = true;
            // 
            // bCopyFrom
            // 
            this.bCopyFrom.Location = new System.Drawing.Point(6, 19);
            this.bCopyFrom.Name = "bCopyFrom";
            this.bCopyFrom.Size = new System.Drawing.Size(116, 23);
            this.bCopyFrom.TabIndex = 84;
            this.bCopyFrom.Text = "Copy from Solution";
            this.bCopyFrom.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.bOpenSettings);
            this.groupBox4.Controls.Add(this.bOpenSolution);
            this.groupBox4.Controls.Add(this.bCopyTo);
            this.groupBox4.Controls.Add(this.bCopyFrom);
            this.groupBox4.Location = new System.Drawing.Point(546, 17);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(129, 140);
            this.groupBox4.TabIndex = 86;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Folder Options";
            // 
            // bOpenSettings
            // 
            this.bOpenSettings.Location = new System.Drawing.Point(6, 106);
            this.bOpenSettings.Name = "bOpenSettings";
            this.bOpenSettings.Size = new System.Drawing.Size(116, 23);
            this.bOpenSettings.TabIndex = 87;
            this.bOpenSettings.Text = "Open Settings Folder";
            this.bOpenSettings.UseVisualStyleBackColor = true;
            // 
            // bOpenSolution
            // 
            this.bOpenSolution.Location = new System.Drawing.Point(6, 77);
            this.bOpenSolution.Name = "bOpenSolution";
            this.bOpenSolution.Size = new System.Drawing.Size(116, 23);
            this.bOpenSolution.TabIndex = 86;
            this.bOpenSolution.Text = "Open Solution Folder";
            this.bOpenSolution.UseVisualStyleBackColor = true;
            // 
            // bCopyTo
            // 
            this.bCopyTo.Location = new System.Drawing.Point(6, 48);
            this.bCopyTo.Name = "bCopyTo";
            this.bCopyTo.Size = new System.Drawing.Size(116, 23);
            this.bCopyTo.TabIndex = 85;
            this.bCopyTo.Text = "Copy to Solution";
            this.bCopyTo.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 398);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.bDuplicate);
            this.Controls.Add(this.bSearch);
            this.Controls.Add(this.tbResult);
            this.Controls.Add(this.bGenerate);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tbConfigValues);
            this.Controls.Add(this.bBrowse);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConfigModifier";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbSTI1ALL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bBrowse;
        private System.Windows.Forms.TextBox tbConfigValues;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cbSTI1Job;
        private System.Windows.Forms.CheckBox cbSTI1CM;
        private System.Windows.Forms.CheckBox cbSTI1CD;
        private System.Windows.Forms.ListBox lbSites;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox lbConfigs;
        private System.Windows.Forms.Button bGenerate;
        private System.Windows.Forms.TextBox tbResult;
        private System.Windows.Forms.Button bSearch;
        private System.Windows.Forms.Button bDuplicate;
        private System.Windows.Forms.Button bCopyFrom;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button bOpenSettings;
        private System.Windows.Forms.Button bOpenSolution;
        private System.Windows.Forms.Button bCopyTo;
    }
}

