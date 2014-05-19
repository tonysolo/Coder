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
    public partial class codeEdit : Form
    {
        //public string namebox { get; set; }
        public codeEdit()
        {
            InitializeComponent();
            string str = "test";
            char[] delim = new char[] { ' ', ',', ';' };
            string[] sarr = str.Split(delim, StringSplitOptions.RemoveEmptyEntries);
            
        }

        private void newICD_Load(object sender, EventArgs e)
        {

        }
    }
}
