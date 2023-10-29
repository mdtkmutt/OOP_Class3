public class Guitar
{
    private string _serialNumber;
    private double _price;

    private GuitarSpec _guitarSpec;


    public Guitar(string serialNumber,
    double price,
    GuitarSpec guitarSpec)
    {
        this._serialNumber = serialNumber;
        this._price = price;
        this._guitarSpec = guitarSpec;
    }

    public string GetSerialNumber()
    {
        return this._serialNumber;
    }

    public double GetPrice()
    {
        return this._price;
    }

    public void SetPrice(double newPrice)
    {
        this._price = newPrice;
    }

    public GuitarSpec GetGuitarSpec()
    {
        return this._guitarSpec;
    }

}