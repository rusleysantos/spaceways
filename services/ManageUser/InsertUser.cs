using data_source.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using web_spaceways.Models;

namespace services.ManageUser
{
    public class InsertUser
    {

        /// <summary>
        /// Metodo responsável por inserir usuário na base de dados.
        /// </summary>
        /// <param name="user">Usuário a ser inserido.</param>
        /// <returns></returns>
        public bool Inserir(User user)
        {
            var optionsBuilder = new DbContextOptions<EmployeeDbContext>();
            try
            {
                using (var context = new EmployeeDbContext(optionsBuilder))
                {
                    context.Add(user);
                    context.SaveChanges();
                }
                return true;

            }
            catch
            {
                return false;
            }

        }
    }
}
