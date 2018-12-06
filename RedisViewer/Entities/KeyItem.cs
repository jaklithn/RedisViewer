using System;
using System.Linq;


namespace RedisViewer.Entities
{
    public class KeyItem
    {
        public string Key { get;  }
        public string Version { get;  }
        public string Name1 { get;  }
        public string Name2 { get;  }
        public string Value { get;  }

        public KeyItem(string key)
        {
            Key = key;
            var sections = key.Split(";".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).ToList();
            switch(sections.Count)
            {
                case 0:
                    throw new ArgumentException("Key has no value");
                case 1:
                    Name1 = sections.First();
                    break;
                case 2:
                    Version = sections.First();
                    Name1 = sections.Skip(1).First();
                    break;
                case 3:
                    Version = sections.First();
                    Name1 = sections.Skip(1).First();
                    Name2 = sections.Skip(2).First();
                    break;
                default:
                    Version = sections.First();
                    Name1 = sections.Skip(1).First();
                    Name2 = sections.Skip(2).First();
                    Value = string.Join(";", sections.Skip(3));
                    break;
            }
        }
    }
}