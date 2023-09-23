using System.Text.Json;

namespace Web_Api;

class AccesoADatosCadetes {
    public List<Cadete> Obtener(){

        string jsonPath = Directory.GetCurrentDirectory();

        jsonPath = jsonPath + "/Cadetes.json";
        
        string jsonContent = File.ReadAllText(jsonPath);

        List<Cadete> cadetes = JsonSerializer.Deserialize<List<Cadete>>(jsonContent);

        return cadetes;
    }
}