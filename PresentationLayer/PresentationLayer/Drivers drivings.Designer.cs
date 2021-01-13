
namespace PresentationLayer
{
    partial class Drivers_drivings
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
            this.comboBoxDrivers = new System.Windows.Forms.ComboBox();
            this.labelId = new System.Windows.Forms.Label();
            this.listBoxDrivings = new System.Windows.Forms.ListBox();
            this.buttonShowDrivings = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxDrivers
            // 
            this.comboBoxDrivers.FormattingEnabled = true;
            this.comboBoxDrivers.Location = new System.Drawing.Point(210, 365);
            this.comboBoxDrivers.Name = "comboBoxDrivers";
            this.comboBoxDrivers.Size = new System.Drawing.Size(177, 21);
            this.comboBoxDrivers.TabIndex = 33;
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelId.Location = new System.Drawing.Point(84, 365);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(53, 17);
            this.labelId.TabIndex = 32;
            this.labelId.Text = "Drivers";
            // 
            // listBoxDrivings
            // 
            this.listBoxDrivings.FormattingEnabled = true;
            this.listBoxDrivings.Location = new System.Drawing.Point(47, 106);
            this.listBoxDrivings.Name = "listBoxDrivings";
            this.listBoxDrivings.Size = new System.Drawing.Size(378, 225);
            this.listBoxDrivings.TabIndex = 31;
            // 
            // buttonShowDrivings
            // 
            this.buttonShowDrivings.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonShowDrivings.Location = new System.Drawing.Point(127, 402);
            this.buttonShowDrivings.Name = "buttonShowDrivings";
            this.buttonShowDrivings.Size = new System.Drawing.Size(188, 33);
            this.buttonShowDrivings.TabIndex = 30;
            this.buttonShowDrivings.Text = "SHOW DRIVINGS";
            this.buttonShowDrivings.UseVisualStyleBackColor = true;
            this.buttonShowDrivings.Click += new System.EventHandler(this.buttonShowDrivings_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(121, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(202, 31);
            this.label3.TabIndex = 29;
            this.label3.Text = "Drivers drivings";
            // 
            // Drivers_drivings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 458);
            this.Controls.Add(this.comboBoxDrivers);
            this.Controls.Add(this.labelId);
            this.Controls.Add(this.listBoxDrivings);
            this.Controls.Add(this.buttonShowDrivings);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Drivers_drivings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Drivers drivings";
            this.Load += new System.EventHandler(this.Drivers_drivings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxDrivers;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.ListBox listBoxDrivings;
        private System.Windows.Forms.Button buttonShowDrivings;
        private System.Windows.Forms.Label label3;
    }
}