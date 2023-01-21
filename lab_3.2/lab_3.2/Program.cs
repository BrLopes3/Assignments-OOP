using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_3._2
{
    public struct Person //creation of struct person
    {
        public string first_name;
        public string last_name;
        public sbyte per_age;

    }

    public struct Student //creation of struct student
    {
        public Person st_data;
        public uint stud_id;
        public string college_name;
        public string city_name;
        public string col_address;

    }

    internal class Program
    {

        static void Main(string[] args)
        {
            //creation of objects

            Student[] student = new Student[3];
            int counter = 0;
            int opt = 0;
            for (int i=0; i<student.Length; i++)
            { //menu with options
            
            label0:
                Console.WriteLine("\n-----------------------------------------------------------------------------------------------------------------------\n");
                Console.WriteLine("Enter with the option\n1) Enter with student information\n2) Display the information\n3) quit the application");
                Console.WriteLine("\n-----------------------------------------------------------------------------------------------------------------------\n");
                try
                {
                    opt = int.Parse(Console.ReadLine());
                    Console.WriteLine("\n-----------------------------------------------------------------------------------------------------------------------\n");
                    if (opt < 1 || opt > 3)
                    {
                        Console.WriteLine("Enter with one of the options numers 1, 2 or 3");
                        goto label0;
                    }

                }
                catch (Exception ex0)
                {
                    Console.WriteLine(ex0.Message + "Enter with a valid number from the list");
                    goto label0;
                }

                switch (opt)
                {
                    case 1:
                        {
                            
                            
                                counter++;
                                Console.WriteLine("Enter with information of student:");

                                Console.Write("First Name: ");

                                student[i].st_data.first_name = Console.ReadLine();

                                Console.Write("Last Name: ");

                                student[i].st_data.last_name = Console.ReadLine();

                            label1:
                                Console.Write("Age: ");
                                try
                                {
                                    student[i].st_data.per_age = Convert.ToSByte(Console.ReadLine());
                                    if (student[i].st_data.per_age < 18 || student[i].st_data.per_age > 65)
                                    {
                                        Console.WriteLine("Enter with a valid age (between 18 and 65)");
                                        goto label1;

                                    }
                                }
                                catch (Exception ex3)
                                {
                                    Console.WriteLine(ex3.Message + "Enter with a valid age");
                                    goto label1;
                                }
                            label2: // 
                                Console.Write("Student ID: ");
                                try
                                {
                                    student[i].stud_id = Convert.ToUInt32(Console.ReadLine());

                                }
                                catch (Exception ex4)
                                {
                                    Console.WriteLine(ex4.Message + "Enter with a valid ID");
                                    goto label2;
                                }

                                Console.Write("College Name: ");

                                student[i].college_name = Console.ReadLine();


                                Console.Write("City: ");

                                student[i].city_name = Console.ReadLine();

                                Console.Write("Address: ");

                                student[i].col_address = Console.ReadLine();

                            
                            
                            break;
                        }
                    
                    case 2:
                        {
                            for (i = 0; i < student.Length; i++)
                            {
                                if (student[i].st_data.first_name != null)
                                {
                                    Console.WriteLine("\n-----------------------------------------------------------------------------------------------------------------------\n");
                                    Console.WriteLine($"STUDENT 1: {student[i].st_data.first_name} {student[i].st_data.last_name}, {student[i].st_data.per_age} years old.\nStudent ID: {student[i].stud_id}, study at {student[i].college_name}, City: {student[i].city_name}, Address: {student[i].col_address}");
                                }
                                Console.WriteLine("\n-----------------------------------------------------------------------------------------------------------------------\n");

                            }
                            
                            
                            break;

                        }
                    case 3:
                        {
                            Console.WriteLine("bye bye");
                            break;
                        }
                }

            }

        }
    }
}
