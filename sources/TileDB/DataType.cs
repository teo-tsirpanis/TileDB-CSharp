namespace TileDB;

/// <summary>
/// Specifies the data type of entities such as array attributes
/// and dimensions, as well as array and group metadata.
/// </summary>
public enum DataType
{
    /// <summary>
    /// An unsigned 8-bit integer.
    /// </summary>
    UInt8,
    /// <summary>
    /// A signed 8-bit integer.
    /// </summary>
    Int8,
    /// <summary>
    /// An unsigned 16-bit integer.
    /// </summary>
    UInt16,
    /// <summary>
    /// A signed 16-bit integer.
    /// </summary>
    Int16,
    /// <summary>
    /// An unsigned 32-bit integer.
    /// </summary>
    UInt32,
    /// <summary>
    /// A signed 32-bit integer.
    /// </summary>
    Int32,
    /// <summary>
    /// An unsigned 64-bit integer.
    /// </summary>
    UInt64,
    /// <summary>
    /// A signed 64-bit integer.
    /// </summary>
    Int64,
    /// <summary>
    /// A 32-bit floating point number.
    /// </summary>
    Float32,
    /// <summary>
    /// A 64-bit floating point number.
    /// </summary>
    Float64,
    /// <summary>
    /// An ASCII character.
    /// </summary>
    CharAscii,
    /// <summary>
    /// A UTF-8 character.
    /// </summary>
    CharUtf8,
    /// <summary>
    /// A UTF-16 character.
    /// </summary>
    CharUtf16,
    /// <summary>
    /// A UTF-32 character.
    /// </summary>
    CharUtf32,
    /// <summary>
    /// A date and time, counted as the signed 64-bit number of
    /// years since the Unix epoch (January 1 1970 at midnight).
    /// </summary>
    DateTimeYear,
    /// <summary>
    /// A date and time, counted as the signed 64-bit number of
    /// months since the Unix epoch (January 1 1970 at midnight).
    /// </summary>
    DateTimeMonth,
    /// <summary>
    /// A date and time, counted as the signed 64-bit number of
    /// weeks since the Unix epoch (January 1 1970 at midnight).
    /// </summary>
    DateTimeWeek,
    /// <summary>
    /// A date and time, counted as the signed 64-bit number of
    /// days since the Unix epoch (January 1 1970 at midnight).
    /// </summary>
    DateTimeDay,
    /// <summary>
    /// A date and time, counted as the signed 64-bit number of
    /// hours since the Unix epoch (January 1 1970 at midnight).
    /// </summary>
    DateTimeHour,
    /// <summary>
    /// A date and time, counted as the signed 64-bit number of
    /// minutes since the Unix epoch (January 1 1970 at midnight).
    /// </summary>
    DateTimeMinute,
    /// <summary>
    /// A date and time, counted as the signed 64-bit number of
    /// seconds since the Unix epoch (January 1 1970 at midnight).
    /// </summary>
    DateTimeSecond,
    /// <summary>
    /// A date and time, counted as the signed 64-bit number of
    /// milliseconds since the Unix epoch (January 1 1970 at midnight).
    /// </summary>
    DateTimeMillisecond,
    /// <summary>
    /// A date and time, counted as the signed 64-bit number of
    /// microseconds since the Unix epoch (January 1 1970 at midnight).
    /// </summary>
    DateTimeMicrosecond,
    /// <summary>
    /// A date and time, counted as the signed 64-bit number of
    /// nanoseconds since the Unix epoch (January 1 1970 at midnight).
    /// </summary>
    DateTimeNanosecond,
    /// <summary>
    /// A date and time, counted as the signed 64-bit number of
    /// picoseconds since the Unix epoch (January 1 1970 at midnight).
    /// </summary>
    /// <remarks>
    /// One second consists of one trillion picoseconds.
    /// </remarks>
    DateTimePicosecond,
    /// <summary>
    /// A date and time, counted as the signed 64-bit number of
    /// femtoseconds since the Unix epoch (January 1 1970 at midnight).
    /// </summary>
    /// <remarks>
    /// One second consists of one quadrillion femtoseconds.
    /// </remarks>
    DateTimeFemtosecond,
    /// <summary>
    /// A date and time, counted as the signed 64-bit number of
    /// attoseconds since the Unix epoch (January 1 1970 at midnight).
    /// </summary>
    /// <remarks>
    /// One second consists of one quintillion attoseconds.
    /// </remarks>
    DateTimeAttosecond,
    /// <summary>
    /// A time of day counted in hours.
    /// </summary>
    TimeHour,
    /// <summary>
    /// A time of day counted in minutes.
    /// </summary>
    TimeMinute,
    /// <summary>
    /// A time of day counted in seconds.
    /// </summary>
    TimeSecond,
    /// <summary>
    /// A time of day counted in milliseconds.
    /// </summary>
    TimeMillisecond,
    /// <summary>
    /// A time of day counted in microseconds.
    /// </summary>
    TimeMicrosecond,
    /// <summary>
    /// A time of day counted in nanoseconds.
    /// </summary>
    TimeNanosecond,
    /// <summary>
    /// A time of day counted in picoseconds.
    /// </summary>
    /// <remarks>
    /// One second consists of one trillion picoseconds.
    /// </remarks>
    TimePicosecond,
    /// <summary>
    /// A time of day counted in femtoseconds.
    /// </summary>
    /// <remarks>
    /// One second consists of one quadrillion femtoseconds.
    /// </remarks>
    TimeFemtosecond,
    /// <summary>
    /// A time of day counted in attoseconds.
    /// </summary>
    /// <remarks>
    /// One second consists of one quintillion attoseconds.
    /// </remarks>
    TimeAttosecond,
    /// <summary>
    /// A byte, devoid of any numeric meaning.
    /// </summary>
    Binary,
    /// <summary>
    /// A boolean value.
    /// </summary>
    Boolean
}
