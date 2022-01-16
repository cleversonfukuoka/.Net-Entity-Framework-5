using CpmPedido.Domain;
using System.Collections.Generic;

namespace CpmPedido.Interface
{
    public interface IPedidoRepository
    {
        decimal TicketMaximo();
        dynamic PedidosClientes();
    }
}
