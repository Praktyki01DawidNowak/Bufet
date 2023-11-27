namespace Bufet.Models
{
    public class Zamowienia
    {
        public int Id { get; set; }
        public string Zamowienie { get; set; }
        public DateTime Data { get; set; }
        public decimal Cena { get; set; }

        public int IdKanapki { get; set; }
        public Kanapki? Kanapki { get; set; }
        public int IdUzytkownik { get; set; }
        public Uzytkownik? Uzytkownik { get; set; }
    }
}
