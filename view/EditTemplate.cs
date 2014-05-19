using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using coder.model;

namespace coder.view
{
    public partial class EditShortcut : EditVisit_Template
    {
        public EditShortcut()
        {
          InitializeComponent();
        }
   
        public EditShortcut(coder.model.Shortcut t)
        {
           InitializeComponent();

            if (namebox.DataBindings["Text"]!=null)
                namebox.DataBindings.Remove(namebox.DataBindings["Text"]);
            string str = t.Name;
          this.namebox.DataBindings.Add("Text",t,"Name");
        }

        private void EditTemplate_Load(object sender, EventArgs e)
        {

        }
       
    }
}
