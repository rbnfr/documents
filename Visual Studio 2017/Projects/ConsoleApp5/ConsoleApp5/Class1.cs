using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class ServiceBase : IDisposable
    {
        readonly IDisposable _dispose;
        public ServiceBase(IDispose dispose)
        {
            if (null == dispose)
            {
                throw new ArgumentNullException("Dispose");
            }

        }
        public virtual void Dispose
        {

        }

    }
    public class EntityBase
    {
        public guild Id { get; set; }
        public bool IsValid { get; private set; }
        protected void Validate()
        {
            // Validar si lo que vamos a meter en la base de datos es valido o no antes de mandarlo a la base de datos para que nos de el error.
            // Heredando de esta clase, cualquier entidad de nuestro dominio podrá ser validada sin necesidad de que sea la bdd quien nos lo diga.
            // Ahorramos abrir una conexión y recibir el error.
        }
    }
    IUow : IDisposable
        {
            
        }

}
