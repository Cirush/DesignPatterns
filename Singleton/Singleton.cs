public sealed class Singleton 
{
    private static Singleton _instance;
    private static readonly object _lock = new object();
    public string Value {get; set;}

    private Singleton() {}

    public static Singleton GetInstance(string value)
    {
        lock(_lock){
            if(_instance == null)
            {
                _instance = new Singleton();
                _instance.Value = value;
            }
            return _instance;
        }
    }

}