using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using coder;
using System.IO;
//using coder.model;
//using coder.controller;

namespace coder
{
public partial class Shell : Form
{
public ShellConroller Controller {get;set;}
//public ListviewController ListController {get;set;}
public Shell()
{
InitializeComponent();
Controller = new ShellConroller();
//ListController = new ListviewController();
ResetView();
}

private void ResetView()
{ 
ResetToolbars();
ResetList();
Controller.ModeChanged = true; //force update
}
private void ResetToolbars()
{
    for (int i = 0; i < 3; i++) ToolBar.Items[i].BackColor = Color.White;
    for (int i = 4; i < ToolBar.Items.Count; i++) ToolBar.Items[i].Visible = false;

    switch (Controller.Mode)
    {
        case mode.visit:
            ToolBar.Items[0].BackColor = Color.LightGray;
            ToolBar.Items[4].Visible = true;
            ToolBar.Items[5].Visible = true;
            ToolBar.Items[6].Visible = true; 
            break;
        case mode.shortcut:
            ToolBar.Items[1].BackColor = Color.LightGray;
            ToolBar.Items[7].Visible = true;
            ToolBar.Items[8].Visible = true; 
            break;
        case mode.region:
            ToolBar.Items[2].BackColor = Color.LightGray;
            ToolBar.Items[9].Visible = true;
            ToolBar.Items[10].Visible = true; 
            break;
    }
    
}
    /*

private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
{
Controller.EditSettings();
}
*/
private void TemplateButton_Click(object sender, EventArgs e)
{ 
//if (Controller.Mode == mode.template) return;
Controller.Mode = mode.shortcut;
if (Controller.ModeChanged) ResetView();
UpdateList();
}

private void VisitButton_Click(object sender, EventArgs e)
{ 
// if (Controller.Mode == mode.visit) return;
Controller.Mode = mode.visit;
if (Controller.ModeChanged) ResetView();//,ListheadingWidth[i]);
UpdateList();
}

private void RegionButton_Click(object sender, EventArgs e)
{
  // if (Controller.Mode == mode.region) return;
Controller.Mode = mode.region;
if (Controller.ModeChanged) ResetView();//,ListheadingWidth[i]);
UpdateList();
}




private void toolStripTextBox1_Click(object sender, EventArgs e)
{

}

private void uploadbutton_Click(object sender, EventArgs e)
{

}

private void shell_Load(object sender, EventArgs e)
{

}

private void helpToolStripMenuItem_Click(object sender, EventArgs e)
{
   
}

//Resets and Updates the ListView when the mode changes
private void ResetList()
{
toolStripStatusLabel1.Text = "000";
//var col[] = listView.Columns;
listView.Columns.Clear();
model.Str_obj[] H = Controller.ListHeadings;
for (int i = 0; i < H.Length; i++)
{
listView.Columns.Add(H[i].Str,(int)H[i].Ob);
}

}

    
 //Updates the Listview only   
private void UpdateList() 
{
string[][] str = Controller.ListItems;
if (str == null) return;
listView.Items.Clear();
for (int i = 0;i<str.Length;i++)
{
string[] s = str[i];    
ListViewItem lvi = new ListViewItem(s);
listView.Items.Add(lvi);

   
}
}

private void listView_SelectedIndexChanged(object sender, EventArgs e)
{

}

private void shellToolbarClick(object sender, EventArgs e)
{
int x = listView.SelectedIndices.IndexOf(0);
ToolStripButton tsb = (ToolStripButton)sender;
switch(tsb.Name)
{
case "newVisitButton": Controller.NewVisit();UpdateList(); break;//UpdateList();break;
case "newTemplateButton": Controller.NewShortcut();UpdateList(); break;
case "newRegionButton":Controller.NewRegion();UpdateList();  break;
case "editVisitButton": Controller.EditVisit(x);UpdateList(); break;
case "editTemplateButton": Controller.EditShortcut(x); UpdateList(); break;
case "editRegionButton":Controller.EditRegion(x);UpdateList();  break;
case "synchVisitsButton":Controller.SyncVisits();  break;
}
}

private void ToolBar_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
{

}

}}

