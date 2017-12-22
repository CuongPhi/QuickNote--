using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickNote
{
    public class ANote
    {
        private string titleNote;
        private string textNote;
        private DateTime dayCre;
        private string idNote;
        private List<string> tags;
        private Font font;
        private Color color;
        public ANote(string id, string title, string text, DateTime dayCre, List<string> tags,Color cl, Font font = null )
        {
            this.DayCre = dayCre;
            this.IdNote = id;
            this.TitleNote = title;
            this.TextNote = text;
            this.Tags = new List<string>(tags);
            this.Font = font;
            this.color = cl;
        }
 
        public string TitleNote { get => titleNote; set => titleNote = value; }
        public string TextNote { get => textNote; set => textNote = value; }
        public DateTime DayCre { get => dayCre; set => dayCre = value; }
        public List<string> Tags { get => tags; set => tags = value; }
        public string IdNote { get => idNote; set => idNote = value; }
        public Font Font { get => font; set => font = value; }
        public Color Color { get => color; set => color = value; }
    }
}
