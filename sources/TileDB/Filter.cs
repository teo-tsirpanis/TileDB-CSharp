namespace TileDB;

/// <summary>
/// Represents a transformation that is applied to data when written to storage.
/// Multiple filters can be chained together to form a filter pipeline.
/// </summary>
public abstract class Filter
{
    private protected Filter() { }

    public static BitShuffleFilter BitShuffle => BitShuffleFilter.Instance;

    public static BitWidthReductionFilter BitWidthReduction { get; } = new();

    public static ByteShuffleFilter ByteShuffle => ByteShuffleFilter.Instance;

    public static Bzip2Filter Bzip2 { get; } = new();

    public static ChecksumMd5Filter ChecksumMd5 => ChecksumMd5Filter.Instance;

    public static ChecksumSha256Filter ChecksumSha256 => ChecksumSha256Filter.Instance;

    public static DeltaFilter Delta { get; } = new();

    public static DictionaryEncodingFilter DictionaryEncoding => DictionaryEncodingFilter.Instance;

    public static DoubleDeltaFilter DoubleDelta { get; } = new();

    public static Gzip2Filter Gzip2 { get; } = new();

    public static Lz4Filter Lz4 { get; } = new();

    public static NoopFilter Noop => NoopFilter.Instance;

    public static PositiveDeltaFilter PositiveDelta { get; } = new();

    public static FloatScaleFilter FloatScale { get; } = new();

    public static RunLengthEncodingFilter RunLengthEncoding => RunLengthEncodingFilter.Instance;

    public static WebpFilter WebpRgb { get; } = new(WebpInputFormat.Rgb);

    public static WebpFilter WebpRgba { get; } = new(WebpInputFormat.Rgba);

    public static WebpFilter WebpBgr { get; } = new(WebpInputFormat.Bgr);

    public static WebpFilter WebpBgra { get; } = new(WebpInputFormat.Bgra);

    public static XorFilter Xor => XorFilter.Instance;

    public static ZstandardFilter Zstandard { get; } = new();

    /// <summary>
    /// The name of the filter.
    /// </summary>
    public abstract string Name { get; }

    public override string ToString() => Name;
}

public sealed class BitShuffleFilter : Filter
{
    private BitShuffleFilter() { }

    public static BitShuffleFilter Instance { get; } = new();

    /// <inheritdoc/>
    public override string Name => "BitShuffle";
}

public sealed class BitWidthReductionFilter(int maxWindowSize = -1) : Filter
{
    public int MaxWindowSize { get; } = maxWindowSize;

    /// <inheritdoc/>
    public override string Name => "BitWidthReduction";
}

public sealed class ByteShuffleFilter : Filter
{
    private ByteShuffleFilter() { }

    public static ByteShuffleFilter Instance { get; } = new();

    /// <inheritdoc/>
    public override string Name => "ByteShuffle";
}

public sealed class Bzip2Filter(int compressionLevel = -1) : CompressionFilter(compressionLevel)
{
    /// <inheritdoc/>
    public override string Name => "Bzip2";
}

public sealed class ChecksumMd5Filter : Filter
{
    private ChecksumMd5Filter() { }

    public static ChecksumMd5Filter Instance { get; } = new();

    /// <inheritdoc/>
    public override string Name => "ChecksumMd5";
}

public sealed class ChecksumSha256Filter : Filter
{
    private ChecksumSha256Filter() { }

    public static ChecksumSha256Filter Instance { get; } = new();

    /// <inheritdoc/>
    public override string Name => "ChecksumSha256";
}

public abstract class CompressionFilter : Filter
{
    private protected CompressionFilter(int compressionLevel = -1)
    {
        CompressionLevel = compressionLevel;
    }

    public int CompressionLevel { get; }
}

public sealed class DeltaFilter(DataType? reinterpretDataType = null) : Filter
{
    public DataType? ReinterpretDataType { get; } = reinterpretDataType;

    /// <inheritdoc/>
    public override string Name => "Delta";
}

public sealed class DictionaryEncodingFilter : Filter
{
    private DictionaryEncodingFilter() { }

    public static DictionaryEncodingFilter Instance { get; } = new();

    /// <inheritdoc/>
    public override string Name => "DictionaryEncoding";
}

public sealed class DoubleDeltaFilter(DataType? reinterpretDataType = null) : Filter
{
    public DataType? ReinterpretDataType { get; } = reinterpretDataType;

    /// <inheritdoc/>
    public override string Name => "DoubleDelta";
}

public sealed class FloatScaleFilter(double scale = 1.0, double offset = 0.0, ulong byteWidth = 8) : Filter
{
    public double Scale { get; } = scale;

    public double Offset { get; } = offset;

    public ulong ByteWidth { get; } = byteWidth;

    /// <inheritdoc/>
    public override string Name => "FloatScale";
}

public sealed class Gzip2Filter(int compressionLevel = -1) : CompressionFilter(compressionLevel)
{
    /// <inheritdoc/>
    public override string Name => "Gzip2";
}

public sealed class Lz4Filter(int compressionLevel = -1) : CompressionFilter(compressionLevel)
{
    /// <inheritdoc/>
    public override string Name => "LZ4";
}

public sealed class NoopFilter : Filter
{
    private NoopFilter() { }

    public static NoopFilter Instance { get; } = new();

    /// <inheritdoc/>
    public override string Name => "Noop";
}

public sealed class PositiveDeltaFilter(int maxWindowSize = -1) : Filter
{
    public int MaxWindowSize { get; } = maxWindowSize;

    /// <inheritdoc/>
    public override string Name => "PositiveDelta";
}

public sealed class RunLengthEncodingFilter : Filter
{
    private RunLengthEncodingFilter() { }

    public static RunLengthEncodingFilter Instance { get; } = new();

    /// <inheritdoc/>
    public override string Name => "RunLengthEncoding";
}

public sealed class WebpFilter(WebpInputFormat inputFormat, float quality = 100, bool isLossless = false) : Filter
{
    public WebpInputFormat InputFormat { get; } = inputFormat;

    public float Quality { get; } = quality;

    public bool IsLossless { get; } = isLossless;

    /// <inheritdoc/>
    public override string Name => "Webp";
}

public sealed class XorFilter : Filter
{
    private XorFilter() { }

    public static XorFilter Instance { get; } = new();

    /// <inheritdoc/>
    public override string Name => "Xor";
}

public sealed class ZstandardFilter(int compressionLevel = -1) : CompressionFilter(compressionLevel)
{
    /// <inheritdoc/>
    public override string Name => "ZStandard";
}
