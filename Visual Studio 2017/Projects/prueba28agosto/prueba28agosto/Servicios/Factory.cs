using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prueba28agosto.Servicios
{
    class Factory
    {
        private object CreateFactory(object obj)
        {
            var type = obj.GetType();
            if (null == type)
            {
                throw new Exception("El tipo del objeto no existe");
            }

            // Crear instancia
            var instance = new type();
        }
    }
}
