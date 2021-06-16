using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace project
{
    class Program
    {
        static void Main(string[] args)
        {


            TeachersFile();
        }

        static void TeachersFile()
        {
            string filenm = "Teachers.txt";
            string folder = Directory.GetCurrentDirectory();

            Console.WriteLine("Welcome to Rainbow school system to store, retrieve and update teachers data");

            // taking data from the user
            Console.WriteLine();
            Console.WriteLine("please enter the following information to be saved in your file: ");
            Console.WriteLine();
            Console.WriteLine("your ID: ");
            string TeacherID = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("your name: ");
            string TeacherNM = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("your class: ");
            string TeacherClass = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("your section: ");
            string TeacherSec = Console.ReadLine();
            Console.WriteLine();

            // adding the data took from the user to the file
            using (StreamWriter writer = File.CreateText(filenm))
            {
                writer.WriteLine("the teacher ID: " + TeacherID);
                writer.WriteLine("the teacher name: " + TeacherNM);
                writer.WriteLine("the teacher class: " + TeacherClass);
                writer.WriteLine("the teacher section: " + TeacherSec);

            }


            // users options 
            // I used while loop to keep the system running till the user choose to exit. 
            string closing ="1";
            while ( closing != "0") { 
            Console.WriteLine("what do you want to do with your file?");
            Console.WriteLine("please choose an option: ");
            Console.WriteLine("enter 1 for viewing your file.");
            Console.WriteLine("enter 2 for updating your file.");
            Console.WriteLine("enter 0 to exit.");
            String option = Console.ReadLine();
            Console.WriteLine();
                // if.. else to deal with what the user choose
                if (option == "1")
                {

                    Console.WriteLine("viewing your file:");
                    string txtcontent = File.ReadAllText(filenm);
                    Console.WriteLine(txtcontent);
                    Console.WriteLine();
                    Console.WriteLine("enter 1 to see the main menu or enter 0 to exit");
                    closing = Console.ReadLine();
                    Console.WriteLine();
                }
                else if (option == "2")
                {

                    Console.WriteLine("what do you want to update? (please note you are not allowed to change your ID)");
                    Console.WriteLine("enter 1 for updating your name");
                    Console.WriteLine("enter 2 for updating your class");
                    Console.WriteLine("enter 3 for updating your section");

                   
                    string op = Console.ReadLine();

                   
                    // switch to deal with the update options. 
                    switch (op)
                    {

                        case "1":
                            Console.WriteLine("please enter your new name: ");
                            TeacherNM = Console.ReadLine();
                            string appendtxt1 = ("the teacher name after updating: " + TeacherNM + Environment.NewLine);
                            File.AppendAllText(filenm, appendtxt1);
                            Console.WriteLine();
                            Console.WriteLine("your name has been updating successfully");
                            Console.WriteLine();
                            Console.WriteLine("enter 1 to see the main menu or enter 0 to exit");
                            closing = Console.ReadLine();
                            Console.WriteLine();
                            break;

                        case "2":
                            Console.WriteLine("please enter your new class: ");
                            string newClass = Console.ReadLine();

                            string appendtxt2 = ("the teacher class after updating: " + newClass + Environment.NewLine);
                            File.AppendAllText(filenm, appendtxt2);
                            Console.WriteLine();
                            Console.WriteLine("your class has been updating successfully");
                            Console.WriteLine();
                            Console.WriteLine("enter 1 to see the main menu or enter 0 to exit");
                            closing = Console.ReadLine();
                            Console.WriteLine();
                            break;

                        case "3":
                            Console.WriteLine("please enter your new section: ");
                            string newSection = Console.ReadLine();

                            string appendtxt3 = ("the teacher section after updating: " + newSection + Environment.NewLine);
                            File.AppendAllText(filenm, appendtxt3);
                            Console.WriteLine();
                            Console.WriteLine("your section has been updating successfully");
                            Console.WriteLine();
                            Console.WriteLine("enter 1 to see the main menu or enter 0 to exit");
                            closing = Console.ReadLine();
                            Console.WriteLine();
                            break;
                            default:
                                Console.WriteLine("please choose correctly");
                                Console.WriteLine();
                                continue;
                        }
                }
                

                // closing the system
                else if (option != "1" || option != "2" || option != "0")
                {
                    Console.WriteLine("please choose correctly");
                    Console.WriteLine();
                  
                }

                else
                {
                    Environment.Exit(0);
                }
                }

          
            }

        }



    }


    



