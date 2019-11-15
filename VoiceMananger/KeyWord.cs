using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoiceMananger
{
    class KeyWord
    {
        public string Name { get; set; }
        public string[] Words { get; set; }

        public static List<KeyWord> GetMaps()
        {
            return new List<KeyWord>()
            {
                new KeyWord() {Name = "favela", Words = new[] {"貧民窟", "貧民"}},
                new KeyWord() {Name = "consulate", Words = new[] { "領事館", "領事"}},
            };
        }
        public static List<KeyWord> GetFloors()
        {
            return new List<KeyWord>()
            {
                new KeyWord() {Name = "0", Words = new[] { "地下室", "地下"}},
                new KeyWord() {Name = "1", Words = new[] { "一樓", "一","1樓"}},
                new KeyWord() {Name = "2", Words = new[] { "二樓", "二","2樓"}},
            };
        }
    }
}
