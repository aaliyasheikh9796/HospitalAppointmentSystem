using HospitalAppointmentSystem.DataObject;
using HospitalAppointmentSystem.Interfaces.Appointment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalAppointmentSystem.AggregationAndOperation
{
    public class AppointmentImpl : IAppointement
    {
        public AppointmentDetailsDO getAppointmentDetails(int doctorId, DateTime time, string location, DateTime date)
        {
            throw new NotImplementedException();
        }

        public int getBookAppointmentByDoctorDetails(int doctorId)
        {
            throw new NotImplementedException();
        }
    }
}
