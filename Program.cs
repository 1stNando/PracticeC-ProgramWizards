using System;

namespace Blackjack
{

    //Wizard exercise practice project using basic CLASS, METHODS, IF ELSE statements, use of Constructors as well. Using C#.

    //Lets Create a class called Wizard for our game, note that we do this outside of our default program. We are declaring a Wizard class here.
    class Wizard
    {
        //Here we describe the wizard characteristics.
        public string name;
        public string favoriteSpell;
        private int spellSlots;
        //Note that when using float classes , always add the letter f at the end of the integer used!
        private float experience;

        /////
        public static int Count;

        /////Lets implement a CONSTRUCTOR to maximize our code having to do with our Wizard class.
        //We can create parameters by using constructor. NOTE that we use under score_ simply to differentiate between the "public string name", above.
        public Wizard(string _name, string _favoriteSpell)
        {
            //these two variables are defined in value here and will be assumed every time a NEW wizard is created.
            spellSlots = 2;
            experience = 0f;
            //lets facilitate the creation of new wizards and maximize our code by setting name string and favorite spell.
            name = _name;
            favoriteSpell = _favoriteSpell;

            //lets add to the Counter we created as a "public static int Count" of Wizard class.
            Count++;//this will keep track every time we create a new wizard.

        }


        //Lets go ahead and create some METHODS for the Wizard to do:
        public void CastSpell()
        {
            ///Lets give some functionality to specify what spellSlots can control. Lets create an IF statement, where we only want to cast a spell IF our spell slots variable is greater than zero. So we need to have at least one spell slot in order to cast a spell.
            if (spellSlots > 0)
            {
                //Lets have this type out a sentence to the user:
                Console.WriteLine(name + " casts " + favoriteSpell);
                //Ok, now lets implement the spellSlots characteristic that diminishes the count every time we CastSpell with -- below:
                spellSlots--;//this -- is short for diminish count by one.Then we can go back into the main program and insert the call of method CastSpell.
                //How about we implement experience at this point by say increasing every time a spell casts.
                experience += 0.3f;// this float class uses an f after the use of decimanls.
            }
            //The ELSE statement that follows the IF, explains what should happen when the spellSlots count is at ZERO.
            else
            {
                Console.WriteLine(name + " is out of spell slots.");
            }
        }
        ////next step, we want to give the wizard the ability to gain back spellSlots. Note that we are still within the general Wizard class!
        public void Meditate()//We decide to call this ability Meditate as it makes sense.
        {
            Console.WriteLine(name + "meditates to regain spell slots.");
            //Now we will give back the wizard 2 spellSlots by typing:
            spellSlots = 2;
            //its that easy!
        }



    }
    class Program
    {
        static void Main(string[] args)
        {
            //Here we create the first INSTANCE of a Wizard and set the properties:
            //Within our main program we will create a Wizard based on the class created above.
            //we are passing in this data as PARAMETERS! because we made a constructor. Look at how many less lines of code we typed to do the exact same thing as the less effective method below this.
            Wizard wizard01 = new Wizard("Parry Hopper", "Unexpecto Patronum");
            //Wizard wizard01 = new Wizard();//this and below is the less effective way to code.
            // the . action allows us to access this class.
            //wizard01.name = "Harry Potter";
            //wizard01.favoriteSpell = "Expecto Patronus";
            //wizard01.spellSlots = 2;
            //note the f we need to add when using a float class. Starting experience is zero.
            //wizard01.experience = 0f;

            //At this point, our wizard is pretty boring because there are no METHODS for us to use. Lets create some methods to describe What we want a wizard to be able to do!
            //This is done by us going back to the top and into the "class Wizard".

            ////////////////////////At this point is where the program actually shows something on the screen to the user. Everything above is stating an instance of a wizard occurring in our Main program.///////////////////////////

            //Lets insert a sentence that tells the user the spellSlots count.
            //Console.WriteLine("Spell slots: " + wizard01.spellSlots);

            //call for method CastSpell:
            wizard01.CastSpell();

            //Now lets show the user the spellSlots count once again, but after the fact 
            //that the wizard casted a spell.It should be 1 less than previously.
            Console.WriteLine("Spell slots: " + wizard01.spellSlots);

            //how about we blank out the WriteLine above, and show that our expereince and spellSlots counts are changing. Lets cast 3 spells back to back:
            //wizard01.CastSpell();
            //wizard01.CastSpell();
            //wizard01.CastSpell();

            //give a wizard a break by Meditate:
            //wizard01.Meditate();

            //Now he has gained back some spellSlots by 2 as stated in the Wizard class.
            //cast more spells and see the change:
            //wizard01.CastSpell();
            // wizard01.CastSpell();
            //and then have it print out a line stating our current experience. it should have changed. wizard01 experience should also have changed to 1.2
            //Console.WriteLine("Experience: " + wizard01.experience);
            ///////////////////////////////////////////////////////////////////////////////////
            //Now that we implemented more efficient code by using constructor parameters lets add some more wizards to the game:
            Wizard wizard02 = new Wizard("Glindalf Merlinson", "Abracadabra");
            //and have him cast one spell:
            wizard02.CastSpell();
            //display spellSlots
            Console.WriteLine("Spell slots: " + wizard02.spellSlots);


            Console.WriteLine(Wizard.Count);








        }
    }
