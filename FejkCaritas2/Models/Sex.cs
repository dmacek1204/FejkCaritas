using System.Collections.Generic;

namespace FejkCaritas.Models
{
    public class Sex
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public ICollection<Volunteer> Volunteers { get; set; }
    }
}

