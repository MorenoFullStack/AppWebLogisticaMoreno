using AppWebLogisticaMoreno.Models.Entidades;
using Microsoft.AspNetCore.Mvc;

namespace AppWebLogisticaMoreno.Controllers

{
    public class MOrdenCompraController : Controller
    {
        public List<MOrdenCompra> GetDatosOrdenCompra()
        {
            var listado = new List<MOrdenCompra>();
            listado.Add(new MOrdenCompra
            {
                idOrdenCompra = 1,
                Proveedor = "Maestro",
                Descripcion = "Permo de 1/2 x 3/4",
                UnidadMedida = "Und",
                Cantidad = 10,
                Precio = 5,


            });
            listado.Add(new MOrdenCompra
            {
                idOrdenCompra = 2,
                Proveedor = "Sodimac",
                Descripcion = "Permo de 1/2 x 3/4",
                UnidadMedida = "Und",
                Cantidad = 10,
                Precio = 5,
            });
            listado.Add(new MOrdenCompra
            {
                idOrdenCompra = 3,
                Proveedor = "Redondos",
                Descripcion = "Permo de 1/2 x 3/4",
                UnidadMedida = "Und",
                Cantidad = 10,
                Precio = 5,
            });
            listado.Add(new MOrdenCompra
            {
                idOrdenCompra = 4,
                Proveedor = "Maestro",
                Descripcion = "Permo de 1/2 x 3/4",
                UnidadMedida = "Und",
                Cantidad = 10,
                Precio = 5,
            });
            listado.Add(new MOrdenCompra
            {
                idOrdenCompra = 5,
                Proveedor = "Sodimac",
                Descripcion = "Permo de 1/2 x 3/4",
                UnidadMedida = "Und",
                Cantidad = 10,
                Precio = 5,
            });
            listado.Add(new MOrdenCompra
            {
                idOrdenCompra = 6,
                Proveedor = "Maestro",
                Descripcion = "Permo de 1/2 x 3/4",
                UnidadMedida = "Und",
                Cantidad = 10,
                Precio = 5,
            });
            return listado;
        }
        public IActionResult Index()
        { var listado =GetDatosOrdenCompra();
            return View(listado);
        }
    }
}