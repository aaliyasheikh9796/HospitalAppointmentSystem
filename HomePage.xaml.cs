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
       List<DoctorDetailsDO> doctorDetail;
        List<AvailbleSpecilization> homePageDetail;
        public HomePage()
        {
            InitializeComponent();
            DoctorMockData doctorMockData = new DoctorMockData();
           
            List<DoctorDetailsDO> doctorDetailsList = doctorMockData.getDoctarDataList();
            doctorDetail = new List<DoctorDetailsDO>();

            foreach (DoctorDetailsDO item in doctorDetailsList)
            {
                doctorDetail.Add(item);
            }
            MyList.ItemsSource = doctorDetail;

            FilterImpl filterImpl = new FilterImpl();
            List<AvailbleSpecilization> list = filterImpl.showaAilableSpecialist(doctorDetailsList);
            homePageDetail = new List<AvailbleSpecilization>();
            foreach (AvailbleSpecilization item in list)
            {
                homePageDetail.Add(item);
            }
            Speciallist.ItemsSource = homePageDetail;

            MyList.Items.Filter = NameFilter;
        }

        private bool NameFilter(object obj)
        {
           var FilterObject = obj as DoctorDetailsDO;

            return FilterObject.DoctorName.Contains(searchbar.Text , StringComparison.OrdinalIgnoreCase);
        }

        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
          
        }

        private void searchbar_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (searchbar.Text == null)
            {
                MyList.Items.Filter = null;
            }
            else
            {
                MyList.Items.Filter = NameFilter;
            }
        }
    }
}
