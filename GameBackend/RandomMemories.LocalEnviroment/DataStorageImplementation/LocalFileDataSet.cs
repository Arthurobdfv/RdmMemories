using Newtonsoft.Json;
using RandomMemories.Contracts.DataStorage;

namespace RandomMemories.LocalImplementation.DataStorageImplementation
{
    internal class LocalFileDataSet<T> : IDataSet<T> where T : class
    {
        private readonly string _fileName;
        private readonly string _folderPath;
        private string FullPath => $@"{_folderPath}\{_fileName}";
        public LocalFileDataSet(string fileName)
        {
            _fileName = $"{fileName}.json";
            _folderPath = $@"{Directory.GetCurrentDirectory()}\LocalDataStorage";
            Console.WriteLine($"fileName :{fileName}, fullPathL{FullPath}");
            if(!Directory.Exists(_folderPath))
                Directory.CreateDirectory(_folderPath);
        }
        public void Add(T item)
        {
            var items = LoadFile();
            var newitems = items.Append(item);
            SaveFile(newitems);
        }

        public IEnumerable<T> GetAll()
        {
            return LoadFile();
        }

        public T GetById(object id)
        {
            throw new NotImplementedException();
        }

        private IEnumerable<T> LoadFile()
        {
            if (!File.Exists(FullPath))
                File.Create(FullPath);
            using (StreamReader r = new StreamReader(FullPath))
            {
                string json = r.ReadToEnd();
                var items = JsonConvert.DeserializeObject<List<T>>(json) ?? new List<T>();
                return items;
            }
        }

        private void SaveFile(IEnumerable<T> itemsToSave)
        {
            var data = JsonConvert.SerializeObject(itemsToSave);
            File.WriteAllText(FullPath, data);
        }

    }
}
