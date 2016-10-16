using PatientTestResult.Model.BaseModels;

namespace PatientTestResult.Model.AsistantModels
{
    public class AsistantModel:PersistantModel
    {
        public string Name { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public decimal Phone { get; set; }
    }
}
