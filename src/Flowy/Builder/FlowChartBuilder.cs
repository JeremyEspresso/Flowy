using Flowy.Builder.Abstractions;
using Flowy.Nodes.Abstractions;

namespace Flowy.Builder;

internal sealed partial class FlowChartBuilder : IFlowChartBuilder
{
    internal FlowChartBuilder()
    {

    }

    public IFlowChartBuilder AddNode<T>(T node) where T : IFlowchartNode
    {
        throw new NotImplementedException();
    }

    public FlowChart Build()
    {
        throw new NotImplementedException();
    }
}