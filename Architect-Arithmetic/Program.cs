namespace Architect_Arithmetic
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            CalculateTotalCost();
        }
        static double Rectangle(double length, double width)
        {
            //calculate rectangle area
            double area1 = length * width;
            Console.WriteLine(area1);
            return length * width;
        }
        static double Circle(double radius)
        {
            //calculate circle area
            double area2 = Math.PI * (Math.Pow(radius, 2));
            Console.WriteLine(area2);
            return Math.PI * (Math.Pow(radius, 2));
        }
        static double Triangle(double bottom, double height)
        {
            //calculate triangle area
            double area3 = 0.5 * bottom * height;
            Console.WriteLine(area3);
            return 0.5 * bottom * height;
        }
        static double TotalArea(double rectHeight, double rectLength, double circRadius, double triBottom, double triHeight)
        { 
            //calculate total are of teotihuacan
            double areaRect = rectHeight * rectLength;
            double areaCirc = Math.PI * (Math.Pow(circRadius, 2));
            double areaTri = 0.5 * triBottom * triHeight;
            double area = areaRect + areaTri + (areaCirc / 2);
            Console.WriteLine($"The total are is: {area}");
            double totalCost = Math.Round((area * 180), 2);
            Console.WriteLine($"The cost of the floor material is {totalCost}.\nThis is calculated by getting the area and multiplying it by the cost of the material");
            return area;
        }
        static void CalculateTotalCost()
        {
            Console.WriteLine("What monument would you like to work with?");
            Console.WriteLine("A) Taj Mahal \nB) Great Moscque \nC) Teotihuacan");
            string userChoice = Console.ReadLine();
            string monument = userChoice.ToUpper();
            double monumentArea;
            double totalCost;

            switch(monument)
            {
                //Taj Mahal total area floor cost
                case "A":
                    double tajTri = (0.5 * 24 * 24) * 3;
                    double tajRect = (90.5 * 90.5) - tajTri;
                    monumentArea = tajTri + tajRect;
                    totalCost = Math.Round((monumentArea * 180), 2);
                    Console.WriteLine($"The total cost for the monument will be {totalCost} pesos.");                    
                    break;
                
                case "B":
                    double meccaTri = 0.5 * 265 * 84;
                    double meccaRect1 = 180 * 106;
                    double meccaRect2 = (284 * 264) - meccaTri;
                    monumentArea = meccaRect1 + meccaRect2;
                    totalCost = Math.Round((monumentArea * 180), 2);
                    Console.WriteLine($"The total cost for the monument will be {totalCost} pesos.");
                    break;
                
                case "C":
                    double teoRect = 2500 * 1500;
                    double teoCirc = Math.PI * (Math.Pow(375, 2));
                    double teoTri = 0.5 * 750 * 500;
                    monumentArea = teoRect + teoTri + (teoCirc / 2);
                    totalCost = Math.Round((monumentArea * 180), 2);
                    Console.WriteLine($"The total cost for the monument will be {totalCost} pesos.");
                    break;
                
                default:
                break;
            }
        }
    }
}
