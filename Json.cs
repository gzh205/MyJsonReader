using System.IO;
namespace JosnReaderFramework
{
    public abstract class Json
    {
        public void loadFromFile(string filename)
        {
            StreamReader sr = new StreamReader(new FileStream(filename, FileMode.Open));
            string data = sr.ReadToEnd();
            sr.Close();
            JsonReader reader = new JsonReader();
            JsonTree tree = reader.createTree(data);
            reader.createObject(tree, this);
        }
    }
}
