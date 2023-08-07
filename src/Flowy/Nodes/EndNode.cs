using Flowy.Nodes.Abstractions;

namespace Flowy.Nodes;

internal sealed record EndNode(ulong Id, string Text) : IEndNode;