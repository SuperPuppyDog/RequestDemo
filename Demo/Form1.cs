using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (!string.IsNullOrWhiteSpace(txt_url.Text)&& txt_url.Text.Contains("longzhu"))
            {
                Common.GetIpList();
                //lal_res.Text = "82DE252F74286C2D47951D7EF7F96E6B";
                txt_res.Text += Common.GetIpList()+"\r\n"; 
                // Func_Start();
            }
            else
            {
                MessageBox.Show("请输入合法的龙珠直播房间url");
            }
        }


        public void Func_Start()
        {
            Regex reg = new Regex("http://y.longzhu.com/(.+)?style=");
            string roomId = reg.Match(txt_url.Text).Groups[1].ToString();

            WebClient wc = new WebClient();
            wc.Encoding = Encoding.UTF8;
            //string res = wc.DownloadString(string.Format("http://yoyo-api.longzhu.com/api/room/init?domain={0}&style=v&callback=roominit", roomId.Trim('?')));
            string res = wc.DownloadString("http://yoyo-api.longzhu.com/api/singer/singerInfo?roomId=2126605&callback=anchorinfo");
            if (!string.IsNullOrWhiteSpace(res))
            {
                 res = new Regex("[a-zA-Z]+((.+))").Match(res).Groups[1].ToString().Trim('(',')');

                dynamic ds = JsonConvert.DeserializeObject<dynamic>(res);
                txt_res.Text += string.Format("昵称:{0}\t直播状态:{1}\t在线人数{2}\r\n",ds.data.baseInfo.nickname,Convert.ToBoolean(ds.data.live.isLive)?"直播中":"下线了",ds.data.live.views);
                lal_res.Text += ds.data.live.views;
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
        }
    }
}
