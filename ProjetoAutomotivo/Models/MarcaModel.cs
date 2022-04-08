using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgenciaAutomotiva.Models
{
    public class MarcaModel
    {
        public int id { get; private set; }
        public string nome { get; private set; }
        public Status status { get; private set; }

        public MarcaModel(int id, string nome, Status status)
        {
            this.id = id;
            this.nome = nome;
            this.status = status;
        }

        public enum Status
        {
            Ativo = 1,
            Cancelado = 0
        }
    }
}
