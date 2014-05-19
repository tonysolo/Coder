using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using coder.model;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Auth;
using Microsoft.WindowsAzure.Storage.Table;
using Microsoft.WindowsAzure.Storage.Queue;
using Microsoft.WindowsAzure.Storage.Shared;
//using System.Configuration;
//using System.Configuration.Assemblies;



namespace coder.controller
{
    //public enum mode { visit, shortcut, region };


    public class ShellConroller
    {
        //public List<visitstrings> vstrings = new List<visitstrings>();
        public List<cvisit> Visits { get { return record.Visits; } }// = new List<string[]>(); //as strings[]
        public int SelectedVisitIndex = -1;
        public cvisit DisplayVisit { get { return (SelectedVisitIndex > -1) ? Visits[SelectedVisitIndex] : null; } }
        //public model.Visit  DisplayVisit { get;set; }
        public ListViewItem topitem { get; set; }
        private Coder record = new Coder();
        //private string[][] _listitems;
        public string[][] ICDList;
        //private CloudStorageAccount storageAccount;
        //private CloudTableClient tableClient<>();





        public ShellConroller()
        {
            //WCFServiceWebRole1.Service1 webserv = new WCFServiceWebRole1.Service1();
            //string s = webserv.GetData(12);
            //CloudQueue cq = new CloudQueue("test");
            //CloudQueueClient q = cq.ServiceClient;
            //GHGEntity gh = new GHGEntity();




            //storageAccount = CloudStorageAccount.Parse(
            // ConfigurationManager.ConnectionStrings ["StorageConnectionString"].ConnectionString);
            //   tableClient = storageAccount.CreateCloudTableClient();

            // Create the table if it doesn't exist.
            //CloudTable table = tableClient.GetTableReference("GHG");
            //tableClient = CloudStorageAccount.DevelopmentStorageAccount.CreateCloudTableClient();
            //CloudTable ct = tableClient.GetTableReference("GHG"). 

            // table.Delete();


        }

        public void ReadIS()
        {
            throw new System.NotImplementedException();
        }

        public void WriteIS()
        {
            throw new System.NotImplementedException();
        }


        //public void NewVisit() 
        //{
        //record.Visits.Add(new Visit());
        //DisplayVisit = Visits[Visits.Count];
        //}

        public void EditVisit(int n) { }

        public void SyncVisits()
        {
            view.PasswordBox pwb = new coder.view.PasswordBox();
            if (pwb.ShowDialog() == DialogResult.OK)
                MessageBox.Show("Synchonising Visits to Cloud storage");
            else MessageBox.Show("Password not Valid");
        }

        //--------------------------------------------------------------------
        public void EditRegion()
        {
            //record.Regions.Clear();
            //cRegion l = new cRegion("Sandton,-21.5677,78.5649");
            //record.Regions.Add(l);

            coder.view.RegionEdit re = new coder.view.RegionEdit(record.Regions);
            if (re.ShowDialog() == DialogResult.OK) { }
            //record.Regions.Add(re.);
            //    re.Regions.Add 
        }
        //------------------------------------------------------------------------





        public string[][] ListItems
        {
            get
            {
                string[][] _listitems = new string[Visits.Count][];
                for (int i = 0; i < _listitems.Length; i++)
                {
                    _listitems[i] = new string[1];
                    if (Visits[i] != null)
                    {
                        _listitems[i][0] = Visits[i].ICDs;// Date.dateTime.ToShortDateString();
                        // _listitems[i][1] = Visits[i].Name;
                    }
                }
                return _listitems;
            }
        }




        private void UpdateVisits()
        {
            Visits.Clear();
            for (int i = 0; i < record.Visits.Count; i++)
            {
                model.cvisit v = record.Visits[i];
                //string[] s = v.ToString().Split(',');
                Visits.Add(v);
            }
        }


        //public int EditVisitIndex { get; set; }

        //void CloneV

    }
}







