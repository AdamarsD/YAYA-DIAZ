using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace labotarioII
{
    public class ProductosAlCarrro : IEquatable<ProductosAlCarrro>
    {
        public int Cantidad { get; set; }
        private int IdProducto;
        private Producto Producto = null;
        public int idProducto
        {
            get { return IdProducto; }
            set
            {
                Producto = null;
                IdProducto = value;
            }
        }
        public Producto producto
        {
            get
            {
                if (producto == null)
                {
                    Producto = new Producto(IdProducto);
                }
                return producto;
            }
        }
        public string Descripcion
        {
            get { return Producto.Descripcion; }
        }
        public decimal PrecioUnitario
        {
            get { return Producto.Precio; }
        }
        public decimal Total
        {
            get { return PrecioUnitario * Cantidad; }
        }
        public ProductosAlCarrro(int pId)
        {
            IdProducto = pId;
        }
        public bool Equals(ProductosAlCarrro pItem)
        {
            return pItem.IdProducto == IdProducto;
        }

    }
}