using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace uml2finished
{
  public class Program
    {
        private Program()
        {
            Home();
         
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
                   .Map("exit", exit)
                      .Show();

        }

        void MenuSegway()
        {
            new Nestedmenu().Prompt("welcome to the menu section, you must now choose whether or not you want to idk buy a pizza or something.")
                .Map("make your ownn pizza", pizzamaker)
           .Map(" look at the sub menu", menuChoice)
                .Map("return to mainmenu", Home)
                .Show();
            
        }
      

        void menuChoice()
        {
            new Nestedmenu().Prompt("what do you want to do? make your own order/pizza, look at the menu, or return to the main menu")
               .Map("make your ownn pizza", pizzamaker)
               .Map("menu options", storemenuoptions)
               .Map(" return home", Home)
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
               .Map("remove a pizza", deletingpizzas)
               .Map("search for pizzas on the menu or other nonsense", pizzasearch)
                  .Map(" update something on the menu", updatepizzanumber)
                  .Map(" order from the menu", orderpizza)
               .Map(" customorder", Home)
               .Show();

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
            WriteLine("remember when choosing which pizza to remove you must enter its item number");
            int pizzachoices = Convert.ToInt32(Console.ReadLine());

            switch (pizzachoices)
            {
                case 44:
                    Menu.DeletePizza(44);
                    break;
                case 45:
                    Menu.DeletePizza(45);
                    break;
                case 46:
                    Menu.DeletePizza(46);
                    break;
                case 47:
                    Menu.DeletePizza(47);
                    break;
                        default:
                    throw new ArgumentOutOfRangeException("Unknown value");

            }

          Menu.ReadPizza(_Pizzas);
            WriteLine($"congratulations you have just successfully removed  one of our items from the menu");

            
            WriteLine("press any key to return to the main menu");
            ReadKey(true);
            Home();
        }
        Pizza updatepizza = new Pizza();
        void updatepizzanumber()
        {
            WriteLine("so you have chosen to  update a item on the menu");

            WriteLine("when choosing what you want to do, you must either write yes or yes");
            WriteLine(" btw please remember to write  yes ");
            WriteLine(" ¨yes¨ write yes just like that ");

            string yes = Console.ReadLine();
            if (yes != "yes")
            {
                throw new Customexception("error please enter yes ");
            }
            Console.WriteLine("update the pizza number by entering in a new number");
            Console.WriteLine("i cant program properly because im inept, please enter a number between 1 and 2");
            int menuchoices = Convert.ToInt32(Console.ReadLine());
            if (menuchoices == 1)
            {
                Menu.UpdatePizza(1, updatepizza);
            }
            if (menuchoices == 2)
            {
                Menu.UpdatePizza(2, updatepizza);
            }
            if(menuchoices >2 )
            {
                throw new Customexception("error number was too large");
            }
            Console.WriteLine("congratulations you just updated an item on the menu");
            WriteLine("press any key to return to the main menu");
            ReadKey(true);
            Home();
        }

        public static Dictionary<int, Pizza> _PizzaSearch = new Dictionary<int, Pizza>();
        void pizzasearch()
        {
            //counteren virker ikke helt
            //jeg hader dictionaries
            //orker ikke at fixe det
            // jeg er så træt af uml 2

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
            var count = Menu.SearchPizza(Console.ReadLine());
            WriteLine($"congratulations you have just successfully looked up {count} of our items");
            WriteLine("press any key to return to the main menu");
            ReadKey(true);
            Home();
        }
        void orderpizza()
        {
        
            Pizza menupizza = new Pizza();
            Console.WriteLine("which pizza do you want to order?");
            Console.WriteLine("enter the number of the pizza you want to order");
            int orderChoices = Convert.ToInt32(Console.ReadLine());
            if (orderChoices == 1)
            {

                Menu.CreatePizza(menupizza, 1);
            }
            else if (orderChoices == 2)
            {
                Menu.CreatePizza(menupizza, 2);

            }
            else if (orderChoices == 3)
            {
                Menu.CreatePizza(menupizza, 3);
            }
            else if (orderChoices == 4)
            {
                Menu.CreatePizza(menupizza, 4);
            }
      
            Console.WriteLine("congratulations you have just successfully just ordered a pizza");

            WriteLine("press any key to return to the main menu");
            ReadKey(true);
            Home();
        }

        private static Dictionary<int, string> Topping = new Dictionary<int, string>();
        private Dictionary<int, Order> _ItemsOrdered = new Dictionary<int, Order>();
        private List<Customer> CustomerList = new List<Customer>();
        private int pizzaOrderCounter = 0;
         void pizzamaker()
        {
            string _CommandPrompt = "please just make your pizza already";
            string[] _Options = { "createpizza"};
            Keyboardmenu keyboardmenu4 = new Keyboardmenu(_CommandPrompt, _Options);
            int _SelectedIndex = keyboardmenu4.RunMenu();
            Order customorder = new  Order();
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
            customorder._No = Convert.ToInt32(Console.ReadLine());
        
            WriteLine("a custom pizza costs 50dkk");
            WriteLine("you are always welcome to add a tip to the total amount");               
            try
            {
                    customorder._Price = Convert.ToDouble(Console.ReadLine());
                if (customorder._Price < 50)
                {
                    throw new Customexception("error price cannot be lower than 50dkk");
                }
            }
            catch (Customexception)
            {
                WriteLine($"error error you only paid { customorder._Price} for the pizza. pizzas cost 50dkk without an additional tip ");
               
                throw;

            }
            Write(" enter name:  ");
            try
            {

                Customers._Name = Console.ReadLine();
            }
            catch (Exception )
            {
                if ( Customers._Name.Length < 0 && !string.IsNullOrWhiteSpace(Customers._Name))
                    WriteLine("you forgot to enter in your name ");

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
                    WriteLine("you forgot to enter in your email");

                throw;
            } 
            Console.WriteLine("do you want extra topping?");
            Console.WriteLine("each topping will cost you an additional 5dkk");
            Console.WriteLine("you choose the topping by writing its number");
           int input;
            Menu toppingmenu = new Menu(8);
                input = Convert.ToInt32(Console.ReadLine());
                  Menu.readtopping(Topping);
           //meget primitiv måde at tilføje topping på
                switch (input)
               {
                  case 0:
              Console.WriteLine("you chose bellpeppers");
                    Topping.Add(60, "bellpeppers");
                    break;
                   case 1:
                  Console.WriteLine("you chose beef");
                       Topping.Add(61, "beef");
                     break;
                   case 2:
                   Console.WriteLine("you chose  cured meats");
                       Topping.Add(62, "cured meats");
                       break;
                   case 3:
                  Console.WriteLine("you chose extra mozzarella cheese ");
                    Topping.Add(63, "extra mozzarella cheese");
                      break;
                case 4:
                 Console.WriteLine("you chose chicken");
                     Topping.Add(64, "chicken");
                      break;
                case 5:
                  Console.WriteLine("you chose shiitake mushrooms");
                    Topping.Add(65, "shiitake mushrooms");
                    break;
                case 6:
                 Console.WriteLine("you chose fried tofu");
                   Topping.Add(66, "fried tofu");
                    break;
                case 7:
                   Console.WriteLine(  "you chose chili peppers");
                       Topping.Add(67, "chili peppers");
                       break;
                 case 8:
                   Console.WriteLine( "you chose olives");
                        Topping.Add(68, "olives");
                      break;
                   default:
                        throw new ArgumentOutOfRangeException("Unknown value");

               }

            // det er meningen at koden skal merge de to lister
            //koden virker nok stadigvæk ikke ordenligt
            // jeg hader dictionaries
            Order previous = null;
            _ItemsOrdered.TryGetValue(customorder._No, out previous);

            if (previous == null)
                _ItemsOrdered.Add(pizzaOrderCounter++, customorder);
            else previous.Merge(customorder);

            Console.WriteLine("the order");

            Console.WriteLine(customorder.ToString());
            Console.WriteLine("by the customer");
            Console.WriteLine(Customers.ToString());
            Console.WriteLine("has been confirmed");

            WriteLine("press any key to return to the main menu");
            ReadKey(true);
            Home();
        }
          void exit()
        {
            WriteLine("press any key to exit");
            ReadKey(true);
            Environment.Exit(0);

        }
    }
}