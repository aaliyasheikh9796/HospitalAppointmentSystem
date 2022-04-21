using HospitalAppointmentSystem.DataObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalAppointmentSystem.MockData
{
    public class DoctorMockData
    {
       public List<DoctorDetailsDO> getDoctarDataList()
        {
            List<DoctorDetailsDO> doctorDetailsList = new List<DoctorDetailsDO>();
            doctorDetailsList.Add(new DoctorDetailsDO(101, "Dr.Sajal","MBBS","Surgen"));
            doctorDetailsList.Add(new DoctorDetailsDO(102, "Dr.Rohit", "BAMS", "Gynecologist"));
            doctorDetailsList.Add(new DoctorDetailsDO(103, "Dr.nitin", "MBBS", "Surgen"));
            doctorDetailsList.Add(new DoctorDetailsDO(104, "Dr.Sajal", "MD", "Gynecologist"));
            doctorDetailsList.Add(new DoctorDetailsDO(105, "Dr.jhon", "MBBS", "Pediatrician"));
            doctorDetailsList.Add(new DoctorDetailsDO(106, "Dr.chloe", "MBBS", "Orthologist"));
            doctorDetailsList.Add(new DoctorDetailsDO(107, "Dr.joy", "MD", "Surgen"));
            doctorDetailsList.Add(new DoctorDetailsDO(108, "Dr.tamrakar", "MBBS", "Pediatrician"));
            doctorDetailsList.Add(new DoctorDetailsDO(109, "Dr.sharad", "MD", "Surgen"));
            doctorDetailsList.Add(new DoctorDetailsDO(1010, "Dr.shukla", "BHMS", "Surgen"));
            doctorDetailsList.Add(new DoctorDetailsDO(1011, "Dr.Sajal", "Gynecologist", "nurologist"));
            doctorDetailsList.Add(new DoctorDetailsDO(1012, "Dr.Shania", "BHMS", "Surgen"));
            doctorDetailsList.Add(new DoctorDetailsDO(1013, "Dr.Levine", "MBBS", "Surgen"));
            doctorDetailsList.Add(new DoctorDetailsDO(1014, "Dr.Casey", "BHMS", "Cardiologist"));
            doctorDetailsList.Add(new DoctorDetailsDO(1015, "Dr.Miguel", "MBBS", "Surgen"));
            doctorDetailsList.Add(new DoctorDetailsDO(1016, "Dr.Micah", "MBBS", "Surgen"));
            doctorDetailsList.Add(new DoctorDetailsDO(1017, "Dr.Gregory", "BHMS", "Surgen"));
            doctorDetailsList.Add(new DoctorDetailsDO(1018, "Dr.Cooley", "MBBS", "Surgen"));
            doctorDetailsList.Add(new DoctorDetailsDO(1019, "Dr.Jensen", "Pediatrician", "nurologist"));
            doctorDetailsList.Add(new DoctorDetailsDO(1020, "Dr.Sajal", "MBBS", "Surgen"));
            doctorDetailsList.Add(new DoctorDetailsDO(1021, "Dr.Calhoun", "BHMS", "Orthologist"));
            doctorDetailsList.Add(new DoctorDetailsDO(1022, "Dr.Espinoza", "MBBS", "Surgen"));
            doctorDetailsList.Add(new DoctorDetailsDO(1024, "Dr.Erickson", "BHMS", "Cardiologist"));
            doctorDetailsList.Add(new DoctorDetailsDO(1025, "Dr.Oconnell", "MBBS", "Surgen"));
            doctorDetailsList.Add(new DoctorDetailsDO(1026, "Dr.Hicks", "BHMS", "nurologist"));
            doctorDetailsList.Add(new DoctorDetailsDO(1027, "Dr.Simpson", "BAMS", "Surgen"));
            doctorDetailsList.Add(new DoctorDetailsDO(1028, "Dr.Carlson", "Pediatrician", "Surgen"));
            doctorDetailsList.Add(new DoctorDetailsDO(1029, "Dr.Shaun", "MBBS", "Surgen"));
            doctorDetailsList.Add(new DoctorDetailsDO(1030, "Dr.Jaqueline", "Gynecologist", "nurologist"));
            doctorDetailsList.Add(new DoctorDetailsDO(1031, "Dr.Daniella", "MBBS", "Surgen"));
            doctorDetailsList.Add(new DoctorDetailsDO(1032, "Dr.Avery", "Pediatrician", "Orthologist"));
            doctorDetailsList.Add(new DoctorDetailsDO(1033, "Dr.Mcbride", "BAMS", "Surgen"));
            doctorDetailsList.Add(new DoctorDetailsDO(1034, "Dr.Zane", "MD", "nurologist"));
            doctorDetailsList.Add(new DoctorDetailsDO(1035, "Dr.Zariah", "MBBS", "Surgen"));
            doctorDetailsList.Add(new DoctorDetailsDO(1036, "Dr.Sammy", "Pediatrician", "Cardiologist"));
            doctorDetailsList.Add(new DoctorDetailsDO(1037, "Dr.Allen", "MBBS", "Surgen"));
            doctorDetailsList.Add(new DoctorDetailsDO(1038, "Dr.Page", "Gynecologist", "Surgen"));
            doctorDetailsList.Add(new DoctorDetailsDO(1039, "Dr.Davin", "MD", "Surgen"));
            doctorDetailsList.Add(new DoctorDetailsDO(1040, "Dr.Xzavier", "Gynecologist", "Surgen"));
            doctorDetailsList.Add(new DoctorDetailsDO(1041, "Dr.Jakobe", "MD", "Nurologist"));
            doctorDetailsList.Add(new DoctorDetailsDO(1042, "Dr.Moises", "Gynecologist", "Orthologist"));
            return doctorDetailsList;
        }
    }
}
