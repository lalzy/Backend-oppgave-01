/* 1. Et program som kan lese en temperaturvariabel, 
og basert på grenser dere setter selv, gi info i terminalen ang temperaturen.*/

using System.ComponentModel;
static public class Oppgave1{
        
    static public string TempKvalitet(double celcius){
        if(celcius > 25 ){
            return "ekstremt varmt";
        }else if (celcius > 15){
            return "sånn passe";
        }else if (celcius > 5){
            return "Litt kjølig";
        }else if(celcius > -10){
            return "kjølig";
        }else{
            return "veldig kaldt";
        }
    }

    static void SjekkTemp (double celcius){
        Console.WriteLine($"Temperaturen er: {celcius}, dette er {TempKvalitet(celcius)}");
    }

        static void Main(){
        /*
        Temperatur Sjekk:
        */
        SjekkTemp(20.0);
        SjekkTemp(10);
        SjekkTemp(15);
        SjekkTemp(-30);
        SjekkTemp(0);
        SjekkTemp(30);
        SjekkTemp(-30);
    }


    /* 2. Et program som ser på antall produkter en butikk har av en gitt vare, 
    og skriver ut i terminalen hvor mange prosent avslag den skal ha basert på mengden produkter.*/


    /*Psudokode:

    funksjon(produkt):
        if dict[produkt] > 20:
            return 10
        else if dict[produkt] > 30:
            return 15
        else if dict[produkt] > 10
            return 5
        else
            return 0
    */


    static private Dictionary<String, int> butikkInnhold = new Dictionary<string, int>(){
        {"ketchup", 15},
        {"grandiosa", 34},
        {"sennep", 22}
    };

    static public int FåRabbat(string produkt){
        int antal = butikkInnhold[produkt];

        if (antal > 30){
            return 15;
        }else if (antal > 20){
            return 10;
        }else if (antal > 10){
            return 5;
        }else{
            return 0;
        }
    }

    static void PrintRabat(string produkt){
        int rabat = FåRabbat(produkt);
        Console.WriteLine($"rabbaten for {produkt} er {rabat}%");
    }

    static void Main2(){
        PrintRabat("ketchup");
        PrintRabat("sennep");
        PrintRabat("grandiosa");
    }

    /*
    3.  Et program som ser på lengden av en tekststreng 
    (den kan man finne av .Length propertien til en tekstvariabel) 
    og ser om tekstrengen er et sterkt eller svakt passord. 
    */

    static public string SjekkPassordHjelper(string passord){
        if (passord != null){
            int passordLengde = passord.Length;
            if(passordLengde > 40){
                return "Ganske sikkert";
            }else if(passordLengde >= 25){
                return "sikkert";
            }else if (passordLengde > 15){
                return "moderat sikkert";
            }else{
                return "Du burde finne noe mer sikkert";
            }
        }
        return "ingen passord";
    }

    static void SjekkPassord(){
            
        Console.WriteLine("Skriv in passordet du ønsker å sjekke: ");
        Console.Write(">> ");
        String? passord = Console.ReadLine();
        Console.Write("Basert på lengden, så er passordet ditt - ");
        Console.WriteLine(SjekkPassordHjelper(passord));
    }
    static void Main3(){
        SjekkPassord();
    }
}