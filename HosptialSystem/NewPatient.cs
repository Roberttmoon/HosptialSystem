using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Reflection;

namespace HosptialSystem
{
    class NewPatient
    {
        public Patient assignPatientID()
        {

            Patient patient = new Patient();
            XmlDocument doc = new XmlDocument();
            doc.Load("C:\\Users\\Fenix Down\\Documents\\GitHub\\HosptialSystem\\HosptialSystem\\PeopleDatabase.xml");
            int personID = doc.SelectNodes("root/person").Count;

            return patient;
        }
        public static string AssemblyDirectory
        {
            get
            {
                string codeBase = Assembly.GetExecutingAssembly().CodeBase;
                UriBuilder uri = new UriBuilder(codeBase);
                string path = Uri.UnescapeDataString(uri.Path);
                return Path.GetDirectoryName(path);
            }
        }
        public void assignPatientName(Patient patient)
        {
            patient.personFirstName = "enter name";
            patient.personLastName = "enter name";
        }
        public void assignPatientAddress(Patient patient)
        {
            patient.personAddress = "enter address";
        }
        public void assignPatientPhonenumber(Patient patient)
        {
            patient.personPhoneNumber = "enter phonenumber";
        }
        public void assignPatientBirthDate(Patient patient)
        {
            patient.personDateOfBirth = "enter dob";
        }
        public List<string> sendDataToLogic (List<string> incomingData)
        {
            return incomingData;
        }
    }

}