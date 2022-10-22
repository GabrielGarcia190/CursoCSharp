using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetocursoModel
{
    public class Estado
    {
        public int idEstado { get; set; }
        public String nomeEstado { get; set; }
        public String siglaEstado { get; set; }

        public Estado()
        {
            this.idEstado = 0;
            this.nomeEstado = "";
            this.siglaEstado = "";
        }

        public Estado(int idEstado, string nomeEstado, string siglaEstado)
        {
            this.idEstado = idEstado;
            this.nomeEstado = nomeEstado;
            this.siglaEstado = siglaEstado;
        }
    }
}
