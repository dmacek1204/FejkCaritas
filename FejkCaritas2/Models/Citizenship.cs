using FejkCaritas.Models;
using System.Collections.Generic;
using System.Collections.ObjectModel;

public class Citizenship
{
    public int ID { get; set; }
    public string Name { get; set; }
    public ICollection<Volunteer> Volunteers { get; set; }
}
