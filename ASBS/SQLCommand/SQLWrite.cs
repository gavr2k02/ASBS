using System;
using System.Data;
using System.Data.SqlClient;
using ASBS.Models;

namespace ASBS.SQLCommand
{
    class SQLWrite : SQL
    {
        public SQLWrite(string connString)
            : base(connString)
        {
        }

        public void AddNewRecord(int idTime, string nameClient, string nameEmployee)
        {
            try
            {
                var sqlConnection = new SqlConnection(ConnString);
                sqlConnection.Open();

                var sqlCommand = new SqlCommand($"INSERT INTO RECORDS (ID_EMPLOYEE, ID_CLIENT, ID_FREE_DATETIME) " +
                                                   $"VALUES((SELECT ID FROM EMPLOYES WHERE FIRSTNAME = '{nameEmployee.Split()[0]}' AND LASTNAME = '{nameEmployee.Split()[1]}'), " +
                                                   $"(SELECT ID FROM CLIENTS WHERE FIRSTNAME = '{nameClient.Split()[0]}' AND LASTNAME = '{nameClient.Split()[1]}' AND TEL = '{nameClient.Split()[2] + " " + nameClient.Split()[3]}'), " +
                                                   $"{idTime})" ,sqlConnection);
                sqlCommand.ExecuteNonQuery();

                sqlCommand = new SqlCommand("UPDATE FREE_DATETIME SET FREE = 'false' " +
                                                $"WHERE ID = {idTime}", sqlConnection);
                sqlCommand.ExecuteNonQuery();

                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                MyLog.Log("Исключение в классе SQLWrite метод AddNewRecord: " + ex.Message);
                throw;
            }
        }

        public void AddNewEmployee(Employee employee)
        {
            try
            {
                var sqlConnection = new SqlConnection(ConnString);
                sqlConnection.Open();

                if (new SQLReader(ConnString).GetListTel("EMPLOYES").IndexOf(employee.Tel) != -1)
                    throw new Exception("EmployeeExistsInTheDatabase");

                if (new SQLReader(ConnString).GetListSpeciiality().IndexOf(employee.Speciality) == -1)
                {

                    var sqlCommand1 = new SqlCommand($"INSERT INTO SPECIALITY (NAME_SPECIALITY)" +
                                                    $"VALUES('{employee.Speciality}')", sqlConnection);
                    sqlCommand1.ExecuteNonQuery();
                }

                 var sqlCommand = new SqlCommand($"INSERT INTO EMPLOYES (FIRSTNAME, LASTNAME, EMAIL, TEL, ID_SPECIALITY)" +
                                                    $"VALUES('{employee.FirstName}', '{employee.LastName}', '{employee.Email}', '{employee.Tel}', " +
                                                    $"(SELECT ID FROM SPECIALITY WHERE NAME_SPECIALITY = '{employee.Speciality}'))",
                                                    sqlConnection);
                sqlCommand.ExecuteNonQuery();

                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                MyLog.Log("Исключение в классе SQLWrite метод AddNewEmployee: " + ex.Message);
                throw;
            }
        }

        public void AddNewClient(Client client)
        {
            try
            {
                var sqlConnection = new SqlConnection(ConnString);
                sqlConnection.Open();

                if (new SQLReader(ConnString).GetListTel("CLIENTS").IndexOf(client.Tel) != -1)
                    throw new Exception("ClientExistsInTheDatabase");

                var sqlCommand = new SqlCommand($"INSERT INTO CLIENTS (FIRSTNAME, LASTNAME, EMAIL, TEL)" +
                                                   $"VALUES('{client.FirstName}', '{client.LastName}', '{client.Email}', '{client.Tel}')",
                                                   sqlConnection);

                sqlCommand.ExecuteNonQuery();

                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                MyLog.Log("Исключение в классе SQLWrite метод AddNewClient: " + ex.Message);
                throw;
            }
        }

        public void ChangeDataTime()
        {
            try
            {
                var sqlConnection = new SqlConnection(ConnString);
                sqlConnection.Open();

                var sqlCommand = new SqlCommand($"UPDATE DATA_TIME_EMPLOYES SET " +
                    $"START_TIME_FIRST_MODE = '{Data.StartTimeFirstMod}', " +
                    $"END_TIME_FISRT_MODE = '{Data.EndTimeFirstMod}', " +
                    $"START_TIME_SECOND_MODE = '{Data.StartTimeSecondMod}', " +
                    $"END_TIME_SECOND_MODE = '{Data.EndTimeSecondMod}', " +
                    $"START_TIME_FULL_MODE = '{Data.StartTimeFullMod}', " +
                    $"END_TIME_FILL_MODE = '{Data.EndTimeFullMod}', " +
                    $"RECIPT_TIME = '{Data.ReciptTime}'", sqlConnection);

                sqlCommand.ExecuteNonQuery();

                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                MyLog.Log("Исключение в классе SQLWrite метод ChangeDataTime: " + ex.Message);
                throw;
            }
        }

        public void AddTimeRecords(DateTime dateTime, string name, TimeSpan startTime, TimeSpan endTime)
        {
            try
            {
                var sqlConnection = new SqlConnection(ConnString);
                sqlConnection.Open();

                for (var i = startTime; i < endTime; i += Data.ReciptTime)
                {
                    var sqlCommand = new SqlCommand($"INSERT FREE_DATETIME(DATE_RECORD, TIME_RECORD, FREE, ID_EMPLOYEE) " +
                    $"VALUES('{dateTime}',  '{i}', 'true', " +
                    $"(SELECT ID FROM EMPLOYES " +
                    $"WHERE FIRSTNAME = '{name.Split()[0]}' AND LASTNAME = '{name.Split()[1]}'))", sqlConnection);
                    sqlCommand.ExecuteNonQuery();
                }
                

                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                MyLog.Log("Исключение в классе SQLWrite метод AddTimeRecords: " + ex.Message);
                throw;
            }
        }

        public void DeleteEmployee(int idEmployee)
        {
            try
            {
                var sqlConnection = new SqlConnection(ConnString);
                sqlConnection.Open();

                var sqlCommand = new SqlCommand($"DELETE FROM EMPLOYES WHERE ID = {idEmployee}", sqlConnection);

                sqlCommand.ExecuteNonQuery();

                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                MyLog.Log("Исключение в классе SQLWrite метод DeleteEmployee: " + ex.Message);
                throw;
            }
        }

        public void DeleteClient(int idClient)
        {
            try
            {
                var sqlConnection = new SqlConnection(ConnString);
                sqlConnection.Open();

                var sqlCommand = new SqlCommand($"DELETE FROM CLIENTS WHERE ID = {idClient}", sqlConnection);

                sqlCommand.ExecuteNonQuery();

                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                MyLog.Log("Исключение в классе SQLWrite метод DeleteClient: " + ex.Message);
                throw;
            }
        }

        public void UpdateDataEmployee(DataTable dt)
        {
            try
            {
                var sqlConnection = new SqlConnection(ConnString);
                sqlConnection.Open();

                var adapter = new SqlDataAdapter();

                var command = new SqlCommand("IF EXISTS (SELECT NAME_SPECIALITY FROM SPECIALITY WHERE NAME_SPECIALITY = @NAME_SPECIALITY) " +
                    "UPDATE EMPLOYES SET FIRSTNAME = @FIRSTNAME, LASTNAME = @LASTNAME, TEL = @TEL, EMAIL = @EMAIL, ID_SPECIALITY = " +
                    "(SELECT SPECIALITY.ID FROM SPECIALITY " +
                    "WHERE NAME_SPECIALITY = @NAME_SPECIALITY) " +
                    "WHERE ID = @oldID", sqlConnection);

                command.Parameters.Add("@FIRSTNAME", SqlDbType.NVarChar, 30, "FIRSTNAME");
                command.Parameters.Add("@LASTNAME", SqlDbType.NVarChar, 30, "LASTNAME");
                command.Parameters.Add("@EMAIL", SqlDbType.NVarChar, 50, "EMAIL");
                command.Parameters.Add("@TEL", SqlDbType.NVarChar, 14, "TEL");
                command.Parameters.Add("@NAME_SPECIALITY", SqlDbType.NVarChar, 50, "NAME_SPECIALITY");


                SqlParameter parameter = command.Parameters.Add("@oldID", SqlDbType.Int, 0, "ID");
                parameter.SourceVersion = DataRowVersion.Original;

                adapter.UpdateCommand = command;
                adapter.Update(dt);

                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                MyLog.Log("Исключение в классе SQLWrite метод UpdateDataEmployee: " + ex.Message);
                throw;
            }
        }

        public void DeleteDateTime(int idDateTime)
        {
            try
            {
                var sqlConnection = new SqlConnection(ConnString);
                sqlConnection.Open();

                var sqlCommand = new SqlCommand($"DELETE FROM FREE_DATETIME WHERE ID = {idDateTime}", sqlConnection);

                sqlCommand.ExecuteNonQuery();

                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                MyLog.Log("Исключение в классе SQLWrite метод DeleteClient: " + ex.Message);
                throw;
            }
        }

        public void UpdateDataClient(DataTable dt)
        {
            try
            {
                var sqlConnection = new SqlConnection(ConnString);
                sqlConnection.Open();

                var adapter = new SqlDataAdapter();

                var command = new SqlCommand("UPDATE CLIENTS SET FIRSTNAME = @FIRSTNAME, LASTNAME = @LASTNAME, TEL = @TEL, EMAIL = @EMAIL " +
                    "WHERE ID = @oldID", sqlConnection);

                command.Parameters.Add("@FIRSTNAME", SqlDbType.NVarChar, 30, "FIRSTNAME");
                command.Parameters.Add("@LASTNAME", SqlDbType.NVarChar, 30, "LASTNAME");
                command.Parameters.Add("@EMAIL", SqlDbType.NVarChar, 50, "EMAIL");
                command.Parameters.Add("@TEL", SqlDbType.NVarChar, 14, "TEL");

                SqlParameter parameter = command.Parameters.Add("@oldID", SqlDbType.Int, 0, "ID");
                parameter.SourceVersion = DataRowVersion.Original;

                adapter.UpdateCommand = command;
                adapter.Update(dt);

                sqlConnection.Close();

            }
            catch (Exception ex)
            {
                MyLog.Log("Исключение в классе SQLWrite метод UpdateDataClients: " + ex.Message);
                throw;
            }
        }
    }
}
