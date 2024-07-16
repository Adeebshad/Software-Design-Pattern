namespace Builder
{
    public class Director
    {
        private IBuilder _builder;

        public IBuilder Builder
        {
            set { _builder = value; }
        }

        // The Director can construct several product variations using the same
        // building steps.
        public void BuildMinimalViableProduct()
        {
            //this._builder.BuildPartA();
            _builder.Engine();
            _builder.Transmission();
            _builder.Alternator();
            _builder.Battery();
            _builder.Radiator();
        }
        public void BuildMiddlePerformanceProduct()
        {
            _builder.Engine180();
            _builder.Transmission180();
            _builder.Alternator180();
            _builder.Battery180();
            _builder.Radiator180();
            
        }
        public void BuildFullFeaturedProduct()
        {
            _builder.Engine360();
            _builder.Transmission360();
            _builder.Alternator360();
            _builder.Battery360();
            _builder.Radiator();
        }
    }
}
