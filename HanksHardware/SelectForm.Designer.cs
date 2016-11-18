namespace HanksHardware
{
    partial class SelectForm
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
            this.SelectLabel = new System.Windows.Forms.Label();
            this.SelectDataGridView = new System.Windows.Forms.DataGridView();
            this.SelectedLabel = new System.Windows.Forms.Label();
            this.SelectedTextBox = new System.Windows.Forms.TextBox();
            this.ExitButton = new System.Windows.Forms.Button();
            this.NextButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SelectDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // SelectLabel
            // 
            this.SelectLabel.AutoSize = true;
            this.SelectLabel.Location = new System.Drawing.Point(13, 13);
            this.SelectLabel.Name = "SelectLabel";
            this.SelectLabel.Size = new System.Drawing.Size(232, 13);
            this.SelectLabel.TabIndex = 0;
            this.SelectLabel.Text = "Please select a computer you wish to purchase:";
            // 
            // SelectDataGridView
            // 
            this.SelectDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SelectDataGridView.Location = new System.Drawing.Point(16, 29);
            this.SelectDataGridView.MultiSelect = false;
            this.SelectDataGridView.Name = "SelectDataGridView";
            this.SelectDataGridView.ReadOnly = true;
            this.SelectDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.SelectDataGridView.Size = new System.Drawing.Size(413, 150);
            this.SelectDataGridView.TabIndex = 1;
            this.SelectDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SelectDataGridView_CellContentClick);
            // 
            // SelectedLabel
            // 
            this.SelectedLabel.AutoSize = true;
            this.SelectedLabel.Location = new System.Drawing.Point(12, 200);
            this.SelectedLabel.Name = "SelectedLabel";
            this.SelectedLabel.Size = new System.Drawing.Size(91, 13);
            this.SelectedLabel.TabIndex = 2;
            this.SelectedLabel.Text = "Current Selection:";
            // 
            // SelectedTextBox
            // 
            this.SelectedTextBox.Location = new System.Drawing.Point(111, 197);
            this.SelectedTextBox.Name = "SelectedTextBox";
            this.SelectedTextBox.ReadOnly = true;
            this.SelectedTextBox.Size = new System.Drawing.Size(318, 20);
            this.SelectedTextBox.TabIndex = 3;
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(12, 234);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 23);
            this.ExitButton.TabIndex = 4;
            this.ExitButton.Text = "Cancel";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // NextButton
            // 
            this.NextButton.Location = new System.Drawing.Point(354, 234);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(75, 23);
            this.NextButton.TabIndex = 5;
            this.NextButton.Text = "Next";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // SelectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 269);
            this.ControlBox = false;
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.SelectedTextBox);
            this.Controls.Add(this.SelectedLabel);
            this.Controls.Add(this.SelectDataGridView);
            this.Controls.Add(this.SelectLabel);
            this.Name = "SelectForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Select A Product";
            this.Load += new System.EventHandler(this.SelectForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SelectDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SelectLabel;
        private System.Windows.Forms.DataGridView SelectDataGridView;
        private System.Windows.Forms.Label SelectedLabel;
        private System.Windows.Forms.TextBox SelectedTextBox;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button NextButton;
    }
}