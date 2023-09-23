using System.Text.Json.Serialization;
using System.Text.Json;



namespace Web_Api;

class AccesoADatosCadeteria {
    public Cadeteria Obtener(){
        string jsonPath = Directory.GetCurrentDirectory();
        
        Console.WriteLine(jsonPath);
        
        string jsonContent = File.ReadAllText(jsonPath);

        Cadeteria cadeteriaNueva = JsonSerializer.Deserialize<Cadeteria>(jsonContent);

        return cadeteriaNueva;
    }
}