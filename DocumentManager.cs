using System;
using System.Collections.Generic;
using static Lab03Library.Exception;

namespace Lab03Library
{
    public class DocumentManager
    {
        public List<Document> Documents { get; set; }

        public DocumentManager()
        {
            Documents = new List<Document>();
        }

        public void Add(Document doc)
        {
            doc.validate(Documents);
            Documents.Add(doc);
        }

        public void ListToConsole(List<Document>  docs)
        {
            foreach (var doc in docs)
            {
                Console.WriteLine(doc);
            }
        }

        public Document GetByISBN(long ISBN)
        {
            Document doc = Documents.Find(d => d.ISBN == ISBN);
            return doc;
        }

        public List<Document> GetByPhraseInTitle(string phrase)
        {
            List<Document> filteredDocs = new List<Document>();
            foreach (var doc in Documents)
            {
                if (doc.Title.Contains(phrase))
                {
                    filteredDocs.Add(doc);
                }
            }
            return filteredDocs;
        }

        public List<Document> GetByFrequency(Frequencies freq)
        {
            List<Document> filteredDocs = new List<Document>();
            foreach (var doc in Documents)
            {
                if(doc is Magazine)
                {
                    Magazine mag = (Magazine)doc;
                    if (mag.Frequency == freq)
                    {
                        filteredDocs.Add(mag);
                    }
                }
            }
            return filteredDocs;

        }

        public List<Document> GetVolumesByTitle(string title)
        {
            List<Document> filteredDocs = new List<Document>();
            foreach (var doc in Documents)
            {
                if(doc is Volume)
                {
                    Volume vol = (Volume)doc;
                    if (vol.Title == title)
                    {
                        filteredDocs.Add(vol);
                    }
                }
            }
            return filteredDocs;
        }
    }
}

/* void Validate(Document doc)
    {
        if (GetByISBN(doc.ISBN) != null)
        {
            throw new AddDocumentException("Dokument o podanym ISBN już istnieje");
        }

        Document res = Documents.Find(v => v.Title == ((Volume)doc).Title || ((Volume)v).Number == ((Volume)doc).Number);

        if (res != null)
        {
            throw new AddVolumeException("Tom o podanym tytule i/lub numerze tomu już istnieje");
        }

        res = Documents.Find(v => ((Volume)v).VolumesTotal < ((Volume)doc).Number);

        if (res != null)
        {
            throw new AddVolumeException("Podany numer tomu jest większy niz liczba wszystkich numerów serii");
        }

        if (((Book)doc).PublicationYear < 1450)
        {
            throw new AddBookException("Ksiązka nie mogła zostać wydana przed wynalezieniem druku");
        }
    } */