namespace LogicGateProject;

public class GarageGate: ILogicCircuit
{
    public List<Input> Inputs { get; }
    public bool Output { get; private set; }

    public GarageGate(Input input1, Input input2, Input input3)
    {
        this.Inputs = new List<Input>();
        this.Inputs.Add(input1);
        this.Inputs.Add(input2);
        this.Inputs.Add(input3);
        this.Output = false;
    }
    public bool LogicOutput()
    {
        Input inputA = this.Inputs[0];
        Input inputB = this.Inputs[1];
        Input inputC = this.Inputs[2];

        And and1 = new And("AND1");
        and1.AddInput(inputA);
        and1.AddInput(inputB);
        Input and1Output = new Input(and1.Name, and1.GetOutput());

        Not not1 = new Not("NOT1");
        not1.AddInput(inputA);
        Input not1Output = new Input(not1.Name, not1.GetOutput());

        Not not2 = new Not("NOT2");
        not2.AddInput(inputB);
        Input not2Output = new Input(not2.Name, not2.GetOutput());

        And and2 = new And("AND2");
        and2.AddInput(not1Output);
        and2.AddInput(not2Output);
        Input and2Output = new Input(and2.Name, and2.GetOutput());

        Or or1 = new Or("OR1");
        or1.AddInput(and1Output);
        or1.AddInput(and2Output);
        Input or1Output = new Input(or1.Name, or1.GetOutput());

        And and3 = new And("AND3");
        and3.AddInput(or1Output);
        and3.AddInput(inputC);

        this.Output = and3.GetOutput();
        return this.Output;
    }
}