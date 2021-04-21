using System;

namespace MyFirstConsoleApplication
{
    /*
        The Person class has two attributes, name and location, with respective getters and setters. 
    */
    class Person
    {
        public string name, location;

        public string GetName()
        {
            return this.name;
        }

        public string GetLocation()
        {
            return this.location;
        }

        public void SetName(string name)
        {
            this.name = name;
        }

        public void SetLocation(string location)
        {
            this.location = location;
        }
    }
}
