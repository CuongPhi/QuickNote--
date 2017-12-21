using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _testHOOK
{
    public class ANote
    {
        private string titleNote;
        private string textNote;
        private DateTime dayCre;
        private string idNote;
        private List<string> tags;

        public ANote(string id, string title, string text, DateTime dayCre, List<string> tags)
        {
            this.DayCre = dayCre;
            this.IdNote = id;
            this.TitleNote = title;
            this.TextNote = text;
            this.Tags = new List<string>(tags);
        }
 
        public string TitleNote { get => titleNote; set => titleNote = value; }
        public string TextNote { get => textNote; set => textNote = value; }
        public DateTime DayCre { get => dayCre; set => dayCre = value; }
        public List<string> Tags { get => tags; set => tags = value; }
        public string IdNote { get => idNote; set => idNote = value; }
    }
}
