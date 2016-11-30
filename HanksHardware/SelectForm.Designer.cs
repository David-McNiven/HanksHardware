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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.SelectLabel = new System.Windows.Forms.Label();
            this.SelectDataGridView = new System.Windows.Forms.DataGridView();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cOMP1004DataSet = new HanksHardware.COMP1004DataSet();
            this.SelectedLabel = new System.Windows.Forms.Label();
            this.SelectedTextBox = new System.Windows.Forms.TextBox();
            this.ExitButton = new System.Windows.Forms.Button();
            this.NextButton = new System.Windows.Forms.Button();
            this.productsTableAdapter = new HanksHardware.COMP1004DataSetTableAdapters.productsTableAdapter();
            this.productIDColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manufacturerColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RAM_typeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RAM_sizeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.displaytypeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.screensizeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resolutionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPU_ClassColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPU_brandColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPU_typeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPU_speedColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPU_numberColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.conditionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OSColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.platformColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HDD_sizeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HDD_speedColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GPU_TypeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.optical_driveColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Audio_typeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LANColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WIFIColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.widthColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.heightColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.depthColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weightColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moust_typeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.powerColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.webcamColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.SelectDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOMP1004DataSet)).BeginInit();
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
            this.SelectDataGridView.AllowUserToAddRows = false;
            this.SelectDataGridView.AllowUserToDeleteRows = false;
            this.SelectDataGridView.AllowUserToResizeColumns = false;
            this.SelectDataGridView.AllowUserToResizeRows = false;
            this.SelectDataGridView.AutoGenerateColumns = false;
            this.SelectDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.SelectDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SelectDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productIDColumn,
            this.costColumn,
            this.manufacturerColumn,
            this.modelColumn,
            this.RAM_typeColumn,
            this.RAM_sizeColumn,
            this.displaytypeColumn,
            this.screensizeColumn,
            this.resolutionColumn,
            this.CPU_ClassColumn,
            this.CPU_brandColumn,
            this.CPU_typeColumn,
            this.CPU_speedColumn,
            this.CPU_numberColumn,
            this.conditionColumn,
            this.OSColumn,
            this.platformColumn,
            this.HDD_sizeColumn,
            this.HDD_speedColumn,
            this.GPU_TypeColumn,
            this.optical_driveColumn,
            this.Audio_typeColumn,
            this.LANColumn,
            this.WIFIColumn,
            this.widthColumn,
            this.heightColumn,
            this.depthColumn,
            this.weightColumn,
            this.moust_typeColumn,
            this.powerColumn,
            this.webcamColumn});
            this.SelectDataGridView.DataSource = this.productsBindingSource;
            this.SelectDataGridView.Location = new System.Drawing.Point(16, 29);
            this.SelectDataGridView.MultiSelect = false;
            this.SelectDataGridView.Name = "SelectDataGridView";
            this.SelectDataGridView.ReadOnly = true;
            this.SelectDataGridView.RowHeadersVisible = false;
            this.SelectDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.SelectDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.SelectDataGridView.Size = new System.Drawing.Size(621, 225);
            this.SelectDataGridView.TabIndex = 1;
            this.SelectDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SelectDataGridView_CellContentClick);
            this.SelectDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SelectDataGridView_CellContentClick);
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "products";
            this.productsBindingSource.DataSource = this.cOMP1004DataSet;
            // 
            // cOMP1004DataSet
            // 
            this.cOMP1004DataSet.DataSetName = "COMP1004DataSet";
            this.cOMP1004DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // SelectedLabel
            // 
            this.SelectedLabel.AutoSize = true;
            this.SelectedLabel.Location = new System.Drawing.Point(13, 265);
            this.SelectedLabel.Name = "SelectedLabel";
            this.SelectedLabel.Size = new System.Drawing.Size(91, 13);
            this.SelectedLabel.TabIndex = 2;
            this.SelectedLabel.Text = "Current Selection:";
            // 
            // SelectedTextBox
            // 
            this.SelectedTextBox.Location = new System.Drawing.Point(110, 262);
            this.SelectedTextBox.Name = "SelectedTextBox";
            this.SelectedTextBox.ReadOnly = true;
            this.SelectedTextBox.Size = new System.Drawing.Size(365, 20);
            this.SelectedTextBox.TabIndex = 3;
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(481, 260);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 23);
            this.ExitButton.TabIndex = 4;
            this.ExitButton.Text = "Cancel";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // NextButton
            // 
            this.NextButton.Location = new System.Drawing.Point(562, 260);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(75, 23);
            this.NextButton.TabIndex = 5;
            this.NextButton.Text = "Next";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // productIDColumn
            // 
            this.productIDColumn.DataPropertyName = "productID";
            this.productIDColumn.HeaderText = "productID";
            this.productIDColumn.Name = "productIDColumn";
            this.productIDColumn.ReadOnly = true;
            this.productIDColumn.Visible = false;
            this.productIDColumn.Width = 60;
            // 
            // costColumn
            // 
            this.costColumn.DataPropertyName = "cost";
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = null;
            this.costColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.costColumn.HeaderText = "cost";
            this.costColumn.Name = "costColumn";
            this.costColumn.ReadOnly = true;
            this.costColumn.Width = 52;
            // 
            // manufacturerColumn
            // 
            this.manufacturerColumn.DataPropertyName = "manufacturer";
            this.manufacturerColumn.HeaderText = "manufacturer";
            this.manufacturerColumn.Name = "manufacturerColumn";
            this.manufacturerColumn.ReadOnly = true;
            this.manufacturerColumn.Width = 94;
            // 
            // modelColumn
            // 
            this.modelColumn.DataPropertyName = "model";
            this.modelColumn.HeaderText = "model";
            this.modelColumn.Name = "modelColumn";
            this.modelColumn.ReadOnly = true;
            this.modelColumn.Width = 60;
            // 
            // RAM_typeColumn
            // 
            this.RAM_typeColumn.DataPropertyName = "RAM_type";
            this.RAM_typeColumn.HeaderText = "RAM_type";
            this.RAM_typeColumn.Name = "RAM_typeColumn";
            this.RAM_typeColumn.ReadOnly = true;
            this.RAM_typeColumn.Width = 82;
            // 
            // RAM_sizeColumn
            // 
            this.RAM_sizeColumn.DataPropertyName = "RAM_size";
            this.RAM_sizeColumn.HeaderText = "RAM_size";
            this.RAM_sizeColumn.Name = "RAM_sizeColumn";
            this.RAM_sizeColumn.ReadOnly = true;
            this.RAM_sizeColumn.Width = 80;
            // 
            // displaytypeColumn
            // 
            this.displaytypeColumn.DataPropertyName = "displaytype";
            this.displaytypeColumn.HeaderText = "displaytype";
            this.displaytypeColumn.Name = "displaytypeColumn";
            this.displaytypeColumn.ReadOnly = true;
            this.displaytypeColumn.Width = 84;
            // 
            // screensizeColumn
            // 
            this.screensizeColumn.DataPropertyName = "screensize";
            this.screensizeColumn.HeaderText = "screensize";
            this.screensizeColumn.Name = "screensizeColumn";
            this.screensizeColumn.ReadOnly = true;
            this.screensizeColumn.Width = 82;
            // 
            // resolutionColumn
            // 
            this.resolutionColumn.DataPropertyName = "resolution";
            this.resolutionColumn.HeaderText = "resolution";
            this.resolutionColumn.Name = "resolutionColumn";
            this.resolutionColumn.ReadOnly = true;
            this.resolutionColumn.Width = 77;
            // 
            // CPU_ClassColumn
            // 
            this.CPU_ClassColumn.DataPropertyName = "CPU_Class";
            this.CPU_ClassColumn.HeaderText = "CPU_Class";
            this.CPU_ClassColumn.Name = "CPU_ClassColumn";
            this.CPU_ClassColumn.ReadOnly = true;
            this.CPU_ClassColumn.Width = 85;
            // 
            // CPU_brandColumn
            // 
            this.CPU_brandColumn.DataPropertyName = "CPU_brand";
            this.CPU_brandColumn.HeaderText = "CPU_brand";
            this.CPU_brandColumn.Name = "CPU_brandColumn";
            this.CPU_brandColumn.ReadOnly = true;
            this.CPU_brandColumn.Width = 87;
            // 
            // CPU_typeColumn
            // 
            this.CPU_typeColumn.DataPropertyName = "CPU_type";
            this.CPU_typeColumn.HeaderText = "CPU_type";
            this.CPU_typeColumn.Name = "CPU_typeColumn";
            this.CPU_typeColumn.ReadOnly = true;
            this.CPU_typeColumn.Width = 80;
            // 
            // CPU_speedColumn
            // 
            this.CPU_speedColumn.DataPropertyName = "CPU_speed";
            this.CPU_speedColumn.HeaderText = "CPU_speed";
            this.CPU_speedColumn.Name = "CPU_speedColumn";
            this.CPU_speedColumn.ReadOnly = true;
            this.CPU_speedColumn.Width = 89;
            // 
            // CPU_numberColumn
            // 
            this.CPU_numberColumn.DataPropertyName = "CPU_number";
            this.CPU_numberColumn.HeaderText = "CPU_number";
            this.CPU_numberColumn.Name = "CPU_numberColumn";
            this.CPU_numberColumn.ReadOnly = true;
            this.CPU_numberColumn.Width = 95;
            // 
            // conditionColumn
            // 
            this.conditionColumn.DataPropertyName = "condition";
            this.conditionColumn.HeaderText = "condition";
            this.conditionColumn.Name = "conditionColumn";
            this.conditionColumn.ReadOnly = true;
            this.conditionColumn.Width = 75;
            // 
            // OSColumn
            // 
            this.OSColumn.DataPropertyName = "OS";
            this.OSColumn.HeaderText = "OS";
            this.OSColumn.Name = "OSColumn";
            this.OSColumn.ReadOnly = true;
            this.OSColumn.Width = 47;
            // 
            // platformColumn
            // 
            this.platformColumn.DataPropertyName = "platform";
            this.platformColumn.HeaderText = "platform";
            this.platformColumn.Name = "platformColumn";
            this.platformColumn.ReadOnly = true;
            this.platformColumn.Width = 69;
            // 
            // HDD_sizeColumn
            // 
            this.HDD_sizeColumn.DataPropertyName = "HDD_size";
            this.HDD_sizeColumn.HeaderText = "HDD_size";
            this.HDD_sizeColumn.Name = "HDD_sizeColumn";
            this.HDD_sizeColumn.ReadOnly = true;
            this.HDD_sizeColumn.Width = 80;
            // 
            // HDD_speedColumn
            // 
            this.HDD_speedColumn.DataPropertyName = "HDD_speed";
            this.HDD_speedColumn.HeaderText = "HDD_speed";
            this.HDD_speedColumn.Name = "HDD_speedColumn";
            this.HDD_speedColumn.ReadOnly = true;
            this.HDD_speedColumn.Width = 91;
            // 
            // GPU_TypeColumn
            // 
            this.GPU_TypeColumn.DataPropertyName = "GPU_Type";
            this.GPU_TypeColumn.HeaderText = "GPU_Type";
            this.GPU_TypeColumn.Name = "GPU_TypeColumn";
            this.GPU_TypeColumn.ReadOnly = true;
            this.GPU_TypeColumn.Width = 85;
            // 
            // optical_driveColumn
            // 
            this.optical_driveColumn.DataPropertyName = "optical_drive";
            this.optical_driveColumn.HeaderText = "optical_drive";
            this.optical_driveColumn.Name = "optical_driveColumn";
            this.optical_driveColumn.ReadOnly = true;
            this.optical_driveColumn.Width = 92;
            // 
            // Audio_typeColumn
            // 
            this.Audio_typeColumn.DataPropertyName = "Audio_type";
            this.Audio_typeColumn.HeaderText = "Audio_type";
            this.Audio_typeColumn.Name = "Audio_typeColumn";
            this.Audio_typeColumn.ReadOnly = true;
            this.Audio_typeColumn.Width = 85;
            // 
            // LANColumn
            // 
            this.LANColumn.DataPropertyName = "LAN";
            this.LANColumn.HeaderText = "LAN";
            this.LANColumn.Name = "LANColumn";
            this.LANColumn.ReadOnly = true;
            this.LANColumn.Width = 53;
            // 
            // WIFIColumn
            // 
            this.WIFIColumn.DataPropertyName = "WIFI";
            this.WIFIColumn.HeaderText = "WIFI";
            this.WIFIColumn.Name = "WIFIColumn";
            this.WIFIColumn.ReadOnly = true;
            this.WIFIColumn.Width = 55;
            // 
            // widthColumn
            // 
            this.widthColumn.DataPropertyName = "width";
            this.widthColumn.HeaderText = "width";
            this.widthColumn.Name = "widthColumn";
            this.widthColumn.ReadOnly = true;
            this.widthColumn.Width = 57;
            // 
            // heightColumn
            // 
            this.heightColumn.DataPropertyName = "height";
            this.heightColumn.HeaderText = "height";
            this.heightColumn.Name = "heightColumn";
            this.heightColumn.ReadOnly = true;
            this.heightColumn.Width = 61;
            // 
            // depthColumn
            // 
            this.depthColumn.DataPropertyName = "depth";
            this.depthColumn.HeaderText = "depth";
            this.depthColumn.Name = "depthColumn";
            this.depthColumn.ReadOnly = true;
            this.depthColumn.Width = 59;
            // 
            // weightColumn
            // 
            this.weightColumn.DataPropertyName = "weight";
            this.weightColumn.HeaderText = "weight";
            this.weightColumn.Name = "weightColumn";
            this.weightColumn.ReadOnly = true;
            this.weightColumn.Width = 63;
            // 
            // moust_typeColumn
            // 
            this.moust_typeColumn.DataPropertyName = "moust_type";
            this.moust_typeColumn.HeaderText = "moust_type";
            this.moust_typeColumn.Name = "moust_typeColumn";
            this.moust_typeColumn.ReadOnly = true;
            this.moust_typeColumn.Width = 86;
            // 
            // powerColumn
            // 
            this.powerColumn.DataPropertyName = "power";
            this.powerColumn.HeaderText = "power";
            this.powerColumn.Name = "powerColumn";
            this.powerColumn.ReadOnly = true;
            this.powerColumn.Width = 61;
            // 
            // webcamColumn
            // 
            this.webcamColumn.DataPropertyName = "webcam";
            this.webcamColumn.HeaderText = "webcam";
            this.webcamColumn.Name = "webcamColumn";
            this.webcamColumn.ReadOnly = true;
            this.webcamColumn.Width = 72;
            // 
            // SelectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 295);
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
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOMP1004DataSet)).EndInit();
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
        private COMP1004DataSet cOMP1004DataSet;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private COMP1004DataSetTableAdapters.productsTableAdapter productsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIDColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn manufacturerColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn RAM_typeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn RAM_sizeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn displaytypeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn screensizeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn resolutionColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPU_ClassColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPU_brandColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPU_typeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPU_speedColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPU_numberColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn conditionColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn OSColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn platformColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn HDD_sizeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn HDD_speedColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn GPU_TypeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn optical_driveColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Audio_typeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn LANColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn WIFIColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn widthColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn heightColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn depthColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn weightColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn moust_typeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn powerColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn webcamColumn;
    }
}