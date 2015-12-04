using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Demo2
{
    /// <summary>
    /// Interaction logic for PatientInformation.xaml
    /// </summary>
    public partial class PatientInformation : Page
    {
        public PatientInformation()
        {
            InitializeComponent();
        }
        private void button_Click(object sender, RoutedEventArgs e)
        {
            HosptialSystem.NewPatient addPatient = new HosptialSystem.NewPatient();
            HosptialSystem.Patient newPatient;
            Title = "Clicked";
            newPatient = addPatient.assignPatientID();
            addPatient.assignPatientName(newPatient, FirstName.Text, LastName.Text);
            addPatient.assignPatientAddress(newPatient, Address.Text, Address2.Text, City.Text, State.Text, Zip.Text);
            addPatient.assignPatientAge(newPatient, Age.Text);
            addPatient.assignPatientPhonenumber(newPatient, Phone.Text);
           

        }

        }
    }
