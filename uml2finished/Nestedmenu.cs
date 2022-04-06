using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uml2finished
{
    class Nestedmenu
    {
        public delegate void Callback();

        public Nestedmenu Map(string option, Callback callback)
        {
            _options.Add(new Tuple<string, Callback>(option, callback));
            return this;

        }

        public Nestedmenu Prompt(string prompt)
        {
            _prompt = prompt;
            return this;
        }

        private List<Tuple<String, Callback>> _options = new List<Tuple<string, Callback>>();
        private string _prompt = "";


        

        public void Show()
        {
            Keyboardmenu menu = new Keyboardmenu(
                _prompt, 
                _options.ConvertAll((tuple) => tuple.Item1).ToArray());
            _options[menu.RunMenu()].Item2();
        }
    }
}
