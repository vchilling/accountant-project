﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace ServerApp.Data
{
    static class Storage
    {
        private static String[] reasons = new String[]
        {
            "Food",
            "Bills",
            "Presents",
            "Shoes",
            "Clothes",
            "Accessories",
            "Furnitures",
            "Car Parts"
        };
        //Public Methods
        public static string IsUserExisting(string username, string password)
        {
            return _IsUserPassCorrect(username, password);
        }
        public static bool AddRecord(int user_id, float value, int spend_for, DateTime date)
        {
            if (_IsInputCorrect(user_id, value, spend_for, date))
            {
                return _AddRecord(user_id, value, spend_for, date);
            }
            return false;
        }
        public static double GetAverageRecordForDay(int user_id, DateTime date)
        {
            return _GetAverageRecordForDay(user_id, date);
        }
        //Private Methods
        private static string _IsUserPassCorrect(string username, string password)
        {
            DataClassesDataContext dc = new DataClassesDataContext();
            var queryResult = (from users in dc.GetTable<User>()
                               where (users.Name == username) &&
                               (users.Password == password)
                               select users).ToArray<User>();
            if (queryResult.Count<User>() > 0)
            {
                User current = (queryResult.GetValue(0) as User);
                return String.Format("{0} {1}", current.Name, current.Id);
            }
            return null;
        }
        private static bool _IsInputCorrect(int user_id, float value, int spend_for, DateTime date)
        {
            if (user_id < 0)
            {
                return false;
            }
            if (spend_for < 0)
            {
                return false;
            }
            return true;
        }
        private static bool _AddRecord(int user_id, float value, int spend_for, DateTime date)
        {
            using (SqlConnection connection = new SqlConnection(ServerApp.Properties.Settings.Default.AccountantDBConnectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(null, connection);

                // Create and prepare an SQL statement.
                command.CommandText =
                    "INSERT INTO Records (user_id, value, spend_for, date)" +
                "VALUES (@user_id, @value, @spend_for, @date)";
                SqlParameter user_idParam = new SqlParameter("@user_id", SqlDbType.Int, 0);
                SqlParameter valueParam =
                    new SqlParameter("@value", SqlDbType.Float, 100);
                SqlParameter spend_forParam =
                    new SqlParameter("@spend_for", SqlDbType.Int, 100);
                SqlParameter dateParam =
                    new SqlParameter("@date", SqlDbType.DateTime, 100);
                user_idParam.Value = user_id;
                valueParam.Value = value;
                spend_forParam.Value = spend_for;
                dateParam.Value = date;
                command.Parameters.Add(user_idParam);
                command.Parameters.Add(valueParam);
                command.Parameters.Add(spend_forParam);
                command.Parameters.Add(dateParam);
                // Call Prepare after setting the Commandtext and Parameters.
                command.Prepare();
                if (command.ExecuteNonQuery() < 0)
                {
                    return false;
                }
                return true;
            }
        }
        private static double _GetAverageRecordForDay(int user_id, DateTime date)
        {
            DataClassesDataContext dc = new DataClassesDataContext();
            var queryResult = (from records in dc.GetTable<Record>()
                               where (records.user_id == user_id) && (records.date.Date == date.Date)
                               select records.value).Average();
            return queryResult;
        }

        internal static string GetReasons()
        {
            StringBuilder builder = new StringBuilder();
            foreach (string value in reasons)
            {
                builder.Append(value);
                builder.Append('.');
            }
            return builder.ToString();
        }

        internal static double TotalForMonth(int userId, DateTime date)
        {
            DataClassesDataContext dc = new DataClassesDataContext();
            var queryResult = (from records in dc.GetTable<Record>()
                               where (records.user_id == userId) && (records.date.Date.Month == date.Date.Month)
                               && (records.date.Date.Year == date.Date.Year)
                               select records.value).Sum();
            return queryResult;
        }

        internal static double TotalForYear(int userId, DateTime date)
        {
            DataClassesDataContext dc = new DataClassesDataContext();
            var queryResult = (from records in dc.GetTable<Record>()
                               where (records.user_id == userId) && (records.date.Date.Year == date.Date.Year)
                               select records.value).Sum();
            return queryResult;
        }

        internal static Record[] CostsForReason(int userId, int reason)
        {
            DataClassesDataContext dc = new DataClassesDataContext();
            var queryResult = (from records in dc.GetTable<Record>()
                               where (records.user_id == userId) && (records.spend_for == reason)
                               select records).ToArray<Record>();
            return queryResult;
        }
    }
}

