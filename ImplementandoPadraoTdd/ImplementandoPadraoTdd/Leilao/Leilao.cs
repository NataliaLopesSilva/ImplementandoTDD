using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementandoPadraoTdd.Leilao
{
    public class Leilao
    {
        private string descricao;
        private List<Lance> lances;

        public Leilao(string descricao)
        {
            this.descricao = descricao;
            lances = new List<Lance>();
        }

        public void propoe(Lance lance)
        {
            lances.Add(lance);
        }

        public String getDescricao()
        {
            return descricao;
        }

        public List<Lance> getLances()
        {
            return lances;
        }
    }
}