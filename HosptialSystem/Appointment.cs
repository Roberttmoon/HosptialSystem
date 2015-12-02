using Google.Apis.Auth.OAuth2;
using Google.Apis.Calendar.v3;
using Google.Apis.Calendar.v3.Data;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HosptialSystem
{
    class Appointment
    {
        // takes in med. prof, room and patent

        Dictionary<int, bool> vacantRoom= new Dictionary<int, bool>();
        DateTime appointmentTime;
    }
}
