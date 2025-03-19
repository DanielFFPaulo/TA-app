using System.ComponentModel.DataAnnotations;

namespace AppFotos.Models {

   /// <summary>
   /// utilizadores não anónimos da aplicação
   /// </summary>
   public class Utilizadores {

      /// <summary>
      /// Identificador do utilizador
      /// </summary>
      [Key]
      public int Id { get; set; }

        /// <summary>
        /// Nome do utilizador
        /// </summary>
        [Display(Name = "Nome")]
        [StringLength(50)]
        [Required(ErrorMessage = "O {0} é obrigatorio")]
        public string Nome { get; set; }

        /// <summary>
        /// Morada do utilizador
        /// </summary>
        [Display(Name = "Morada")]
        [StringLength(50)]
        public string Morada { get; set; }

        /// <summary>
        /// Código Postal da  morada do utilizador
        /// </summary>

        [Display(Name = "Código Postal")]
        [StringLength(50)]
        [RegularExpression("[0-9]{4}-[0-9]{3}([a-zA-Z] *)?", ErrorMessage = "O {0} deve ser composto por 8 algarismos")]
        public string CodPostal { get; set; }

        /// <summary>
        /// País da morada do utilizador
        /// </summary>
        [Display(Name = "Pais")]
        [StringLength(50)]
        public string Pais { get; set; }

        /// <summary>
        /// Número de identificação fiscal do Utilizador
        /// </summary>
        [Display(Name = "NIF")]
        [StringLength(9)]
        [RegularExpression("[123578][0-9]{8}", ErrorMessage = "O {0} deve ser composto por 9 algarismos")]
        [Required(ErrorMessage = "O {0} é de preenchimento obrigatório")]
        public string NIF { get; set; }

        /// <summary>
        /// número de telemóvel do utilizador
        /// </summary>
        [Display(Name = "Telemovel")]
        [StringLength(9)]
        [RegularExpression("(([+]|00)[0-9]{2,5})?[1-9][0-9]{5,10}")]
        public string Telemovel { get; set; }
        /*
         * 
         * 
         * 
         * 
         */


      /* *************************
     * Definção dos relacionamentos
     * ************************** 
     */

      /// <summary>
      /// Lista das fotografias que são propriedade do 
      /// utilizador
      /// </summary>
      public ICollection<Fotografias> ListaFotos { get; set; }

      /// <summary>
      /// Lista dos 'gostos' de fotografias do utilizador
      /// </summary>
      public ICollection<Gostos> ListaGostos { get; set; }

      /// <summary>
      /// Lista das fotografias compradas pelo utilizador
      /// </summary>
      public ICollection<Compras> ListaCompras { get; set; }



   }
}
