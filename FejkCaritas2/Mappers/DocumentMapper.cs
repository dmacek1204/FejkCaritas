using FejkCaritas2.Views;
using System.Collections.Generic;

namespace FejkCaritas2.Mappers
{
    public class DocumentMapper
    {
        public DocumentView MapDocumentToDocumentView(Document document)
        {
            var result = new DocumentView()
            {
                ID = document.ID,
                StartDate = document.StartDate,
                EndDate = document.EndDate,
                NumberOfHours = document.NumberOfHours,
                DocumentTypeID = document.DocumentTypeID,
                DocumentType = new DocumentTypeView()
                {
                    ID = document.DocumentType.ID,
                    Name = document.DocumentType.Name
                },
                VolunteerId = document.VolunteerId
            };
            return result;
        }

        public IEnumerable<DocumentView> MapDocumentCollectionToDocumentViewCollection(IEnumerable<Document> documentColl)
        {
            var result = new List<DocumentView>();
            foreach (var document in documentColl)
            {
                result.Add(MapDocumentToDocumentView(document));
            }
            return result;
        }

        public Document MapDocumentViewToDocument(DocumentView document)
        {
            var result = new Document()
            {
                ID = document.ID,
                StartDate = document.StartDate,
                EndDate = document.EndDate,
                NumberOfHours = document.NumberOfHours,
                DocumentTypeID = document.DocumentType.ID,
                VolunteerId = document.VolunteerId
            };
            return result;
        }
    }
}