
Console.WriteLine("slagsmålgenerator, skriv start");

string start = "";

while (start != "start")
{

    start = Console.ReadLine();

    if (start != "start")
    {
        Console.WriteLine("skriv start.");
    }
}

Random generator = new Random (); 

string fighterA = "bertil";
int hpA = 50;

string fighterB="kalle"; 
int hpB = 50; 

while ( hpA > 0 && hpB > 0  )
{
    Console.WriteLine(@"
███╗░░██╗███████╗░██╗░░░░░░░██╗  ██████╗░░█████╗░██╗░░░██╗███╗░░██╗██████╗░██╗
████╗░██║██╔════╝░██║░░██╗░░██║  ██╔══██╗██╔══██╗██║░░░██║████╗░██║██╔══██╗██║
██╔██╗██║█████╗░░░╚██╗████╗██╔╝  ██████╔╝██║░░██║██║░░░██║██╔██╗██║██║░░██║██║
██║╚████║██╔══╝░░░░████╔═████║░  ██╔══██╗██║░░██║██║░░░██║██║╚████║██║░░██║╚═╝
██║░╚███║███████╗░░╚██╔╝░╚██╔╝░  ██║░░██║╚█████╔╝╚██████╔╝██║░╚███║██████╔╝██╗
╚═╝░░╚══╝╚══════╝░░░╚═╝░░░╚═╝░░  ╚═╝░░╚═╝░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░╚═╝");

Console.WriteLine($"bertil has {hpA} hp kalle has {hpB} hp");
int fighterADamage = generator.Next(26);    
hpB -= fighterADamage; 
hpB = Math.Max (0, hpB);    
Console.WriteLine($"BERTIL DOES {fighterADamage} DAMAGE TO KALLE");
    
int fighterBDamage = generator.Next(26);
hpA -= fighterBDamage; 
hpA = Math.Max (0,hpA);
Console.WriteLine($"KALLE DOES {fighterBDamage} DAMAGE TO BERTIL");
   
   Console.WriteLine("tryck på valfri knapp för att starta nästa runda!");
   Console.ReadKey();
}

Console.WriteLine(" GAME OVER");    

if ( hpB== 0 && hpA == 0) 
{
Console.WriteLine("tie!");
}

else if (hpA == 0)  

{
    Console.WriteLine($"{fighterB} won!");

}
else

{
Console.WriteLine($"{fighterA} won!");

}

Console.WriteLine("press any button to end game");

Console.ReadKey();













// Random generator = new Random (); 

// while (true)
// {
// int result = generator.Next (5, 15);
// Console.WriteLine(result);
// Console.ReadLine();
// if (result == 0)
// { 
// Console.WriteLine("du får en banan");
// }
// if (result == 1)
// {
//     Console.WriteLine("du får en annan bannan.");
// }
// }




// int hp = 5;


// while (hp > 0)

// {
//     Console.WriteLine("still alive!");
//     Console.WriteLine(hp);
//     hp--; 
// }



Console.ReadLine();

