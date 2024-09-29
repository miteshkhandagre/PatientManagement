using System.Data.SQLite;

namespace PatientManagement.Controller
{
    public class DBSchema
    {
        public static void CreatePatientInfoTable(SQLiteConnection conn)
        {
            try
            {
                conn.Open();

                var cmd = conn.CreateCommand();
                cmd.CommandText = @"drop table if exists PatientInfo";
                cmd.ExecuteNonQuery();

                cmd = conn.CreateCommand();
                cmd.CommandText = @"Create table if not exists PatientInfo(
                                    [Id] INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
                                    [FirstName] NVARCHAR(100) NOT NULL,
                                    [LastName] NVARCHAR(100) NOT NULL,
                                    [DoB] TEXT NOT NULL,
                                    [Gender] TEXT NOT NULL,
                                    [Mobile] INTEGER NOT NULL,
                                    [Email] TEXT NULL,
                                    [Address] NVARCHAR(200) NULL,
                                    [IdType] TEXT NOT NULL,
                                    [IdDetails] NVARCHAR(50) NOT NULL,
                                    [Other] TEXT NULL,
                                    [CreationDate] TEXT NOT NULL)";
                cmd.ExecuteNonQuery();
            }
            catch (Exception) { throw; }
            finally { conn.Close(); }
        }

        public static void CreatePatientInfoTableIndex(SQLiteConnection conn)
        {
            try
            {
                conn.Open();
                var cmd = conn.CreateCommand();
                cmd.CommandText = @"Create index PatientInfo_Mobile_Idx on PatientInfo (Mobile)";
                cmd.ExecuteNonQuery();

                cmd = conn.CreateCommand();
                cmd.CommandText = @"Create index PatientInfo_IdDetails_Idx on PatientInfo (IdDetails)";
                cmd.ExecuteNonQuery();
            }
            catch (Exception) { throw; }
            finally { conn.Close(); }
        }

        public static void CreatePatientHistoryTable(SQLiteConnection conn)
        {
            try
            {
                conn.Open();

                var cmd = conn.CreateCommand();
                cmd.CommandText = @"drop table if exists PatientHistory";
                cmd.ExecuteNonQuery();

                cmd = conn.CreateCommand();
                cmd.CommandText = @"Create table if not exists PatientHistory(
                                    [Id] INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
                                    [PatientId] INTEGER NOT NULL,
                                    [Name] NVARCHAR(100) NOT NULL,
                                    [TestType] NVARCHAR(100) NOT NULL,
                                    [TestSpecific] TEXT NOT NULL,
                                    [TestResult] NVARCHAR(100) NULL,
                                    [DoctorId] INTEGER NOT NULL,
                                    [DoctorName] TEXT NULL,
                                    [Amount] INTEGER NOT NULL,
                                    [PaymentMode] TEXT NOT NULL,
                                    [PaymentId] NVARCHAR(50) NULL,
                                    [Other] TEXT NULL,
                                    [CreationDate] TEXT NOT NULL)";
                cmd.ExecuteNonQuery();
            }
            catch (Exception) { throw; }
            finally { conn.Close(); }
        }

        public static void CreatePatientHistoryTableIndex(SQLiteConnection conn)
        {
            try
            {
                conn.Open();
                var cmd = conn.CreateCommand();
                cmd.CommandText = @"Create index PatientHistory_CreationDate_Idx on PatientHistory (CreationDate)";
                cmd.ExecuteNonQuery();
            }
            catch (Exception) { throw; }
            finally { conn.Close(); }
        }

        public static void CreateDoctorsTable(SQLiteConnection conn)
        {
            try
            {
                conn.Open();

                var cmd = conn.CreateCommand();
                cmd.CommandText = @"drop table if exists Doctors";
                cmd.ExecuteNonQuery();

                cmd = conn.CreateCommand();
                cmd.CommandText = @"Create table if not exists Doctors(
                                    [Id] INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
                                    [FirstName] NVARCHAR(100) NOT NULL,
                                    [LastName] NVARCHAR(100) NOT NULL,
                                    [Address] NVARCHAR(200) NULL,
                                    [Gender] TEXT NOT NULL,
                                    [Mobile] INTEGER NOT NULL,
                                    [Email] TEXT NULL,
                                    [RegistrationNo] NVARCHAR(100) NOT NULL,
                                    [CreationDate] TEXT NOT NULL)";
                cmd.ExecuteNonQuery();
            }
            catch (Exception) { throw; }
            finally { conn.Close(); }
        }
    }
}
