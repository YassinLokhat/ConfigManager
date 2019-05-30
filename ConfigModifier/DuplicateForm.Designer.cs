namespace ConfigModifier
{
    partial class DuplicateForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DuplicateForm));
            this.bDuplicate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbConfigs = new System.Windows.Forms.ListBox();
            this.cbFromEnvironment = new System.Windows.Forms.ComboBox();
            this.cbToEnvironment = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbSites = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // bDuplicate
            // 
            this.bDuplicate.Location = new System.Drawing.Point(220, 166);
            this.bDuplicate.Name = "bDuplicate";
            this.bDuplicate.Size = new System.Drawing.Size(124, 23);
            this.bDuplicate.TabIndex = 0;
            this.bDuplicate.Text = "Duplicate";
            this.bDuplicate.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "From :";
            // 
            // lbConfigs
            // 
            this.lbConfigs.FormattingEnabled = true;
            this.lbConfigs.Location = new System.Drawing.Point(15, 39);
            this.lbConfigs.Name = "lbConfigs";
            this.lbConfigs.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbConfigs.Size = new System.Drawing.Size(174, 147);
            this.lbConfigs.Sorted = true;
            this.lbConfigs.TabIndex = 2;
            // 
            // cbFromEnvironment
            // 
            this.cbFromEnvironment.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbFromEnvironment.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbFromEnvironment.FormattingEnabled = true;
            this.cbFromEnvironment.Location = new System.Drawing.Point(54, 12);
            this.cbFromEnvironment.Name = "cbFromEnvironment";
            this.cbFromEnvironment.Size = new System.Drawing.Size(135, 21);
            this.cbFromEnvironment.TabIndex = 3;
            // 
            // cbToEnvironment
            // 
            this.cbToEnvironment.FormattingEnabled = true;
            this.cbToEnvironment.Location = new System.Drawing.Point(259, 15);
            this.cbToEnvironment.Name = "cbToEnvironment";
            this.cbToEnvironment.Size = new System.Drawing.Size(85, 21);
            this.cbToEnvironment.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(217, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "To :";
            // 
            // lbSites
            // 
            this.lbSites.FormattingEnabled = true;
            this.lbSites.Location = new System.Drawing.Point(220, 39);
            this.lbSites.Name = "lbSites";
            this.lbSites.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbSites.Size = new System.Drawing.Size(124, 121);
            this.lbSites.TabIndex = 6;
            // 
            // DuplicateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 199);
            this.Controls.Add(this.lbSites);
            this.Controls.Add(this.cbToEnvironment);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbFromEnvironment);
            this.Controls.Add(this.lbConfigs);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bDuplicate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "DuplicateForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DuplicateForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bDuplicate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbConfigs;
        private System.Windows.Forms.ComboBox cbFromEnvironment;
        private System.Windows.Forms.ComboBox cbToEnvironment;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lbSites;
    }
}