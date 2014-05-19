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
public partial class EditVisit_Template : Form
    {
private model.BitData _bitdata = new BitData();
private List<Icd> allicds { get; set; }
public string ICDname {get;set; }
public string Icds { get; set; } //{ get{return _icds;}set{_icds= value;}}// { return editicds; } set { editicds = value; } }
public string Tariffs {get;set;} //{ get { return _tariffs; } set { _tariffs = value; } }
public vstatus vstatus = 0;

public model.BitData Bitdata { 
get
    {
   // _bitdata.treater.qualif = (byte)treat_qualif.SelectedIndex; 
//_bitdata.referer.qualif = (byte)refer_qualif.SelectedIndex;
//_bitdata.treater_spec_interest = (byte)treat_spec.SelectedIndex; 
//_bitdata.referer_spec_interest = (byte)refer_spec.SelectedIndex; 
//_bitdata.treater_clinic = (byte)treat_facility.SelectedIndex;
//_bitdata.referer_clinic = (byte)refer_facility.SelectedIndex;
//_bitdata.patient.out_patient (byte)facility_type.SelectedIndex; 
_bitdata.patient = (byte) age.SelectedIndex; 
_bitdata.gender =(byte) gender.SelectedIndex;
_bitdata.race = (byte) race.SelectedIndex;
return _bitdata;
}
set{
_bitdata = value;
//treat_qualif.SelectedIndex = _bitdata.treater_qualif;
//refer_qualif.SelectedIndex = _bitdata.referer_qualif;
//treat_spec.SelectedIndex = _bitdata.treater_spec_interest;
//refer_spec.SelectedIndex = _bitdata.referer_spec_interest;
//treat_facility.SelectedIndex = _bitdata.treater_clinic;
//refer_facility.SelectedIndex = _bitdata.referer_clinic;
//facility_type.SelectedIndex = _bitdata.pub_priv;
age.SelectedIndex = _bitdata.age;
gender.SelectedIndex = _bitdata.gender;
race.SelectedIndex = _bitdata.race;
} 
}

//private string[] organiseArray(string[]arr,int length) //compacts icds and tariffs
//{
//    arr = arr.Where(s => !String.IsNullOrEmpty(s)).ToArray<string>();// != "");
//    string[] sarr = new string[length];
//    for (int i = 0; i < arr.Length; i++) sarr[i] = arr[i];
 //   return sarr;
//}


private void SetDropdownLists()
{
treat_qualif.DataSource = Enum.GetNames(typeof(model.qualif));
refer_qualif.DataSource = Enum.GetNames(typeof(model.qualif));
treat_spec.DataSource = Enum.GetNames(typeof(model.special_interest));
refer_spec.DataSource = Enum.GetNames(typeof(model.special_interest));
treat_facility.DataSource=Enum.GetNames(typeof(model.clinic));
refer_facility.DataSource=Enum.GetNames(typeof(model.clinic));
facility_type.DataSource = Enum.GetNames(typeof(model.priv_pub));
visit_type.DataSource = Enum.GetNames(typeof(model.out_in_pat));
age.DataSource = Enum.GetNames(typeof(model.age_group));
gender.DataSource= Enum.GetNames(typeof(model.gender));
race.DataSource = Enum.GetNames(typeof(model.race));
}

public EditVisit_Template()
{
InitializeComponent();
SetDropdownLists();
Bitdata = new coder.model.BitData();
}

        private void savebutton_Click(object sender, EventArgs e){}

    
        private void newCodes_Click(object sender, EventArgs e)
        {
            view.codeEdit ncode = new view.codeEdit();
            ncode.icdname.DataBindings.Add("Text", this, "ICDname");
            ncode.icds.DataBindings.Add("Text", this, "Icds");
            ncode.tariffs.DataBindings.Add("Text", this, "Tariffs");
            if (ncode.ShowDialog(this) == DialogResult.OK)
        {
            //vstatus = 0;
            if(additional_icds_checkbox.Checked==true) vstatus = vstatus|vstatus.additionalICDs;
            if(tariffcheckbox.Checked==true) vstatus = vstatus|vstatus.addtariffs;
            //string display = String.Format("{0,-12}{1,20}", ICDname,Icds );
            int pos = icdcombobox.Items.Add(ICDname);
            icdcombobox.SelectedIndex = pos;
            string picd="";
            if (Icds.Length>0)
            picd = Icds.Split(new char[]{' '})[0]; //get the first icd code         
            this.PrimaryICDlabel.Text += picd;
            this.additional_icds_checkbox.Text += this.Icds; //all icd codes
            this.tariffcheckbox.Text += this.Tariffs;
        }
        }

        private void EditVisit_Template_Load(object sender, EventArgs e){}

        private void race_SelectedIndexChanged(object sender, EventArgs e){}

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e){}

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
           
        }
    }
}
