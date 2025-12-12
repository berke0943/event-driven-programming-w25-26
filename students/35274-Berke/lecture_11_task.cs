using System;

class Countries
{
    public string Name { get; set; }
    public string Capital { get; set; }
    public string Currency { get; set; }
    public string Language { get; set; }

    public Countries(string name, string capital, string currency, string language)
    {
        Name = name;
        Capital = capital;
        Currency = currency;
        Language = language;
    }

    public void ShowInfo()
    {
        Console.WriteLine($"Name: {Name} Capital: {Capital} Currency: {Currency} Language: {Language}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Countries country1 = new Countries("United Kingdom", "London", "Pound", "English");
        Countries country2 = new Countries("Poland", "Warsaw", "Zloty", "Polish");
        Countries country3 = new Countries("Turkiye", "Ankara", "Lira", "Turkish");

        country1.ShowInfo();
        country2.ShowInfo();
        country3.ShowInfo();
    }
}
