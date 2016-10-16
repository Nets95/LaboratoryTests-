using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientTestResult.Model.PatientModels
{
    class PatientResultModel
    {
        public IEnumerable<PatientModel> Patients { get; set; }

        public int RowCount { get; set; }
    }
}
