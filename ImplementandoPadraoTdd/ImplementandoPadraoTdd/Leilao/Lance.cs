using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementandoPadraoTdd.Leilao
{
    public class Lance
    {
        private Usuario usuario;
        private double valor;

        public Lance(Usuario usuario, double valor)
        {
            this.usuario = usuario;
            this.valor = valor;
        }

        public Usuario getUsuario()
        {
            return usuario;
        }

        public double getValor()
        {
            return valor;
        }
    }
}