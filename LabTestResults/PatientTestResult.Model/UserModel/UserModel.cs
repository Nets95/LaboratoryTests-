using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PatientTestResult.Model.BaseModels;
namespace PatientTestResult.Model.UserModel
{
    public class UserModel : PersistantModel
    {
        public string FirstName { get; set; }

        public string Surname { get; set; }

        public string Login { get; set; }

        public string Password { get; set; }

        public bool Disabled { get; set; }
    }
}
