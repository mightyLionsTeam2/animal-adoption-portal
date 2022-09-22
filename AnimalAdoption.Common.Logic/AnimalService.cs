using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalAdoption.Common.Logic
{
    public class AnimalService
    {
        public Animal[] ListAnimals => new Animal[] {
            new Animal { Id = 1, Name = "Alpha", Age = 20, Description = "The leader" },
            new Animal { Id = 2, Name = "Loki", Age = 20, Description = "The cunning" },
            new Animal { Id = 3, Name = "Super King", Age = 20, Description = "The king" },
        };
    }
}
