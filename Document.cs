using System;
using System.Collections.Generic;
using static Lab03Library.Exception;

namespace Lab03Library
{
    public enum Frequencies
    {
        Daily,
        Weekly,
        Monthly,
        Yearly
    }

    public abstract class Document
    {
        public long ISBN { get; set; }
        public string Title { get; set; }
        public int PublicationYear { get; set; }
        public int NumberOfPages { get; set; }

        public Document()
        {
        }

        public Document(long iSBN, string title, int publicationYear, int numberOfPages)
        {
            ISBN = iSBN;
            Title = title;
            PublicationYear = publicationYear;
            NumberOfPages = numberOfPages;
        }

        public abstract string Print();

        public override string ToString()
        {
            return $"ISBN: {ISBN}, Title: {Title}, Publication year: {PublicationYear}, Number of pages: {NumberOfPages}";
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(ToString());
        }

        public override bool Equals(object obj)
        {
            return ToString() == obj.ToString();
        }

        public static bool operator ==(Document a, Document b)
        {
            if (a is null && b is null)
            {
                return true;
            }
            else if (a is null || b is null)
            {
                return false;
            }
            else
            {
                return a.Equals(b);
            }
        }

        public static bool operator !=(Document a, Document b)
        {
            if(a is null && b is null)
            {
                return false;
            }
            else if (a is null || b is null)
            {
                return true;
            }
            else
            {
                return !a.Equals(b);
            }
            
        }

        public virtual void validate(List<Document> docs)
        {
            if(docs.Find(d => d.ISBN == ISBN) != null)
            {
                throw new AddDocumentException("Dokument o podanym ISBN już istnieje");
            }
        }

    }

    public class Book : Document
    {
        public string Author { get; set; }


        public Book()
        {
        }

        public Book(long iSBN, string title, int publicationYear, int numberOfPages, string author) : base(iSBN, title, publicationYear, numberOfPages)
        {
            Author = author;
        }

        public override string ToString()
        {
            return $"{base.ToString()}, Autor: {Author}";
        }

        public override string Print()
        {
            return "Wydrukowano ksiązkę";
        }

        public override void validate(List<Document> docs)
        {
            base.validate(docs);
            if (PublicationYear < 1450)
            {
                throw new AddBookException("Ksiązka nie mogła zostać wydana przed wynalezieniem druku");
            }
        }
    }

    public class Volume : Book
    {
        public int Number { get; set; }
        public int VolumesTotal { get; set; }
        public Volume()
        {
        }

        public Volume(long iSBN, string title, int publicationYear, int numberOfPages, string author, int number, int volumesTotal) : base(iSBN, title, publicationYear, numberOfPages, author)
        {
            Number = number;
            VolumesTotal = volumesTotal;
        }

        public override string ToString()
        {
            return $"{base.ToString()}, Number tomu: {Number}, Volumes total: {VolumesTotal}";
        }

        public override string Print()
        {
            return "Wydrukowano tom";
        }

        public override void validate(List<Document> docs)
        {
            base.validate(docs);
            foreach (var doc in docs)
            {
               if(doc is Volume)
                {
                    if(doc.Title == Title || ((Volume)doc).Number == Number)
                    {
                        throw new AddVolumeException("Tom o podanym tytule i/lub numerze tomu już istnieje");
                    }

                    if(((Volume)doc).VolumesTotal < Number)
                    {
                        throw new AddVolumeException("Podany numer tomu jest większy niz liczba wszystkich numerów serii");
                    }
                }
            }
        }

    }

    public class Magazine : Document
    {
        public int Number { get; set; }
        public Frequencies Frequency { get; set; }

        public Magazine()
        {
        }

        public Magazine(long iSBN, string title, int publicationYear, int numberOfPages, int number, Frequencies frequency) : base(iSBN, title, publicationYear, numberOfPages)
        {
            Number = number;
            Frequency = frequency;
        }

        public override string ToString()
        {
            return $"{base.ToString()}, Number: {Number}, Frequency: {Frequency}";
        }

        public override string Print()
        {
            return "Wydrukowano czasopismo";
        }
    }
}
