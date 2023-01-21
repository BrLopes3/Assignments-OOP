using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace lab_3
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

            Student student1 = new Student();
            Student student2 = new Student();
            int opt=0;
            do
            { //menu with options
                label0:
                Console.WriteLine("\n-----------------------------------------------------------------------------------------------------------------------\n");
                Console.WriteLine("Enter with the option\n1) Enter student information of student1\n2) Enter student information of student2\n3) Display the information\n4) quit the application");
                Console.WriteLine("\n-----------------------------------------------------------------------------------------------------------------------\n");
                try
                {
                    opt = int.Parse(Console.ReadLine());
                    Console.WriteLine("\n-----------------------------------------------------------------------------------------------------------------------\n");
                    if (opt<1 || opt > 4)
                    {
                        Console.WriteLine("Enter with one of the options numers 1, 2, 3 or 4");
                        goto label0;
                    }

                }
                catch(Exception ex0)
                {
                    Console.WriteLine(ex0.Message+"Enter with a valid number from the list");
                    goto label0;
                }
                
                switch (opt)
                {
                    case 1:
                        {
                            
                            Console.WriteLine("Enter with information of student 1:");
                      
                            Console.Write("First Name: ");
                            
                                student1.st_data.first_name = Console.ReadLine();                           
                    
                            Console.Write("Last Name: ");
                                      
                                student1.st_data.last_name = Console.ReadLine();
                        
                        label1:
                            Console.Write("Age: ");
                            try
                            {
                                student1.st_data.per_age = Convert.ToSByte(Console.ReadLine());
                                if(student1.st_data.per_age < 18 || student1.st_data.per_age > 65)
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
                                student1.stud_id = Convert.ToUInt32(Console.ReadLine());
                               
                            }
                            catch (Exception ex4)
                            {
                                Console.WriteLine(ex4.Message + "Enter with a valid ID");
                                goto label2;
                            }
                        
                            Console.Write("College Name: ");
                           
                                student1.college_name = Console.ReadLine();

                        
                            Console.Write("City: ");
                            
                                student1.city_name = Console.ReadLine();
 
                            Console.Write("Address: ");

                            student1.col_address = Console.ReadLine();
                            break;                   
                        }
                    case 2:
                        {


                            Console.WriteLine("Enter with information of student 2:");

                            Console.Write("First Name: ");

                            student2.st_data.first_name = Console.ReadLine();

                            Console.Write("Last Name: ");

                            student2.st_data.last_name = Console.ReadLine();

                        label3:
                            Console.Write("Age: ");
                            try
                            {
                                student2.st_data.per_age = Convert.ToSByte(Console.ReadLine());
                                if (student2.st_data.per_age < 18 || student2.st_data.per_age > 65)
                                {
                                    Console.WriteLine("Enter with a valid age (between 18 and 65)");
                                    goto label3;

                                }
                            }
                            catch (Exception ex3)
                            {
                                Console.WriteLine(ex3.Message + "Enter with a valid age");
                                goto label3;
                            }
                        label4: // 
                            Console.Write("Student ID: ");
                            try
                            {
                                student2.stud_id = Convert.ToUInt32(Console.ReadLine());

                            }
                            catch (Exception ex4)
                            {
                                Console.WriteLine(ex4.Message + "Enter with a valid ID");
                                goto label4;
                            }

                            Console.Write("College Name: ");

                            student2.college_name = Console.ReadLine();


                            Console.Write("City: ");

                            student2.city_name = Console.ReadLine();

                            Console.Write("Address: ");

                            student2.col_address = Console.ReadLine();
                           

                            break;
                            
                        }
                    case 3:
                        {
                            if (student1.st_data.first_name != null)
                            {
                                Console.WriteLine("\n-----------------------------------------------------------------------------------------------------------------------\n");
                                Console.WriteLine($"STUDENT 1: {student1.st_data.first_name} {student1.st_data.last_name}, {student1.st_data.per_age} years old.\nStudent ID: {student1.stud_id}, study at {student1.college_name}, City: {student1.city_name}, Address: {student1.col_address}");
                            }
                            Console.WriteLine("\n-----------------------------------------------------------------------------------------------------------------------\n");
                            if (student2.st_data.first_name != null)
                            {
                                Console.WriteLine($"STUDENT 2: {student2.st_data.first_name} {student2.st_data.last_name}, {student2.st_data.per_age} years old.\nStudent ID: {student2.stud_id}, study at {student2.college_name}, City: {student2.city_name}, Address: {student2.col_address}");
                                Console.WriteLine("\n-----------------------------------------------------------------------------------------------------------------------\n");
                            }
                            break;
                            
                        }
                    case 4:
                        {
                            Console.WriteLine("bye bye");
                            break;
                        }
                }

            } while(opt != 4);

        }
    }
}
