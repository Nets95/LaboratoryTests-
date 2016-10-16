using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PatientTestResult.Model.BaseModels;
namespace PatientTestResult.Model.PatientModels
{
    public class PatientModel: PersistantModel
    {
        public string Name { get; set; }

        public string LastName { get; set; }

        public string Gender { get; set; }

        public string DateOfBirth { get; set; }

        public string PlaceOfResidence { get; set; }

        public string BloodType { get; set; }

        public string Email { get; set; }

        public string PhoneNumber { get; set; }

        public string NameOfAsistant { get; set; }

        public string LastNameOfAsistant { get; set; }

        public string DateOfRegistration { get; set; }

        public string NameOfTest { get; set; }

    }
}
