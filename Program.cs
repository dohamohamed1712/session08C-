using Session_08;

namespace session08C_
{
    internal class Program
    {
        static double ReadCoordinate(string message)
        {
            double value;
            bool isValid;

            do
            {
                Console.Write(message);
                isValid = double.TryParse(Console.ReadLine(), out value);

                if (!isValid)
                    Console.WriteLine("Invalid input, please enter a valid number.");
            }
            while (!isValid);

            return value;

            static void Main(string[] args)
            {
                
                #region Q2 - ToString Test
                Point3D P = new Point3D(10, 10, 10);
                Console.WriteLine(P.ToString());
                #endregion

                Console.WriteLine("--------------------------------");

                #region Q3 - Read coordinates for P1, P2 with input validation
                Console.WriteLine("Enter coordinates for Point 1:");
                double x1 = ReadCoordinate("X1: ");
                double y1 = ReadCoordinate("Y1: ");
                double z1 = ReadCoordinate("Z1: ");
                Point3D P1 = new Point3D(x1, y1, z1);

                Console.WriteLine("Enter coordinates for Point 2:");
                double x2 = ReadCoordinate("X2: ");
                double y2 = ReadCoordinate("Y2: ");
                double z2 = ReadCoordinate("Z2: ");
                Point3D P2 = new Point3D(x2, y2, z2);

                Console.WriteLine("P1: " + P1.ToString());
                Console.WriteLine("P2: " + P2.ToString());
                #endregion

                #region Q4 - Testing == operator
                if (P1 == P2)
                    Console.WriteLine("P1 and P2 are equal.");
                else
                    Console.WriteLine("P1 and P2 are NOT equal.");
                #endregion


                #region Q6 - Clone Test
                Point3D original = new Point3D(10, 20, 30);
                Point3D cloned = (Point3D)original.Clone();

                Console.WriteLine("Original: " + original.ToString());
                Console.WriteLine("Cloned: " + cloned.ToString());

                Console.WriteLine("Are they the same object (ReferenceEquals)? " + ReferenceEquals(original, cloned));
                Console.WriteLine("Are their values equal (==)? " + (original == cloned));

                
                cloned.X = 999;
                Console.WriteLine("--------------------------------");
                Console.WriteLine("After modifying cloned.X:");
                Console.WriteLine("Original: " + original.ToString());
                Console.WriteLine("Cloned: " + cloned.ToString());
                #endregion


                #region Maths - Static version
                Console.WriteLine("Add: " + Maths.Add(10, 5));
                Console.WriteLine("Subtract: " + Maths.Subtract(10, 5));
                Console.WriteLine("Multiply: " + Maths.Multiply(10, 5));
                Console.WriteLine("Divide: " + Maths.Divide(10, 5));
                #endregion


                #region Duration Tests
                Duration D1 = new Duration(1, 10, 15);
                Console.WriteLine(D1.ToString());

                Duration D1b = new Duration(3600);
                Console.WriteLine(D1b.ToString());

                Duration D2 = new Duration(7800);
                Console.WriteLine(D2.ToString());

                Duration D3 = new Duration(666);
                Console.WriteLine(D3.ToString());

                Console.WriteLine("--------------------------------");

                // Equals test
                Duration D4 = new Duration(1, 10, 15);
                Console.WriteLine("D1.Equals(D4)? " + D1.Equals(D4)); // True
                Console.WriteLine("D1.GetHashCode() == D4.GetHashCode()? " + (D1.GetHashCode() == D4.GetHashCode())); // True
                #endregion
            }
        }
    }
}
