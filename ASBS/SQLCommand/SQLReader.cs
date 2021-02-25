using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace ASBS.SQLCommand
{
    class SQLReader : SQL
    {
        public SQLReader(string connString)
            : base (connString)
        {

        }

        public DataSet GetDataSetEmployes()
        {
            try
            {
                var sqlConnection = new SqlConnection(ConnString);
                sqlConnection.Open();
                var adapter = new SqlDataAdapter($"SELECT EMPLOYES.ID, FIRSTNAME, LASTNAME, EMAIL, TEL, SPECIALITY.NAME_SPECIALITY FROM EMPLOYES" +
                    $" INNER JOIN SPECIALITY ON EMPLOYES.ID_SPECIALITY = SPECIALITY.ID", sqlConnection);
                var ds = new DataSet();
                adapter.Fill(ds);
                
                return ds;
            }
            catch (Exception ex)
            {
                MyLog.Log("Исключение в классе SQLReader метод GetDataSetEmployes: " + ex.Message);
                throw;
            }
        }

        public DataSet GetDataSetClient()
        {
            try
            {
                var sqlConnection = new SqlConnection(ConnString);
                sqlConnection.Open();
                var adapter = new SqlDataAdapter($"SELECT * FROM CLIENTS", sqlConnection);
                var ds = new DataSet();
                adapter.Fill(ds);

                return ds;
            }
            catch (Exception ex)
            {
                MyLog.Log("Исключение в классе SQLReader метод GetDataSetClient: " + ex.Message);
                throw;
            }
        }

        public DataSet GetDataSetEmployes(string speciality)
        {
            try
            {
                var sqlConnection = new SqlConnection(ConnString);
                sqlConnection.Open();
                var adapter = new SqlDataAdapter($"SELECT EMPLOYES.ID, FIRSTNAME, LASTNAME, EMAIL, TEL, SPECIALITY.NAME_SPECIALITY FROM EMPLOYES" +
                    $" INNER JOIN SPECIALITY ON EMPLOYES.ID_SPECIALITY = SPECIALITY.ID AND NAME_SPECIALITY = '{speciality}'", sqlConnection);
                var ds = new DataSet();
                adapter.Fill(ds);

                return ds;
            }
            catch (Exception ex)
            {
                MyLog.Log("Исключение в классе SQLReader метод GetDataSetEmployes(SPECIALITY): " + ex.Message);
                throw;
            }
        }

        public List<string> GetListTel(string tableName)
        {
            try
            {
                var list = new List<string>();
                var sqlConnection = new SqlConnection(ConnString);
                sqlConnection.Open();
                var sqlDataReader = new SqlCommand($"SELECT TEL FROM {tableName}", sqlConnection).ExecuteReader();

                while (sqlDataReader.Read())
                    list.Add((String)sqlDataReader[0]);

                sqlConnection.Close();
                return list;
            }
            catch (Exception ex)
            {
                MyLog.Log("Исключение в классе SQLReader метод GetListTelEmployes: " + ex.Message);
                throw;
            }
        }

        public List<string> GetListSpeciiality()
        {
            try
            {
                var list = new List<string>();
                var sqlConnection = new SqlConnection(ConnString);
                sqlConnection.Open();
                var sqlDataReader = new SqlCommand("SELECT NAME_SPECIALITY FROM SPECIALITY", sqlConnection).ExecuteReader();
                
                while (sqlDataReader.Read())
                    list.Add((String) sqlDataReader[0]);

                sqlConnection.Close();
                return list;
            }
            catch (Exception ex)
            { 
                MyLog.Log("Исключение в классе SQLReader метод GetListSpeciiality: " + ex.Message);
                throw;
            }
        }

        public List<string> GetListClients()
        {
            try
            {
                var list = new List<string>();
                var sqlConnection = new SqlConnection(ConnString);
                sqlConnection.Open();
                var sqlDataReader = new SqlCommand("SELECT FIRSTNAME, LASTNAME, TEL FROM CLIENTS", sqlConnection).ExecuteReader();

                while (sqlDataReader.Read())
                    list.Add($"{(String)sqlDataReader[0]} {(String)sqlDataReader[1]} {(String)sqlDataReader[2]}");

                sqlConnection.Close();
                return list;
            }
            catch (Exception ex)
            {
                MyLog.Log("Исключение в классе SQLReader метод GetListSpeciiality: " + ex.Message);
                throw;
            }
        }

        public List<string> GetListEmployes()
        {
            try
            {
                var list = new List<string>();
                var sqlConnection = new SqlConnection(ConnString);
                sqlConnection.Open();
                var sqlDataReader = new SqlCommand("SELECT FIRSTNAME, LASTNAME FROM EMPLOYES", sqlConnection).ExecuteReader();

                while (sqlDataReader.Read())
                    list.Add($"{(String)sqlDataReader[0]} {(String)sqlDataReader[1]}");

                sqlConnection.Close();
                return list;
            }
            catch (Exception ex)
            {
                MyLog.Log("Исключение в классе SQLReader метод GetListSpeciiality: " + ex.Message);
                throw;
            }
        }

        public List<string> GetListEmployes(string speciality)
        {
            try
            {
                var list = new List<string>();
                var sqlConnection = new SqlConnection(ConnString);
                sqlConnection.Open();
                var sqlDataReader = new SqlCommand("SELECT FIRSTNAME, LASTNAME FROM EMPLOYES " +
                    $"WHERE ID_SPECIALITY = (SELECT ID FROM SPECIALITY WHERE NAME_SPECIALITY = '{speciality}')", sqlConnection).ExecuteReader();

                while (sqlDataReader.Read())
                    list.Add($"{(String)sqlDataReader[0]} {(String)sqlDataReader[1]}");

                sqlConnection.Close();
                return list;
            }
            catch (Exception ex)
            {
                MyLog.Log("Исключение в классе SQLReader метод GetListSpeciiality: " + ex.Message);
                throw;
            }
        }

        public DataSet GetDataSetDateTime(string name)
        {
            try
            {
                var sqlConnection = new SqlConnection(ConnString);
                sqlConnection.Open();
                var adapter = new SqlDataAdapter($"SELECT * FROM FREE_DATETIME " +
                    $"WHERE ID_EMPLOYEE = (SELECT ID FROM EMPLOYES WHERE FIRSTNAME = '{name.Split()[0]}' AND LASTNAME = '{name.Split()[1]}')", sqlConnection);
                var ds = new DataSet();
                adapter.Fill(ds);

                return ds;
            }
            catch (Exception ex)
            {
                MyLog.Log("Исключение в классе SQLReader метод GetDataSetDateTime: " + ex.Message);
                throw;
            }
        }

        public DataSet GetDataSetDateTime(string name, DateTime dateTime)
        {
            try
            {
                var sqlConnection = new SqlConnection(ConnString);
                sqlConnection.Open();
                var adapter = new SqlDataAdapter($"SELECT * FROM FREE_DATETIME " +
                    $"WHERE ID_EMPLOYEE = (SELECT ID FROM EMPLOYES WHERE FIRSTNAME = '{name.Split()[0]}' AND LASTNAME = '{name.Split()[1]}') " +
                    $"AND DATE_RECORD = '{dateTime}'", sqlConnection);
                var ds = new DataSet();
                adapter.Fill(ds);

                return ds;
            }
            catch (Exception ex)
            {
                MyLog.Log("Исключение в классе SQLReader метод GetDataSetDateTime: " + ex.Message);
                throw;
            }
        }

        public DataSet GetDataSetFreeDateTime(string name)
        {
            try
            {
                var sqlConnection = new SqlConnection(ConnString);
                sqlConnection.Open();
                var adapter = new SqlDataAdapter($"SELECT * FROM FREE_DATETIME " +
                    $"WHERE ID_EMPLOYEE = (SELECT ID FROM EMPLOYES WHERE FIRSTNAME = '{name.Split()[0]}' AND LASTNAME = '{name.Split()[1]}') AND FREE = 'TRUE'", sqlConnection);
                var ds = new DataSet();
                adapter.Fill(ds);

                return ds;
            }
            catch (Exception ex)
            {
                MyLog.Log("Исключение в классе SQLReader метод GetDataSetFreeDateTime: " + ex.Message);
                throw;
            }
        }

        public DataSet GetDataSetFreeDateTime(string name, DateTime dateTime)
        {
            try
            {
                var sqlConnection = new SqlConnection(ConnString);
                sqlConnection.Open();
                var adapter = new SqlDataAdapter($"SELECT * FROM FREE_DATETIME " +
                    $"WHERE ID_EMPLOYEE = (SELECT ID FROM EMPLOYES WHERE FIRSTNAME = '{name.Split()[0]}' AND LASTNAME = '{name.Split()[1]}') " +
                    $"AND DATE_RECORD = '{dateTime}' AND FREE = 'TRUE'", sqlConnection);
                var ds = new DataSet();
                adapter.Fill(ds);

                return ds;
            }
            catch (Exception ex)
            {
                MyLog.Log("Исключение в классе SQLReader метод GetDataSetDateTime: " + ex.Message);
                throw;
            }
        }

        public void LaodDataTimeEmployee()
        {
            try
            {
                var list = new List<string>();
                var sqlConnection = new SqlConnection(ConnString);
                sqlConnection.Open();
                var sqlDataReader = new SqlCommand("SELECT * FROM DATA_TIME_EMPLOYES", sqlConnection).ExecuteReader();
                sqlDataReader.Read();

                Data.StartTimeFirstMod = (TimeSpan)sqlDataReader[0];
                Data.EndTimeFirstMod = (TimeSpan)sqlDataReader[1];
                Data.StartTimeSecondMod = (TimeSpan)sqlDataReader[2];
                Data.EndTimeSecondMod = (TimeSpan)sqlDataReader[3];
                Data.StartTimeFullMod = (TimeSpan)sqlDataReader[4];
                Data.EndTimeFullMod = (TimeSpan)sqlDataReader[5];
                Data.ReciptTime = (TimeSpan)sqlDataReader[6];

                sqlConnection.Close();

            }
            catch (Exception ex)
            {
                MyLog.Log("Исключение в классе SQLReader метод LaodDataTimeEmployee: " + ex.Message);
                throw;
            }
        }


    }
}
