namespace Web_Api;

class AccesoADatosCadetes {
    List<Cadete> Obtener;
    public List<Cadete> Obtener(){

        string jsonPath = Directory.GetCurrentDirectory();

        jsonPath = jsonPath + "/Cadeteria.json";
        
        Console.WriteLine(jsonPath);
        
        string jsonContent = File.ReadAllText(jsonPath);

        Cadeteria cadeteriaNueva = JsonSerializer.Deserialize<Cadeteria>(jsonContent);

        return cadeteriaNueva;
    }
}