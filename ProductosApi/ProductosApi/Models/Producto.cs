namespace ProductosApi.Models
{
    public class Producto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; } = "";
        public double Precio { get; set; }
        public double DescuentoPorcentaje { get; set; } = 0;
        public double Rating { get; set; } = 0;
        public int Stock { get; set; } = 0;
        public string Marca { get; set; } = "";
        public string Categoria { get; set; } = "";
        public string Imagen { get; set; } = "";
        public string[] Imagenes { get; set; } = new string[] { };
    }
}
