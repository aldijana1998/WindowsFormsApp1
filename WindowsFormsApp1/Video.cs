using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Video
    {
        public string Title { get; set; }

        public string Author { get; set; }

        public string Url { get; set; }

        public BadImageFormatException Thumbnail { get; set; }

    }
}