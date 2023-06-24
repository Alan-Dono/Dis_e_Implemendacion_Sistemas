using System;
using CrearAnimales.Helpers;
using EntitiesLayer.Interfaces;


namespace EntitiesLayer.ConcretClass
{
    public class Animal : IAnimal, IFood, IEnergy, IPositionable
    {
        #region Attributes
        private static int _contadorId = 0;
        private int _id; // ID automatico a cada animal idependientemente de que tipo sean
        private string _especie;
        private int _energy = 100;
        private int _positionX = 0;
        private int _positionY = 0;
        private int _positionZ = 0;
        private int _age;
        private int _weight;
        private IDiet _diet;
        private IEnviroment _enviroment;


        #endregion

        #region Properties
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Especie
        {
            get { return _especie; }
            set { _especie = value; }
        }

        public int Energy
        {
            get { return _energy; }
            set { _energy = value; }
        }

        public int PositionX
        {
            get { return _positionX; }
            set { _positionX = value; }
        }

        public int PositionY
        {
            get { return _positionY; }
            set { _positionY = value; }
        }
        public int PositionZ
        {
            get { return _positionZ; }
            set { _positionZ = value; }
        }

        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }

        public int Weight
        {
            get { return _weight; }
            set { _weight = value; }
        }

        public IDiet Diet
        {
            get { return _diet; }
            set { _diet = value; }
        }
        public IEnviroment Enviroment
        {
            get { return _enviroment; }
            set { _enviroment = value; }
        }
        #endregion

        #region Builders
        public Animal() { }
        public Animal(string especie, int age, int weigth, IDiet dieta)
        {
            _contadorId++;
            _id = _contadorId;
            _especie = especie;
            _age = age;
            _weight = weigth;
            _diet = dieta;
        }
        #endregion

        #region IAnimalRegion
        void IAnimal.Feed(IFood food)
        {
            if (_diet.canEat(food))
            {       // Pruebas Piloto
                Console.WriteLine("La energia del animal antes de comer es: " + Energy);
                Console.WriteLine("El animal esta comiendo " + food.GetName());
                SetEnergyPlus(food.getCalories());
                Console.WriteLine("La energia del animal despues de comer es: " + Energy);
            }
            else
            {       // Pruebas Piloto
                Console.WriteLine("La energia del animal antes de comer es: " + Energy);
                Console.WriteLine("El animal no puede comer " + food.GetName());
                Console.WriteLine("El animal pierde 10 de energia por cazar en vano");
                SetEnergyLess(10);
                Console.WriteLine("La energia del animal despues cazar en vano es: " + Energy);

            }
        }
        public void Move()
        {
            // Pruebas Piloto, moverse gasta 30 de energia, cazar un alimento que no puede comer gasta 10 de energia
            if (Energy >= 30)
            {
                Console.WriteLine("La posision del animal antes de moverse es: " + "X: " + PositionX + "  Y: " + PositionY);
                Console.WriteLine("La energia del animal antes de moverse es: " + Energy);
                setPositionX(NumberRandomGenerate.GenerateRandomNumber(0, 1000));
                setPositionY(NumberRandomGenerate.GenerateRandomNumber(0, 1000));
                SetEnergyLess(30);
                Console.WriteLine("La posision del animal despues de moverse es: " + "X: " + PositionX + "  Y: " + PositionY);
                Console.WriteLine("La energia del animal despues de moverse es: " + Energy);
            }
            else if (Energy < 30 && Energy >= 10)
            {
                Console.WriteLine("El animal notiene energia para moverse... nesecita cazar para alimentarce o dormir");
                Console.WriteLine("La energia del animal es de: " + Energy);
            }
            else
            {
                Console.WriteLine("El animal no tiene energia para moverse o cazar. Nesecita dormir ya o morira!!!");
            }
        }

        public void Sleep()
        {
            // Pruebas piloto
            Console.WriteLine("La energia del animal antes de dormir es: " + Energy);
            Console.WriteLine("El animal esta durmiendo");
            SetEnergyPlus(50);
            Console.WriteLine("La energia del animal despues de dormir es: " + Energy);
        }
        #endregion

        #region IEnergyRegion
        public int GetEnergy()
        {
            return Energy;
        }

        public void SetEnergyPlus(int energy)
        {
            Energy += energy;
            if (Energy >= 100)
            {
                Energy = 100;
            }
        }

        public void SetEnergyLess(int energy)
        {
            Energy -= energy;
            if (Energy <= 0)
            {
                Energy = 0;
            }
        }
        #endregion

        #region IPositionableRegion
        public int getPositionX()
        {
            return PositionX;
        }

        public int getPositionY()
        {
            return PositionY;
        }

        public int getPositionZ()
        {
            return PositionZ;
        }

        public void setPositionX(int x)
        {
            _positionX = PositionX;
        }

        public void setPositionY(int y)
        {
            _positionY = PositionY;
        }

        public void setPositionZ(int z)
        {
            _positionZ = PositionZ;
        }
        #endregion

        #region IFoodRegion
        public string GetName()
        {
            return Especie;
        }
        public new IFood GetType()
        {
            return this;
        }

        public int getCalories()
        {
            return Energy;
        }
        #endregion

    }

}

