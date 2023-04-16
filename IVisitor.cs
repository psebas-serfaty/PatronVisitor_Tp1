using PatronVisitor_Tp1.PatronVisitor2Iva;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronVisitor_Tp1
{
    public interface IVisitor
    {
        double Visitar(ProductoClase1 p);
        double Visitar(ProductoClase2 p);
    }
}
