using System.Collections.Generic;

namespace Web_Api;


public class Cadeteria{

    private static Cadeteria cadeteriaSingleton;

    public static Cadeteria GetCadeteria()
    {
        if (cadeteriaSingleton==null)
        {
            cadeteriaSingleton = new Cadeteria();
        }
        return cadeteriaSingleton;
    }

    private List<Pedido> _pedidos;
    private string _nombre;

    public string Nombre { get => _nombre; set => _nombre = value; }

    public Cadeteria()
    {
        _pedidos = new List<Pedido>();
        _nombre = "Cadeteria la prueba";
        _pedidos.Add(new Pedido{
            Nro = 1,
            Observacion = " Es el primer pedido"
        });
        _pedidos.Add(new Pedido{
            Nro = 2,
            Observacion = " Es el segundo pedido"
        });
        _pedidos.Add(new Pedido{
            Nro = 3,
            Observacion = " Es el tercer pedido"
        });
    }

    public Pedido GetPedido(int nro)
    {
        return _pedidos.FirstOrDefault(t => t.Nro == nro);
    }

    public List<Pedido> GetPedidos()
    {
        return _pedidos;
    }


     public Pedido AddPedido(Pedido pedido)
    {
        _pedidos.Add(pedido);
        pedido.Nro = _pedidos.Count;
        return pedido;
    }

    public Pedido UpdPedido(Pedido pedido)
    {
      Pedido auxpedido=_pedidos.FirstOrDefault(t => t.Nro == pedido.Nro);
      auxpedido.Observacion=pedido.Observacion;
      return auxpedido;
    }
    
        
    
}
