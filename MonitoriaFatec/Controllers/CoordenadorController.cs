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
    public class CoordenadorController : Controller
    {
        // GET: Coordenador
        public ActionResult Index()
        {
           

            return View();
        }

       
        public ActionResult Cadastro()
        {
            AtualizaCampos();
            return View();
        }

        public ActionResult Calendario()
        {
            AtualizaCampos();
            return View();
        }

        public ActionResult Materiais()
        {

            AtualizaCampos();
            return View();
        }

        public ActionResult Logout()
        {
            return RedirectToAction("Index","Login","Index");
        }

        public ActionResult CadastraDisciplina(String nome)
        {
            DISCIPLINE disciplina = new DISCIPLINE();
            disciplina.NMDISCIPLINE = nome;
            DisciplinaDAO dao = new DisciplinaDAO();
            dao.Cadastra(disciplina);
            AtualizaCampos();
            return View("Cadastro");
        }

        public ActionResult CadastraProfessor(String nome, String email)
        {
            UsuariosDAO daoUsuario = new UsuariosDAO();
            USUARIO professor = new USUARIO {
                NMUSER = nome,
                EMAILUSER = email,
                USERPASSWORD = email + "1234",
                IDSCOPE = 3
            };
            daoUsuario.Cadastra(professor);
            return View("Cadastro");
        }

        public ActionResult CadastraAluno(String nome, String email)
        {
            UsuariosDAO daoUsuario = new UsuariosDAO();
            USUARIO aluno = new USUARIO
            {
                NMUSER = nome,
                EMAILUSER = email,
                USERPASSWORD = email + "1234",
                IDSCOPE = 5
            };
            daoUsuario.Cadastra(aluno);
            AtualizaCampos();
            return View("Cadastro");
        }

        public void AtualizaCampos()
        {
            DisciplinaDAO daoDisciplina = new DisciplinaDAO();
            IList<DISCIPLINE> disciplinas = daoDisciplina.Lista();
            ViewBag.Disciplinas = disciplinas;

            CalendarioDao daoCalendario = new CalendarioDao();
            var agenda = daoCalendario.Lista();
            ViewBag.Agenda = agenda;

            ConteudoDAO daoConteudo = new ConteudoDAO();
            var conteudos = daoConteudo.Lista();
            ViewBag.Conteudos = conteudos;

        }
    }
}