namespace KeyedDI
{
    public class CloudStorageService : IStorage
    {
        public void StoreData(string data)
        {
            Console.WriteLine("data stored in cloud " + data);
        }
    }
}
