[MemoryDiagnoser(false)]
public class TimeOnlyToClockNotationConverterBenchmarks
{
    static TimeOnly time = new TimeOnly(13, 6, 2, 88, 987);

    static EsTimeOnlyToClockNotationConverter esConverter = new EsTimeOnlyToClockNotationConverter();
    [Benchmark]
    public void EsClockNotationConverter()
    {
        esConverter.Convert(time, ClockNotationRounding.None);
        esConverter.Convert(time, ClockNotationRounding.NearestFiveMinutes);
    }

    static BrazilianPortugueseTimeOnlyToClockNotationConverter brazilianConverter = new BrazilianPortugueseTimeOnlyToClockNotationConverter();
    [Benchmark]
    public void BrazilianPortugueseClockNotationConverter()
    {
        brazilianConverter.Convert(time, ClockNotationRounding.None);
        brazilianConverter.Convert(time, ClockNotationRounding.NearestFiveMinutes);
    }

    static FrTimeOnlyToClockNotationConverter frConverter = new FrTimeOnlyToClockNotationConverter();
    [Benchmark]
    public void FrClockNotationConverter()
    {
        frConverter.Convert(time, ClockNotationRounding.None);
        frConverter.Convert(time, ClockNotationRounding.NearestFiveMinutes);
    }

    static LbTimeOnlyToClockNotationConverter lbConverter = new LbTimeOnlyToClockNotationConverter();
    [Benchmark]
    public void LbClockNotationConverter()
    {
        lbConverter.Convert(time, ClockNotationRounding.None);
        lbConverter.Convert(time, ClockNotationRounding.NearestFiveMinutes);
    }

    static DefaultTimeOnlyToClockNotationConverter defaultConverter = new DefaultTimeOnlyToClockNotationConverter();
    [Benchmark]
    public void DefaultClockNotationConverter()
    {
        defaultConverter.Convert(time, ClockNotationRounding.None);
        defaultConverter.Convert(time, ClockNotationRounding.NearestFiveMinutes);
    }
}