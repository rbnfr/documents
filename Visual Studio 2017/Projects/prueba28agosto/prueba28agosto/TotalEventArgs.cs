using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prueba28agosto
{
    class TotalEventArgs : EventArgs
    {
        public int Id { get; set; }
        public decimal Total { get; set; }
        public TotalEventArgs(decimal total)
        {
            Total = total;
        }
    }
}
