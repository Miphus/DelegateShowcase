namespace DelegatesExcersice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>()
            {
                new Car {Brand = "Volvo", Model = "XC90", YearOfManufacture = 2023, LicenseNumber = "ABC 123"},
                new Car {Brand = "SAAB", Model = "9-5", YearOfManufacture = 1999, LicenseNumber = "SAA 345"},
                new Car {Brand = "Volkswagen", Model = "Golf", YearOfManufacture = 2002, LicenseNumber = "GOL 888"},
                new Car {Brand = "Toyota", Model = "Aygo Hybrid", YearOfManufacture = 2001, LicenseNumber = "TOY 111"},
            };

            cars = cars.OrderBy(c => c.LicenseNumber).ToList();

        }

        static int CompareByBrand(Car a, Car b)
        {
            return string.Compare(a.Brand, b.Brand);
        }

        static int CompareByYearOfManufacture(Car a, Car b)
        {
            if (a.YearOfManufacture < b.YearOfManufacture)
                return -1;
            else
                if (a.YearOfManufacture > b.YearOfManufacture)
                return 1;

                return 0;
        }
    }
}
