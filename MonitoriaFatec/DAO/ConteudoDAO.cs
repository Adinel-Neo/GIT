using MonitoriaFatec.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MonitoriaFatec.DAO
{
    public class ConteudoDAO
    {
        public IList<CONTENT> Lista()
        {
            using (var context = new MONITORIA_FATECEntities())
            {
                return context.CONTENT.ToList<CONTENT>();

            }

        }


        public void Cadastrar(CONTENT conteudo)
        {
            using (var context = new MONITORIA_FATECEntities())
            {
                context.CONTENT.Add(conteudo);
                context.SaveChanges();

            }

        }
    }
}