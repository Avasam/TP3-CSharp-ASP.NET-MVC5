using System.ComponentModel.DataAnnotations;

namespace TP3.Models
{
    public class Livre
    {
        [Required(ErrorMessage = "Un isbn et requis")]
        public string isbn { get; set; }
        [Required(ErrorMessage = "Un auteur et requis")]
        public string author { get; set; }
        [Required(ErrorMessage = "Un title et requis")]
        public string title { get; set; }
        [Required(ErrorMessage = "Un nombre de pages et requis")]
        public int nbPages { get; set; }
        [Required(ErrorMessage = "Une edition et requise")]
        public string edition { get; set; }
        [Required(ErrorMessage = "Une annee et requise"), Range(-9999,9999)]
        public int year { get; set; }
        [Required(ErrorMessage = "Une langue et requise")]
        public string language { get; set; }
        [Required(ErrorMessage = "Une description et requise")]
        public string description { get; set; }
        [Required(ErrorMessage = "Un ou des keywords sont requis")]
        public string keywords { get; set; }

        public Livre(string isbn, string author, string title, int nbPages, string edition, int year, string language, string description, string keywords)
        {
            this.isbn = isbn;
            this.author = author;
            this.title = title;
            this.nbPages = nbPages;
            this.edition = edition;
            this.year = year;
            this.language = language;
            this.description = description;
            this.keywords = keywords;
        }
    }
}
