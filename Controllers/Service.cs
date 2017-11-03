using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using movie.Models;

namespace movie.Controllers
{
    public class Service
    {
        // public string UrlSeries = "http://api.tvmaze.com/shows/11";
        public Filmes[] GetFilmes()
        {
            Filmes[] filmes = new Filmes[] 
            {
                new Filmes
                    {
                        Id = 1,
                        Nome = "Chappie",
                        Categoria = "Aventura",
                        Nota = 8,
                        Imagem = "http://cache2.allpostersimages.com/p/LRG/86/8699/QXSU300Z/posters/chappie.jpg",
                        Sinopse = "A consolidação das estruturas causa impacto indireto na reavaliação do remanejamento dos quadros funcionais. No mundo atual, a expansão dos mercados mundiais auxilia a preparação e a composição do impacto na agilidade decisória. O cuidado em identificar pontos críticos na complexidade dos estudos efetuados oferece uma interessante oportunidade para verificação do orçamento setorial.",
                        Diretor = "Diretor genérico",
                        Roteirista = "Roteirista genérico",
                        Ano = 2010,
                        IsTopTen = 1
                    },
                new Filmes
                    {
                        Id = 2,
                        Nome = "Whatchmen",
                        Categoria = "Aventura",
                        Nota = 8,
                        Imagem = "http://br.web.img3.acsta.net/r_1280_720/medias/nmedia/18/87/24/64/19873508.jpg",
                        Sinopse = "A consolidação das estruturas causa impacto indireto na reavaliação do remanejamento dos quadros funcionais. No mundo atual, a expansão dos mercados mundiais auxilia a preparação e a composição do impacto na agilidade decisória. O cuidado em identificar pontos críticos na complexidade dos estudos efetuados oferece uma interessante oportunidade para verificação do orçamento setorial.",
                        Diretor = "Diretor genérico",
                        Roteirista = "Roteirista genérico",
                        Ano = 2010,
                        IsTopTen = 0
                    },
                new Filmes
                    {
                        Id = 3,
                        Nome = "The Dark Knight",
                        Categoria = "Ação",
                        Nota = 8,
                        Imagem = "http://cache2.allpostersimages.com/p/LRG/96/9646/3YQE500Z/posters/dark-knight-serious-teaser.jpg",
                        Sinopse = "A consolidação das estruturas causa impacto indireto na reavaliação do remanejamento dos quadros funcionais. No mundo atual, a expansão dos mercados mundiais auxilia a preparação e a composição do impacto na agilidade decisória. O cuidado em identificar pontos críticos na complexidade dos estudos efetuados oferece uma interessante oportunidade para verificação do orçamento setorial.",
                        Diretor = "Diretor genérico",
                        Roteirista = "Roteirista genérico",
                        Ano = 2010,
                        IsTopTen = 1
                    },
                new Filmes
                    {
                        Id = 4,
                        Nome = "The Last Jedi",
                        Categoria = "Ficção Cintífica",
                        Nota = 7,
                        Imagem = "http://cache2.allpostersimages.com/p/LRG/102/10275/9AWT500Z/posters/star-wars-episode-viii-the-last-jedi-teaser.jpg",
                        Sinopse = "A consolidação das estruturas causa impacto indireto na reavaliação do remanejamento dos quadros funcionais. No mundo atual, a expansão dos mercados mundiais auxilia a preparação e a composição do impacto na agilidade decisória. O cuidado em identificar pontos críticos na complexidade dos estudos efetuados oferece uma interessante oportunidade para verificação do orçamento setorial.",
                        Diretor = "Diretor genérico",
                        Roteirista = "Roteirista genérico",
                        Ano = 2010,
                        IsTopTen = 0
                    },
                new Filmes
                    {
                        Id = 5,
                        Nome = "The Wolverine",
                        Categoria = "Ação",
                        Nota = 8,
                        Imagem = "http://cache2.allpostersimages.com/p/LRG/68/6846/L8LY100Z/posters/wolverine-one-sheet-movie-poster.jpg",
                        Sinopse = "A consolidação das estruturas causa impacto indireto na reavaliação do remanejamento dos quadros funcionais. No mundo atual, a expansão dos mercados mundiais auxilia a preparação e a composição do impacto na agilidade decisória. O cuidado em identificar pontos críticos na complexidade dos estudos efetuados oferece uma interessante oportunidade para verificação do orçamento setorial.",
                        Diretor = "Diretor genérico",
                        Roteirista = "Roteirista genérico",
                        Ano = 2010,
                        IsTopTen = 0
                    },
                new Filmes
                    {
                        Id = 6,
                        Nome = "Die Hard",
                        Categoria = "Comédia",
                        Nota = 8,
                        Imagem = "http://cache2.allpostersimages.com/p/LRG/56/5663/5XGUG00Z/posters/duro-de-matar.jpg",
                        Sinopse = "A consolidação das estruturas causa impacto indireto na reavaliação do remanejamento dos quadros funcionais. No mundo atual, a expansão dos mercados mundiais auxilia a preparação e a composição do impacto na agilidade decisória. O cuidado em identificar pontos críticos na complexidade dos estudos efetuados oferece uma interessante oportunidade para verificação do orçamento setorial.",
                        Diretor = "Diretor genérico",
                        Roteirista = "Roteirista genérico",
                        Ano = 2010,
                        IsTopTen = 0
                    },
                new Filmes
                    {
                        Id = 15,
                        Nome = "American Sniper",
                        Categoria = "Ação",
                        Nota = 8,
                        Imagem = "http://www.hypeness.com.br/wp-content/uploads/2016/07/milposter.jpg",
                        Sinopse = "A consolidação das estruturas causa impacto indireto na reavaliação do remanejamento dos quadros funcionais. No mundo atual, a expansão dos mercados mundiais auxilia a preparação e a composição do impacto na agilidade decisória. O cuidado em identificar pontos críticos na complexidade dos estudos efetuados oferece uma interessante oportunidade para verificação do orçamento setorial.",
                        Diretor = "Diretor genérico",
                        Roteirista = "Roteirista genérico",
                        Ano = 2010,
                        IsTopTen = 0
                    },
                new Filmes
                    {
                        Id = 16,
                        Nome = "Braveheart",
                        Categoria = "Aventura",
                        Nota = 7,
                        Imagem = "http://cache2.allpostersimages.com/p/LRG/56/5663/EAGUG00Z/posters/coracao-valente.jpg",
                        Sinopse = "A consolidação das estruturas causa impacto indireto na reavaliação do remanejamento dos quadros funcionais. No mundo atual, a expansão dos mercados mundiais auxilia a preparação e a composição do impacto na agilidade decisória. O cuidado em identificar pontos críticos na complexidade dos estudos efetuados oferece uma interessante oportunidade para verificação do orçamento setorial.",
                        Diretor = "Diretor genérico",
                        Roteirista = "Roteirista genérico",
                        Ano = 2010,
                        IsTopTen = 1
                    },
                new Filmes
                    {
                        Id = 17,
                        Nome = "The GoodFather",
                        Categoria = "Ação",
                        Nota = 8,
                        Imagem = "http://www.hypeness.com.br/wp-content/uploads/2016/07/milposter11.jpg",
                        Sinopse = "A consolidação das estruturas causa impacto indireto na reavaliação do remanejamento dos quadros funcionais. No mundo atual, a expansão dos mercados mundiais auxilia a preparação e a composição do impacto na agilidade decisória. O cuidado em identificar pontos críticos na complexidade dos estudos efetuados oferece uma interessante oportunidade para verificação do orçamento setorial.",
                        Diretor = "Diretor genérico",
                        Roteirista = "Roteirista genérico",
                        Ano = 2010,
                        IsTopTen = 0
                    },
                new Filmes
                    {
                        Id = 18,
                        Nome = "Frozen",
                        Categoria = "Animação",
                        Nota = 7,
                        Imagem = "http://www.hypeness.com.br/wp-content/uploads/2016/07/Frozen-01.jpg",
                        Sinopse = "A consolidação das estruturas causa impacto indireto na reavaliação do remanejamento dos quadros funcionais. No mundo atual, a expansão dos mercados mundiais auxilia a preparação e a composição do impacto na agilidade decisória. O cuidado em identificar pontos críticos na complexidade dos estudos efetuados oferece uma interessante oportunidade para verificação do orçamento setorial.",
                        Diretor = "Diretor genérico",
                        Roteirista = "Roteirista genérico",
                        Ano = 2010,
                        IsTopTen = 0
                    },
                new Filmes
                    {
                        Id = 7,
                        Nome = "Interestellar",
                        Categoria = "Ficção Cintífica",
                        Nota = 7,
                        Imagem = "http://cache2.allpostersimages.com/p/LRG/86/8621/POFM300Z/posters/interstellar-ice-walk.jpg",
                        Sinopse = "A consolidação das estruturas causa impacto indireto na reavaliação do remanejamento dos quadros funcionais. No mundo atual, a expansão dos mercados mundiais auxilia a preparação e a composição do impacto na agilidade decisória. O cuidado em identificar pontos críticos na complexidade dos estudos efetuados oferece uma interessante oportunidade para verificação do orçamento setorial.",
                        Diretor = "Diretor genérico",
                        Roteirista = "Roteirista genérico",
                        Ano = 2010,
                        IsTopTen = 1
                    },
                    new Filmes
                    {
                        Id = 8,
                        Nome = "Kill Bill",
                        Categoria = "Ação",
                        Nota = 8,
                        Imagem = "http://cache2.allpostersimages.com/p/LRG/56/5662/CVFUG00Z/posters/kill-bill-vol-1-estilo-dinamarques.jpg",
                        Sinopse = "A consolidação das estruturas causa impacto indireto na reavaliação do remanejamento dos quadros funcionais. No mundo atual, a expansão dos mercados mundiais auxilia a preparação e a composição do impacto na agilidade decisória. O cuidado em identificar pontos críticos na complexidade dos estudos efetuados oferece uma interessante oportunidade para verificação do orçamento setorial.",
                        Diretor = "Diretor genérico",
                        Roteirista = "Roteirista genérico",
                        Ano = 2010,
                        IsTopTen = 0
                    },
                new Filmes
                    {
                        Id = 9,
                        Nome = "Blade Runner",
                        Categoria = "Ficção Cintífica",
                        Nota = 8,
                        Imagem = "http://cache2.allpostersimages.com/p/LRG/55/5582/Z27VG00Z/posters/blade-runner-o-cacador-de-androides.jpg",
                        Sinopse = "A consolidação das estruturas causa impacto indireto na reavaliação do remanejamento dos quadros funcionais. No mundo atual, a expansão dos mercados mundiais auxilia a preparação e a composição do impacto na agilidade decisória. O cuidado em identificar pontos críticos na complexidade dos estudos efetuados oferece uma interessante oportunidade para verificação do orçamento setorial.",
                        Diretor = "Diretor genérico",
                        Roteirista = "Roteirista genérico",
                        Ano = 2010,
                        IsTopTen = 1
                    },
                new Filmes
                    {
                        Id = 10,
                        Nome = "2001",
                        Categoria = "Ficção Cintífica",
                        Nota = 8,
                        Imagem = "http://cache2.allpostersimages.com/p/LRG/56/5661/8ODUG00Z/posters/2001-uma-odisseia-no-espaco.jpg",
                        Sinopse = "A consolidação das estruturas causa impacto indireto na reavaliação do remanejamento dos quadros funcionais. No mundo atual, a expansão dos mercados mundiais auxilia a preparação e a composição do impacto na agilidade decisória. O cuidado em identificar pontos críticos na complexidade dos estudos efetuados oferece uma interessante oportunidade para verificação do orçamento setorial.",
                        Diretor = "Diretor genérico",
                        Roteirista = "Roteirista genérico",
                        Ano = 2010,
                        IsTopTen = 0
                    },
                new Filmes
                    {
                        Id = 11,
                        Nome = "V for Vendetta",
                        Categoria = "Suspense",
                        Nota = 7,
                        Imagem = "http://cache2.allpostersimages.com/p/LRG/76/7615/1EXF300Z/posters/v-de-vinganca.jpg",
                        Sinopse = "A consolidação das estruturas causa impacto indireto na reavaliação do remanejamento dos quadros funcionais. No mundo atual, a expansão dos mercados mundiais auxilia a preparação e a composição do impacto na agilidade decisória. O cuidado em identificar pontos críticos na complexidade dos estudos efetuados oferece uma interessante oportunidade para verificação do orçamento setorial.",
                        Diretor = "Diretor genérico",
                        Roteirista = "Roteirista genérico",
                        Ano = 2010,
                        IsTopTen = 1
                    },
                new Filmes
                    {
                        Id = 12,
                        Nome = "Mad Max",
                        Categoria = "Ação",
                        Nota = 8,
                        Imagem = "http://cache2.allpostersimages.com/p/LRG/94/9445/G9HH500Z/posters/mad-max-what-a-lovely-day.jpg",
                        Sinopse = "A consolidação das estruturas causa impacto indireto na reavaliação do remanejamento dos quadros funcionais. No mundo atual, a expansão dos mercados mundiais auxilia a preparação e a composição do impacto na agilidade decisória. O cuidado em identificar pontos críticos na complexidade dos estudos efetuados oferece uma interessante oportunidade para verificação do orçamento setorial.",
                        Diretor = "Diretor genérico",
                        Roteirista = "Roteirista genérico",
                        Ano = 2010,
                        IsTopTen = 1
                    },
                new Filmes
                    {
                        Id = 13,
                        Nome = "Wonder Woman",
                        Categoria = "Ação",
                        Nota = 8,
                        Imagem = "http://cache2.allpostersimages.com/p/LRG/99/9980/1ZUK500Z/posters/wonder-woman-run.jpg",
                        Sinopse = "A consolidação das estruturas causa impacto indireto na reavaliação do remanejamento dos quadros funcionais. No mundo atual, a expansão dos mercados mundiais auxilia a preparação e a composição do impacto na agilidade decisória. O cuidado em identificar pontos críticos na complexidade dos estudos efetuados oferece uma interessante oportunidade para verificação do orçamento setorial.",
                        Diretor = "Diretor genérico",
                        Roteirista = "Roteirista genérico",
                        Ano = 2010,
                        IsTopTen = 0
                    },
                new Filmes
                    {
                        Id = 14,
                        Nome = "Matrix",
                        Categoria = "Ficção Cintífica",
                        Nota = 7,
                        Imagem = "http://cache2.allpostersimages.com/p/LRG/56/5666/DM3UG00Z/posters/matrix.jpg",
                        Sinopse = "A consolidação das estruturas causa impacto indireto na reavaliação do remanejamento dos quadros funcionais. No mundo atual, a expansão dos mercados mundiais auxilia a preparação e a composição do impacto na agilidade decisória. O cuidado em identificar pontos críticos na complexidade dos estudos efetuados oferece uma interessante oportunidade para verificação do orçamento setorial.",
                        Diretor = "Diretor genérico",
                        Roteirista = "Roteirista genérico",
                        Ano = 2010,
                        IsTopTen = 1
                    },
            };

            return filmes;


            // try
            // {
            //     string responseData = Request();

            //     Filmes filmes = JsonConvert.DeserializeObject<Filmes>(responseData);
            //     return filmes;
            // }
            // catch (Exception)
            // {
            //     throw;
            // }
        }

        // public string Request()
        // {
        //     try
        //     {
        //         string url = string.Format(UrlSeries);
        //         HttpWebRequest quoteRequest = (HttpWebRequest)WebRequest.Create(url);
        //         HttpWebResponse quoteResponse = (HttpWebResponse)quoteRequest.GetResponse();

        //         StreamReader quoteResponseReader = new StreamReader(quoteResponse.GetResponseStream());

        //         //Objeto Json
        //         string responseData = quoteResponseReader.ReadToEnd();

        //         quoteResponseReader.Close();
        //         quoteRequest.GetResponse().Close();

        //         return responseData;
        //     }
        //     catch (Exception)
        //     {
        //         throw;
        //     }
        // }
    }
}