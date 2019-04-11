using Avonale_Web.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Avonale_Web.Controllers
{
    public class RepositoriosController : Controller
    {
        /// <summary>
        /// Retorna todos os repositórios
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            return View(GitRepositorios.TodosRepositorios());

        }
        
        /// <summary>
        /// Seção de buscar repositório pelo nome exato ou nome parcial
        /// </summary>
        /// <param name="filtro"> Palavra para ser filtrada </param>
        /// <param name="opcao"> True para filtro exato ou false para filtro parcial </param>
        /// <returns></returns>
        public ActionResult Buscar(string filtro, bool? opcao)
        {
            if (filtro == null)
            {
                return View(GitRepositorios.TodosRepositorios());
            }
            if (opcao == true)
            {
                return View(GitRepositorios.TodosRepositorios().Where(a => a.name == filtro).ToList());
            }
            else
            {
                return View(GitRepositorios.TodosRepositorios().Where(a => a.name.ToUpper().Contains(filtro.ToUpper())).ToList());
            }

        }

        /// <summary>
        /// Seção de detalhes do repositório
        /// </summary>
        /// <param name="filtro"> Nome do repositório a ser detalhado </param>
        /// <returns></returns>
        public ActionResult Detalhar(string filtro)
        {
            return View(GitRepositorios.TodosRepositorios().Find(a => a.name == filtro));
        }

        /// <summary>
        /// Salva se um repositório é ou não favorito
        /// </summary>
        /// <param name="nome"> nome do repositório a ser salvo</param>
        /// <param name="novoFavorito"> Se true é favorito se null não é favorito</param>
        /// <returns> Retorna para view meus repositórios </returns>
        public ActionResult SalvarFavorito(string nome, bool? novoFavorito)
        {
            if(novoFavorito == null)
            {
                novoFavorito = false;
            }

            GitRepositorios.TodosRepositorios().Find(a => a.name == nome).favorito = novoFavorito.Value;

            return View("Index",GitRepositorios.TodosRepositorios());
        }

        public ActionResult ListarFavoritos()
        {
            return View(GitRepositorios.TodosRepositorios().Where(a => a.favorito == true).ToList());

        }
    }

}