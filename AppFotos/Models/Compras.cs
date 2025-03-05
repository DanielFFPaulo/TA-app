using System.ComponentModel.DataAnnotations.Schema;

namespace AppFotos.Models
{
    /// <summary>
    /// compras efetuadas pelos utilizadores
    /// </summary>
    public class Compras
    {
        public int ID { get; set; }

        public enum Estados{
            Pendente,
            Pago,
            Enviado,
            Entregue
        }




        /// <summary>
        /// FK para refereciar o dono da fotografia
        /// </summary>
        [ForeignKey(nameof(Comprador))]
        public int CompradorFK { get; set; }
        public Utilizadores Comprador { get; set; }

    }
}
