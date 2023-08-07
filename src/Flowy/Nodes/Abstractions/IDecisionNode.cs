namespace Flowy.Nodes.Abstractions;

public interface IDecisionNode : IFlowchartNode
{
    public IFlowchartNode Yes { get; }

    public IFlowchartNode No { get; }
}