using Flowy.Builder;
using Flowy.Builder.Abstractions;

namespace Flowy;

public sealed class FlowChart
{
    public static IFlowChartBuilder CreateBuilder()
        => new FlowChartBuilder();
}