using System;
using System.Collections.ObjectModel;
using System.Windows;

namespace Demo2
{
    public class Doctor
    {
        public Doctor()
        {
        }

        public string DoctorName { get; set; }

        public bool IsAvailable { get; set; }
    }
    public class DoctorList : ObservableCollection<Doctor>
    {

    }
}
