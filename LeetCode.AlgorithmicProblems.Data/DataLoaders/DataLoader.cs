using System.Text.Json;

namespace LeetCode.AlgorithmicProblems.Data.DataLoaders
{
    public abstract class DataLoader<T>
    {
        protected string _fileName = string.Empty;

        public List<T> LoadData()
        {
            string? dataDirectory = FindDataDirectory();
            if (dataDirectory == null)
            {
                throw new DirectoryNotFoundException("Папка 'Data' не найдена.");
            }

            string filePath = Path.Combine(dataDirectory, _fileName);
            if (!File.Exists(filePath))
            {
                throw new FileNotFoundException($"Файл '{_fileName}' не найден в папке 'Data'.");
            }

            string json = File.ReadAllText(filePath);
            return JsonSerializer.Deserialize<List<T>>(json) ?? new List<T>();
        }

        protected string? FindDataDirectory()
        {
            string? currentDirectory = Environment.CurrentDirectory;
            while (currentDirectory != null)
            {
                string dataDirectoryPath = Path.Combine(currentDirectory, "LeetCode.AlgorithmicProblems.Data", "Data");
                if (Directory.Exists(dataDirectoryPath))
                {
                    return dataDirectoryPath;
                }
                currentDirectory = Directory.GetParent(currentDirectory)?.FullName;
            }

            return null;
        }
    }
}
