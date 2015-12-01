using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HosptialSystem
{
    class MedicalProfessinal: Person
    {
        int yearsOfExperence;
        Dictionary<DateTime, Room> roomOccupiedWhen;
    }
}
