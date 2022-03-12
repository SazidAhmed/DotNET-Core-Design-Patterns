namespace BuilderPatterns{
    class CarBuilder : ICarBuilder{

        private Car _car = new Car();

        public ICarBuilder setMake(string make){
            _car.Make = make;
            return this;
        }

        public ICarBuilder setColor(string color){
            _car.Make = color;
            return this;
        }

        public ICarBuilder setManifactureDate(string dateTime){
            _car.ManifactureDate = dateTime;
            return this;
        }

        public Car Build() => _car;
    }
}