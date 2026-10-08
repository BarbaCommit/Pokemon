public class ItemData{
    public int id {get;set;}
    public string type {get;set;}
    public Description description {get;set;}
    public ItemName name {get;set;}
}

public class Description{
    //rajouter francais / anglais quand fait
    public string description{get;set;}
}

public class ItemName{
    public string english {get;set;}
    public string french {get;set;}
}