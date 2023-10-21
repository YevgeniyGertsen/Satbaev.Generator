using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Satbaev.Generator
{
    public class QuestionTemplate
    {
        public int Id { get; set; }
        public DateTime CreateDate { get; set; }
        public string Question { get; set; }
        public double Mark { get; set; }
        public int HardMark { get; set; }
        public Category Category { get; set; }
    }
}