namespace CreateShortLink.Models;

public class Resultss<T>
{
    public T? Result { get; set; }

    private Resultss(T? result)
    {
        Result = result;
    }

    public static Resultss<T> SetResult(T result)
    {
        return new Resultss<T>(result);
    }
}