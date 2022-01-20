using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFood.Model
{
    class ModelTemplate
    {
        private static SqlConnection connection;
        private SqlCommand command;
        private bool result;

        public static SqlConnection GetConnection()
        {
            connection = new SqlConnection();

            connection.ConnectionString = "Data Source=DESKTOP-CO424V8;" +
                "Initial Catalog=Fastfood;" +
                "Integrated Security=True";
            return connection;
        }

        public ModelTemplate()
        {
            GetConnection();
        }

        public void cekKoneksi()
        {
            GetConnection();
            try
            {
                connection.Open();
                MessageBox.Show("koneksi anda berhasil");
            }
            catch (SqlException ex)
            {
                MessageBox.Show("koneksi gagal" + ex);
            }
        }

        //template select data
        public DataSet Select(string tabel, string kondisi)
        {
            DataSet ds = new DataSet();

            try
            {
                connection.Open();
                command = new SqlCommand();
                command.Connection = connection;
                command.CommandType = CommandType.Text;
                if (kondisi == null)
                {
                    command.CommandText = "SELECT * FROM " + tabel;
                }
                else
                {
                    command.CommandText = "SELECT * FROM " + tabel + " WHERE " + kondisi;
                }
                SqlDataAdapter sda = new SqlDataAdapter(command);
                sda.Fill(ds, tabel);
            }
            catch (SqlException)
            {
                ds = null;
            }
            connection.Close();
            return ds;
        }

        //template select data (counting, top, grouping dll)
        public DataSet SelectData(string query, string tabel)
        {
            DataSet ds = new DataSet();

            try
            {
                connection.Open();
                command = new SqlCommand();
                command.Connection = connection;
                command.CommandType = CommandType.Text;
                command.CommandText = query;
                SqlDataAdapter sda = new SqlDataAdapter(command);
                sda.Fill(ds, tabel);
            }
            catch (SqlException)
            {
                ds = null;
            }
            connection.Close();
            return ds;
        }

        //template insert data
        public Boolean Insert(string tabel, string data)
        {
            result = false;
            try
            {
                string query = "INSERT INTO " + tabel + " VALUES (" + data + ")";
                connection.Open();
                command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = query;
                command.ExecuteNonQuery();
                result = true;
            }
            catch (SqlException)
            {
                result = false;
            }
            connection.Close();
            return result;
        }

        //template update data
        public Boolean Update(string tabel, string data, string kondisi)
        {
            result = false;
            try
            {
                string query = "UPDATE " + tabel + " SET " + data + " WHERE " + kondisi;
                connection.Open();
                command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = query;
                command.ExecuteNonQuery();
                result = true;
            }
            catch (SqlException)
            {
                result = false;
            }
            connection.Close();
            return result;
        }

        //template delete data
        public Boolean Delete(string tabel, string kondisi)
        {
            result = false;
            try
            {
                string query = "DELETE FROM " + tabel + " WHERE " + kondisi;
                connection.Open();
                command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = query;
                command.ExecuteNonQuery();
                result = true;
            }
            catch (SqlException)
            {
                result = false;
            }
            connection.Close();
            return result;
        }
    }

}
