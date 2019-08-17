﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace aa.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public virtual ICollection<Tarefa> Tarefas { get; set; }
    }
}