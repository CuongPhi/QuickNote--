using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _testHOOK
{
    public class TagNote
    {
        // Name of tag
        private string tag;
        // Appearance frequency
        private int nAppFre;
        public TagNote(string tag, int n)
        {
            this.NAppFre = n;
            this.Tag = tag;
        }
        public TagNote()
        {
            this.NAppFre = 0;
            this.Tag = "";
        }
        public string Tag { get => tag; set => tag = value; }
        public int NAppFre { get => nAppFre; set => nAppFre = value; }
    }
}
