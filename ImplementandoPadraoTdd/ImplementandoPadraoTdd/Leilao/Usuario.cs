using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementandoPadraoTdd.Leilao
{
    public class Usuario
    {
        private int id;
        private string nome;

        public Usuario(string nome)
        {
            this.id = 0;
            this.nome = nome;
        }

        public Usuario(int id, string nome)
        {
            this.id = id;
            this.nome = nome;
        }

        public int getId()
        {
            return id;
        }

        public String getNome()
        {
            return nome;
        }
    }
}