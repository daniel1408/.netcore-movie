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
                
            HttpResponseMessage Res = await client.GetAsync("api/values");  
            
            if (Res.IsSuccessStatusCode)  
            {  
                var EmpResponse = Res.Content.ReadAsStringAsync().Result;
                filmes = JsonConvert.DeserializeObject<List<Filmes>>(EmpResponse);  
            }     
            
            return filmes;
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

            var req = new HttpRequestMessage(HttpMethod.Post, "http://localhost:5050/api/values");
            var reqBody = JsonConvert.SerializeObject(movie);
            
            req.Content = new StringContent(reqBody, Encoding.UTF8, "application/json");
            var resp = client.SendAsync(req).Result;
            Console.WriteLine(resp);
            Console.WriteLine(resp.Content.ReadAsStringAsync().Result);
            /*
            @"{
                'Title':'Daniel',
                'Year':'Daniel',
                'Rated':'Daniel',
                'Released':'Daniel',
                'Runtime':'Daniel',
                'Genre':'Daniel',
                'Director':'Daniel',
                'Writer':'Daniel',
                'Actors':'Daniel',
                'Plot':'Daniel',
                'Language':'Daniel',
                'Country':'Daniel',
                'Awards':'Daniel',
                'Poster':'Daniel',
                'Metascore':'Daniel',
                'imdbRating':'Daniel',
                'imdbVotes':'Daniel',
                'imdbID' :'Daniel',
                'Type':'Daniel',
                'DVD':'Daniel',
                'BoxOffice':'Daniel',
                'Production':'Daniel',
                'Website':'Daniel',
                'Response':'Daniel'
            }".Replace('\'', '\"');
            */
        }
    }
}


