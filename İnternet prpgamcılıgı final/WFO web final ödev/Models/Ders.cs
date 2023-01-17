using Microsoft.Data.SqlClient;
using System.Data.SqlClient;

namespace WVO.Models

{//Id, Ad, Kredisi, OkulYonetimId(Dersi veren Öğretim görevlisi)
    
    public class Ders
    {

        
        public int Id { get; set; }
        public String Ad { get; set; }
        public String Kredisi { get; set; }
        public String OkulYönetimId { get; set; }

        public String Controler{ get; set; }
    }
}
