using System;

namespace texas_movie.Models
{
    public class Cast
    {
        public int Id {get; set;}
        public string Nome {get; set;}
        public float Salario {get; set;}
        public Filmes FilmeFeito {get; set;}
        public Series SerieFeita {get; set;}
    }
}