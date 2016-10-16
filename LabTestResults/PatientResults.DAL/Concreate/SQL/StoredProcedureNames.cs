using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientResults.DAL.Concreate.SQL
{
    public static class StoredProcedureNames
    {
        public const string SpGetPatientResultByName = "[dbo].[spGetPatientResultsByName]";

        public const string SpGetPatientResultByNameOfTest = "spGetPatientResultByNameOfTest";

        public const string SpGetAllPatients = "[dbo].[spGetAllPatients]";

        public const string SpInsertPatient = "[dbo].[spInsertPatientInfo]";

        public const string SpInsertRegistration = "[dbo].[spInsertRegistration]";

        public const string SpInsertAsistantInfo = "[dbo].[spInsertAsistantInfo]";

        public const string SpInsertUrinaTestResultInfo = "[dbo].[spInsertUrinaTestResultInfo]";

        public const string SInsertpGeneralBloodTestResultInfo = "[dbo].[spGeneralBloodTestResultInfo]";

        public const string SpInsertProteinMetabolismTestresultInfo = "[dbo].[spInsertProteinMetabolismTestResultInfo]";

        public const string SpInsertCarbohydrateMetabolismTestResultInfo = "[dbo].[spCarbohydrateMetabolismTestResult]";

        public const string SpInsertVitaminsTestResultInfo = "[dbo].[spInsertVitaminsTestResultInfo]";

        public const string SpGetAllPatientsByNameOfAsistent = "[dbo].[spGetPatientsByNameOfAsistant]";

        public const string SpDeletePatientById = "[dbo].[spDeletePatientById]";

        public const string SpGetUserByLoginQuery = "spGetUserByLogin";
    }
}
