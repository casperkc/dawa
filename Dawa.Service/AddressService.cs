using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Dawa.Service.Models;
using Newtonsoft.Json;

namespace Dawa.Service
{
    public class AddressService
    {
        private HttpClient client { get; }

        public AddressService()
        {
            client = new HttpClient
            {
                BaseAddress = new Uri("http://dawa.aws.dk/"),
                Timeout = new TimeSpan(0, 0, 30)
            };
        }

        /// <summary>
        /// Returns a model with information about an address from a unique id
        /// </summary>
        /// <param name="id">Unique id (eg. 0255b942-f3ac-4969-a963-d2c4ed9ab943)</param>
        public async Task<Adresse> Reverse(string id)
        {
            try
            {
                var response = await client.GetAsync($"adresser/{id}");

                if (response.IsSuccessStatusCode)
                {

                    var body = await response.Content.ReadAsStringAsync();

                    var result = JsonConvert.DeserializeObject<Adresse>(body);

                    return result;
                }

                return null;
            }
            catch (HttpRequestException e)
            {
                throw new HttpRequestException(e.Message);
            }
        }

        /// <summary>
        /// Returns a list of autocomplete address models
        /// </summary>
        /// <param name="query">Part of an address (eg. Brettevillesgade 14)</param>
        public async Task<List<AutocompleteAdresse>> Autocomplete(string query)
        {
            try
            {
                var response = await client.GetAsync($"adresser/autocomplete?q={query}");

                if (response.IsSuccessStatusCode)
                {
                    var body = await response.Content.ReadAsStringAsync();

                    var result = JsonConvert.DeserializeObject<List<AutocompleteAdresse>>(body);

                    return result;
                }

                return null;
            }
            catch (HttpRequestException e)
            {
                throw new HttpRequestException(e.Message);
            }
        }
    }
}
