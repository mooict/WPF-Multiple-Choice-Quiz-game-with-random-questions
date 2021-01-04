using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Quiz_Game_WPF_MOO_ICT
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // create a new list of integers called question numbers
        // this interger will hold how many questions we have for this quiz and we will shuffle this inside the start game function
        List<int> questionNumbers = new List<int> {1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        // create 3 more integers called qNum that will control which question shows on the screen, i and score
        int qNum = 0;
        int i;
        int score;


        public MainWindow()
        {
            InitializeComponent();

            // inside of the main constructor we will run the start game and next question function

            StartGame();
            NextQuestion();
        }

        private void checkAnswer(object sender, RoutedEventArgs e)
        {
            // this is the check answer event, this event is linked to each button on the canvas
            // when either of the buttons will be pressed we will run this event

            Button senderButton = sender as Button; // first check which button sent this event and link it to a local button inside of this event

            // in the if statement below we will check if the button clicked on has a 1 tag inside of it, if it does then we will add 1 to the score
            if (senderButton.Tag.ToString() == "1")
            {
                score++;
            }

            // if the qnum is less than 0 then we will reset the qnum integer to 0
            if (qNum < 0)
            {
                qNum = 0;
            }
            else
            {
                // if the qnum is greater than 0 then we will add 1 to the qnum integer
                qNum++;
            }

            // update the score text label each time the buttons are pressed
            scoreText.Content = "Answered Correctly " + score + "/" + questionNumbers.Count;

            // run the next question function
            NextQuestion();

        }

        private void RestartGame()
        {
            // restart game function will load all of the default values for this game
            score = 0; // set score to 0
            qNum = -1; // set qnum to -1
            i = 0; // set i to 0
            StartGame(); // run the start game function
        }

        private void NextQuestion()
        {
            // this function will check which question to show next and it will have all of the question and answer definitions

            // in the if statement below it will checking if the qnum integer is less than the total number of questions if it then we will set the value of i to the value of qnum

            if (qNum < questionNumbers.Count)
            {
                i = questionNumbers[qNum];
            }
            else
            {
                // if we have done below the number of questions we have available then we will restart the game
                RestartGame();
            }

            // below we are running a foreach loop where will check for each button inside of the canvas and when we find them we will set their tag to 0 and background to dakr salmon colour
            foreach (var x in myCanvas.Children.OfType<Button>())
            {
                x.Tag = "0";
                x.Background = Brushes.DarkSalmon;
            }


            // below you have all of the question and answers template
            // you can add your own questions to the txtQuestion section
            // and add your own answers inside of the ans1, ans2, ans3 content and so. 


            // this switch statement will check what value is inside of i integer and show the questions based on that value

            switch (i)
            {
                case 1:

                    txtQuestion.Text = "Question 1"; // this the question for the quiz

                    ans1.Content = "Answer 1"; // each of the buttons can have their own answers in this game
                    ans2.Content = "Answer 2 Correct";
                    ans3.Content = "Answer 3";
                    ans4.Content = "Answer 4";

                    ans2.Tag = "1"; // here we tell the program which one of the answers above is the right answer by adding the 1 inside of the tag for the button. 
                    // in this example we adding 1 inside of ans2 or button 2
                    // so when the button is clicked the game will know which is the correct answer and it add 1 to the score for the game

                    qImage.Source = new BitmapImage(new Uri("pack://application:,,,/images/1.jpg")); // here we will load the 1st image inside of the qimage 

                    break; // when this condition is met the program will break the switch statement here and wait for the next one
                    // rest of the condition will follow the same principle as this one

                case 2:

                    txtQuestion.Text = "Question 2";

                    ans1.Content = "Answer 1 Correct";
                    ans2.Content = "Answer 2";
                    ans3.Content = "Answer 3";
                    ans4.Content = "Answer 4";

                    ans1.Tag = "1";

                    qImage.Source = new BitmapImage(new Uri("pack://application:,,,/images/2.jpg"));

                    break;

                case 3:

                    txtQuestion.Text = "Question 3";

                    ans1.Content = "Answer 1";
                    ans2.Content = "Answer 2";
                    ans3.Content = "Answer 3 Correct";
                    ans4.Content = "Answer 4";

                    ans3.Tag = "1";

                    qImage.Source = new BitmapImage(new Uri("pack://application:,,,/images/3.jpg"));

                    break;

                case 4:

                    txtQuestion.Text = "Question 4";

                    ans1.Content = "Answer 1";
                    ans2.Content = "Answer 2";
                    ans3.Content = "Answer 3";
                    ans4.Content = "Answer 4 Correct";

                    ans4.Tag = "1";

                    qImage.Source = new BitmapImage(new Uri("pack://application:,,,/images/4.jpg"));

                    break;

                case 5:

                    txtQuestion.Text = "Question 5";

                    ans1.Content = "Answer 1 Correct";
                    ans2.Content = "Answer 2";
                    ans3.Content = "Answer 3";
                    ans4.Content = "Answer 4";

                    ans1.Tag = "1";

                    qImage.Source = new BitmapImage(new Uri("pack://application:,,,/images/5.jpg"));

                    break;
                case 6:

                    txtQuestion.Text = "Question 6";

                    ans1.Content = "Answer 1";
                    ans2.Content = "Answer 2";
                    ans3.Content = "Answer 3 Correct";
                    ans4.Content = "Answer 4";

                    ans3.Tag = "1";

                    qImage.Source = new BitmapImage(new Uri("pack://application:,,,/images/6.jpg"));

                    break;
                case 7:

                    txtQuestion.Text = "Question 7";

                    ans1.Content = "Answer 1";
                    ans2.Content = "Answer 2 Correct";
                    ans3.Content = "Answer 3";
                    ans4.Content = "Answer 4";

                    ans2.Tag = "1";

                    qImage.Source = new BitmapImage(new Uri("pack://application:,,,/images/7.jpg"));

                    break;
                case 8:

                    txtQuestion.Text = "Question 8";

                    ans1.Content = "Answer 1";
                    ans2.Content = "Answer 2";
                    ans3.Content = "Answer 3";
                    ans4.Content = "Answer 4 Correct";

                    ans4.Tag = "1";

                    qImage.Source = new BitmapImage(new Uri("pack://application:,,,/images/8.jpg"));

                    break;
                case 9:

                    txtQuestion.Text = "Question 9";

                    ans1.Content = "Answer 1";
                    ans2.Content = "Answer 2";
                    ans3.Content = "Answer 3 Correct";
                    ans4.Content = "Answer 4";

                    ans3.Tag = "1";

                    qImage.Source = new BitmapImage(new Uri("pack://application:,,,/images/9.jpg"));

                    break;

                case 10:

                    txtQuestion.Text = "Question 10";

                    ans1.Content = "Answer 1 Correct";
                    ans2.Content = "Answer 2";
                    ans3.Content = "Answer 3";
                    ans4.Content = "Answer 4";

                    ans1.Tag = "1";

                    qImage.Source = new BitmapImage(new Uri("pack://application:,,,/images/10.jpg"));

                    break;
            }
        }

        private void StartGame()
        {
            // this is the start game function
            // inside of this function we will randomise the questions list and save it back into the list 

            // create a new randomlist variable and use the line below to randomise the order of the content
            var randomList = questionNumbers.OrderBy(a => Guid.NewGuid()).ToList();

            // save the random list to the question numbers list again
            questionNumbers = randomList;

            // empty the question order label on the canvas
            questionOrder.Content = null;

            // run a for loop to add the value which will display the randomised list to the display so we can see how the list has been ramdomised
            for (int i = 0; i < questionNumbers.Count; i++)
            {
                questionOrder.Content += " " + questionNumbers[i].ToString();
            }

        }
    }
}
