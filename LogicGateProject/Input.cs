namespace LogicGateProject;

public class Input
{
    public string Name { get; set; }
    public bool Value { get; set; }

    public Input(string thisName, bool thisValue)
    {
        this.Name = thisName;
        this.Value = thisValue;
    }
    
}