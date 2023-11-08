using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlazorEcuasolmovsa.Models;

namespace BlazorEcuasolmovsa.Services
{
    public interface IEcuasolmovsaAPIClient
    {
        Task<IEnumerable<Usuario>> GetAllUsuarios();
        Task<ResultadoUsuario> GetUsuarioDetails(string user, string password);
    }
}
