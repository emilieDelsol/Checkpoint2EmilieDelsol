using System;
using System.Collections.Generic;
using System.Text;

namespace DALCheckPoint2EmilieD
{
    class Promotion
    {
        public Int32 PromotionId { get; set; }
        public String PromotionName { get; set; }
        public ICollection<Student> Students { get; set; }
        public Int32 StudentId { get; set; }

    }
}
