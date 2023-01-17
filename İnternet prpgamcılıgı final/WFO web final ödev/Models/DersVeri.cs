namespace WVO.Models
{
    public class DersVeri
    {
        public static List<Ders> Dersler = new List<Ders>()
        {
            new Ders()
            {
                Id = 1,
                Ad = "İnternet Progamcılıgı",
                Kredisi = "4",
                OkulYönetimId = "3",

            },
            new Ders()
            {
                Id = 2,
                Ad = "Görsel Progamlama",
                Kredisi = "4",
                OkulYönetimId = "3",
            },
            new Ders()
            {
                Id = 3,
                Ad = "Bilgi Güvenligi",
                Kredisi = "4",
                OkulYönetimId = "3",
            },
            new Ders()
            {
                Id = 4,
                Ad = "Deniz liman islemeciligi",
                Kredisi = "4",
                OkulYönetimId = "3",
            },
        };
    }
}
