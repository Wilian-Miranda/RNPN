using RNPN.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RNPN.Service
{
    public interface IPersona
    {
        void Guardar(Persona persona);
        ICollection<Persona> ListaPersonas();
    }
}
