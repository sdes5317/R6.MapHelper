using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoiceMananger
{
    public class Map
    {
        public string Name { get; set; } = "consulate";
        public string Floor { get; set; } = "1";

        //https://www.r6maps.com/#favela/2/all
        private string[] _urls = { "https://www.r6maps.com/#", "", "/", "", "/all" };

        private readonly Dictionary<string, string> _map;

        private readonly Dictionary<string, string> _floor;

        private static List<KeyWord> _mapWords;

        private static List<KeyWord> _floorWords;

        public Map()
        {
            _mapWords = KeyWord.GetMaps();
            _floorWords = KeyWord.GetFloors();

            _map = GetMaps();
            _floor = GetFloors();
        }
        public string GetUrlByString(string whatYouSay)
        {
            Name = SelectMap(whatYouSay)?? Name;
            Floor = SelectFloor(whatYouSay)?? Floor;

            _urls[1] = Name;
            _urls[3] = Floor;

            return string.Join("", _urls);
        }

        private Dictionary<string, string> GetMaps()
        {
            return GetDic(_mapWords);
        }

        private Dictionary<string, string> GetFloors()
        {
            return GetDic(_floorWords);
        }

        private Dictionary<string, string> GetDic(List<KeyWord> means)
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();
            foreach (var m in means)
            {
                foreach (var word in m.Words)
                {
                    dic.Add(word, m.Name);
                }
            }

            return dic;
        }

        private string SelectMap(string whatYouSay)
        {
            return Select(_map, whatYouSay);
        }

        private string SelectFloor(string whatYouSay)
        {
            return Select(_floor, whatYouSay);
        }

        private string Select(Dictionary<string, string> words, string whatYouSay)
        {
            foreach (var map in words)
            {
                if (whatYouSay.Contains(map.Key))
                {
                    return map.Value;
                }
            }

            return null;
        }
    }
}
