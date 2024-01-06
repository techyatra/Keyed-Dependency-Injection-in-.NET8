namespace KeyedDI
{
    public class LocalStorageService : IStorage
    {
        public void StoreData(string data)
        {
            Console.WriteLine("data stored locally " +  data);
        }
    }
}
