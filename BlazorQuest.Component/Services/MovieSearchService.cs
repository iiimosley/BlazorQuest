using BlazorQuest.Domain;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace BlazorQuest.Component.Services
{
    public interface IMovieSearchService
    {
        Task<IEnumerable<Movie>> GetMoviesByTitle(string searchText);
    }
    public class MovieSearchService : IMovieSearchService
    {
        private readonly HttpClient _client;

        public MovieSearchService(HttpClient client)
        {
            _client = client;
        }

        public Task<IEnumerable<Movie>> GetMoviesByTitle(string searchText)
        {
            throw new NotImplementedException();
        }
    }
}
