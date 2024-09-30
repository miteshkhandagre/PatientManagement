using System.Data.SQLite;
using System.Data;
using System.Configuration;
using PatientManagement.Model;

namespace PatientManagement.Controller
{
    public class DBManager : IDisposable
    {
        public DBManager()
        {
            try
            {
                string? dbConstr = ConfigurationManager.AppSettings["SqliteConStr"];
                if (string.IsNullOrWhiteSpace(dbConstr))
                    throw new Exception("DB Connection string not specified");
                
                _conn = new SQLiteConnection(dbConstr);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error while initializing DB. ErrorMsg: {ex.Message}");
                throw;
            }
        }
        public bool CreateDatabase()
        {
            try
            {
                _conn.Dispose();
                string? dbConstr = ConfigurationManager.AppSettings["SqliteConStr"];
                string dbFile = dbConstr.Substring(12, (dbConstr.IndexOf(';') - 12 ));

                if (File.Exists(dbFile))
                    File.Delete(dbFile);

                if (!Directory.Exists("DB"))
                    Directory.CreateDirectory("DB");

                _conn = new SQLiteConnection(dbConstr);
                DBSchema.CreateLoginUserTable(_conn);
                DBSchema.CreatePatientInfoTable(_conn);
                DBSchema.CreatePatientInfoTableIndex(_conn);
                DBSchema.CreateDoctorsTable(_conn);
                DBSchema.CreatePatientHistoryTable(_conn);
                DBSchema.CreatePatientHistoryTableIndex(_conn);
                AddLoginUser("Admin", "Admin", "ADMIN");

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error in DB Creation. ErrorMsg: {ex.Message}");
                return false;
            }
        }

        #region Patient Record

        public (bool success, int Id) AddPatientInfo(PatientInfoDto record)
        {
            try
            {
                _conn.Open();
                var cmd = _conn.CreateCommand();
                cmd.CommandText = $@"INSERT INTO PatientInfo(
                                    FirstName, LastName, DoB, Gender, Mobile, Email, Address, IdType, 
                                    IdDetails, Other, CreationDate) 
                                    VALUES('{record.FirstName}', '{record.LastName}', '{record.DoB}',
                                    '{record.Gender}', '{record.Mobile}', '{record.Email}',
                                    '{record.Address}', '{record.IdType}', '{record.IdDetails}',
                                    '{record.Other}', datetime('now')) ";
                if (cmd.ExecuteNonQuery() > 0)
                {
                    cmd = _conn.CreateCommand();
                    cmd.CommandText = "SELECT last_insert_rowid()";
                    int Id = Convert.ToInt32(cmd.ExecuteScalar());

                    return new(true, Id);
                }
                return (false, -1);
            }
            catch (Exception)
            {
                throw;
            }
            finally { _conn.Close(); }
        }

        public PatientInfoDto GetPatientInfoByMobileNo(int mobileNo)
        {
            try
            {
                _conn.Open();
                SQLiteCommand cmd = new SQLiteCommand($"{patientInfoQuery} where Mobile = {mobileNo}", _conn);
                using (SQLiteDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return GetPatientInfoDto(reader);
                    }
                }
                return null;
            }
            catch (Exception)
            {
                throw;
            }
            finally { _conn.Close(); }            
        }

        public PatientInfoDto GetPatientInfoById(int id)
        {
            try
            {
                _conn.Open();
                SQLiteCommand cmd = new SQLiteCommand($"{patientInfoQuery} where Id = {id}", _conn);
                using (SQLiteDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return GetPatientInfoDto(reader);
                    }
                }
                return null;
            }
            catch (Exception)
            {
                throw;
            }
            finally { _conn.Close(); }
        }

        public IEnumerable<PatientInfoDto> GetPatientInfoByName(string firstName, string lastName)
        {
            try
            {
                _conn.Open();
                SQLiteCommand cmd = new SQLiteCommand($"{patientInfoQuery} where FirstName = {firstName} and LastName = {lastName}", _conn);
                using (SQLiteDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        yield return GetPatientInfoDto(reader);
                    }
                }
                yield break;
            }
            //catch (Exception)
            //{
            //    throw;
            //}
            finally { _conn.Close(); }
        }

        public PatientInfoDto GetPatientInfoDto(SQLiteDataReader reader)
        {
            return new PatientInfoDto
            {
                Id = Convert.ToInt32(reader["ID"]),
                FirstName = Convert.ToString(reader["FirstName"]),
                LastName = Convert.ToString(reader["LastName"]),
                DoB = Convert.ToDateTime(reader["DoB"]),
                Gender = Convert.ToString(reader["Gender"]),
                Mobile = Convert.ToInt32(reader["Mobile"]),
                Email = Convert.ToString(reader["Email"]),
                Address = Convert.ToString(reader["Address"]),
                IdType = Convert.ToString(reader["IdType"]),
                IdDetails = Convert.ToString(reader["IdDetails"]),
                Other = Convert.ToString(reader["Other"]),
                CreationDate = Convert.ToDateTime(reader["CreationDate"])
            };
        }

        public (bool success, int Id) AddPatientHistory(PatientHistoryDto record)
        {
            try
            {
                _conn.Open();
                var cmd = _conn.CreateCommand();
                cmd.CommandText = $@"INSERT INTO PatientHistory(
                                    PatientId, Name, TestType, TestSpecific, TestResult, DoctorId, DoctorName, Amount, 
                                    PaymentMode, PaymentId, Other, CreationDate) 
                                    VALUES('{record.PatientId}', '{record.Name}', '{record.TestType}',
                                    '{record.TestSpecific}', '{record.TestResult}', '{record.DoctorId}',
                                    '{record.DoctorName}', '{record.Amount}', '{record.PaymentMode}', '{record.PaymentId}',
                                    '{record.Other}', datetime('now')) ";
                if (cmd.ExecuteNonQuery() > 0)
                {
                    cmd = _conn.CreateCommand();
                    cmd.CommandText = "SELECT last_insert_rowid()";
                    int Id = Convert.ToInt32(cmd.ExecuteScalar());

                    return new(true, Id);
                }
                return (false, -1);
            }
            catch (Exception)
            {
                throw;
            }
            finally { _conn.Close(); }
        }

        public DataTable GetPatientHistoryById(int id)
        {
            DataTable dt = new DataTable();
            try
            {
                string query = $"{patientHistoryQuery} where PatientId = '{id}'";
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(query, _conn);
                adapter.Fill(dt);
                return dt;
            }
            catch (Exception)
            {
                throw;
            }
            finally { _conn.Close(); }
        }


        #endregion

        #region Doctors

        public (bool, int) AddDoctor(DoctorInfoDto doctorInfo)
        {
            try
            {
                _conn.Open();
                var cmd = _conn.CreateCommand();
                cmd.CommandText = $@"INSERT INTO Doctors(FirstName, LastName, Address, Gender, Mobile, RegistrationNo, Email, CreationDate) 
                                    VALUES('{doctorInfo.FirstName}', '{doctorInfo.LastName}', '{doctorInfo.Address}', '{doctorInfo.Gender}',
                                            '{doctorInfo.Mobile}', '{doctorInfo.RegistrationNo}', '{doctorInfo.Email}', datetime('now')) ";
                if (cmd.ExecuteNonQuery() > 0)
                {
                    cmd = _conn.CreateCommand();
                    cmd.CommandText = "SELECT last_insert_rowid()";
                    int Id = Convert.ToInt32(cmd.ExecuteScalar());

                    return new(true, Id);
                }
                return (false, -1);
            }
            catch (Exception)
            {
                throw;
            }
            finally { _conn.Close(); }
        }

        public DataTable GetDoctors()
        {
            DataTable dt = new DataTable();
            try
            {
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(
                    "SELECT Id, FirstName, LastName, Address, Gender, Mobile, RegistrationNo, Email from Doctors", _conn);

                adapter.Fill(dt);
                return dt;
            }
            catch (Exception)
            {
                throw;
            }
            finally { _conn.Close(); }
        }

        #region Login Users
        public bool AddLoginUser(string username, string password, string role)
        {
            try
            {
                _conn.Open();
                var cmd = _conn.CreateCommand();
                cmd.CommandText = $@"INSERT INTO LoginUsers(Username, Password, Role) 
                                    VALUES('{username}', '{password}', '{role}') ";
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
                return false;
            }
            catch (Exception)
            {
                throw;
            }
            finally { _conn.Close(); }
        }

        public DataTable GetLoginUser()
        {
            DataTable dt = new DataTable();
            try
            {
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(
                    "SELECT Id, Username, Password, Role from LoginUsers", _conn);

                adapter.Fill(dt);
                return dt;
            }
            catch (Exception)
            {
                throw;
            }
            finally { _conn.Close(); }
        }

        public (bool valid, string role) IsValidUser(string username, string password)
        {
            try
            {
                _conn.Open();
                var cmd = _conn.CreateCommand();
                cmd.CommandText = $@"Select Id, Role from LoginUsers  
                                    where Username = '{username}' and Password = '{password}' ";
                using (var reader = cmd.ExecuteReader())
                {
                    if (reader != null && reader.HasRows)
                    {
                        reader.Read();
                        return (true, Convert.ToString(reader["Role"]));
                    }
                }
                return (false, "User");
            }
            catch (Exception)
            {
                throw;
            }
            finally { _conn.Close(); }
        }

        #endregion

        public void Dispose()
        {
            _conn.Dispose();
        }

        #endregion

        public static DBManager Instance = new DBManager();
        private SQLiteConnection _conn = null;
        private const string patientInfoQuery = $"SELECT Id, FirstName, LastName, DoB, Gender, Mobile, Email, Address, IdType, IdDetails, Other, CreationDate from PatientInfo ";
        private const string patientHistoryQuery = $"SELECT Id, Name, TestType, TestSpecific, TestResult, DoctorId, DoctorName, Amount, PaymentMode, PaymentId, Other, CreationDate from PatientHistory ";
    }
}
