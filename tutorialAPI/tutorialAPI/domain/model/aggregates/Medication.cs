namespace tutorialAPI.tutorialAPI.domain.model.aggregates;

public class Medication
{
    public string id { get;}
    public string name { get; private set; }
    public string description { get; private set; }
    public string quantity { get; private set; }
    public string frecuency { get; private set; }

    public Medication()
    {
        
    }
}