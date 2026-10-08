using System.Collections.Generic;
using Newtonsoft.Json;

public class PokemonData {
    public int id { get; set; }
    public PokemonName name { get; set; }
    public List<string> type { get; set; }
    [JsonProperty("base")]
    public BaseStats @base { get; set; }
    public string species { get; set; }
    public string description { get; set; }
    public Evolution evolution { get; set; }
    public Profile profile { get; set; }
    public Dictionary<string, int> moves_level { get; set; }
    public List<string> moves_TM { get; set; }
    public Experience experience {get;set;}
}

public class PokemonName {
    public string english { get; set; }
    public string french { get; set; }
}

public class BaseStats {
    public int HP { get; set; }
    public int Attack { get; set; }
    public int Defense { get; set; }
    [JsonProperty("Sp. Attack")]
    public int SpAttack { get; set; }
    [JsonProperty("Sp. Defense")]
    public int SpDefense { get; set; }
    public int Speed { get; set; }
}

public class Evolution {
    public List<List<string>> next { get; set; }
}

public class Profile {
    public string height { get; set; }
    public string weight { get; set; }
    public List<string> egg { get; set; }
    public List<List<string>> ability { get; set; }
    public string gender { get; set; }
}

public class Experience{
    public int baseXP {get;set;}
    public string courbe {get;set;} 
}