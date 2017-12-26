using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using movie.Models;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using System.Text;
using System.Net.Http;  
using System.Net.Http.Headers;  
using System.Threading.Tasks;

namespace movie.Service
{
    public class WebService
    {
        string OmdbBaseURL = "http://www.omdbapi.com/";
        string ApiMovieURL = "http://localhost:5050/";

        public async Task<List<Filmes>> GetMovies()
        {            
            List<Filmes> filmes = new List<Filmes>();
            HttpClient client = new HttpClient();
            
            client.BaseAddress = new Uri(ApiMovieURL);
            client.DefaultRequestHeaders.Clear();                  
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));  
                
            HttpResponseMessage Res = await client.GetAsync("api/movie");  
            
            if (Res.IsSuccessStatusCode)  
            {  
                var EmpResponse = Res.Content.ReadAsStringAsync().Result;
                filmes = JsonConvert.DeserializeObject<List<Filmes>>(EmpResponse);
            }
            
            return filmes;
        }

        public async Task<List<Filmes>> Recomendation(){
            
            Filmes filme = await GetMoviesOmdb("12 Angry Men", "1957");
            Filmes filme2 = await GetMoviesOmdb("The Shawshank Redemption", "1994");
            Filmes filme3 = await GetMoviesOmdb("Murder in the First", "1995");
            Filmes filme4 = await GetMoviesOmdb("The Book of Eli", "2010");
            Filmes filme5 = await GetMoviesOmdb("Man on Fire", "2004");

            List<Filmes> especificMovie = new List<Filmes>();
            especificMovie.Add(filme);
            especificMovie.Add(filme2);
            especificMovie.Add(filme3);
            especificMovie.Add(filme4);
            especificMovie.Add(filme5);

            //Verificar se já está na lista do usuário.

            return especificMovie;
        }

        public async Task<Filmes> GetMoviesOmdb(string title, string year)
        {            
            Filmes filmes = new Filmes();
            HttpClient client = new HttpClient();
            
            client.BaseAddress = new Uri(OmdbBaseURL);
            client.DefaultRequestHeaders.Clear();                  
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));  
                
            HttpResponseMessage Res = await client.GetAsync($"?t={title}&y={year}&apikey=8af6a417");  
            
            if (Res.IsSuccessStatusCode)  
            {  
                var EmpResponse = Res.Content.ReadAsStringAsync().Result;
                filmes = JsonConvert.DeserializeObject<Filmes>(EmpResponse);  
            }     
            
            return filmes;
        }

        public void PostMovie(Filmes movie)
        {
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Clear();                  
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));  

            var req = new HttpRequestMessage(HttpMethod.Post, "http://localhost:5050/api/movie");
            var reqBody = JsonConvert.SerializeObject(movie);
            
            req.Content = new StringContent(reqBody, Encoding.UTF8, "application/json");
            var resp = client.SendAsync(req).Result;
            Console.WriteLine(resp);
            Console.WriteLine(resp.Content.ReadAsStringAsync().Result);
        }

        public Filmes DeleteMovie(int id)
        {
            Filmes filme = new Filmes();
            using (var client = new HttpClient())    
            {    
                client.BaseAddress = new Uri("http://localhost:5050/");    
                HttpResponseMessage Res = client.DeleteAsync($"api/movie/{id}").Result;    
                
                if (Res.IsSuccessStatusCode)
                {    
                    var response = Res.Content.ReadAsStringAsync().Result;
                    filme = JsonConvert.DeserializeObject<Filmes>(response);  
                }
            }  
            return filme;
        }
    }
}


