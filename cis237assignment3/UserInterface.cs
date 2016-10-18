using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    class UserInterface
    {
        //Variables
        private string modelString;
        private string materialString;
        private string colorString;
        private bool toolboxBool;
        private bool compConnectionBool;
        private bool armBool;


        //Instanciate the Droid collection class
        DroidCollection Droids = new DroidCollection();

        //Empty Constructor to call loop for user input
        public UserInterface()
        {

        }

        //Method to loop through user options
        private void UserInput()
        {
            int choice = 0;

            while (choice != 3)
            {
                Console.WriteLine("1.Add New Droid");
                Console.WriteLine("2.Print Droid List");
                Console.WriteLine("3.Exit");
                Console.WriteLine("Input Choice");

                try
                {
                    choice = Int32.Parse(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            AddDroid(Droids);
                            break;

                        case 2:
                            DroidCollection.PrintDroids();
                            break;

                        case 3:
                            break;

                        default:
                            InvalidChoice();
                            break;
                    }
                }
                catch
                {
                    InvalidChoice();
                }
            }

        }

        private void AddDroid(DroidCollection Droids)
        {
            int choice;

            Console.WriteLine("What kind of droid would you like to add?");
            Console.WriteLine("1.Protical");
            Console.WriteLine("2.Utility");
            Console.WriteLine("3.Janitor");
            Console.WriteLine("4.AstroMech");

            try
            {
                choice = Int32.Parse(Console.ReadLine());

                switch(choice)
                {
                    case 1:
                        AddProtical();
                        break;

                    case 2:
                        AddUtility();
                        break;

                    case 3:
                        AddJanitor();
                        break;

                    case 4:
                        AddAstromech();
                        break;

                    default:
                        InvalidChoice();
                        break;
                }
            }
            catch
            {
                InvalidChoice();
            }

        }

        private void AddProtical()
        {
            bool langBool = false;
            modelString = "Protical";
            materialString = MaterialQuestion();
            colorString = ColorQuestion();
            
            Console.WriteLine("How many languages would you like the droid to know? 1-10");
            while(langBool != true)
            try
            {
                int langInt = Int32.Parse(Console.ReadLine());

                    if (langInt < 1 && langInt > 10)
                        InvalidChoice();
                    else
                        langBool = true;
            }
                catch
                {
                    InvalidChoice();
                }

        }

        private void AddUtility()
        {
            modelString = "Utility";
            materialString = MaterialQuestion();
            colorString = ColorQuestion();
            toolboxBool = ToolboxQ();
            compConnectionBool = ComputerQ();
            armBool = ArmQ();


        }

        private void AddJanitor()
        {
            modelString = "Janitor";
            materialString = MaterialQuestion();
            colorString = ColorQuestion();
            toolboxBool = ToolboxQ();
            compConnectionBool = ComputerQ();
            armBool = ArmQ();
            bool trashBool = TrashQ();
            bool vacuumBool = VacuumQ();

        }

        private void AddAstromech()
        {
            bool done = false;

            modelString = "Astromech";
            materialString = MaterialQuestion();
            colorString = ColorQuestion();
            toolboxBool = ToolboxQ();
            compConnectionBool = ComputerQ();
            armBool = ArmQ();
            bool fireBool = FireQ();


            Console.WriteLine("How many ships would you like the droid to have? Must be one or greater");
            while (done != true)
                try
                {
                    int langInt = Int32.Parse(Console.ReadLine());

                    if (langInt < 1)
                        InvalidChoice();
                    else
                        done = true;
                }
                catch
                {
                    InvalidChoice();
                }

        }


        private string MaterialQuestion()
        {
            int choice;
            string String = "";
            bool done = true;

            Console.WriteLine("What material would you like the droid to be made of?");
            Console.WriteLine("1.Cantium");
            Console.WriteLine("2.Berilium");
            Console.WriteLine("3.Dimandium");

            while(done)
            try
            {
                choice = Int32.Parse(Console.ReadLine());

                switch(choice)
                {
                    case 1:
                        String = "Cantium";
                        done = false;
                        break;

                        case 2:
                            String = "Berilium";
                            done = false;
                            break;

                        case 3:
                            String = "Dimandium";
                            done = false;
                            break;

                        default:
                            InvalidChoice();
                            break;
                }
            }
            catch
                {
                    InvalidChoice();
                }
            return String;
        }

        private string ColorQuestion()
        {
            int choice;
            string String = "";
            bool done = true;

            Console.WriteLine("What color would you like the droid to be?");
            Console.WriteLine("1.Red");
            Console.WriteLine("2.Blue");
            Console.WriteLine("3.Gray");

            while (done)
                try
                {
                    choice = Int32.Parse(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            String = "Red";
                            done = false;
                            break;

                        case 2:
                            String = "Blue";
                            done = false;
                            break;

                        case 3:
                            String = "Gray";
                            done = false;
                            break;

                        default:
                            InvalidChoice();
                            break;
                    }
                }
                catch
                {
                    InvalidChoice();
                }
            return String;
        }

        private bool ToolboxQ()
        {
            bool exit = false;
            bool qBool = false;

            Console.WriteLine("Does the droid have a toolbox?");
            Console.WriteLine("1.Yes");
            Console.WriteLine("2.No");

            while(exit != true)
                try
                {
                    int choice = Int32.Parse(Console.ReadLine());

                    if (choice == 1 || choice == 2)
                    {
                        if (choice == 1)
                            qBool = true;
                        if (choice == 2)
                            qBool = false;
                    }
                    else
                        InvalidChoice();
                }
                catch
                {
                    InvalidChoice();
                }
            return qBool;
        }

        private bool ComputerQ()
        {
            bool exit = false;
            bool qBool = false;

            Console.WriteLine("Does the droid have a computer connection?");
            Console.WriteLine("1.Yes");
            Console.WriteLine("2.No");

            while (exit != true)
                try
                {
                    int choice = Int32.Parse(Console.ReadLine());

                    if (choice == 1 || choice == 2)
                    {
                        if (choice == 1)
                            qBool = true;
                        if (choice == 2)
                            qBool = false;
                    }
                    else
                        InvalidChoice();
                }
                catch
                {
                    InvalidChoice();
                }
            return qBool;
        }

        private bool ArmQ()
        {
            bool exit = false;
            bool qBool = false;

            Console.WriteLine("Does the droid have an arm?");
            Console.WriteLine("1.Yes");
            Console.WriteLine("2.No");

            while (exit != true)
                try
                {
                    int choice = Int32.Parse(Console.ReadLine());

                    if (choice == 1 || choice == 2)
                    {
                        if (choice == 1)
                            qBool = true;
                        if (choice == 2)
                            qBool = false;
                    }
                    else
                        InvalidChoice();
                }
                catch
                {
                    InvalidChoice();
                }
            return qBool;
        }

        private bool VacuumQ()
        {
            bool exit = false;
            bool qBool = false;

            Console.WriteLine("Does the droid have a Vacuum?");
            Console.WriteLine("1.Yes");
            Console.WriteLine("2.No");

            while (exit != true)
                try
                {
                    int choice = Int32.Parse(Console.ReadLine());

                    if (choice == 1 || choice == 2)
                    {
                        if (choice == 1)
                            qBool = true;
                        if (choice == 2)
                            qBool = false;
                    }
                    else
                        InvalidChoice();
                }
                catch
                {
                    InvalidChoice();
                }
            return qBool;
        }

        private bool TrashQ()
        {
            bool exit = false;
            bool qBool = false;

            Console.WriteLine("Does the droid have a trash compactor?");
            Console.WriteLine("1.Yes");
            Console.WriteLine("2.No");

            while (exit != true)
                try
                {
                    int choice = Int32.Parse(Console.ReadLine());

                    if (choice == 1 || choice == 2)
                    {
                        if (choice == 1)
                            qBool = true;
                        if (choice == 2)
                            qBool = false;
                    }
                    else
                        InvalidChoice();
                }
                catch
                {
                    InvalidChoice();
                }
            return qBool;
        }

        private bool FireQ()
        {
            bool exit = false;
            bool qBool = false;

            Console.WriteLine("Does the droid have a fire extinguisher?");
            Console.WriteLine("1.Yes");
            Console.WriteLine("2.No");

            while (exit != true)
                try
                {
                    int choice = Int32.Parse(Console.ReadLine());

                    if (choice == 1 || choice == 2)
                    {
                        if (choice == 1)
                            qBool = true;
                        if (choice == 2)
                            qBool = false;
                    }
                    else
                        InvalidChoice();
                }
                catch
                {
                    InvalidChoice();
                }
            return qBool;
        }

        private void InvalidChoice()
    {
        Console.WriteLine("Input is not a valid option. Try Again.");
        Console.WriteLine();
    }




}
}
