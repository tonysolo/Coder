using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using coder.controller;
using System.IO;
using System.Net;


namespace coder
{
//------------------------------------------------
public partial class Shell : Form
{
public ShellConroller Controller {get;set;}
public model.cvisit EditVisit;
static int editvisitindex = 0; 
private static bool _editmode;
//------------------------------------------------
public bool EditMode
{
get { return _editmode; }
set {if (_editmode == value) return; //nothing changed

if (_editmode == true){} //? there is a edited visit so save the editing  
setEditMode(value); 
}
}
//---------------------------------------------------------    
void setEditMode(bool b)
{ if (b == false)
{
System.Type t;
for (int i = 0; i < flowLayoutPanel1.Controls.Count; i++)
{
t = flowLayoutPanel1.Controls[i].GetType();
if (! t.Equals(typeof(Button))) 
flowLayoutPanel1.Controls[i].Enabled = false;
_editmode = false;
}
}
else { for (int i = 0; i < flowLayoutPanel1.Controls.Count; i++) 
flowLayoutPanel1.Controls[i].Enabled = true;

_editmode = true;
}
}
//---------------------------------------------------------------
public Shell()
{
InitializeComponent();
Controller = new ShellConroller();
//EditMode = false;
setEditMode(false);
SetDropdownLists();
ResetView();
}
//------------------------------------------------------------------
void SetDisplayBindings(model.cvisit v)
{
    if (v == null) return;
model.Patient patient = v.Bitdata.epirec.patient;
model.Treater treater = v.Bitdata.epirec.treater;
//model.provider referrer = v.Bitdata.referer;
datepickerBox.DataBindings.Clear();
nameBox.DataBindings.Clear();
treatBox.DataBindings.Clear();
treatSpecBox.DataBindings.Clear();
treatfacilityBox.DataBindings.Clear();
treatfundBox.DataBindings.Clear();
Visits_Days.DataBindings.Clear();
//referBox.DataBindings.Clear();
//referSpecBox.DataBindings.Clear();
//referfacilityBox.DataBindings.Clear();
//referfundBox.DataBindings.Clear();
ageBox.DataBindings.Clear();
genderBox.DataBindings.Clear();
outpatBox.DataBindings.Clear();
raceBox.DataBindings.Clear();
icdBox.DataBindings.Clear();
patientRegionBox.DataBindings.Clear();
treatRegionBox.DataBindings.Clear();
//tariffBox.DataBindings.Clear();
//datepickerBox.Value.Date.
//v.Date.dateTime
//datepickerBox.DataBindings.Add("Value",v.Bitdata.date,"Date.dateTime.");
nameBox.DataBindings.Add("Text",v,"Name");
treatBox.DataBindings.Add("SelectedIndex",v.Bitdata.epirec.treater,"qualif");
treatSpecBox.DataBindings.Add("SelectedIndex", v.Bitdata.epirec.treater, "spec_int");
treatfacilityBox.DataBindings.Add("SelectedIndex",v.Bitdata.epirec.treater_clinic,"type");
treatfundBox.DataBindings.Add("SelectedIndex",v.Bitdata.epirec.treater_clinic,"pvt");
Visits_Days.DataBindings.Add("Value", v.Bitdata.epirec.treater_clinic,"count");
//patientRegionBox.DataBindings.Add("Value",v.Bitdata,"PatientRegion");
//treatRegionBox.DataBindings.Add("Text",v.Bitdata,"TreatRegion");
//referBox.DataBindings.Add("SelectedIndex", v.Bitdata.referer, "qualif");
//referSpecBox.DataBindings.Add("SelectedIndex", v.Bitdata.referer, "spec_int");
//referfacilityBox.DataBindings.Add("SelectedIndex",v.Bitdata.referer_clinic,"type");
//referfundBox.DataBindings.Add("SelectedIndex",v.Bitdata.referer_clinic,"pvt");
ageBox.DataBindings.Add("SelectedIndex", v.Bitdata.epirec.patient, "age_group");
genderBox.DataBindings.Add("SelectedIndex", v.Bitdata.epirec.patient, "male");
outpatBox.DataBindings.Add("SelectedIndex", v.Bitdata.epirec.patient, "out_patient");
raceBox.DataBindings.Add("SelectedIndex", v.Bitdata.epirec.patient,"race");
icdBox.DataBindings.Add("Text",v,"ICDs");
//patientRegionBox.DataBindings.Add("Text",v,"TreatPlaceName");
//label5.DataBindings.Add("Text", v.Bitdata.patient, "out_patient");
//tariffBox.DataBindings.Add("Text",v,"Tariffs");
}

//-----------------------------------------------------------------

private void SetDropdownLists()
{
treatBox.DataSource = Enum.GetNames(typeof(model.qualif));
//referBox.DataSource = Enum.GetNames(typeof(model.qualif));
treatSpecBox.DataSource = Enum.GetNames(typeof(model.special_interest));
//referSpecBox.DataSource = Enum.GetNames(typeof(model.special_interest));
treatfacilityBox.DataSource = Enum.GetNames(typeof(model.clinic));
//referfacilityBox.DataSource = Enum.GetNames(typeof(model.clinic));
treatfundBox.DataSource = Enum.GetNames(typeof(model.priv_pub));
//referfundBox.DataSource = Enum.GetNames(typeof(model.priv_pub));
this.ageBox.DataSource = Enum.GetNames(typeof(model.age_group));
this.genderBox.DataSource = Enum.GetNames(typeof(model.gender));
this.raceBox.DataSource = Enum.GetNames(typeof(model.race));   
this.outpatBox.DataSource=Enum.GetNames(typeof(model.out_in_pat));
}
//--------------------------------------------------------------------
private void ResetView()
{ 
ResetList();
}
//-------------------------------------------------------------------
//Resets and Updates the ListView when the mode changes
private void ResetList()
{
toolStripStatusLabel1.Text = "Sync of several items required";
listView.Columns.Clear();
listView.Columns.Add("ICD's",80);
//listView.Columns.Add("#",20);
//listView.Columns.Add("Name",100);
}
//-------------------------------------------------------------------
private void UpdateList() 
{
    listView.Items.Clear();
string[][] str = Controller.ListItems;
if (str == null) return;


for (int i = 0;i<str.Length;i++)
{
string[] s = str[i];    
ListViewItem lvi = new ListViewItem(s);
listView.Items.Add(lvi);
}
}
//--------------------------------------------------------------------
private void listView_SelectedIndexChanged(object sender, EventArgs e)
{  
  if (listView.SelectedIndices.Count > 0)
    {
      Controller.SelectedVisitIndex = listView.SelectedIndices[0];
      SetDisplayBindings(Controller.DisplayVisit);
        flowLayoutPanel1.Focus();
    }  
}
//-------------------------------------------------------------------------

private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e){}
//------------------------------------------------------------------------------------


private void label5_Click(object sender, EventArgs e)
{
Controller.EditRegion(); 
UpdateList();
}


//---------------------------------------------------------------------------
private void cloneButton_Click(object sender, EventArgs e)
{
//Controller.DisplayVisit = listView.te    
EditMode = false;
if (Controller.SelectedVisitIndex > -1 )
{
    if (Controller.Visits[Controller.SelectedVisitIndex]==null) return;
    Controller.Visits.Add((model.cvisit)Controller.Visits[Controller.SelectedVisitIndex].Clone());  
}
else
{
    model.cvisit v = new model.cvisit(); 
    Controller.Visits.Add(v);
    
}
Controller.SelectedVisitIndex = Controller.Visits.Count - 1;
UpdateList();
listView.EnsureVisible(listView.Items.Count - 1);
}
//----------------------------------------------------------------------------------------


private void Shell_Load(object sender, EventArgs e){}


//--------------------------------------------------------------------------------

private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e){}

//-------------------------------------------------------------------------------

private void editButton_Click(object sender, EventArgs e)
{
    if (Controller.DisplayVisit == null) return;
EditVisit = (model.cvisit)Controller.DisplayVisit.Clone();
SetDisplayBindings(EditVisit);
EditMode = true;
}

    //-------------------------------------------------------------------------


private void undoButton_Click(object sender, EventArgs e) {}

    //------------------------------------------------------------------------

private void saveButton_Click(object sender, EventArgs e)
{
   Controller.Visits[Controller.SelectedVisitIndex] = EditVisit;
   EditMode = false;
   EditVisit = null;
   listView.Focus();
   UpdateList();
   listView.EnsureVisible(Controller.SelectedVisitIndex);
}

//------------------------------------------------------------------------------


private void listView_MouseEnter(object sender, EventArgs e){}


//-----------------------------------------------------------------------------


private void listView_MouseLeave(object sender, EventArgs e){}


    //----------------------------------------------------------------------------


private void listView_Click(object sender, EventArgs e)
{
EditMode = false; 
UpdateList();
listView.EnsureVisible(editvisitindex);
}


    //---------------------------------------------------------------------------------

private void listView_ItemChecked(object sender, ItemCheckedEventArgs e)
{
    if (e.Item.Checked == true)
    {
        Controller.SelectedVisitIndex = e.Item.Index;  // for listview ensure visibility
        //DisplayVisit = Controller.Visits[Controller.SelectedVisitIndex];
        SetDisplayBindings(Controller.DisplayVisit);
        listView.Items[e.Item.Index].Selected = true;
        flowLayoutPanel1.Focus();
        editButton.Enabled = true;
    }
    else editButton.Enabled = false;
}

private void outpatBox_SelectedIndexChanged(object sender, EventArgs e)
{
    string[] s = {"Visits","Days"};
    label5.Text = s[outpatBox.SelectedIndex];
}

private void RegionBox_SelectedIndexChanged(object sender, EventArgs e)
{

}

private void synchToolStripMenuItem_Click(object sender, EventArgs e)
{

 //   post epidemiology
 //   using (var wb = new WebClient())
 // {
      //string data = "testing 123";
 //       data["username"] = "myUser";
 //       data["password"] = "myPassword";
 //       var response = wb.UploadValues(url, "POST", data);
     //   var response = wb.UploadString("","");
    
}

//-----------------------------------------------------------------------------------------------

}
}

