using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml;
using System.IO.IsolatedStorage;
using coder.model;


namespace coder.model
{

    public enum special_interest : byte  //5bits --32 choices
    {
        Anaesthetics, Cardiology, CardiacSurgery, Chiropractice, Dermatology, Dietetics,
        ENT_HeadNeck, EmergencyMedicine, GeneralMedicine, GeneralSurgery, Geriatrics,
        OccupationalTherapy, Paediatrics, PaediatricSurgery, Pathology, PhysioTherapy,
        PublicHealth, NeuroSurgery, Nursing, Psychiatry, Pulmonology, IntensiveCare, ObstetsGynae,
        Opththalmology, Orthopaedics, PlasticSurgery, RenalMedicine, Rheumatology, SportsMedicine,
        TerminalCare, TraditionalMedicine, _notApplicable_
    }

    public enum qualif : byte //3bits 8 choices
    {
        Specialist, MedPractioner, Therapist, NursingSister, Nurse, ParaMedic, HealthVisitor,
        _notApplicable_
    }

    public enum clinic : byte //3bits 8 choices

    { TeachingHosp, CityHospital, DistrictHospital, Clinic, IndependantPractice, _notApplicable_ }//3bits 8 of

    public enum age_group : byte //4bits 16choices
    {
        Premature, ExPrem, Neonate, FirstYear, OneToFour, FiveToTwelve, Teenager, Twenties, Thirties, Forties,
        Fifties, Sixties, Seventies, Eighties, Seniors
    }//4bits 16 possibilities

    public enum out_in_pat : byte { Outpatient, Inpatient }
    public enum gender : byte { Female, Male }
    public enum priv_pub : byte { Public, Private }
    public enum race : byte { Black, White, Coloured, Asian } //2 bits --4
    public enum vstatus : byte { sent = 0x01, additionalICDs = 0x02, addtariffs = 0x04 } //default == 0
    public enum icd10 : byte //not saved used for reports and display(icd chapter divisions)
    {
        Infective = 1, Neoplastic, Haematologic, Metabolic, Psychiatic, Neurologic, Opthalmic, ENT, Cardiovascular, Respiratory,
        Gastrointestinal, Dermatologic, Othopaedic, UroGenital, Obstetric, Perinatal, Congenital, Miscellaneuus, Poison_Injury,
        Violence_Trauma, Healthcare_Access, Special
    }
    public enum language : byte //6 bits 64 choices
    { English = 0 }//will appear as a choice (all the enums will need translation)
}

//-----------------------------------------------------------

public class Coder
{
    public List<cvisit> Visits { get; set; }
    public List<coder.model.cRegion> Regions { get; set; }

    //-----------------------------------------------------------

    public Coder()
    {
        Visits = new List<cvisit>();
        Regions = new List<coder.model.cRegion>();
    }
    //---------------------------------------------------------------

    public void LoadFromFile(string filename)
    {
        FileInfo fi = new FileInfo(filename);
        StreamReader sr = fi.OpenText();
        DecodeXMLString(sr.ReadToEnd());
        sr.Close();
    }

    //----------------------------------------------------------------

    public void SaveToFile(string Filename)
    {
        FileInfo fi = new FileInfo(Filename);
        StreamWriter sw = fi.CreateText();
        sw.Write(BuildXMLString());
        sw.Close();
    }

    //-----------------------------------------------------------------

    void LoadFromIS()
    {
        using (IsolatedStorageFileStream stm =
        new IsolatedStorageFileStream("coder.xml", FileMode.Open))
        using (StreamReader sr = new StreamReader(stm))
        {
            DecodeXMLString(sr.ReadToEnd());
        }
    }

    //-----------------------------------------------------------------------

    void SaveToIS()
    {
        using (IsolatedStorageFileStream stm =
        new IsolatedStorageFileStream("coder.xml", FileMode.Create))
        using (StreamWriter sw = new StreamWriter(stm))
        {
            sw.Write(BuildXMLString());
        }
    }

    //--------------------------------------------------------------------------

    string BuildXMLString()
    {
        StringBuilder sb = new StringBuilder();
        using (StringWriter sw = new StringWriter(sb))
        using (XmlTextWriter xtw = new XmlTextWriter(sw))
        {
            xtw.WriteStartElement("coder");
            // xtw.WriteAttributeString(

            xtw.WriteStartElement("visits");
            for (int i = 0; i < Visits.Count; i++)
                xtw.WriteElementString("v", Visits[i].ToString());
            xtw.WriteEndElement();//visits

            xtw.WriteStartElement("regions");
            for (int i = 0; i < Regions.Count; i++)
                xtw.WriteElementString("r", Regions[i].ToString());
            xtw.WriteEndElement();//regions

            xtw.WriteEndElement();//coder
        }
        return sb.ToString();
    }
    //-----------------------------------------------------------------------------------

    void DecodeXMLString(string xstr)
    {
        //XmlNameTable nt =
        using (StringReader reader = new StringReader(xstr))
        using (XmlTextReader xmlreader = new XmlTextReader(reader))
        {
            string str;
            while (xmlreader.Read())
            {
                str = (xmlreader.NodeType == XmlNodeType.Element) ? xmlreader.Name : null;
                switch (str)
                {
                    case "coder":
                        xmlreader.MoveToFirstAttribute();
                        break;

                    case "visits":
                        {
                            XmlReader subtree = xmlreader.ReadSubtree();
                            while (subtree.Read())
                                if (subtree.Name == "v") Visits.Add(new cvisit(subtree.Value));
                        }
                        break;
                    case "regions":
                        {
                            XmlReader subtree = xmlreader.ReadSubtree();
                            while (subtree.Read())
                                if (subtree.Name == "r") Regions.Add(new cRegion(subtree.Value));
                            break;
                        }
                }
            }
        }
    }
    //------------------------------------------------------------------------------------
}


