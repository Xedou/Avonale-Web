using Avonale_Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Avonale_Web.Services;

namespace Avonale_Web
{
    public class GitRepositorios
    {
        /// <summary>
        /// Variável global para guardar a buscar feita pelo webapi e não precisar buscando outras vezes
        /// </summary>
        public static List<Repositorio> repositoriosGit;

        private GitRepositorios()
        {
        }

        public static List<Repositorio> TodosRepositorios()
        {
            if(repositoriosGit == null)
            {
                repositoriosGit =  new GitApiServices().GetRepositorios();
            }

            return repositoriosGit;
        }

    }
}