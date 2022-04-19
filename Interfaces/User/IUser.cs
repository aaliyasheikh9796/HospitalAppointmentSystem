using HospitalAppointmentSystem.DataObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalAppointmentSystem.Interfaces.User
{
    public interface IUser
    {
        UserDetailsDO authenticateLoginDetails(bool isUser);
        bool AuthenticateLoginDetails(List<UserDetailsDO> userDetails);
        List<DoctorDetailsDO> getDoctorDetails(int pageNumber);
        String cancelAppointment(string appointmentStatus);

    }
}
