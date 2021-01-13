
namespace PresentationLayer
{
    partial class New_driver
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
            this.buttonAddDriver = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelSurname = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxPhoneNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxDispatchers = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.labelPhoneNumberRegex = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonAddDriver
            // 
            this.buttonAddDriver.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddDriver.Location = new System.Drawing.Point(128, 327);
            this.buttonAddDriver.Name = "buttonAddDriver";
            this.buttonAddDriver.Size = new System.Drawing.Size(209, 33);
            this.buttonAddDriver.TabIndex = 11;
            this.buttonAddDriver.Text = "Add driver";
            this.buttonAddDriver.UseVisualStyleBackColor = true;
            this.buttonAddDriver.Click += new System.EventHandler(this.buttonAddDriver_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(122, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 31);
            this.label3.TabIndex = 10;
            this.label3.Text = "New driver";
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Location = new System.Drawing.Point(196, 221);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(190, 20);
            this.textBoxSurname.TabIndex = 9;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(196, 170);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(190, 20);
            this.textBoxName.TabIndex = 8;
            // 
            // labelSurname
            // 
            this.labelSurname.AutoSize = true;
            this.labelSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSurname.Location = new System.Drawing.Point(45, 221);
            this.labelSurname.Name = "labelSurname";
            this.labelSurname.Size = new System.Drawing.Size(74, 17);
            this.labelSurname.TabIndex = 7;
            this.labelSurname.Text = "Surname *";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(45, 170);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(54, 17);
            this.labelName.TabIndex = 6;
            this.labelName.Text = "Name *";
            // 
            // textBoxPhoneNumber
            // 
            this.textBoxPhoneNumber.Location = new System.Drawing.Point(196, 269);
            this.textBoxPhoneNumber.Name = "textBoxPhoneNumber";
            this.textBoxPhoneNumber.Size = new System.Drawing.Size(190, 20);
            this.textBoxPhoneNumber.TabIndex = 13;
            this.textBoxPhoneNumber.TextChanged += new System.EventHandler(this.textBoxPhoneNumber_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 269);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Phone number *";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(45, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Dispatcher *";
            // 
            // comboBoxDispatchers
            // 
            this.comboBoxDispatchers.FormattingEnabled = true;
            this.comboBoxDispatchers.Location = new System.Drawing.Point(148, 118);
            this.comboBoxDispatchers.Name = "comboBoxDispatchers";
            this.comboBoxDispatchers.Size = new System.Drawing.Size(167, 21);
            this.comboBoxDispatchers.TabIndex = 15;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(333, 104);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 47);
            this.button1.TabIndex = 16;
            this.button1.Text = "Add dispatcher";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelPhoneNumberRegex
            // 
            this.labelPhoneNumberRegex.AutoSize = true;
            this.labelPhoneNumberRegex.ForeColor = System.Drawing.Color.Red;
            this.labelPhoneNumberRegex.Location = new System.Drawing.Point(185, 295);
            this.labelPhoneNumberRegex.Name = "labelPhoneNumberRegex";
            this.labelPhoneNumberRegex.Size = new System.Drawing.Size(0, 13);
            this.labelPhoneNumberRegex.TabIndex = 31;
            // 
            // New_driver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 394);
            this.Controls.Add(this.labelPhoneNumberRegex);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBoxDispatchers);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxPhoneNumber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonAddDriver);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxSurname);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelSurname);
            this.Controls.Add(this.labelName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "New_driver";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New driver";
            this.Load += new System.EventHandler(this.New_driver_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAddDriver;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelSurname;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxPhoneNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxDispatchers;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelPhoneNumberRegex;
    }
}