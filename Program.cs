using System;
using System.Diagnostics.CodeAnalysis;
using System.Threading.Channels;
using System.Xml.Linq;
using TrainingApp2;
using TrainingApp2.Menus;
using TrainingApp2.Validators;
using static TrainingApp2.Menus.Menu;

Menu menu = new Menu();
int tempProjectSelectMenu;

ClassicProjectMenu classicProjectMenu = new ClassicProjectMenu();
FinanceProjectMenu financeProjectMenu = new FinanceProjectMenu();

while(true)
{
    tempProjectSelectMenu = menu.DisplayProjectSelectMenu();
    if (tempProjectSelectMenu == (int)ProjectSelectMenuSelections.classicProjectSelection)
    {
        classicProjectMenu.ClassicProjectMenuSelection(); 
    }
    else if (tempProjectSelectMenu == (int)ProjectSelectMenuSelections.financeProjectSelection)
    {
        financeProjectMenu.FinanceProjectMenuSelection();
    }
    else if (tempProjectSelectMenu == (int)ProjectSelectMenuSelections.closeProjectSelection)
    {
        break;
    }
}

