﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TareaRegistros
{
    public class Utilitarios
    {
        public static int ToInt(string texto)
        {
            int numero;
            int.TryParse(texto, out numero);
            return numero;
        }        
    }
}
