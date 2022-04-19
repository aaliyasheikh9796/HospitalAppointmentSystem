using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalAppointmentSystem.DataObject
{
    public class AppointmentDetailsDO
    {
        public string DoctorName { get; set; }
        public DateOnly AppointmentDate { get; set; }
        public TimeOnly AppointmentTime { get; set; }
        public string AppointmentLocation { get; set; }
        public AppointmentDetailsDO()
        {

        }
        public AppointmentDetailsDO(string DoctorName, DateOnly AppointmentDate, TimeOnly AppointmentTime, string AppointmentLocation)
        {
           this.DoctorName = DoctorName;
            this.AppointmentDate = AppointmentDate;
            this.AppointmentTime = AppointmentTime;
            this.AppointmentLocation = AppointmentLocation;

        }
    }

}
