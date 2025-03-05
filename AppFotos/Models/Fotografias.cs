using System.ComponentModel.DataAnnotations.Schema;

namespace AppFotos.Models
{
    /// <summary>
    /// Fotografias á venda na aplicação
    /// </summary>
    public class Fotografias
    {

        public int ID { get; set; }
        public string Titulo { get; set; }

        public string Descricao { get; set; }
        public string Ficheiro { get; set; }

        public DateTime Data { get; set; }

        public decimal Preco { get; set; }


        /* *************************
         * Definicao dos relacionamentos
         * ***************************
         */
        /// <summary>
        /// AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA
        /// </summary>
        [ForeignKey(nameof(Categoria))]
        public int CategoriaFK { get; set; }
        /// <summary>
        /// FK para as categorias
        /// </summary>
        public Categorias Categoria { get; set; }

        public ICollection<Gostos> ListaGostos { get; set; }

        public ICollection<Compras> ListaCompras { get; set; }

    }
 }
