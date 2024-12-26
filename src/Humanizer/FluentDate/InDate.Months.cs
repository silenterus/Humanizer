
#if NET6_0_OR_GREATER
namespace Humanizer;

public partial class InDate
{
    /// <summary>
    /// Returns 1st of January of the current year
    /// </summary>
    public static DateOnly January => new DateOnly(DateTime.UtcNow.Year, 1, 1);

    /// <summary>
    /// Returns 1st of January of the year passed in
    /// </summary>
    public static DateOnly JanuaryOf(int year) =>
        new DateOnly(year, 1, 1);

    /// <summary>
    /// Returns 1st of February of the current year
    /// </summary>
    public static DateOnly February => new DateOnly(DateTime.UtcNow.Year, 2, 1);

    /// <summary>
    /// Returns 1st of February of the year passed in
    /// </summary>
    public static DateOnly FebruaryOf(int year) =>
        new DateOnly(year, 2, 1);

    /// <summary>
    /// Returns 1st of March of the current year
    /// </summary>
    public static DateOnly March => new DateOnly(DateTime.UtcNow.Year, 3, 1);

    /// <summary>
    /// Returns 1st of March of the year passed in
    /// </summary>
    public static DateOnly MarchOf(int year) =>
        new DateOnly(year, 3, 1);

    /// <summary>
    /// Returns 1st of April of the current year
    /// </summary>
    public static DateOnly April => new DateOnly(DateTime.UtcNow.Year, 4, 1);

    /// <summary>
    /// Returns 1st of April of the year passed in
    /// </summary>
    public static DateOnly AprilOf(int year) =>
        new DateOnly(year, 4, 1);

    /// <summary>
    /// Returns 1st of May of the current year
    /// </summary>
    public static DateOnly May => new DateOnly(DateTime.UtcNow.Year, 5, 1);

    /// <summary>
    /// Returns 1st of May of the year passed in
    /// </summary>
    public static DateOnly MayOf(int year) =>
        new DateOnly(year, 5, 1);

    /// <summary>
    /// Returns 1st of June of the current year
    /// </summary>
    public static DateOnly June => new DateOnly(DateTime.UtcNow.Year, 6, 1);

    /// <summary>
    /// Returns 1st of June of the year passed in
    /// </summary>
    public static DateOnly JuneOf(int year) =>
        new DateOnly(year, 6, 1);

    /// <summary>
    /// Returns 1st of July of the current year
    /// </summary>
    public static DateOnly July => new DateOnly(DateTime.UtcNow.Year, 7, 1);

    /// <summary>
    /// Returns 1st of July of the year passed in
    /// </summary>
    public static DateOnly JulyOf(int year) =>
        new DateOnly(year, 7, 1);

    /// <summary>
    /// Returns 1st of August of the current year
    /// </summary>
    public static DateOnly August => new DateOnly(DateTime.UtcNow.Year, 8, 1);

    /// <summary>
    /// Returns 1st of August of the year passed in
    /// </summary>
    public static DateOnly AugustOf(int year) =>
        new DateOnly(year, 8, 1);

    /// <summary>
    /// Returns 1st of September of the current year
    /// </summary>
    public static DateOnly September => new DateOnly(DateTime.UtcNow.Year, 9, 1);

    /// <summary>
    /// Returns 1st of September of the year passed in
    /// </summary>
    public static DateOnly SeptemberOf(int year) =>
        new DateOnly(year, 9, 1);

    /// <summary>
    /// Returns 1st of October of the current year
    /// </summary>
    public static DateOnly October => new DateOnly(DateTime.UtcNow.Year, 10, 1);

    /// <summary>
    /// Returns 1st of October of the year passed in
    /// </summary>
    public static DateOnly OctoberOf(int year) =>
        new DateOnly(year, 10, 1);

    /// <summary>
    /// Returns 1st of November of the current year
    /// </summary>
    public static DateOnly November => new DateOnly(DateTime.UtcNow.Year, 11, 1);

    /// <summary>
    /// Returns 1st of November of the year passed in
    /// </summary>
    public static DateOnly NovemberOf(int year) =>
        new DateOnly(year, 11, 1);

    /// <summary>
    /// Returns 1st of December of the current year
    /// </summary>
    public static DateOnly December => new DateOnly(DateTime.UtcNow.Year, 12, 1);

    /// <summary>
    /// Returns 1st of December of the year passed in
    /// </summary>
    public static DateOnly DecemberOf(int year) =>
        new DateOnly(year, 12, 1);

}
#endif
