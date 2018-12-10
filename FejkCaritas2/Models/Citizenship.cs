using FejkCaritas.Models;
using System.Collections.Generic;

public class Citizenship
{
    public int ID { get; set; }
    public string Name { get; set; }
    public ICollection<Volunteer> Volunteers { get; set; }
}
