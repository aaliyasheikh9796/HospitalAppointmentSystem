using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalAppointmentSystem.DataObject
{
    public class UserDetailsDO
    {
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string EmailId { get; set; }
        public string Password { get; set; }
        public UserDetailsDO()
        {

        }
        public UserDetailsDO(int UserID, string UserName, string EmailId, string Password)
        {
            this.UserID = UserID;
            this.UserName = UserName;
            this.EmailId = EmailId;
            this.Password = Password;
        }
    }
}
