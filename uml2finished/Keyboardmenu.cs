using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace uml2finished
{
	class Keyboardmenu
	{
			private int _SelectedIndex;
			private string[] _Options;
			//aka displayprompt, den viser ting, så som en titel  
			private string _CommandPrompt;

			public Keyboardmenu(string CommandPrompt, string[] Options ) 
			{
				_Options = Options;
				_CommandPrompt = CommandPrompt;
				_SelectedIndex = 0;

			}

			// sætter displayoption som private fordi at jeg ikke kommer til at bruge meetoden i i userdialogen
			private void DisplayOptions()
			{
				WriteLine(_CommandPrompt);
				for (int i = 0; i < _Options.Length; i++)
				{
					string CurrentOption = _Options[i];
					string prefix;

					//styler menuen
					if (i == _SelectedIndex)
					{
						prefix = "$";
						ForegroundColor = ConsoleColor.Black;
						BackgroundColor = ConsoleColor.DarkMagenta;
					}
					else
					{
						prefix = "";
						ForegroundColor = ConsoleColor.DarkMagenta;
						BackgroundColor = ConsoleColor.Black;
					}

					WriteLine($"{prefix} --{CurrentOption}--");

				}
				ResetColor();
			}
			public int RunMenu()
			{
				ConsoleKey keyPressed;

				do
				{
					Clear();
					DisplayOptions();

					//indplementere bevægelse i menuen, dvs at man kan gå op og ned i menuen
					ConsoleKeyInfo keyInfo = ReadKey(true);
					keyPressed = keyInfo.Key;

					if (keyPressed == ConsoleKey.UpArrow)
					{
						_SelectedIndex--;
						if (_SelectedIndex == -1)
						{

							_SelectedIndex = _Options.Length - 1;
						}

					}

					else if (keyPressed == ConsoleKey.DownArrow)
					{
						_SelectedIndex++;
						if (_SelectedIndex == _Options.Length)
							_SelectedIndex = 0;
						//updaterer selectedindex når at man indtaster noget

					}
				}

				while (keyPressed != ConsoleKey.Enter);

				return _SelectedIndex;

			}
		}
	}
 



