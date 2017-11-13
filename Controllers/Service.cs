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

namespace movie.Controllers
{
    public class Service
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

        // public Filmes GetEspecificMovie(int id){
            
        //     List<Filmes> filmes = GetMovies();
        //     Filmes especificMovie = null;

        //     foreach(Filmes item in filmes){
        //         if(item.Id == id){
        //             especificMovie = item;
        //         }
        //     }
        //     return especificMovie;
        // }

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


