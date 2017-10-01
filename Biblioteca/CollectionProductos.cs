using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
   public class CollectionProductos:List<Producto>
    {
        public CollectionProductos() { }


        public bool Modifica(CollectionProductos myProduc, int codProd, int precioProd)
        {
            try
            {
                if (myProduc.Exists(r => r.CodProd.Equals(codProd)))
                {
                    myProduc.First(c => c.CodProd.Equals(codProd)).PrecioProd = precioProd;
                    return true;

                }
                else
                {

                    return false;
                }
            }
            catch (Exception)
            {
                return false;

            }

        }
        public bool Elimina(CollectionProductos myProduc, int codigo)
        {
            try
            {
                if (myProduc.Exists(m => m.CodProd.Equals(codigo)))
                {
                    myProduc.Remove(myProduc.First(c => c.CodProd.Equals(codigo)));
                    return true;
                }else
                {
                    return false;
                }
            }
            catch (Exception)
            {

                return false;
            }
        }

        
    }
    

   
}
