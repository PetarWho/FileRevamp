using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileRevamp
{
    public class MyFile
    {
        #region Fields

        string _name;
        string _path;
        string _extension;
        DateTime _creationDate;

        #endregion

        #region Properties
        public string Name
        {
            get => _name;
            set
            {
                {
                    if (value.Trim().Length != 0)
                    {
                        _name = value;
                    }
                }
            }
        }
        public string Path
        {
            get => _path;
            set
            {
                {
                    if (value.Trim().Length != 0)
                    {
                        _path = value;
                    }
                }
            }
        }
        public string Extension
        {
            get => _extension;
            set
            {
                {
                    if (value.Trim().Length != 0 && value.Contains('.'))
                    {
                        _extension = value;
                    }
                }
            }
        }
        public DateTime CreationDate
        {
            get => _creationDate;
            set
            {
                {
                    if (value != null)
                    {
                        _creationDate = value;
                    }
                }
            }
        }

        #endregion

        public MyFile()
        {
            this.Name = "Unnamed";
            this.Path = "No Path";
            this.Extension = ".invalidExtension";
            this.CreationDate = DateTime.Now;
        }
        public MyFile(string name, string path) : this()
        {
            this.Name = name;
            this.Path = path;
        }
        public MyFile(string name, string path, string extension) : this(name, path)
        {
            this.Extension = extension;
        }
        public MyFile(string name, string path, string extension, DateTime creationDate) :
            this(name, path, extension)
        {
            this.CreationDate = creationDate;
        }
    }
}
