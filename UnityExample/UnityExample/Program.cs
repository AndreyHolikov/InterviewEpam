﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Unity;
using UnityExample.Contracts;
using UnityExample.Implementations;

namespace UnityExample
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Registry

            // Declare a Unity Container
            var unityContainer = new UnityContainer();

            #region Simple Registry

            // Register IGame that when dependency is detected, it will
            // provide a TrivialPursuit instance
            
            unityContainer.RegisterType<IGame, TrivialPursuit>();
            

            #endregion

            #region Property Injection

            // Inject a property when dependecy is resolved
            /*
            InjectionProperty injectionProperty = new InjectionProperty("Name", "Trivial Pursuit Genus Edition");
            unityContainer.RegisterType<IGame, TrivialPursuit>(injectionProperty);
            */
            
            #endregion

            #endregion

            #region Resolving

            #region Direct resolving

            // Make Unity resolve the interface, providing an instance
            // of TrivialPursuit class
            var game = unityContainer.Resolve<IGame>();

            // Check that the behavior is correct
            game.addPlayer();
            game.addPlayer();
            Console.WriteLine(string.Format("{0} people playing to {1}", game.CurrentPlayers, game.Name));
            Console.ReadLine();

            #endregion

            #region Indirect resolving

            // Instantiate an object of Table class through Unity
            var table = unityContainer.Resolve<Table>();

            table.AddPlayer();
            table.AddPlayer();
            table.Play();

            Console.WriteLine(table.GameStatus());
            Console.ReadLine();

            #endregion

            #region Parameter Injection

            // Override the constructor parameter of Table
            var table2 = unityContainer.Resolve<Table>(new ParameterOverride("game", new TicTacToe()));

            table2.AddPlayer();
            table2.AddPlayer();
            table2.Play();
            
            Console.WriteLine(table2.GameStatus());
            Console.ReadLine();

            #endregion

            #endregion

        }
    }
}
