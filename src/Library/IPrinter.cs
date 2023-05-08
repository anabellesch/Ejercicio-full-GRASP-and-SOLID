using System;
using System.IO;
// se usa el principio de polimorfismo

public interface IPrinter
    {
        void PrintRecipe(Recipe recipe, Destination destination);

    }