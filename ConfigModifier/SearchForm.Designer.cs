namespace ConfigModifier
{
    partial class SearchForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchForm));
            this.label1 = new System.Windows.Forms.Label();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.rbSettingName = new System.Windows.Forms.RadioButton();
            this.rbSettingValue = new System.Windows.Forms.RadioButton();
            this.rbText = new System.Windows.Forms.RadioButton();
            this.cbMatchCase = new System.Windows.Forms.CheckBox();
            this.cbAllowRegex = new System.Windows.Forms.CheckBox();
            this.lbResult = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Search :";
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(65, 12);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(181, 20);
            this.tbSearch.TabIndex = 0;
            // 
            // rbSettingName
            // 
            this.rbSettingName.AutoSize = true;
            this.rbSettingName.Checked = true;
            this.rbSettingName.Location = new System.Drawing.Point(252, 13);
            this.rbSettingName.Name = "rbSettingName";
            this.rbSettingName.Size = new System.Drawing.Size(87, 17);
            this.rbSettingName.TabIndex = 10;
            this.rbSettingName.TabStop = true;
            this.rbSettingName.Text = "Setting name";
            this.rbSettingName.UseVisualStyleBackColor = true;
            // 
            // rbSettingValue
            // 
            this.rbSettingValue.AutoSize = true;
            this.rbSettingValue.Location = new System.Drawing.Point(345, 13);
            this.rbSettingValue.Name = "rbSettingValue";
            this.rbSettingValue.Size = new System.Drawing.Size(88, 17);
            this.rbSettingValue.TabIndex = 20;
            this.rbSettingValue.Text = "Setting Value";
            this.rbSettingValue.UseVisualStyleBackColor = true;
            // 
            // rbText
            // 
            this.rbText.AutoSize = true;
            this.rbText.Location = new System.Drawing.Point(439, 13);
            this.rbText.Name = "rbText";
            this.rbText.Size = new System.Drawing.Size(46, 17);
            this.rbText.TabIndex = 31;
            this.rbText.Text = "Text";
            this.rbText.UseVisualStyleBackColor = true;
            // 
            // cbMatchCase
            // 
            this.cbMatchCase.AutoSize = true;
            this.cbMatchCase.Checked = true;
            this.cbMatchCase.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbMatchCase.Location = new System.Drawing.Point(513, 15);
            this.cbMatchCase.Name = "cbMatchCase";
            this.cbMatchCase.Size = new System.Drawing.Size(83, 17);
            this.cbMatchCase.TabIndex = 32;
            this.cbMatchCase.Text = "Match Case";
            this.cbMatchCase.UseVisualStyleBackColor = true;
            // 
            // cbAllowRegex
            // 
            this.cbAllowRegex.AutoSize = true;
            this.cbAllowRegex.Location = new System.Drawing.Point(602, 15);
            this.cbAllowRegex.Name = "cbAllowRegex";
            this.cbAllowRegex.Size = new System.Drawing.Size(180, 17);
            this.cbAllowRegex.TabIndex = 33;
            this.cbAllowRegex.Text = "Allow Search Patern (*,+,?,!,^,$ )";
            this.cbAllowRegex.UseVisualStyleBackColor = true;
            // 
            // lbResult
            // 
            this.lbResult.FormattingEnabled = true;
            this.lbResult.Location = new System.Drawing.Point(12, 38);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(770, 212);
            this.lbResult.TabIndex = 34;
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 261);
            this.Controls.Add(this.lbResult);
            this.Controls.Add(this.cbAllowRegex);
            this.Controls.Add(this.cbMatchCase);
            this.Controls.Add(this.rbText);
            this.Controls.Add(this.rbSettingValue);
            this.Controls.Add(this.rbSettingName);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(624, 300);
            this.Name = "SearchForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search a setting";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.RadioButton rbSettingName;
        private System.Windows.Forms.RadioButton rbSettingValue;
        private System.Windows.Forms.RadioButton rbText;
        private System.Windows.Forms.CheckBox cbMatchCase;
        private System.Windows.Forms.CheckBox cbAllowRegex;
        private System.Windows.Forms.ListBox lbResult;
    }
}