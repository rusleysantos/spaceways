using data_source.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using web_spaceways.Models;

namespace services.ManageCelestialObject
{
    public class InsertCelestialObject
    {
        /// <summary>
        /// Metodo responsável por inserir um objeto celestia na base de dados.
        /// </summary>
        /// <param name="user">Objeto celestia a ser inserido.</param>
        /// <returns></returns>
        public bool Inserir(CelestialObject celestialObject)
        {
            var optionsBuilder = new DbContextOptions<EmployeeDbContext>();
            try
            {
                using (var context = new EmployeeDbContext(optionsBuilder))
                {
                    context.Add(celestialObject);
                    context.SaveChanges();
                }
                return true;

            }
            catch(Exception e)
            {
                return false;
            }

        }
    }
}
