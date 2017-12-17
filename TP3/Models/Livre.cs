namespace TP3.Models
{
    public class Livre
    {
        public string isbn { get; set; }
        public string author { get; set; }
        public string title { get; set; }
        public int nbPages { get; set; }
        public string edition { get; set; }
        public int year { get; set; }
        public string language { get; set; }
        public string description { get; set; }
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
