using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalAppointmentSystem
{
    public  class HomepageDataContext
    {
        public string unique{ get; set; }
        public HomepageDataContext(string unique)
        {
            this.unique = unique;
        }
        public HomepageDataContext()
        {
            

        }
    }
}
