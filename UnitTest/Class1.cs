using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VoiceMananger;
using Xunit;

namespace UnitTest
{
    public class Class1
    {
        [Fact]
        public void SelectMapTest()
        {
            Map map=new Map();
            var actually= map.GetUrlByString("領事館二樓");
            var expect = "https://www.r6maps.com/#consulate/2/all";
            Assert.Equal(expect,actually);
        }
    }
}
