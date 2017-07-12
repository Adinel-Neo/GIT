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
    public class MonitorController : Controller
    {
        // GET: Monitor
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Calendario()
        {
            AtualizaCampos();
            return View();
        }

        public ActionResult Postar()
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
                IDSTATUS = 1
            };
            daoConteudo.Cadastrar(conteudo);
            AtualizaCampos();
            return View("Postar");
        }

        public ActionResult CadastrarAgenda(String data, String hora, String evento)
        {
            var usuario = Session["usuarioLogado"] as USUARIO;
            DateTime date = DateTime.Parse(data);
            String[] hour = hora.Split(':');
            date = date.AddHours(Convert.ToDouble(hour[0]));
            date = date.AddMinutes(Convert.ToDouble(hour[1]));

            CalendarioDao daoCalendar = new CalendarioDao();
            CALENDAR calendar = new CALENDAR
            {
               DATE_HOUR = date,
               IDMONITOR = usuario.IDUSER,
               EVENTO = evento,
               ID_DISCIPLINE = 1
            };
            daoCalendar.Cadastrar(calendar);
            AtualizaCampos();
            return View("Calendario");
        }

        public ActionResult Excluir(int id)
        {
            CalendarioDao daoCalendario = new CalendarioDao();
            daoCalendario.Excluir(id);
            AtualizaCampos();
            return View("Calendario");
        }

        public void AtualizaCampos()
        {
            TipoConteudoDAO daoTipoConteudo = new TipoConteudoDAO();
            IList<TYPECONTENT> tiposConteudo = daoTipoConteudo.Lista();
            ViewBag.TiposConteudo = tiposConteudo;
            
            CalendarioDao daoCalendario = new CalendarioDao();
            var agenda = daoCalendario.Lista();
            ViewBag.Agenda = agenda;

        }
    }
}