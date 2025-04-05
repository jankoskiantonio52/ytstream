using YtStream.Abstract;

namespace YtStream.Impl;

public record ParsedMetadata(string Title, string Artist) : IMetadata;