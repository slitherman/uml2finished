using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uml2finished
{
    public class Order: Pizza
    {
        public Customer customer { get; set; }
        public int _ReceiptNumber { get; set; }
        public double _DeliveryFee { get; set; }
        public double _Tax { get; set; }

        public Dictionary<int, Order> _ItemsOrdered = new Dictionary<int, Order>();

        static Order firstorder = new Order(40, 0.05, 11, "cheesepizza", 40.00, "slithermangotasoloset@gmail.com", " rxknephew");
        static Order secondOrder = new Order(40, 0.05, 12, "meatlover", 40.00, "", "lachy");
        static Order thirdOrder = new Order(40, 0.05, 13, "slice of frozen pizza found underneath a cardboardbox inside of the stores walk in freezer", 40.00, "lachy@gmail.com", "lacy");
        static Order fourthOrder = new Order(40, 0.05, 14, "meatlover", 40.00, "lachy@gmail.com", "lachy");

        public Order ()
        {
        }
     
        public Order(double Deliveryfee, double Tax, int _No, string _Name, double _Price, string email, string name)
            : base(_No, _Name, _Price)
        {
            _ReceiptNumber = _ReceiptNumber;
            this._Tax = Tax = 0.05;
            this._DeliveryFee = Deliveryfee = 40;
        }
        public void DeleteOrder(int receiptnumber)
        {
            _ItemsOrdered.Remove(receiptnumber);
        }
     
        public Order UpdateOrders(Order Order, int index)
        {
            

            _ItemsOrdered[index] = Order;

            return Order;
        }

        public double OrderTotal(Pizza products)
        {
            double orderprice = 0;
            foreach (var items in _ItemsOrdered)
            {
                orderprice += products._Price;
                {
                    if (orderprice <= 0)
                    {

                        throw new Customexception("error orderprice cannot be negative");
                    }
                }
            }
            return orderprice * (1.0 + _Tax) + _DeliveryFee;
        }
        public List<Order> CreateListOfOrders()
        {

            _ItemsOrdered.Add(11,firstorder);
            _ItemsOrdered.Add(12, secondOrder);
            _ItemsOrdered.Add(13, thirdOrder);
            _ItemsOrdered.Add(14, fourthOrder);
            return _ItemsOrdered.Values.ToList();
        }
        public void Merge(Order order)
        {
            Order original;
            _ItemsOrdered.TryGetValue(order._No, out original);
            original.Merge(order);
        }
    }
}
