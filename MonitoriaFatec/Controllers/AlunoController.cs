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
    public class AlunoController : Controller
    {
        // GET: Aluno
        public ActionResult Index()
        {
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

        
        public ActionResult Mensagem()
        {
            
             return View();
        }

        public ActionResult Logout()
        {
            return RedirectToAction("Index", "Login", "Index");
        }

        public ActionResult Envia(String header, String body)
        {
            MensagemDAO dao = new MensagemDAO();

            USERMESSAGE mensagem = new USERMESSAGE
            {
                IDAUTHOR = 5,
                IDRECIVER = 4,
                HEADER = header,
                BODY = body,
                MESSAGEDATE = DateTime.Now,
                IDTYPEMESSAGE = 2,
            };


            dao.Envia(mensagem);

            return View("Index");

        }

        


        public void AtualizaCampos()
        {
            CalendarioDao daoCalendario = new CalendarioDao();
            var agenda = daoCalendario.Lista();
            ViewBag.Agenda = agenda;

            ConteudoDAO daoConteudo = new ConteudoDAO();
            var conteudos = daoConteudo.Lista();
            ViewBag.Conteudos = conteudos;
        }

    }
}