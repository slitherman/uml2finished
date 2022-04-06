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

        //    pizza[] pizzadic = {  
        //     new pizza(1, "cheesepizza", 55),
        //    new pizza(2, "cheesepizza", 55),
        //    new pizza(3, "cheesepizza", 55),
        //    new pizza(4, "cheesepizza", 55),
        //    new pizza(5, "cheesepizza", 55),

        //};

    



        public static Dictionary<int, Pizza> _Pizzas = new Dictionary<int, Pizza>();




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
            
            

            //foreach (pizza pizzas in pizzadic)
            //{
            //    _Pizzas.Add(_Pizzas.TryAdd(key)     ,pizzas);
            //}




        }

        //public static void CreatePizza(Pizza pizzas)
        //{
        //    _Pizzas.Add(pizzas._No, pizzas);
        //}

        public static void ReadPizza(Dictionary<int, Pizza> _Pizzas)
        {
            foreach (KeyValuePair<int, Pizza> pizzas in _Pizzas)
            {
                Console.WriteLine(pizzas.Value.ToString());
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
            _Pizzas[index] = pizza;
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
