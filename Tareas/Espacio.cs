    using Tareas;
    using System.Text.Json;
    using System.Reflection.Metadata;

    namespace Espacio.Service
    {

        public static class TareaService
        {
            private static readonly HttpClient client = new HttpClient();
            public static string url = "https://jsonplaceholder.typicode.com/todos";

            public static async Task<List<Tarea>> ObtenerTareaAsync()
            {

                HttpResponseMessage response = await client.GetAsync(url);
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                List<Tarea> tareas = JsonSerializer.Deserialize<List<Tarea>>(responseBody);
                
                return tareas;
            }
            
            }


    
    




}