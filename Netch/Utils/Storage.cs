using System.IO;
using System.Text;

public class StorageData
{
    /// <summary>
    /// 将序列化的json字符串内容写入Json文件，并且保存
    /// </summary>
    /// <param name="path">路径</param>
    /// <param name="jsonConents">Json内容</param>
    public void WriteJsonFile(string path, string jsonConents)
    {
        using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate, System.IO.FileAccess.ReadWrite, FileShare.ReadWrite))
        {
            using (StreamWriter sw = new StreamWriter(fs, Encoding.UTF8))
            {
                sw.WriteLine(jsonConents);
            }
        }
    }

    /// <summary>
    /// 获取到本地的Json文件并且解析返回对应的json字符串
    /// </summary>
    /// <param name="filepath">文件路径</param>
    /// <returns></returns>
    public string GetJsonFile(string filepath)
    {
        string json = string.Empty;
        using (FileStream fs = new FileStream(filepath, FileMode.OpenOrCreate, System.IO.FileAccess.ReadWrite, FileShare.ReadWrite))
        {
            using (StreamReader sr = new StreamReader(fs, Encoding.UTF8))
            {
                json = sr.ReadToEnd().ToString();
            }
        }
        return json;
    }
}
