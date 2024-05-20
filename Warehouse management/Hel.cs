using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Net.Mail;
using System.Net;
using System.Reflection;
using System.Windows.Forms.VisualStyles;
using System.Net.NetworkInformation;

namespace Warehouse_management
{
    public class User
    {
        private string userName;
        private string password;
        private string email;
        private bool isAdmin;
        public User(string userName, string password, string email, bool isAdmin)
        {
            UserName = userName;
            Password = password;
            Email = email;
            IsAdmin = isAdmin;
        }

        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }
        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public bool IsAdmin
        {
            get { return isAdmin; }
            set { isAdmin = value; }
        }

    }
    public static class InternetCheaker
    {
        public static bool Cheak()//צריך לחבר את הבדיקה לתוכנית
        {
            try
            {
                Ping ping = new Ping();
                PingReply reply = ping.Send("www.google.com");

                if (reply.Status == IPStatus.Success)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show("שגיאה בבדיקת החיבור לאינטרנט: " + ex.Message);
                return false;
            }
        }
    }
    public static class LoginRightNow
    {
        static bool LoginStatus;
        static string Username_Login;
        public static string GetUsername_Login()
        {
            return Username_Login;
        }
        public static bool GetLoginStatus()
        {
            return LoginStatus;
        }
        public static void LoginStatusToFalse()
        {
            LoginStatus = false;
        }
        public static void ChangeStatus(string status)
        {
            if (status == "SADMIN")
            {
                LoginStatus = true;
            }
            else if (status == "SUSER")
            {
                LoginStatus = false;
            }
            else
            {
                MessageBox.Show("Error with The Status");
                LoginStatus = false;
            }

        }
        public static void SetUserNameLogin(string userName)
        {
            Username_Login = userName;
        }
        public static void UpdateData()
        {
            string[,] DataOrder = Hellp_DATABASE_ORDER.GetFromDataBaseOrderProduct();
            for (int i = 0; i < DataOrder.GetLength(0); i++)
            {
                if (Hellp_expiry_Sintax.DateOrderGetOrNot(DataOrder[i, 5]))
                {//0,1 = type, 0,2 = company , 0,3 = name , 0,4 = tokef 
                    if (Hellp_DATABASE_PRODUCT.SendParameterDataBaseProduct(DataOrder[i, 1], DataOrder[i, 2], DataOrder[i, 3], DataOrder[i, 4]))
                    {
                        try
                        {
                            Hellp_DATABASE_ORDER.deleteRowOrderProducts(DataOrder[i, 0]);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error with deleting from ORDER PRUDUCT TABLE ");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error with the Sending from ORDER TABLE to PRUDUCT TABLE");
                    }
                }
            }
            string[,] DataPruduct = Hellp_DATABASE_PRODUCT.GetFromDataBaseProduct();
            for (int i = 0; i < DataPruduct.GetLength(0); i++)
            {
                if (Hellp_expiry_Sintax.cheakThePruductDateBroken(DataPruduct[i, 4]))
                {//0,1 = type, 0,2 = company , 0,3 = name , 0,4 = tokef 
                    try
                    {
                        Hellp_DATABASE_PRODUCT.deleteRowProducts((DataPruduct[i, 0]));
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error with deleting from ORDER PRUDUCT TABLE ");
                    }
                }
            }
        }
    }
    public static class Hellp_DATABASE_USERS
    {
        static string connectionString = $"Data Source=sql.bsite.net\\MSSQL2016;Initial Catalog=eyallavi_SampleDB;Persist Security Info=True;User ID=eyallavi_SampleDB;Password={Properties.Resources.KeyConnectionStringDB}";
        public static string Encryption(string str) // מצפין sha512
        {
            SHA512 sha512 = SHA512.Create();
            byte[] hash = Encoding.UTF8.GetBytes(str);
            hash = sha512.ComputeHash(hash);
            string result = BitConverter.ToString(hash).Replace("-", "");
            return result;
        }
        /*public static string[,] GetFromDataBaseUsers()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string query = "SELECT * FROM UsersTableMange";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            // Get the number of columns and rows in the result set
            int numColumns = reader.FieldCount;
            int numRows = 0;
            while (reader.Read())
            {
                numRows++;
            }

            // Create a 2D string array to hold the data
            string[,] data = new string[numRows, numColumns];

            // ResetText the reader and read the data into the array
            reader.Close();
            reader = command.ExecuteReader();
            int row = 0;
            while (reader.Read())
            {
                for (int col = 0; col < numColumns; col++)
                {
                    data[row, col] = reader[col].ToString();
                }
                row++;
            }

            reader.Close();
            connection.Close();
            return data;
        }//קבלת כל הדאטא משתמשים*/
        public static string[,] ifHaveThisUsernameReturnOnlyHimData_UserName(string username)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string query = $"SELECT * FROM UsersTableMange WHERE USERNAME = '{username}'";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            // Get the number of columns and rows in the result set
            int numColumns = reader.FieldCount;
            int numRows = 0;

            if (reader.Read() == true)
            {
                reader.Close();
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    numRows++;
                }
                string[,] data = new string[numRows, numColumns];

                // ResetText the reader and read the data into the array
                reader.Close();
                reader = command.ExecuteReader();
                int row = 0;
                while (reader.Read())
                {
                    for (int col = 0; col < numColumns; col++)
                    {
                        data[row, col] = reader[col].ToString();
                    }
                    row++;
                }

                reader.Close();
                connection.Close();
                return data;
            }
            reader.Close();
            connection.Close();
            return null;

        }//בודק האם יש משתמש כזה אם כן מחזירה את כל השורה של המידע שלו 
        public static bool SendParameterDataBaseUsers(string UserName, string Password, string Status, string Email)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlCommand sqlCmd = new SqlCommand("UserAdd", sqlCon);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@USERNAME", UserName);
                sqlCmd.Parameters.AddWithValue("@PASSWORD", Encryption(Password));
                sqlCmd.Parameters.AddWithValue("@STATUS", Status);
                sqlCmd.Parameters.AddWithValue("@EMAIL", Email);
                sqlCmd.ExecuteNonQuery();
                return true;
            }
            return false;
        }//שליחת משתמש חדש
        /*public static string WhyCannotRegister(string UserName, string Email)
        {
            string[,] data = GetFromDataBaseUsers();
            string cheak = String.Empty;
            for (int i = 0; i < data.GetLength(0); i++) // בדיקה האם קיים השם משתמש כבר במאגר
            {
                if (data[i, 1] != null && data[i, 1] == UserName)
                {
                    cheak += $"Have UserName with this UserName value :{data[i, 1]} ,";
                    break;
                }
            }
            for (int i = 0; i < data.GetLength(0); i++)// בדיקה האם קיים האיימל כבר במאגר
            {
                if (data[i, 4] != null && data[i, 4] == Email)
                {
                    cheak += $"\nand have Email with this Email value :{data[i, 4]} ,";
                    break;
                }
            }
            return cheak;
        }//בדיקה תקניות מבחנית כפילויות בדאטא הרשמת משתמש*/
        public static bool CheakLogIn(string UserName, string Password)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string query = $"SELECT * FROM UsersTableMange WHERE USERNAME = '{UserName}' AND PASSWORD = '{Encryption(Password)}'";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            // Get the number of columns and rows in the result set
            int numColumns = reader.FieldCount;
            int numRows = 0;

            if (reader.Read() == true)
            {
                reader.Close();
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    numRows++;
                }
                string[,] data = new string[numRows, numColumns];

                // ResetText the reader and read the data into the array
                reader.Close();
                reader = command.ExecuteReader();
                int row = 0;
                while (reader.Read())
                {
                    for (int col = 0; col < numColumns; col++)
                    {
                        data[row, col] = reader[col].ToString();
                    }
                    row++;
                }
                LoginRightNow.ChangeStatus(data[0, 3]);
                LoginRightNow.SetUserNameLogin(data[0, 1]);
                reader.Close();
                connection.Close();
                return true;
            }
            reader.Close();
            connection.Close();
            return false;

        }//בדיקת התחברות
        public static bool CheakHaveUserNameLikeThis(string UserName)
        {
            if(UserName!=null&&UserName!=string.Empty)
            {
                SqlConnection connection = new SqlConnection(connectionString);
                string query = $"SELECT * FROM UsersTableMange WHERE USERNAME = '{UserName}'";
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    reader.Close();
                    connection.Close();
                    return true;
                }
                reader.Close();
                connection.Close();
            }

            return false;
        }//בדיקת האם קיים שם משתמש כזה ברשימת המשתמשים
        /*public static bool CheakHaveEmailAndUserNameOnDataAndDoIt(string userName , string email)
        {
            string[,] data = GetFromDataBaseUsers();
            string delID = null;
            int index = -1;
            for (int i = 0; i < data.GetLength(0); i++)
            {
                if (data[i, 1] == userName && data[i,4]==email)
                {
                    delID = data[i, 0];
                    index= i; 
                    break;
                    //return true;
                }
            }
            if(delID != null)
            {
                string newPass = RandomPassword();
                if (SendEmailWithPassword(data[index,4],newPass))
                {
                    if(SendParameterDataBaseUsers(data[index, 1],newPass, data[index, 3], data[index, 4]))
                    {
                        deleteRowUser(delID);
                        return true;
                    }
                }
                
            }
            return false;
        }*/
        public static bool CheakHaveEmailAndUserNameOnDataAndDoIt2(string userName, string email)
        {
                string[,] data = ifHaveThisUsernameReturnOnlyHimData_UserName(userName);
                if (data != null)
                {
                    if (data[0, 4] == email)
                    {
                        string newPass = RandomPassword();
                        if (SendEmailWithPassword(data[0, 4], newPass))
                        {
                            if (SendParameterDataBaseUsers(data[0, 1], newPass, data[0, 3], data[0, 4]))
                            {
                                deleteRowUser(data[0, 0]);
                                return true;
                            }
                        }
                    }
                }
            return false;
        }
        public static string RandomPassword()
        {
            string a = string.Empty;
            Random rand = new Random();
            for (int i = 0; i < 3; i++)
            {
                a += (char)rand.Next(65, 90);
                a += rand.Next(1, 10);
            }
            return a;
        }
        public static bool SendEmailWithPassword(string to_Email, string body) // פונרצית שליחת מייל
        {

            MailMessage message = new MailMessage();
            message.From = new MailAddress("mailautoforeyal@gmail.com");
            message.To.Add(to_Email);
            message.Subject = "Your new Password";
            message.Body = body;
            message.IsBodyHtml = false;
            SmtpClient client = new SmtpClient();
            client.Host = "smtp.gmail.com";
            client.Port = 587;
            client.EnableSsl = true;
            client.UseDefaultCredentials = false;                         // MailSenderOne / Properties /Resources מיקום הצופן
            client.Credentials = new NetworkCredential("mailautoforeyal@gmail.com", Properties.Resources.KeyMailSender);//מוצפן 
            try
            {
                client.Send(message);
                return true;
            }

            catch (Exception)
            {
                return false;
            }


        }
        public static void deleteRowUser(string IDUser)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    using (SqlCommand command = new SqlCommand("DELETE FROM UsersTableMange WHERE ID = '" + IDUser + "'", con))//לבדוק תקינות
                    {
                        command.ExecuteNonQuery();
                    }
                    con.Close();
                }
            }
            catch (SystemException ex)
            {
                MessageBox.Show(string.Format("An error occurred: {0}", ex.Message));
            }
        }// מחיקת שורה מהדאטא
        public static bool ChangePasswordInTheApp(string oldPASSWORD,string newPASSWORD)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string query = $"SELECT * FROM UsersTableMange WHERE USERNAME = '{LoginRightNow.GetUsername_Login()}'";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            int numColumns = reader.FieldCount;
            int numRows = 1;

            string[,] data = new string[numRows, numColumns];

            reader.Close();
            reader = command.ExecuteReader();
            int row = 0;
            while (reader.Read())
            {
                for (int col = 0; col < numColumns; col++)
                {
                    data[row, col] = reader[col].ToString();
                }
                row++;
            }

            reader.Close();
            connection.Close();
            if (data[0, 2] == Encryption(oldPASSWORD)&&CheakSyntaxPass(newPASSWORD))
            {
                deleteRowUser(data[0, 0]);
                if(SendParameterDataBaseUsers(data[0, 1], newPASSWORD , data[0, 3], data[0, 4]))
                {
                    return true;
                }
            }
            return false;
        }
        public static bool CheakSyntaxPass(string password)
        {
            if(password!=null&&password!=string.Empty)
            {
                int counter = 0;
                for (int i = 0; i < password.Length; i++)
                {
                    if (password[i] >= 'A' && password[i] <= 'Z' || password[i] >= 'a' && password[i] <= 'z' || password[i] >= '0' && password[i] <= '9')
                    {
                        counter++;
                    }
                }
                if (counter == password.Length)
                {
                    return true;
                }
            }
            return false;
        }

    }
    public static class Hellp_DATABASE_PRODUCT
    {
        static string connectionString = $"Data Source=sql.bsite.net\\MSSQL2016;Initial Catalog=eyallavi_SampleDB;Persist Security Info=True;User ID=eyallavi_SampleDB;Password={Properties.Resources.KeyConnectionStringDB}";

        public static string[,] GetFromDataBaseProduct()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string query = "SELECT * FROM ProductTable";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            // Get the number of columns and rows in the result set
            int numColumns = reader.FieldCount;
            int numRows = 0;
            while (reader.Read())
            {
                numRows++;
            }

            // Create a 2D string array to hold the data
            string[,] data = new string[numRows, numColumns];

            // ResetText the reader and read the data into the array
            reader.Close();
            reader = command.ExecuteReader();
            int row = 0;
            while (reader.Read())
            {
                for (int col = 0; col < numColumns; col++)
                {
                    data[row, col] = reader[col].ToString();
                }
                row++;
            }

            reader.Close();
            connection.Close();
            return data;
        }//קבלת כל הדאטא מוצרים
        public static bool SendParameterDataBaseProduct(string ProductType, string ProductCompany, string ProductName, string Expiry_Date)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlCommand sqlCmd = new SqlCommand("ProductAdd", sqlCon);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@PRODUCT_TYPE", ProductType);
                sqlCmd.Parameters.AddWithValue("@PRODUCT_COMPANY", ProductCompany);
                sqlCmd.Parameters.AddWithValue("@PRODUCT_NAME", ProductName);
                sqlCmd.Parameters.AddWithValue("@EXPIRY_DATE", Expiry_Date);
                sqlCmd.ExecuteNonQuery();
                return true;
            }
            return false;
        }//שליחת משתמש חדש
        public static void deleteRowProducts(string IDProduct)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    using (SqlCommand command = new SqlCommand("DELETE FROM ProductTable WHERE ID = '" + IDProduct + "'", con))//לבדוק תקינות
                    {
                        command.ExecuteNonQuery();
                    }
                    con.Close();
                }
            }
            catch (SystemException ex)
            {
                MessageBox.Show(string.Format("An error occurred: {0}", ex.Message));
            }
        }// מחיקת שורה מהדאטא
        /*public static int LenRows()
        {
            SqlConnection connection = new SqlConnection(connectionString);

            string query = "SELECT * FROM ProductTable";

            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            return reader.FieldCount;
        }*/
        public static string[,] GetAllDataID(string id)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string query = $"SELECT * FROM ProductTable WHERE ID = '{id}'";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            // Get the number of columns and rows in the result set
            int numColumns = reader.FieldCount;
            int numRows = 0;

            if (reader.Read() == true)
            {
                reader.Close();
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    numRows++;
                }
                string[,] data = new string[numRows, numColumns];

                // ResetText the reader and read the data into the array
                reader.Close();
                reader = command.ExecuteReader();
                int row = 0;
                while (reader.Read())
                {
                    for (int col = 0; col < numColumns; col++)
                    {
                        data[row, col] = reader[col].ToString();
                    }
                    row++;
                }

                reader.Close();
                connection.Close();
                return data;
            }
            reader.Close();
            connection.Close();
            return null;
        }
    }
    public static class Hellp_DATABASE_COMPANY
    {
        static string connectionString = $"Data Source=sql.bsite.net\\MSSQL2016;Initial Catalog=eyallavi_SampleDB;Persist Security Info=True;User ID=eyallavi_SampleDB;Password={Properties.Resources.KeyConnectionStringDB}";
        public static string[,] GetFromDatabaseCompany()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string query = "SELECT * FROM CompaniesTable";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            // Get the number of columns and rows in the result set
            int numColumns = reader.FieldCount;
            int numRows = 0;
            while (reader.Read())
            {
                numRows++;
            }

            // Create a 2D string array to hold the data
            string[,] data = new string[numRows, numColumns];

            // ResetText the reader and read the data into the array
            reader.Close();
            reader = command.ExecuteReader();
            int row = 0;
            while (reader.Read())
            {
                for (int col = 0; col < numColumns; col++)
                {
                    data[row, col] = reader[col].ToString();
                }
                row++;
            }

            reader.Close();
            connection.Close();
            return data;
        }//קבלת כל הדאטא חברות
        public static bool SendParameterDataBaseCompany(string Company)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlCommand sqlCmd = new SqlCommand("CompanyAdd", sqlCon);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@COMPANY", Company);
                sqlCmd.ExecuteNonQuery();
                return true;
            }
            return false;
        }//שליחת חברה חדשה
        public static bool CheakIfCompanyHaveOnDataBase(string Company)
        {
            string[,] data = GetFromDatabaseCompany();
            for (int i = 0; i < data.GetLength(0); i++)
            {
                if (data[i, 1] == Company)
                {
                    return false;
                }
            }
            return true;
        }
        public static bool CreateTableForCompanyPruduct(string Company)
        {

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand($"CREATE TABLE {Company}_CompanyProductTable (ID int IDENTITY(1,1) PRIMARY KEY, Product varchar(50))", connection);
                command.ExecuteNonQuery();
                connection.Close();
                return true;
            }
            return false;
        }
        public static bool SendProductToCompanyProduct(string Company, string product)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand($"INSERT INTO {Company}_CompanyProductTable (Product)\r\nVALUES ('{product}')\r\n", connection);
                command.ExecuteNonQuery();
                connection.Close();
                return true;
            }
            return false;
        }
        public static bool SyntaxEnglishCompanyName(string Company)
        {
            if (Company.Length > 0)
            {
                foreach (char c in Company)
                {
                    if (c == ' ')
                    {
                        return false;
                    }
                    if (c < 'A' || c > 'Z' && c < 'a' || c > 'z')
                    {
                        return false;
                    }
                }
                return true;
            }
            return false;
        }
    }

    public static class Hellp_DATABASE_ORDER
    {
        static string connectionString = $"Data Source=sql.bsite.net\\MSSQL2016;Initial Catalog=eyallavi_SampleDB;Persist Security Info=True;User ID=eyallavi_SampleDB;Password={Properties.Resources.KeyConnectionStringDB}";

        public static string[,] GetFromDataBaseOrderProduct()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string query = "SELECT * FROM OrderTable";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            // Get the number of columns and rows in the result set
            int numColumns = reader.FieldCount;
            int numRows = 0;
            while (reader.Read())
            {
                numRows++;
            }

            // Create a 2D string array to hold the data
            string[,] data = new string[numRows, numColumns];

            // ResetText the reader and read the data into the array
            reader.Close();
            reader = command.ExecuteReader();
            int row = 0;
            while (reader.Read())
            {
                for (int col = 0; col < numColumns; col++)
                {
                    data[row, col] = reader[col].ToString();
                }
                row++;
            }

            reader.Close();
            connection.Close();
            return data;
        }//קבלת כל הדאטא הזמנות 
        public static bool SendParameterDataBaseOrderProduct(string ProductCompany, string ProductType, string ProductName, string Expiry_Date, string Ex_get)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlCommand sqlCmd = new SqlCommand("OrderProductAdd", sqlCon);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@COMPANY", ProductType);
                sqlCmd.Parameters.AddWithValue("@TYPE_PRUDUCT", ProductCompany);
                sqlCmd.Parameters.AddWithValue("@NAME_PRUDUCT", ProductName);
                sqlCmd.Parameters.AddWithValue("@EXPIRY_DATE", Expiry_Date);
                sqlCmd.Parameters.AddWithValue("@EX_GET", Ex_get);
                sqlCmd.ExecuteNonQuery();
                return true;
            }
            return false;
        }//שליחת הזמנה חדשה
        public static void deleteRowOrderProducts(string IDProduct)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    using (SqlCommand command = new SqlCommand("DELETE FROM OrderTable WHERE ID = '" + IDProduct + "'", con))//לבדוק תקינות
                    {
                        command.ExecuteNonQuery();
                    }
                    con.Close();
                }
            }
            catch (SystemException ex)
            {
                MessageBox.Show(string.Format("An error occurred: {0}", ex.Message));
            }
        }// מחיקת שורה מהדאטא
        /*public static int LenRows()
        {
            SqlConnection connection = new SqlConnection(connectionString);

            string query = "SELECT * FROM ProductTable";

            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            return reader.FieldCount;
        }*/
    }
    public static class Hellp_DATABASE_BRANCH
    {
        static string connectionString = $"Data Source=sql.bsite.net\\MSSQL2016;Initial Catalog=eyallavi_SampleDB;Persist Security Info=True;User ID=eyallavi_SampleDB;Password={Properties.Resources.KeyConnectionStringDB}";
        public static string[,] GetFromDatabaseBranch()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string query = "SELECT * FROM BranchTable";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            // Get the number of columns and rows in the result set
            int numColumns = reader.FieldCount;
            int numRows = 0;
            while (reader.Read())
            {
                numRows++;
            }

            // Create a 2D string array to hold the data
            string[,] data = new string[numRows, numColumns];

            // ResetText the reader and read the data into the array
            reader.Close();
            reader = command.ExecuteReader();
            int row = 0;
            while (reader.Read())
            {
                for (int col = 0; col < numColumns; col++)
                {
                    data[row, col] = reader[col].ToString();
                }
                row++;
            }

            reader.Close();
            connection.Close();
            return data;
        }//קבלת כל הדאטא סניפים
        public static bool SendParameterDataBaseBranch(string Branch)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlCommand sqlCmd = new SqlCommand("BranchAdd", sqlCon);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@BRANCH", Branch);
                sqlCmd.ExecuteNonQuery();
                return true;
            }
            return false;
        }//שליחת סניף חדש
        public static bool CheakIfBranchHaveOnDataBase(string Branch)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string query = $"SELECT BRANCH\r\nFROM BranchTable \r\nWHERE BRANCH ='{Branch}'";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                reader.Close();
                connection.Close();
                return true;
            }
            reader.Close();
            connection.Close();
            return false;
        }
    }
    public static class Hellp_expiry_Sintax
    {
        public static bool cheakTheSintax(string ex)
        {
            if (10 == ex.Length && ex[2] == '/' && ex[5] == '/')//"23.03.2003"
            {
                string day = string.Empty;
                day += ex[0] + "" + ex[1];
                int res = -1;
                if (int.TryParse(day, out res))
                {
                    if (res > 0 && res < 32)
                    {
                        string month = string.Empty;
                        month += ex[3] + "" + ex[4];
                        res = -2;
                        if (int.TryParse(month, out res))
                        {
                            if (res > 0 && res <= 12)
                            {
                                string year = string.Empty;
                                year += ex[6] + "" + ex[7] + "" + ex[8] + "" + "" + ex[9];
                                if (int.TryParse(year, out res))
                                {
                                    if (res >= DateTime.Now.Year)
                                    {
                                        return true;
                                    }
                                }
                            }
                        }
                    }
                }
            }
            return false;
        }
        public static bool cheakTheSintaxDate(string ex)
        {
            if (10 == ex.Length && ex[2] == '/' && ex[5] == '/')//"23.03.2003"
            {
                int res = -1;
                string year = string.Empty;
                year += ex[6] + "" + ex[7] + "" + ex[8] + "" + "" + ex[9];
                if (int.TryParse(year, out res))
                {
                    if (res > DateTime.Now.Year)//במידה והשנה גדולה 
                    {
                        string month = string.Empty;
                        month += ex[3] + "" + ex[4];
                        res = -2;
                        if (int.TryParse(month, out res))
                        {
                            if (res > 0 && res <= 12)
                            {
                                string day = string.Empty;
                                day += ex[0] + "" + ex[1];
                                if (int.TryParse(day, out res))
                                {
                                    if (res > 0 && res < 32)
                                    {
                                        return true;
                                    }
                                }
                            }
                        }
                    }

                    else if (res == DateTime.Now.Year)//במידה והשנה שווה
                    {
                        string month = string.Empty;
                        month += ex[3] + "" + ex[4];
                        res = -2;
                        if (int.TryParse(month, out res))
                        {
                            if (res > 0 && res <= 12 && res > DateTime.Now.Month)//במידה והחודש גדול 
                            {
                                string day = string.Empty;
                                day += ex[0] + "" + ex[1];
                                if (int.TryParse(day, out res))
                                {
                                    if (res > 0 && res < 32)
                                    {
                                        return true;
                                    }
                                }
                            }
                            if (res > 0 && res <= 12 && res == DateTime.Now.Month)//במידה והחודש שווה
                            {
                                string day = string.Empty;
                                day += ex[0] + "" + ex[1];
                                if (int.TryParse(day, out res))
                                {
                                    if (res > 0 && res < 32 && res > DateTime.Now.Day)//במידה והיום גדול
                                    {
                                        return true;
                                    }
                                }
                            }
                        }
                    }
                }
            }
            return false;
        }//בודק סינטקס תאריך וגם בודק שהתאריך נכון מבחינת התאריך העכשיו לצורך הזמנה 
        public static bool cheakThePruductDateBroken(string ex)//בודק אם המוצר התקלקל
        {
            if (10 == ex.Length && ex[2] == '/' && ex[5] == '/')//"23.03.2003"
            {
                int res = -1;
                string year = string.Empty;
                year += ex[6] + "" + ex[7] + "" + ex[8] + "" + "" + ex[9];
                if (int.TryParse(year, out res))
                {
                    if (res > DateTime.Now.Year)//במידה והשנה גדולה 
                    {
                        string month = string.Empty;
                        month += ex[3] + "" + ex[4];
                        res = -2;
                        if (int.TryParse(month, out res))
                        {
                            if (res > 0 && res <= 12)
                            {
                                string day = string.Empty;
                                day += ex[0] + "" + ex[1];
                                if (int.TryParse(day, out res))
                                {
                                    if (res > 0 && res < 32)
                                    {
                                        return false;
                                    }
                                }
                            }
                        }
                    }

                    else if (res == DateTime.Now.Year)//במידה והשנה שווה
                    {
                        string month = string.Empty;
                        month += ex[3] + "" + ex[4];
                        res = -2;
                        if (int.TryParse(month, out res))
                        {
                            if (res > 0 && res <= 12 && res > DateTime.Now.Month)//במידה והחודש גדול 
                            {
                                string day = string.Empty;
                                day += ex[0] + "" + ex[1];
                                if (int.TryParse(day, out res))
                                {
                                    if (res > 0 && res < 32)
                                    {
                                        return false;
                                    }
                                }
                            }
                            if (res > 0 && res <= 12 && res == DateTime.Now.Month)//במידה והחודש שווה
                            {
                                string day = string.Empty;
                                day += ex[0] + "" + ex[1];
                                if (int.TryParse(day, out res))
                                {
                                    if (res > 0 && res < 32 && res >= DateTime.Now.Day)//במידה והיום גדול
                                    {
                                        return false;
                                    }
                                }
                            }
                        }
                    }
                }
            }
            return true;
        }
        public static bool DateOrderGetOrNot(string ex)
        {
            int res = -1;
            string year = string.Empty;
            year += ex[6] + "" + ex[7] + "" + ex[8] + "" + "" + ex[9];
            if (int.TryParse(year, out res))
            {
                if (res > DateTime.Now.Year)//במידה והשנה גדולה 
                {
                    return false;
                }

                else if (res == DateTime.Now.Year)//במידה והשנה שווה
                {
                    string month = string.Empty;
                    month += ex[3] + "" + ex[4];
                    res = -2;
                    if (int.TryParse(month, out res))
                    {
                        if (res > 0 && res <= 12 && res > DateTime.Now.Month)//במידה והחודש גדול 
                        {
                            return false;

                        }
                        if (res > 0 && res <= 12 && res == DateTime.Now.Month)//במידה והחודש שווה
                        {
                            string day = string.Empty;
                            day += ex[0] + "" + ex[1];
                            if (int.TryParse(day, out res))
                            {
                                if (res > 0 && res < 32 && res > DateTime.Now.Day)//במידה והיום גדול
                                {
                                    return false;
                                }
                            }
                        }
                    }
                }
            }
            return true;
        }//בודק אם ההזמנה הגיע לפי התאריך
    }
    public static class Hellp_English_Sintax
    {
        public static bool EnglishWithMakaf(string str)
        {
            if(str != null && str != string.Empty)
            {
                int counterEnglish = 0;
                int counterMakaf = 0;
                for (int i = 0; i < str.Length; i++)
                {
                    if (str[i] >= 'a' && str[i] <= 'z' || str[i] >= 'A' && str[i] <= 'Z')
                    {
                        counterEnglish++;
                    }
                    else if (str[i] == '-')
                    {
                        counterMakaf++;
                    }
                }
                if (counterMakaf == str.Length)
                {
                    return false;
                }
                else if (counterEnglish + counterMakaf == str.Length)
                {
                    return true;
                }
            }
           return false;

        }
        public static bool EnglishOnlyAndNumbers(string str)
        {
            if(str!= null && str != string.Empty)
            {
                int counter_A = 0;
                int counter_a = 0;
                int counter_9 = 0;
                for (int i = 0; i < str.Length; i++)
                {
                    if (str[i] >= 'A' && str[i] <= 'Z')
                    {
                        counter_A++;
                    }
                    if (str[i] >= 'a' && str[i] <= 'z')
                    {
                        counter_a++;
                    }
                    if (str[i] >= '0' && str[i] <= '9')
                    {
                        counter_9++;
                    }

                }
                if ((counter_A>0||counter_a>0)&&counter_a+counter_A+counter_9==str.Length)
                {
                    return true;
                }
            }
           
            return false;
        }
    }
    /*public class AllPrudcts
    {
        public Product[] GetProducts()
        {
            Product[] products = new Product[Hellp_DATABASE_PRODUCT.LenRows()];
            string[,] dataPr = Hellp_DATABASE_PRODUCT.GetFromDataBaseProduct();
            int counter = 0;
            for (int x = 0; x < dataPr.GetLength(0); x++)
            {
                products[counter++] = new Product(dataPr[x, 0], dataPr[x, 1], dataPr[x, 2], dataPr[x, 3], dataPr[x,4]);
            }
            return products;
        }
    }*/
    /*public class Product
    {
        string idSireali;
        string productType;
        string productCompany;
        string productName;
        string expiry_Date;
        public Product(string idSireali, string productType,string productCompany, string productName, string expiry_Date)
        {
            IdSireali = idSireali;
            ProductName = productName;
            ProductType = productType;
            Expiry_Date = expiry_Date;
            ProductCompany= productCompany;
        }
        public string IdSireali
        {
            get { return idSireali; }
            set { idSireali = value; }
        }
        public string ProductName
        {
            get { return productName; }
            set { productName = value; }
        }
        public string ProductType
        {
            get { return productType; }
            set { productType = value; }
        }
        public string Expiry_Date
        {
            get { return expiry_Date; }
            set { expiry_Date = value;}
        }
        public string ProductCompany
        {
            get { return productCompany; }
            set { productCompany = value; }
        }
    }*/
    /*public class ProductOrder
    {
        string productType;
        string productCompany;
        string productName;
        string expiry_Date;
        public ProductOrder( string productType, string productCompany, string productName, string expiry_Date)
        {
            ProductName = productName;
            ProductType = productType;
            Expiry_Date = expiry_Date;
            ProductCompany = productCompany;
        }
        public string ProductName
        {
            get { return productName; }
            set { productName = value; }
        }
        public string ProductType
        {
            get { return productType; }
            set { productType = value; }
        }
        public string Expiry_Date
        {
            get { return expiry_Date; }
            set { expiry_Date = value; }
        }
        public string ProductCompany
        {
            get { return productCompany; }
            set { productCompany = value; }
        }
    }*/
}
