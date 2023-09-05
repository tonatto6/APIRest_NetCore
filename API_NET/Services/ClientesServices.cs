using API_NET.Models;

namespace API_NET.Services
{
    public class ClientesServices
    {
        List<ClientesModels> ListClientes = new List<ClientesModels>();
        
        public List<ClientesModels> listClientes()
        {
            return ListClientes;
        }

        public List<ClientesModels> addCliente(ClientesModels cliente)
        {
            ListClientes.Add(cliente);
            return ListClientes.ToList();
        }
    }
}
