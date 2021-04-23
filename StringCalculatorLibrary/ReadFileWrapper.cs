using System.IO;

namespace StringCalculatorLibrary
{
    public class ReadFileWrapper : IReadFile
    {


        public string ReadLine(string fileName)
        {
            //StreamReader reader = new StreamReader("c:\\data\\" + fileName);
            string readData = null;
            StreamReader reader = new StreamReader(fileName);
            try
            {
                do
                {
                    readData = reader.ReadLine().ToString();
                    return readData;
                }
                while (reader.Peek() != -1);
            }
            catch
            {
                return "-1";
            }
            finally
            {
                reader.Close();
            }

        }
    }
}
