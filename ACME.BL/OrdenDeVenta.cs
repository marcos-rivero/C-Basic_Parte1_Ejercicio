namespace ACME.BL
{
    public class OrdenDeVenta
    {
        public int ID { get; set; }
        public List<DetalleOrden> DetallesDeOrden { get; set; }
        public DateTime FechaDeOrden { get; set; }
        public decimal CalcularTotalPrecioActualOrden()
        {
            //Modificar codigo y retornar valor correcto
            return 0;
        }
        public decimal CalcularTotalPrecioVentaPorOrden() 
        {
            //Modificar codigo y retornar valor correcto
            return 0;
        }
    }
}
