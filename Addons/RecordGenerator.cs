using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DBPractise.Addons
{
    class RecordGenerator
    {

        Random rnd = new Random();
        public  string imie;
        public  string nazwisko;
        public string osiedle;
        public string ulica;
        public int lbMInwalidow;  // 0-5
        public int lbMPark; // 0-100
        public int lbMPrzyp;  // 0 - LbMPark
        public int lbBlkNaWyn; // 0-20
        public int zarobkiZarz; // 4500 - 16000
        public int zarobkiBlk; // 0 - 60000
        public int lbMieszkOs;
       public void Init()
        {
            imie = typeof(EImiona).GetRandomEnumValue().ToString();
            nazwisko = typeof(ENazwiska).GetRandomEnumValue().ToString();
            osiedle = typeof(EOsiedla).GetRandomEnumValue().ToString();
            ulica = typeof(EUlice).GetRandomEnumValue().ToString();
            lbMInwalidow = rnd.Next(0, 5);
            lbMPark = rnd.Next(0, 100);
            lbMPrzyp = rnd.Next(0, lbMPark);
            lbBlkNaWyn = rnd.Next(0, 20);
            zarobkiZarz = rnd.Next(350, 1500)*10;
            zarobkiBlk = rnd.Next(0, 60000);
            lbMieszkOs = rnd.Next(0, 11100);
        }
        
    }

    enum EImiona
    {
        Jan,Artur, Iwona, Beata, Karolina, Krystyna, Geralt, Gerard, Idzik, Janusz, Maria, Stanisław, Andrzej,Józef,Tadeusz,Jerzy,Zbigniew,Anna,Barbara,Teresa,Elżbieta,Janina, Zofia, Dominik,Maksymilian,Gustaw,Aleksy,Longin,Bartosz,Wilhelm,Ferdynand,Erwin,Klemens,Lechosław,Ernest,Seweryn, Eugeniusz, Konrad, Władysław, Wacław,Ingeborga, Manfred, Manfreda, Czesława, Czesław, Zygmunt, Piotr, Mariusz, Marek, Mirosława, Marianna, Mieczysława
    }
    enum ENazwiska
    {
        Piotrowicz, Kononowicz, Suchodolski, Mońka, Fiodor, Fiodorowicz, Kot, Brzezowicz, Kapturowicz, Polok, Pulak, Rokita, Nowicki, Wałęsa, Kiepski,Adamowicz,Adamowski,Aleksandrowicz,Alexandrowicz, Betlej,Betliński,Białas,Białecki, Nowak, Jabłkowski,Jabłonowski,Fikus,Filipczak,Filipowicz,Hernik,Godlewski,Gogolewski,Chlebek, Kowal, Grzyb, Kaniewski, Ziemczonek, Smith, Kotynia, Warius, Nowok, Seher, Osmanowski, Jemielniak, Olejnik, Raczkowiak
    }

    enum EOsiedla
    {
        Gwiazdy, Szombierki, Karb, Centrum, Bobrek, Witosa, Manhattan, Miechowice, Wojkowice, Batorego, Bazie, Orkan, Antonin, Kaliska,Hubala
    }

    enum EUlice
    {
        Akademicka, Balonowa, Bielska, Chmielna, Witosa, Karpacka, Małachowskiego, Wiedźmińska,Józefczaka, Krasińskiego, Mariacka, Piwna, Chorzowska, Dworcowa, Fabryczna, Garbarska, Hrubieszowska, Jezuicka, Kamienna, Lipowa, Mickiewicza, Mochnackiego, Narutowicza, Ogrodowa, Pijarska, Pocztowa, Rajska, Senatorska, Siemianowicka, Sienna, Towarowa, Uniwersytecka, Wiejska, Zamkowa, Żytnia
    } 

    public static class EnumExtensions
    {
        public static Enum GetRandomEnumValue(this Type t)
        {
            return Enum.GetValues(t)         
                .OfType<Enum>()              
                .OrderBy(e => Guid.NewGuid()) 
                .FirstOrDefault();            
        }
    }
}
