namespace DomiciliosYa.Services
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading.Tasks;
    using DomiciliosYa.Common.Models;
    using Newtonsoft.Json;

    public class ApiService
    {
        /*metodo generico para mostrar listas de datos*/
        public async Task<Response> GetList<T>(string urlBase, string prefix, string controller)
        {
            /**el metodo devulve una lista generica*/
            try
            {
                /*crear un cliente, que nos servira para hacer la comunicación*/
                var client = new HttpClient();
                client.BaseAddress = new Uri(urlBase);
                var url = $"{prefix}{controller}";
                var response = await client.GetAsync(url);
                var answer = await response.Content.ReadAsStringAsync(); //json como un string
                if (!response.IsSuccessStatusCode)
                {
                    return new Response
                    {
                        IsSuccess = false,
                        Message = answer,
                    };
                }
                var list = JsonConvert.DeserializeObject<List<T>>(answer); //una lista de objetos
                return new Response
                {
                    IsSuccess = true,
                    Result = list,
                };
            }
            catch (Exception ex)
            {

                return new Response
                {
                    IsSuccess = false,
                    Message = ex.Message,
                };
            }
        }
    }
}
