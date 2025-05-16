using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eguaman_CRUD.Modelos;
using SQLite;

namespace eguaman_CRUD.Data
{
    public class PersonRepository
    {
        string _dbPath;
        private SQLiteConnection conn;
        public string StatusMessage { get; set;  }

        private void Init()
        {
            if (conn is not null)
                return;
            conn = new(_dbPath);
            conn.CreateTable<Persona>();
         }
        public PersonRepository(string bdPath) { 

            _dbPath = bdPath;
        }

        //Creamos las otras clases
        public void AddNewPerson(string nombre)
        {
            int result = 0;
            try
            {
                Init();
                if (string.IsNullOrEmpty(nombre))
                    throw new Exception("Nombre requerido");
                Persona persona = new() { Name=nombre};
                result=conn.Insert(persona);
                StatusMessage = string.Format("{0} record(s) add (Nombre: {1})",result,nombre);

            }
            catch (Exception ex)
            {
                StatusMessage = string.Format("Failed to add {0}. Error: {1}",nombre, ex.Message);
                throw;
            }
        }

        public List<Persona> GetAllPeople(){
            try
            {
                Init();
                return conn.Table<Persona>().ToList();  
            }
            catch (Exception ex)
            {
                StatusMessage=string.Format("Failed to retrive data. {0}",ex.Message);  
                      
            }
            return new List<Persona>();
        
        }

    }
}
