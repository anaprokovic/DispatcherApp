
namespace PresentationLayer
{
    partial class Update_driving_s_info
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
            this.listBoxDrivings = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.labelPercentage = new System.Windows.Forms.Label();
            this.textBoxDispatcherEarning = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBoxDrivers = new System.Windows.Forms.ComboBox();
            this.labelDriver = new System.Windows.Forms.Label();
            this.buttonUpdateDriving = new System.Windows.Forms.Button();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.textBoxMileage = new System.Windows.Forms.TextBox();
            this.labelPricePerKM = new System.Windows.Forms.Label();
            this.labelMileage = new System.Windows.Forms.Label();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.labelId = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBoxDrivings
            // 
            this.listBoxDrivings.FormattingEnabled = true;
            this.listBoxDrivings.Location = new System.Drawing.Point(40, 125);
            this.listBoxDrivings.Name = "listBoxDrivings";
            this.listBoxDrivings.Size = new System.Drawing.Size(378, 277);
            this.listBoxDrivings.TabIndex = 37;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(298, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(259, 31);
            this.label3.TabIndex = 35;
            this.label3.Text = "Update driving\'s info";
            // 
            // labelPercentage
            // 
            this.labelPercentage.AutoSize = true;
            this.labelPercentage.ForeColor = System.Drawing.Color.Red;
            this.labelPercentage.Location = new System.Drawing.Point(605, 317);
            this.labelPercentage.Name = "labelPercentage";
            this.labelPercentage.Size = new System.Drawing.Size(0, 13);
            this.labelPercentage.TabIndex = 48;
            // 
            // textBoxDispatcherEarning
            // 
            this.textBoxDispatcherEarning.Location = new System.Drawing.Point(653, 294);
            this.textBoxDispatcherEarning.Name = "textBoxDispatcherEarning";
            this.textBoxDispatcherEarning.Size = new System.Drawing.Size(190, 20);
            this.textBoxDispatcherEarning.TabIndex = 47;
            this.textBoxDispatcherEarning.TextChanged += new System.EventHandler(this.textBoxDispatcherEarning_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(476, 294);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 17);
            this.label1.TabIndex = 46;
            this.label1.Text = "Dispatcher\'s earning [%] *";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(778, 130);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(65, 47);
            this.button1.TabIndex = 45;
            this.button1.Text = "Add driver";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // comboBoxDrivers
            // 
            this.comboBoxDrivers.FormattingEnabled = true;
            this.comboBoxDrivers.Location = new System.Drawing.Point(559, 144);
            this.comboBoxDrivers.Name = "comboBoxDrivers";
            this.comboBoxDrivers.Size = new System.Drawing.Size(202, 21);
            this.comboBoxDrivers.TabIndex = 44;
            // 
            // labelDriver
            // 
            this.labelDriver.AutoSize = true;
            this.labelDriver.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDriver.Location = new System.Drawing.Point(476, 146);
            this.labelDriver.Name = "labelDriver";
            this.labelDriver.Size = new System.Drawing.Size(55, 17);
            this.labelDriver.TabIndex = 43;
            this.labelDriver.Text = "Driver *";
            // 
            // buttonUpdateDriving
            // 
            this.buttonUpdateDriving.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdateDriving.Location = new System.Drawing.Point(608, 350);
            this.buttonUpdateDriving.Name = "buttonUpdateDriving";
            this.buttonUpdateDriving.Size = new System.Drawing.Size(209, 33);
            this.buttonUpdateDriving.TabIndex = 42;
            this.buttonUpdateDriving.Text = "Update driving";
            this.buttonUpdateDriving.UseVisualStyleBackColor = true;
            this.buttonUpdateDriving.Click += new System.EventHandler(this.buttonAddDriver_Click);
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(653, 247);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(190, 20);
            this.textBoxPrice.TabIndex = 41;
            // 
            // textBoxMileage
            // 
            this.textBoxMileage.Location = new System.Drawing.Point(653, 196);
            this.textBoxMileage.Name = "textBoxMileage";
            this.textBoxMileage.Size = new System.Drawing.Size(190, 20);
            this.textBoxMileage.TabIndex = 40;
            // 
            // labelPricePerKM
            // 
            this.labelPricePerKM.AutoSize = true;
            this.labelPricePerKM.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPricePerKM.Location = new System.Drawing.Point(476, 247);
            this.labelPricePerKM.Name = "labelPricePerKM";
            this.labelPricePerKM.Size = new System.Drawing.Size(96, 17);
            this.labelPricePerKM.TabIndex = 39;
            this.labelPricePerKM.Text = "Price per km *";
            // 
            // labelMileage
            // 
            this.labelMileage.AutoSize = true;
            this.labelMileage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMileage.Location = new System.Drawing.Point(476, 196);
            this.labelMileage.Name = "labelMileage";
            this.labelMileage.Size = new System.Drawing.Size(66, 17);
            this.labelMileage.TabIndex = 38;
            this.labelMileage.Text = "Mileage *";
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(537, 358);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(55, 20);
            this.textBoxId.TabIndex = 50;
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelId.Location = new System.Drawing.Point(503, 358);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(28, 17);
            this.labelId.TabIndex = 49;
            this.labelId.Text = "Id *";
            // 
            // Update_driving_s_info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 433);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.labelId);
            this.Controls.Add(this.labelPercentage);
            this.Controls.Add(this.textBoxDispatcherEarning);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBoxDrivers);
            this.Controls.Add(this.labelDriver);
            this.Controls.Add(this.buttonUpdateDriving);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.textBoxMileage);
            this.Controls.Add(this.labelPricePerKM);
            this.Controls.Add(this.labelMileage);
            this.Controls.Add(this.listBoxDrivings);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Update_driving_s_info";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update driving\'s info";
            this.Load += new System.EventHandler(this.Update_driving_s_info_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox listBoxDrivings;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelPercentage;
        private System.Windows.Forms.TextBox textBoxDispatcherEarning;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBoxDrivers;
        private System.Windows.Forms.Label labelDriver;
        private System.Windows.Forms.Button buttonUpdateDriving;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.TextBox textBoxMileage;
        private System.Windows.Forms.Label labelPricePerKM;
        private System.Windows.Forms.Label labelMileage;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.Label labelId;
    }
}