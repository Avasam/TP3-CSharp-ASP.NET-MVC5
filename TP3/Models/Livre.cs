public class Livre {
    public string isbn;
    public string author;
    public string title;
    public int nbPages;
    public string edition;
    public int year;
    public string language;
    public string description;
    public string keywords;

    public Livre(string isbn, string author, string title, int nbPages, string edition, int year, string language, string description, string keywords) {
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
