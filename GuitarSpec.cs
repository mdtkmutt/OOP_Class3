public class GuitarSpec
{
    private string _builder;
    private string _model;
    private string _wood;

    public GuitarSpec(string builder,
    string model,
    string wood)
    {
        this._builder = builder;
        this._model = model;
        this._wood = wood;
    }

    public string GetBuilder()
    {
        return this._builder;
    }

    public string GetWood()
    {
        return this._wood;
    }

    public string GetModel()
    {
        return this._model;
    }
}