using RNPN.Data;
using RNPN.Dominio;
using RNPN.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RNPN.Repository
{
    public class PersonaRepository : IPersona
    {
        AppDbContext appDb;

        public PersonaRepository(AppDbContext appDb)
        {
            this.appDb = appDb;
        }

        public void Guardar(Persona persona)
        {
            appDb.Add(persona);
            appDb.SaveChanges();
        }

        public ICollection<Persona> ListaPersonas()
        {
            return appDb.Persona.ToList();
        }
    }
}
