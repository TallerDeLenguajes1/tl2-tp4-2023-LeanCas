using System.Text.Json;

namespace Web_Api;

class AccesoADatosPedidos {
    public List<Pedido> Obtener(){
        string jsonPath = Directory.GetCurrentDirectory();

        jsonPath = jsonPath + "/Pedidos.json";

        string jsonContent = File.ReadAllText(jsonPath);

        List<Pedido> pedidos = JsonSerializer.Deserialize<List<Pedido>>(jsonContent);

        return pedidos;
    }

    void Guardar(List<Pedido> Pedido){
        string fileName = "Pedidos.json";
        JsonSerializer.Serialize<List<Pedido>>("Pedidos.json", Pedido);

    }
}