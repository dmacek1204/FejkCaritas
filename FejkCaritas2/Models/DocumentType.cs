using System.Collections.Generic;
using System.Collections.ObjectModel;

public class DocumentType
{
    public int ID { get; set; }
    public string Name { get; set; }
    public ICollection<Document> Documents { get; set; }
}
