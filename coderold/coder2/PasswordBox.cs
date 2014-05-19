using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace coder.view
{
    public partial class PasswordBox : Form
    {
        public PasswordBox()
        {
            InitializeComponent();                  
        }

        private void button1_Click(object sender, EventArgs e)
        {
    DialogResult = ((textBox1.Text == "tony@turbomed.co.za") &&
              (textBox2.Text == "tony123")) ?
         DialogResult.OK : DialogResult.Cancel;
          
        }
    }
}
