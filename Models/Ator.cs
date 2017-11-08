using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace movie.Models
{
    public class Ator
    {
        public int Id { get; set; }     

        [DisplayName("Nome do Filme")]
        public string Nome { get; set; }
        
        [DisplayName("Ano do Filme")]
        public int Idade { get; set; }
        
        public string Sobre { get; set; }
        public string Imagem { get; set; }
        public int QuantidadeDeFilmes { get; set; }
        public List<Filmes> FilmesFeitos { get; set; }
    }
}