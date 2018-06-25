using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ServerApp.Data;

namespace ServerApp.Logic
{
    static class CommandExecutor
    {
        //GET DAY
        public static double ExecuteGetDayCommand(string user_id,string date) 
        {
            int userId = 0;
            DateTime day = DateTime.Now;
            if (!int.TryParse(user_id, out userId) || !DateTime.TryParse(date,out day))
            {
                throw new ArgumentException();
            }            
            return Storage.GetAverageRecordForDay(userId, day);
        }
        //ADD COMMAND
        public static bool ExecuteAddCommand(string user_idParam, string valueParam, string spend_forParam, string dateParam)
        {
            int user_id;
            float value;
            int spend_for;
            DateTime date;

            if (ValidateInput(user_idParam, valueParam, spend_forParam, dateParam, out user_id, out value, out spend_for, out date))
            {
                return Storage.AddRecord(user_id, value, spend_for, date);                
            }
            return false;
        }
        private static bool ValidateInput(string user_idParam, string valueParam, string spend_forParam, string dateParam, out int user_id,
            out float value,
            out int spend_for,
            out DateTime date)
        {
            if (!int.TryParse(user_idParam, out user_id))
            {
                value = 0;
                spend_for = 0;
                date = new DateTime();
                return false;
            }
            if (!float.TryParse(valueParam, out value))
            {
                spend_for = 0;
                date = new DateTime();
                return false;
            }
            if (!int.TryParse(spend_forParam, out spend_for))
            {
                date = new DateTime();
                return false;
            }
            if (!DateTime.TryParse(dateParam, out date))
            {
                return false;
            }
            return true;
        }

        internal static string ExecuteLoginCommand(string username, string password)
        {
            String response = Storage.IsUserExisting(username, password);
            return response == null? "no user" : response;
        }

        internal static string ExecuteReasonsCommand()
        {
            return Storage.GetReasons();
        }

        internal static double ExecuteTotalForMonthCommand(string user_id, string date)
        {
            int userId = 0;
            DateTime dateTime = DateTime.Now;
            if (!int.TryParse(user_id, out userId) || !DateTime.TryParse(date, out dateTime))
            {
                throw new ArgumentException();
            }
            return Storage.TotalForMonth(userId, dateTime);
        }

        internal static double ExecuteTotalForYearCommand(string user_id, string date)
        {
            int userId = 0;
            DateTime dateTime = DateTime.Now;
            if (!int.TryParse(user_id, out userId) || !DateTime.TryParse(date, out dateTime))
            {
                throw new ArgumentException();
            }
            return Storage.TotalForYear(userId, dateTime);
        }
        internal static String ExecuteCostsForReasonCommand(string user_id, string reason) 
        {
            int userId = 0;
            int reasonInt = 0;
            if (!int.TryParse(user_id, out userId) || !int.TryParse(reason, out reasonInt))
            {
                throw new ArgumentException();
            }
            return RecordsArrayToString(Storage.CostsForReason(userId, reasonInt));
        }

        private static String RecordsArrayToString(Record[] records)
        {
            StringBuilder builder = new StringBuilder();
            if(records.Length == 0)
            {
                return "No data";
            }
            foreach (Record current in records)
            {
                builder.Append(String.Format("{0:0.00}#{1}&", current.value, current.date.ToShortDateString()));
            }

            return builder.ToString();
        }
    }
}
