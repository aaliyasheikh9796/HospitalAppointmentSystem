using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalAppointmentSystem.DataObject
{
    public class AvailbleSpecilization
    {
        public string Availble { get; set; }
        public AvailbleSpecilization()
        {

        }
        public AvailbleSpecilization(string Availble)
        {
            this.Availble = Availble;
        }

        public override bool Equals(object obj)
        {
            AvailbleSpecilization q = obj as AvailbleSpecilization;
            return q != null && q.Availble == this.Availble;
        }

        public override int GetHashCode()
        {
            return this.Availble.GetHashCode();
        }
    }
}
