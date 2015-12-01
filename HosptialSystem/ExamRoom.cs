using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HosptialSystem
{
    class ExamRoom: Room
    {
        Dictionary<DateTime, MedicalProfessinal> reserveProfecinalTime;
        Dictionary<DateTime, Patient> reservePatientTime;
    }
}
