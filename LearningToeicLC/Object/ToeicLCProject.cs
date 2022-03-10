using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningToeicLC.Object
{
    internal class ToeicLCProject
    {
        public ToeicLCProject()
        {
            SessionItems = new List<Session>();
        }
        public string AudioMp3FilePath { get; set; }
        public List<Session> SessionItems { get; set; }
    }
}
