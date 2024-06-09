using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class UpdateSeyahat
    {
        public int Id { get; set; }
        public string Başlık { get; set; }
        public string Açıklama { get; set; }
        public int GünSayısı { get; set; }
        public int ŞehirId { get; set; }

        public decimal Fiyat { get; set; }
        public DateTime Tarih { get; set; }
        public string ImgUrl { get; set; }

    }
}
