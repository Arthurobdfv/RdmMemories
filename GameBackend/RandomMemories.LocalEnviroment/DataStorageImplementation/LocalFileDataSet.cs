using RandomMemories.Contracts.DataStorage;

namespace RandomMemories.LocalImplementation.DataStorageImplementation
{
    internal class LocalFileDataSet<T> : IDataSet<T> where T : class
    {
        private readonly string _fileName;
        private readonly string _fullPath;
        public LocalFileDataSet(string fileName)
        {
            _fileName = fileName;
            _fullPath = Directory.GetCurrentDirectory();
            Console.WriteLine($"fileName :{fileName}, fullPathL{_fullPath}");

        }
        public void Add(T item)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public T GetById(object id)
        {
            throw new NotImplementedException();
        }

        private void LoadFile()
        {
            using (StreamReader r = new StreamReader("file.json"))
            {

            }
        }

    }
}
