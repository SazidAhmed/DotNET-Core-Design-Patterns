namespace BuilderPatterns{
    
    interface ICarBuilder{

        public ICarBuilder setMake(string make);
        public ICarBuilder setColor(string color);
        public ICarBuilder setManifactureDate(string dateTime);
    }
}