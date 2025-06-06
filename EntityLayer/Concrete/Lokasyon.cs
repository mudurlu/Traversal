﻿using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete
{
    public class Lokasyon
    {
        [Key]
        public int LokasyonId { get; set; }
        public string Sehir { get; set; }
        public string GunGece { get; set; }
        public double Fiyat { get; set; }
        public string Aciklama { get; set; }
        public string Resim { get; set; }
        public int Kapasite { get; set; }
        public bool Durum { get; set; }
    }
}
