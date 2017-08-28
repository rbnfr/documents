using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            var caja = new Caja() { };
            caja.Total += Caja_Total; // Evento += tabulador --> me da la firma de mi delegado. Para quitar la suscripción de un evento se hace con -=
            caja.Total -= Caja_Total;
        }

        private static void Caja_Total(object o, Caja.TotalEventArgs e) // Firma
        {
            throw new NotImplementedException();
        }
    }
    class Ticket
    {
        public int Id { get; set; }
        public decimal Total { get; set; }
    }
    class Caja
    {
        public event TotalEventHandler Total;// Con event defino que total es de eventhandler
        public Caja()
        {
            this.tickets = new List<Ticket>();
        }
        public virtual void OnTotal(TotalEventArgs e)
        {
            var handler = Total;// Aquí se almacena el valor antes de comparar, para que si se cancela la suscripción no se quede total como nulo y falle el código
            if (null != handler)
            {
                handler(this, e);
            }
        }
        public int Id { get; set; }
        public List<Ticket> tickets { get; private set; }

        public delegate void TotalEventHandler(object o, TotalEventArgs e);// Todos los eventos que son delegados--> envent handler. Para definir clases --> evetargs. El delegado es el puntero a la función, es su firma que lo identifica. Con ella se puede suscribir un suscriptor a él.

        public class TotalEventArgs:EventArgs
        {
            public TotalEventArgs(int id, decimal total)
            {
                Id = id;
                Total = total;
            }
            public int Id { get; private set; }
            public decimal Total { get; private set; }
        }
    }
 
}
