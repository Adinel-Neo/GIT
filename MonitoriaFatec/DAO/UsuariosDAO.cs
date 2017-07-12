using MonitoriaFatec.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MonitoriaFatec.DAO
{
    public class UsuariosDAO
    {
        public USUARIO BuscaPorId(int id)
        {
            using (var context = new MONITORIA_FATECEntities())
            {
                return context.USUARIO.Find(id);
            }

        }

        public USUARIO Busca(string login, string senha)
        {
            using (var context = new MONITORIA_FATECEntities())
            {
                return context.USUARIO.FirstOrDefault(u => u.EMAILUSER == login && u.USERPASSWORD == senha);
            }
        }

        public IList<USUARIO> ListaPorEscopo(int escopo)
        {
            using (var context = new MONITORIA_FATECEntities())
            {
                var usuarios = (from u in context.USUARIO
                               where u.IDSCOPE == 5
                               select u).ToList();
                return usuarios;
            }
        }

        public void Cadastra(USUARIO usuario)
        {
            using (var context = new MONITORIA_FATECEntities())
            {
                context.USUARIO.Add(usuario);
                context.SaveChanges();
            }
        }
    }
}