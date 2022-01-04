using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwinCAT.Ads;
using System.IO;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace AdsClientDLL
{
    public class AdsClientClass
    {
        

        [StructLayout(LayoutKind.Sequential, Pack = 1), Serializable]
        public struct AXIS_DATA
        {
            public Int32 actual_position;
            public Int32 actual_velocity;
            public Int32 actual_current;
            public Int32 absolute_position;
        };

        [StructLayout(LayoutKind.Sequential, Pack = 1), Serializable]
        public struct System_Data
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 500)]
            public Int32[] m_cnt;
            public Int32 m_log_cnt;
            public Int32 mode_of_operation;
            public Int32 mode_of_operation_display;
            public Int32 status_word;
            public Int32 control_word;
            public Int32 digital_output;
            public Int32 max_torque;
            public Int32 max_current;
            public Int32 digital_input;
            public Int32 analog_input;
            public Int32 target_position;
            public Int32 target_velocity;
            public Int32 target_current;
            public Int32 control_gain_1;
            public Int32 control_gain_2;	       
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 500)]
            public AXIS_DATA[] ModuleData;
        };

        public System_Data ADS_Input;

        private TcAdsClient _tcClient;
        private AdsStream adsWriteStream;
        private AdsStream adsReadStream;


        FileInfo f = new FileInfo("logging.txt");

        string m_strErrMsg;
        string m_strlbOutput;

        public void AdsInitialize()
        {
            m_strErrMsg = "";
            m_strlbOutput = "";
            // create a new TcClient instance          
            _tcClient = new TcAdsClient();

            ADS_Input = new System_Data();

            adsReadStream = new AdsStream(Marshal.SizeOf(typeof(System_Data)));
            adsWriteStream = new AdsStream(4);

        }

        public void AdsConnect(string _address ="127.0.0.1.1.1", int _port = 32771)
        {
            AmsAddress serverAddress = null;
            try
            {
                serverAddress = new AmsAddress(_address, _port);
            }
            catch
            {
                m_strErrMsg += "Invalid AMS NetId or Ams port";
                return;
            }

            try
            {
                _tcClient.Connect(serverAddress.NetId, serverAddress.Port);
                m_strlbOutput += ("Client port " + _tcClient.ClientPort + " opened");
                
            }
            catch
            {
                m_strErrMsg += "Could not connect client";
            }
        }

        public void AdsDisconnect()
        {
            try
            {
                _tcClient.Dispose();

            }

            catch(Exception ex)
            {
                m_strErrMsg += ex.ToString();
            }
            
        }

        public void AdsServoOn(uint _mode)
        {

            // _mode = 3 => Velocity mode
            // _mode = 8 => Position mode
            // _mode = 4 => Current mode

            try
            {


                AdsBinaryWriter binWriter = new AdsBinaryWriter(adsWriteStream);
                adsWriteStream.Position = 0;

                binWriter.Write(_mode);

                _tcClient.ReadWrite(0x4, 0x1, adsReadStream, adsWriteStream);
            }

            catch (Exception err)
            {
                Debug.Write(err.Message);
            }

        }

    }
}
