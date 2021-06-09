using BetCarRaceGame.RaceEngine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BetGame2
{
    public partial class GameForm : Form
    {

        Car[] cars = new Car[4];
        Punter[] punters = new Punter[3];
        Car winnerCar;

        Timer timer1,timer2,timer3,timer4;


        public GameForm()
        {
            InitializeComponent();
            GetCarData();  // method calling to prepare car data here
        }

        // Car Details
        private void GetCarData()
        {
            cars[0] = new Car() { CarName = "Car 1", RaceTrackLength = 1030, MyPictureBox = picCar1 };
            cars[1] = new Car() { CarName = "Car 2", RaceTrackLength = 1030, MyPictureBox = picCar2 };
            cars[2] = new Car() { CarName = "Car 3", RaceTrackLength = 1030, MyPictureBox = picCar3 };
            cars[3] = new Car() { CarName = "Car 4", RaceTrackLength = 1030, MyPictureBox = picCar4 };


            punters[0] = Factory.GetPunter("Thomas");
            punters[1] = Factory.GetPunter("Jack");
            punters[2] = Factory.GetPunter("Alex");
            
            punters[0].MyLabel = labelBet;
            punters[0].MyRadioButton = punter1Radio;
            punters[0].MyText = textBoxPunter1;
            punters[0].MyRadioButton.Text = punters[0].Name;

            
            punters[1].MyLabel = labelBet;
            punters[1].MyRadioButton = punter2Radio;
            punters[1].MyText = textBoxPunter2;
            punters[1].MyRadioButton.Text = punters[1].Name;

            
            punters[2].MyLabel = labelBet;
            punters[2].MyRadioButton = punter3Radio;
            punters[2].MyText = textBoxPunter3;
            punters[2].MyRadioButton.Text = punters[2].Name;

            chooseCar.Minimum = 1;
            chooseCar.Maximum = 4;
            chooseCar.Value = 1;
        }


        private void puntersRadio_CheckedChanged(object sender, EventArgs e)
        {
            SetupBetArena(); // method calling to set the bet arena
        }

        
        //setup bet arena
        private void SetupBetArena()
        {
            foreach (Punter punter in punters)
            {
                if (punter.Busted)
                {
                    punter.MyText.Text = "BUSTED";
                }
                else
                {
                    if (punter.MyBet == null)
                    {
                        punter.MyText.Text = punter.Name + " has not placed any bet";
                    }
                    else
                    {
                        punter.MyText.Text = punter.Name + " bets $" + punter.MyBet.Amount + " on " + punter.MyBet.myCar.CarName;
                    }
                    if (punter.MyRadioButton.Checked)
                    {
                        labelMax.Text = "Max Bet Amount is $" + punter.Cash.ToString();
                        btnAction.Text = "Place Bet for " + punter.Name;
                        punter.MyLabel.Text = punter.Name + " Bets Amount $";
                        SelectBetAmount.Minimum = 1;
                        SelectBetAmount.Maximum = punter.Cash;
                        SelectBetAmount.Value = 1;
                    }
                }
            }
        }

        //Set n Race
        private void btnAction_Click(object sender, EventArgs e)
        {
            if (btnAction.Text.Contains("Place"))
            {
                int count = 0;
                int total_active = 0;
                foreach (Punter punter in punters)
                {
                    if (punter.Busted)
                    {
                        //"Bet Not Placed Because punter is BUSTED";
                    }
                    else
                    { 
                        total_active++;
                        if (punter.MyRadioButton.Checked)
                        {
                            if (punter.MyBet == null)
                            {
                                int number = (int)chooseCar.Value;
                                int amount = (int)SelectBetAmount.Value;
                                bool alreadyPlaced = false;
                                foreach (Punter pun in punters)
                                {
                                    if (pun.MyBet != null && pun.MyBet.myCar == cars[number - 1])
                                    {
                                        alreadyPlaced = true;
                                        break;
                                    }
                                }
                                if (alreadyPlaced)
                                {
                                    MessageBox.Show("This Car is Already Taken By Another Better.");
                                }
                                else
                                {
                                    punter.MyBet = new Bet() { Amount = amount, myCar = cars[number - 1] };
                                }

                            }
                            else
                            {
                                MessageBox.Show("You Already Place Bet for " + punter.Name);
                            }
                        }
                        if (punter.MyBet != null)
                        {
                            count++;
                        }
                    }                    
                }
                SetupBetArena(); // method calling
                if (count == total_active)
                {
                    btnAction.Text = "Start The RACE";
                    panelBet.Enabled = false;
                }
            }
            else if (btnAction.Text.Contains("Start"))
            {
                timer1 = new Timer();
                timer1.Interval = 15;
                timer1.Tick += Cycling_Tick;

                timer2 = new Timer();
                timer2.Interval = 15;
                timer2.Tick += Cycling_Tick;

                timer3 = new Timer();
                timer3.Interval = 15;
                timer3.Tick += Cycling_Tick;

                timer4 = new Timer();
                timer4.Interval = 15;
                timer4.Tick += Cycling_Tick;

                timer1.Start();
                timer2.Start();
                timer3.Start();
                timer4.Start();
                
            }
            else if (btnAction.Text.Contains("Game"))
            {
                MessageBox.Show("Game Over!");
                Application.Exit();
            }
        }


        private void Cycling_Tick(object sender, EventArgs e)
        {
            if(sender is Timer)
            {
                int index = -1;
                Timer timer = sender as Timer;
                if( timer == timer1)
                {
                    index = 0;
                }
                else if (timer == timer2)
                {
                    index = 1;
                }
                else if (timer == timer3)
                {
                    index = 2;
                }
                else if (timer == timer4)
                {
                    index = 3;
                }

                if( index != -1 )
                {
                    PictureBox pbox = cars[index].MyPictureBox;
                    if (pbox.Location.X + pbox.Width > cars[index].RaceTrackLength)
                    {  
                        if (winnerCar == null)
                        {
                            winnerCar = cars[index];
                        }
                        timer1.Stop();
                        timer2.Stop();
                        timer3.Stop();
                        timer4.Stop();
                    }
                    else
                    {
                        int jump = new Random().Next(1, 15);
                        pbox.Location = new Point(pbox.Location.X + jump, pbox.Location.Y);
                    }
                }
            }
            if(winnerCar != null)
            {
                MessageBox.Show("Hurray!!! " + winnerCar.CarName + " is Won...");
                SetupBetArena();
                foreach (Punter punter in punters)
                {
                    if (punter.MyBet != null)
                    {
                        if (punter.MyBet.myCar == winnerCar)
                        {
                            punter.Cash += punter.MyBet.Amount;
                            punter.MyText.Text = punter.Name + " Won and now has $" + punter.Cash;
                            punter.Winner = true;
                        }
                        else
                        {
                            punter.Cash -= punter.MyBet.Amount;
                            if (punter.Cash == 0)
                            {
                                punter.MyText.Text = "BUSTED";
                                punter.Busted = true;
                                punter.MyRadioButton.Enabled = false;
                            }
                            else
                            {
                                punter.MyText.Text = punter.Name + " Lost and now has $" + punter.Cash;
                            }
                        }                        
                    }
                }
                winnerCar = null;
                timer1 = timer2 = timer3 = timer4 = null;
                int count = 0;
                foreach (Punter punter in punters)
                {
                    if (punter.Busted)
                    {
                        count++;
                    }
                    if (punter.MyRadioButton.Enabled && punter.MyRadioButton.Checked)
                    {
                        labelMax.Text = "Max Bet is $" + punter.Cash;
                        SelectBetAmount.Maximum = punter.Cash;
                        SelectBetAmount.Minimum = 1;
                    }
                    punter.MyBet = null;
                    punter.Winner = false;
                }
                if (count == punters.Length)
                {
                    btnAction.Text = "Game Over";

                }
                else
                {
                    panelBet.Enabled = true;
                }
                foreach (Car cycle in cars)
                {
                    cycle.MyPictureBox.Location = new Point(12, cycle.MyPictureBox.Location.Y);
                }
            }
        }
    }
}
