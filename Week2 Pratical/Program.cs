Main();


//Pratical 2
//Information Methods demo
//Version 1
//Author Ethan Maxwell
//Date 1st October 2024












void Main() {
    int option =1;
    

    do
    {

        PrintMenu();
        option = GetOption();
        
        GetMessage(option);
        
    } while (option != 0);

}

static void PrintMenu()
{
   
    Console.WriteLine("Please enter a valid option from below:");
    Console.WriteLine("1. Hello in French?");
    Console.WriteLine("2. Hello in Spanish?");
    Console.WriteLine("3. Hello in German?");
    Console.WriteLine("4. Hello in Italian?");
    Console.WriteLine("0. Exit application");
}
static int GetOption()

{

    try
    {
        Console.WriteLine("");
        int option = Convert.ToInt32(Console.ReadLine());

        return option;


    }
    catch (Exception ex)
    {
        Console.WriteLine($"Error:{ex.Message}. Please enter a valid operation.");
        int option = 0;
        return option;
        
    }



}



static void GetMessage(int option )
{


    switch (option)
    {




        case 0:
            Console.WriteLine("Goodbye");
            break;

        case 1:
            Console.WriteLine("Bonjour");
            break;
        case 2:
            Console.WriteLine("Ola");
            break;
        case 3:
            Console.WriteLine("Hallo");
            break;
        case 4:
            Console.WriteLine("Ciao");
            break;
        default:
            Console.WriteLine("Invalid Input");
            break;
            

    }




}








