/* 1. Et program som kan lese en temperaturvariabel, 
og basert på grenser dere setter selv, gi info i terminalen ang temperaturen.*/

using System.ComponentModel;

string tempKvalitet(double celcius){
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

void sjekkTemp (double celcius){
    Console.WriteLine($"Temperaturen er: {celcius}, dette er {tempKvalitet(celcius)}");
}


/*
Temperatur Sjekk:
*/
sjekkTemp(20.0);
sjekkTemp(10);
sjekkTemp(15);
sjekkTemp(-30);
sjekkTemp(0);
sjekkTemp(30);
sjekkTemp(-30);


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


Dictionary<String, int> butikkInnhold = new Dictionary<string, int>(){
    {"ketchup", 15},
    {"grandiosa", 34},
    {"sennep", 22}
};

int fåRabbat(string produkt){
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

void printRabat(string produkt){
    int rabat = fåRabbat(produkt);
    Console.WriteLine($"rabbaten for {produkt} er {rabat}%");
}

printRabat("ketchup");
printRabat("sennep");
printRabat("grandiosa");

/*
3.  Et program som ser på lengden av en tekststreng 
(den kan man finne av .Length propertien til en tekstvariabel) 
og ser om tekstrengen er et sterkt eller svakt passord. 
*/


void sjekkPassord(){
        
    Console.WriteLine("Skriv in passordet du ønsker å sjekke: ");
    Console.Write(">> ");
    String? passord = Console.ReadLine();
    Console.Write("Basert på lengden, så er passordet ditt - ");
    if (passord != null){
        int passordLengde = passord.Length;
        if(passordLengde > 40){
            Console.WriteLine("Ganske sikkert");
        }else if(passordLengde >= 25){
            Console.WriteLine("sikkert");
        }else if (passordLengde > 15){
            Console.WriteLine("moderat sikkert");
        }else{
            Console.WriteLine("Du burde finne noe mer sikkert");
        }
    }
}

sjekkPassord();