using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HospitalAppointmentSystem.DataObject;

namespace HospitalAppointmentSystem.Interfaces.Appointment
{
    public interface IAppointement
    {
        int getBookAppointmentByDoctorDetails(int doctorId);
        AppointmentDetailsDO getAppointmentDetails(int doctorId, DateTime time, string location, DateTime date);
    }
}
