using MonitoriaFatec.DAO;
using MonitoriaFatec.Filtros;
using MonitoriaFatec.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MonitoriaFatec.Controllers
{
    [AutorizacaoFilterAttribute]
    public class ProfessorController : Controller
    {
        // GET: Professor
        public ActionResult Index()
        {
            
            return View();
        }


        public ActionResult Aprovar()
        {
            AtualizaCampos();
            return View();
        }

        public ActionResult Postar()
        {
            AtualizaCampos();
            return View();
        }


        public ActionResult Cadastrar()
        {
            AtualizaCampos();
            return View();
        }

        public ActionResult Logout()
        {
            return RedirectToAction("Index", "Login", "Index");
        }

        public ActionResult PostarMaterial(String titulo, String tipoConteudo, String url, String descricao)
        {
            var usuario = Session["usuarioLogado"] as USUARIO;
            ConteudoDAO daoConteudo = new ConteudoDAO();
            CONTENT conteudo = new CONTENT
            {
                IDAUTHOR = usuario.IDUSER,
                TITLE = titulo,
                IDTYPECONTENT = Int32.Parse(tipoConteudo),
                CONTENT1 = url,
                INFOCONTENT = descricao,
                DATECONTENT = DateTime.Now,
                IDSTATUS = 2
            };
            daoConteudo.Cadastrar(conteudo);
            AtualizaCampos();
            return View("Postar");
        }


        public ActionResult CadastrarMonitor(String idAluno)
        {
            UsuariosDAO daoUsuario = new UsuariosDAO();
            USUARIO usuario = new USUARIO();
            usuario = daoUsuario.BuscaPorId(Int32.Parse(idAluno));
            USUARIO monitor = new USUARIO
            {
                NMUSER = usuario.NMUSER,
                EMAILUSER = idAluno + "@monitor.com",
                USERPASSWORD = idAluno + "@monitor.com" + "1234",
                IDSCOPE = 5
            };
            daoUsuario.Cadastra(monitor);
            AtualizaCampos();
            return View("Cadastrar");
        }

        public void AtualizaCampos()
        {
            UsuariosDAO daoUsuarios = new UsuariosDAO();
            IList<USUARIO> alunos = daoUsuarios.ListaPorEscopo(5);
            ViewBag.Alunos = alunos;

            TipoConteudoDAO daoTipoConteudo = new TipoConteudoDAO();
            IList<TYPECONTENT> tiposConteudo = daoTipoConteudo.Lista();
            ViewBag.TiposConteudo = tiposConteudo;


            ConteudoDAO daoConteudo = new ConteudoDAO();
            var conteudos = daoConteudo.Lista();
            ViewBag.Conteudos = conteudos;

        }
    }
}