using MonitoriaFatec.DAO;
using MonitoriaFatec.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MonitoriaFatec.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Autentica(String login, String senha)
        {
            UsuariosDAO dao = new UsuariosDAO();
            USUARIO usuario = dao.Busca(login, senha);


            if (usuario != null)
            {
                switch (Convert.ToInt32(usuario.IDSCOPE))
                {
                    case 1:

                        Session["usuarioLogado"] = usuario;
                        return RedirectToAction("Index", "Admin");

                    case 2:

                        Session["usuarioLogado"] = usuario;
                        return RedirectToAction("Index", "Coordenador");

                    case 3:

                        Session["usuarioLogado"] = usuario;
                        return RedirectToAction("Index", "Professor");


                    case 4:

                        Session["usuarioLogado"] = usuario;
                        return RedirectToAction("Index", "Monitor");
                        
                    case 5:

                        Session["usuarioLogado"] = usuario;
                        return RedirectToAction("Index", "aluno");


                    default:
                
                        return RedirectToAction("Index");


                }
            }
            else
            {
                return RedirectToAction("Index");
            }

        }
    }
}