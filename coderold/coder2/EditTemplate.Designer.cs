namespace coder.view
{
    partial class EditShortcut
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
            this.label9 = new System.Windows.Forms.Label();
            this.namebox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(185, 17);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Shortcut Name";
            // 
            // namebox
            // 
            this.namebox.Location = new System.Drawing.Point(269, 15);
            this.namebox.Name = "namebox";
            this.namebox.Size = new System.Drawing.Size(171, 20);
            this.namebox.TabIndex = 22;
            // 
            // EditTemplate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 472);
            this.Controls.Add(this.namebox);
            this.Controls.Add(this.label9);
            this.Name = "EditTemplate";
            this.Text = "EditTemplate";
            this.Load += new System.EventHandler(this.EditTemplate_Load);
            this.Controls.SetChildIndex(this.label9, 0);
            this.Controls.SetChildIndex(this.namebox, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox namebox;
        // private System.Windows.Forms.TextBox name;
    }
}