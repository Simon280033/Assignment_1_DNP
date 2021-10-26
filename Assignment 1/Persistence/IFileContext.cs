using System.Collections.Generic;
using Models;

namespace FileData
{
    public interface IFileContext
    {
        public IList<Adult> Adults { get; set; }
        public void SaveChanges();
    }
}