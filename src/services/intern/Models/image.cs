using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Intern.Models
{
    public class Image
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string URL { get; set; }
        public DateTime Created { get; set; }
    }
}
