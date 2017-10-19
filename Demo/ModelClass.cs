using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    public class ModelClass
    {
        public int status { get; set; }
        public DataModel data { get; set; }
        public string message { get; set; }
    }
    public class DataModel
    {
       public baseInfoModel baseInfo { get; set; }
        public familyModel family { get; set; }
        public liveModel live { get; set; }

        public dynamic managers { get; set; }
        public string jump { get; set; }

    }

    public class liveModel
    {
        public int roomId { get; set; }
        public string nickname { get; set; }
        public int userId { get; set; }
        public string avatar { get; set; }
        public string title { get; set; }
        public TimeSpan broadcastBegin { get; set; }
        public TimeSpan Duration { get; set; }
        public int views { get; set; }
        public string preview { get; set; }
        public string preview2 { get; set; }
        public string playId { get; set; }
        public string gameId { get; set; }
        public string gameName { get; set; }
        public string longitude { get; set; }
        public string latitude { get; set; }
        public bool isLive { get; set; }
        public string address { get; set; }

    }
    public class familyModel
    {
        public int familyId { get; set; }
        public string domain { get; set; }
        public string badge { get; set; }
    }
    public class baseInfoModel
    {
        public int roomId { get; set; }
        public string domain { get; set; }
        public string url { get; set; }
        public int userId { get; set; }
        public string nickname { get; set; }
        public string notice { get; set; }
        public dynamic tags { get; set; }
        public int gameId { get; set; }
        public dynamic level { get; set; }
        public int followCnt { get; set; }
        public string avatar { get; set; }
        public string cover { get; set; }
        public string cover2 { get; set; }
        public string address { get; set; }
        public string gameName { get; set; }
        public string isAuth { get; set; }
        public int flowerCount { get; set; }
        public string welcome { get; set; }
    }
}
