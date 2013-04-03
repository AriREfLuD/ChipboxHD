using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Sockets;
using System.Net;
using System.Threading;

namespace Chipbox
{
    /*
       -- Key Data Code --
      0 ~ 9  : RCU Key 0 ~ 9
     10 ~ 13 : RCU Key UP, Down, Left, Right
     14 ~ 16 : RCU Key Menu, Ok, Exit
     17 , 18 : RCU Key Page UP, Page Down
     19      : RCU Key Recall
     20 ~ 23 : RCU Key Vol Up, Down, Ch Up, Down

     24 , 25 : RCU Key REC, Stop
     26      : RCU Key Mute

     */

    public enum RCKeys
    {
        Key_0, Key_1, Key_2, Key_3, Key_4, Key_5, Key_6, Key_7, Key_8, Key_9,
        Key_Up, Key_Down, Key_Left, Key_Right,
        Key_Menu, Key_Ok, Key_Exit,
        Key_PageUp, Key_PageDown,
        Key_Recall,
        Key_VolumeUp, Key_VolumeDown, Key_ChannelUp, Key_ChannelDown,
        Key_Record, Key_Stop,
        Key_Mute,
        Key_Standby = 62
    }

    public class ChipboxHD
    {
        private const string rcuemulator = "/usr/work0/app/rcuemulator.elf ";

        private TcpClient _chipbox;
        NetworkStream _stream;

        public ChipboxHD(string IP)
        {
            try
            {
                _chipbox = new TcpClient(IP, 23);
                _stream = _chipbox.GetStream();
            }
            catch (Exception exp)
            {
                throw exp;
            }
        }

        public bool IsConnected
        {
            get
            {
                try
                {
                    //byte[] data = new byte[] { 0x0A, 0x0A, 0x0a };
                    //_stream.Write(data, 0, 3);
                    //_stream.Flush();
                    //Thread.Sleep(25);
                    //_stream.Write(data, 0, 3);
                    //_stream.Flush();
                    _stream.WriteByte(0x0A);
                    Thread.Sleep(100);
                    _stream.WriteByte(0x0A);
                }
                catch { return false; }

                return _chipbox.Client.Connected;
            }
        }

        public string IPAdress
        {
            get
            {
                return _chipbox.Client.RemoteEndPoint.ToString().Split(':')[0];
            }
        }

        public void SendRCKey(RCKeys key)
        {
            string komut = rcuemulator + ((int)key).ToString() + "\n";
            byte[] data = System.Text.Encoding.ASCII.GetBytes(komut);
            _stream.Write(data, 0, data.Length);

        }
        public void SendRCKey(string key)
        {
            string k = ((int)Enum.Parse(typeof(RCKeys), key)).ToString();
            string komut = rcuemulator + k + "\n";
            Byte[] data = System.Text.Encoding.ASCII.GetBytes(komut);
            _stream.Write(data, 0, data.Length);
        }

        public void CloseAll()
        {
            _stream.Close();
            _chipbox.Close();
        }
    }
}

