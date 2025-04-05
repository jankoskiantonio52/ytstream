namespace YtStream.Abstract;

public interface IMetadataParser<in T>
{
    IMetadata Parse(T parse);
}