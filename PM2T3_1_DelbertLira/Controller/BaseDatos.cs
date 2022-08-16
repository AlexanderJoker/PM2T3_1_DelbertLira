using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using System.Threading.Tasks;
using PM2T3_1_DelbertLira.Models;

namespace PM2T3_1_DelbertLira.Controller
{
    public class BaseDatos
    {
        readonly SQLiteAsyncConnection db;
        public BaseDatos(string pathdb)
        {
            db = new SQLiteAsyncConnection(pathdb);
            db.CreateTableAsync<Empleado>().Wait();
        }

        public Task<List<Empleado>> ObtenerListaEmpleados()
        {
            return db.Table<Empleado>().ToListAsync();
        }


        public Task<Empleado> ObtenerEmpleado(int codidoid)
        {
            return db.Table<Empleado>()
                .Where(i => i.id == codidoid)
                .FirstOrDefaultAsync();
        }

        public Task<int> AggEmpleado(Empleado emple)
        {
            if (emple.id != 0)
            {
                return db.UpdateAsync(emple);
            }
            else
            {
                return db.InsertAsync(emple);
            }

        }
        public Task<int> EliminarEmpleado(Empleado emplea)
        {
            return db.DeleteAsync(emplea);
        }
    }

}
