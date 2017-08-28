using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prueba28agosto
{
    class Caja
    {
        // Variable estática asignada con expresión lambda dado que el constructor es privado
        private static readonly Lazy<Caja> instanceCaja = new Lazy<Caja>(() => new Caja()); 

        // variable que almacena el total que hay en la caja
        public decimal Total { get; set; }

        // Lista de tickets de la caja
        public List<Ticket> tickets { get; set; }

        // Declaracion del delegado del evento
        public delegate void TotalEventArgs (object obj, EventArgs e);

        // Declaracion del evento


        // Constructor privado para evitar instanciarlo directamente
        private Caja()
        {
            tickets = new List<Ticket>();
        } 

        public static Caja InstanceCaja
        {
            get
            {
                return instanceCaja.Value;
            }
        }

        public void AddTicket(Ticket ticket, int id)
        {
            if (null == ticket)
            {
                throw new Exception("Empty ticket");
            }
            tickets.Add(ticket);
            Total += ticket.Import;
        }
    }

}
