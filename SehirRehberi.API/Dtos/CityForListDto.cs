using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SehirRehberi.API.Dtos
{
    public class CityForListDto
    {
        //Kullanıcıya hangi bilgiler göndermek istiyorsak onları ekleyeceğiz
        //SQL de join işlemleri gibi

        public int Id { get; set; }
        public string Name { get; set; }
        public string PhotoURL { get; set; }
        public string Description { get; set; }


    }
}
