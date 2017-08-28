using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prueba28agosto
{
    class ComprobarTotal
    {
        public event EventHandler<TotalEventArgs> PublishTotalEventArgs;

        public void ComprobarCaja()
        {
            var caja = Caja.InstanceCaja;
            if (caja.Total >= 200)
            {
                var ticket = new Ticket();

                OnPublishTotalEventArgs(new TotalEventArgs(5,caja.Total));
            }

        }
        protected virtual void OnPublishTotalEventArgs(TotalEventArgs e)
        {
            
        }
    }
}
