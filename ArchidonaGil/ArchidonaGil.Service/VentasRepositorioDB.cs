using ArchidonaGil.Modelos;
using System.Collections.Generic;
using System.Linq;

namespace ArchidonaGil.Services
{
    public class VentasRepositorioDB
    {
        public ExamenDbContext Context { get; set; }

        public VentasRepositorioDB(ExamenDbContext context)
        {
            Context = context;
        }

        public List<Ventas> GetVentas()
        {
            return Context.Ventas.ToList();
        }

        public void InsertarVenta(Ventas venta)
        {
            Context.Ventas.Add(venta);
            Context.SaveChanges();
        }
    }
}