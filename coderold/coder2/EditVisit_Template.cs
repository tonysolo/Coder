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
    public partial class EditVisit_Template : Form
    {
        public EditVisit_Template()
        {
            InitializeComponent();
            treat_qualif.DataSource = Enum.GetNames(typeof(model.specialty));
            refer_qualif.DataSource = Enum.GetNames(typeof(model.specialty));
            treat_spec.DataSource = Enum.GetNames(typeof(model.special_interest));
            refer_spec.DataSource = Enum.GetNames(typeof(model.special_interest));
            treat_facility.DataSource=Enum.GetNames(typeof(model.work_conditions));
            refer_facility.DataSource=Enum.GetNames(typeof(model.work_conditions));
            facility_type.DataSource = Enum.GetNames(typeof(model.facility));
            age.DataSource = Enum.GetNames(typeof(model.age_group));
            gender.DataSource= Enum.GetNames(typeof(model.gender));
            race.DataSource= Enum.GetNames(typeof(model.race));
            //treat_spec.Sorted = true;
            //refer_spec.Sorted = true;
           
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
