namespace CommandSystem.utilities
{
    public interface IInputUtilities
    {
        string? ReadInput(string message);
        int ReadInteger(string message);
        decimal? ReadDecimal(string message);
        DateTime? ReadDate(string message);
    }
}
