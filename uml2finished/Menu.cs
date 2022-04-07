using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uml2finished
{
    class Menu
    {
        //public const int _MenuItems = -1;
        public Pizza Pizza { get; set; }
        public static Dictionary<int, Pizza> _Pizzas = new Dictionary<int, Pizza>()
        {
            { 1, new Pizza  { _No =1, _Name ="cheesepizza", _Price=55, Topping = { "bell peppers", "onions", "beef", " mushrooms"} } },
            { 2,  new Pizza { _No = 2, _Name = "meatlover", _Price = 55,  Topping = { "bell peppers", "onions", "beef", " mushrooms" } } },
            { 3, new Pizza { _No = 3, _Name = "slice of frozen pizza found underneath a cardboardbox inside of the stores walk in freezer", _Price= 55,  Topping = { "bell peppers", "onions", "beef", " mushrooms"      } } },
            {4, new Pizza { _No =4, _Name = "vegetarian", _Price = 55,  Topping = { "bell peppers", "onions", "beef", " mushrooms"  } } },
    };
        //Pizza newpizza1 = new Pizza(44, "cheesepizza", 55);
        //Pizza newpizza2 = new Pizza(45, "meatlover", 55);
        //Pizza newpizza3 = new Pizza(46, "slice of frozen pizza found underneath a cardboardbox inside of the stores walk in freezer", 55);
        //Pizza newpizza4 = new Pizza(47, "vegetarian", 55);
        public Menu()
        {
            _Pizzas.Add(1, Pizza);
            _Pizzas.Add(2, Pizza);

            _Pizzas.Add(3, Pizza);
            _Pizzas.Add(4, Pizza);
            Menu.ReadPizza(_Pizzas);   
        
        }

        public static void CreatePizza(Pizza pizzas, int no)
        {
            _Pizzas.Add(pizzas._No, pizzas);
        }

        public static void ReadPizza(Dictionary<int, Pizza> _Pizzas)
        {
            foreach (var  pizza  in _Pizzas)
            {
                Console.WriteLine(pizza);
            }

            //foreach (KeyValuePair<int, Pizza> pizzas in _Pizzas)
            //{
            //   Console.WriteLine(pizzas);
            //}
        }
        //public static void UpdatePizza(Pizza pizza)
        //{

        //}

        public static void UpdatePizza(int index, Pizza pizza)
        {

            //_Pizzas[index] = pizza;
            //_Pizzas[index.Equals(_Pizzas.Values.
            if ( _Pizzas[index].Equals(_Pizzas.Values ))
            {
               
            }
        }

        public static void DeletePizza(int number)
        {
            _Pizzas.Remove(number);

        }

        public static void SearchPizza(string find)
        {
            //Dictionary<int, pizza>.KeyCollection keycoll = _Pizzas.Keys;

            foreach (var pizza in _Pizzas)
            {
                if (pizza.Value._Name.StartsWith(find))
                    Console.WriteLine(pizza);
            }
        }
    }
}
