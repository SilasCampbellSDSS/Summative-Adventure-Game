using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading; //allows the use of Thread.Sleep()
using System.Media; //allows the use of Sound Player

namespace Summative_Adventure_Game
{
    public partial class adventureSummative : Form
    {
        //global variables
        //Random generator to create a 33% chance if you keep walking foward to not die
        Random sense = new Random();
        int awareness = 0;

        //Tracks what page the user is on
        int page = 0;

        public adventureSummative()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            //Setting up game, displaying intial message and options
            awareness = sense.Next(1, 3);

            BackgroundImage = Properties.Resources.Black;
            titleLable.Visible = false;
            startButton.Visible = false;

            Refresh();
            Thread.Sleep(2000);

            BackgroundImage = Properties.Resources.Alien_Cell;
            descriptorLabel.Visible = true;
            option1.Visible = true;
            option2.Visible = true;
            option3.Visible = true;
        }

        private void option1_Click(object sender, EventArgs e)
        {
            //Tracking what page the user is on and what page the player needs to go to if they select option 1 on a certain page

            if (page == 0)
            {
                page = 1;
            }
            else if (page == 3)
            {
                page = 5;
            }
            else if (page == 4)
            {
                page = 5;
            }
            else if (page == 5)
            {
                page = 7;
            }
            else if (page == 7)
            {
                page = 8;
            }
            else if (page == 8)
            {
                page = 10;
            }
            else if (page == 10)
            {
                page = 11;
            }
            else if (page == 11)
            {
                page = 12;
            }
            else if (page == 12)
            {
                page = 13;
            }
            else if (page == 13)
            {
                page = 15;
            }
            else if (page == 15)
            {
                page = 17;
            }
            else if (page == 17)
            {
                page = 18;
            }
            else if (page == 19)
            {
                page = 21;
            }
            else if (page == 98)
            {
                page = 0;
            }

            //Displays game options based off current page, this code is reoccuring but I couldn't find a way for the program to work without repeating this

            switch (page)
            {
                case 0:
                    awareness = sense.Next(1, 3);

                    BackgroundImage = Properties.Resources.Black;
                    titleLable.Visible = false;
                    startButton.Visible = false;

                    Refresh();
                    Thread.Sleep(2000);

                    BackgroundImage = Properties.Resources.Alien_Cell;
                    descriptorLabel.Visible = true;
                    option1.Visible = true;
                    option2.Visible = true;
                    option3.Visible = true;

                    descriptorLabel.Text = "You wake up in some kind of cell. It appears very technologically advanced. You don't remember how you got here. Actually you don't remember anything at all, who you are, where you came from,not even your name.";
                    option1.Text = "Observe your surroundings";
                    option2.Text = "Call out for help";
                    option3.Text = "Attempt to open the cell";

                    break;
                case 1:
                    descriptorLabel.Text = "You are in some kind of alien like cell. You do not see any buttons or things that could help you escape. Although you do recognize the door like structure in front of you...";
                    option1.Visible = false;

                    break;
                case 2:
                    descriptorLabel.Text = "Nobody responds to your call.";

                    Refresh();
                    Thread.Sleep(2000);

                    descriptorLabel.Text = "In fact the whole place seems kind of empty...";

                    option2.Visible = false;

                    break;
                case 3:
                    descriptorLabel.Text = "You approach the door like structure, do you...";
                    option1.Visible = true;
                    option2.Visible = true;
                    option3.Visible = false;

                    option1.Text = "Feel for a lock or something similar";
                    option2.Text = "Push as hard as you can";

                    break;
                case 4:
                    descriptorLabel.Text = "You push as hard as you can but nothing happens";
                    option2.Visible = false;

                    break;
                case 5:
                    descriptorLabel.Text = "You do not find any lock but you do find a small gap in the door do you...";
                    option2.Visible = true;

                    option1.Text = "Put your hand in";
                    option2.Text = "Do nothing and just wait";

                    break;
                case 6:
                    descriptorLabel.Text = "You do not put your hand in. Nobody comes to give you food or water, you die. Play again? (press menu to get options)";

                    option1.Visible = false;
                    option2.Visible = false;
                    menuLabel.Visible = true;

                    break;
                case 7:
                    descriptorLabel.Text = "You put your hand in the gap, it feels uncomfortably warm";

                    option1.Text = "Pull your hand out";
                    option2.Text = "Keep your hand in";

                    break;
                case 8:
                    descriptorLabel.Text = "You pull your hand out but the feeling doesn't stop, in fact it gets worse,like your entire body is on fire. ";

                    option1.Text = "Try and put your hand back in";
                    option2.Text = "Wait";

                    break;
                case 9:
                    descriptorLabel.Text = "You wait but it doesn't get better, eventually you pass out and die of themysterious heat. Play again? (press menu to get options)";

                    option1.Visible = false;
                    option2.Visible = false;
                    menuLabel.Visible = true;

                    break;
                case 10:
                    descriptorLabel.Text = "The heat energy envelops your wholebody, you feel like you're going to die then, it goesaway.The door lights up, then slowly opens...";

                    option1.Visible = false;
                    option2.Visible = false;

                    Refresh();
                    Thread.Sleep(2000);

                    BackgroundImage = Properties.Resources.Black;

                    Refresh();
                    Thread.Sleep(2000);

                    BackgroundImage = Properties.Resources.Hallway_One;

                    descriptorLabel.Text = "You are in a dark alien hallway, barely illuminated by blue light.";

                    option1.Visible = true;
                    option2.Visible = true;

                    option1.Text = "Go left";
                    option2.Text = "Go right";

                    break;
                case 11:
                    descriptorLabel.Text = "You arrive at a dead end, you see a container at the end of the hall.";

                    option1.Text = "Open it";
                    option2.Text = "Go back";

                    break;
                case 12:

                    descriptorLabel.Text = "It is locked";

                    option2.Visible = false;

                    option1.Text = "Go back";

                    break;
                case 13:
                    BackgroundImage = Properties.Resources.Hallway_Two;
                    SoundPlayer spaceplayer = new SoundPlayer(Properties.Resources.Space);

                    descriptorLabel.Text = "You walk right, eventually you start tohear ominous noises. It might be the ship, or something else ...";

                    option3.Visible = true;
                    option2.Visible = true;

                    option1.Text = "Wait and see if anything comes";
                    option2.Text = "Trek ahead";
                    option3.Text = "Go back to your cell";

                    break;
                case 14:
                    descriptorLabel.Text = "You turn around, then suddenly something attacks you from behind, you never see what it was. You die. Play again? (press menu to get options)";

                    option1.Visible = false;
                    option2.Visible = false;
                    option3.Visible = false;
                    menuLabel.Visible = true;

                    break;
                case 15:
                    if (awareness == 1)
                    {
                        descriptorLabel.Text = "You see something move in the corner of your eye";

                        option1.Text = "RUN!!!";
                        option2.Text = "Continue moving foward";
                    }
                    else
                    {
                        descriptorLabel.Text = "You keep waiting, then suddenly something attacks you from behind, you never see what it was. You die. Play again? (press menu to get options)";

                        option1.Visible = false;
                        option2.Visible = false;
                        option3.Visible = false;
                        menuLabel.Visible = true;
                    }

                    break;
                case 16:
                    descriptorLabel.Text = "You keep walking, then suddenly something attacks you from behind, you never see what it was. You die. Play again? (press menu to get options)";

                    option1.Visible = false;
                    option2.Visible = false;
                    option3.Visible = false;
                    menuLabel.Visible = true;

                    break;
                case 17:
                    descriptorLabel.Text = "You start running down the hall, you hear footsteps and some kind of alien scream behind you. You arrive at a fork do you...";

                    option1.Text = "Turn left";
                    option2.Text = "Turn right";
                    break;
                case 18:
                    BackgroundImage = Properties.Resources.Alien;

                    descriptorLabel.ForeColor = Color.Black;

                    descriptorLabel.Text = "You arrive at a dead end, the alien kills you. Play again? (press menu to get options)";

                    option1.Visible = false;
                    option2.Visible = false;
                    option3.Visible = false;
                    menuLabel.Visible = true;

                    break;
                case 19:
                    BackgroundImage = Properties.Resources.Hangar;

                    descriptorLabel.Text = "Your turn right and arrive in some kind of hanger bay there are three ships Choose 1, but be fast!";

                    option1.Text = "Hop in the first ship";
                    option2.Text = "Hop in the second ship";
                    option3.Text = "Hop in the third ship";

                    break;
                case 20:
                    BackgroundImage = Properties.Resources.Space_Station;

                    descriptorLabel.Text = "The ship explodes, you die. Play again? (press menu to get options)";

                    option1.Visible = false;
                    option2.Visible = false;
                    option3.Visible = false;
                    menuLabel.Visible = true;

                    break;
                case 21:
                    BackgroundImage = Properties.Resources.Space_Station;

                    descriptorLabel.Text = "This ship works! You escape the ship. Play again? (press menu to get options)";

                    option1.Visible = false;
                    option2.Visible = false;
                    option3.Visible = false;
                    menuLabel.Visible = true;

                    break;
                case 98:
                    BackgroundImage = Properties.Resources.Space_Station;
                    
                    option1.Visible = true;
                    option2.Visible = true;
                    option3.Visible = false;
                    menuLabel.Visible = false;

                    descriptorLabel.Text = "Play again?";
                    option1.Text = "Yes";
                    option2.Text = "No";

                    break;
                case 99:
                    descriptorLabel.Text = "Thanks for playing!";

                    option1.Visible = false;
                    option2.Visible = false;
                    option3.Visible = false;

                    Refresh();
                    Thread.Sleep(2000);

                    BackgroundImage = Properties.Resources.Black;

                    Close();

                    break;
            }
        }

        private void option2_Click(object sender, EventArgs e)
        {
      
            //Tracking what page the user is on and what page the player needs to go to if they select option 2 on a certain page

            if (page == 0)
            {
                page = 2;
            }
            else if (page == 1)
            {
                page = 2;
            }
            else if (page == 3)
            {
                page = 4;
            }
            else if (page == 5)
            {
                page = 6;
            }
            else if (page == 7)
            {
                page = 10;
            }
            else if (page == 8)
            {
                page = 9;
            }
            else if (page == 10)
            {
                page = 13;
            }
            else if (page == 11)
            {
                page = 13;
            }
            else if (page == 13)
            {
                page = 15;
            }
            else if (page == 15)
            {
                page = 16;
            }
            else if (page == 17)
            {
                page = 19;
            }
            else if (page == 19)
            {
                page = 20;
            }
            else if (page == 98)
            {
                page = 99;
            }

            //Displays game options based off current page, this code is reoccuring but I couldn't find a way for the program to work without repeating this

            switch (page)
            {
                case 0:
                    awareness = sense.Next(1, 3);

                    BackgroundImage = Properties.Resources.Black;
                    titleLable.Visible = false;
                    startButton.Visible = false;

                    Refresh();
                    Thread.Sleep(2000);

                    BackgroundImage = Properties.Resources.Alien_Cell;
                    descriptorLabel.Visible = true;
                    option1.Visible = true;
                    option2.Visible = true;
                    option3.Visible = true;
                    
                    break;
                case 1:
                    descriptorLabel.Text = "You are in some kind of alien like cell. You do not see any buttons or things that could help you escape. Although you do recognize the door like structure in front of you...";
                    option1.Visible = false;

                    break;
                case 2:
                    descriptorLabel.Text = "Nobody responds to your call.";

                    Refresh();
                    Thread.Sleep(2000);

                    descriptorLabel.Text = "In fact the whole place seems kind of empty...";

                    option2.Visible = false;

                    break;
                case 3:
                    descriptorLabel.Text = "You approach the door like structure, do you...";
                    option1.Visible = true;
                    option2.Visible = true;
                    option3.Visible = false;

                    option1.Text = "Feel for a lock or something similar";
                    option2.Text = "Push as hard as you can";

                    break;
                case 4:
                    descriptorLabel.Text = "You push as hard as you can but nothing happens";
                    option2.Visible = false;

                    break;
                case 5:
                    descriptorLabel.Text = "You do not find any lock but you do find a small gap in the door do you...";
                    option2.Visible = true;

                    option1.Text = "Put your hand in";
                    option2.Text = "Do nothing and just wait";

                    break;
                case 6:
                    descriptorLabel.Text = "You do not put your hand in. Nobody comes to give you food or water, you die. Play again? (press menu to get options)";

                    option1.Visible = false;
                    option2.Visible = false;
                    menuLabel.Visible = true;

                    break;
                case 7:
                    descriptorLabel.Text = "You put your hand in the gap, it feels uncomfortably warm";

                    option1.Text = "Pull your hand out";
                    option2.Text = "Keep your hand in";

                    break;
                case 8:
                    descriptorLabel.Text = "You pull your hand out but the feeling doesn't stop, in fact it gets worse,like your entire body is on fire. ";

                    option1.Text = "Try and put your hand back in";
                    option2.Text = "Wait";

                    break;
                case 9:
                    descriptorLabel.Text = "You wait but it doesn't get better, eventually you pass out and die of themysterious heat. Play again? (press menu to get options)";

                    option1.Visible = false;
                    option2.Visible = false;
                    menuLabel.Visible = true;

                    break;
                case 10:
                    descriptorLabel.Text = "The heat energy envelops your wholebody, you feel like you're going to die then, it goesaway.The door lights up, then slowly opens...";

                    option1.Visible = false;
                    option2.Visible = false;

                    Refresh();
                    Thread.Sleep(2000);

                    BackgroundImage = Properties.Resources.Black;

                    Refresh();
                    Thread.Sleep(2000);

                    BackgroundImage = Properties.Resources.Hallway_One;

                    descriptorLabel.Text = "You are in a dark alien hallway, barely illuminated by blue light.";

                    option1.Visible = true;
                    option2.Visible = true;

                    option1.Text = "Go left";
                    option2.Text = "Go right";

                    break;
                case 11:
                    descriptorLabel.Text = "You arrive at a dead end, you see a container at the end of the hall.";

                    option1.Text = "Open it";
                    option2.Text = "Go back";

                    break;
                case 12:
                    descriptorLabel.Text = "It is locked";

                    option2.Visible = false;

                    option1.Text = "Go back";

                    break;
                case 13:
                    BackgroundImage = Properties.Resources.Hallway_Two;
                    SoundPlayer spaceplayer = new SoundPlayer(Properties.Resources.Space);
                    descriptorLabel.Text = "You walk right, eventually you start tohear ominous noises. It might be the ship, or something else ...";

                    option3.Visible = true;
                    option2.Visible= true;

                    option1.Text = "Wait and see if anything comes";
                    option2.Text = "Trek ahead";
                    option3.Text = "Go back to your cell";

                    break;
                case 14:
                    descriptorLabel.Text = "You turn around, then suddenly something attacks you from behind, you never see what it was. You die. Play again? (press menu to get options)";

                    option1.Visible = false;
                    option2.Visible = false;
                    option3.Visible = false;
                    menuLabel.Visible = true;

                    break;
                case 15:
                    if (awareness == 1)
                    {
                        descriptorLabel.Text = "You see something move in the corner of your eye";

                        option1.Text = "RUN!!!";
                        option2.Text = "Continue moving foward";
                    }
                    else
                    {
                        descriptorLabel.Text = "You keep waiting, then suddenly something attacks you from behind, you never see what it was. You die. Play again? (press menu to get options)";

                        option1.Visible = false;
                        option2.Visible = false;
                        option3.Visible = false;
                        menuLabel.Visible = true;
                    }

                    break;
                case 16:
                    descriptorLabel.Text = "You keep walking, then suddenly something attacks you from behind, you never see what it was. You die. Play again? (press menu to get options)";

                    option1.Visible = false;
                    option2.Visible = false;
                    option3.Visible = false;
                    menuLabel.Visible = true;

                    break;
                case 17:
                    descriptorLabel.Text = "You start running down the hall, you hear footsteps and some kind of alien scream behind you. You arrive at a fork do you...";

                    option1.Text = "Turn left";
                    option2.Text = "Turn right";
                    
                    break;
                case 18:
                    BackgroundImage = Properties.Resources.Alien;
                   
                    descriptorLabel.ForeColor = Color.Black;
                    descriptorLabel.Text = "You arrive at a dead end, the alien kills you. Play again? (press menu to get options)";

                    option1.Visible = false;
                    option2.Visible = false;
                    option3.Visible = false;
                    menuLabel.Visible = true;

                    break;
                case 19:
                    BackgroundImage = Properties.Resources.Hangar;

                    descriptorLabel.Text = "Your turn right and arrive in some kind of hanger bay there are three ships Choose 1, but be fast!";

                    option1.Text = "Hop in the first ship";
                    option2.Text = "Hop in the second ship";
                    option3.Text = "Hop in the third ship";

                    break;
                case 20:
                    BackgroundImage = Properties.Resources.Space_Station;

                    descriptorLabel.Text = "The ship explodes, you die. Play again? (press menu to get options)";

                    option1.Visible = false;
                    option2.Visible = false;
                    option3.Visible = false;
                    menuLabel.Visible = true;

                    break;
                case 21:
                    BackgroundImage = Properties.Resources.Space_Station;

                    descriptorLabel.Text = "This ship works! You escape the ship. Play again? (press menu to get options)";

                    option1.Visible = false;
                    option2.Visible = false;
                    option3.Visible = false;
                    menuLabel.Visible = true;

                    break;
                case 98:
                    BackgroundImage = Properties.Resources.Space_Station;

                    option1.Visible = true;
                    option2.Visible = true;
                    option3.Visible = false;
                    menuLabel.Visible = false;

                    descriptorLabel.Text = "Play again?";
                    option1.Text = "Yes";
                    option2.Text = "No";

                    break;
                case 99:
                    descriptorLabel.Text = "Thanks for playing!";

                    option1.Visible = false;
                    option2.Visible = false;
                    option3.Visible = false;

                    Refresh();
                    Thread.Sleep(2000);

                    BackgroundImage = Properties.Resources.Black;

                    Close();

                    break;
            }
        }
        private void option3_Click(object sender, EventArgs e)
        {
            //Tracking what page the user is on and what page the player needs to go to if they select option 3 on a certain page

            if (page == 0)
            {
                page = 3;
            }
            else if (page == 1)
            {
                page = 3;
            }
            else if (page == 2)
            {
                page = 3;
            }
            else if (page == 13)
            {
                page = 14;
            }
            else if (page == 19)
            {
                page = 21;
            }

            switch (page)
            {
                case 0:
                    awareness = sense.Next(1, 3);

                    BackgroundImage = Properties.Resources.Black;
                    titleLable.Visible = false;
                    startButton.Visible = false;

                    Refresh();
                    Thread.Sleep(2000);


                    BackgroundImage = Properties.Resources.Alien_Cell;
                    descriptorLabel.Visible = true;
                    option1.Visible = true;
                    option2.Visible = true;
                    option3.Visible = true;

                    break;
               
                //Displays game options based off current page, this code is reoccuring but I couldn't find a way for the program to work without repeating this

                case 1:
                    descriptorLabel.Text = "You are in some kind of alien like cell. You do not see any buttons or things that could help you escape. Although you do recognize the door like structure in front of you...";
                    option1.Visible = false;

                    break;
                case 2:
                    descriptorLabel.Text = "Nobody responds to your call.";


                    Refresh();
                    Thread.Sleep(2000);

                    descriptorLabel.Text = "In fact the whole place seems kind of empty...";

                    option2.Visible = false;
                    
                    break;
                case 3:
                    descriptorLabel.Text = "You approach the door like structure, do you...";
                    option1.Visible = true;
                    option2.Visible = true;
                    option3.Visible = false;

                    option1.Text = "Feel for a lock or something similar";
                    option2.Text = "Push as hard as you can";

                    break;
                case 4:
                    descriptorLabel.Text = "You push as hard as you can but nothing happens";
                    option2.Visible = false;

                    break;
                case 5:
                    descriptorLabel.Text = "You do not find any lock but you do find a small gap in the door do you...";
                    option2.Visible = true;

                    option1.Text = "Put your hand in";
                    option2.Text = "Do nothing and just wait";

                    break;
                case 6:
                    descriptorLabel.Text = "You do not put your hand in. Nobody comes to give you food or water, you die. Play again? (press menu to get options)";

                    option1.Visible = false;
                    option2.Visible = false;
                    menuLabel.Visible = true;

                    break;
                case 7:
                    descriptorLabel.Text = "You put your hand in the gap, it feels uncomfortably warm";

                    option1.Text = "Pull your hand out";
                    option2.Text = "Keep your hand in";

                    break;
                case 8:
                    descriptorLabel.Text = "You pull your hand out but the feeling doesn't stop, in fact it gets worse,like your entire body is on fire. ";

                    option1.Text = "Try and put your hand back in";
                    option2.Text = "Wait";

                    break;
                case 9:
                    descriptorLabel.Text = "You wait but it doesn't get better, eventually you pass out and die of themysterious heat. Play again? (press menu to get options)";

                    option1.Visible = false;
                    option2.Visible = false;
                    menuLabel.Visible = true;

                    break;
                case 10:
                    descriptorLabel.Text = "The heat energy envelops your wholebody, you feel like you're going to die then, it goesaway.The door lights up, then slowly opens...";

                    option1.Visible = false;
                    option2.Visible = false;

                    Refresh();
                    Thread.Sleep(2000);

                    BackgroundImage = Properties.Resources.Black;

                    Refresh();
                    Thread.Sleep(2000);

                    BackgroundImage = Properties.Resources.Hallway_One;

                    descriptorLabel.Text = "You are in a dark alien hallway, barely illuminated by blue light.";

                    option1.Visible = true;
                    option2.Visible = true;

                    option1.Text = "Go left";
                    option2.Text = "Go right";

                    break;
                case 11:
                    descriptorLabel.Text = "You arrive at a dead end, you see a container at the end of the hall.";

                    option1.Text = "Open it";
                    option2.Text = "Go back";

                    break;
                case 12:
                    descriptorLabel.Text = "It is locked";

                    option2.Visible = false;

                    option1.Text = "Go back";

                    break;
                case 13:
                    BackgroundImage = Properties.Resources.Hallway_Two;
                    SoundPlayer spaceplayer = new SoundPlayer(Properties.Resources.Space);
                    descriptorLabel.Text = "You walk right, eventually you start tohear ominous noises. It might be the ship, or something else ...";

                    option3.Visible = true;
                    option2.Visible = true;

                    option1.Text = "Wait and see if anything comes";
                    option2.Text = "Trek ahead";
                    option3.Text = "Go back to your cell";

                    break;
                case 14:
                    descriptorLabel.Text = "You turn around, then suddenly something attacks you from behind, you never see what it was. You die. Play again? (press menu to get options)";

                    option1.Visible = false;
                    option2.Visible = false;
                    option3.Visible = false;
                    menuLabel.Visible = true;

                    break;
                case 15:
                    if (awareness == 1)
                    {
                        descriptorLabel.Text = "You see something move in the corner of your eye";

                        option1.Text = "RUN!!!";
                        option2.Text = "Continue moving foward";
                    }
                    else
                    {
                        descriptorLabel.Text = "You keep waiting, then suddenly something attacks you from behind, you never see what it was. You die. Play again? (press menu to get options)";

                        option1.Visible = false;
                        option2.Visible = false;
                        option3.Visible = false;
                        menuLabel.Visible = true;
                    }

                    break;
                case 16:
                    descriptorLabel.Text = "You keep walking, then suddenly something attacks you from behind, you never see what it was. You die. Play again? (press menu to get options)";

                    option1.Visible = false;
                    option2.Visible = false;
                    option3.Visible = false;
                    menuLabel.Visible = true;

                    break;
                case 17:
                    descriptorLabel.Text = "You start running down the hall, you hear footsteps and some kind of alien scream behind you. You arrive at a fork do you...";

                    option1.Text = "Turn left";
                    option2.Text = "Turn right";
                    break;

                case 18:
                    BackgroundImage = Properties.Resources.Alien;

                    descriptorLabel.ForeColor = Color.Black;
                    descriptorLabel.Text = "You arrive at a dead end, the alien kills you. Play again? (press menu to get options)";

                    option1.Visible = false;
                    option2.Visible = false;
                    option3.Visible = false;
                    menuLabel.Visible = true;

                    break;
                case 19:
                    BackgroundImage = Properties.Resources.Hangar;

                    descriptorLabel.Text = "Your turn right and arrive in some kind of hanger bay there are three ships Choose 1, but be fast!";

                    option1.Text = "Hop in the first ship";
                    option2.Text = "Hop in the second ship";
                    option3.Text = "Hop in the third ship";

                    break;
                case 20:
                    BackgroundImage = Properties.Resources.Space_Station;

                    descriptorLabel.Text = "The ship explodes, you die. Play again? (press menu to get options)";

                    option1.Visible = false;
                    option2.Visible = false;
                    option3.Visible = false;
                    menuLabel.Visible = true;

                    break;
                case 21:
                    BackgroundImage = Properties.Resources.Space_Station;

                    descriptorLabel.Text = "This ship works! You escape the ship. Play again? (press menu to get options)";

                    option1.Visible = false;
                    option2.Visible = false;
                    option3.Visible = false;
                    menuLabel.Visible = true;

                    break;
                case 98:
                    BackgroundImage = Properties.Resources.Space_Station;

                    option1.Visible = true;
                    option2.Visible = true;
                    option3.Visible = false;
                    menuLabel.Visible = false;

                    descriptorLabel.Text = "Play again?";
                    option1.Text = "Yes";
                    option2.Text = "No";

                    break;
                case 99:
                    descriptorLabel.Text = "Thanks for playing!";

                    option1.Visible = false;
                    option2.Visible = false;
                    option3.Visible = false;

                    Refresh();
                    Thread.Sleep(2000);

                    BackgroundImage = Properties.Resources.Black;

                    Close();

                    break;
            }
        }

        private void menuLabel_Click(object sender, EventArgs e)
        {
            //Options to be displayed on death
            
            page = 98;

            switch (page)
            {
                case 1:
                    descriptorLabel.Text = "You are in some kind of alien like cell. You do not see any buttons or things that could help you escape. Although you do recognize the door like structure in front of you...";
                    option1.Visible = false;

                    break;
                case 2:
                    descriptorLabel.Text = "Nobody responds to your call.";

                    Refresh();
                    Thread.Sleep(2000);

                    descriptorLabel.Text = "In fact the whole place seems kind of empty...";

                    option2.Visible = false;

                    break;
                case 3:
                    descriptorLabel.Text = "You approach the door like structure, do you...";
                    option1.Visible = true;
                    option2.Visible = true;
                    option3.Visible = false;

                    option1.Text = "Feel for a lock or something similar";
                    option2.Text = "Push as hard as you can";

                    break;
                case 4:
                    descriptorLabel.Text = "You push as hard as you can but nothing happens";
                    option2.Visible = false;

                    break;
                case 5:
                    descriptorLabel.Text = "You do not find any lock but you do find a small gap in the door do you...";
                    option2.Visible = true;

                    option1.Text = "Put your hand in";
                    option2.Text = "Do nothing and just wait";

                    break;
                case 6:
                    descriptorLabel.Text = "You do not put your hand in. Nobody comes to give you food or water, you die. Play again? (press menu to get options)";

                    option1.Visible = false;
                    option2.Visible = false;
                    menuLabel.Visible = true;

                    break;
                case 7:
                    descriptorLabel.Text = "You put your hand in the gap, it feels uncomfortably warm";

                    option1.Text = "Pull your hand out";
                    option2.Text = "Keep your hand in";

                    break;
                case 8:
                    descriptorLabel.Text = "You pull your hand out but the feeling doesn't stop, in fact it gets worse,like your entire body is on fire. ";

                    option1.Text = "Try and put your hand back in";
                    option2.Text = "Wait";

                    break;
                case 9:
                    descriptorLabel.Text = "You wait but it doesn't get better, eventually you pass out and die of themysterious heat. Play again? (press menu to get options)";

                    option1.Visible = false;
                    option2.Visible = false;
                    menuLabel.Visible = true;

                    break;
                case 10:
                    descriptorLabel.Text = "The heat energy envelops your wholebody, you feel like you're going to die then, it goesaway.The door lights up, then slowly opens...";

                    option1.Visible = false;
                    option2.Visible = false;

                    Refresh();
                    Thread.Sleep(2000);

                    BackgroundImage = Properties.Resources.Black;

                    Refresh();
                    Thread.Sleep(2000);

                    BackgroundImage = Properties.Resources.Hallway_One;

                    descriptorLabel.Text = "You are in a dark alien hallway, barely illuminated by blue light.";

                    option1.Visible = true;
                    option2.Visible = true;

                    option1.Text = "Go left";
                    option2.Text = "Go right";

                    break;
                case 11:
                    descriptorLabel.Text = "You arrive at a dead end, you see a container at the end of the hall.";

                    option1.Text = "Open it";
                    option2.Text = "Go back";

                    break;
                case 12:
                    descriptorLabel.Text = "It is locked";

                    option2.Visible = false;

                    option1.Text = "Go back";

                    break;
                case 13:
                    BackgroundImage = Properties.Resources.Hallway_Two;

                    descriptorLabel.Text = "You walk right, eventually you start tohear unrecognizable noises. It might be the ship, or something else ...";

                    option2.Visible = true;
                    option3.Visible = true;

                    option1.Text = "Wait and see if anything comes";
                    option2.Text = "Trek ahead";
                    option3.Text = "Go back to your cell";

                    break;
                case 14:
                    descriptorLabel.Text = "You turn around, then suddenly something attacks you from behind, you never see what it was. You die. Play again? (press menu to get options)";

                    option1.Visible = false;
                    option2.Visible = false;
                    option3.Visible = false;
                    menuLabel.Visible = true;

                    break;
                case 15:
                    if (awareness == 1)
                    {
                        descriptorLabel.Text = "You see something move in the corner of your eye";

                        option1.Text = "RUN!!!";
                        option2.Text = "Continue moving foward";
                    }
                    else
                    {
                        descriptorLabel.Text = "You keep waiting, then suddenly something attacks you from behind, you never see what it was. You die. Play again? (press menu to get options)";

                        option1.Visible = false;
                        option2.Visible = false;
                        option3.Visible = false;
                        menuLabel.Visible = true;
                    }
                    
                    break;
                case 16:
                    descriptorLabel.Text = "You keep walking, then suddenly something attacks you from behind, you never see what it was. You die. Play again? (press menu to get options)";

                    option1.Visible = false;
                    option2.Visible = false;
                    option3.Visible = false;
                    menuLabel.Visible = true;

                    break;
                case 17:
                    descriptorLabel.Text = "You start running down the hall, you hear footsteps and some kind of alien scream behind you. You arrive at a fork do you...";

                    option1.Text = "Turn left";
                    option2.Text = "Turn right";
                    break;
                case 18:
                    BackgroundImage = Properties.Resources.Alien;

                    descriptorLabel.Text = "You arrive at a dead end, the alien kills you. Play again? (press menu to get options)";

                    option1.Visible = false;
                    option2.Visible = false;
                    option3.Visible = false;
                    menuLabel.Visible = true;

                    break;
                case 19:
                    BackgroundImage = Properties.Resources.Hangar;

                    descriptorLabel.Text = "Your turn right and arrive in some kind of hanger bay there are three ships Choose 1, but be fast!";

                    option1.Text = "Hop in the first ship";
                    option2.Text = "Hop in the second ship";
                    option3.Text = "Hop in the third ship";

                    break;
                case 20:
                    BackgroundImage = Properties.Resources.Space_Station;

                    descriptorLabel.Text = "The ship explodes, you die. Play again? (press menu to get options)";

                    option1.Visible = false;
                    option2.Visible = false;
                    option3.Visible = false;
                    menuLabel.Visible = true;

                    break;
                case 21:
                    BackgroundImage = Properties.Resources.Space_Station;

                    descriptorLabel.Text = "This ship works! You escape the ship. Play again? (press menu to get options)";

                    option1.Visible = false;
                    option2.Visible = false;
                    option3.Visible = false;
                    menuLabel.Visible = true;

                    break;
                case 98:
                    BackgroundImage = Properties.Resources.Space_Station;

                    option1.Visible = true;
                    option2.Visible = true;
                    option3.Visible = false;
                    menuLabel.Visible = false;

                    descriptorLabel.Text = "Play again?";
                    option1.Text = "Yes";
                    option2.Text = "No";

                    break;
                
                //Closes the game when the player decides to stop playing
                
                case 99:
                    descriptorLabel.Text = "Thanks for playing!";

                    option1.Visible = false;
                    option2.Visible = false;
                    option3.Visible = false;

                    Refresh();
                    Thread.Sleep(2000);

                    BackgroundImage = Properties.Resources.Black;

                    Close();

                    break;
            } 
        }

    
    }
}
