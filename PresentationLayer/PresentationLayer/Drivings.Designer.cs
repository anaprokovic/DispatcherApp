
namespace PresentationLayer
{
    partial class Drivings
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
            this.buttonUpdateDriving = new System.Windows.Forms.Button();
            this.buttonDeleteDriving = new System.Windows.Forms.Button();
            this.buttonNewDriving = new System.Windows.Forms.Button();
            this.listBoxDrivings = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(378, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 39);
            this.label1.TabIndex = 17;
            this.label1.Text = "Drivings";
            // 
            // buttonUpdateDriving
            // 
            this.buttonUpdateDriving.Location = new System.Drawing.Point(720, 186);
            this.buttonUpdateDriving.Name = "buttonUpdateDriving";
            this.buttonUpdateDriving.Size = new System.Drawing.Size(141, 69);
            this.buttonUpdateDriving.TabIndex = 15;
            this.buttonUpdateDriving.Text = "UPDATE INFO ABOUT DRIVING";
            this.buttonUpdateDriving.UseVisualStyleBackColor = true;
            this.buttonUpdateDriving.Click += new System.EventHandler(this.buttonUpdateDriving_Click);
            // 
            // buttonDeleteDriving
            // 
            this.buttonDeleteDriving.Location = new System.Drawing.Point(540, 308);
            this.buttonDeleteDriving.Name = "buttonDeleteDriving";
            this.buttonDeleteDriving.Size = new System.Drawing.Size(321, 47);
            this.buttonDeleteDriving.TabIndex = 14;
            this.buttonDeleteDriving.Text = "DELETE DRIVING";
            this.buttonDeleteDriving.UseVisualStyleBackColor = true;
            this.buttonDeleteDriving.Click += new System.EventHandler(this.buttonDeleteDriving_Click);
            // 
            // buttonNewDriving
            // 
            this.buttonNewDriving.Location = new System.Drawing.Point(540, 186);
            this.buttonNewDriving.Name = "buttonNewDriving";
            this.buttonNewDriving.Size = new System.Drawing.Size(141, 69);
            this.buttonNewDriving.TabIndex = 13;
            this.buttonNewDriving.Text = "NEW DRIVING";
            this.buttonNewDriving.UseVisualStyleBackColor = true;
            this.buttonNewDriving.Click += new System.EventHandler(this.buttonNewDriving_Click);
            // 
            // listBoxDrivings
            // 
            this.listBoxDrivings.FormattingEnabled = true;
            this.listBoxDrivings.Location = new System.Drawing.Point(36, 122);
            this.listBoxDrivings.Name = "listBoxDrivings";
            this.listBoxDrivings.Size = new System.Drawing.Size(457, 316);
            this.listBoxDrivings.TabIndex = 12;
            // 
            // Drivings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 475);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonUpdateDriving);
            this.Controls.Add(this.buttonDeleteDriving);
            this.Controls.Add(this.buttonNewDriving);
            this.Controls.Add(this.listBoxDrivings);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Drivings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Drivings";
            this.Load += new System.EventHandler(this.Drivings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonUpdateDriving;
        private System.Windows.Forms.Button buttonDeleteDriving;
        private System.Windows.Forms.Button buttonNewDriving;
        private System.Windows.Forms.ListBox listBoxDrivings;
    }
}