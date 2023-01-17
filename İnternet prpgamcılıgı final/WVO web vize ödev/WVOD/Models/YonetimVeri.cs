namespace WVO.Models
{
    public class YonetimVeri
    {
        public static List<Yonetim> Yöneticiler = new List<Yonetim>()
        {
            new Yonetim()
            {
                Id = 1,
                Ad = "Emrah",
                Soyad = "Sarı",
                Gorevi = "Ögretmen",
                YonetimTip11 ="yok",
                YonetimTip12 ="Ögretmen",
                YonetimTip13 ="yok",

            },
            new Yonetim()
            {
                Id = 2,
                Ad = "Sener",
                Soyad = "Sözer",
                Gorevi = "Calısan",
                YonetimTip11 ="yok",
                YonetimTip12 ="yok",
                YonetimTip13 ="Ögrenci isleri" ,
            },
            new Yonetim()
            {
                Id = 3,
                Ad = "Ali",
                Soyad = "Sazcı",
                 Gorevi = "Calısan",
                YonetimTip11 ="yok",
                YonetimTip12 ="yok",
                YonetimTip13 ="Ögrenci isleri" ,
            },
            new Yonetim()
            {
                Id = 4,
                Ad = "Veli",
                Soyad = "sezer",
                 Gorevi = "Calısan",
                YonetimTip11 ="İdare",
                YonetimTip12 ="yok",
                YonetimTip13 ="yok" ,
            },
        };
    }
}
