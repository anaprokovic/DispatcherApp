
namespace PresentationLayer
{
    partial class New_driving
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
            this.button1 = new System.Windows.Forms.Button();
            this.comboBoxDrivers = new System.Windows.Forms.ComboBox();
            this.labelDriver = new System.Windows.Forms.Label();
            this.buttonAddDriver = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.textBoxMileage = new System.Windows.Forms.TextBox();
            this.labelPricePerKM = new System.Windows.Forms.Label();
            this.labelMileage = new System.Windows.Forms.Label();
            this.textBoxDispatcherEarning = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelPercentage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(343, 105);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(65, 47);
            this.button1.TabIndex = 27;
            this.button1.Text = "Add driver";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBoxDrivers
            // 
            this.comboBoxDrivers.FormattingEnabled = true;
            this.comboBoxDrivers.Location = new System.Drawing.Point(124, 119);
            this.comboBoxDrivers.Name = "comboBoxDrivers";
            this.comboBoxDrivers.Size = new System.Drawing.Size(202, 21);
            this.comboBoxDrivers.TabIndex = 26;
            // 
            // labelDriver
            // 
            this.labelDriver.AutoSize = true;
            this.labelDriver.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDriver.Location = new System.Drawing.Point(41, 121);
            this.labelDriver.Name = "labelDriver";
            this.labelDriver.Size = new System.Drawing.Size(55, 17);
            this.labelDriver.TabIndex = 25;
            this.labelDriver.Text = "Driver *";
            // 
            // buttonAddDriver
            // 
            this.buttonAddDriver.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddDriver.Location = new System.Drawing.Point(117, 320);
            this.buttonAddDriver.Name = "buttonAddDriver";
            this.buttonAddDriver.Size = new System.Drawing.Size(209, 33);
            this.buttonAddDriver.TabIndex = 22;
            this.buttonAddDriver.Text = "Add driving";
            this.buttonAddDriver.UseVisualStyleBackColor = true;
            this.buttonAddDriver.Click += new System.EventHandler(this.buttonAddDriver_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(118, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 31);
            this.label3.TabIndex = 21;
            this.label3.Text = "New driving";
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(218, 222);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(190, 20);
            this.textBoxPrice.TabIndex = 20;
            // 
            // textBoxMileage
            // 
            this.textBoxMileage.Location = new System.Drawing.Point(218, 171);
            this.textBoxMileage.Name = "textBoxMileage";
            this.textBoxMileage.Size = new System.Drawing.Size(190, 20);
            this.textBoxMileage.TabIndex = 19;
            // 
            // labelPricePerKM
            // 
            this.labelPricePerKM.AutoSize = true;
            this.labelPricePerKM.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPricePerKM.Location = new System.Drawing.Point(41, 222);
            this.labelPricePerKM.Name = "labelPricePerKM";
            this.labelPricePerKM.Size = new System.Drawing.Size(96, 17);
            this.labelPricePerKM.TabIndex = 18;
            this.labelPricePerKM.Text = "Price per km *";
            // 
            // labelMileage
            // 
            this.labelMileage.AutoSize = true;
            this.labelMileage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMileage.Location = new System.Drawing.Point(41, 171);
            this.labelMileage.Name = "labelMileage";
            this.labelMileage.Size = new System.Drawing.Size(66, 17);
            this.labelMileage.TabIndex = 17;
            this.labelMileage.Text = "Mileage *";
            // 
            // textBoxDispatcherEarning
            // 
            this.textBoxDispatcherEarning.Location = new System.Drawing.Point(218, 269);
            this.textBoxDispatcherEarning.Name = "textBoxDispatcherEarning";
            this.textBoxDispatcherEarning.Size = new System.Drawing.Size(190, 20);
            this.textBoxDispatcherEarning.TabIndex = 29;
            this.textBoxDispatcherEarning.TextChanged += new System.EventHandler(this.textBoxDispatcherEarning_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 269);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 17);
            this.label1.TabIndex = 28;
            this.label1.Text = "Dispatcher\'s earning [%] *";
            // 
            // labelPercentage
            // 
            this.labelPercentage.AutoSize = true;
            this.labelPercentage.ForeColor = System.Drawing.Color.Red;
            this.labelPercentage.Location = new System.Drawing.Point(170, 292);
            this.labelPercentage.Name = "labelPercentage";
            this.labelPercentage.Size = new System.Drawing.Size(0, 13);
            this.labelPercentage.TabIndex = 30;
            // 
            // New_driving
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 380);
            this.Controls.Add(this.labelPercentage);
            this.Controls.Add(this.textBoxDispatcherEarning);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBoxDrivers);
            this.Controls.Add(this.labelDriver);
            this.Controls.Add(this.buttonAddDriver);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.textBoxMileage);
            this.Controls.Add(this.labelPricePerKM);
            this.Controls.Add(this.labelMileage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "New_driving";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New driving";
            this.Load += new System.EventHandler(this.New_driving_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBoxDrivers;
        private System.Windows.Forms.Label labelDriver;
        private System.Windows.Forms.Button buttonAddDriver;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.TextBox textBoxMileage;
        private System.Windows.Forms.Label labelPricePerKM;
        private System.Windows.Forms.Label labelMileage;
        private System.Windows.Forms.TextBox textBoxDispatcherEarning;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelPercentage;
    }
}