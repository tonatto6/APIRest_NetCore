using API_NET.Models;
using Microsoft.AspNetCore.Mvc;

namespace API_NET.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClientesController : ControllerBase
    {
        List<ClientesModels> clientes;

        //[HttpGet(Name = "GetClientesById")]
        //public ResponseModels<ClientesModels> getClientesById()
        //{
        //    ResponseModels<ClientesModels> response = new ResponseModels<ClientesModels>();
        //    ClientesModels cliente = new ClientesModels();
        //    cliente.Nombre = "Lazaro";
        //    cliente.Apellido = "Tonatto";
        //    //clientes.Add(cliente);

        //    response.StatusCode = 200;
        //    response.Body = cliente;

        //    return response;
        //}

        [HttpGet(Name = "GetClientes")]
        public ResponseModels<List<ClientesModels>> getClientes()
        {
            ResponseModels<List<ClientesModels>> response = new ResponseModels<List<ClientesModels>>();
            clientes = new List<ClientesModels>();
            ClientesModels cliente = new ClientesModels();
            cliente.Nombre = "Lazaro";
            cliente.Apellido = "Tonatto";
            clientes.Add(cliente);
            cliente.Nombre = "Pedro";
            cliente.Apellido = "Picapiedra";
            clientes.Add(cliente);

            response.StatusCode = 200;
            response.Body = clientes;

            return response;
        }
    }
}
