﻿using System;
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
            string updateQuery = "Update Medication Set MedicationName = '" + newMedication + "', DateStarted = '" + newDateStarted + "', Amount = '" + newAmount + "', Frequency = '" + newFrequency + "', Route = '" + newRoute + "' Where PatientID ='" + PatientID + "' AND MedicationName = '" + newMedication + "'AND DateStarted = '" + oldDateStarted + "' AND Amount = '" + oldAmount + "'AND Frequency = '" + oldFrequency + "'AND Route = '" + oldRoute + "';";
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

