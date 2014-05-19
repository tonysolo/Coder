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
    public partial class RegionEdit : Form
    {
        public RegionEdit() { }
        public RegionEdit(coder.model.Coordinate coord)
        {
            InitializeComponent();
            this.namebox.Text = coord.Name;
            this.coordbox.Text = coord.ToString();
        }
    }
}
