using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Web;
using coder.model;
//using System.Xml;

namespace coder.view
{
public partial class RegionEdit : Form
{
public List<coder.model.cRegion> Regions { get; set; }

//---------------------------------------------------------------
public RegionEdit(List<coder.model.cRegion> r)
{
InitializeComponent();
Regions = r;
UpdateRegionList();
}
//---------------------------------------------------------------

public RegionEdit(List<coder.model.cRegion> r, int ndx)
{
InitializeComponent();
Regions = r;
}
//---------------------------------------------------------------

private void UpdateRegionList()
{
if (Regions.Count>0)
{
listView1.Items.Clear();

string[][] sarr = new string[Regions.Count][];
for (int i = 0; i < Regions.Count; i++)
{
    sarr[i] = new string[3];
    coder.model.cRegion cd = Regions[i];

    sarr[i][0] = cd.PlaceName;
    sarr[i][1] = cd.Coordinates;
    sarr[i][2] = cd.HexValue;
    
    listView1.Items.Add(new ListViewItem(sarr[i]));
}
}
}
//---------------------------------------------------------------
// private string googlestaticmap(string coords)
//{
    //HexRegion hr = new HexRegion(coords);
    
   // StringBuilder path = new StringBuilder(new HexRegion(coords));
    // path.Insert(0,"&path=color:0x00000000|weight:5|fillcolor:0xFFFF0033|");
    // path.Replace("|","%7C");
    // string Path = path.ToString();
       // = String.Format("path=color:0x00000000|weight:5|fillcolor:0xFFFF0033|{0}|{1}|{2}|{3}",border[0],border[1],border[2],border[3]);

   //  string Coord = coord;
     //&key=AIzaSyByqWtU4oXxdDKpkX0p6GrAFhbSojZJ_KQ
// string str = String.Format("http://maps.googleapis.com/maps/api/staticmap?center={0}&zoom=14&size=400x400&key=AIzaSyByqWtU4oXxdDKpkX0p6GrAFhbSojZJ_KQ&sensor=false",coords); 
     
     
 //"http://maps.googleapis.com/maps/api/staticmap?center=Brooklyn+Bridge,New+York,NY&zoom=13&size=400x400&maptype=roadmap&markers=color:blue%7Clabel:S%7C40.702147,-74.015794&markers=color:green%7Clabel:G%7C40.711614,-74.012318&markers=color:red%7Ccolor:red%7Clabel:C%7C40.718217,-73.998284&sensor=false;";
//"http://maps.googleapis.com/maps/api/staticmap?center=40.714728,-73.998672&zoom=12&size=400x400&sensor=false;";
// return str;
 //}
//---------------------------------------------------------------
private void listBox_SelectedIndexChanged(object sender, EventArgs e)
{
//int i = listBox.SelectedIndex;
//get bounding region
//if bounding region changed then reload picturebox

//pictureBox1.Load(Google static maps api url for this place);          
//pictureBox1.Load(googlestaticmap(coords));
//namebox.Text = Regions[i].Name;
//coordbox.Text = Regions[i].DetailName();

}
//---------------------------------------------------------------
private void editButton_Click(object sender, EventArgs e)
{
// namebox.ReadOnly = false;
// coordbox.ReadOnly = false;

if (sender == (object)editButton)
{

//  namebox.Focus();
}
else // newbutton
{
//  namebox.Clear();
// coordbox.Clear();
// namebox.Focus();
}
}
//---------------------------------------------------------------
private void RegionEdit_Load(object sender, EventArgs e)
{

}
//---------------------------------------------------------------
private void addButton_Click(object sender, EventArgs e)
{

//           string nyc = @"http://maps.googleapis.com/maps/api/staticmap?center=Brooklyn+Bridge,New+York,NY&zoom=13&size=600x300&maptype=roadmap
//&markers=color:blue%7Clabel:S%7C40.702147,-74.015794&markers=color:green%7Clabel:G%7C40.711614,-74.012318
//&markers=color:red%7Ccolor:red%7Clabel:C%7C40.718217,-73.998284&sensor=false;";


coder.model.cRegion gr = new coder.model.cRegion();//"Sandton,-26.05,28.07");
CoordLookup cl = new CoordLookup(gr);

if (cl.ShowDialog() == DialogResult.OK)
{
//gr.HexValue
if (gr.Coordinates!=null)          // change this to check for valid address
{
Regions.Add(gr);
UpdateRegionList();
}
}
}

//-------------------------------------------------------------------------

private void listView1_SelectedIndexChanged(object sender, EventArgs e)
{
    if (listView1.SelectedIndices.Count > 0)
    {
        int ndx = listView1.SelectedIndices[0];

        //string cds = (Regions[ndx].Coordinates!=null)? Regions[1].Coordinates: "" ;
        string cds = Regions[ndx].Coordinates;
        //string bnd = Regions[ndx].
        // string border = new cRegion(cds).Border;
        this.richTextBox1.Text = GoogleUtils.GoogleStaticMapURL(cds, null);// googlestaticmap(cds);

        pictureBox1.Load(GoogleUtils.GoogleStaticMapURL(cds, null));

    } 
}

//---------------------------------------------------------------
}
}


                
   
        
    

