public class Inventory
{
    private Guitar[] _guitars;

    public Inventory(Guitar[] guitars)
    {
        this._guitars = guitars;
    }


    // Function Overlading
    public Guitar GetGuitar(string serialNumber)
    {
        foreach (Guitar guitar in this._guitars)
        {
            if (guitar.GetSerialNumber().Equals(serialNumber))
            {
                return guitar;
            }
        }

        return null;
    }

    public Guitar GetGuitar(double price)
    {
        foreach (Guitar guitar in this._guitars)
        {
            if (guitar.GetPrice().Equals(price))
            {
                return guitar;
            }
        }

        return null;
    }

    public Guitar Search(Guitar searchGuitar)
    {
        foreach (Guitar guitar in this._guitars)
        {
            string serialNumber = searchGuitar.GetSerialNumber();
            double price = searchGuitar.GetPrice();

            if (guitar.GetSerialNumber().Equals(serialNumber) &&
               guitar.GetPrice().Equals(price))
            {
                return guitar;
            }
        }
        return null;
    }
}