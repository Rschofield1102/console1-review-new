namespace FirstConsoleApplication
{
    //write a program to find area of tiangle, rectangle, circle, square

interface Area
    {
        void Area(double w, double h);

    }
    class CircleArea : Area
    {
public void Area(double w, double h)
        {
            Console.WriteLine("Area of Circle {0}", 3.14 * w * w);

        }


    class RectangleArea : Area
     {
public void Area( double h, double w)
            {
                Console.WriteLine(" Area of Rectangle {0}",h*w);
            }
        }
    class TriangleArea : Area
        {
public void Area( double h, double w)
            {

                Console.WriteLine(" Area of Triangle {0}", (h*w) /2);
            }
        }
        class Assignment
        {
            static void Main(string[] arg)
            {

                int ch;
                Console.WriteLine("1.Triangle");
                Console.WriteLine("2.Circle");
                Console.WriteLine("3.Square");
                Console.WriteLine("4.Rectangle");
                Console.WriteLine("5.Enter Answer");
                ch = Convert.ToInt32(Console.ReadLine());
                if (ch == 1)
                {
                    double w, h;
                    RectangleArea r = new RectangleArea();
                    Console.WriteLine("Enter Width");
                    w = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Enter Height");
                    h = Convert.ToDouble(Console.ReadLine());
                    r.Area(w, h);
                }
                else if (ch == 2)
                {
                    double b, h;
                    TriangleArea t = new TriangleArea();
                    Console.WriteLine("Enter Base");
                    b = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Enter Height");
                    h = Convert.ToDouble(Console.ReadLine());
                    t.Area(b, h);
                }
                else if (ch == 3)
                {
                    double r;

                    CircleArea c = new CircleArea();
                    Console.WriteLine("Enter Radius");
                    r = Convert.ToDouble(Console.ReadLine());
                    c.Area(r, r);
                }
                else
                {
                    Console.WriteLine("Invalid Choice");
                }
                Console.ReadLine();

                }
            }
         
        }

    }
