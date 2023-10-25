namespace WoodPelletLib
{
    public class WoodPellet
    {
        public int Id { get; set; }

        public int Price { get; set; }
        public int Qaulity { get; set; }

        private string _brand;
        public string Brand {
            get
            {
                return _brand;
            }
            set
            {
                if (value.Length <= 2)
                {
                    _brand = value;
                
                }
                else
                {
                    throw new ArgumentException("Der skal minimum være 2 karektere");

                }
                if (_brand != null)
                {
                    _brand = value;

                }
                else
                {
                    throw new ArgumentException("Der skal være 2 karrektere");
                }

            }

        }

        public WoodPellet(int id, int price, int qaulity, string brand)
        {
            Id = id;
            Price = price;
            Qaulity = qaulity;
            Brand = brand;
        }

        public WoodPellet()
        {
        }

        public override string ToString()
        {
            return $"{{{nameof(Id)}={Id.ToString()}, {nameof(Price)}={Price.ToString()}, {nameof(Qaulity)}={Qaulity.ToString()}, {nameof(Brand)}={Brand}}}";
        }
    }
}