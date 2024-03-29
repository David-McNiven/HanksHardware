﻿namespace HanksHardware
{
    partial class OrderForm
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
            this.BackButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.FinishButton = new System.Windows.Forms.Button();
            this.OrderFormMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ProductPictureBox = new System.Windows.Forms.PictureBox();
            this.orderPriceGroupBox = new System.Windows.Forms.GroupBox();
            this.GrandTotalTextBox = new System.Windows.Forms.TextBox();
            this.SalestaxTextBox = new System.Windows.Forms.TextBox();
            this.ProductCostTextBox = new System.Windows.Forms.TextBox();
            this.GrandTotalLabel = new System.Windows.Forms.Label();
            this.SalesTaxLabel = new System.Windows.Forms.Label();
            this.ProductCostLabel = new System.Windows.Forms.Label();
            this.OrderDetailsGroupBox = new System.Windows.Forms.GroupBox();
            this.GPUTextBox = new System.Windows.Forms.TextBox();
            this.DisplayTextBox = new System.Windows.Forms.TextBox();
            this.HardDriveTextBox = new System.Windows.Forms.TextBox();
            this.RAMTextBox = new System.Windows.Forms.TextBox();
            this.CPUTextBox = new System.Windows.Forms.TextBox();
            this.WeightTextBox = new System.Windows.Forms.TextBox();
            this.WeightLabel = new System.Windows.Forms.Label();
            this.PlatformTextBox = new System.Windows.Forms.TextBox();
            this.PlatformLabel = new System.Windows.Forms.Label();
            this.ConditionTextBox = new System.Windows.Forms.TextBox();
            this.DimensionsTextBox = new System.Windows.Forms.TextBox();
            this.ManufacturerTextBox = new System.Windows.Forms.TextBox();
            this.ConditionLabel = new System.Windows.Forms.Label();
            this.DimensionsLabel = new System.Windows.Forms.Label();
            this.ManufacturerLabel = new System.Windows.Forms.Label();
            this.LANTextBox = new System.Windows.Forms.TextBox();
            this.LANLabel = new System.Windows.Forms.Label();
            this.WebCamTextBox = new System.Windows.Forms.TextBox();
            this.PowerTextBox = new System.Windows.Forms.TextBox();
            this.MouseTextBox = new System.Windows.Forms.TextBox();
            this.WIFITextBox = new System.Windows.Forms.TextBox();
            this.AudioTextBox = new System.Windows.Forms.TextBox();
            this.DiskDriveTextBox = new System.Windows.Forms.TextBox();
            this.WebcamLabel = new System.Windows.Forms.Label();
            this.PowerLabel = new System.Windows.Forms.Label();
            this.MouseLabel = new System.Windows.Forms.Label();
            this.WIFILabel = new System.Windows.Forms.Label();
            this.AudioLabel = new System.Windows.Forms.Label();
            this.DiskDriveLabel = new System.Windows.Forms.Label();
            this.GPULabel = new System.Windows.Forms.Label();
            this.CPULabel = new System.Windows.Forms.Label();
            this.DisplayLabel = new System.Windows.Forms.Label();
            this.RAMLabel = new System.Windows.Forms.Label();
            this.HardDriveLabel = new System.Windows.Forms.Label();
            this.OrderFormMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductPictureBox)).BeginInit();
            this.orderPriceGroupBox.SuspendLayout();
            this.OrderDetailsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(288, 284);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(75, 23);
            this.BackButton.TabIndex = 0;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(12, 284);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 23);
            this.ExitButton.TabIndex = 1;
            this.ExitButton.Text = "Cancel";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // FinishButton
            // 
            this.FinishButton.Location = new System.Drawing.Point(566, 284);
            this.FinishButton.Name = "FinishButton";
            this.FinishButton.Size = new System.Drawing.Size(75, 23);
            this.FinishButton.TabIndex = 2;
            this.FinishButton.Text = "Finish";
            this.FinishButton.UseVisualStyleBackColor = true;
            this.FinishButton.Click += new System.EventHandler(this.FinishButton_Click);
            // 
            // OrderFormMenuStrip
            // 
            this.OrderFormMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.OrderFormMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.OrderFormMenuStrip.Name = "OrderFormMenuStrip";
            this.OrderFormMenuStrip.Size = new System.Drawing.Size(861, 24);
            this.OrderFormMenuStrip.TabIndex = 3;
            this.OrderFormMenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.printToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.printToolStripMenuItem.Text = "&Print";
            this.printToolStripMenuItem.Click += new System.EventHandler(this.printToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // backToolStripMenuItem
            // 
            this.backToolStripMenuItem.Name = "backToolStripMenuItem";
            this.backToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.backToolStripMenuItem.Text = "&Back";
            this.backToolStripMenuItem.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // ProductPictureBox
            // 
            this.ProductPictureBox.Image = global::HanksHardware.Properties.Resources.Asus;
            this.ProductPictureBox.InitialImage = null;
            this.ProductPictureBox.Location = new System.Drawing.Point(647, 27);
            this.ProductPictureBox.Name = "ProductPictureBox";
            this.ProductPictureBox.Size = new System.Drawing.Size(203, 164);
            this.ProductPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ProductPictureBox.TabIndex = 4;
            this.ProductPictureBox.TabStop = false;
            // 
            // orderPriceGroupBox
            // 
            this.orderPriceGroupBox.Controls.Add(this.GrandTotalTextBox);
            this.orderPriceGroupBox.Controls.Add(this.SalestaxTextBox);
            this.orderPriceGroupBox.Controls.Add(this.ProductCostTextBox);
            this.orderPriceGroupBox.Controls.Add(this.GrandTotalLabel);
            this.orderPriceGroupBox.Controls.Add(this.SalesTaxLabel);
            this.orderPriceGroupBox.Controls.Add(this.ProductCostLabel);
            this.orderPriceGroupBox.Location = new System.Drawing.Point(647, 198);
            this.orderPriceGroupBox.Name = "orderPriceGroupBox";
            this.orderPriceGroupBox.Size = new System.Drawing.Size(200, 108);
            this.orderPriceGroupBox.TabIndex = 5;
            this.orderPriceGroupBox.TabStop = false;
            this.orderPriceGroupBox.Text = "Order Pricing";
            // 
            // GrandTotalTextBox
            // 
            this.GrandTotalTextBox.Location = new System.Drawing.Point(94, 74);
            this.GrandTotalTextBox.Name = "GrandTotalTextBox";
            this.GrandTotalTextBox.Size = new System.Drawing.Size(100, 20);
            this.GrandTotalTextBox.TabIndex = 5;
            // 
            // SalestaxTextBox
            // 
            this.SalestaxTextBox.Location = new System.Drawing.Point(94, 48);
            this.SalestaxTextBox.Name = "SalestaxTextBox";
            this.SalestaxTextBox.Size = new System.Drawing.Size(100, 20);
            this.SalestaxTextBox.TabIndex = 4;
            // 
            // ProductCostTextBox
            // 
            this.ProductCostTextBox.Location = new System.Drawing.Point(94, 23);
            this.ProductCostTextBox.Name = "ProductCostTextBox";
            this.ProductCostTextBox.Size = new System.Drawing.Size(100, 20);
            this.ProductCostTextBox.TabIndex = 3;
            // 
            // GrandTotalLabel
            // 
            this.GrandTotalLabel.AutoSize = true;
            this.GrandTotalLabel.Location = new System.Drawing.Point(6, 77);
            this.GrandTotalLabel.Name = "GrandTotalLabel";
            this.GrandTotalLabel.Size = new System.Drawing.Size(63, 13);
            this.GrandTotalLabel.TabIndex = 2;
            this.GrandTotalLabel.Text = "Grand Total";
            // 
            // SalesTaxLabel
            // 
            this.SalesTaxLabel.AutoSize = true;
            this.SalesTaxLabel.Location = new System.Drawing.Point(6, 51);
            this.SalesTaxLabel.Name = "SalesTaxLabel";
            this.SalesTaxLabel.Size = new System.Drawing.Size(83, 13);
            this.SalesTaxLabel.TabIndex = 1;
            this.SalesTaxLabel.Text = "Sales Tax (13%)";
            // 
            // ProductCostLabel
            // 
            this.ProductCostLabel.AutoSize = true;
            this.ProductCostLabel.Location = new System.Drawing.Point(6, 26);
            this.ProductCostLabel.Name = "ProductCostLabel";
            this.ProductCostLabel.Size = new System.Drawing.Size(68, 13);
            this.ProductCostLabel.TabIndex = 0;
            this.ProductCostLabel.Text = "Product Cost";
            // 
            // OrderDetailsGroupBox
            // 
            this.OrderDetailsGroupBox.Controls.Add(this.GPUTextBox);
            this.OrderDetailsGroupBox.Controls.Add(this.DisplayTextBox);
            this.OrderDetailsGroupBox.Controls.Add(this.HardDriveTextBox);
            this.OrderDetailsGroupBox.Controls.Add(this.RAMTextBox);
            this.OrderDetailsGroupBox.Controls.Add(this.CPUTextBox);
            this.OrderDetailsGroupBox.Controls.Add(this.WeightTextBox);
            this.OrderDetailsGroupBox.Controls.Add(this.WeightLabel);
            this.OrderDetailsGroupBox.Controls.Add(this.PlatformTextBox);
            this.OrderDetailsGroupBox.Controls.Add(this.PlatformLabel);
            this.OrderDetailsGroupBox.Controls.Add(this.ConditionTextBox);
            this.OrderDetailsGroupBox.Controls.Add(this.DimensionsTextBox);
            this.OrderDetailsGroupBox.Controls.Add(this.ManufacturerTextBox);
            this.OrderDetailsGroupBox.Controls.Add(this.ConditionLabel);
            this.OrderDetailsGroupBox.Controls.Add(this.DimensionsLabel);
            this.OrderDetailsGroupBox.Controls.Add(this.ManufacturerLabel);
            this.OrderDetailsGroupBox.Controls.Add(this.LANTextBox);
            this.OrderDetailsGroupBox.Controls.Add(this.LANLabel);
            this.OrderDetailsGroupBox.Controls.Add(this.WebCamTextBox);
            this.OrderDetailsGroupBox.Controls.Add(this.PowerTextBox);
            this.OrderDetailsGroupBox.Controls.Add(this.MouseTextBox);
            this.OrderDetailsGroupBox.Controls.Add(this.WIFITextBox);
            this.OrderDetailsGroupBox.Controls.Add(this.AudioTextBox);
            this.OrderDetailsGroupBox.Controls.Add(this.DiskDriveTextBox);
            this.OrderDetailsGroupBox.Controls.Add(this.WebcamLabel);
            this.OrderDetailsGroupBox.Controls.Add(this.PowerLabel);
            this.OrderDetailsGroupBox.Controls.Add(this.MouseLabel);
            this.OrderDetailsGroupBox.Controls.Add(this.WIFILabel);
            this.OrderDetailsGroupBox.Controls.Add(this.AudioLabel);
            this.OrderDetailsGroupBox.Controls.Add(this.DiskDriveLabel);
            this.OrderDetailsGroupBox.Controls.Add(this.GPULabel);
            this.OrderDetailsGroupBox.Controls.Add(this.CPULabel);
            this.OrderDetailsGroupBox.Controls.Add(this.DisplayLabel);
            this.OrderDetailsGroupBox.Controls.Add(this.RAMLabel);
            this.OrderDetailsGroupBox.Controls.Add(this.HardDriveLabel);
            this.OrderDetailsGroupBox.Location = new System.Drawing.Point(13, 28);
            this.OrderDetailsGroupBox.Name = "OrderDetailsGroupBox";
            this.OrderDetailsGroupBox.Size = new System.Drawing.Size(628, 250);
            this.OrderDetailsGroupBox.TabIndex = 6;
            this.OrderDetailsGroupBox.TabStop = false;
            this.OrderDetailsGroupBox.Text = "Product Details";
            // 
            // GPUTextBox
            // 
            this.GPUTextBox.Location = new System.Drawing.Point(77, 225);
            this.GPUTextBox.Name = "GPUTextBox";
            this.GPUTextBox.Size = new System.Drawing.Size(231, 20);
            this.GPUTextBox.TabIndex = 44;
            // 
            // DisplayTextBox
            // 
            this.DisplayTextBox.Location = new System.Drawing.Point(77, 198);
            this.DisplayTextBox.Name = "DisplayTextBox";
            this.DisplayTextBox.Size = new System.Drawing.Size(231, 20);
            this.DisplayTextBox.TabIndex = 43;
            // 
            // HardDriveTextBox
            // 
            this.HardDriveTextBox.Location = new System.Drawing.Point(77, 171);
            this.HardDriveTextBox.Name = "HardDriveTextBox";
            this.HardDriveTextBox.Size = new System.Drawing.Size(231, 20);
            this.HardDriveTextBox.TabIndex = 42;
            // 
            // RAMTextBox
            // 
            this.RAMTextBox.Location = new System.Drawing.Point(77, 145);
            this.RAMTextBox.Name = "RAMTextBox";
            this.RAMTextBox.Size = new System.Drawing.Size(231, 20);
            this.RAMTextBox.TabIndex = 41;
            // 
            // CPUTextBox
            // 
            this.CPUTextBox.Location = new System.Drawing.Point(77, 118);
            this.CPUTextBox.Name = "CPUTextBox";
            this.CPUTextBox.Size = new System.Drawing.Size(231, 20);
            this.CPUTextBox.TabIndex = 40;
            // 
            // WeightTextBox
            // 
            this.WeightTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.WeightTextBox.Location = new System.Drawing.Point(77, 95);
            this.WeightTextBox.Name = "WeightTextBox";
            this.WeightTextBox.ReadOnly = true;
            this.WeightTextBox.Size = new System.Drawing.Size(231, 20);
            this.WeightTextBox.TabIndex = 39;
            // 
            // WeightLabel
            // 
            this.WeightLabel.AutoSize = true;
            this.WeightLabel.Location = new System.Drawing.Point(6, 98);
            this.WeightLabel.Name = "WeightLabel";
            this.WeightLabel.Size = new System.Drawing.Size(41, 13);
            this.WeightLabel.TabIndex = 38;
            this.WeightLabel.Text = "Weight";
            // 
            // PlatformTextBox
            // 
            this.PlatformTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.PlatformTextBox.Location = new System.Drawing.Point(77, 39);
            this.PlatformTextBox.Name = "PlatformTextBox";
            this.PlatformTextBox.ReadOnly = true;
            this.PlatformTextBox.Size = new System.Drawing.Size(231, 20);
            this.PlatformTextBox.TabIndex = 37;
            // 
            // PlatformLabel
            // 
            this.PlatformLabel.AutoSize = true;
            this.PlatformLabel.Location = new System.Drawing.Point(6, 42);
            this.PlatformLabel.Name = "PlatformLabel";
            this.PlatformLabel.Size = new System.Drawing.Size(45, 13);
            this.PlatformLabel.TabIndex = 36;
            this.PlatformLabel.Text = "Platform";
            // 
            // ConditionTextBox
            // 
            this.ConditionTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.ConditionTextBox.Location = new System.Drawing.Point(383, 13);
            this.ConditionTextBox.Name = "ConditionTextBox";
            this.ConditionTextBox.ReadOnly = true;
            this.ConditionTextBox.Size = new System.Drawing.Size(231, 20);
            this.ConditionTextBox.TabIndex = 34;
            // 
            // DimensionsTextBox
            // 
            this.DimensionsTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.DimensionsTextBox.Location = new System.Drawing.Point(77, 65);
            this.DimensionsTextBox.Name = "DimensionsTextBox";
            this.DimensionsTextBox.ReadOnly = true;
            this.DimensionsTextBox.Size = new System.Drawing.Size(231, 20);
            this.DimensionsTextBox.TabIndex = 33;
            // 
            // ManufacturerTextBox
            // 
            this.ManufacturerTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.ManufacturerTextBox.Location = new System.Drawing.Point(77, 17);
            this.ManufacturerTextBox.Name = "ManufacturerTextBox";
            this.ManufacturerTextBox.ReadOnly = true;
            this.ManufacturerTextBox.Size = new System.Drawing.Size(231, 20);
            this.ManufacturerTextBox.TabIndex = 31;
            // 
            // ConditionLabel
            // 
            this.ConditionLabel.AutoSize = true;
            this.ConditionLabel.Location = new System.Drawing.Point(315, 13);
            this.ConditionLabel.Name = "ConditionLabel";
            this.ConditionLabel.Size = new System.Drawing.Size(51, 13);
            this.ConditionLabel.TabIndex = 29;
            this.ConditionLabel.Text = "Condition";
            // 
            // DimensionsLabel
            // 
            this.DimensionsLabel.AutoSize = true;
            this.DimensionsLabel.Location = new System.Drawing.Point(6, 65);
            this.DimensionsLabel.Name = "DimensionsLabel";
            this.DimensionsLabel.Size = new System.Drawing.Size(61, 13);
            this.DimensionsLabel.TabIndex = 28;
            this.DimensionsLabel.Text = "Dimensions";
            // 
            // ManufacturerLabel
            // 
            this.ManufacturerLabel.AutoSize = true;
            this.ManufacturerLabel.Location = new System.Drawing.Point(6, 20);
            this.ManufacturerLabel.Name = "ManufacturerLabel";
            this.ManufacturerLabel.Size = new System.Drawing.Size(34, 13);
            this.ManufacturerLabel.TabIndex = 26;
            this.ManufacturerLabel.Text = "Make";
            // 
            // LANTextBox
            // 
            this.LANTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.LANTextBox.Location = new System.Drawing.Point(383, 93);
            this.LANTextBox.Name = "LANTextBox";
            this.LANTextBox.ReadOnly = true;
            this.LANTextBox.Size = new System.Drawing.Size(231, 20);
            this.LANTextBox.TabIndex = 25;
            // 
            // LANLabel
            // 
            this.LANLabel.AutoSize = true;
            this.LANLabel.Location = new System.Drawing.Point(322, 96);
            this.LANLabel.Name = "LANLabel";
            this.LANLabel.Size = new System.Drawing.Size(28, 13);
            this.LANLabel.TabIndex = 24;
            this.LANLabel.Text = "LAN";
            // 
            // WebCamTextBox
            // 
            this.WebCamTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.WebCamTextBox.Location = new System.Drawing.Point(383, 199);
            this.WebCamTextBox.Name = "WebCamTextBox";
            this.WebCamTextBox.ReadOnly = true;
            this.WebCamTextBox.Size = new System.Drawing.Size(231, 20);
            this.WebCamTextBox.TabIndex = 23;
            // 
            // PowerTextBox
            // 
            this.PowerTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.PowerTextBox.Location = new System.Drawing.Point(383, 175);
            this.PowerTextBox.Name = "PowerTextBox";
            this.PowerTextBox.ReadOnly = true;
            this.PowerTextBox.Size = new System.Drawing.Size(231, 20);
            this.PowerTextBox.TabIndex = 22;
            // 
            // MouseTextBox
            // 
            this.MouseTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.MouseTextBox.Location = new System.Drawing.Point(383, 147);
            this.MouseTextBox.Name = "MouseTextBox";
            this.MouseTextBox.ReadOnly = true;
            this.MouseTextBox.Size = new System.Drawing.Size(231, 20);
            this.MouseTextBox.TabIndex = 21;
            // 
            // WIFITextBox
            // 
            this.WIFITextBox.BackColor = System.Drawing.SystemColors.Window;
            this.WIFITextBox.Location = new System.Drawing.Point(383, 121);
            this.WIFITextBox.Name = "WIFITextBox";
            this.WIFITextBox.ReadOnly = true;
            this.WIFITextBox.Size = new System.Drawing.Size(231, 20);
            this.WIFITextBox.TabIndex = 20;
            // 
            // AudioTextBox
            // 
            this.AudioTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.AudioTextBox.Location = new System.Drawing.Point(383, 66);
            this.AudioTextBox.Name = "AudioTextBox";
            this.AudioTextBox.ReadOnly = true;
            this.AudioTextBox.Size = new System.Drawing.Size(231, 20);
            this.AudioTextBox.TabIndex = 19;
            // 
            // DiskDriveTextBox
            // 
            this.DiskDriveTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.DiskDriveTextBox.Location = new System.Drawing.Point(383, 42);
            this.DiskDriveTextBox.Name = "DiskDriveTextBox";
            this.DiskDriveTextBox.ReadOnly = true;
            this.DiskDriveTextBox.Size = new System.Drawing.Size(231, 20);
            this.DiskDriveTextBox.TabIndex = 18;
            // 
            // WebcamLabel
            // 
            this.WebcamLabel.AutoSize = true;
            this.WebcamLabel.Location = new System.Drawing.Point(319, 202);
            this.WebcamLabel.Name = "WebcamLabel";
            this.WebcamLabel.Size = new System.Drawing.Size(51, 13);
            this.WebcamLabel.TabIndex = 17;
            this.WebcamLabel.Text = "WebCam";
            // 
            // PowerLabel
            // 
            this.PowerLabel.AutoSize = true;
            this.PowerLabel.Location = new System.Drawing.Point(319, 178);
            this.PowerLabel.Name = "PowerLabel";
            this.PowerLabel.Size = new System.Drawing.Size(37, 13);
            this.PowerLabel.TabIndex = 16;
            this.PowerLabel.Text = "Power";
            // 
            // MouseLabel
            // 
            this.MouseLabel.AutoSize = true;
            this.MouseLabel.Location = new System.Drawing.Point(322, 150);
            this.MouseLabel.Name = "MouseLabel";
            this.MouseLabel.Size = new System.Drawing.Size(39, 13);
            this.MouseLabel.TabIndex = 15;
            this.MouseLabel.Text = "Mouse";
            // 
            // WIFILabel
            // 
            this.WIFILabel.AutoSize = true;
            this.WIFILabel.Location = new System.Drawing.Point(322, 124);
            this.WIFILabel.Name = "WIFILabel";
            this.WIFILabel.Size = new System.Drawing.Size(30, 13);
            this.WIFILabel.TabIndex = 14;
            this.WIFILabel.Text = "WIFI";
            // 
            // AudioLabel
            // 
            this.AudioLabel.AutoSize = true;
            this.AudioLabel.Location = new System.Drawing.Point(319, 69);
            this.AudioLabel.Name = "AudioLabel";
            this.AudioLabel.Size = new System.Drawing.Size(34, 13);
            this.AudioLabel.TabIndex = 13;
            this.AudioLabel.Text = "Audio";
            // 
            // DiskDriveLabel
            // 
            this.DiskDriveLabel.AutoSize = true;
            this.DiskDriveLabel.Location = new System.Drawing.Point(319, 45);
            this.DiskDriveLabel.Name = "DiskDriveLabel";
            this.DiskDriveLabel.Size = new System.Drawing.Size(56, 13);
            this.DiskDriveLabel.TabIndex = 12;
            this.DiskDriveLabel.Text = "Disk Drive";
            // 
            // GPULabel
            // 
            this.GPULabel.AutoSize = true;
            this.GPULabel.Location = new System.Drawing.Point(13, 226);
            this.GPULabel.Name = "GPULabel";
            this.GPULabel.Size = new System.Drawing.Size(30, 13);
            this.GPULabel.TabIndex = 4;
            this.GPULabel.Text = "GPU";
            // 
            // CPULabel
            // 
            this.CPULabel.AutoSize = true;
            this.CPULabel.Location = new System.Drawing.Point(6, 120);
            this.CPULabel.Name = "CPULabel";
            this.CPULabel.Size = new System.Drawing.Size(29, 13);
            this.CPULabel.TabIndex = 3;
            this.CPULabel.Text = "CPU";
            // 
            // DisplayLabel
            // 
            this.DisplayLabel.AutoSize = true;
            this.DisplayLabel.Location = new System.Drawing.Point(13, 201);
            this.DisplayLabel.Name = "DisplayLabel";
            this.DisplayLabel.Size = new System.Drawing.Size(41, 13);
            this.DisplayLabel.TabIndex = 2;
            this.DisplayLabel.Text = "Display";
            // 
            // RAMLabel
            // 
            this.RAMLabel.AutoSize = true;
            this.RAMLabel.Location = new System.Drawing.Point(6, 145);
            this.RAMLabel.Name = "RAMLabel";
            this.RAMLabel.Size = new System.Drawing.Size(31, 13);
            this.RAMLabel.TabIndex = 1;
            this.RAMLabel.Text = "RAM";
            // 
            // HardDriveLabel
            // 
            this.HardDriveLabel.AutoSize = true;
            this.HardDriveLabel.Location = new System.Drawing.Point(6, 171);
            this.HardDriveLabel.Name = "HardDriveLabel";
            this.HardDriveLabel.Size = new System.Drawing.Size(58, 13);
            this.HardDriveLabel.TabIndex = 0;
            this.HardDriveLabel.Text = "Hard Drive";
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 316);
            this.ControlBox = false;
            this.Controls.Add(this.OrderDetailsGroupBox);
            this.Controls.Add(this.orderPriceGroupBox);
            this.Controls.Add(this.ProductPictureBox);
            this.Controls.Add(this.FinishButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.OrderFormMenuStrip);
            this.MainMenuStrip = this.OrderFormMenuStrip;
            this.Name = "OrderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Order Information";
            this.Load += new System.EventHandler(this.OrderForm_Load);
            this.OrderFormMenuStrip.ResumeLayout(false);
            this.OrderFormMenuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductPictureBox)).EndInit();
            this.orderPriceGroupBox.ResumeLayout(false);
            this.orderPriceGroupBox.PerformLayout();
            this.OrderDetailsGroupBox.ResumeLayout(false);
            this.OrderDetailsGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button FinishButton;
        private System.Windows.Forms.MenuStrip OrderFormMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.PictureBox ProductPictureBox;
        private System.Windows.Forms.GroupBox orderPriceGroupBox;
        private System.Windows.Forms.TextBox GrandTotalTextBox;
        private System.Windows.Forms.TextBox SalestaxTextBox;
        private System.Windows.Forms.TextBox ProductCostTextBox;
        private System.Windows.Forms.Label GrandTotalLabel;
        private System.Windows.Forms.Label SalesTaxLabel;
        private System.Windows.Forms.Label ProductCostLabel;
        private System.Windows.Forms.GroupBox OrderDetailsGroupBox;
        private System.Windows.Forms.Label HardDriveLabel;
        private System.Windows.Forms.Label RAMLabel;
        private System.Windows.Forms.Label CPULabel;
        private System.Windows.Forms.Label DisplayLabel;
        private System.Windows.Forms.Label GPULabel;
        private System.Windows.Forms.TextBox WebCamTextBox;
        private System.Windows.Forms.TextBox PowerTextBox;
        private System.Windows.Forms.TextBox MouseTextBox;
        private System.Windows.Forms.TextBox WIFITextBox;
        private System.Windows.Forms.TextBox AudioTextBox;
        private System.Windows.Forms.TextBox DiskDriveTextBox;
        private System.Windows.Forms.Label WebcamLabel;
        private System.Windows.Forms.Label PowerLabel;
        private System.Windows.Forms.Label MouseLabel;
        private System.Windows.Forms.Label WIFILabel;
        private System.Windows.Forms.Label AudioLabel;
        private System.Windows.Forms.Label DiskDriveLabel;
        private System.Windows.Forms.TextBox LANTextBox;
        private System.Windows.Forms.Label LANLabel;
        private System.Windows.Forms.TextBox GPUTextBox;
        private System.Windows.Forms.TextBox DisplayTextBox;
        private System.Windows.Forms.TextBox HardDriveTextBox;
        private System.Windows.Forms.TextBox RAMTextBox;
        private System.Windows.Forms.TextBox CPUTextBox;
        private System.Windows.Forms.TextBox WeightTextBox;
        private System.Windows.Forms.Label WeightLabel;
        private System.Windows.Forms.TextBox PlatformTextBox;
        private System.Windows.Forms.Label PlatformLabel;
        private System.Windows.Forms.TextBox ConditionTextBox;
        private System.Windows.Forms.TextBox DimensionsTextBox;
        private System.Windows.Forms.TextBox ManufacturerTextBox;
        private System.Windows.Forms.Label ConditionLabel;
        private System.Windows.Forms.Label DimensionsLabel;
        private System.Windows.Forms.Label ManufacturerLabel;
    }
}