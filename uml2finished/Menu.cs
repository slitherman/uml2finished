using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uml2finished
{
    class Menu
    {
        public const int _MenuItems = 0;
       
        public Pizza Pizza { get; set; }

        public static Dictionary<int, string> Topping = new Dictionary<int, string>()
        {

        };

        public static Dictionary<int, Pizza> _Pizzas = new Dictionary<int, Pizza>()
        {
            //{ 1, new Pizza  { _No =1, _Name ="cheesepizza", _Price=55, Topping = { "bell peppers", "onions", "beef", " mushrooms"} } },
            //{ 2,  new Pizza { _No = 2, _Name = "meatlover", _Price = 55,  Topping = { "bell peppers", "onions", "beef", " mushrooms" } } },
            //{ 3, new Pizza { _No = 3, _Name = "slice of frozen pizza found underneath a cardboardbox inside of the stores walk in freezer", _Price= 55,  Topping = { "bell peppers", "onions", "beef", " mushrooms"      } } },
            //{4, new Pizza { _No =4, _Name = "vegetarian", _Price = 55,  Topping = { "bell peppers", "onions", "beef", " mushrooms"  } } },
        };
        Pizza newpizza1 = new Pizza(44, "cheesepizza", 55);
        Pizza newpizza2 = new Pizza(45, "meatlover", 55);
        Pizza newpizza3 = new Pizza(46, "slice of frozen pizza found underneath a cardboardbox inside of the stores walk in freezer", 55);
        Pizza newpizza4 = new Pizza(47, "vegetarian", 55);


        public Menu()
        {
            _Pizzas.Add(1, newpizza1);
            _Pizzas.Add(2, newpizza2);

            _Pizzas.Add(3, newpizza3);
            _Pizzas.Add(4, newpizza4);
            Menu.ReadPizza(_Pizzas);

        }


        public Menu ( int menuitems )
        {

            menuitems = _MenuItems;

            Topping.Add(0, "bell peppers");
            Topping.Add(1, "beef");
            Topping.Add(2, "cured meats");
            Topping.Add(3, "extra mozzarella cheese");
            Topping.Add(4, "chicken");
            Topping.Add(5, "shiitake mushrooms");
            Topping.Add(6, "fried tofu");
            Topping.Add(7, "chili peppers");
            Topping.Add(8, "olives");

            Menu.readtopping(Topping);

        }

        public static void CreatePizza(Pizza pizzas, int no)
        {
            _Pizzas.Add(pizzas._No, pizzas);
        }
        public static void readtopping(Dictionary<int, string> Topping)
        {

            foreach (var toppings in Topping)
            {
                Console.WriteLine(toppings);
            }
        }

        public static void CreateTopping(string Toppings, int no)
        {
            Topping.Add(no, Toppings);
        }

        public static void ReadPizza(Dictionary<int, Pizza> _Pizzas)
        {
            foreach (var pizza in _Pizzas)
            {
                Console.WriteLine(pizza);
            }

        }
       

        public static void UpdatePizza(int index, Pizza pizzas)
        {
          
             foreach (var item in _Pizzas)
            {
               if (item.Value._No.Equals(_Pizzas[index]))
               {
                   _Pizzas[index] = item.Value;
                }
            }

        }
            public static void DeletePizza(int number)
            {
                _Pizzas.Remove(number);

            }

            public static int SearchPizza(string find)
            {
              
                int count = 0;
                foreach (var pizza in _Pizzas)
                {
                    if (pizza.Value._Name.StartsWith(find))
                    {
                        Console.WriteLine(pizza);
                        ++count;
                    }
                }
                return count;
            }

            public static void mergecollections(Menu pizzas)
            {

                _Pizzas.SelectMany(_Pizzas => Topping).ToDictionary(pair => pair.Key, pair => pair.Value);

            }
        }
    }
    