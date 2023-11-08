using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using BlazorEcuasolmovsa.Models;
using Newtonsoft.Json;

namespace BlazorEcuasolmovsa.Services
{
    public class EcuasolmovsaAPIClient : IEcuasolmovsaAPIClient
    {
        private readonly HttpClient _httpClient;
        public EcuasolmovsaAPIClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public Task<IEnumerable<Usuario>> GetAllUsuarios()
        {
            throw new NotImplementedException();
        }

        public async Task<ResultadoUsuario> GetUsuarioDetails(string user, string password)
        {
            return JsonConvert.DeserializeObject<ResultadoUsuario>(
                await _httpClient.GetStringAsync($"/api/Usuarios?usuario={user}&password={password}"));

            //var usuariosList = new List<Usuarios>();
            //usuariosList.Add(_httpClient...)
            /*
             * Ejemplo de la URI que recupera el usuario 5004
             * http://apiservicios.ecuasolmovsa.com:3009/api/Usuarios?usuario=5004&password=5004U
             */
        }
    }
}
