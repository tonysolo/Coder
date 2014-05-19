namespace coder.view
{
    partial class codeEdit
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
            this.savebutton = new System.Windows.Forms.Button();
            this.namebox = new System.Windows.Forms.TextBox();
            this.icdlabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.icds = new System.Windows.Forms.TextBox();
            this.tariffs = new System.Windows.Forms.TextBox();
            this.icdname = new System.Windows.Forms.TextBox();
            this.testbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.testlabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // savebutton
            // 
            this.savebutton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.savebutton.Location = new System.Drawing.Point(242, 238);
            this.savebutton.Name = "savebutton";
            this.savebutton.Size = new System.Drawing.Size(75, 23);
            this.savebutton.TabIndex = 5;
            this.savebutton.Text = "save";
            this.savebutton.UseVisualStyleBackColor = true;
            // 
            // namebox
            // 
            this.namebox.Location = new System.Drawing.Point(11, 26);
            this.namebox.Name = "namebox";
            this.namebox.Size = new System.Drawing.Size(123, 20);
            this.namebox.TabIndex = 1;
            // 
            // icdlabel
            // 
            this.icdlabel.AutoSize = true;
            this.icdlabel.Location = new System.Drawing.Point(44, 131);
            this.icdlabel.Name = "icdlabel";
            this.icdlabel.Size = new System.Drawing.Size(75, 13);
            this.icdlabel.TabIndex = 0;
            this.icdlabel.Text = "ICD10 code(s)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Procedure Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tariff codes (optional)";
            // 
            // icds
            // 
            this.icds.Location = new System.Drawing.Point(138, 128);
            this.icds.Name = "icds";
            this.icds.Size = new System.Drawing.Size(171, 20);
            this.icds.TabIndex = 2;
            // 
            // tariffs
            // 
            this.tariffs.Location = new System.Drawing.Point(138, 169);
            this.tariffs.Name = "tariffs";
            this.tariffs.Size = new System.Drawing.Size(171, 20);
            this.tariffs.TabIndex = 3;
            // 
            // icdname
            // 
            this.icdname.Location = new System.Drawing.Point(138, 87);
            this.icdname.Name = "icdname";
            this.icdname.Size = new System.Drawing.Size(87, 20);
            this.icdname.TabIndex = 1;
            // 
            // testbutton
            // 
            this.testbutton.Location = new System.Drawing.Point(13, 238);
            this.testbutton.Name = "testbutton";
            this.testbutton.Size = new System.Drawing.Size(52, 23);
            this.testbutton.TabIndex = 4;
            this.testbutton.Text = "test";
            this.testbutton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "( use a space or comma to separate multiple codes )";
            // 
            // testlabel
            // 
            this.testlabel.AutoSize = true;
            this.testlabel.Location = new System.Drawing.Point(23, 9);
            this.testlabel.Name = "testlabel";
            this.testlabel.Size = new System.Drawing.Size(109, 52);
            this.testlabel.TabIndex = 0;
            this.testlabel.Text = "Name :\r\nPrimary ICD code:\r\nAdditional ICD codes:\r\nTariffs codes";
            // 
            // codeEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 279);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.testlabel);
            this.Controls.Add(this.testbutton);
            this.Controls.Add(this.icdname);
            this.Controls.Add(this.tariffs);
            this.Controls.Add(this.icds);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.icdlabel);
            this.Controls.Add(this.savebutton);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "codeEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Code Planner";
            this.Load += new System.EventHandler(this.newICD_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

private System.Windows.Forms.Button savebutton;


private System.Windows.Forms.Label icdlabel;
private System.Windows.Forms.Label label2;

public System.Windows.Forms.TextBox namebox;
//public System.Windows.Forms.TextBox icd0;
//public System.Windows.Forms.TextBox icd1;

private System.Windows.Forms.Label label3;
public System.Windows.Forms.TextBox icds;
public System.Windows.Forms.TextBox tariffs;
public System.Windows.Forms.TextBox icdname;
private System.Windows.Forms.Button testbutton;
private System.Windows.Forms.Label label1;
private System.Windows.Forms.Label testlabel;
    }
}