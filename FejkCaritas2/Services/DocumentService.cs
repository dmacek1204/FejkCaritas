using FejkCaritas.Models;
using FejkCaritas2.ServiceInterfaces;
using System.Collections.Generic;
using System.Linq;

namespace FejkCaritas2.Services
{
    public class DocumentService : IDocumentService
    {
        private VolunteerContext _context;

        public DocumentService()
        {
            this._context = new VolunteerContext();
        }

        public Document GetDocument(int id)
        {
            var result = _context.Documents.SingleOrDefault(c => c.ID == id);
            return result;
        }

        public int GetDocumentCountForVolunteer(int volunteerID)
        {
            var result = _context.Documents.Where(d => d.VolunteerId == volunteerID).OrderBy(e => e.StartDate);

            return result.Count();
        }

        public IEnumerable<Document> GetDocumentsForVolunteer(int volunteerID, int pageIndex, int pageSize)
        {
            var result = _context.Documents.Where(c => c.VolunteerId == volunteerID).OrderBy(c => c.StartDate);

            return result.Skip(pageIndex * pageSize).Take(pageSize).ToList();
        }

        public bool AddDocument(Document document)
        {
            _context.Documents.Add(document);

            try
            {
                _context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool UpdateDocument(Document document)
        {
            var dbDocument = _context.Documents.SingleOrDefault(c => c.ID == document.ID);
            dbDocument.StartDate = document.StartDate;
            dbDocument.EndDate = document.EndDate;
            dbDocument.NumberOfHours = document.NumberOfHours;
            dbDocument.DocumentTypeID = document.DocumentTypeID;
            try
            {
                _context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool DeleteDocument(int id)
        {
            var dbDocument = _context.Documents.SingleOrDefault(c => c.ID == id);
            _context.Documents.Remove(dbDocument);
            try
            {
                _context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}