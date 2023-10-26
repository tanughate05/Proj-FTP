using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Drawing.Text;
using System.Data.SQLite;
using System.Diagnostics;
using System.Net;
using System.Reflection;

namespace Uploading_SqlServer_SQLite_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public object DataSources { get; private set; }

        private void btn1_Click(object sender, EventArgs e)
        {
            // address of Sql server and database
            string ConnectionString = "Data Source=ADI\\SQLEXPRESS;Initial Catalog=SqlServerDatabase1;Integrated Security=True";

            // Establish connection
            SqlConnection con = new SqlConnection(ConnectionString);

            // sqlite connection



            // open connection
            con.Open();

            // prepare query
            String code = itemCodeBox.Text;
            String price = itemPriceBox.Text;
            String newPrice = itemNewPriceBox.Text;

            float priceNum;
            float newPriceNum;

            float.TryParse(price, out priceNum);
            float.TryParse(newPrice, out newPriceNum);

            string Query = "insert into materials(ItemCode, ItemPrice,NewPrice) values ('" + code + "'," + price + "," + newPrice + ") ";

            //s.execute query
            SqlCommand cmd = new SqlCommand(Query, con);
            cmd.ExecuteNonQuery();

            // close connection
            con.Close();

            MessageBox.Show("Uploaded");
        }

        public void backup(string strDestination, SQLiteConnection location)
        {
            SQLiteConnection.CreateFile(strDestination);
            using (var destination = new SQLiteConnection(string.Format(@"Data Source={0}; Version=3;", strDestination)))
            {
                
                destination.Open();
                location.BackupDatabase(destination, "main", "main", -1, null, 0);
                destination.Close();
            }
        }

        private void uplaodBtn_Click(object sender, EventArgs e)
        {
            // address of Sql server and database
            string ConnectionString = "Data Source=ADI\\SQLEXPRESS;Initial Catalog=SqlServerDatabase1;Integrated Security=True";

            // Establish connection

            List<Material> materials = new List<Material>();

            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                con.Open();
                SqlCommand sqlCommand = new SqlCommand("SELECT * FROM materials", con);
                SqlDataReader reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    string itemCode = (string)reader["ItemCode"];
                    double itemPrice = (double)reader["ItemPrice"];
                    double newItemPrice = (double)reader["NewPrice"];
                    Material f = new Material(itemCode, itemPrice, newItemPrice);
                    materials.Add(f);
                }
                con.Close();
            }

            MessageBox.Show("" + materials.Count);

            SQLiteConnection.CreateFile("ftp_sqlite1.sqlite");
            string connectionString = "Data Source=ftp_sqlite1.sqlite;Version=3;Pooling=False;";
           SQLiteConnection m_dbConnection = new SQLiteConnection(connectionString);
            m_dbConnection.Open();
            string dropTable = "drop table Materials";
            SQLiteCommand command;
            //command = new SQLiteCommand(dropTable, m_dbConnection);
            //command.ExecuteNonQuery();
            string sql = "Create Table Materials(ItemCode NVARCHAR(50) NULL,ItemPrice REAL NULL,NewPrice REAL NULL)";
            // you could also write sql = "CREATE TABLE IF NOT EXISTS highscores ..."
            command = new SQLiteCommand(sql, m_dbConnection);
            command.ExecuteNonQuery();

            foreach(var material in materials)
            {
                sql = "Insert into Materials (ItemCode, ItemPrice, NewPrice) values ('" + material.getItemCode() + "'," + material.getItemPrice() + "," + material.getNewItemPrice() + ")";
                command = new SQLiteCommand(sql, m_dbConnection);
                command.ExecuteNonQuery();
                command.Dispose();
            }
            backup("backup.sqlite", m_dbConnection);
            m_dbConnection.Close();
            SQLiteConnection.ClearAllPools();
            m_dbConnection.Dispose();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            

            using (var client = new WebClient())
            {

                string executableLocation = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
                string fileLocation = Path.Combine(executableLocation, "backup.sqlite");
                client.Credentials = new NetworkCredential("tester@bilmarkltd.com", "8T.n,hI[x8}O");
                client.UploadFile("ftp://bilmarkltd.com/t_file_sample_1.sqlite", WebRequestMethods.Ftp.UploadFile, fileLocation);
            }
            MessageBox.Show("Done..");
        }

        

    }
}