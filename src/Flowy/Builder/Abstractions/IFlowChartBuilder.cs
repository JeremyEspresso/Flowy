using Flowy.Nodes.Abstractions;

namespace Flowy.Builder.Abstractions;

public interface IFlowChartBuilder
{
    IFlowChartBuilder AddNode<T>(T node) where T : IFlowchartNode;

    FlowChart Build();
}