using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Avonale_Web.Models
{
    /// <summary>
    /// Classe para deserializar o objeto em Json
    /// </summary>
    public class Repositorio
    {
        /// <summary>
        /// Nome do repositório
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// Descrição do repositório
        /// </summary>
        public string description { get; set; }

        /// <summary>
        /// Linguagem do repositório
        /// </summary>
        public string language { get; set; }

        /// <summary>
        /// Ultima data de atualização
        /// </summary>
        public DateTime updated_at { get; set; }

        /// <summary>
        /// Dono do repositório
        /// </summary>
        public Owner owner { get; set; }

        public bool favorito { get; set; }

    }

    /// <summary>
    /// Classe suporte para deserializar o objeto em Json
    /// </summary>
    public class Owner
    {
        public string login { get; set; }
    }
}