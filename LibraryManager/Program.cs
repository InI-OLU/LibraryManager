using LibraryManager;
using System.Security.Cryptography.X509Certificates;

class program
{
    static void Main(string[] args)
    {

        Console.WriteLine("1: View Materials");
        Console.WriteLine("2: Add Material");
        Console.WriteLine("3: Exit");

        string input = Console.ReadLine();

       

    

      
    LibraryItem[] Materials = new LibraryItem[]
        {
            new Book("Inioluwa", true, "Bible", "Holy spirit", 2000),
            new Book("Sharon", true, "Fluid Mechanics", "Inioluw A.G", 2005),
            new Book("Victor", true, "Quantum Mechanics", "Inioluw A.G", 2015),
            new Book("Tolulope", true, "Deep Work", "Cal Newport", 2021),
            new Book("Esther", true, "BattleField  Of The Mind", "Joyce Meyer", 2008),
            new Book("Inioluwa", true, "Thermodynamics", "Inioluw A.G", 2013),
            new Magazine(348900, "Vogue", "Lola Kate", 2025),
            new Magazine(348900, "New York Times", "Richard erikson", 2011),
        };
        switch (input)
        {
            case "1":
                DisplayMaterials(Materials);
                break;
            case "2":
                AddBook(false,Materials);
                break;
            case "3":
                Console.WriteLine("Ok");
                break;
        }


        void DisplayMaterials(LibraryItem[] Materials)
        {
            foreach (LibraryItem item in Materials)
            {
                item.Displayinfo();
                Console.WriteLine("--------------");
            }
        }



      static Book  AddBook( bool IsBorrowed, LibraryItem[] Materials)
    {
            Console.WriteLine("Enter title :");
            string title = Console.ReadLine();

            Console.WriteLine("Enter Author's Name :");
            string author = Console.ReadLine();

            Console.WriteLine(" Borrowed By who? :");
            string BorrowedBy = Console.ReadLine();

            Console.WriteLine("Enter Production Date :");
            int Year = int.Parse(Console.ReadLine());

            Console.WriteLine("New Entry Succesful");


            return new Book(BorrowedBy, IsBorrowed, title, author, Year);
       
        }

    }
   
}