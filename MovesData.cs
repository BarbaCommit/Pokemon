public class MovesData{
    
    public int id {get;set;}
    public MoveName name {get;set;}
    public string type {get;set;}
    public string category {get;set;}
    public string pp {get;set;}
    public string power {get;set;}
    public string accuracy {get;set;}
    public Effect effect {get;set;}
}

public class MoveName{
    public string english {get;set;}
    public string french {get;set;}
}

public class Effect {
    public string english {get;set;}
    public string french {get;set;}
}