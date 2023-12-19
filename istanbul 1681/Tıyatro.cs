using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace istanbul_1681
{
    internal class oyun
    {
        public int ıd { get; set; }
        public int oyunAd { get; set; }
        public string sahne { get; set; }
        public DateTime tarih { get; set; }
        public int sure { get; set; }
        public double Ucret { get; set; }
        public bool Muzikal { get; set; }

        public oyun(int id, string oyunAd, string sahne, DateTime tarih, int sure, double ucret, bool muzikal)
        {
            ıd = id;
           

        }
            

}

    
}
