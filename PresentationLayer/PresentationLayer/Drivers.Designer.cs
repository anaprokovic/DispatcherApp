
namespace PresentationLayer
{
    partial class Drivers
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
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonNewDriver = new System.Windows.Forms.Button();
            this.listBoxDrivers = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(394, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 39);
            this.label1.TabIndex = 11;
            this.label1.Text = "Drivers";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(736, 315);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(141, 69);
            this.button3.TabIndex = 10;
            this.button3.Text = "SHOW DRIVERS DRIVINGS";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(736, 193);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(141, 69);
            this.button4.TabIndex = 9;
            this.button4.Text = "UPDATE INFO ABOUT DRIVER";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(556, 315);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(141, 69);
            this.button2.TabIndex = 8;
            this.button2.Text = "DELETE DRIVER";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonNewDriver
            // 
            this.buttonNewDriver.Location = new System.Drawing.Point(556, 193);
            this.buttonNewDriver.Name = "buttonNewDriver";
            this.buttonNewDriver.Size = new System.Drawing.Size(141, 69);
            this.buttonNewDriver.TabIndex = 7;
            this.buttonNewDriver.Text = "NEW DRIVER";
            this.buttonNewDriver.UseVisualStyleBackColor = true;
            this.buttonNewDriver.Click += new System.EventHandler(this.buttonNewDriver_Click);
            // 
            // listBoxDrivers
            // 
            this.listBoxDrivers.FormattingEnabled = true;
            this.listBoxDrivers.Location = new System.Drawing.Point(52, 129);
            this.listBoxDrivers.Name = "listBoxDrivers";
            this.listBoxDrivers.Size = new System.Drawing.Size(457, 316);
            this.listBoxDrivers.TabIndex = 6;
            // 
            // Drivers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 482);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonNewDriver);
            this.Controls.Add(this.listBoxDrivers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Drivers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Drivers";
            this.Load += new System.EventHandler(this.Drivers_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttonNewDriver;
        private System.Windows.Forms.ListBox listBoxDrivers;
    }
}