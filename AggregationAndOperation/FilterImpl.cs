using HospitalAppointmentSystem.DataObject;
using HospitalAppointmentSystem.Interfaces.Filter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HospitalAppointmentSystem.AggregationAndOperation
{
    public class FilterImpl : IFilter
    {
        public List<DoctorDetailsDO> searchDoctorByName(string doctorName)
        {
            throw new NotImplementedException();
        }

        public List<DoctorDetailsDO> sortDoctorBySpecilization(string doctorSpecialization)
        {
            throw new NotImplementedException();
        }
    }
}
