﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhasAnotacoesSqlLite.Classe
{
    public class Anotacoes
    {
        public int Id { get; set; }
        public string Titulo { get; set; }

        public string Tipo { get; set; }

        public string Descricao { get; set; }
    }
}
