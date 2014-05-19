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
public partial class UserSettings : Form
{

   

public UserSettings(model.Usersettings dat)
{
//string st = set.MP_Number;
InitializeComponent();
string[] sa =  Enum.GetNames(typeof (model.work_conditions));
this.instbox.Items.AddRange(sa);
this.instbox.SelectedIndex=0;
sa =  Enum.GetNames(typeof (model.specialty));
this.practypebox.Items.AddRange(sa);
this.practypebox.SelectedIndex = 0;
    //dat.Practitioner

this.mpbox.DataBindings.Add("Text",dat,"MP_Number");
this.namebox.DataBindings.Add("Text",dat,"Name");
this.lattitudebox.DataBindings.Add("Text",dat,"Lattitude");
this.longitudebox.DataBindings.Add("Text",dat,"Longitude");
this.regionbox.DataBindings.Add("Text",dat,"Region");
this.practypebox.DataBindings.Add("SelectedIndex",dat,"Work_Conditions");
this.instbox.DataBindings.Add("SelectedIndex",dat,"Qualification");

return;
    
}

private void UserSettings_Load(object sender, EventArgs e)
{
}


}
}
