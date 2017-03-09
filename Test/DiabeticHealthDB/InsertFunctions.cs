using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace DiabeticHealthDB
{
    public static class InsertFunctions
    {
        ////having issues with datetime differences between mysql and .net
        public static int InsertIntoDemographics(string FirstName, string LastName, string DateofLastVisit, string Street, string City, string State, string Zip, string DOB, string Phone, string PrimaryInsuranceProvider, string SecondaryInsuranceProvider)
        {
            int totalRowsInserted = 0;
            MySqlConnection conn = DatabaseConnection.GetConnection();
            string qry =
               "INSERT INTO `Demographics`(`FirstName`, `LastName`, `DateofLastVisit`, `Street`, `City`, `State`, `Zip`, `DOB`, `Phone`, `PrimaryInsuranceProvider`, `SecondaryInsuranceProvider`)" +
               "VALUES (@FirstName, @Lastname, @DateofLastVisit, @Street, @City, @State, @Zip, @DOB, @Phone, @PrimaryInsuranceProvider, @SecondaryInsuranceProvider);";
            MySqlCommand cmd = new MySqlCommand(qry, conn);
            cmd.Parameters.AddWithValue("@FirstName", FirstName);
            cmd.Parameters.AddWithValue("@LastName", LastName);
            cmd.Parameters.AddWithValue("@DateofLastVisit", DateofLastVisit);//might drop this one
            cmd.Parameters.AddWithValue("@Street", Street);
            cmd.Parameters.AddWithValue("@City", City);
            cmd.Parameters.AddWithValue("@State", State);
            cmd.Parameters.AddWithValue("@Zip", Zip);
            cmd.Parameters.AddWithValue("@DOB", DOB);
            cmd.Parameters.AddWithValue("@Phone", Phone);
            cmd.Parameters.AddWithValue("@PrimaryInsuranceProvider", PrimaryInsuranceProvider);
            cmd.Parameters.AddWithValue("@SecondaryInsuranceProvider", SecondaryInsuranceProvider);
            try
            {
                conn.Open();
                totalRowsInserted = cmd.ExecuteNonQuery();
            }
            catch(MySqlException ex)//perhaps pass exception to message box
            {
                totalRowsInserted = 0;
                throw ex;
               
            }
            finally
            {
                conn.Close();
            }
            return totalRowsInserted;

        }
    }
}


