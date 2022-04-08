using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgenciaAutomotiva.Models
{
    public class Marca
    {
        public List<MarcaModel> marcas = new List<MarcaModel>();

        public Marca()
        {
            marcas.Add(new MarcaModel(1, "Volkswagen", MarcaModel.Status.Ativo));
            marcas.Add(new MarcaModel(2, "Renault", MarcaModel.Status.Ativo));
            marcas.Add(new MarcaModel(3, "Ford", MarcaModel.Status.Ativo));
        }

        public void adicionarMarca(MarcaModel marca)
        {
            marcas.Add(marca);
        }

        public void atualizarMarca(MarcaModel marca)
        {
            marcas.RemoveAt(marcas.FindIndex(m => m.id == marca.id));
            marcas.Add(marca);
        }

        public MarcaModel getMarca(int id)
        {
            return marcas.FindLast(m => m.id == id);
        }

        public void excluirMarca(int id)
        {
            MarcaModel marca = new MarcaModel
            (
                marcas.FindLast(m => m.id == id).id,
                marcas.FindLast(m => m.id == id).nome,
                MarcaModel.Status.Cancelado
            );
            marcas.RemoveAt(marcas.FindIndex(m => m.id == id));
            marcas.Add(marca);
        }

    }
}
