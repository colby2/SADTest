using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace DiabeticHealthDB
{
   public static class DeleteFunctions
    {
        /************************************************************************************************
      * Deletes all patient Information
      * **********************************************************************************************/
        public static int DeletePatient(int PatientID)
        {
            int rowsDeleted = 0;
            MySqlConnection connection = DatabaseConnection.GetConnection();
            string updateQuery = "Delete FROM Demographics WHERE PatientID = @ID;";
            MySqlCommand command = new MySqlCommand(updateQuery, connection);
            command.Parameters.AddWithValue("@ID", PatientID);
            try
            {
                connection.Open();
                rowsDeleted = command.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                rowsDeleted = 0;
                throw ex;
            }
            finally
            {
                connection.Close();
            }
            return rowsDeleted;
        }
        /************************************************************************************************
      * Deletes all allergy information
      * **********************************************************************************************/
        public static int DeleteAllergy(int AllergyInfoID)
        {
            int rowsDeleted = 0;
            MySqlConnection connection = DatabaseConnection.GetConnection();
            string updateQuery = "Delete FROM AllergyInfo WHERE AllergyInfoID = @ID;";
            MySqlCommand command = new MySqlCommand(updateQuery, connection);
            command.Parameters.AddWithValue("@ID", AllergyInfoID);
            try
            {
                connection.Open();
                rowsDeleted = command.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                rowsDeleted = 0;
                throw ex;
            }
            finally
            {
                connection.Close();
            }
            return rowsDeleted;
        }
    }
    
}
