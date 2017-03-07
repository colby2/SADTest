using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySql.Data.Types;
namespace DiabeticHealthDB
{
    public static class UpdateFunctions
    {
        public static int UpdateDemographics(int PatientID, string FirstName, string LastName, string DateofLastVisit, string Street, string City, string State, string Zip, string DOB, string Phone, string PrimaryInsuranceProvider, string SecondaryInsuranceProvider)
        {
            
            int rowsUpdated = 0;
            MySqlConnection connection = DatabaseConnection.GetConnection();
            string updateQuery =
                    "Update Demographics Set FirstName = @F, LastName = @L, DateOfLastVisit = @D, Street = @St, City = @C, State = @S, Zip = @Z, DOB = @DOB, Phone = @P, PrimaryInsuranceProvider = @PI, SecondaryInsuranceProvider = @SI WHERE PatientID = @ID";
            MySqlCommand command = new MySqlCommand(updateQuery, connection);
            command.Parameters.AddWithValue("@F", FirstName);
            command.Parameters.AddWithValue("@L", LastName);
            command.Parameters.AddWithValue("@D", DateofLastVisit);
            command.Parameters.AddWithValue("@St", Street);
            command.Parameters.AddWithValue("@C", City);
            command.Parameters.AddWithValue("@S", State);
            command.Parameters.AddWithValue("@Z", Zip);
            command.Parameters.AddWithValue("@DOB", DOB);
            command.Parameters.AddWithValue("@P", Phone);
            command.Parameters.AddWithValue("@PI", PrimaryInsuranceProvider);
            command.Parameters.AddWithValue("@SI", SecondaryInsuranceProvider);
            command.Parameters.AddWithValue("@ID", PatientID);
            try
            {
                connection.Open();
                rowsUpdated = command.ExecuteNonQuery();
            }
            catch(MySqlException ex)
            {
                rowsUpdated = 0;
                throw ex;
            }
            finally
            {
                connection.Close();
            }
            return rowsUpdated;
        }
           

    }
}
