using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace DALCheckPoint2EmilieD
{
    internal class DataAbstractionLayer
    {
        private static SqlConnection _connection = new SqlConnection();
        internal static void Connect(SqlConnectionStringBuilder stringBuilder)
        {
            _connection.ConnectionString = stringBuilder.ConnectionString;
            _connection.Open();
        }

        internal static void Disconnect()
        {
            _connection.Close();
        }

        public static List<Student> SelectAllStudents()
        {
            SqlCommand command = _connection.CreateCommand();
            command.CommandText = "SELECT * FROM Student";
            SqlDataReader reader = command.ExecuteReader();
            List<Student> students = new List<Student>();
            while (reader.Read())
            {
                Student student= new Student
                {
                    StudentId = reader.GetInt32(0),
                    StudentLastName = reader.GetString(1),
                    StudentFirstName = reader.GetString(2),
                    PromotionId = reader.GetInt32(3),
                }; 
                students.Add(student);
            }
            reader.Close();
            return students;
        }


        public static List<Student> SelectStudentsByName()
        {
            SqlCommand command = _connection.CreateCommand();
            command.CommandText = "SELECT * FROM Student WHERE StudentLastName='Delsol'";
            SqlDataReader reader = command.ExecuteReader();
            List<Student> students = new List<Student>();
            while (reader.Read())
            {
                Student student = new Student
                {
                    StudentId = reader.GetInt32(0),
                    StudentLastName = reader.GetString(1),
                    StudentFirstName = reader.GetString(2),
                    PromotionId = reader.GetInt32(3),
                };
                students.Add(student);
            }
            reader.Close();
            return students;
        }
    }
}
