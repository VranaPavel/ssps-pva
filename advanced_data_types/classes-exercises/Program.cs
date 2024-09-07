using System;

namespace ClassesExercises
{
    // first exercise
    public class ClassInformations
    {
        public string name;
        public int numOfStudents;
        public double avgGrade;

        public ClassInformations(string nameArg, int numOfStudentsArg, double avgGardeArg)
        {
            name = nameArg;
            numOfStudents = numOfStudentsArg;
            avgGrade = avgGardeArg;
        }

        public void PrintInformations()
        {
            Console.WriteLine($"Name of class: {name}");
            Console.WriteLine($"Number of students in the class: {numOfStudents}");
            Console.WriteLine($"Average grade: {avgGrade}\n");
        }
    }

    // second exercise
    public class AstrologicalObject
    {
        public double weight;
        public AstrologicalObject(double weightArg)
        {
            weight = weightArg;
        }
    }

    public class Star : AstrologicalObject
    {
        public string name;
        public double diameter;
        public double luminosity;

        public Star(double weightArg, string nameArg, double diameterArg, double luminosityArg) : base(weightArg)
        {
            weight = weightArg;
            name = nameArg;
            diameter = diameterArg;
            luminosity = luminosityArg;
        }
    }

    public class Planet : AstrologicalObject
    {
        public string name;
        public double diameter;
        public string nameOfStar;
        public double distanceFromStar;

        public Planet(double weightArg, string nameArg, double diameterArg, string nameOfStarArg, double distanceFromStarArg) : base(weightArg)
        {
            weight = weightArg;
            name = nameArg;
            diameter = diameterArg;
            nameOfStar = nameOfStarArg;
            distanceFromStar = distanceFromStarArg;
        }

        public void PrintInformations()
        {
            Console.WriteLine($"Weight: {weight}");
            Console.WriteLine($"Name of planet: {name}");
            Console.WriteLine($"Diameter: {diameter}");
            Console.WriteLine($"Name of the star: {nameOfStar}");
            Console.WriteLine($"Distance from the star: {distanceFromStar}\n");
        }
    }

    public class PlanetarySystem
    {
        public string star;
        public PlanetarySystem(string starArg)
        {
            star = starArg;
        }
    }


    // fourth exercise
    public class GeometricalObject
    {
        public double x;
        public double y;

        public GeometricalObject(double xArg, double yArg)
        {
            x = xArg;
            y = yArg;
        }
    }

    public class Circle : GeometricalObject
    {
        public double diameter;

        public Circle(double xArg, double yArg, double diameterArg) : base(xArg, yArg)
        {
            x = xArg;
            y = yArg;
            diameter = diameterArg;
        }
        public double Circumference()
        {
            return Math.PI * 2 * diameter;
        }
        public double Area()
        {
            return Math.PI * diameter * diameter;
        }
        public bool Intersect(Circle circle)
        {
            double distanceBetweenCenters;
            if (x == circle.x)
            {
                distanceBetweenCenters = Math.Abs(y - circle.y);
            }
            else if (y == circle.y)
            {
                distanceBetweenCenters = Math.Abs(x - circle.x);
            }
            else
            {
                double a = Math.Abs(x - circle.x) * Math.Abs(x - circle.x);
                double b = Math.Abs(y - circle.y) * Math.Abs(y - circle.y);
                distanceBetweenCenters = Math.Sqrt(a + b);
            }
            
            if (diameter + circle.diameter < distanceBetweenCenters)
            {
                return false;
            }
            else if (diameter + circle.diameter == distanceBetweenCenters)
            {
                return true;
            }
            else if (diameter - circle.diameter < distanceBetweenCenters && distanceBetweenCenters < diameter + circle.diameter)
            {
                return true;
            }
            else if (diameter - circle.diameter < distanceBetweenCenters)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    public static class Program
    {
        public static void Main()
        {
            // first exercise
            ClassInformations[] arrOfClasses = new ClassInformations[4];
            arrOfClasses[0] = new ClassInformations("1.A", 33, 1.53);
            arrOfClasses[1] = new ClassInformations("1.B", 31, 2.46);
            arrOfClasses[2] = new ClassInformations("1.C", 34, 2.57);
            arrOfClasses[3] = new ClassInformations("1.K", 33, 1.32);
            
            for(int i = 0; i < arrOfClasses.Length; i++)
            {
                if (arrOfClasses[i].avgGrade < 2.5)
                {
                    arrOfClasses[i].PrintInformations();
                }
            } 


            // second exercise
            Star star = new Star(64512, "Sun", 15487, 63215);
            List<Planet> planets = new List<Planet>();
            Planet planet = new Planet(1, "Merkury", 59, "Sun", 1234159674);
            Planet planet2 = new Planet(4, "Venus", 14, "Sun", 123451564);
            Planet planet3 = new Planet(5, "Earth", 2, "Sun", 12344578);
            Planet planet4 = new Planet(8, "Mars", 68, "Sun", 12345);
            Planet planet5 = new Planet(7, "Jupiter", 43, "Sun", 1789);
            Planet planet6 = new Planet(6, "Saturn", 101, "Sun", 1237);
            Planet planet7 = new Planet(0.5, "Uran", 78, "Sun", 130);
            Planet planet8 = new Planet(11, "Neptun", 8, "Sun", 129);
            planets.Add(planet);
            planets.Add(planet2);
            planets.Add(planet3);
            planets.Add(planet4);
            planets.Add(planet5);
            planets.Add(planet6);
            planets.Add(planet7);
            planets.Add(planet8);
            planets = planets.OrderBy(i => i.distanceFromStar).ToList();
            for (int i = 0; i < planets.Count; i++)
            {
                planets[i].PrintInformations();
            }


            // third exercise
            Console.Write("Type \"weight\" to sort by weight or type \"diameter\" to sort by diameter: ");
            bool checkOption = false;
            bool sortByWeight = false;
            do
            {
                string? option = Console.ReadLine();
                if (option == "weight")
                {
                    checkOption = true;
                    sortByWeight = true;
                }
                else if (option == "diameter")
                {
                    checkOption = true;
                }
                else
                {
                    Console.WriteLine("Invalid option");
                }
            } while (checkOption == false);
            
            if (sortByWeight == true)
            {
                for (int i = 1; i < planets.Count; i++)
                {
                    for (int j = 0; j < planets.Count - i; j++)
                    {
                        if (planets[j].weight > planets[j + 1].weight)
                        {
                            Planet swap = planets[j + 1];
                            planets[j + 1] = planets[j];
                            planets[j] = swap;
                        }
                    }
                }
            }
            else
            {
                for (int i = 1; i < planets.Count; i++)
                {
                    for (int j = 0; j < planets.Count - i; j++)
                    {
                        if (planets[j].diameter > planets[j + 1].diameter)
                        {
                            Planet swap = planets[j + 1];
                            planets[j + 1] = planets[j];
                            planets[j] = swap;
                        }
                    }
                }
            }
            for (int i = 0; i < planets.Count; i++)
                planets[i].PrintInformations();

            
            // fourth exercise
            Circle firstCircle = new Circle(1, -1.1, 2.9);
            Circle secondCircle = new Circle(-2, 2, 2.1);
            Console.WriteLine(firstCircle.Circumference());
            Console.WriteLine(firstCircle.Area());
            Console.WriteLine(firstCircle.Intersect(secondCircle));

            List<Circle> listOfCircles = new List<Circle>();
            Circle thirdCircle = new Circle(16, 211.1, 3);
            Circle fourthCircle = new Circle(174, 51.1, 3);
            Circle fifthCircle = new Circle(231, 10.1, 3);
            Circle sixthCircle = new Circle(261, 191.1, 3);
            Circle seventhCircle = new Circle(301, -101.1, 3);
            listOfCircles.Add(thirdCircle);
            listOfCircles.Add(fourthCircle);
            listOfCircles.Add(fifthCircle);
            listOfCircles.Add(sixthCircle);
            listOfCircles.Add(seventhCircle);

            List<double> distances = new List<double>();
            for (int i = 0; i < listOfCircles.Count; i++)
            {
                double xSq = listOfCircles[i].x * listOfCircles[i].x;
                double ySq = listOfCircles[i].y * listOfCircles[i].y;
                double distance = Math.Sqrt(xSq + ySq);
                distances.Add(distance);
            }

            for (int i = 0; i < distances.Count; i++)
            {
                
            }
        }
    }
}
