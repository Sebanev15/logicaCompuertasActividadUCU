namespace LogicGateProject;

public class Or: ILogicGate
{
    public string Name { get; set; }
    public List<Input> Inputs { get; }
    public bool Output { get; private set; }

    public Or(string thisName)
    {
        this.Name = thisName;
        this.Inputs = new List<Input>();
        this.Output = false;
    }
    
    public bool GetOutput()
    {
        foreach (Input input in Inputs)
        {
            if (input.Value)
            {
                this.Output = true;
                return true;
            }
        }

        this.Output = false;
        return false;
    }

    public void RemoveInput(Input input)
    {
        if (this.Inputs.Contains(input))
        {
            this.Inputs.Remove(input);
        }
        else
        {
            Console.WriteLine("ERROR: La compuerta " + this.Name + " no tenia el input " + input.Name);
        }
    }

    public void AddInput(Input input)
    {
        if (this.Inputs.Contains(input))
        {
            Console.WriteLine("ERROR: La compuerta " + this.Name + " ya tenia el input " + input.Name);
        }
        else
        {
            this.Inputs.Add(input);
        }
    }
}