using System;

public class Entry
{
    public const string Separator = "~|~";

    private string _date;
    private string _prompt;
    private string _response;

    public Entry(string date, string prompt, string response)
    {
        _date = date;
        _prompt = prompt;
        _response = response;
    }

    public void Display()
    {
        Console.WriteLine(_date);
        Console.WriteLine(_prompt);
        Console.WriteLine(_response);
        Console.WriteLine();
    }

    public override string ToString()
    {
        return $"{_date}{Separator}{_prompt}{Separator}{_response}";
    }
}
