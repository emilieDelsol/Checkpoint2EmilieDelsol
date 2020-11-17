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
        public Int32 PromotionId { get; set; }

        public override string ToString()
        {
            return "Nom: " + StudentLastName + " prénom: " + StudentFirstName + " \n\tId de sa promotion:  "+  PromotionId;
        }
    }
}
