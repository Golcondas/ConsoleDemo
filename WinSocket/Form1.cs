using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace WinSocket
{
    public partial class Form1 : Form
    {
        public int threadSendToServerErrorCount = 0;
        private static Thread threadSendToServer;
        private int gloryh = 0;//程序与设备的会话句柄  
        public Form1()
        {
            InitializeComponent();
        }

        byte[] GetConMessage(MemoryStream ms)
        {
            string content = Encoding.UTF8.GetString(ms.ToArray());
            //string message = string.Format("[len={0}]{1}", content.Length, content);//添加消息结束标记  
            return Encoding.UTF8.GetBytes(content);
        }

        public string GetIpAddress(string input)
        {
            return input.Split(':')[0];
        }

        public class ConnectionDataMessage
        {
            ///// <summary>  
            ///// ip地址  
            ///// </summary>  
            //public string Address { get; set; }
            ///// <summary>  
            ///// 登录用户  
            ///// </summary>  
            //public string SignInName { get; set; }
            ///// <summary>  
            ///// 设备号  
            ///// </summary>  
            //public string DeviceCode { get; set; }
            ///// <summary>  
            ///// 网点  
            ///// </summary>  
            //public int BranchID { get; set; }
            ///// <summary>  
            ///// 时间  
            ///// </summary>  
            //public DateTime NowTime { get; set; }
            ///// <summary>  
            ///// 0：正常 1：终端机正常  2： 终端机异常  
            ///// </summary>  
            //public int ConnStatus { get; set; }
            public string accountID{get;set;}
            public string amount{get;set;}
            public string Method{get;set;} 
            public string expireDay{get;set;}
            public string description{get;set;}

        }

        private void btn_Request_Click(object sender, EventArgs e)
        {
            //while (true)
            //{
                TcpClient client = new TcpClient((IPAddress.Parse("121.40.242.227")).ToString(), 7002);
                ConnectionDataMessage cdm = new ConnectionDataMessage();
                cdm.Method = "FinancialRewardsExecute";
                cdm.accountID = "753082221526781952";
                cdm.amount = "1";
                cdm.expireDay = "test_1";
                cdm.description = "奖励";

                NetworkStream ns = client.GetStream();
                if (ns.CanWrite) {
                    //JavaScriptSerializer serial = new JavaScriptSerializer();
                    //string context = serial.Serialize(cdm);
                    //Byte[] sendBytes = Encoding.UTF8.GetBytes(context);
                    //ns.Write(sendBytes, 0, sendBytes.Length);
                    //ns.
                }


                //System.Runtime.Serialization.Json.DataContractJsonSerializer dss = new System.Runtime.Serialization.Json.DataContractJsonSerializer(typeof(ConnectionDataMessage));
                //MemoryStream ms = new MemoryStream();
                //ConnectionDataMessage dataMessage = new ConnectionDataMessage()
                //{
                //    //Address = GetIpAddress(client.Client.LocalEndPoint.ToString()),  
                //    //SignInName = "az",  
                //    //BranchID = 12,  
                //    //DeviceCode = "A31",  
                //    //NowTime = System.DateTime.Now,  
                //    //ConnStatus = 0  
                //    Method = "FinancialRewardsExecute",
                //    accountID = "753082221526781952",
                //    amount = "1",
                //    expireDay = "test_1",
                //    description = "奖励"
                //};
                //dss.WriteObject(ms, dataMessage);
                //byte[] data = GetConMessage(ms);
                //NetworkStream stream = client.GetStream();

                //stream.Write(data, 0, data.Length);
                //ms.Close();
                //stream.Close();

                client.Close();
                //Thread.Sleep(1000); 
            //}
        }
    }
}
