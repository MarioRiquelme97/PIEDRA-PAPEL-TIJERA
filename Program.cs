List<string> users = new List<string>()
{
    "PAPEL","PIEDRA","TIJERA"
};

while (true)

{
    Console.WriteLine("\n ELIJE: \n");
    Console.WriteLine("PAPEL - PIEDRA - TIJERA");
    string user = Console.ReadLine();
    Console.Clear();
    Random rand = new Random();

    int indexrandom = rand.Next(users.Count);
    // Console.ForegroundColor = ConsoleColor.Green;   COLORES
    Console.WriteLine($"{user}----- TU");
    Console.WriteLine($"{users.ElementAt(indexrandom)} ----- BOT");

    switch (user)
    {
        case "PAPEL":
            if ("PAPEL" == users.ElementAt(indexrandom))
            {
                Console.WriteLine("**************  EMPATE  **************");
            }
            else if ("PAPEL" != users.ElementAt(indexrandom) && users.ElementAt(indexrandom) == "TIJERA")
            {
                Console.WriteLine("**************  PERDISTE  **************");
            }
            else if ("PAPEL" != users.ElementAt(indexrandom) && users.ElementAt(indexrandom) == "PIEDRA")
            {
                Console.WriteLine("**************  GANASTE  **************");
            }
            break;
        case "PIEDRA":
            if ("PIEDRA" == users.ElementAt(indexrandom))
            {
                Console.WriteLine("**************  EMPATE  **************");
            }
            else if ("PIEDRA" != users.ElementAt(indexrandom) && users.ElementAt(indexrandom) == "PAPEL")
            {
                Console.WriteLine("**************  PERDISTE  **************");
            }
            else if ("PIEDRA" != users.ElementAt(indexrandom) && users.ElementAt(indexrandom) == "TIJERA")
            {
                Console.WriteLine("**************  GANASTE  **************");
            }
            break;

        case "TIJERA":
            if ("TIJERA" == users.ElementAt(indexrandom))
            {
                Console.WriteLine("**************  EMPATE  **************");
            }
            else if ("TIJERA" != users.ElementAt(indexrandom) && users.ElementAt(indexrandom) == "PAPEL")
            {
                Console.WriteLine("**************  GANASTE  **************");
            }
            else if ("TIJERA" != users.ElementAt(indexrandom) && users.ElementAt(indexrandom) == "PIEDRA")
            {
                Console.WriteLine("**************  PERDISTE  **************"); 
            }
            break;

        default:
            Console.WriteLine("HAZ LA UN ELEMENTO VALIDO");
            break;
    }
}








