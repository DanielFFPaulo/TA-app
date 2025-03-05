namespace AppFotos.Models
{
    /// <summary>
    /// Categorias a que as fotografias pode ser associadas
    /// </summary>
    public class Categorias
    {
        public int Id { get; set; }
        public string Categoria { get; set; }

        public ICollection<Fotografias> ListaFotografias { get; set; }
    }
}
