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
        public static string UpdateDemographics(int PatientID, string FirstName, string LastName, string DateofLastVisit, string Street, string City, string State, string Zip, string DOB, string Phone, string PrimaryInsurance, string SecondaryInsurance)
        {
            
            string rowsUpdated = "0";
            MySqlConnection connection = DatabaseConnection.GetConnection();
            string updateQuery =
                    "Update Demographics Set FirstName = @F, LastName = @L, DateOfLastVisit = @D, Street = @St, City = @C, State = @S, Zip = @Z, DOB = @DOB, Phone = @P, PrimaryInsurance = @PI, SecondayInsurance = @SI WHERE PatientID = @ID";
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
            command.Parameters.AddWithValue("@PI", PrimaryInsurance);
            command.Parameters.AddWithValue("@SI", SecondaryInsurance);
            command.Parameters.AddWithValue("@ID", PatientID);
            try
            {
                connection.Open();
                rowsUpdated = command.ExecuteNonQuery().ToString();
            }
            catch(MySqlException ex)
            {
                rowsUpdated = ex.ToString();
            }
            finally
            {
                connection.Close();
            }
            return rowsUpdated;
        }
           

    }
}
