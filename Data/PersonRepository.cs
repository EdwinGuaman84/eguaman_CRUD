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

    }
}
