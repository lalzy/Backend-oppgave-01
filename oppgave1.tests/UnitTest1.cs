namespace oppgave1.tests;

        // if(celcius > 25 ){
        //     return "ekstremt varmt";
        // }else if (celcius > 15){
        //     return "sånn passe";
        // }else if (celcius > 5){
        //     return "Litt kjølig";
        // }else if(celcius > -10){
        //     return "kjølig";
        // }else{
        //     return "veldig kaldt";
        // }
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
    // static public int FåRabbat(string produkt){
    //     int antal = butikkInnhold[produkt];

    //     if (antal > 30){
    //         return 15;
    //     }else if (antal > 20){
    //         return 10;
    //     }else if (antal > 10){
    //         return 5;
    //     }else{
    //         return 0;
    //     }
        //   {"ketchup", 15},
        // {"grandiosa", 34},
        // {"sennep", 22}
    // }
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