using Flowy.Builder;
using Flowy.Builder.Abstractions;

namespace Flowy;

public sealed class FlowChart
{
    public static IStartNodeBuilder CreateBuilder()
        => new FlowChartBuilder();
}