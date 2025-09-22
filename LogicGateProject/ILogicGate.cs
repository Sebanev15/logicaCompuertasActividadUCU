namespace LogicGateProject;

public interface ILogicGate
{
    public List<Input> Inputs { get; }
    public string Name { get; set; }
    public bool Output { get; }

    public void AddInput(Input input);

    public void RemoveInput(Input input);

    public bool GetOutput();

}