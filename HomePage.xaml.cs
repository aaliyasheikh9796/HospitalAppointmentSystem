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
using System.Windows.Shapes;
using HospitalAppointmentSystem.DataObject;
using HospitalAppointmentSystem.AggregationAndOperation;
using HospitalAppointmentSystem.MockData;

   
namespace HospitalAppointmentSystem
{
    /// <summary>
    /// Interaction logic for HomePage.xaml
    /// </summary>
    public partial class HomePage : Window
    {
        public List<DoctorDetailsDO> DoctorDetail { get; set; }
        UserImpl UserImpl = new UserImpl();
        DoctorMockData doctorMockData = new DoctorMockData();
        public HomePage()
        {
            InitializeComponent();

           
            List<DoctorDetailsDO> doctorDetailsList = doctorMockData.getDoctarDataList();  
            DoctorDetail = new List<DoctorDetailsDO>();
            
            foreach(DoctorDetailsDO item in doctorDetailsList)
            {
                DoctorDetail.Add(item);
            }
           DataContext = this;
           
        }

        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
