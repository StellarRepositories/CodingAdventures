using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace EventAlgebra
{
    public class CardDescription
    {
        // [Global Stats] that arent part of the Object
        static int totalID = 0;

        // [ID]
        int cardID;
        
        // [Primary Key - Identifier over Attributes]
        string cardName;
        bool cardForm; // false - Light; true - Dark
        int Stake;

        // [Data] 
        int Health;
        int DarkAttack;
        int LightAttack;
        string Faction1;
        string Faction2;
        string Condition;
        string OffKeyword1;
        string OffKeyword2;
        string OffKeyword3;
        string DefKeyword1;
        string DefKeyword2;
        string DefKeyword3;
        string Effekt1;
        string Effekt2;
        string Effekt3;




        // generate a new standard Entry of this Type 
        public CardDescription()
        {
            cardID = totalID;
            cardName = "CardName" + totalID;
            cardForm = totalID % 2 == 1;
            Stake = 1+ (totalID % 5);
            Faction1 = "Faction1";
            Faction2 = "Faction2";
            Condition = "Condition: Lightscale positive 5";
            OffKeyword1 = "DoubleAttack";
            OffKeyword2 = "";
            OffKeyword3 = "";
            DefKeyword1 = "Fading";
            DefKeyword2 = "";
            DefKeyword3 = "";
            totalID++;
        }

        public string toString()
        {
            string result = " ";
            result += cardID + " ";
            result += cardName + " ";
            
            if (cardForm == false)
            {
                result += "Light ";
            }
            else
            {
                result += "Dark  "; // 2 Leerzeichen damits aligned
            }

            result += "Stake: " + Stake + " ";
            result += Faction1 + " ";
            result += Faction2 + " ";
            result += Condition + " ";
            result += OffKeyword1 + " ";
            result += OffKeyword2 + " ";
            result += OffKeyword3 + " ";
            result += DefKeyword1 + " ";
            result += DefKeyword2 + " ";
            result += DefKeyword3 + " ";
            result += ";";

            return result;
        }
    }
}

