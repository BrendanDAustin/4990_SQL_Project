using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;
namespace _4990ExampleApp
{
    class queryMethods
    {
        static public string thisQuery;
        static private string strDsn;
        static private string dbName;
        //public bool showQuery;
        static private string get_str_dsn()
        {
            string fullDbName = dbName + ".accdb";
            string dbPath = System.IO.Path.Combine(
            AppDomain.CurrentDomain.BaseDirectory,
            fullDbName);
            string strDsn = String.Format(
                       "Provider=Microsoft.ACE.OLEDB.12.0; Data Source={0}",
                       dbPath);
            return strDsn;
        }
        private static string enteredUserName;
        private static string enteredPassword;
        private static string stored_username;
        private static bool displayCurrentQuery;
        Label queryLabel;
        public void update_query_label()
        {
            queryLabel.Text = thisQuery;
        }
        public bool no_validation_dual_query()
        {
            bool username_exists(string userName)
            {
                string strSql = "SELECT UserName FROM Users WHERE Users.[UserName] = '" + userName + "'";
                thisQuery = strSql;
                using (OleDbConnection conn = new OleDbConnection(strDsn))
                {
                    OleDbCommand user_command = new OleDbCommand(strSql, conn);
                    conn.Open();
                    try
                    {
                        OleDbDataReader reader = user_command.ExecuteReader();
                        reader.Read();
                        string foundVal = reader.GetValue(0).ToString();
                        reader.Close();
                        if (foundVal == userName)
                        {
                            stored_username = foundVal;
                            return true;
                        }
                        else
                            return false;
                    }
                    catch (System.Data.OleDb.OleDbException ex)
                    {
                        MessageBox.Show("SQL ERROR:\n" + ex.Message);
                        return false;
                    }
                }
            }
            bool correct_password(string password)
            {
                string strSql = "SELECT Password FROM Users WHERE Users.[UserName] = '"+stored_username+"' AND Users.[Password] = '" + password + "'";
                thisQuery = strSql;
                using (OleDbConnection conn = new OleDbConnection(strDsn))
                {
                    OleDbCommand user_command = new OleDbCommand(strSql, conn);
                    conn.Open();
                    try
                    {
                        OleDbDataReader reader = user_command.ExecuteReader();
                        reader.Read();
                        string foundVal = reader.GetValue(0).ToString();
                        reader.Close();
                        if (foundVal == password)
                        {
                            return true;
                        }
                        else
                            return false;
                    }
                    catch (System.Data.OleDb.OleDbException ex)
                    {
                        MessageBox.Show("SQL ERROR:\n" + ex.Message);
                        return false;
                    }
                }
            }
            if (username_exists(enteredUserName))
            {
                if (correct_password(enteredPassword))
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("Login Failed for username: " + stored_username);
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Username '" + enteredUserName + "' not found");
                return false;
            }
        }
        public bool no_validation()
        {
            string strSql = "SELECT * FROM Users WHERE Users.[UserName] = '"+enteredUserName+"' AND Users.[Password] = '"+enteredPassword+"'";
            thisQuery = strSql;
            if (displayCurrentQuery)
                update_query_label();
            OleDbConnection conn = new OleDbConnection(strDsn);
            conn.Open();
            using (OleDbCommand command = new OleDbCommand(strSql, conn))
            {
                //var userNameParam = new OleDbParameter("@UserName", enteredUserName);
                //MessageBox.Show("User Name Parameters:\n" + userNameParam.Value);
                //var passwordParam = new OleDbParameter("@Password", enteredPassword);
                //command.Parameters.Add(userNameParam);
                //command.Parameters.Add(passwordParam);
                try
                {
                    OleDbDataReader reader = command.ExecuteReader();
                    if (reader != null && reader.Read())
                    {
                        reader.Close();
                        reader.Dispose();
                        return true;
                    }
                    else
                    {
                        if (reader != null)
                        {
                            reader.Close();
                            reader.Dispose();
                            //MessageBox.Show("ERROR: Failed login for user; \n" + reader.GetString(0));
                        }
                        MessageBox.Show("ERROR: Failed login for user; \n" + enteredUserName);
                        return false;
                    }
                }
                catch (System.Data.OleDb.OleDbException ex)
                {
                    MessageBox.Show("ERROR:\n" + ex.Message);
                    conn.Close();
                    return false;
                }
            }
        }
        public bool character_validation()
        {
            bool has_illegal_chars(string input)
            {
                string[] illegals = { "OR", "AND", "WHERE", "'", "=", "*", " " };
                for (int i = 0; i < illegals.Length; i++)
                {
                    if (input.Contains(illegals[i]) == true)
                        return true;
                }
                return false;
            }
            if(has_illegal_chars(enteredUserName))
            {
                MessageBox.Show("Illegal Characters found in username. Try again.");
                thisQuery = "NONE - SQL command aborted due to funny business.";
                if (displayCurrentQuery)
                    update_query_label();
                return false;
            }
            if(has_illegal_chars(enteredPassword))
            {
                MessageBox.Show("Illegal Characters found in password. Try again.");
                thisQuery = "NONE - SQL command aborted due to funny business.";
                if (displayCurrentQuery)
                    update_query_label();
                return false;
            }
            return no_validation();
        }
        public bool driver_parameterizations()
        {
            //string dbPath = "C:\\Users\\Brend\\Desktop\\Fall 2020\\CyberSecurity\\Project\\ExampleDB.accdb";
            string strSql = "SELECT * FROM Users WHERE Users.[UserName] = ? AND Users.[Password] = ?";
            thisQuery = strSql;
            OleDbConnection conn = new OleDbConnection(strDsn);
            conn.Open();
            using (OleDbCommand command = new OleDbCommand(strSql, conn))
            {
                var userNameParam = new OleDbParameter("@UserName", enteredUserName);
                //MessageBox.Show("User Name Parameters:\n" + userNameParam.Value);
                var passwordParam = new OleDbParameter("@Password", enteredPassword);
                command.Parameters.Add(userNameParam);
                command.Parameters.Add(passwordParam);
                thisQuery = command.CommandText;
                if (displayCurrentQuery)
                    update_query_label();
                try
                {
                    OleDbDataReader reader = command.ExecuteReader();
                    if (reader != null && reader.Read())
                    {
                        reader.Close();
                        reader.Dispose();
                        //record found
                        return true;
                    }
                    else
                    {
                        if (reader != null)
                        {
                            reader.Close();
                            reader.Dispose();
                        }
                        MessageBox.Show("Invalid Entry. Please try again.");
                        return false;
                    }
                }
                catch (System.Data.OleDb.OleDbException ex)
                {
                    MessageBox.Show("ERROR:\n" + ex.Message);
                    conn.Close();
                    return false;
                }

            }
        }
        //public static bool execute_query()
        //{

        //}
        public queryMethods(string entered_name,string entered_pw,string database_name,bool display_query,ref Label query_label)
        {
            enteredUserName = entered_name;
            enteredPassword = entered_pw;
            dbName = database_name;
            strDsn = get_str_dsn();
            displayCurrentQuery = display_query;
            queryLabel = query_label;
        }
    }
}
