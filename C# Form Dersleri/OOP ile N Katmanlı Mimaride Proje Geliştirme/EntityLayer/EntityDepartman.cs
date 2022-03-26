using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class EntityDepartman
    {
        private int id;
        private string ad;
        private string aciklama;

        public int Id { get => id; set => id = value; }
        public string Ad { get => ad; set => ad = value; }
        public string Aciklama { get => aciklama; set => aciklama = value; }
    }
}
