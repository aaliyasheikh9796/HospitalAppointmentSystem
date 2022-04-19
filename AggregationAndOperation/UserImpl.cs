using HospitalAppointmentSystem.DataObject;
using HospitalAppointmentSystem.Interfaces.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalAppointmentSystem.AggregationAndOperation
{
    public class UserImpl : IUser
    {
        public UserDetailsDO authenticateLoginDetails(bool isUser)
        {
            throw new NotImplementedException();
        }

        public bool AuthenticateLoginDetails(List<UserDetailsDO> userDetails)
        {
            throw new NotImplementedException();
        }

        public string cancelAppointment(string appointmentStatus)
        {
            throw new NotImplementedException();
        }

        public List<DoctorDetailsDO> getDoctorDetails(int pageNumber)
        {
            throw new NotImplementedException();
        }
    }
}
