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
    public class NewPatient
    {
        public Patient assignPatientID()
        {

            Patient patient = new Patient();
            XmlDocument doc = new XmlDocument();
            doc.Load("C:\\Users\\nanne\\Documents\\GitHub\\HosptialSystem\\HosptialSystem\\PeopleDatabase.xml");
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
        public void assignPatientName(Patient patient, string dataFirstName, string dataLastName)
        {
            patient.personFirstName = dataFirstName;
            patient.personLastName = dataLastName;
        }
        public void assignPatientAddress(Patient patient, string address, string address2 /*,string city, string state, string zip*/)
        {
            patient.personAddress = address;
            patient.personAddress2 = address2;
            /*patient.personCity = city;
            patient.personState = state;
            patient.personZip = zip;*/
        }
        public void assignPatientPhonenumber(Patient patient, string dataPhoneNumber)
        {
            patient.personPhoneNumber = dataPhoneNumber;
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