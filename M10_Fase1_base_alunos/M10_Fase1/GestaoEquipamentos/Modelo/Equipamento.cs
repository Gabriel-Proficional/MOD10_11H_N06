using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoEquipamentos.Modelo
{
    public class Equipamento
    {
        public string Marca;
        public string Modelo;
        public string Sala;
        public int Ano_Aquisicao;
        public decimal Preco_Compra;

        public Equipamento(string marca, string modelo, string sala, int ano_Aquisicao, decimal preco_Compra)
        {
            Marca = marca;
            Modelo = modelo;
            Sala = sala;
            Ano_Aquisicao = ano_Aquisicao;
            Preco_Compra = preco_Compra;
        }
        public string ObterDescricao()
        {
            return $"Marca-{Marca} Modelo-{Modelo} Sala-{Sala} Ano Aquisição-{Ano_Aquisicao} Preço-{Preco_Compra}";
        }
    }
}
