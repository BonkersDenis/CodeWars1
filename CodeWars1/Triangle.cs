using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars1
{
    
    public class Triangle 
    {
        private double _sideA;
        private double _sideB;
        private double _sideC;
        public double AngleAB;
        public double AngleBC;
        public double AngleCA;
        public string Name;
        
        public Triangle(string name) {  Name = name; }
        
        public Triangle(double sideA, double sideB, double sideC, double angleAB, double angleBC, double angleCA, string name)
        {
            if (IsCanCreate(sideA, sideB, sideC))
            {
                
                _sideA = sideA;
                _sideB = sideB;
                _sideC = sideC;
                AngleAB = angleAB;
                AngleBC = angleBC;
                AngleCA = angleCA;
                Name = name;
                
            }
            else
            {
                throw new Exception($"Невозможно создать треугольник со сторонами:{sideA}, {sideB}, {sideC}");
            }
        }

       public void SetSides(double sideA, double sideB, double sideC)
        {
            _sideA = sideA;
            _sideB = sideB;
            _sideC = sideC;

        }
        public string Information() 
        {
            return $"side A = {_sideA}\n side B = {_sideB}\n side C = {_sideC}\n Name: {Name} ";
            
        }
        private bool IsCanCreate(double sideA,double sideB,double sideC) 
        {
            return ((sideA + sideB > sideC) && (sideB + sideC > sideA) && (sideC + sideA > sideB));
            
        }
       
        public void Ploshad()
        {



        }



    }
}
