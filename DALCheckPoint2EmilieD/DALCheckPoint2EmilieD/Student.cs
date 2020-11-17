using System;
using System.Collections.Generic;
using System.Text;

namespace DALCheckPoint2EmilieD
{
    class Student
    {
        public Int32 StudentId { get; set; }
        public String StudentLastName { get; set; }
        public String StudentFirstName { get; set; }
        public ICollection<Controle> Controles { get; set; }
        public Int32 PromotionId { get; set; }
        public Int32 ControleId { get; set; }

       
    }
}
