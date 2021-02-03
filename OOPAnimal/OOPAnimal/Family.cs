using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPAnimal
{
    class Family
    {
        public int numberOfToes;
        public int numberOfTeeth;
        public bool whiskers;
        public string Name; // don't need to add name for genus and specius b/c it inherite here on family. 
        public bool doesJeremyLikeIt;
        public Family(string _name = null)
        {
            Name = _name;
            Console.WriteLine("Creating: " + _name + " at " + DateTime.Now.ToString ("yyyy-MM-dd"));
        }
        // void return type 
        public void setAttributes (Family sentFamily)
        {
            numberOfToes = sentFamily.numberOfToes;
            numberOfTeeth = sentFamily.numberOfTeeth;
        }
        // RETURN THE BOOL VALUE     
        public bool doesJeremyLikeThisFamily()
        {
            return doesJeremyLikeIt; 
        }
    }
}
