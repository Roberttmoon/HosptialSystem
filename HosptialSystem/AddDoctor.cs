using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.IO;
using System.Reflection;

namespace HosptialSystem
{
    public class addDoctor
    {

        public Doctor assignDoctor()
        {

            Doctor doctor = new Doctor();
            XmlDocument doc = new XmlDocument();
            doc.Load("C:\\Users\\Fenix Down\\Documents\\GitHub\\HosptialSystem\\HosptialSystem\\PeopleDatabase.xml");
            int personID = doc.SelectNodes("root/person").Count;

            return doctor;
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

        public void assignDoctorName(Doctor doctor)
        {
            doctor.personFirstName = "Enter First Name: ";
            doctor.personLastName = "Enter Last Name: ";
        }
        public void assignDoctorAddress(Doctor doctor)
        {
            doctor.personStreetAddress1 = "Enter Address: ";
        }
        public void assignDoctorPhoneNumber(Doctor doctor)
        {
            doctor.personPhoneNumber = "Enter Phone Number: ";
        }
        public void assignPatientBirthDate(Doctor doctor)
        {
            doctor.personDateOfBirth = "Enter your Date of Birth (MM/DD): ";
        }
    }
}