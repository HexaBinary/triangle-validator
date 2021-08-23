using System;

namespace triangle_validator
{
    class Program
    {   
        static int Main(string[] args)
        {
            Console.Title = "Triangle Validator";
            Console.WriteLine("Triangle Validator by HexaBinary (github.com/hexabinary)");

            double edge1, edge2, edge3;
            //The length of the edges of the triangle to validate if it really is a triangle, and declare the type if it is one

            bool isTriangle;
            isTriangle = false;
            //Boolean variable to declare if the given edge values can make a triangle

            uint triangleAngleType, triangleEdgeType;
            triangleAngleType = 0;
            triangleEdgeType = 0;
            //Unsigned Integers to declare the type of triangle according to its angles and edges

            Console.WriteLine("Please enter the length of the first edge of the triangle (no order required)");
            edge1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Second edge...");
            edge2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Third edge...");
            edge3 = Convert.ToDouble(Console.ReadLine());
            //Reading the lengths of the edges from the console application

            ValidateIsTriangle(edge1, edge2, edge3, ref isTriangle);
            DeclareAcuteAngledTriangle(edge1, edge2, edge3,ref triangleAngleType);
            DeclareOptuseAngledTriangle(edge1, edge2, edge3, ref triangleAngleType);
            DeclareRightTriangle(edge1, edge2, edge3, ref triangleAngleType);
            //Running methods to declare the tringle type according to the angles

            DeclareIsoscelesTriangle(edge1, edge2, edge3, ref triangleEdgeType);
            DeclareEquilateralTriangle(edge1, edge2, edge3, ref triangleEdgeType);
            //Running methods to declare the triangle type according to the edges

            if (isTriangle)
            {
                switch (triangleAngleType)
                {
                    case 1:
                        Console.Write("Right ");
                        switch (triangleEdgeType)
                        {
                            case 1:
                                break;
                            case 2:
                                Console.Write("isosceles triangle");
                                break;
                            case 3:
                                Console.Write("equilateral triangle");
                                break;
                        }
                        break;
                    case 2:
                        Console.Write("Acute ");
                        switch (triangleEdgeType)
                        {
                            case 1:
                                break;
                            case 2:
                                Console.Write("isosceles triangle");
                                break;
                            case 3:
                                Console.Write("equilateral triangle");
                                break;
                        }
                        break;
                    case 3:
                        Console.Write("Optuse ");
                        switch (triangleEdgeType)
                        {
                            case 1:
                                break;
                            case 2:
                                Console.Write("isosceles triangle");
                                break;
                            case 3:
                                Console.Write("equilateral triangle");
                                break;
                        }
                        break;
                }
            }
            else Console.WriteLine("not triangle");
            //Outputing the type of the triangle according to its angles and edges

            return 0;
        }

        private static void ValidateIsTriangle(double edge1, double edge2, double edge3, ref bool isTriangle)
        {
            if (edge1 + edge2 > edge3 && edge1 - edge2 < edge3)
            {
                if (edge1 + edge3 > edge2 && edge1 - edge3 < edge2)
                {
                    if (edge2 + edge3 > edge1 && edge2 - edge3 < edge1)
                    {
                        isTriangle = true;
                    }
                }
            }
        }
        //Method to validate that the given values can form a triangle
        private static void DeclareRightTriangle(double edge1, double edge2, double edge3, ref uint triangleAngleType)
        {
            if (Math.Sqrt(Math.Pow(edge1, 2) + Math.Pow(edge2, 2)) == edge3) triangleAngleType = 1;
        }
        //Method to declare if the given values form a right triangle
        private static void DeclareAcuteAngledTriangle(double edge1, double edge2, double edge3, ref uint triangleAngleType)
        {
            if (Math.Sqrt(Math.Pow(edge1, 2) + Math.Pow(edge2, 2)) > edge3)
            {
                triangleAngleType = 2;
            }
            else if (Math.Sqrt(Math.Pow(edge1, 2) + Math.Pow(edge3, 2)) > edge2)
            {
                triangleAngleType = 2;
            }
            else if (Math.Sqrt(Math.Pow(edge2, 2) + Math.Pow(edge3, 2)) > edge1)
            {
                triangleAngleType = 2;
            }
        }
        //Method to declare if the given values form an acute angled triangle
        private static void DeclareOptuseAngledTriangle(double edge1, double edge2, double edge3, ref uint triangleAngleType)
        {
            if (Math.Sqrt(Math.Pow(edge1, 2) + Math.Pow(edge2, 2)) < edge3)
            {
                triangleAngleType = 3;
            }
            else if (Math.Sqrt(Math.Pow(edge1, 2) + Math.Pow(edge3, 2)) < edge2)
            {
                triangleAngleType = 3;
            }
            else if (Math.Sqrt(Math.Pow(edge2, 2) + Math.Pow(edge3, 2)) < edge1)
            {
                triangleAngleType = 3;
            }
        }
        //Method to declare if the given values form an optuse angled triangle
        private static void DeclareIsoscelesTriangle(double edge1, double edge2,double edge3,ref uint triangleEdgeType)
        {
            if (edge1 == edge2) triangleEdgeType = 2;
            else if (edge1 == edge3) triangleEdgeType = 2;
            else if (edge2 == edge3) triangleEdgeType = 2;
            else triangleEdgeType = 1;
        }
        //Method to declare if the given values form an isosceles triangle
        private static void DeclareEquilateralTriangle(double edge1,double edge2,double edge3, ref uint triangleEdgeType)
        {
            if (edge1 == edge2 && edge2 == edge3) triangleEdgeType = 3;
            else if (triangleEdgeType != 2) triangleEdgeType = 1;
        }
        //Method to declare if the given values form an equilateral triangle
    }
}
