﻿namespace AnimalHierarchy.Models
{
    public class Kitten : Cat
    {
        public Kitten(string name, int age)
            : base(name, age, Gender.Female)
        {
        }
    }
}
