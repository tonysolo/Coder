using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace coder.view
{

public partial class CoordLookup : Form
{       
public string latit=null, longit=null;
//bool okstatus = false;

//----------------------------------------------------------------------

public CoordLookup(model.cRegion gr)
{
InitializeComponent();
this.nameBox.DataBindings.Add("Text", gr, "PlaceName");
this.coordBox.DataBindings.Add("Text", gr, "Coordinates",false,DataSourceUpdateMode.OnPropertyChanged);
}
//---------------------------------------------------------------------

private void addrBox_TextChanged(object sender, EventArgs e)
{
this.coordButton.Enabled = true;
}
//----------------------------------------------------------------------

private void coordButton_Click(object sender, EventArgs e)
{
coordBox.Text = model.GoogleUtils.GoogleLocationURL(addrBox.Text);

}
//--------------------------------------------------------------------------------
}
}
