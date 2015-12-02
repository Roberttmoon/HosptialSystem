using HosptialSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HosptialSystem
{
    public class Patient: Person
    {
        //patent information
        public string patientPrimaryDoctor;


        //patient history
       // List<List<patientCurrentSymptoms>> patientPastSymptoms;
        List<string> patientAllergys;
        List<string> patientPastSurgerys;


        //appointment details
        public DateTime patientApointmentDateTime;
        public string patientApointmentRoom;
        public string patientApointmentDoctor;
        public List<string> patientCurrentSymptoms;

        //insurance details
        public bool hasInsurance;
        public string insuranceCompanyName;
        public string memberID;
        public string groupID;
        public string insuranceExpirationDate;

    }
}
