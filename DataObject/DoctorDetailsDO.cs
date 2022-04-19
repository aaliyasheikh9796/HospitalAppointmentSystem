using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalAppointmentSystem.DataObject
{
    public class DoctorDetailsDO
    {
        public int DoctorId { get; set; }
        public string DoctorName { get; set; }
        public string Degree { get; set; }
        public string Specilization { get; set; }
        public DoctorDetailsDO()
        {

        }
        public DoctorDetailsDO(int DoctorId, string DoctorName, string Degree, string Specilization)
        {
            this.DoctorId = DoctorId;
            this.DoctorName = DoctorName;
            this.Degree = Degree;
            this.Specilization = Specilization;

        }
    }
    
}
