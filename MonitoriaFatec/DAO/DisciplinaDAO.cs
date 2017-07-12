using MonitoriaFatec.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MonitoriaFatec.DAO
{
    public class DisciplinaDAO
    {
        public void Cadastra(DISCIPLINE disciplina)
        {
            using (var context = new MONITORIA_FATECEntities())
            {
                context.DISCIPLINE.Add(disciplina);
                context.SaveChanges();
            }
        }


        public IList<DISCIPLINE> Lista()
        {
            using (var context = new MONITORIA_FATECEntities())
            {
                return context.DISCIPLINE.ToList<DISCIPLINE>();
                
            }

        }

    }
}