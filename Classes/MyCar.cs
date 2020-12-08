

namespace Classes
{
    public partial class MyCar
    {
        public static MyCar[] myCarList;


        private readonly decimal maxFuel;
        private readonly int maxSpeed;
        private bool brakeLight;
        private decimal fuel;
        private int speed;
        private decimal fuelPercent;
        public decimal Fuel { get { return fuel; } }
        public int Speed { get { return speed; } }
        public bool BrakeLight
        {
            get { return brakeLight; }
            private set { brakeLight = false; }
        }
        public decimal FuelPercent
        {
            get { return (fuel / maxFuel) * 100; }
        }

        public string infoMaxFuelMaxSpeed;
        public string infoWarning;
        public string InfoMaxFuelMaxSpeed
        {
            get { return "maxFuel=" + maxFuel + "\tmaxSpeed" + maxSpeed; ; }

        }
        public string WarningFuel
        {
            get { return fuel < 5 ? "low fuel" : "Fuel " + FuelPercent; }

        }

        static MyCar()
        {
            myCarList = new MyCar[0];
        }

        public MyCar()
        {
            this.maxSpeed = 60;
            this.maxFuel = 10;
            addToMyCarList();
        }
        public MyCar(int maxSpeed, decimal maxFuel)
        {
            this.maxSpeed = maxSpeed;
            this.maxFuel = maxFuel;
            addToMyCarList();
        }

        public MyCar(int maxSpeed, decimal maxFuel, decimal fuel)
        {
            this.maxSpeed = maxSpeed;
            this.maxFuel = maxFuel;
            this.fuel = fuel;
            addToMyCarList();
        }

        private void addToMyCarList()
        {
            MyCar[] tempList = new MyCar[myCarList.Length + 1];
            myCarList.CopyTo(tempList, 0);
            myCarList = tempList;
            myCarList[myCarList.Length - 1] = this;
        }

        public void movement()
        {
            brakeLight = false;
            if (fuel <= 0 & speed > 0)
            {
                speed--;
                return;
            }
            if (speed <= maxSpeed & fuel > 0)
            {
                speed++;
                fuel--;
            }
        }

        public void brakeCar()
        {
            brakeLight = true;
            if (speed == 0) return;
            else speed--;
        }

        public void addFuel()
        {
            if (speed == 0 & fuel < maxFuel / 2)
            {
                while (fuel != maxFuel)
                {
                    fuel++;
                }
            }
            else return;// throw new Exception(" Бак заполнен! ");
        }
        public string myCarInfo()
        {
            string stringMyCar =
                (brakeLight ? " brakeLight \n" : "\n") +
                maxFuel + "  fuel " + fuel + "\n" +
                maxSpeed + " speed " + speed + "\n" +
                 "fuelPercent " + FuelPercent + "\n";
            return stringMyCar;
        }
    }
}
