namespace LogicGateProject;

public interface ILogicCircuit
{
    public List<Input> Inputs { get; }
    public bool Output { get; }

    public bool LogicOutput();
}