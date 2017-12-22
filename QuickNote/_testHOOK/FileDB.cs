using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuickNote
{   /// <summary>
    /// Class FileDB to work with file data
    /// </summary>
    public class FileDB
    {
        private string dataPath = Application.StartupPath + @"\DataNote\CurrNote";
        /// <summary>
        /// Singleton design pattern
        /// make sure that only one instance
        /// </summary>
        private static FileDB inst;
        private FileDB() { }
        public static FileDB Inst
        {
            get
            {
                if (inst == null)
                    inst = new FileDB();
                return inst;
            }
        }

        public string DataPath { get => dataPath; set => dataPath = value; }

        public string readFile(string fileName)
        {
            using (FileStream fs = new FileStream(fileName, FileMode.Open))
            {
                using (StreamReader reader = new StreamReader(fs, Encoding.UTF8))
                {
                    return reader.ReadToEnd();
                }
            }
        }

        public void writeFile(string fileName, string text)
        {
            using (FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate))
            {
                using (StreamWriter writer = new StreamWriter(fs, Encoding.UTF8))
                {
                    writer.Write(text);
                }
            }
        }
        public string[] ShowFile(string path)
        {
            if (Directory.Exists(path))
            {
                return ProcessDirectory(path); // nếu file tồn tại
            }
            return null;
        }

       public string[] ProcessDirectory(string pathfile)
        {
            string[] fileList = Directory.GetFiles(pathfile);//lay danh sách file cho vao mảng
            string[] ListFileName = new string[fileList.Length]; //danh sach tên file trong thư mục

            //duyet mang file trong thư mục
            for (int i = 0; i < fileList.Length; i++)
            {
                ListFileName[i] = Path.GetFileName(fileList[i]).Trim();
            }
            return ListFileName;
        }
    }
}
