using LogicGateProject;

Input inputA = new Input("A", false);
Input inputB = new Input("B", false);
Input inputC = new Input("C", false);

GarageGate garageGate = new GarageGate(inputA, inputB, inputC);

Console.WriteLine(garageGate.LogicOutput());