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
        public List<Filmes> GetFilmes()
        {
            
            
            //  int[] chappie = {1,2,4,5};
            //  int[] whatchmen = {2,3,5,6};
            //  int[] braveheart = {3,4,5,6};
            //  int[] madMax = {4,5,6};
            //  int[] vendetta = {4,5,6};
            //  int[] batman = {1,2,3,};
            //  int[] theLastJedi = {1,3,4,5,6};
            //  int[] theWolverine = {1,5,6};
            //  int[] dieHard = {1,2,4,5};
            //  int[] americanSniper = {3,4,5,6};
            //  int[] theGoodFather = {1,4,5,6};
            //  int[] interstellar = {1,2,6};
            //  int[] killBill = {1, 3,5,6};
            //  int[] umaOdisseia = {3,4,5,6};
            //  int[] bladeRunner = {1,2,3,6};
            //  int[] wonderWoman = {1,4,5,6};
            //  int[] matrix = {1,4,5,6};
            //  int[] frozen = {2,3,4,6};


            List<Filmes> filmes = new List<Filmes>();
            
            Filmes chappie = new Filmes()
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
                IsTopTen = 1,
                // Atores = GetAtor(chappie)
            };

            Filmes whatchmen = new Filmes()
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
                IsTopTen = 0,
                // Atores = GetAtor(whatchmen)
            };

            Filmes batman = new Filmes()
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
                IsTopTen = 1,
                // Atores = GetAtor(batman)
            };

            Filmes theLastJedi = new Filmes()
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
                IsTopTen = 0,
                // Atores = GetAtor(theLastJedi)
            };

            Filmes wolverine = new Filmes()
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
                IsTopTen = 0,
                // Atores = GetAtor(theWolverine)
            };

            Filmes dieHard = new Filmes()
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
                IsTopTen = 0,
                // Atores = GetAtor(dieHard)
            };

            Filmes americanSniper = new Filmes()
            {
                Id = 15,
                Nome = "American Sniper",
                Categoria = "Ação",
                Nota = 8,
                Imagem = "https://images-na.ssl-images-amazon.com/images/I/517aKo0pNsL.jpg",
                Sinopse = "A consolidação das estruturas causa impacto indireto na reavaliação do remanejamento dos quadros funcionais. No mundo atual, a expansão dos mercados mundiais auxilia a preparação e a composição do impacto na agilidade decisória. O cuidado em identificar pontos críticos na complexidade dos estudos efetuados oferece uma interessante oportunidade para verificação do orçamento setorial.",
                Diretor = "Diretor genérico",
                Roteirista = "Roteirista genérico",
                Ano = 2010,
                IsTopTen = 0,
                // Atores = GetAtor(americanSniper)
            };

            Filmes braveheart = new Filmes()
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
                IsTopTen = 1,
                // Atores = GetAtor(braveheart)
            };

            Filmes theGoodFather = new Filmes()
            {
                Id = 17,
                Nome = "The GoodFather",
                Categoria = "Ação",
                Nota = 8,
                Imagem = "https://s-media-cache-ak0.pinimg.com/originals/a3/92/82/a39282230e8b0d2c140fe87578061b26.jpg",
                Sinopse = "A consolidação das estruturas causa impacto indireto na reavaliação do remanejamento dos quadros funcionais. No mundo atual, a expansão dos mercados mundiais auxilia a preparação e a composição do impacto na agilidade decisória. O cuidado em identificar pontos críticos na complexidade dos estudos efetuados oferece uma interessante oportunidade para verificação do orçamento setorial.",
                Diretor = "Diretor genérico",
                Roteirista = "Roteirista genérico",
                Ano = 2010,
                IsTopTen = 0,
                // Atores = GetAtor(theGoodFather)
            };
                        
            
            Filmes frozen = new Filmes()
            {
                Id = 18,
                Nome = "Frozen",
                Categoria = "Animação",
                Nota = 7,
                Imagem = "https://cdn.europosters.eu/image/1300/28739.jpg",
                Sinopse = "A consolidação das estruturas causa impacto indireto na reavaliação do remanejamento dos quadros funcionais. No mundo atual, a expansão dos mercados mundiais auxilia a preparação e a composição do impacto na agilidade decisória. O cuidado em identificar pontos críticos na complexidade dos estudos efetuados oferece uma interessante oportunidade para verificação do orçamento setorial.",
                Diretor = "Diretor genérico",
                Roteirista = "Roteirista genérico",
                Ano = 2010,
                IsTopTen = 0,
                // Atores = GetAtor(frozen)
            };

            Filmes interestellar = new Filmes()
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
                IsTopTen = 1,
                // Atores = GetAtor(interstellar)
            };

            Filmes killBill = new Filmes()
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
                IsTopTen = 0,
                // Atores = GetAtor(killBill)
            };

            Filmes bladeRunner = new Filmes()
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
                IsTopTen = 1,
                // Atores = GetAtor(bladeRunner)
            };
            Filmes umaOdisseia = new Filmes()
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
                IsTopTen = 0,
                // Atores = GetAtor(umaOdisseia)
            };

            Filmes vendetta = new Filmes()
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
                IsTopTen = 1,
                // Atores = GetAtor(vendetta)
            };

            Filmes madMax = new Filmes()
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
                IsTopTen = 1,
                // Atores = GetAtor(madMax)
            };

            Filmes wonderWoman = new Filmes()
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
                IsTopTen = 0,
            // Atores = GetAtor(wonderWoman)
            };

            Filmes matrix = new Filmes()
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
                IsTopTen = 1,
                // Atores = GetAtor(matrix)
            };
    

            filmes.Add(wolverine);
            filmes.Add(chappie);
            filmes.Add(dieHard);
            filmes.Add(theLastJedi);
            filmes.Add(batman);
            filmes.Add(whatchmen);
            filmes.Add(matrix);
            filmes.Add(wonderWoman);
            filmes.Add(vendetta);
            filmes.Add(madMax);
            filmes.Add(theGoodFather);
            filmes.Add(umaOdisseia);
            filmes.Add(americanSniper);
            filmes.Add(bladeRunner);
            filmes.Add(braveheart);
            filmes.Add(killBill);
            filmes.Add(interestellar);
            filmes.Add(frozen);

            return filmes;
        }

        public List<Ator> GetAtores()
        { 
            List<Ator> atores = new List<Ator>();

            Ator KevinSpacey = new Ator()
            {
                Id = 1,
                Nome = "Kevin Spacey",
                Idade = 57,
                Imagem = "https://images-na.ssl-images-amazon.com/images/M/MV5BY2NhY2U2YjgtNTFhZS00NjkwLWI2YzAtYWViNmRhMmQ5YWZjXkEyXkFqcGdeQXVyMDkxMjMwMA@@._V1_UY317_CR87,0,214,317_AL_.jpg",
                Sobre = "A constante divulgação das informações é uma das consequências dos índices pretendidos. A certificação de metodologias que nos auxiliam a lidar com a mobilidade dos capitais internacionais estende o alcance e a importância das diretrizes de desenvolvimento para o futuro. Evidentemente, a necessidade de renovação processual cumpre um papel essencial na formulação do levantamento das variáveis envolvidas. O incentivo ao avanço tecnológico, assim como o desafiador cenário globalizado oferece uma interessante oportunidade para verificação das novas proposições.",
                QuantidadeDeFilmes = 49,
            };

            Ator AngelinaJolie = new Ator()
            {
                Id = 2,
                Nome = "Angelina Jolie",
                Idade = 46,
                Imagem = "https://media.vanityfair.com/photos/57e15c417dd0d7d276c7cb7c/master/h_590,c_limit/angelina-jolie-vf-december-2014-ss02.jpg",
                Sobre = "Gostaria de enfatizar que a adoção de políticas descentralizadoras promove a alavancagem do retorno esperado a longo prazo. No mundo atual, o surgimento do comércio virtual cumpre um papel essencial na formulação dos níveis de motivação departamental. Por outro lado, o aumento do diálogo entre os diferentes setores produtivos agrega valor ao estabelecimento dos procedimentos normalmente adotados. Não obstante, a determinação clara de objetivos estimula a padronização dos conhecimentos estratégicos para atingir a excelência.",
                QuantidadeDeFilmes = 32,
            };

            Ator DanielDayLewis = new Ator()
            {
                Id = 3,
                Nome = "Daniel Day Lewis",
                Idade = 61,
                Imagem = "http://image.boomsbeat.com/data/images/full/279811/daniel-day-lewis-3-jpg.jpg",
                Sobre = "Evidentemente, a constante divulgação das informações estimula a padronização do processo de comunicação como um todo. Gostaria de enfatizar que o julgamento imparcial das eventualidades acarreta um processo de reformulação e modernização do fluxo de informações. No mundo atual, o acompanhamento das preferências de consumo é uma das consequências dos níveis de motivação departamental.",
                QuantidadeDeFilmes = 56,
            };

            Ator TomHardy = new Ator()
            {
                Id = 4,
                Nome = "Tom Hardy",
                Idade = 39,
                Imagem = "https://media.gq.com/photos/56d4902a9acdcf20275ef34c/master/pass/tom-hardy-lead-840.jpg",
                Sobre = "Evidentemente, a constante divulgação das informações estimula a padronização do processo de comunicação como um todo. Gostaria de enfatizar que o julgamento imparcial das eventualidades acarreta um processo de reformulação e modernização do fluxo de informações. No mundo atual, o acompanhamento das preferências de consumo é uma das consequências dos níveis de motivação departamental.",
                QuantidadeDeFilmes = 46,
            };

            Ator CharlizeTheron = new Ator()
            {
                Id = 5,
                Nome = "Charlize Theron",
                Idade = 38,
                Imagem = "https://i.pinimg.com/736x/67/09/6b/67096bdc91a7ac5a50ae320d68839130--beautiful-actresses-hair-ideas.jpg",
                Sobre = "Evidentemente, a constante divulgação das informações estimula a padronização do processo de comunicação como um todo. Gostaria de enfatizar que o julgamento imparcial das eventualidades acarreta um processo de reformulação e modernização do fluxo de informações. No mundo atual, o acompanhamento das preferências de consumo é uma das consequências dos níveis de motivação departamental.",
                QuantidadeDeFilmes = 36,
            };

            Ator NicholasHoult = new Ator()
            {
                Id = 6,
                Nome = "Nicholas Hoult",
                Idade = 29,
                Imagem = "https://ewedit.files.wordpress.com/2017/05/gettyimages-632633354.jpg?w=669",
                Sobre = "Evidentemente, a constante divulgação das informações estimula a padronização do processo de comunicação como um todo. Gostaria de enfatizar que o julgamento imparcial das eventualidades acarreta um processo de reformulação e modernização do fluxo de informações. No mundo atual, o acompanhamento das preferências de consumo é uma das consequências dos níveis de motivação departamental.",
                QuantidadeDeFilmes = 16,
            };

            atores.Add(KevinSpacey);
            atores.Add(AngelinaJolie);
            atores.Add(DanielDayLewis);
            atores.Add(TomHardy);
            atores.Add(CharlizeTheron);
            atores.Add(NicholasHoult);

            
            return atores;
        }

        public Ator GetAtor(int Id)
        {
            Ator atorEspecifico = null;
            List<Ator> atores = GetAtores();
            foreach(Ator item in atores)
            {
                if(item.Id == Id){
                    atorEspecifico = item;
                }
            }
            
            return atorEspecifico;
        }
    }
}


