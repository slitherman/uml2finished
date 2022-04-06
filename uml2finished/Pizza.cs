using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uml2finished
{
    public class Pizza
    {
        public string _Name { get; set; }
        public int _No { get; set; }
        public double _Price { get; set; }


        public Pizza()
        {


        }

        //lav om på ordreren af lister senere
        public Pizza(int _No, string _Name, double _Price)

        {
            this._No = _No;
            this._Name = _Name;
            this._Price = _Price;


        }



        public override string ToString()
        {
            string obj = $" {_No }, {_Name },  {_Price }";
            return obj;
        }

    }
}
