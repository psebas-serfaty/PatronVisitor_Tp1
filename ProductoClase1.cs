using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronVisitor_Tp1
{
    public class ProductoClase1 : Producto
    {
        public override double Aceptar(IVisitor v)
        {
            return v.Visitar(this);
        }
    }
}
    

