using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace HosptialSystem
{
    public class NewPatient
    {
        public Patient assignPatientID()
        {
            Patient patient = new Patient();
            long i = 1;
            foreach (byte b in Guid.NewGuid().ToByteArray())
            {
                i *= ((int)b + 1);
            }
            patient.personID = String.Format("{0:d9}", (DateTime.Now.Ticks / 10) % 1000000000);            
            return patient;
        }
        public void assignPatientName(Patient patient, string dataFirstName, string dataLastName)
        {
            patient.personFirstName = dataFirstName;
            patient.personLastName = dataLastName;
        }
        public void assignPatientAddress(Patient patient)
        {
            patient.personAddress = "enter address";
        }
        public void assignPatientPhonenumber(Patient patient, string dataPhoneNumber)
        {
            patient.personPhoneNumber = dataPhoneNumber;
        }
        public void assignPatientBirthDate(Patient patient, string dataBirthDate)
        {
            patient.personDateOfBirth = dataBirthDate;
        }
        public void addNewPatientToDatabase(Patient patient)
        {
            InputOutput toData = new InputOutput();
            toData.writeToXML(patient);            
        }       
    }

}