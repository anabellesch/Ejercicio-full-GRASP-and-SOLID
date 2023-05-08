//---------------------------------------------------------------------------------
// <copyright file="AllInOnePrinter.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//---------------------------------------------------------------------------------
// se usa el principio de polimorfismo
using System;
using System.IO;

namespace Full_GRASP_And_SOLID.Library
{
    public enum Destination
    {
        Console,
        File
    }

    public interface IAllInOnePrinter
    {
        void PrintRecipe(Recipe recipe, Destination destination)
        {


            public class FilePrinter : IAllInOnePrinter {


            public void PrintRecipe(Recipe recipe)
            {
                 File.WriteAllText("Recipe.txt", recipe.GetTextToPrint());
             }
             public class ConsolePrinter : IAllInOnePrinter
            {
                public void PrintRecipe(Recipe recipe)
                     {
                        Console.WriteLine(recipe.GetTextToPrint());
                    }
            }
        }
            
        }

        

    
}
}