using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lanchonete
{
    class Item
    {
        public string Codigo { get; set; }
        public string Nome { get; set; }
        public double Valor { get; set; }

        public Item()
        {
        }

        public Item(string codigo, string nome, double valor)
        {
            Codigo = codigo;
            Nome = nome;
            Valor = valor;
        }

        public override string ToString()
        {
            return Codigo
                + "   "
                + Nome
                + " - R$ "
                + Valor.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
