﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace eguaman_CRUD.Modelos
{
    [SQLite.Table("persona")]
    public class Persona
    {
        [PrimaryKey,AutoIncrement]
        public int Id { get; set; }
        [MaxLength(25), Unique]
        public string Name { get; set; }

        

    }
}
