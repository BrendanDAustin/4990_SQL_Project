using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace _4990ExampleApp
{
    public partial class Form1 : Form
    {
        List < Panel > listPanel = new List < Panel > ();
        int Index;
        private BindingSource dfSource = new BindingSource();
        public Form1()
        {
            InitializeComponent();
            set_initial_status();
            listPanel.Add(signInPanel);
            listPanel.Add(appPanel);
        }
        public void set_initial_status()
        {

            bool Testing = true;
            goodOrBad.Checked = false;
            if (Testing)
            {
                userNameTextBox.Text = "BrendanAustin";
                passwordTextBox.Text = "BrendansLazyPassword";
            }
            else
            {
                userNameTextBox.Text = String.Empty;
                passwordTextBox.Text = String.Empty;
            }
            signInPanel.BringToFront();
            //signInPanel.Show();
            //appPanel.Hide();
            appPanel.SendToBack();
            userInfoGrid.DataSource = String.Empty;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

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
            string dbPath = System.IO.Path.Combine(
            AppDomain.CurrentDomain.BaseDirectory,
            "ExampleDB.accdb");

            string strDsn = String.Format(
                       "Provider=Microsoft.ACE.OLEDB.12.0; Data Source={0}",
                       dbPath);
            DataSet df = new DataSet();
            //string dbPath = "C:\\Users\\Brend\\Desktop\\Fall 2020\\CyberSecurity\\Project\\ExampleDB.accdb";
            string strSql = "SELECT * FROM Users WHERE UserName = '" + userName + "'";// AND Password = "+password;
            MessageBox.Show("SQL String Used for displaying personal data:\n" + strSql);
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

        private bool auth_user_bad_way(string userName, string password)
        {
            string dbPath = System.IO.Path.Combine(
            AppDomain.CurrentDomain.BaseDirectory,
            "ExampleDB.accdb");

            string strDsn = String.Format(
                       "Provider=Microsoft.ACE.OLEDB.12.0; Data Source={0}",
                       dbPath);
            DataSet users = new DataSet();
            //string dbPath = "C:\\Users\\Brend\\Desktop\\Fall 2020\\CyberSecurity\\Project\\ExampleDB.accdb";
            string strSql = "SELECT * FROM Users WHERE Users.[UserName] = '" + userName + "' AND Users.[Password] ='" + password+"'";
            //string strDsn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source =" + dbPath;
            OleDbConnection conn = new OleDbConnection(strDsn);
            conn.Open();

            using (OleDbCommand command = new OleDbCommand(strSql, conn))
            using (OleDbDataAdapter adapter = new OleDbDataAdapter(command))
            {
                adapter.Fill(users);
                conn.Close();
            }
            MessageBox.Show("SQL Select string constructed from user input:\n" + strSql);
            if (users.Tables[0].Rows.Count == 0)
                return false;
            else
                return true;
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
            string strSql = "SELECT * FROM Users WHERE Users.[UserName] = '" + userName + "' AND Users.[Password] ='" + password + "'";
            //string strDsn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source =C:\\Users\\Brend\\Desktop\\Fall 2020\\CyberSecurity\\Project\\ExampleDB.accdb";// + dbPath;
            //using (OleDbConnection conn = new OleDbConnection(strDsn))
            OleDbConnection conn = new OleDbConnection(strDsn);
            conn.Open();
            using (OleDbCommand command = new OleDbCommand(strSql, conn))
            using (OleDbDataAdapter adapter = new OleDbDataAdapter(command))
            {
                //conn.Open();
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
            if ((String.IsNullOrEmpty(userNameTextBox.Text)) | (String.IsNullOrEmpty(passwordTextBox.Text)))
            {
                MessageBox.Show("Uh Oh! You forgot to enter a field. Let's try that again.");
            }
            else
            {

                if (!goodOrBad.Checked)
                {
                    if (auth_user_bad_way(userNameTextBox.Text, passwordTextBox.Text))
                    {
                        get_data(userNameTextBox.Text);
                        goto_nextPage();
                    }
                    else
                    {
                        MessageBox.Show("You entered some bad information dude.");
                        set_initial_status();
                    }
                }
                else
                {
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
                }
            }
        }

        private void goodOrBad_CheckedChanged(object sender, EventArgs e)
        {
            if (goodOrBad.Checked)
                goodOrBad.Checked = false;
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
    }
}
