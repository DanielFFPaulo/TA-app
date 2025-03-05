namespace AppFotos.Models
{
    /// <summary>
    /// utilizadores nao anonimos da aplicação
    /// </summary>
    public class Utilizadores
    {
        /// <summary>
        /// identificador unico da conta do utilizador
        /// </summary>
        public int ID { get; set; }
        /// <summary>
        /// nome do utilizador
        /// </summary>
        public string nome { get; set; }
        /// <summary>
        /// morada do utilizador
        /// </summary>
        public string morada { get; set; }
        /// <summary>
        /// casa do utilizador
        /// </summary>
        public string MyProperty { get; set; }
        /// <summary>
        /// codigo postal do utilizador
        /// </summary>
        public string CodPostal { get; set; }
        /// <summary>
        /// pais de residencia do utilizador
        /// </summary>
        public string Pais { get; set; }
        /// <summary>
        /// numero de identificacao fiscal do utilizador
        /// </summary>
        public string NIF { get; set; }
        /// <summary>
        /// numero de telemovel
        /// </summary>
        public string Telemovel { get; set; }
    }
}
