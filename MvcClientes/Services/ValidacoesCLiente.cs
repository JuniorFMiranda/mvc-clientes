using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcClientes.Services
{
    public static class ValidacoesCLiente
    {
        public static bool ValidarNomeVazio(string nome)
        {
            return string.IsNullOrEmpty(nome);
        }

        public static bool ValidarDocumentoVazio(string documento)
        {
            return string.IsNullOrEmpty(documento);
        }
    }
}