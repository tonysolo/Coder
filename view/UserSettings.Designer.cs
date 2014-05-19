namespace coder.view
{
    partial class UserSettings
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
            this.instbox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.practypebox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.regionbox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lattitudebox = new System.Windows.Forms.TextBox();
            this.mpbox = new System.Windows.Forms.TextBox();
            this.namebox = new System.Windows.Forms.TextBox();
            this.closebutton = new System.Windows.Forms.Button();
            this.longitudebox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // instbox
            // 
            this.instbox.AllowDrop = true;
            this.instbox.FormattingEnabled = true;
            this.instbox.Location = new System.Drawing.Point(156, 125);
            this.instbox.Name = "instbox";
            this.instbox.Size = new System.Drawing.Size(121, 21);
            this.instbox.TabIndex = 4;
            this.toolTip1.SetToolTip(this.instbox, "Your Institution or\r\nyour type of work");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Institution Type";
            this.toolTip1.SetToolTip(this.label1, "Your Institution or\r\nyour type of work");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Practice Type";
            this.toolTip1.SetToolTip(this.label2, "Your Practice Type");
            // 
            // practypebox
            // 
            this.practypebox.AllowDrop = true;
            this.practypebox.FormattingEnabled = true;
            this.practypebox.Location = new System.Drawing.Point(156, 95);
            this.practypebox.Name = "practypebox";
            this.practypebox.Size = new System.Drawing.Size(121, 21);
            this.practypebox.TabIndex = 3;
            this.toolTip1.SetToolTip(this.practypebox, "Your Practice Type");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(102, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Location";
            this.toolTip1.SetToolTip(this.label3, "Your City or Region\r\n where you work");
            // 
            // regionbox
            // 
            this.regionbox.AllowDrop = true;
            this.regionbox.FormattingEnabled = true;
            this.regionbox.Location = new System.Drawing.Point(156, 157);
            this.regionbox.Name = "regionbox";
            this.regionbox.Size = new System.Drawing.Size(121, 21);
            this.regionbox.TabIndex = 5;
            this.toolTip1.SetToolTip(this.regionbox, "Your City or Region\r\n where you work");
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Coordinate Lattude N/-S";
            this.toolTip1.SetToolTip(this.label4, "Your Region/City GPS Coordinates:\r\nUse decimal degree format\r\nExample: Johannesbu" +
                    "rg\r\nLattitude =     -21.4\r\nLongitude =      23.5\r\n*Negative (-) for South and We" +
                    "st\r\n Positive for North and East\r\n");
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(115, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Name";
            this.toolTip1.SetToolTip(this.label5, "Your Name: \r\n(Optional)\r\nThis information \r\nwon\'t be shared.\r\n");
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(41, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Registration Number";
            this.toolTip1.SetToolTip(this.label6, "Your professional registration\r\nnumber (required)\r\n\r\n\r\n");
            // 
            // lattitudebox
            // 
            this.lattitudebox.Location = new System.Drawing.Point(156, 191);
            this.lattitudebox.Name = "lattitudebox";
            this.lattitudebox.ReadOnly = true;
            this.lattitudebox.Size = new System.Drawing.Size(121, 20);
            this.lattitudebox.TabIndex = 6;
            this.toolTip1.SetToolTip(this.lattitudebox, "Your Region/City GPS Coordinates:\r\nUse decimal degree format\r\nExample: Johannesbu" +
                    "rg\r\nLattitude =     -21.4\r\nLongitude =      23.5\r\n*Negative (-) for South and We" +
                    "st\r\n Positive for North and East");
            // 
            // mpbox
            // 
            this.mpbox.Location = new System.Drawing.Point(156, 66);
            this.mpbox.Name = "mpbox";
            this.mpbox.Size = new System.Drawing.Size(121, 20);
            this.mpbox.TabIndex = 1;
            this.toolTip1.SetToolTip(this.mpbox, "Your professional registration\r\nnumber (required)");
            // 
            // namebox
            // 
            this.namebox.Location = new System.Drawing.Point(156, 33);
            this.namebox.Name = "namebox";
            this.namebox.Size = new System.Drawing.Size(121, 20);
            this.namebox.TabIndex = 0;
            this.toolTip1.SetToolTip(this.namebox, "Your Name: \r\n(Optional)\r\nThis information \r\nwon\'t be shared.");
            // 
            // closebutton
            // 
            this.closebutton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.closebutton.Location = new System.Drawing.Point(109, 284);
            this.closebutton.Name = "closebutton";
            this.closebutton.Size = new System.Drawing.Size(75, 23);
            this.closebutton.TabIndex = 12;
            this.closebutton.Text = "OK";
            this.toolTip1.SetToolTip(this.closebutton, "Closes and Saves\r\nyour practice details");
            this.closebutton.UseVisualStyleBackColor = true;
            // 
            // longitudebox
            // 
            this.longitudebox.Location = new System.Drawing.Point(156, 220);
            this.longitudebox.Name = "longitudebox";
            this.longitudebox.ReadOnly = true;
            this.longitudebox.Size = new System.Drawing.Size(121, 20);
            this.longitudebox.TabIndex = 7;
            this.toolTip1.SetToolTip(this.longitudebox, "Your Region/City GPS Coordinates:\r\nUse decimal degree format\r\nExample: Johannesbu" +
                    "rg\r\nLattitude =     -21.4\r\nLongitude =      23.5\r\n*Negative (-) for South and We" +
                    "st\r\n Positive for North and East");
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 220);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Coordinate Longitude E/-W\r\n";
            this.toolTip1.SetToolTip(this.label7, "Your Region/City GPS Coordinates:\r\nUse decimal degree format\r\nExample: Johannesbu" +
                    "rg\r\nLattitude =     -21.4\r\nLongitude =      23.5\r\n*Negative (-) for South and We" +
                    "st\r\n Positive for North and East");
            // 
            // UserSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 335);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.longitudebox);
            this.Controls.Add(this.closebutton);
            this.Controls.Add(this.namebox);
            this.Controls.Add(this.mpbox);
            this.Controls.Add(this.lattitudebox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.regionbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.practypebox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.instbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UserSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Owner Settings";
            this.Load += new System.EventHandler(this.UserSettings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox instbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox practypebox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox regionbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox lattitudebox;
        private System.Windows.Forms.TextBox mpbox;
        private System.Windows.Forms.TextBox namebox;
        private System.Windows.Forms.Button closebutton;
        private System.Windows.Forms.TextBox longitudebox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}