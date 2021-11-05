using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MinhaPrimeiraApiPosQuad.Models
{
    public class AnimalModels : Entity
    {
        public AnimalModels(string nome, string especie, string raca, int idade)
        {
            Nome = nome;
            Especie = especie;
            Raca = raca;
            Idade = idade;
        }

        public string Nome { get; set; }
        public string Especie { get; set; }
        public string Raca { get; set; }
        public int Idade { get; set; }
    }
}
