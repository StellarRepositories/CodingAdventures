using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventAlgebra
{
    public class Card
    {
        // [Metadata]
        public bool isKnown; // Effekte decken Karten manchmal auf; das wird beiden Spielern gezeigt
                             // Nur eine Variable dadurch

        // [Stats] 
        public string Name;
        public int darkAttack;
        public int lightAttack;
        public int Health;
        public int faction1; // 1 = sink; 2 = fiery; 3 = celebration; 4 = sun; (...)
        public int faction2; 

        // anhand von Name, Light oder Dark, und Stake kann man die Stats ranholen, right?
        // also brauch ich ein großes Objekt, in dem alle drin sind... hmm... 

        // also lade ich einfach anhand des Stake upgrades immer das nächste nach. Irgendwo muss ich dann abbilden, welche Stakes es gibt
        // oder legit einfach ne dublikat liste
        // das sollte ja gehen 



        // [Keywords]
        List<Keyword> ATKKeywords = new List<Keyword>(); // max. 3 Offensive Keywords
        List<Keyword> DEFKeywords = new List<Keyword>(); // max. 3 Defensive Keywords
        


        public bool canAttack;
        public bool hasDoubleAttack;
        public bool isFiredUp;

        public int location; // 0-7


        public Card()
        {

        }
        public Card(string cardName, int darkAD, int lightAD, int cardHP)
        {
            // MetaDaten
            isKnown = false;
            
            // Stats
            Name = cardName;
            darkAttack = darkAD;
            lightAttack = lightAD;
            Health = cardHP;

            // Effekte
            canAttack = false;
            hasDoubleAttack = false;
            isFiredUp = false;
        }

        public void addAtkKeyword(Keyword keyword)
        {
            if (ATKKeywords.Count < 3)
            {

            }
        }

        public void addDefKeyword()
        { 
        
        }


        public string toString()
        {
            return Name + " " + darkAttack + " " + lightAttack + " " + Health;
        }



    }

   






}
