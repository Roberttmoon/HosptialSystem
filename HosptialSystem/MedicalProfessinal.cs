using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HosptialSystem
{
    public class MedicalProfessinal: Person
    {
        public int yearsOfExperence;
        Dictionary<DateTime, Room> roomOccupiedWhen;
    }
}
