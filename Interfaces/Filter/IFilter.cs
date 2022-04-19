using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HospitalAppointmentSystem.DataObject;


namespace HospitalAppointmentSystem.Interfaces.Filter
{
    public interface IFilter
    {
        List<DoctorDetailsDO> searchDoctorByName(string doctorName);

    }
}
