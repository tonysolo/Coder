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
    public partial class EditVisit //: view.EditVisit_Template
    {

        public EditVisit()
        {
            InitializeComponent();
            //dateTimePicker1.
            //base.Bitdata = new coder.model.BitData();
            //dateTimePicker1.Value. = DateTime.Today;
            //base.ICDs = new string[]();
                       


        }
        /*
public byte treatQualif;      
public byte referQualif;     
public byte treatSpecInterest;     
public byte referSpecInterest;      
public byte treatFacility;  
public byte referFacility;     
public byte FacilityType;
public byte Age;       
public byte Gender;
public byte Race;
  */ 

        public EditVisit(model.Visit v)
        {
            InitializeComponent();
           // model.Visit test = v;
           // model.Visit tst = test;
           
        }

        //private void EditVisit_Load(object sender, EventArgs e)
        //{

        //}

        private void EditVisit_Load_1(object sender, EventArgs e)
        {
        }
    }
}
