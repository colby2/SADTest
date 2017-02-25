using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

//this class will set variables that will store information from fields in the database
//the variables will be the exact same name as the database fields 
namespace DiabeticHealthDB
{
    class Demographics
    {
        public int PatientID { get; set; }
        public string Name { get; set; }
        public string dateOfLastVisit { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int Zip { get; set; }
        public int Age { get; set; }
        public string Phone { get; set; }
        public string PrimaryInsuranceProvider { get; set; }
        public string SecondaryInsuranceProvider { get; set; }
    }
}
