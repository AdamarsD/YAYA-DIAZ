using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace labotarioII
{
    public class CarroDeCompras
    {
        public List<ProductosAlCarrro> ListaProductos { get; private set; }
        public static CarroDeCompras CapturarProducto()
        {
            CarroDeCompras _carrito = (CarroDeCompras)HttpContext.Current.Session["ASPCarroDeCompras"];
            if (_carrito == null)
            {
                HttpContext.Current.Session["ASPCarroDeCompras"] = _carrito = new CarroDeCompras();
            }
            return _carrito;
        }
        protected CarroDeCompras()
        {
            ListaProductos = new List<ProductosAlCarrro>();
        }
        public void Agregar(int pIdProducto)
        {
            ProductosAlCarrro NuevoProducto = new ProductosAlCarrro(pIdProducto);
            if (ListaProductos.Contains(NuevoProducto))
            {
                foreach (ProductosAlCarrro item in ListaProductos)
                {
                    if (item.Equals(NuevoProducto))
                    {
                        item.Cantidad++;
                        return;
                    }
                }
            }
            else
            {
                NuevoProducto.Cantidad = 1;
                ListaProductos.Add(NuevoProducto);
            }
        }

        public void EliminarProductos(int pIdProducto)
        {
            ProductosAlCarrro eliminaritems = new ProductosAlCarrro(pIdProducto);
            ListaProductos.Remove(eliminaritems);
        }
        public void CantidadDeProductos(int pIdProducto, int pCantidad)
        {
            if (pCantidad == 0)
            {
                EliminarProductos(pIdProducto);
                return;
            }
            ProductosAlCarrro updateProductos = new ProductosAlCarrro(pIdProducto);
            foreach (ProductosAlCarrro item in ListaProductos)
            {
                if (item.Equals(updateProductos))
                {
                    item.Cantidad = pCantidad;
                    return;
                }
            }
        }
        public decimal SubTotal()
        {
            decimal subtotal = 0;
            foreach (ProductosAlCarrro item in ListaProductos)
            {
                subtotal += item.Total;
            }
            return subtotal;
        }
    }
}