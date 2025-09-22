namespace LogicGateProject;

public class Not: ILogicGate
{
    public string Name { get; set; }
    public List<Input> Inputs { get; }
    public bool Output { get; private set; }

    public Not(string thisName)
    {
        this.Name = thisName;
        this.Inputs = new List<Input>();
        this.Output = false;
    }
    public bool GetOutput()
    {
        this.Output = !Inputs[0].Value;
        return !Inputs[0].Value;
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
        if (this.Inputs.Count > 0)
        {
            Console.WriteLine("ERROR: La compuerta NOT solo puede tener un input");
        }
        else
        {
            this.Inputs.Add(input);
        }
    }
}