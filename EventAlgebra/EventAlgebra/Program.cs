using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using ExtensionMethods;
using Microsoft.Win32;

namespace EventAlgebra
{

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hallo Welt");
            Console.WriteLine("Welcome to the Card Game");

            List<List<Card>> MengeAllerMengen = new List<List<Card>>();
            
            List<Card> p1_Deck = new List<Card>();
            List<Card> p1_HandKarten = new List<Card>();
            List<Card> p1_Units = new List<Card>();
            List<Card> p1_Artefacts = new List<Card>();
            List<Card> p1_PileResting = new List<Card>();
            List<Card> p1_PileDiscard = new List<Card>();
            List<Card> p1_PileBanish = new List<Card>();
            List<Card> p1_PileSink = new List<Card>();

            List<Card> p2_Deck = new List<Card>();
            List<Card> p2_HandKarten = new List<Card>();
            List<Card> p2_Units = new List<Card>();
            List<Card> p2_Artefacts = new List<Card>();
            List<Card> p2_PileResting = new List<Card>();
            List<Card> p2_PileDiscard = new List<Card>();
            List<Card> p2_PileBanish = new List<Card>();
            List<Card> p2_PileSink = new List<Card>();

            //List<PossibleEvents> EventDinge = new List<PossibleEvents>();


            // Background Deck; List of all cards that are in the game with their stakes 
            //  _____
            // | --  |
            // | --  |
            // |_____|
            List<CardDescription> MengeVonKarten = new List<CardDescription>();

            for (int i = 0; i < 10; i++)
            {
                CardDescription element = new CardDescription();
                MengeVonKarten.Add(element);
            }
            Console.WriteLine("Descriptions: ");
            MengeVonKarten.renderCardList();
            // Weiter: 
            // Wie mach ich das jetzt, das ich aus dieser Liste die Karten holen kann... hmmm ....
            // so dass die handkarten aus diesem Background deck generiert werden
            // schritt 1: liste der unique karten ausm deck (wenn sie mehrmals drin sind, mehrfach
            // ok also brauchen wir ne 2. Liste, die deckliste
            // aus der karten ziehen, und die stats abhängig von gezogener karte (name) und der aktuellen stake festlegen
            // 
            // TL;DR 
            // generate Decklist
            // generate List of all cards effekts through decklist
            // generate hand from deck
            // display hand from effektList
            // Update Cards from effektlist whenever they come to the hand




            // Erstelle Deck, shuffle es und guck obs funktioniert
            p1_Deck.addSampleCards(10);
            Console.WriteLine("  Karten in Spieler 1 Deck: ");
            p1_Deck.renderDeck();

            Console.WriteLine("  shuffle: ");

            p1_Deck.shuffle();
            p1_Deck.renderDeck();




            // check out how switch case works! 
            int Bedingung = 1;
            int effekt = 1;

            switch (Bedingung)
            {
                case 1: // Summon
                    //resolveEffect();
                    break;
                case 2:
                    // code block
                    break;
                default:
                    // code block
                    break;
            }


            System.Threading.Thread.Sleep(1000000);




        }
    }
}


