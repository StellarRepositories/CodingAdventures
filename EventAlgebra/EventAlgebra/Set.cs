using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace EventAlgebra
{
    public class Set
    {
        public string Name { get; set; }
        List<Card> card = new List<Card>();

        Set(string BezeichnerDerMenge)
        {
            Name = BezeichnerDerMenge;
        }

        List<object> asd = new List<object>();



        


        // whacko constructor
        //Set(Type Typus)
        //{
        //    List<Typus> card = new List<Typus>();
        //}



    }
}
