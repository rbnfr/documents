using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prueba28agosto
{
    class ComprobarTotal
    {
     // public event EventHandler<TotalEventArgs> PublishTotalEventArgs;
     // public event TotalEventArgs PublishTotalEventArgs;
        public delegate void TotalEventHandler(object obj, TotalEventArgs a);

        public void ComprobarCaja()
        {
            var caja = Caja.InstanceCaja;
            if (caja.Total >= 200)
            {
                OnPublishTotalEventArgs(new TotalEventArgs(caja.Total));
            }

        }
        protected virtual void OnPublishTotalEventArgs(TotalEventArgs e)
        {
            //TODO
        }
    }
}
