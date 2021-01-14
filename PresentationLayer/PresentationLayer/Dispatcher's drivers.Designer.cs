
namespace PresentationLayer
{
    partial class Dispatcher_s_drivings
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
            this.labelId = new System.Windows.Forms.Label();
            this.listBoxDispatchers = new System.Windows.Forms.ListBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxDispatchers = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelId.Location = new System.Drawing.Point(75, 380);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(76, 17);
            this.labelId.TabIndex = 27;
            this.labelId.Text = "Dispatcher";
            // 
            // listBoxDispatchers
            // 
            this.listBoxDispatchers.FormattingEnabled = true;
            this.listBoxDispatchers.Location = new System.Drawing.Point(38, 121);
            this.listBoxDispatchers.Name = "listBoxDispatchers";
            this.listBoxDispatchers.Size = new System.Drawing.Size(378, 225);
            this.listBoxDispatchers.TabIndex = 26;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.Location = new System.Drawing.Point(118, 417);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(188, 33);
            this.buttonDelete.TabIndex = 25;
            this.buttonDelete.Text = "SHOW DRIVERS";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(112, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(226, 31);
            this.label3.TabIndex = 24;
            this.label3.Text = "Delete dispatcher";
            // 
            // comboBoxDispatchers
            // 
            this.comboBoxDispatchers.FormattingEnabled = true;
            this.comboBoxDispatchers.Location = new System.Drawing.Point(201, 380);
            this.comboBoxDispatchers.Name = "comboBoxDispatchers";
            this.comboBoxDispatchers.Size = new System.Drawing.Size(177, 21);
            this.comboBoxDispatchers.TabIndex = 28;
            // 
            // Dispatcher_s_drivings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 471);
            this.Controls.Add(this.comboBoxDispatchers);
            this.Controls.Add(this.labelId);
            this.Controls.Add(this.listBoxDispatchers);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Dispatcher_s_drivings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dispatcher_s_drivings";
            this.Load += new System.EventHandler(this.Dispatcher_s_drivings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.ListBox listBoxDispatchers;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxDispatchers;
    }
}