﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using MoviesAp.Models;
using MoviesAp.Utils;
using RestSharp;
using static MoviesAp.Utils.Constants;

namespace MoviesAp.ViewModels
{
    public class MoviesViewModel : BaseViewModel
    {
        public RestClient Client { get; set; }

        public MoviesViewModel()
        {
            Client = new RestClient(BaseUrl);
        }

        public async Task<List<Movie>> GetMovies(int page = 1)
        {
            var request = new RestRequest(Endpoints.ListMovies, DataFormat.Json);
            request.AddParameter("limit", 10);
            request.AddParameter("page", page);
            var res = await Client.GetAsync<YTS>(request);

            return res.Data.Movies;
        }
    }
}
