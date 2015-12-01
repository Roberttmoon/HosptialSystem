using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hosptial
{
    public class Patient
    {
        //patent information
        string patientID;
        string patientLastName;
        string patientFirstName;
        string patientBirthDate;
        string patientPhoneNumber;
        string patientPrimaryDoctor;


        //patient history
        List<List<patientCurrentSymptoms>> patientPastSymptoms;
        List<string> patentAllergys;
        List<string> patentPastSurgerys;

        //appointment details
        DateTime patientApointmentDateTime;
        string patientApointmentRoom;
        string patientApointmentDoctor;
        List<string> patientCurrentSymptoms;

        //insurance details
        bool hasInsurance;
        string insuranceCompanyName;
        string memberID;
        string groupID;
        string insuranceExpirationDate;

    }
}
