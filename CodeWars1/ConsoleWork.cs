using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CodeWars1
{
   public class ConsoleWork
    {
       public List<Triangle> TrianglesList;
       public Triangle SelectedTriangel;
        

        public ConsoleWork() 
        {
            TrianglesList = new List<Triangle>();
            Console.WriteLine("1-треугольник\n 2- добавить вершины в треугольник\n 3- вывести все триугольники ");
            string  number = Console.ReadLine();
            if (number == "1")
            {
                AddTriangel();
                
            }
            if (number == "2")
            {
                AddSide();
                
            }
            if (number == "3")
            {
                ListTriangel();
            }
           
            
        }
        public void AddTriangel()
        {

            Console.WriteLine("Введите Имя");
            var triangel = new Triangle("");
            triangel.Name = Console.ReadLine();
            TrianglesList.Add(triangel);
            
            
        }
        public void AddSide()
        {

            ChooseTriangle();
            Console.WriteLine("Добавить сторону ");
            double sideA = double.Parse(Console.ReadLine());
            Console.WriteLine("Добавить сторону ");
            double sideB = double.Parse (Console.ReadLine());
            Console.WriteLine("Добавить сторону ");
            double sideC = double.Parse(Console.ReadLine());
            SelectedTriangel.SetSides(sideA, sideB, sideC);
  

        }
        public void AddAngel()
        {
            Console.WriteLine("Введите угол");
           
        }
        public void ListTriangel()
        {
            var list = new List<Triangle>();
            foreach(var triangel in list)
            {


                Console.WriteLine($"{triangel.Name}");
            }
        }
        public void ChooseTriangle()
        {
            var list = new List<Triangle>();
            foreach (Triangle triangel in list)
            {
                if (triangel.Name == Console.ReadLine()) 
                 { Console.WriteLine(triangel.Name);
                    SelectedTriangel = triangel;

                }
            
            }



        }
    }
}
