using API_NET.Models;
using API_NET.Services;
using Microsoft.AspNetCore.Mvc;

namespace API_NET.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClientesController : ControllerBase
    {
        List<ClientesModels> clientes = new List<ClientesModels>();
        ClientesServices clienteService = new ClientesServices();

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
            ClientesModels cliente = new ClientesModels();
            cliente.Nombre = "Lazaro";
            cliente.Apellido = "Tonatto";
            clientes.Add(cliente);

            response.StatusCode = 200;
            response.Body = clientes;

            return response;
        }
    
        [HttpPost(Name = "AddCliente")]
        public ResponseModels<ClientesModels> addCliente(ClientesModels cliente)
        {
            clienteService.addCliente(cliente);
            ResponseModels<ClientesModels> response = new ResponseModels<ClientesModels>();

            response.StatusCode = 200;
            response.Body = cliente;

            return response;
        }
    }
}
