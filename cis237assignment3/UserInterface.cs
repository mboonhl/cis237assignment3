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
            UserInput();
        }

        //Method to loop through user options
        private void UserInput()
        {
            int choice = 0;

            while (choice != 3)
            {
                Console.WriteLine();
                Console.WriteLine("1.Add New Droid");
                Console.WriteLine("2.Print Droid List");
                Console.WriteLine("3.Exit");
                Console.WriteLine("Input Choice");

                try
                {
                    choice = Int32.Parse(Console.ReadLine());

                    //case stuctor to call method depending on user input
                    switch (choice)
                    {
                        case 1:
                            AddDroid(Droids);
                            break;

                        case 2:
                            Droids.PrintDroids();
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

        //AddDroid method begins the questions for adding the droid
        private void AddDroid(DroidCollection Droids)
        {
            int choice;
            bool exit = false;

            Console.WriteLine();
            Console.WriteLine("What kind of droid would you like to add?");
            Console.WriteLine("1.Protical");
            Console.WriteLine("2.Utility");
            Console.WriteLine("3.Janitor");
            Console.WriteLine("4.AstroMech");

            while (exit != true)
            {
                try
                {
                    choice = Int32.Parse(Console.ReadLine());

                    //Case structor to call method depending on droid
                    switch (choice)
                    {
                        case 1:
                            AddProtical();
                            exit = true;
                            break;

                        case 2:
                            AddUtility();
                            exit = true;
                            break;

                        case 3:
                            AddJanitor();
                            exit = true;
                            break;

                        case 4:
                            AddAstromech();
                            exit = true;
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


        //Method to add Protical droid incluuding questipns for droid variables
        private void AddProtical()
        {
            bool langBool = false;
            int langInt = 0;

            modelString = "Protical";
            materialString = MaterialQuestion();
            colorString = ColorQuestion();
            
            Console.WriteLine();
            Console.WriteLine("How many languages would you like the droid to know? Greater than one");
            while (langBool != true)
            {
                try
                {
                    langInt = Int32.Parse(Console.ReadLine());

                    if (langInt > 0)
                    {
                        langBool = true;
                       
                    }
                    else
                    {
                        InvalidChoice();
                    }
                }
                catch
                {
                    InvalidChoice();
                }
            }

            //Pass droid values to the Droid Collection class
            Droids.NewDroid(modelString, materialString, colorString, langInt);
            Console.WriteLine("You have added a new droid");
            Console.WriteLine();

        }

        //Method to add Utility droid including variable questions
        private void AddUtility()
        {
            modelString = "Utility";
            materialString = MaterialQuestion();
            colorString = ColorQuestion();
            toolboxBool = ToolboxQ();
            compConnectionBool = ComputerQ();
            armBool = ArmQ();

            Droids.NewDroid(modelString, materialString, colorString, toolboxBool, compConnectionBool, armBool);
            Console.WriteLine("You have added a new droid");
            Console.WriteLine();
        }

        //Method to add Janitor droid including variable questions
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

            Droids.NewDroid(modelString, materialString, colorString, toolboxBool, compConnectionBool, armBool, trashBool, vacuumBool);
            Console.WriteLine("You have added a new droid");
            Console.WriteLine();
        }

        //Method to add Astromech droid including variable questions
        private void AddAstromech()
        {
            bool done = false;
            int shipsInt = 0;

            modelString = "Astromech";
            materialString = MaterialQuestion();
            colorString = ColorQuestion();
            toolboxBool = ToolboxQ();
            compConnectionBool = ComputerQ();
            armBool = ArmQ();
            bool fireBool = FireQ();

            Console.WriteLine();
            Console.WriteLine("How many ships would you like the droid to have? Must be one or greater");
            while (done != true)
                try
                {
                    shipsInt = Int32.Parse(Console.ReadLine());

                    if (shipsInt < 1)
                        InvalidChoice();
                    else
                        done = true;
                }
                catch
                {
                    InvalidChoice();
                }

            Droids.NewDroid(modelString, materialString, colorString, toolboxBool, compConnectionBool, armBool, fireBool, shipsInt);
            Console.WriteLine("You have added a new droid");
            Console.WriteLine();

        }

        //Question for material type
        private string MaterialQuestion()
        {
            string String = "";
            bool done = true;

            Console.WriteLine();
            Console.WriteLine("What material would you like the droid to be made of?");
            Console.WriteLine("1.Cantium");
            Console.WriteLine("2.Berilium");
            Console.WriteLine("3.Dimandium");

            while(done)
            try
            {
                int choice = Int32.Parse(Console.ReadLine());

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

        //Question for color
        private string ColorQuestion()
        {
            string String = "";
            bool done = true;

            Console.WriteLine();
            Console.WriteLine("What color would you like the droid to be?");
            Console.WriteLine("1.Red");
            Console.WriteLine("2.Blue");
            Console.WriteLine("3.Gray");

            while (done)
                try
                {
                    int  choice = Int32.Parse(Console.ReadLine());

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

        //Question for toolbox
        private bool ToolboxQ()
        {
            bool exit = false;
            bool qBool = false;

            Console.WriteLine();
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
                        {
                            qBool = true;
                            exit = true;
                        }
                        if (choice == 2)
                        {
                            qBool = false;
                            exit = true;
                        }
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

        //Question for computer connection
        private bool ComputerQ()
        {
            bool exit = false;
            bool qBool = false;

            Console.WriteLine();
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
                        {
                            qBool = true;
                            exit = true;
                        }
                        if (choice == 2)
                        {
                            qBool = false;
                            exit = true;
                        }
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

        //Question for arm
        private bool ArmQ()
        {
            bool exit = false;
            bool qBool = false;

            Console.WriteLine();
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
                        {
                            qBool = true;
                            exit = true;
                        }
                        if (choice == 2)
                        {
                            qBool = false;
                            exit = true;
                        }
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

        //Question for vacuum
        private bool VacuumQ()
        {
            bool exit = false;
            bool qBool = false;

            Console.WriteLine();
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
                        {
                            qBool = true;
                            exit = true;
                        }
                        if (choice == 2)
                        {
                            qBool = false;
                            exit = true;
                        }
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

        //Question for trash compactor
        private bool TrashQ()
        {
            bool exit = false;
            bool qBool = false;

            Console.WriteLine();
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
                        {
                            qBool = true;
                            exit = true;
                        }
                        if (choice == 2)
                        {
                            qBool = false;
                            exit = true;
                        }
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

        //Question for Fire Extingusher
        private bool FireQ()
        {
            bool exit = false;
            bool qBool = false;

            Console.WriteLine();
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
                        {
                            qBool = true;
                            exit = true;
                        }
                        if (choice == 2)
                        {
                            qBool = false;
                            exit = true;
                        }
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

        //Method to print invalid choice message
        private void InvalidChoice()
    {
            Console.WriteLine();
            Console.WriteLine("Input is not a valid option. Try Again.");
    }




}
}
