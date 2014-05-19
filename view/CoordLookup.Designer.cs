namespace coder.view
{
    partial class CoordLookup
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
            this.coordButton = new System.Windows.Forms.Button();
            this.addrBox = new System.Windows.Forms.TextBox();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.coordBox = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // coordButton
            // 
            this.coordButton.Enabled = false;
            this.coordButton.Location = new System.Drawing.Point(44, 96);
            this.coordButton.Name = "coordButton";
            this.coordButton.Size = new System.Drawing.Size(76, 23);
            this.coordButton.TabIndex = 2;
            this.coordButton.Text = "Locate";
            this.toolTip1.SetToolTip(this.coordButton, "Finds the map coordinates");
            this.coordButton.UseVisualStyleBackColor = true;
            this.coordButton.Click += new System.EventHandler(this.coordButton_Click);
            // 
            // addrBox
            // 
            this.addrBox.Location = new System.Drawing.Point(44, 47);
            this.addrBox.Name = "addrBox";
            this.addrBox.Size = new System.Drawing.Size(284, 20);
            this.addrBox.TabIndex = 1;
            this.toolTip1.SetToolTip(this.addrBox, "Address or desription of plae to locate");
            this.addrBox.TextChanged += new System.EventHandler(this.addrBox_TextChanged);
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(133, 143);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(195, 20);
            this.nameBox.TabIndex = 3;
            this.toolTip1.SetToolTip(this.nameBox, "Short name to display");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Address or Place to locate";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Display Name";
            this.toolTip1.SetToolTip(this.label2, "Short name to display");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Brown;
            this.label3.Location = new System.Drawing.Point(41, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(212, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "e.g. Rivonia and Hill, Sandton, South Africa";
            // 
            // coordBox
            // 
            this.coordBox.Location = new System.Drawing.Point(133, 98);
            this.coordBox.Name = "coordBox";
            this.coordBox.ReadOnly = true;
            this.coordBox.Size = new System.Drawing.Size(195, 20);
            this.coordBox.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(252, 188);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Ok";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // CoordLookup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 223);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.coordBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.addrBox);
            this.Controls.Add(this.coordButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CoordLookup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Coordinate Lookup";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button coordButton;
        private System.Windows.Forms.TextBox addrBox;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox coordBox;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button button1;
    }
}