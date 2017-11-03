using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace movie.Models
{
    public class Filmes
    {
        [DisplayName("Nome do Filme")]
        public string Nome { get; set; }
        
        [DisplayName("Ano do Filme")]
        public int Ano { get; set; }

        public int Id { get; set; }        

        [DisplayName("Genero")]
        public string Categoria { get; set; } 

        [DisplayName("Minha Nota")]
        public int Nota { get; set; } 


        public string Imagem { get; set;}

        [DisplayName("Sinópse do Filme")]
        public string Sinopse { get; set;}

        [DisplayName("Diretor do Filme")]
        public string Diretor { get; set;}

        [DisplayName("Roteirista do Filme")]
        public string Roteirista { get; set;}

        
        public int IsTopTen { get; set;}
    }
}