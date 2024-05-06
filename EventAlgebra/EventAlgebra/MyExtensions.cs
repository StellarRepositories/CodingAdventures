using EventAlgebra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    public static class MyExtensions
    {
        // WE'RE DOING EXTENSION METHODS!!!
        // Welche Extensions wollen wir haben?
        // shuffle:             
        // addSampleCards:      
        // renderDeck:          
        // drawTopCard:        
        // drawBottomCard:      
        // drawCardByProperty:  
        // drawSearchedCard:    ziehe eine Karte mit einer bestimmten Eigenschaft nach User Input. 


        /// <summary>
        /// Shuffle the Deck (works on any List of Cards)
        /// Getestet, funktioniert gut! Aber Randomness wie gesagt nicht vollständig random. 
        /// PSA: Randomness nicht perfekt Random, da Random rand = new Random benutzt wird.
        /// Bitte in Zukunft patchen! // foreshadowing - 30/10/2022
        /// </summary>
        public static void shuffle(this List<Card> Cards)
        {
            return;
            while (true)
            {
                int x = 0;
            
                Random rng = new Random();
            
                int n = Cards.Count;
                while (n > 1)
                {
                    n--;
                    int k = rng.Next(n + 1);
                    Card value = Cards[k];
                    Cards[k] = Cards[n];
                    Cards[n] = value;
                }
                x++;
                if (x > 3)
                {
                    break;
                }
            }
        }

        public static void karteAusspielen()
        {
            // 1. spiele karte aus
            // 2. löse effekt der karte aus 
            // 3. Löse "karte summoned" event aus 
        }



        /// <summary>
        /// Add "size" amount of Cards into a given List of Cards
        /// </summary>
        /// <param name="Cards"></param>
        /// <param name="size"></param> 
        public static void addSampleCards(this List<Card> Cards, int size)
        {
            Console.WriteLine("Kartendeck generator betreten ");
            for (int i = 0; i < size; i++)
            {
                Card card = new Card("Karte" + Cards.Count, Cards.Count, Cards.Count, Cards.Count);
                Cards.Add(card);
            }
        }
        /// <summary>
        /// Render the List of Cards into the Console 
        /// </summary>
        /// <param name="Cards"></param>
        public static void renderDeck(this List<Card> Cards)
        {
            if (Cards.Count != 0)
            {
                for(int i = 0; i < Cards.Count; i++)
                {
                    Console.WriteLine(i + ": " + Cards[i].toString());
                }
            }
            else
            {
                Console.Write("Function renderDeck() found empty List");
            }
        }
        /// <summary>
        /// rendert die Liste der Karten 
        /// </summary>
        /// <param name="Cards"></param>
        public static void renderCardList(this List<CardDescription> descriptions)
        {
            if (descriptions.Count != 0)
            {
                for (int i = 0; i < descriptions.Count; i++)
                {
                    Console.WriteLine(i + ": " + descriptions[i].toString());
                }
            }
            else
            {
                Console.Write("Function renderDeck() found empty List");
            }
        }


        /// <summary>
        /// Returns the first Element from a List of Cards and deletes it from the given List
        /// </summary>
        public static Card drawTopCard(this List<Card> Cards)
        {
            if (Cards.Count != 0)
            {
                Card card = new Card();
                card = Cards[0];
                Cards.RemoveAt(0);
                return card;
            }
            else
            {
                Console.Write("Function drawTopCard fand leere Liste");
                return null;
            }
        }

        public static Card drawBottomCard(this List<Card> Cards)
        {
            if (Cards.Count != 0)
            {
                Card card = new Card();
                card = Cards[Cards.Count - 1];
                Cards.RemoveAt(Cards.Count - 1);
                return card;
            }
            else
            {
                Console.Write("Liste leer - drawBottomCard konnte keine Karte finden");
                return null;
            }
        }

        // HandSchuh
        // SchiffFahrtsKaptain
        // Schifffahrtskaptain


        /// <summary>
        /// Draws cards equal to Property
        /// </summary>
        public static Card drawCardByProperty(this List<Card> Cards, int Property)
        {
            if (Cards.Count != 0)
            {
                Card card = new Card();
                return card;
            }
            else
            {
                Console.Write("Liste leer - drawCardByProperty konnte keine Karte finden");
                return null;
            }
        }

        /// <summary>
        /// Returns the first Card that matches the input string. 
        /// 
        /// </summary>
        public static Card drawSearchedCard(this List<Card> Cards, string searchTerm)
        {
            if (Cards.Count != 0)
            {
                Card card = new Card();
                return card;
            }
            else
            {
                Console.Write("drawSearchedCard");
                return null;
            }
        }
        

    }
}
