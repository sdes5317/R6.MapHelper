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
                new KeyWord() {Name = "consulate", Words = new[] { "領事館", "領事","大使館"}},
                new KeyWord() {Name = "club", Words = new[] { "俱樂部會所", "俱樂部","會所"}},
                new KeyWord() {Name = "tower", Words = new[] { "摩天大樓", "大樓","塔樓"}},
                new KeyWord() {Name = "oregon", Words = new[] { "奧勒岡鄉間屋宅", "奧勒岡", "奧勒岡鄉間民宅"}},
                new KeyWord() {Name = "plane", Words = new[] { "總統專機", "飛機"}},
                new KeyWord() {Name = "chalet", Words = new[] { "木屋"}},
                new KeyWord() {Name = "coastline", Words = new[] { "海岸線", "泳池"}},
                new KeyWord() {Name = "house", Words = new[] { "芝加哥豪宅","豪宅"}},
                new KeyWord() {Name = "border", Words = new[] { "邊境"}},
                new KeyWord() {Name = "bank", Words = new[] { "銀行"}},
                new KeyWord() {Name = "bartlett", Words = new[] { "巴雷特大學","大學"}},
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
