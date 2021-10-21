using System;
using System.Collections.Generic;


namespace QuizieGame
{
    class Quizie: Question
    {
         
  
        private enum Chance { Continue, GAME, LAME }
        public static string MyLowerCaseMethod(ref string userAnswer)
        {

            userAnswer = string.Format(userAnswer.ToLower());
            return userAnswer;

        }
        
        public static void Main()
        {
            
            int counter =0;
            Question[] ques = new Question[31];
            ques[1] = new Question
            {
                Ques = "Which word in the dictionary is spelled incorrectly?",
                Ans = "incorrectly"
            };
            ques[2] = new Question
            {
                Ques = "The study of beautiful handwriting is called?",
                Ans = "calligraphy"
            };
            ques[3] = new Question
            {
                Ques = "The fear of confined spaces is called?",
                Ans = "claustrophobia"
            };
            ques[4] = new Question
            {
                Ques = "How many STRIPES are on US flag ",
                Ans = "13 STRIPES including 50 stars"
            };
            ques[5] = new Question
            {
                Ques = "The capital of italy is?",
                Ans = "rome"
            };
            ques[6] = new Question
            {
                Ques = "How many countries participated in the first world cup tournament?",
                Ans = "13"
            };
            ques[7] = new Question
            {
                Ques = "Someone who sleep walks is known as?",
                Ans = "somnabulist"
            };
            ques[8] = new Question
            {
                Ques = "What can travel around the world which stay in a corner?",
                Ans = "a stamp"
            };
            ques[9] = new Question
            {
                Ques = "What flies without wings?",
                Ans = "time"
            };
            ques[10] = new Question
            {
                Ques = "Fear of ghost is called?",
                Ans = "phasmophobia"
            };
            ques[11] = new Question
            {
                Ques = "The most populous city in the world is?",
                Ans = "tokyo"
            };
            ques[12] = new Question
            {
                Ques = "A score is what?",
                Ans = "20"
            };
            ques[13] = new Question
            {
                Ques = "The only country with no armed forces is known as",
                Ans = "iceand"
            };
            ques[14] = new Question
            {
                Ques = "The capital of Rwanda is ?",
                Ans = "kigali"
            };
            ques[15] = new Question
            {
                Ques = "African was partitioned in what year?",
                Ans = "1885"
            };
            try
            {
                Console.WriteLine("\t\t\tWELCOME TO QUIZIE GAME!\nThis is a brain teaser game where you'll be jeered up and " +
                    "updated mentally and generally about the World's affrairs-Don't be an old fellow! We're here to challenge you with puzzle questions.");
                Console.Write("\nPick and Enter a number from 1-15: ");
                int numberEntry = int.Parse(Console.ReadLine());
                do
                {
                    if (numberEntry >= ques.Length)
                    {
                        throw new ArgumentOutOfRangeException(nameof(ques.Length),"The digit entered is out of the range");
                        
                    }
                    else
                    {
                        Console.WriteLine("The digit is not up to the alloted numbers");
                    }
                    Console.WriteLine((ques[numberEntry].Ques));
                    string userAnswer = Convert.ToString(Console.ReadLine());
                    string userAnswerToLower = MyLowerCaseMethod(ref userAnswer);
                    if (numberEntry is var Confirm)
                    {
                        if (userAnswerToLower.Equals(ques[Confirm].Ans))
                        {
                            Console.WriteLine($"\nWHOOPEE, VERY APT! YOU GOT IT CORRECTLY. \nIt is a {Chance.GAME} for you.");
                            break;
                        }
                        if (Confirm is var Bonus)
                        {
                         if (userAnswerToLower!= ques[Bonus].Ans)
                            {
                                Console.WriteLine($"GROSSLY INCORRECT! \nYOU ARE GIVEN ANOTHER CHANCE TO RETAKE THE LATTER QUESTION\n \n{ques[Bonus].Ques}");
                                userAnswerToLower = Console.ReadLine();

                                if (userAnswerToLower == ques[Bonus].Ans)
                                {
                                    Console.WriteLine($"\nVERY GOOD! YOU LATER CHANCED IT! \nIt's a {Chance.GAME} for you.");
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine($"\nOops,THE GAME IS OVER! YOU GOT IT WRONG.\nTHE PROVIDED ANSWER IS: {ques[Bonus].Ans}");
                                    break;
                                }
                            }
                        }
                    }
                } while (counter <= 2);
            }
            catch( FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            catch(IndexOutOfRangeException ex) 
            {
                throw new ArgumentOutOfRangeException(
                "Parameter index is out of range.", ex);
            }
            finally { }
        } 
       
    }

    public class Question
    { 
        public string Ques { get; set; }
        public string Ans { get; set; } 

        
    }




















}


