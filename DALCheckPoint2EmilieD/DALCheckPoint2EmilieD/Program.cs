using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace DALCheckPoint2EmilieD
{
    class Program
    {
        static void Main(string[] args)
        {
            CreateDatabase();
            DatabaseCheckPoint2Context context = new DatabaseCheckPoint2Context();
            foreach(Student student in context.Students)
            {
                Console.WriteLine(student.StudentFirstName);
            }

            foreach (Promotion promotion in context.Promotions.Include(p=>p.Students))
                {
                Console.WriteLine("\nLa promo : " + promotion.PromotionName +" à "+ promotion.Students.Count()  +" étudiants:");
                foreach (Student student in promotion.Students)
                {
                    Console.WriteLine($"\t {student.StudentFirstName}");
                }
            }

            foreach (Student student in context.Students)
            {
                Console.WriteLine($"{student.ControlesList.Count()}");
            }



            
        }

        private static void CreateDatabase()
        {
            DatabaseCheckPoint2Context context = new DatabaseCheckPoint2Context();

            context.Database.EnsureDeleted();
            context.Database.EnsureCreated();


            ICollection<Controle> controlesEmilie = new List<Controle>
            {
                new Controle { ControleNote = 6 },
                new Controle { ControleNote = 20 },
                new Controle {ControleNote=15}
            };
            ICollection<Controle> controlesColas = new List<Controle>
            {
                new Controle { ControleNote = 6 },
                new Controle { ControleNote = 20 },
                new Controle {ControleNote=15}
            };
            ICollection<Controle> controlesSophie = new List<Controle>
            {
                new Controle { ControleNote = 6 },
                new Controle { ControleNote = 20 },
                new Controle {ControleNote=15}
            };

            ICollection<Controle> controlesRooarii = new List<Controle>
            {
                new Controle { ControleNote = 6 },
                new Controle { ControleNote = 20 },
                new Controle {ControleNote=15}
            };

            ICollection<Controle> controlesLisaLou = new List<Controle>
            {
                new Controle { ControleNote = 6 },
                new Controle { ControleNote = 20 },
                new Controle {ControleNote=15}
            };

            ICollection<Student> studentCsharp = new List<Student>
            {
                 new Student { StudentFirstName = "Emilie", StudentLastName = "Delsol", ControlesList = controlesEmilie },
                new Student { StudentFirstName = "Colas", StudentLastName = "Durcy", ControlesList = controlesColas },
                new Student { StudentFirstName = "Sophie", StudentLastName = "Brultet", ControlesList = controlesSophie },
        };

            ICollection<Student> studentJS = new List<Student>
            {
                new Student { StudentFirstName = "Rooarii", StudentLastName = "Manuel", ControlesList = controlesRooarii },
                new Student { StudentFirstName = "Lisa-Lou", StudentLastName = "Kara", ControlesList = controlesLisaLou }
        };



            Promotion Csharp = new Promotion { PromotionName = "c#", Students = studentCsharp };
            Promotion JS = new Promotion { PromotionName = "JS", Students = studentJS };
            context.AddRange(Csharp,JS);
            context.SaveChanges();
        }
    }
}
