using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace DALCheckPoint2EmilieD
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnectionStringBuilder stringBuilder = new SqlConnectionStringBuilder();
            stringBuilder.DataSource = "LOCALHOST\\SQLEXPRESS";
            stringBuilder.InitialCatalog = "DataCheckPoint2";
            stringBuilder.IntegratedSecurity = true;
            DataAbstractionLayer.Connect(stringBuilder);
            List<Student> students = DataAbstractionLayer.SelectAllStudents();
            foreach (Student student in students)
                {
                Console.WriteLine(student);
            }
        }
    }
}
