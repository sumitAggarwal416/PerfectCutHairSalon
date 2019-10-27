namespace Perfect_Cut_Hair_Salon
{
    partial class Form1
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
            this.hairdresserGroupBox = new System.Windows.Forms.GroupBox();
            this.hairdresserComboBox = new System.Windows.Forms.ComboBox();
            this.servicesGroupBox = new System.Windows.Forms.GroupBox();
            this.serviceListBox = new System.Windows.Forms.ListBox();
            this.chargedItemsGroupBox = new System.Windows.Forms.GroupBox();
            this.chargedItemsListBox = new System.Windows.Forms.ListBox();
            this.priceGroupBox = new System.Windows.Forms.GroupBox();
            this.priceListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.totalPriceTextBox = new System.Windows.Forms.TextBox();
            this.addServiceButton = new System.Windows.Forms.Button();
            this.totalPriceButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.hairdresserGroupBox.SuspendLayout();
            this.servicesGroupBox.SuspendLayout();
            this.chargedItemsGroupBox.SuspendLayout();
            this.priceGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // hairdresserGroupBox
            // 
            this.hairdresserGroupBox.Controls.Add(this.hairdresserComboBox);
            this.hairdresserGroupBox.Location = new System.Drawing.Point(13, 22);
            this.hairdresserGroupBox.Name = "hairdresserGroupBox";
            this.hairdresserGroupBox.Size = new System.Drawing.Size(249, 296);
            this.hairdresserGroupBox.TabIndex = 0;
            this.hairdresserGroupBox.TabStop = false;
            this.hairdresserGroupBox.Text = "Select a Hairdresser:";
            // 
            // hairdresserComboBox
            // 
            this.hairdresserComboBox.FormattingEnabled = true;
            this.hairdresserComboBox.Items.AddRange(new object[] {
            "Jane",
            "Pat",
            "Ron",
            "Sue",
            "Laurie"});
            this.hairdresserComboBox.Location = new System.Drawing.Point(19, 40);
            this.hairdresserComboBox.Name = "hairdresserComboBox";
            this.hairdresserComboBox.Size = new System.Drawing.Size(194, 24);
            this.hairdresserComboBox.TabIndex = 0;
            this.hairdresserComboBox.Text = "Jane";
            this.hairdresserComboBox.SelectedIndexChanged += new System.EventHandler(this.HairdresserComboBox_SelectedIndexChanged);
            // 
            // servicesGroupBox
            // 
            this.servicesGroupBox.Controls.Add(this.serviceListBox);
            this.servicesGroupBox.Location = new System.Drawing.Point(274, 22);
            this.servicesGroupBox.Name = "servicesGroupBox";
            this.servicesGroupBox.Size = new System.Drawing.Size(249, 296);
            this.servicesGroupBox.TabIndex = 1;
            this.servicesGroupBox.TabStop = false;
            this.servicesGroupBox.Text = "Select a Service:";
            // 
            // serviceListBox
            // 
            this.serviceListBox.Enabled = false;
            this.serviceListBox.FormattingEnabled = true;
            this.serviceListBox.ItemHeight = 16;
            this.serviceListBox.Items.AddRange(new object[] {
            "Cut",
            "Wash, blow-dry, and style",
            "Colour",
            "Highlights",
            "Extension",
            "Up-do"});
            this.serviceListBox.Location = new System.Drawing.Point(31, 40);
            this.serviceListBox.Name = "serviceListBox";
            this.serviceListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.serviceListBox.Size = new System.Drawing.Size(180, 180);
            this.serviceListBox.TabIndex = 0;
            // 
            // chargedItemsGroupBox
            // 
            this.chargedItemsGroupBox.Controls.Add(this.chargedItemsListBox);
            this.chargedItemsGroupBox.Location = new System.Drawing.Point(540, 22);
            this.chargedItemsGroupBox.Name = "chargedItemsGroupBox";
            this.chargedItemsGroupBox.Size = new System.Drawing.Size(249, 296);
            this.chargedItemsGroupBox.TabIndex = 1;
            this.chargedItemsGroupBox.TabStop = false;
            this.chargedItemsGroupBox.Text = "Charged Items:";
            // 
            // chargedItemsListBox
            // 
            this.chargedItemsListBox.Enabled = false;
            this.chargedItemsListBox.FormattingEnabled = true;
            this.chargedItemsListBox.ItemHeight = 16;
            this.chargedItemsListBox.Location = new System.Drawing.Point(28, 40);
            this.chargedItemsListBox.Name = "chargedItemsListBox";
            this.chargedItemsListBox.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.chargedItemsListBox.Size = new System.Drawing.Size(180, 180);
            this.chargedItemsListBox.TabIndex = 1;
            // 
            // priceGroupBox
            // 
            this.priceGroupBox.Controls.Add(this.priceListBox);
            this.priceGroupBox.Location = new System.Drawing.Point(804, 22);
            this.priceGroupBox.Name = "priceGroupBox";
            this.priceGroupBox.Size = new System.Drawing.Size(249, 296);
            this.priceGroupBox.TabIndex = 1;
            this.priceGroupBox.TabStop = false;
            this.priceGroupBox.Text = "Price:";
            // 
            // priceListBox
            // 
            this.priceListBox.Enabled = false;
            this.priceListBox.FormattingEnabled = true;
            this.priceListBox.ItemHeight = 16;
            this.priceListBox.Location = new System.Drawing.Point(33, 40);
            this.priceListBox.Name = "priceListBox";
            this.priceListBox.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.priceListBox.Size = new System.Drawing.Size(180, 180);
            this.priceListBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(704, 325);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Total Price:";
            // 
            // totalPriceTextBox
            // 
            this.totalPriceTextBox.Enabled = false;
            this.totalPriceTextBox.Location = new System.Drawing.Point(817, 325);
            this.totalPriceTextBox.Name = "totalPriceTextBox";
            this.totalPriceTextBox.ReadOnly = true;
            this.totalPriceTextBox.Size = new System.Drawing.Size(146, 22);
            this.totalPriceTextBox.TabIndex = 3;
            // 
            // addServiceButton
            // 
            this.addServiceButton.Location = new System.Drawing.Point(305, 365);
            this.addServiceButton.Name = "addServiceButton";
            this.addServiceButton.Size = new System.Drawing.Size(112, 30);
            this.addServiceButton.TabIndex = 4;
            this.addServiceButton.Text = "Add Service";
            this.addServiceButton.UseVisualStyleBackColor = true;
            this.addServiceButton.Click += new System.EventHandler(this.AddServiceButton_Click);
            // 
            // totalPriceButton
            // 
            this.totalPriceButton.Enabled = false;
            this.totalPriceButton.Location = new System.Drawing.Point(510, 365);
            this.totalPriceButton.Name = "totalPriceButton";
            this.totalPriceButton.Size = new System.Drawing.Size(112, 30);
            this.totalPriceButton.TabIndex = 5;
            this.totalPriceButton.Text = "Calculate Total Price";
            this.totalPriceButton.UseVisualStyleBackColor = true;
            this.totalPriceButton.Click += new System.EventHandler(this.TotalPriceButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(707, 365);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(112, 30);
            this.resetButton.TabIndex = 6;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(905, 365);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(112, 30);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 407);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.totalPriceButton);
            this.Controls.Add(this.addServiceButton);
            this.Controls.Add(this.totalPriceTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.servicesGroupBox);
            this.Controls.Add(this.chargedItemsGroupBox);
            this.Controls.Add(this.priceGroupBox);
            this.Controls.Add(this.hairdresserGroupBox);
            this.Name = "Form1";
            this.Text = "Perfect Cut Hair Salon";
            this.hairdresserGroupBox.ResumeLayout(false);
            this.servicesGroupBox.ResumeLayout(false);
            this.chargedItemsGroupBox.ResumeLayout(false);
            this.priceGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox hairdresserGroupBox;
        private System.Windows.Forms.ComboBox hairdresserComboBox;
        private System.Windows.Forms.GroupBox servicesGroupBox;
        private System.Windows.Forms.ListBox serviceListBox;
        private System.Windows.Forms.GroupBox chargedItemsGroupBox;
        private System.Windows.Forms.GroupBox priceGroupBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox totalPriceTextBox;
        private System.Windows.Forms.Button addServiceButton;
        private System.Windows.Forms.Button totalPriceButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.ListBox chargedItemsListBox;
        private System.Windows.Forms.ListBox priceListBox;
    }
}

