using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game.Domain.Models;
using Game.Domain.Interfaces;
using Game.Domain.Implementations.Factories;
using Game.Domain.Enums;
using Game.Services;
using Game.UI.UIHelpers;
using Game.Domain.Helpers;

namespace Game.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            //For dependency injection 
            IRuleService ruleService = new RuleService();
       
            //Apllication Game Start
            var applicationGame = new ApplicationGame(ruleService);

            var key = 0;
            do
            {
                applicationGame.Start();

                key = InputHelper.ReadKey(2);

            } while (key != 2);

            //Apllication Game End
            applicationGame.EndGame();
        }
       
    }
}
