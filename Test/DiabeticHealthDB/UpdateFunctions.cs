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
        /************************************************************************************************
        *Function that will allow users to update all of the fields the user changes on the patient form
        * in the demographics tab
        * ***********************************************************************************************/
        public static int UpdateDemographics(int PatientID, string FirstName, string LastName, string Gender, string DateofLastVisit, string Street, string City, string State, string Zip, string DOB, string Phone, string PrimaryInsuranceProvider, string SecondaryInsuranceProvider)
        {

            int rowsUpdated = 0;
            MySqlConnection connection = DatabaseConnection.GetConnection();
            string updateQuery =
                    "Update Demographics Set FirstName = @F, LastName = @L, Gender = @G, DateOfLastVisit = @D, Street = @St, City = @C, State = @S, Zip = @Z, DOB = @DOB, Phone = @P, PrimaryInsuranceProvider = @PI, SecondaryInsuranceProvider = @SI WHERE PatientID = @ID";
            MySqlCommand command = new MySqlCommand(updateQuery, connection);
            command.Parameters.AddWithValue("@F", FirstName);
            command.Parameters.AddWithValue("@L", LastName);
            command.Parameters.AddWithValue("@G", Gender);
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
            catch (MySqlException ex)
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



        /************************************************************************************************
      *Function that will allow users to update only last visit date
      * ***********************************************************************************************/
        public static int UpdateDateOfLastVisit(int PatientID, string DateOfLastVisit)
    {
        int rowsUpdated = 0;
        MySqlConnection connection = DatabaseConnection.GetConnection();
        string updateQuery =
                "Update Demographics Set DateOfLastVisit = @D Where PatientID = @P;";
        MySqlCommand command = new MySqlCommand(updateQuery, connection);
        command.Parameters.AddWithValue("@D", DateOfLastVisit);
        command.Parameters.AddWithValue("@P", PatientID);
        try
        {
            connection.Open();
            rowsUpdated = command.ExecuteNonQuery();
        }
        catch (MySqlException ex)
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
        public static void UpdateNotes(int PatientID, string PatientNotes)
        {
            int rowsUpdated = 0;
            MySqlConnection connection = DatabaseConnection.GetConnection();
            string updateQuery =
                    "Update Demographics Set PatientNotes = @PN Where PatientID = @P;";
            MySqlCommand command = new MySqlCommand(updateQuery, connection);
            command.Parameters.AddWithValue("@PN", PatientNotes);
            command.Parameters.AddWithValue("@P", PatientID);
            try
            {
                connection.Open();
                rowsUpdated = command.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                rowsUpdated = 0;
                throw ex;
            }
            finally
            {
                connection.Close();
            }
            //return rowsUpdated;
        }

        /************************************************************************************************
    *Function that will allow users to update AllergicTo and Reaction fields in AllergyInfo Table
    * ***********************************************************************************************/
        public static int UpdateDateAllergyInfo(int AllergyInfoID, string AllergicTo, string Reaction)
        {
            int rowsUpdated = 0;
            MySqlConnection connection = DatabaseConnection.GetConnection();
            string updateQuery =
                    "Update AllergyInfo Set AllergicTo = @AllergicTO, Reaction = @Reaction Where AllergyInfoID = @ID;";
            MySqlCommand command = new MySqlCommand(updateQuery, connection);
            command.Parameters.AddWithValue("@AllergictTo", AllergicTo);
            command.Parameters.AddWithValue("@Reaction", Reaction);
            command.Parameters.AddWithValue("@ID", AllergyInfoID);
            try
            {
                connection.Open();
                rowsUpdated = command.ExecuteNonQuery();
            }
            catch (MySqlException ex)
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



        /*****************************************************************************
         * Function that will update a Users AllergicTo and Reaction when editing
         * ***************************************************************************/
        public static void UpdateAllergyInfo(int PatientID, string newAllergicTo, string newReaction, string oldAllergicTo, string oldReaction)
        {
            MySqlConnection connection = DatabaseConnection.GetConnection();
            string updateQuery = "Update AllergyInfo Set AllergicTo = '" + newAllergicTo + "' , Reaction = '" + newReaction + "' Where PatientID = '" + PatientID + "' AND AllergicTo = '" + oldAllergicTo + "' AND Reaction = '" + oldReaction + "';";
            MySqlCommand command = new MySqlCommand(updateQuery, connection);
            try
            {
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
        }

        public static void UpdateMedicationInfo(int PatientID, string newMedication, string newDateStarted, string newAmount, string newFrequency, string newRoute, string oldMedicationName, string oldDateStarted, string oldAmount, string oldFrequency, string oldRoute)
        {
            MySqlConnection connection = DatabaseConnection.GetConnection();
            string updateQuery = "Update Medication Set MedicationName = '" + newMedication + "', DateStarted = '" + newDateStarted + "', Amount = '" + newAmount + "', Frequency = '" + newFrequency + "', Route = '" + newRoute + "' Where PatientID ='" + PatientID + "' AND MedicationName = '" + oldMedicationName + "'AND DateStarted = '" + oldDateStarted + "' AND Amount = '" + oldAmount + "'AND Frequency = '" + oldFrequency + "'AND Route = '" + oldRoute + "';";
            MySqlCommand command = new MySqlCommand(updateQuery, connection);
            try
            {
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }


        }


        public static void UpdateVitalsInfo(int PatientID, DateTime newDateOfTest, string newHR, string newSystolic, string newRR, string newDiastolic, string newO2sat, string newAirType, string newheight, string newweight, string newtemperature, DateTime olddateTaken, string oldheartRate, string oldsystolic, string olddiastolic, string oldrespiratoryRate, string oldO2Sat, string oldAirType, string oldHeight, string oldWeight, string oldTemperature)
        {
            string formattedNewDateOfTest = newDateOfTest.ToString("yyyy-MM-dd");
            string formattedOldDateOfTest = olddateTaken.ToString("yyyy-MM-dd");

            MySqlConnection connection = DatabaseConnection.GetConnection();
            string updateQuery = "Update VitalsInformation Set DateOfTest = '" + formattedNewDateOfTest + "', HeartRate = '" + newHR + "', Systolic = '" + newSystolic + "', Diastolic = '" + newDiastolic + "', RespiratoryRate = '" + newRR + "', OxygenSaturation = '" + newO2sat + "', AirType = '" + newAirType + "', Height ='" + newheight + "', Weight ='" + newweight +"', Temperature = '" + newtemperature + "' Where PatientID ='" + PatientID + "' AND DateOfTest = '" + formattedOldDateOfTest + "' AND HeartRate = '" + oldheartRate  + "' AND Systolic = '" + oldsystolic + "'AND Diastolic = '" + olddiastolic + "'AND RespiratoryRate = '" + oldrespiratoryRate + "' AND OxygenSaturation = '" + oldO2Sat +"' AND AirType = '" + oldAirType+ "' AND Height = '" + oldHeight + "' AND Weight = '" + oldWeight + "' AND Temperature = '" +oldTemperature+"';";
            MySqlCommand command = new MySqlCommand(updateQuery, connection);
            try
            {
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
        }

        public static void UpdateDiabetesMedicationInfo(int PatientID, string newmedication, string newdateStarted, string newamount, string newfrequency, string newroute, string oldmedName, string olddateStarted, string oldamount, string oldfrequency, string oldroute)
        {

            MySqlConnection connection = DatabaseConnection.GetConnection();
            string updateQuery = "Update DiabetesMedication Set MedicationName = '" + newmedication + "', DateStarted = '" + newdateStarted + "', Amount = '" + newamount + "', Frequency = '" + newfrequency + "', Route = '" + newroute + "' Where PatientID ='" + PatientID + "' AND MedicationName = '" + oldmedName + "' AND DateStarted = '" + olddateStarted + "' AND Amount = '" + oldamount + "'AND Frequency = '" + oldfrequency + "'AND Route = '" + oldroute + "';";
            MySqlCommand command = new MySqlCommand(updateQuery, connection);
            try
            {
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }

        }


        public static void UpdateDiabeticTestInfo(int PatientID, string newdatetestTaken, string newmicroalbumin, string newfootcheck, string newcyv, string neweyeexam, string newcounseling, string olddateOfTest, string oldmicroalbiumin, string oldfootCheck, string oldcurrentYearVaccination, string olddiabeticEyeExam, string oldnutritionalCounseling)
        {

            MySqlConnection connection = DatabaseConnection.GetConnection();
            string updateQuery = "Update DiabeticTests Set DateOfTest = '" + newdatetestTaken + "', Microalbumin = '" + newmicroalbumin + "', FootCheck = '" + newfootcheck + "', CurrentYearVaccination = '" + newcyv + "', DiabeticEyeExam = '" + neweyeexam + "', NutritionalCounseling = '" + newcounseling + "' Where PatientID ='" + PatientID + "' AND DateOfTest = '" + olddateOfTest + "' AND Microalbumin = '" + oldmicroalbiumin + "' AND FootCheck = '" + oldfootCheck + "'AND CurrentYearVaccination = '" + oldcurrentYearVaccination + "'AND DiabeticEyeExam = '" + olddiabeticEyeExam + "' AND NutritionalCounseling = '" + oldnutritionalCounseling + "';";
            MySqlCommand command = new MySqlCommand(updateQuery, connection);
            try
            {
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
        }

        public static void UpdateLipidTestInfo(int PatientID, DateTime newDateOfTest, string newHgA1c, string newcholesterol, string newHDL, string newLDL, string newtrigylcerides, DateTime olddateOfTest, string oldHgA1C, string oldcholesterol, string oldHDL, string oldLDL, string oldtriglycerides)
        {
            string formattedNewDateOfTest = newDateOfTest.ToString("yyyy-MM-dd");
            string formattedOldDateOfTest = olddateOfTest.ToString("yyyy-MM-dd");

            MySqlConnection connection = DatabaseConnection.GetConnection();
            string updateQuery = "Update LipidTestInformation Set DateOfTest = '" + formattedNewDateOfTest + "', HgA1C = '" + newHgA1c + "', Cholesterol = '" + newcholesterol + "', HDL = '" + newHDL + "', LDL = '" + newLDL + "', Triglycerides = '" + newtrigylcerides + "' Where PatientID ='" + PatientID + "' AND DateOfTest = '" + formattedOldDateOfTest + "' AND HgA1C = '" + oldHgA1C + "' AND Cholesterol = '" + oldcholesterol + "'AND HDL = '" + oldHDL + "'AND LDL = '" + oldLDL + "' AND Triglycerides = '" + oldtriglycerides + "';";
            MySqlCommand command = new MySqlCommand(updateQuery, connection);
            try
            {
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }

        }

        public static void UpdateDiabetesBackgroundInfo(int PatientID, string newdateInfoTaken, string newdateDiagnosed, string newdiabetesType, string oldDateInfoTaken, string oldDateDiagnosed, string oldDiabetesType)
        {
            MySqlConnection connection = DatabaseConnection.GetConnection();
            string updateQuery = "Update DiabetesBackground Set DateInfoTaken = '" + newdateInfoTaken + "', DateDiagnosed = '" + newdateDiagnosed + "', DiabetesType = '" + newdiabetesType + "' Where PatientID ='" + PatientID + "' AND DateInfoTaken = '" + oldDateInfoTaken + "' AND DateDiagnosed = '" + oldDateDiagnosed + "' AND DiabetesType = '" + oldDiabetesType + "';";
            MySqlCommand command = new MySqlCommand(updateQuery, connection);
            try
            {
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
        }



    }
}

