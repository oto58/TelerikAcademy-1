﻿namespace AnimalHierarchy.Models
{
    public class Tomcat : Cat
    {
        public Tomcat(string name, int age)
            : base(name, age, Gender.Male)
        {
        }
    }
}
