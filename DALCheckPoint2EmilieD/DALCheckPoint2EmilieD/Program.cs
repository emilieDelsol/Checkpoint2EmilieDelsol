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

            Console.WriteLine("****************************************************** \nSélection de tous les étudiants: \n");
            foreach (Student student in students)
                {
                Console.WriteLine(student);
            }
            List<Student> studentsByLastName = DataAbstractionLayer.SelectStudentsByName();
            foreach(Student student in studentsByLastName)
            {
                Console.WriteLine($"****************************************************** \nSélection d'un étudiant en fonction de son nom de famille: \n\t{ student}");
            }
        }
    }
}
