using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Threading;
using System.ComponentModel;
using System.Windows.Forms;

namespace ExamKernel
{
    public class SQLiteDatabase
    {
        public string connectionString;
        //private SQLiteConnection sqlite;

        public SQLiteDatabase()
        {
            connectionString = "Data Source = ExamGenerator_DB.s3db; Version=3";
        }

        /// <summary>
        ///     Single Param Constructor for specifying the DB file.
        /// </summary>
        /// <param name="inputFile">The File containing the DB</param>
        public SQLiteDatabase(String inputFile)
        {
            connectionString = String.Format("Data Source={0}", inputFile);
        }

        /// <summary>
        ///     Single Param Constructor for specifying advanced connection options.
        /// </summary>
        /// <param name="connectionOpts">A dictionary containing all desired options and their values</param>
        public SQLiteDatabase(Dictionary<String, String> connectionOpts)
        {
            String str = "";
            foreach (KeyValuePair<String, String> row in connectionOpts)
            {
                str += String.Format("{0}={1}; ", row.Key, row.Value);
            }
            str = str.Trim().Substring(0, str.Length - 1);
            connectionString = str;
        }
        

        public string ExecuteScalar(string sql)
        {
            SQLiteConnection cnn = new SQLiteConnection(connectionString);
            cnn.Open();
            SQLiteCommand mycommand = new SQLiteCommand(cnn);
            mycommand.CommandText = sql;
            object value = mycommand.ExecuteScalar();
            cnn.Close();
            if (value != null)
            {
               return value.ToString();
            }
            else
            {
                return "";
            }
                
        }
       
    }
}