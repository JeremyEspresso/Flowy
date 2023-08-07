using Flowy.Nodes.Abstractions;

namespace Flowy.Nodes;

internal sealed record StartNode(ulong Id, string Text) : IStartNode;