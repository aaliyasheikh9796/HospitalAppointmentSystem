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

        public List<AvailbleSpecilization> showaAilableSpecialist(List<DoctorDetailsDO> doctors)
        {
          //  Dictionary<string , AvailbleSpecilization> hash = new Dictionary<string , AvailbleSpecilization>();
            HashSet<AvailbleSpecilization> list = new HashSet<AvailbleSpecilization>(); 
            foreach (DoctorDetailsDO doctor in doctors)
            {
                list.Add(new AvailbleSpecilization(doctor.Specilization));
            }
            return list.ToList();
         
        }

        public List<DoctorDetailsDO> sortDoctorBySpecilization(string doctorSpecialization)
        {
            throw new NotImplementedException();
        }
    }
}
