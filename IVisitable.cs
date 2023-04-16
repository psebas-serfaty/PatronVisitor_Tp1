using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronVisitor_Tp1
{
    public interface IVisitable
    {
        double Aceptar(IVisitor v);
    }
}
