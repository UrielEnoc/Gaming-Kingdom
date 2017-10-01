using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Producto
    {
            

        public int CodProd { get; set; }
        public TipoProd TipoProd { get; set; }
        public String NombreProd { get; set; }
        public int PrecioProd { get; set; }

        public Producto()
        {
            this.Init();
        }
        private void Init() {
            CodProd = 0;
            TipoProd = 0;
            NombreProd = string.Empty;
            PrecioProd = 0;

        }
      
    }
}
