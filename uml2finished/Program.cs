using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace uml2finished
{
    class Program
    {
        private Program()
        {
           
         
        }

        static void Main(string[] args)
        {
            new Program();
        }
        void Home() 
        {

            new Nestedmenu()
                .Prompt("welcome to the store. use the arrowkeys to navigate thru the menu")
                .Map("createpizza", menuChoice)
                .Map("about", about)
                .Map("menu", MenuSegway)
                      .Show();

        }

        void MenuSegway()
        {
            new Nestedmenu().Prompt("welcome to the menu section, you must now choose whether or not you want to idk buy a pizza or something.")
                .Map("make your ownn pizza/ order", pizzamaker)
           .Map(" customorder", menuChoice)
                .Map("return to mainmenu", Home)
                .Show();
            
        }
      

        void menuChoice()
        {
            new Nestedmenu().Prompt("what do you want to do? make your own order/pizza, look at the menu, or return to the main menu")
               .Map("make your ownn pizza", pizzamaker)
               .Map("choose  pizza from the menu", storemenuoptions)
               .Map(" customorder", Home)
               .Show();
            WriteLine("press any key to exit");
            ReadKey(true);
        }

        void about()
        {
            Clear();
            WriteLine("this place was founded by Gurbanguly Berdimuhamedow");
            WriteLine("who was the former dictator of turkmenistan");
            WriteLine("after being rumored dead, he released a video of himself doing doughnuts near the gate of hell");
            WriteLine("press any key to return to the main menu");
            ReadKey(true);
            Home();
        }
          
        void storemenuoptions()
        {

            new Nestedmenu().Prompt("what do you want to do, delete a pizza off the menu, or perhaps search for a pizza? returning back to main menu is an option too ig")
               .Map("make your ownn pizza", deletingpizzas)
               .Map("search for pizzas on the menu or other nonsense", pizzasearch)
               .Map(" customorder", Home)
               .Show();
            //ReadKey(true);
            //Home();
        }
        public static Dictionary<int, Pizza> _Pizzas = new Dictionary<int, Pizza>();
        void deletingpizzas()
        {
            WriteLine("so you have chosen to delete a pizza off of the menu");

            WriteLine("when choosing what you want to do, you must either write yes or yes");
            WriteLine(" btw please remember to write  yes ");
            WriteLine(" ¨yes¨ write yes just like that ");

            string yes = Console.ReadLine();
            if (yes != "yes")
            {
                throw new Customexception("error please enter yes ");

            }
            WriteLine(" which pizza do you want to delete? the cheesepizza, the meatlover, the slice of frozen pizza underneath a cardboardbox, or the gross vegetarian pizza. ");
            WriteLine("remember when choosing which pizza to delete, you must write its name, otherwise you will get an error");
            string pizzachoices = Console.ReadLine();
            if (pizzachoices == " cheesepizza")
            {
                Menu.DeletePizza(44);

            }
            else if (pizzachoices == "meatlover")
            {
                Menu.DeletePizza(45);

            }
            else if (pizzachoices == "slice of frozen pizza found underneath a cardboardbox inside of the stores walk in freezer")
            {
                Menu.DeletePizza(46);

            }
            else if (pizzachoices == "vegetarian")
            {
                Menu.DeletePizza(47);

            }
            WriteLine("congratulations you have just successfully removed one of our items from the menu");
           
            Menu.ReadPizza(_Pizzas);
            WriteLine("press any key to return to the main menu");
            ReadKey(true);
            Home();
        }

        public static Dictionary<int, Pizza> _PizzaSearch = new Dictionary<int, Pizza>();
        void pizzasearch()
        {
            WriteLine(" so you have chosen to search for something off of the menu");
            WriteLine("when choosing what you want to do, you must either write yes or yes");
            WriteLine(" btw please remember to write yes  ");
            WriteLine(" ¨yes¨ write yes just like that ");

            Pizza newpizza = new Pizza();
            string yes = Console.ReadLine();
            if (yes != "yes")
            {
                throw new Customexception("error please enter yes ");

            }


            Console.WriteLine("you search for a pizza by typing in its name");

            string emptystring = "";


            //Console.WriteLine(Convert.ToBase64String(Menu.SearchPizza(emptystring));  

            WriteLine("press any key to return to the main menu");
            ReadKey(true);
            Home();


        }
        private Dictionary<int, Order> _ItemsOrdered = new Dictionary<int, Order>();
        private List<Customer> CustomerList = new List<Customer>();
         void pizzamaker()
        {
            string _CommandPrompt = "youre not really creating a custom pizza, since the code is not able to do that. just name a pizza that you want us to make, its price, and its number";
            string[] _Options = { "createpizza", "no" };
            Keyboardmenu keyboardmenu4 = new Keyboardmenu(_CommandPrompt, _Options);
            int _SelectedIndex = keyboardmenu4.RunMenu();
            Order customorder = new Order();
            Customer Customers = new Customer();
            WriteLine(" name the pizza or something");
            try
            {
              customorder._Name = Console.ReadLine();
            }
            catch (Exception)
            {
                if (customorder._Name.Length < 0 && !string.IsNullOrWhiteSpace(customorder._Name))
                    WriteLine("you forgot to give your pizza a name ");

                throw;
            }
            WriteLine(" give it a nr so that you can track it");
            customorder._No = Int32.Parse(Console.ReadLine());
            string input = "";
            WriteLine("how much are you willing to pay?????????");

            try
            {
                input = Console.ReadLine();
                customorder._Price = Int32.Parse(input);
            }
            catch (Exception)
            {
                WriteLine($"error your input {input} wasnt a number silly, TRY AGAIN MAYBE YOU WILL GET IT RIGHT NEXT TIME ");
                throw;

            }

            Write(" enter name:  ");
            try
            {

                Customers._Name = Console.ReadLine();
            }
            catch (Exception)
            {
                if ( Customers._Name.Length < 0 && !string.IsNullOrWhiteSpace(Customers._Name))
                    WriteLine("you forgot to give your pizza a name ");

                throw;
            }
            Write(" enter email:  ");
            try
            {

                Customers._Email = Console.ReadLine();
            }
            catch (Exception)
            {
                if (Customers._Email.Length < 0 && !string.IsNullOrWhiteSpace(Customers._Name))
                    WriteLine("you forgot to give your pizza a name ");

                throw;
            }


            //vil hellere have at indexen stiger linært, eller bare en sat index, i stedet for et tal


          
            void Incrementindex (  Dictionary<int, Pizza> _Pizzas, int currentindex) {

                int updatedindex;
                _Pizzas.TryGetValue(currentindex, out updatedindex);
                _Pizzas[currentindex] = updatedindex++;
            }
            
                

            _ItemsOrdered.Add(,customorder);
            CustomerList.Add(Customers);  
         
           

            Customer.Searchcustomer(Customers);

          

            WriteLine("press any key to return to the main menu");
            ReadKey(true);
            Home();
        }
        void exit()
        {
            WriteLine("press any key to exit");
            ReadKey(true);
            Environment.Exit(0);
            //man skal sætte 0 ind i parameteren for at informere programmet at det ikke crasher. alle andre tal er crashkoder

        }
    }
}