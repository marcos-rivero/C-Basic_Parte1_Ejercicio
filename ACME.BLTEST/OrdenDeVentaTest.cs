using ACME.BL;

namespace ACME.BLTEST
{
    public class OrdernDeVentaTest
    {
        private OrdenDeVenta _ordenDeVenta;
        [SetUp]
        public void Setup()
        {
            var ordenDeVenta = new OrdenDeVenta();
            ordenDeVenta.FechaDeOrden = DateTime.Now;
            ordenDeVenta.DetallesDeOrden = new List<DetalleOrden>();
            ordenDeVenta.DetallesDeOrden?.Add(new DetalleOrden
            {
                Producto = new Producto
                {
                    NombreDelProducto = "Azucar",
                    Descripcion = "Azucar Ledesma 1kg",
                    PrecioActual = 1025.5m
                },
                PrecioDeVenta = 1070.6m,
                Cantidad = 6
            });
            ordenDeVenta.DetallesDeOrden?.Add(new DetalleOrden
            {
                Producto = new Producto
                {
                    NombreDelProducto = "Yerba",
                    Descripcion = "Yerba Cachamai 500grs",
                    PrecioActual = 3025.7m
                },
                PrecioDeVenta = 4025.6m,
                Cantidad = 5
            });
            _ordenDeVenta = ordenDeVenta;
        }

        [Test]
        public void CalcularTotalPrecioActualOrden_OrdenDeVenta_RetornarTotalActual()
        {
            
            Assert.Pass();
        }
        [Test]
        public void CalcularTotalPrecioActualOrden_OrdenDeVentaAgregandoMasProductos_RetornarTotalActual()
        {

            Assert.Pass();
        }
        [Test]
        public void CalcularTotalPrecioVentaPorOrden_OrdenDeVenta_RetornarTotal()
        {
            Assert.Pass();
        }
        [Test]
        public void CalcularTotalPrecioVentaPorOrden_OrdenDeVentaAgregandoMasProductos_RetornarTotalVenta()
        {
            Assert.Pass();
        }
    }
}