namespace ACME.BL
{
    public class DetalleOrden
    {
        public int ID { get; set; }
        public Producto Producto { get; set; }
        public int Cantidad { get; set; }
        public decimal PrecioDeVenta { get; set; }
    }
}
