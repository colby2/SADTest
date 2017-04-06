using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
u
namespace DiabeticHealthDB
{
    public static class InsertFunctions
    {
        /************************************************************************************************
      * Inserts info into Demographic Table from from
      * **********************************************************************************************/
        public static int InsertIntoDemographics(string FirstName, string LastName, string DateofLastVisit, string Street, string City, string State, string Zip, string DOB, string Phone, string PrimaryInsuranceProvider, string SecondaryInsuranceProvider, string PatientNotes)
        {
            int totalRowsInserted = 0;
            MySqlConnection conn = DatabaseConnection.GetConnection();
            string qry =
               "INSERT INTO `Demographics`(`FirstName`, `LastName`, `DateofLastVisit`, `Street`, `City`, `State`, `Zip`, `DOB`, `Phone`, `PrimaryInsuranceProvider`, `SecondaryInsuranceProvider`, `PatientNotes)" +
               "VALUES (@FirstName, @Lastname, @DateofLastVisit, @Street, @City, @State, @Zip, @DOB, @Phone, @PrimaryInsuranceProvider, @SecondaryInsuranceProvider, @PatientNotes);";
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
            cmd.Parameters.AddWithValue("@PatientNotes", PatientNotes);
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
        /************************************************************************************************
         * Inserts info into AllergyInfo Table from form
         * **********************************************************************************************/
        public static int InsertIntoAllergyInfo(int PatientID, string AllergicTo, string Reaction)
        {
            int totalRowsInserted = 0;
            MySqlConnection conn = DatabaseConnection.GetConnection();
            string qry =
                "INSERT INTO `AllergyInfo`(`PatientID`, `AllergicTo`, `Reaction`) VALUES (@PatientID, @AllergicTO, @Reaction);";
            MySqlCommand cmd = new MySqlCommand(qry, conn);
            cmd.Parameters.AddWithValue("@PatientID", PatientID);
            cmd.Parameters.AddWithValue("@AllergicTo", AllergicTo);
            cmd.Parameters.AddWithValue("@Reaction", Reaction);
            try
            {
                conn.Open();
                totalRowsInserted = cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)//perhaps pass exception to message box
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
        /*
         *Insert function for VitalsInforamtion Table  
         */
        public static int InsertIntoVitalsInformation(DateTime DateOfTest, int HeartRate, string BloodPressure, int RespiratoryRate, int OxygenSaturation, string AirType, int Height, int Weight, double Temperature, int PatientID)
        {
            int totalRowsInserted = 0;
            MySqlConnection conn = DatabaseConnection.GetConnection();
            string qry =
                "INSERT INTO `VitalsInformation`( `DateofTest`, `HeartRate`, `BloodPressure`, `RespiratoryRate`, `OxygenSaturation`, `AirType`, `Height`, `Weight`, `Temperature`, `PatientID`)" +
                "VALUES (@DateOfTest, @HeartRate, @BloodPressure, @RespiratoryRate, @OxygenSaturation, @AirType, @Height, @Weight, @Temperature, @PatientID);";
            MySqlCommand cmd = new MySqlCommand(qry, conn);
            cmd.Parameters.AddWithValue("@DateOfTest", DateOfTest);
            cmd.Parameters.AddWithValue("@HeartRate", HeartRate);
            cmd.Parameters.AddWithValue("@BloodPressure", BloodPressure);
            cmd.Parameters.AddWithValue("@RespiratoryRate", RespiratoryRate);
            cmd.Parameters.AddWithValue("@OxygenSaturation", OxygenSaturation);
            cmd.Parameters.AddWithValue("@AirType", AirType);
            cmd.Parameters.AddWithValue("@Height", Height);
            cmd.Parameters.AddWithValue("@Weight", Weight);
            cmd.Parameters.AddWithValue("@Temperature", Temperature);
            cmd.Parameters.AddWithValue("@PatientID", PatientID);
            try
            {
                conn.Open();
                totalRowsInserted = cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)//perhaps pass exception to message box
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

        public static void InsertIntoMedication(string MedicationName, string DateStarted, string Amount, string Frequency, string Route, int PatientID)
        {
            
            MySqlConnection conn = DatabaseConnection.GetConnection();
            string qry =
                "INSERT INTO `Medication`( `MedicationName`, `DateStarted`, `Amount`, `Frequency`, `Route`, `PatientID`)" +
                "VALUES (@MedicationName, @DateStarted, @Amount, @Frequency, @Route, @PatientID);";
            MySqlCommand cmd = new MySqlCommand(qry, conn);
            cmd.Parameters.AddWithValue("@MedicationName", MedicationName);
            cmd.Parameters.AddWithValue("@DateStarted", DateStarted);
            cmd.Parameters.AddWithValue("@Amount", Amount);
            cmd.Parameters.AddWithValue("@Frequency", Frequency);
            cmd.Parameters.AddWithValue("@Route", Route);
            cmd.Parameters.AddWithValue("@PatientID", PatientID);
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)//perhaps pass exception to message box
            {

                ex.ToString();

            }
            finally
            {
                conn.Close();
            }
            

        }
    }

  
}


