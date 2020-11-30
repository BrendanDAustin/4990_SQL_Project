﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
//using queryMethods;
//using _4990ExampleApp.queryMethods;
namespace _4990ExampleApp
{
    public partial class Form1 : Form
    {
        List < Panel > listPanel = new List < Panel > ();
        int Index;
        bool showQueryChecked = false;
        private BindingSource dfSource = new BindingSource();
        public void set_size()
        {
            this.Size = new Size(658, 615);
        }
        public Form1()
        {
            InitializeComponent();
            set_size();
            signInPanel.Location = new Point(45, 36);
            appPanel.Location = new Point(45, 36);
            newAccountPanel.Location = new Point(45, 36);
            set_initial_status();
            listPanel.Add(signInPanel);
            listPanel.Add(appPanel);
        }
        public void set_initial_status()
        {
            bool Testing = true;
            inputValidation.Checked = false;
            if (Testing)
            {
                newAccountName.Text = "HannerHider";
                newAccountPassword.Text = "HannasPassword";
                newAccountPasswordConfirm.Text = "HannasPasword";
                newFirstName.Text = "Hannah";
                newLastName.Text = "Hidy";
                newSsn.Text = "122-56-4585";
                //userNameTextBox.Text = "BrendanAustin";
                //userNameTextBox.Text = "' union select table_schema from information_schema.tables union select '1";
                //userNameTextBox.Text = "1' OR IN (SELECT MSysObjects.Name as table_name FROM MSysObjects WHERE (((Left([Name],1))<>\"~\") AND ((Left([Name],4))<>\"MSys\") AND ((MSysObjects.Type) In (1,4,6))) order by MSysObjects.Name) OR '1";
                //userNameTextBox.Text = "' union select table_schema from DB_NAME().tables union select '1";
                passwordTextBox.Text = "";
                userNameTextBox.Text = "";
                //passwordTextBox.Text = "' UNION SELECT NULL,DB_NAME(1),NULL--";
                
            }
            else
            {
                userNameTextBox.Text = String.Empty;
                passwordTextBox.Text = String.Empty;
            }
            signInPanel.BringToFront();
            appPanel.SendToBack();
            newAccountPanel.SendToBack();
            userInfoGrid.DataSource = String.Empty;
            queryDisplayLabel.Text = String.Empty;
            showQuery.Checked = false;
            //MessageBox.Show("Updated... Heres a box, boy");
        }
        private string get_str_dsn()
        {
            string dbPath = System.IO.Path.Combine(
            AppDomain.CurrentDomain.BaseDirectory,
            "ExampleDB.accdb");
            string strDsn = String.Format(
                       "Provider=Microsoft.ACE.OLEDB.12.0; Data Source={0}",
                       dbPath);
            return strDsn;
        }
        private bool bare_minimum_validation_lol(string name,string password)
        {
            bool nameOk = check_string(name);
            bool pwOk = check_string(password);
            if ((pwOk==false) | (nameOk==false))
            {
                MessageBox.Show("SQL Injection attempt detected. Don't be a jerk.");
                //set_initial_status();
                return false;
            }
            else
            {
                return auth_user_bad_way(name, password);
            }
        }
        private bool check_string(string input)
        {
            string[] illegals = { " OR ", " AND ", " WHERE ", "'", "=", "*"," "};
            for (int i = 0; i < illegals.Length; i++)
            {
                if (input.Contains(illegals[i]) == true)
                    return true;
            }
            return false;
        }
        private void get_data(string userName)
        {
            /*
            string dbPath = System.IO.Path.Combine(
            AppDomain.CurrentDomain.BaseDirectory,
            "ExampleDB.accdb");

            string strDsn = String.Format(
                       "Provider=Microsoft.ACE.OLEDB.12.0; Data Source={0}",
                       dbPath);
            */
            string strDsn = get_str_dsn();
            DataSet df = new DataSet();
            //string dbPath = "C:\\Users\\Brend\\Desktop\\Fall 2020\\CyberSecurity\\Project\\ExampleDB.accdb";
            string strSql = "SELECT * FROM Users WHERE UserName = '" + userName + "'";// AND Password = "+password;
            //MessageBox.Show("SQL String Used for displaying personal data:\n" + strSql);
            //string strDsn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source = " + dbPath;
            OleDbConnection myConn = new OleDbConnection(strDsn);
            OleDbDataAdapter myCmd = new OleDbDataAdapter(strSql, myConn);
            myConn.Open();
            myCmd.Fill(df, "Users");
            myConn.Close();
            if (df.Tables.Count > 0)
            {
                userInfoGrid.AutoGenerateColumns = true;
                dfSource.DataSource = df.Tables[0];
                userInfoGrid.DataSource = dfSource;
                userInfoGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                //userInfoGrid.DataBindings();
            }
            else
                userInfoGrid.DataSource = "No Info For you buddayyy";
            //return df;
        }
        private bool signin_with_reader()
        {
            string userName = userNameTextBox.Text;
            string password = passwordTextBox.Text;
            /*
            string dbPath = System.IO.Path.Combine(
            AppDomain.CurrentDomain.BaseDirectory,
            "ExampleDB_UPDATED.accdb");

            string strDsn = String.Format(
                       "Provider=Microsoft.ACE.OLEDB.12.0; Data Source={0}",
                       dbPath);
                       */
            string strDsn = get_str_dsn();
            string strSql = "SELECT UserName FROM Users WHERE Users.[UserName] = '" + userName + "' AND Users.[Password] ='" + password + "'";
            MessageBox.Show("Entered SQL command:\n" + strSql);
            List<string> found_user = new List<string>();
            string found_user_string = "";
            using (OleDbConnection conn = new OleDbConnection(strDsn))
            {
                OleDbCommand command = new OleDbCommand(strSql, conn);
                conn.Open();
                try
                {
                    OleDbDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        found_user.Add(reader[0].ToString());
                        found_user_string += reader[0].ToString() + "\n";
                    }
                    reader.Close();
                    if (!found_user.Contains(userName))
                    {
                        MessageBox.Show("Login failed for User: " + found_user_string);
                        return false;
                    }
                    else
                        return true;
                }
                catch(System.Data.OleDb.OleDbException ex)
                {
                    MessageBox.Show("ERROR:\n" + ex.Message);
                    return false;
                }

            }

        }
        private bool auth_user_bad_way(string userName, string password)
        {
            /*
            string dbPath = System.IO.Path.Combine(
            AppDomain.CurrentDomain.BaseDirectory,
            "ExampleDB.accdb");

            string strDsn = String.Format(
                       "Provider=Microsoft.ACE.OLEDB.12.0; Data Source={0}",
                       dbPath);
            */
            string strDsn = get_str_dsn();
            DataSet users = new DataSet();
            //string dbPath = "C:\\Users\\Brend\\Desktop\\Fall 2020\\CyberSecurity\\Project\\ExampleDB.accdb";
            string strSql = "SELECT * FROM Users WHERE Users.[UserName] = '" + userName + "' AND Users.[Password] ='" + password+"'";
            //string strDsn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source =" + dbPath;
            OleDbConnection conn = new OleDbConnection(strDsn);
            conn.Open();
            MessageBox.Show("Entered SqlString:\n" + strSql);
            using (OleDbCommand command = new OleDbCommand(strSql, conn))
            using (OleDbDataAdapter adapter = new OleDbDataAdapter(command))
            {
                try
                {
                    adapter.Fill(users);
                    conn.Close();
                    string query_results = "Query Results:\n";
                    foreach (DataRow row in users.Tables[0].Rows)
                    {
                        query_results += row[1].ToString() + "\n";
                    }
                    MessageBox.Show(query_results);
                    if (users.Tables[0].Rows.Count == 0)
                        return false;
                    else
                        return true;
                }
                catch(System.Data.OleDb.OleDbException ex)
                {
                    MessageBox.Show(ex.Message);
                    return false;
                }
            }
            //MessageBox.Show("SQL Select string constructed from user input:\n" + strSql);
            //MessageBox.Show("Failed to login as " + users.Tables[0]);
            //string query_results = users.Tables[0].Columns[0].ToString();

            /*
            string query_results = "Query Results:\n";
            foreach(DataRow row in users.Tables[0].Rows)
            {
                query_results += row[1].ToString() + "\n";
            }
            MessageBox.Show(query_results);
            if (users.Tables[0].Rows.Count == 0)
                return false;
            else
                return true;
            */
        }
        private bool auth_user_bad_way2(string userName, string password)
        {
            string strDsn = get_str_dsn();
            DataSet retrieved_users = new DataSet();
            DataSet retrieved_password = new DataSet();
            //string dbPath = "C:\\Users\\Brend\\Desktop\\Fall 2020\\CyberSecurity\\Project\\ExampleDB.accdb";
            string strSqlUser = "SELECT UserName FROM Users WHERE Users.[UserName] = '" + userName + "'";
            string strSqlPw = "SELECT Password FROM Users WHERE Users.[Password] = '" + password + "'";
            //string strDsn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source =" + dbPath;
            //OleDbConnection conn = new OleDbConnection(strDsn);
            //conn.Open();
            string found_user = "";
            string found_password = "";
            using (OleDbConnection conn = new OleDbConnection(strDsn))
            {
                OleDbCommand user_command = new OleDbCommand(strSqlUser, conn);
                conn.Open();
                try
                {
                    OleDbDataReader reader = user_command.ExecuteReader();
                    while (reader.Read())
                    {
                        //found_user.Add(reader[0].ToString());
                        found_user += reader[0].ToString() + "\n";
                    }
                    reader.Close();
                    if (!found_user.Contains(userName))
                    {
                        MessageBox.Show("Login failed for User: " + found_user);
                        return false;
                    }
                    else
                        return true;
                }
                catch (System.Data.OleDb.OleDbException ex)
                {
                    MessageBox.Show("ERROR:\n" + ex.Message);
                    return false;
                }
                /*
                OleDbCommand pw_command = new OleDbCommand(strSqlPw, conn);
                conn.Open();
                try
                {
                    OleDbDataReader pw_reader = pw_command.ExecuteReader();
                    while (reader.Read())
                    {
                        //found_user.Add(reader[0].ToString());
                        found_user += reader[0].ToString() + "\n";
                    }
                    reader.Close();
                    if (!found_user.Contains(userName))
                    {
                        MessageBox.Show("Login failed for User: " + found_user);
                        return false;
                    }
                    else
                        return true;
                }
                catch (System.Data.OleDb.OleDbException ex)
                {
                    MessageBox.Show("ERROR:\n" + ex.Message);
                    return false;
                }
                */
            }
            
            /*
            using (OleDbCommand command = new OleDbCommand(strSqlUser, conn))
            using (OleDbDataAdapter adapter = new OleDbDataAdapter(command))
            {
                try
                {
                    adapter.Fill(users);
                    conn.Close();
                    string query_results = "Query Results:\n";
                    foreach (DataRow row in users.Tables[0].Rows)
                    {
                        query_results += row[1].ToString() + "\n";
                    }
                    MessageBox.Show(query_results);
                    if (users.Tables[0].Rows.Count == 0)
                        return false;
                    else
                        return true;
                }
                catch (System.Data.OleDb.OleDbException ex)
                {
                    MessageBox.Show(ex.Message);
                    return false;
                }
            }
            */
            //MessageBox.Show("SQL Select string constructed from user input:\n" + strSql);
            //MessageBox.Show("Failed to login as " + users.Tables[0]);
            //string query_results = users.Tables[0].Columns[0].ToString();

            /*
            string query_results = "Query Results:\n";
            foreach(DataRow row in users.Tables[0].Rows)
            {
                query_results += row[1].ToString() + "\n";
            }
            MessageBox.Show(query_results);
            if (users.Tables[0].Rows.Count == 0)
                return false;
            else
                return true;
            */
        }
        private bool auth_user_good_way(string userName,string password)
        {
            string dbPath = System.IO.Path.Combine(
            AppDomain.CurrentDomain.BaseDirectory,
            "ExampleDB.accdb");

            string strDsn = String.Format(
                       "Provider=Microsoft.ACE.OLEDB.12.0; Data Source={0}",
                       dbPath);
            DataSet users = new DataSet();
            //string dbPath = "C:\\Users\\Brend\\Desktop\\Fall 2020\\CyberSecurity\\Project\\ExampleDB.accdb";
            string strSql = "SELECT * FROM Users WHERE Users.[UserName] = ? AND Users.[Password] = ?";
            OleDbConnection conn = new OleDbConnection(strDsn);
            conn.Open();
            using (OleDbCommand command = new OleDbCommand(strSql, conn))
            using (OleDbDataAdapter adapter = new OleDbDataAdapter(command))
            {
                var userNameParam = new OleDbParameter("@UserName", userName);
                //MessageBox.Show("User Name Parameters:\n" + userNameParam.Value);
                var passwordParam = new OleDbParameter("@Password", password);
                command.Parameters.Add(userNameParam);
                command.Parameters.Add(passwordParam);
                adapter.Fill(users);
                conn.Close();
            }
            if (users.Tables[0].Rows.Count == 0)
                return false;
            //MessageBox.Show("Num Rows Returned:\n" + numRows.ToString());
            else
                return true;
        }
        private void goto_nextPage()
        {
            if (Index < listPanel.Count - 1)
                listPanel[++Index].BringToFront();
            /*
            signInPanel.Hide();
            signInPanel.SendToBack();
            appPanel.BringToFront();
            appPanel.Show();
            appPanel.BringToFront();
            */
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //var buttons = techniqueSelectionGroup.Controls.OfType<RadioButton>()
            //   .FirstOrDefault(n => n.Checked);
            //MessageBox.Show("Group box buttons: " + buttons.ToString() + "\n Length of buttons: " + buttons.Size.ToString());
            queryMethods query_method = new queryMethods(userNameTextBox.Text, passwordTextBox.Text, "ExampleDB", showQuery.Checked, ref queryDisplayLabel);
            bool isGood = false;
            if (noValidationCheckbox.Checked)
            {
                isGood = query_method.no_validation();
                /*
                    if (auth_user_bad_way(userNameTextBox.Text, passwordTextBox.Text))
                    //if (signin_with_reader())
                    {
                        get_data(userNameTextBox.Text);
                        goto_nextPage();
                    }
                    else
                    {
                        MessageBox.Show("You entered some bad information dude.");
                        set_initial_status();
                    }
                    */
            }
            if(storedProcedure.Checked)
            {
                isGood = query_method.driver_parameterizations();
                /*
                if(auth_user_good_way(userNameTextBox.Text,passwordTextBox.Text))
                {
                    get_data(userNameTextBox.Text);
                    goto_nextPage();
                }
                else
                {
                    MessageBox.Show("You entered some bad information dude.");
                    set_initial_status();
                }
                */
            }
            if(inputValidation.Checked)
            {
                isGood = query_method.character_validation();
                /*
                //bool inputsGood = bare_minimum_validation_lol(userNameTextBox.Text, passwordTextBox.Text);
                if (bare_minimum_validation_lol(userNameTextBox.Text,passwordTextBox.Text))
                {
                    get_data(userNameTextBox.Text);
                    goto_nextPage();
                }
                else
                {
                    MessageBox.Show("You entered some bad information dude.");
                    set_initial_status();
                }
                */
            }
            if(isGood)
            {
                get_data(userNameTextBox.Text);
                goto_nextPage();
            }
            else
            {
                set_initial_status();
            }
        }

        private void goodOrBad_CheckedChanged(object sender, EventArgs e)
        {
            if (inputValidation.Checked)
                inputValidation.Checked = false;
        }

        private void returnHomeButton_Click(object sender, EventArgs e)
        {
            set_initial_status();
        }

        private void returnHomeButton_Click_1(object sender, EventArgs e)
        {
            set_initial_status();
            if (Index > 0)
                listPanel[--Index].BringToFront();
        }

        private void signInPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void goodOrBad_CheckedChanged_1(object sender, EventArgs e)
        {

        }
        private void set_newAccound_name_blank()
        {
            newAccountName.Text = "";
        }
        private void set_newAccount_passwords_blank()
        {
            newAccountPassword.Text = "";
            newAccountPasswordConfirm.Text = "";
        }
        private void goto_newAccount()
        {
            set_newAccound_name_blank();
            set_newAccount_passwords_blank();
            for (int i = 0; i < listPanel.Count; i++)
                listPanel[i].SendToBack();
            newAccountPanel.Visible = true;
            newAccountPanel.BringToFront();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            goto_newAccount();
        }
        private bool new_user_name(string newName)
        {
            /*
            string dbPath = System.IO.Path.Combine(
                        AppDomain.CurrentDomain.BaseDirectory,
                        "ExampleDB.accdb");

            string strDsn = String.Format(
                       "Provider=Microsoft.ACE.OLEDB.12.0; Data Source={0}",
                       dbPath);
            */
            string strDsn = get_str_dsn();
            DataSet users = new DataSet();
            string strSql = "SELECT UserName FROM Users";// WHERE Users.[UserName] = '" + userName + "' AND Users.[Password] ='" + password + "'";
            OleDbConnection conn = new OleDbConnection(strDsn);
            conn.Open();
            using (OleDbCommand command = new OleDbCommand(strSql, conn))
            using (OleDbDataAdapter adapter = new OleDbDataAdapter(command))
            {
                adapter.Fill(users);
                conn.Close();
            }
            DataRow[] foundRows;
            //foundRows = users.Tables["Users"].Select("UserName = " + newName);
            string selectExpression = String.Format("UserName = '{0}'", newName);
            foundRows = users.Tables[0].Select(selectExpression);
            if(foundRows.Count()>0)
            {
                MessageBox.Show("Username (" + newName + ") is already taken.\nPlease select a different name");
                set_newAccound_name_blank();
                return false;
            }
            return true;
        }
        private bool newAccount_passwords_match(string password1,string password2)
        {
            if (password1 == password2)
                return true;
            else
            {
                MessageBox.Show("Passwords do not match.\nLet's try again.");
                set_newAccount_passwords_blank();
                return false;
            }
        }

        private bool all_fields_filled()
        {
            List<object> newAccountItems = new List<object>();
            newAccountItems.Add(newFirstName);
            newAccountItems.Add(newLastName);
            newAccountItems.Add(newAccountName);
            newAccountItems.Add(newAccountPassword);
            newAccountItems.Add(newAccountPasswordConfirm);
            string enteredSsn = newSsn.ToString();
            for (int i = 0; i < enteredSsn.Length; i++)
            {
                if (enteredSsn[i] == '_')
                {
                    MessageBox.Show("Social Security Number Field invalid.");
                    return false;
                }
            }
            for (int i = 0; i < newAccountItems.Count; i++)
            {
                if ((newAccountItems[i].ToString() == "") | (String.IsNullOrEmpty(newAccountItems[i].ToString())))
                {
                    MessageBox.Show("Required Textbox Field Missing");
                    return false;
                }
            }
            return true;
        }

        private void create_new_account(string user, string pw, string firstName, string lastName, string SSN)
        {
            /*
            string dbPath = System.IO.Path.Combine(
             AppDomain.CurrentDomain.BaseDirectory,
             "ExampleDB.accdb");

            string strDsn = String.Format(
                       "Provider=Microsoft.ACE.OLEDB.12.0; Data Source={0}",
                       dbPath);
                       */
            string strDsn = get_str_dsn();
            string strSql = String.Format("INSERT INTO Users (UserName, [Password], FirstName, LastName, SSN) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}')", user, pw, firstName, lastName, SSN);
            OleDbConnection conn = new OleDbConnection(strDsn);
            OleDbCommand command = new OleDbCommand(strSql, conn);
            conn.Open();
            command.ExecuteNonQuery();
            conn.Close();
        }
        private void returnToMainFromNewAccount_Click(object sender, EventArgs e)
        {
            set_initial_status();
        }

        private void newAccountPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void returnToMainFromNewAccount_Click_1(object sender, EventArgs e)
        {
            //MessageBox.Show("ssn: " + newSsn.TextLength.ToString());
            set_newAccound_name_blank();
            set_newAccount_passwords_blank();
            set_initial_status();
        }

        private void createAccount_Click(object sender, EventArgs e)
        {
            if (all_fields_filled() == false)
                return;
            if ((newAccount_passwords_match(newAccountPassword.Text, newAccountPasswordConfirm.Text) == false) |
                (new_user_name(newAccountName.Text) == false))
            {
                return;
            }
            else
            {
                create_new_account(newAccountName.Text, newAccountPassword.Text, newFirstName.Text, newLastName.Text, newSsn.Text);
                set_initial_status();
                return;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void showQuery_CheckedChanged(object sender, EventArgs e)
        {
            showQueryChecked = showQuery.Checked;
            //if (showQuery.Checked==true)
            //    showQuery.Checked = false;
            //if (showQuery.Checked == false)
            //    showQuery.Checked = true;
        }
        private void showQuery_Click(object sender, EventArgs e)
        {
            if (showQuery.Checked && !showQueryChecked)
                showQuery.Checked = false;
            else
            {
                showQuery.Checked = true;
                showQueryChecked = false;
            }
        }
    }

}
