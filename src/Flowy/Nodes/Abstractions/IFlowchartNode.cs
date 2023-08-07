namespace Flowy.Nodes.Abstractions;

public interface IFlowchartNode
{
    public ulong Id { get; }

    public string Text { get; }
}