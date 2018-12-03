using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FejkCaritas.Models
{
    public class Sex
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public ICollection<Volunteer> Volunteers { get; set; }
    }
}

