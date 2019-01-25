namespace LiveSplit.UI.Components
{
    partial class ComponentSettings
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.chkAutoStart = new System.Windows.Forms.CheckBox();
            this.chkAutoReset = new System.Windows.Forms.CheckBox();
            this.chkAutoSplit = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.chkAutoStart, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.chkAutoReset, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.chkAutoSplit, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(7, 7);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(275, 90);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // chkAutoStart
            // 
            this.chkAutoStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.chkAutoStart.AutoSize = true;
            this.chkAutoStart.Checked = true;
            this.chkAutoStart.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAutoStart.Location = new System.Drawing.Point(7, 36);
            this.chkAutoStart.Margin = new System.Windows.Forms.Padding(7, 3, 3, 3);
            this.chkAutoStart.Name = "chkAutoStart";
            this.chkAutoStart.Size = new System.Drawing.Size(265, 17);
            this.chkAutoStart.TabIndex = 2;
            this.chkAutoStart.Text = "Auto start timer";
            this.chkAutoStart.UseVisualStyleBackColor = true;
            // 
            // chkAutoReset
            // 
            this.chkAutoReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.chkAutoReset.AutoSize = true;
            this.chkAutoReset.Checked = true;
            this.chkAutoReset.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAutoReset.Location = new System.Drawing.Point(7, 6);
            this.chkAutoReset.Margin = new System.Windows.Forms.Padding(7, 3, 3, 3);
            this.chkAutoReset.Name = "chkAutoReset";
            this.chkAutoReset.Size = new System.Drawing.Size(265, 17);
            this.chkAutoReset.TabIndex = 1;
            this.chkAutoReset.Text = "Auto reset timer on character reset during first split";
            this.chkAutoReset.UseVisualStyleBackColor = true;
            // 
            // chkAutoSplit
            // 
            this.chkAutoSplit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.chkAutoSplit.AutoSize = true;
            this.chkAutoSplit.Checked = true;
            this.chkAutoSplit.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAutoSplit.Location = new System.Drawing.Point(7, 66);
            this.chkAutoSplit.Margin = new System.Windows.Forms.Padding(7, 3, 3, 3);
            this.chkAutoSplit.Name = "chkAutoSplit";
            this.chkAutoSplit.Size = new System.Drawing.Size(265, 17);
            this.chkAutoSplit.TabIndex = 3;
            this.chkAutoSplit.Text = "Auto split on chest touch (cinematic)";
            this.chkAutoSplit.UseVisualStyleBackColor = true;
            // 
            // ComponentSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ComponentSettings";
            this.Padding = new System.Windows.Forms.Padding(7);
            this.Size = new System.Drawing.Size(289, 104);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.CheckBox chkAutoReset;
        private System.Windows.Forms.CheckBox chkAutoStart;
        private System.Windows.Forms.CheckBox chkAutoSplit;
    }
}
