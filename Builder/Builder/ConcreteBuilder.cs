namespace Builder
{
    public class ConcreteBuilder : IBuilder
    {
        private Product _product = new Product();
        public ConcreteBuilder()
        {
            this.Reset();
        }

        public void Reset()
        {
            this._product = new Product();
        }

        // All production steps work with the same product instance.

        public Product GetProduct()
        {
            Product result = this._product;
            this.Reset();
            return result;
        }

        public void Engine()
        {
            this._product.Add("Basic Engine");
        }

        public void Transmission()
        {
            this._product.Add("Basic Transmission");
        }

        public void Battery()
        {
            this._product.Add("Basic Battery");
        }

        public void Alternator()
        {
            this._product.Add("Basic Alternator");
        }

        public void Radiator()
        {
            this._product.Add("Basic Radiator");
        }

        public void Engine180()
        {
            this._product.Add("Basic Engine180");
        }

        public void Transmission180()
        {
            this._product.Add("Basic Transmission180");
        }

        public void Battery180()
        {
            this._product.Add("Basic Battery180");
        }

        public void Alternator180()
        {
            this._product.Add("Basic Alternator180");
        }

        public void Radiator180()
        {
            this._product.Add("Basic Radiator180");
        }

        public void Engine360()
        {
            this._product.Add("Basic Engine360");
        }

        public void Transmission360()
        {
            this._product.Add("Basic Transmission360");
        }

        public void Battery360()
        {
            this._product.Add("Basic Battery360");
        }

        public void Alternator360()
        {
            this._product.Add("Basic Alternator360");
        }

        public void Radiator360()
        {
            this._product.Add("Basic Radiator360");
        }

        public void EngineSpecial()
        {
            this._product.Add("Basic EngineSpecial");
        }

        public void TransmissionSpecial()
        {
            this._product.Add("Basic TransmissionSpecial");
        }

        public void BatterySpecial()
        {
            this._product.Add("Basic BatterySpecial");
        }

        public void AlternatorSpecial()
        {
            this._product.Add("Basic AlternatorSpecial");
        }

        public void RadiatorSpecial()
        {
            this._product.Add("Basic RadiatorSpecial");
        }
    }
}
