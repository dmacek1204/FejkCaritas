using System.Collections.Generic;

namespace FejkCaritas2.ServiceInterfaces
{
    interface IDocumentService
    {
        int GetDocumentCountForVolunteer(int volunteerID);
        Document GetDocument(int id);
        IEnumerable<Document> GetDocumentsForVolunteer(int volunteerID, int pageIndex, int pageSize);
        bool AddDocument(Document document);
        bool UpdateDocument(Document document);
        bool DeleteDocument(int id);
    }
}
