﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace HosptialSystem
{
    class NewPatent
    {
        public Patient assignPatientID()
        {

            Patient patient = new Patient();
            XmlDocument doc = new XmlDocument();
            doc.Load("C:\\Users\\Robert Moon\\Documents\\Class\\GitHub\\HosptialSystem\\HosptialSystem\\PeopleDatabase.xml");
            int personID = doc.SelectNodes("root/person").Count;

            return patient;
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
    }

}