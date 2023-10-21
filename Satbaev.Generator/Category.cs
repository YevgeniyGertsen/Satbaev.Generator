using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Satbaev.Generator
{
    public class Category
    {
        public int Id { get; set; }
        public DateTime CreateData { get; set; }
        public string Name { get; set; }
        public bool IsActiv { get; set; }
        public string ChangeUser { get; set; }
        public DateTime ChangeData { get; set; }
    }
}