namespace oppgave1.tests;

public class UnitTest1
{
    [Fact]
    public void TestTemperatur()
    {
        Assert.Equal("sånn passe", Oppgave1.TempKvalitet(23));
        Assert.Equal("ekstremt varmt", Oppgave1.TempKvalitet(33));
        Assert.Equal("kjølig", Oppgave1.TempKvalitet(5));
        Assert.Equal("veldig kaldt", Oppgave1.TempKvalitet(-10));
        Assert.Equal("Litt kjølig", Oppgave1.TempKvalitet(14));
    }

    [Fact]
    public void TestFåRabbat(){
        Assert.Equal(15, Oppgave1.FåRabbat("grandiosa"));
        Assert.Equal(5, Oppgave1.FåRabbat("ketchup"));
        Assert.Equal(10, Oppgave1.FåRabbat("sennep"));
    }

    [Fact]
    public void TestPassord(){
        string passord = "test";
        string text = Oppgave1.SjekkPassordHjelper(passord);
        bool resultat = text.Equals("du burde finne noe mer sikkert", StringComparison.OrdinalIgnoreCase);
        Assert.True(resultat);

        passord = "gdgsdgjsalkgjlsfsafddsafsaddfdsafsadfsadf";
        text = Oppgave1.SjekkPassordHjelper(passord);
        resultat = text.Equals("ganske sikkert", StringComparison.OrdinalIgnoreCase);
        Assert.True(resultat);

        passord = "ghfjtiuykjiuoykjlhirsytrk";
        text = Oppgave1.SjekkPassordHjelper(passord);
        resultat = text.Equals("sikkert", StringComparison.OrdinalIgnoreCase);
        Assert.True(resultat);
    }

    [Fact]
    public void TestNullPassord(){
        string? passord = null;
        string? text = Oppgave1.SjekkPassordHjelper(passord);
        bool resultat = text.Equals("ingen passord", StringComparison.OrdinalIgnoreCase);
        Assert.True(resultat);
    }
}