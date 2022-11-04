using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SehirRehberi.API.Models
{
    public class City
    {
        public City()
        {
            Photos = new List<Photo>();
        }
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        //Veritabanı ilişkileri gibi düşünülebilir
        //Bir Şehrin birden fazla fotoğrafı olabilir bire çok
        //Bir sŞehrin bir ekleyeni olabilir birebir
        public List<Photo> Photos { get; set; } //şehrin birden fazla fotosu var
        public User User { get; set; } // tek ekleyeni var
    }
}
