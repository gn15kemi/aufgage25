using System;

public class aufgabe25
{
	static public void Main()
	{

// Aufgabe 2.5
		//. Wiederholung
		int totalSpielEinsatz = 0, totalSpiele = 0, count0 = 0, count5 = 0,	count10 = 0, count100 = 0;
		int graine = DateTime.Now.Millisecond, spiele, count = 0;
		Random zufallszahl = new Random( graine);

	
do{  
	 spiele = zufallszahl.Next(3, 18); // erzeugt eine Zufallszahl zwischen 3 und 18


	Console.WriteLine( spiele);

	switch( spiele)	
	{  
      case 16 :
       {

	     Console.WriteLine(" Sie haben 5 Euros gewinnt"); count5 = count5 + 5;
        }break;
	
      case 17 :
       {
	     Console.WriteLine(" Sie haben 10 Euros gewinnt"); count10 = count10 +  10;

       } break;
      case 18 :
       {

	     Console.WriteLine(" Sie haben 100 Euros gewinnt"); count100 = count100 + 100;
       }break;

      default:
       {

	     Console.WriteLine(" Sie haben 0 Euro gewinnt"); count0 = count0 + 0;
        }break;
    }

	count = count + 1;   totalSpielEinsatz += 1;	totalSpiele = count0 + count5 + count10 + count100;
 }while(count < 1000);



////Console.WriteLine(" totalSpiel  {0} \n ", + totalSpiele);	//jedes Spiel einen Einsatz von 1 Euro ( hier 1000 Mal)

if ( totalSpiele >= totalSpielEinsatz)
	{   Console.WriteLine(" \n\tSie haben {0} gewonnen", totalSpiele - 1000);
	}else 
		{ Console.WriteLine(" \n\tSie haben   {0} verloren", + ( totalSpielEinsatz - totalSpiele) );
		}

Console.WriteLine(" \n\t Drücken Sie eine Taste, um die Konsole zu verlassen");
Console.ReadKey();

	}

	}
