using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TwinCAT.Ads;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Diagnostics;
using C1Chart2DDLL;

namespace adsClientVisu
{


    //public AXIS_DATA[]
    public partial class form : Form
    {
        public bool motion_enable = false;
        public bool stop_flag = false;
        public bool m_bPC = false;
        public bool m_bSG = false;
        public bool m_logging_flag = false;
        public int m_StiffnessMode = 0;
        public int m_joint_index = 0;
        public bool m_UpdateData = false;
        static bool m_SetLVelRangeFlag = false;
        static bool m_SetLTorqueRangeFlag = false;
        static bool m_SetRVelRangeFlag = false;
        static bool m_SetRTorqueRangeFlag = false;
        public int listenPort = 5000;

        DateTime m_Dt;

        C1ChartFormClass m_Chart = new C1ChartFormClass();
        int m_dChartMode = 0;

        //Initailize Image Box
        Image StatusOnImage = Image.FromFile(Application.StartupPath + @"\\Status_On.bmp");
        Image StatusOffImage = Image.FromFile(Application.StartupPath + @"\\Status_Off.bmp");



        // UDP Connnection Server
        public bool UDP_connect_start = false;
        
        public UdpClient srv;

        UDPServer_SEND UDP_Server_Data;
        UDPClient_RECV UDP_Client_Data;

        public string ipaddress = "192.168.10.50";
        public IPEndPoint endpoint;
        public Thread receiveThread;

        public form()
        {
            InitializeComponent();


            //Robot Status Image
            pbConnect.Image = StatusOffImage;
            pbAuxPow.Image = StatusOffImage;
            pbMainPow.Image = StatusOffImage;
            pbJoint1Servo.Image = StatusOffImage;
            pbJoint2Servo.Image = StatusOffImage;
            pbJoint3Servo.Image = StatusOffImage;
            pbJoint4Servo.Image = StatusOffImage;
            pbJoint5Servo.Image = StatusOffImage;
            pbJoint6Servo.Image = StatusOffImage;
            pbLogging.Image = StatusOffImage;

            //Master Mode State image
            pbPositionMode.Image = StatusOffImage;
            pbTorqueMode.Image = StatusOffImage;
            pbGravityMode.Image = StatusOffImage;
            pbTargetReached.Image = StatusOffImage;
            pbUpdateData.Image = StatusOffImage;
            pbUDPconnection.Image = StatusOffImage;
        }
        

        /////////////////////////////////////////////////////////
        //
        // * ADS Client -> Server Data
        // 
        /////////////////////////////////////////////////////////       


        //[StructLayout(LayoutKind.Sequential, Pack = 1), Serializable]
        public struct ADSClient_SystemData  
        {
            //Position Mode Gain Value
            //[MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)]
            public float[] Pos_Pgain;

            //[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public float[] Pos_Igain;
            //[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public float[] Pos_Dgain;

            //Velocity Mode Gain Value
            //[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public float[] Vel_Pgain;
            //[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public float[] Vel_Igain;
            //[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public float[] Vel_Dgain;

            //Torque Mode Gain Value
            //[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public float[] Torq_Pgain;
            //[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public float[] Torq_Igain;
            //[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public float[] Torq_Dgain;

            //Joint Efficient Const.
            //[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public float[] J_EffiCont;
            //Joint Torque Const.
            //[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public float[] J_TorqueConst;
            //Joint Spring Const.
            //[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public float[] J_SpringConst;

            //Joint Target Position.
            //[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public float[] J_TargetPoistion;
            //Joint Target Time.
            //[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public float[] J_TargetTime;
            //Joint Accel TIme.
            //[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public float[] J_AccelTime;

            public float[] CMD_BufferL1;
            public float[] CMD_BufferL2;
            public float[] CMD_BufferL3;
            public float[] CMD_BufferL4;
            public float[] CMD_BufferL5;
            public float[] CMD_BufferL6;

            public float[] CMD_BufferR1;
            public float[] CMD_BufferR2;
            public float[] CMD_BufferR3;
            public float[] CMD_BufferR4;
            public float[] CMD_BufferR5;
            public float[] CMD_BufferR6;

            //Set Joint Mode
            //public bool SetJointModeSelect;
            //public bool SetCartesianModeSelect;




        };


        public ADSClient_SystemData ADS_ClientData;

        /////////////////////////////////////////////////////////
        //
        // * ADS Server -> ADS Client Data
        // 
        /////////////////////////////////////////////////////////       
        [StructLayout(LayoutKind.Sequential, Pack = 1), Serializable]
        public struct AXIS_DATA
        {
            
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public float[] actual_motor_position;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public float[] actual_link_position;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public float[] actual_motor_velocity;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public float[] actual_link_velocity;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public float[] actual_current;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public float[] target_position;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public float[] target_velocity;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public float[] target_current;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public Int32[] mode_of_operation;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public Int32[] status_word;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public float[] cartesian_target_pose;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public float[] cartesian_current_pose;

        };


        [StructLayout(LayoutKind.Sequential, Pack = 1), Serializable]
        public struct ADSServer_SystemData
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 100)]
            public Int32[] m_Cnt;
            public Int32 m_log_cnt;
            public Int32 m_cycle_sec;
            public Int32 m_cycle_min;
            public Int32 m_cycle_hour;
            public Int32 Gravity_Mode;
            public Int32 TorquePosition_Mode;
            public Int32 target_reached;
            public Int32 m_dSystemMode;// 0: Gravity mode, 1:Joint Mode, 2:Cartesian Mode
            public Int32 m_button_left;
            public Int32 m_button_right;

            // Position Mode
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public float[] accel_time;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public float[] target_reach_time;      

            // Test Buffer Data
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public float[] TestBuffer1;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public float[] TestBuffer2;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public float[] TestBuffer3;

            // Module Data
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 100)]
            public AXIS_DATA[] ModuleData_Left;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 100)]
            public AXIS_DATA[] ModuleData_Right;
        };
        public ADSServer_SystemData ADS_ServerData;      

      //  FileInfo f = new FileInfo("logging.csv");
        
        // UDP Connect
        [StructLayout(LayoutKind.Sequential, Pack = 1), Serializable]
        public struct Controller_struct
        {
            public float x;
            public float y;
            public float z;
            public float m_energy_x;
            public float m_energy_y;
            public float m_energy_z;
            public float roll;
            public float pitch;
            public float yaw;
            public UInt16 button;
            public byte popc_state;
        };
        [StructLayout(LayoutKind.Sequential, Pack = 1), Serializable]
        public struct UDPServer_SEND
        {
            public byte Index1;
            public byte Index2;
            public Controller_struct left;
            public Controller_struct right;

        };


        [StructLayout(LayoutKind.Sequential, Pack = 1), Serializable]
        public struct Machine_struct
        {
            public float force_x;
            public float force_y;
            public float force_z;
            public float s_energy_x;
            public float s_energy_y;
            public float s_energy_z;

        };
        [StructLayout(LayoutKind.Sequential, Pack = 1), Serializable]
        public struct UDPClient_RECV
        {
            public byte Index1;
            public byte Index2;
            public Machine_struct left;
            public Machine_struct right;
        };

        public static byte[] StructToByte(object obj)
        {
            int size = Marshal.SizeOf(obj);
            byte[] arr = new byte[size];
            IntPtr ptr = Marshal.AllocHGlobal(size);

            Marshal.StructureToPtr(obj, ptr, true);
            Marshal.Copy(ptr, arr, 0, size);
            Marshal.FreeHGlobal(ptr);
            return arr;

        }
        public static T ByteToStruct<T>(byte[] buffer) where T : struct
        {

            int size = Marshal.SizeOf(typeof(T));
            if (size > buffer.Length)
            {
                throw new Exception();
            }

            IntPtr ptr = Marshal.AllocHGlobal(size);
            Marshal.Copy(buffer, 0, ptr, size);
            T obj = (T)Marshal.PtrToStructure(ptr, typeof(T));
            Marshal.FreeHGlobal(ptr);
            return obj;
        }
        

        private void Form1_Load(object sender, EventArgs e)
        {
            // create new TcClient instance          
            _tcClient = new TcAdsClient();

            ADS_ServerData = new ADSServer_SystemData();
            ADS_ClientData = new ADSClient_SystemData();

            UDP_Server_Data = new UDPServer_SEND();
            UDP_Client_Data = new UDPClient_RECV();

            ADS_ClientData.J_AccelTime = new float[3];
            ADS_ClientData.J_EffiCont = new float[3];
            ADS_ClientData.J_SpringConst = new float[3];
            ADS_ClientData.J_TargetPoistion = new float[3];
            ADS_ClientData.J_TargetTime = new float[3];
            ADS_ClientData.J_TorqueConst = new float[3];
            ADS_ClientData.Pos_Dgain = new float[3];
            ADS_ClientData.Pos_Igain = new float[3];
            ADS_ClientData.Pos_Pgain = new float[3];
            ADS_ClientData.Torq_Dgain = new float[3];
            ADS_ClientData.Torq_Igain = new float[3];
            ADS_ClientData.Torq_Pgain = new float[3];
            ADS_ClientData.Vel_Dgain = new float[3];
            ADS_ClientData.Vel_Igain = new float[3];
            ADS_ClientData.Vel_Pgain = new float[3];

            ADS_ClientData.CMD_BufferL1 = new float[3];
            ADS_ClientData.CMD_BufferL2 = new float[3];
            ADS_ClientData.CMD_BufferL3 = new float[3];
            ADS_ClientData.CMD_BufferL4 = new float[3];
            ADS_ClientData.CMD_BufferL5 = new float[3];
            ADS_ClientData.CMD_BufferL6 = new float[3];

            ADS_ClientData.CMD_BufferR1 = new float[3];
            ADS_ClientData.CMD_BufferR2 = new float[3];
            ADS_ClientData.CMD_BufferR3 = new float[3];
            ADS_ClientData.CMD_BufferR4 = new float[3];
            ADS_ClientData.CMD_BufferR5 = new float[3];
            ADS_ClientData.CMD_BufferR6 = new float[3];

            
            

            //ADS_ClientData.SetJointModeSelect = new bool;
            //ADS_ClientData.SetCartesianModeSelect = new bool;


            adsReadStream = new AdsStream(Marshal.SizeOf(typeof(ADSServer_SystemData)));
            adsWriteStream = new AdsStream(4);
        }
        
        public void ReceiveData()
        {
            while (true)
            {
                try
                {
                    
                    /////////////////////////////////////////////////////////
                    //
                    // * UDP Server -> UDP Client Data
                    // 
                    /////////////////////////////////////////////////////////

                    // 데이터 수신
                    //IPEndPoint endpoint = new IPEndPoint(IPAddress.Any, 0);
                    byte[] Rdatagram = srv.Receive(ref endpoint);
                    GCHandle handle = GCHandle.Alloc(Rdatagram, GCHandleType.Pinned);
                    UDP_Client_Data = (UDPClient_RECV)Marshal.PtrToStructure(handle.AddrOfPinnedObject(), typeof(UDPClient_RECV));
                    handle.Free();
                    if (Rdatagram != null)
                    {
                        UDP_connect_start = true;
                    }
                    /*
                    /////////////////////////////////////////////////////////
                    //
                    // * UDP Client -> UDP Server Data
                    // 
                    /////////////////////////////////////////////////////////

                    // 데이터 송신
                    byte[] Sdatagram = StructToByte(UDP_Server_Data);
                    // Client
                    //srv.Send(Sdatagram, Sdatagram.Length, ipaddress, sendPort);
                    // Server
                    srv.Send(Sdatagram, Sdatagram.Length, endpoint);
                    */

                }
                catch (Exception err)
                {
                    MessageBox.Show(err.ToString());
                }
            }

        }
        
        /*
         * Connect the client to the local AMS router 
         */

        private void btConnect_Click(object sender, EventArgs e)
        {
            AmsAddress serverAddress = null;
            try
            {
                // check if port is a hex value
                if (tbPort.Text.StartsWith(("0x")) || tbPort.Text.StartsWith(("0X")))
                {
                    string sHexValue = tbPort.Text.Substring(2);
                    serverAddress = new AmsAddress(tbNetId.Text, Int32.Parse(sHexValue, System.Globalization.NumberStyles.HexNumber));
                }
                // interpret as dec value
                else
                {
                    
                }

            }
            catch
            {
                MessageBox.Show("Invalid AMS NetId or Ams port");
                return;
            }

            try
            {
                _tcClient.Connect(serverAddress.NetId, serverAddress.Port);

                //connect on Image
                pbConnect.Image = StatusOnImage;

            }
            catch
            {
                MessageBox.Show("Could not connect client");
                pbConnect.Image = Image.FromFile(Application.StartupPath + @"\\Status_Off.bmp");

            }
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                
                if (m_SetLVelRangeFlag == true)
                {
                    /////////////////////////////////////////////////////////
                    //
                    // * Joint 1 Axis
                    // 
                    ////////////////////////////////////////////////////////    
                    m_joint_index = 0;

                    AdsBinaryWriter ADS_Writer = new AdsBinaryWriter(adsWriteStream);

                    adsWriteStream.Position = 0;
                    ADS_Writer.Write(m_joint_index);//int.Parse(tbPy.Text));
                    _tcClient.ReadWrite(0x4, 0x9, adsReadStream, adsWriteStream);

                    // *Joint Buffer4
                    adsWriteStream.Position = 0;
                    ADS_Writer.Write(float.Parse(tbLBuff1J1.Text));
                    _tcClient.ReadWrite(0x4, 0x27, adsReadStream, adsWriteStream);

                    // *Joint Buffer5
                    adsWriteStream.Position = 0;
                    ADS_Writer.Write(float.Parse(tbLBuff2J1.Text));
                    _tcClient.ReadWrite(0x4, 0x28, adsReadStream, adsWriteStream);

                    // *Joint Buffer6
                    adsWriteStream.Position = 0;
                    ADS_Writer.Write(float.Parse(tbLBuff3J1.Text));
                    _tcClient.ReadWrite(0x4, 0x29, adsReadStream, adsWriteStream);

                    /////////////////////////////////////////////////////////
                    //
                    // * Joint 2 Axis
                    // 
                    ////////////////////////////////////////////////////////    
                    m_joint_index = 1;

                    adsWriteStream.Position = 0;
                    ADS_Writer.Write(m_joint_index);//int.Parse(tbPy.Text));
                    _tcClient.ReadWrite(0x4, 0x9, adsReadStream, adsWriteStream);

                    // *Joint Buffer4
                    adsWriteStream.Position = 0;
                    ADS_Writer.Write(float.Parse(tbLBuff1J2.Text));
                    _tcClient.ReadWrite(0x4, 0x27, adsReadStream, adsWriteStream);

                    // *Joint Buffer5
                    adsWriteStream.Position = 0;
                    ADS_Writer.Write(float.Parse(tbLBuff2J2.Text));
                    _tcClient.ReadWrite(0x4, 0x28, adsReadStream, adsWriteStream);

                    // *Joint Buffer6
                    adsWriteStream.Position = 0;
                    ADS_Writer.Write(float.Parse(tbLBuff3J2.Text));
                    _tcClient.ReadWrite(0x4, 0x29, adsReadStream, adsWriteStream);

                    /////////////////////////////////////////////////////////
                    //
                    // * Joint 3 Axis
                    // 
                    ////////////////////////////////////////////////////////    
                    /*
                    m_joint_index = 2;
           
                    adsWriteStream.Position = 0;
                    ADS_Writer.Write(m_joint_index);//int.Parse(tbPy.Text));
                    _tcClient.ReadWrite(0x4, 0x9, adsReadStream, adsWriteStream);
            
                    // *Joint Buffer4
                    adsWriteStream.Position = 0;
                    ADS_Writer.Write(float.Parse(tbBuff1J3.Text));
                    _tcClient.ReadWrite(0x4, 0x27, adsReadStream, adsWriteStream);
            
            
                    // *Joint Buffer5
                    adsWriteStream.Position = 0;
                    ADS_Writer.Write(float.Parse(tbBuff2J3.Text));
                    _tcClient.ReadWrite(0x4, 0x28, adsReadStream, adsWriteStream);
            
                    // *Joint Buffer6
                    adsWriteStream.Position = 0;
                    ADS_Writer.Write(float.Parse(tbBuff3J3.Text));
                    _tcClient.ReadWrite(0x4, 0x29, adsReadStream, adsWriteStream);
                     */

                    m_SetLVelRangeFlag = false;
                }

                if(m_SetLTorqueRangeFlag == true)
                {
                    /////////////////////////////////////////////////////////
                    //
                    // * Joint 1 Axis
                    // 
                    ////////////////////////////////////////////////////////    
                    m_joint_index = 0;

                    AdsBinaryWriter ADS_Writer = new AdsBinaryWriter(adsWriteStream);
                    adsWriteStream.Position = 0;
                    ADS_Writer.Write(m_joint_index);//int.Parse(tbPy.Text));
                    _tcClient.ReadWrite(0x4, 0x9, adsReadStream, adsWriteStream);

                    // *Joint Buffer1
                    adsWriteStream.Position = 0;
                    ADS_Writer.Write(float.Parse(tbLBuff11.Text));
                    _tcClient.ReadWrite(0x4, 0x16, adsReadStream, adsWriteStream);

                    // *Joint Buffer2
                    adsWriteStream.Position = 0;
                    ADS_Writer.Write(float.Parse(tbLBuff12.Text));
                    _tcClient.ReadWrite(0x4, 0x17, adsReadStream, adsWriteStream);

                    // *Joint Buffer3
                    adsWriteStream.Position = 0;
                    ADS_Writer.Write(float.Parse(tbLBuff13.Text));
                    _tcClient.ReadWrite(0x4, 0x18, adsReadStream, adsWriteStream);

                    /////////////////////////////////////////////////////////
                    //
                    // * Joint 2 Axis
                    // 
                    ////////////////////////////////////////////////////////    
                    m_joint_index = 1;

                    adsWriteStream.Position = 0;
                    ADS_Writer.Write(m_joint_index);//int.Parse(tbPy.Text));
                    _tcClient.ReadWrite(0x4, 0x9, adsReadStream, adsWriteStream);

                    // *Joint Buffer1
                    adsWriteStream.Position = 0;
                    ADS_Writer.Write(float.Parse(tbLBuff21.Text));
                    _tcClient.ReadWrite(0x4, 0x16, adsReadStream, adsWriteStream);

                    // *Joint Buffer2
                    adsWriteStream.Position = 0;
                    ADS_Writer.Write(float.Parse(tbLBuff22.Text));
                    _tcClient.ReadWrite(0x4, 0x17, adsReadStream, adsWriteStream);

                    // *Joint Buffer3
                    adsWriteStream.Position = 0;
                    ADS_Writer.Write(float.Parse(tbLBuff23.Text));
                    _tcClient.ReadWrite(0x4, 0x18, adsReadStream, adsWriteStream);

                    /////////////////////////////////////////////////////////
                    //
                    // * Joint 3 Axis
                    // 
                    ////////////////////////////////////////////////////////    
                    m_joint_index = 2;

                    adsWriteStream.Position = 0;
                    ADS_Writer.Write(m_joint_index);//int.Parse(tbPy.Text));
                    _tcClient.ReadWrite(0x4, 0x9, adsReadStream, adsWriteStream);

                    // *Joint Buffer1
                    adsWriteStream.Position = 0;
                    ADS_Writer.Write(float.Parse(tbLBuff31.Text));
                    _tcClient.ReadWrite(0x4, 0x16, adsReadStream, adsWriteStream);

                    // *Joint Buffer2
                    adsWriteStream.Position = 0;
                    ADS_Writer.Write(float.Parse(tbLBuff32.Text));
                    _tcClient.ReadWrite(0x4, 0x17, adsReadStream, adsWriteStream);

                    // *Joint Buffer3
                    adsWriteStream.Position = 0;
                    ADS_Writer.Write(float.Parse(tbLBuff33.Text));
                    _tcClient.ReadWrite(0x4, 0x18, adsReadStream, adsWriteStream);
                    
                    
                    m_SetLTorqueRangeFlag = false;
                }
                
                if (m_SetRVelRangeFlag == true)
                {
                    /////////////////////////////////////////////////////////
                    //
                    // * Right Side Friction
                    // 
                    ////////////////////////////////////////////////////////    
                    m_joint_index = 0;

                    AdsBinaryWriter ADS_Writer = new AdsBinaryWriter(adsWriteStream);
                    adsWriteStream.Position = 0;
                    ADS_Writer.Write(m_joint_index);//int.Parse(tbPy.Text));
                    _tcClient.ReadWrite(0x4, 0x9, adsReadStream, adsWriteStream);


                    adsWriteStream.Position = 0;
                    ADS_Writer.Write(float.Parse(tbRBuff1J1.Text));
                    _tcClient.ReadWrite(0x4, 0x24, adsReadStream, adsWriteStream);


                    adsWriteStream.Position = 0;
                    ADS_Writer.Write(float.Parse(tbRBuff2J1.Text));
                    _tcClient.ReadWrite(0x4, 0x25, adsReadStream, adsWriteStream);

                    adsWriteStream.Position = 0;
                    ADS_Writer.Write(float.Parse(tbRBuff3J1.Text));
                    _tcClient.ReadWrite(0x4, 0x26, adsReadStream, adsWriteStream);


                    m_joint_index = 1;

                    adsWriteStream.Position = 0;
                    ADS_Writer.Write(m_joint_index);//int.Parse(tbPy.Text));
                    _tcClient.ReadWrite(0x4, 0x9, adsReadStream, adsWriteStream);

                    adsWriteStream.Position = 0;
                    ADS_Writer.Write(float.Parse(tbRBuff2J2.Text));
                    _tcClient.ReadWrite(0x4, 0x24, adsReadStream, adsWriteStream);


                    adsWriteStream.Position = 0;
                    ADS_Writer.Write(float.Parse(tbRBuff2J2.Text));
                    _tcClient.ReadWrite(0x4, 0x25, adsReadStream, adsWriteStream);


                    adsWriteStream.Position = 0;
                    ADS_Writer.Write(float.Parse(tbRBuff3J2.Text));
                    _tcClient.ReadWrite(0x4, 0x26, adsReadStream, adsWriteStream);

                    /*
                    m_joint_index = 2;

                    adsWriteStream.Position = 0;
                    ADS_Writer.Write(m_joint_index);//int.Parse(tbPy.Text));
                    _tcClient.ReadWrite(0x4, 0x9, adsReadStream, adsWriteStream);

                    adsWriteStream.Position = 0;
                    ADS_Writer.Write(float.Parse(tbRBuff1J3.Text));
                    _tcClient.ReadWrite(0x4, 0x24, adsReadStream, adsWriteStream);

                    adsWriteStream.Position = 0;
                    ADS_Writer.Write(float.Parse(tbRBuff2J3.Text));
                    _tcClient.ReadWrite(0x4, 0x25, adsReadStream, adsWriteStream);

                    adsWriteStream.Position = 0;
                    ADS_Writer.Write(float.Parse(tbRBuff3J3.Text));
                    _tcClient.ReadWrite(0x4, 0x26, adsReadStream, adsWriteStream);
                    */
                    m_SetRVelRangeFlag = false;
                }

                if(m_SetRTorqueRangeFlag == true)
                {
                    /////////////////////////////////////////////////////////
                    //
                    // * Joint 1 Axis
                    // 
                    ////////////////////////////////////////////////////////    
                    m_joint_index = 0;

                    AdsBinaryWriter ADS_Writer = new AdsBinaryWriter(adsWriteStream);
                    adsWriteStream.Position = 0;
                    ADS_Writer.Write(m_joint_index);//int.Parse(tbPy.Text));
                    _tcClient.ReadWrite(0x4, 0x9, adsReadStream, adsWriteStream);

                    // *Joint Target Position
                    adsWriteStream.Position = 0;
                    ADS_Writer.Write(float.Parse(tbRBuff11.Text));
                    _tcClient.ReadWrite(0x4, 0x13, adsReadStream, adsWriteStream);

                    // * Joint Target Time
                    adsWriteStream.Position = 0;
                    ADS_Writer.Write(float.Parse(tbRBuff12.Text));
                    _tcClient.ReadWrite(0x4, 0x14, adsReadStream, adsWriteStream);

                    // * Joint Accel Const 
                    adsWriteStream.Position = 0;
                    ADS_Writer.Write(float.Parse(tbRBuff13.Text));
                    _tcClient.ReadWrite(0x4, 0x15, adsReadStream, adsWriteStream);

                    /////////////////////////////////////////////////////////
                    //
                    // * Joint 2 Axis
                    // 
                    ////////////////////////////////////////////////////////    
                    m_joint_index = 1;

                    adsWriteStream.Position = 0;
                    ADS_Writer.Write(m_joint_index);//int.Parse(tbPy.Text));
                    _tcClient.ReadWrite(0x4, 0x9, adsReadStream, adsWriteStream);

                    // *Joint Target Position
                    adsWriteStream.Position = 0;
                    ADS_Writer.Write(float.Parse(tbRBuff21.Text));
                    _tcClient.ReadWrite(0x4, 0x13, adsReadStream, adsWriteStream);

                    // * Joint Target Time
                    adsWriteStream.Position = 0;
                    ADS_Writer.Write(float.Parse(tbRBuff22.Text));
                    _tcClient.ReadWrite(0x4, 0x14, adsReadStream, adsWriteStream);

                    // * Joint Accel Const 
                    adsWriteStream.Position = 0;
                    ADS_Writer.Write(float.Parse(tbRBuff23.Text));
                    _tcClient.ReadWrite(0x4, 0x15, adsReadStream, adsWriteStream);

                    /////////////////////////////////////////////////////////
                    //
                    // * Joint 3 Axis
                    // 
                    ////////////////////////////////////////////////////////    
                    m_joint_index = 2;

                    adsWriteStream.Position = 0;
                    ADS_Writer.Write(m_joint_index);//int.Parse(tbPy.Text));
                    _tcClient.ReadWrite(0x4, 0x9, adsReadStream, adsWriteStream);

                    // *Joint Target Position
                    adsWriteStream.Position = 0;
                    ADS_Writer.Write(float.Parse(tbRBuff31.Text));
                    _tcClient.ReadWrite(0x4, 0x13, adsReadStream, adsWriteStream);

                    // * Joint Target Time
                    adsWriteStream.Position = 0;
                    ADS_Writer.Write(float.Parse(tbRBuff32.Text));
                    _tcClient.ReadWrite(0x4, 0x14, adsReadStream, adsWriteStream);

                    // * Joint Accel Const 
                    adsWriteStream.Position = 0;
                    ADS_Writer.Write(float.Parse(tbRBuff33.Text));
                    _tcClient.ReadWrite(0x4, 0x15, adsReadStream, adsWriteStream);

                    m_SetRTorqueRangeFlag = false;
                }
                
                if (m_UpdateData)
                {

                    /////////////////////////////////////////////////////////
                    //
                    // * ADS Server -> ADS Client Data
                    // 
                    /////////////////////////////////////////////////////////
                    _tcClient.ReadWrite(0x4, 0x4, adsReadStream, adsWriteStream);

                    byte[] read_stream_buffer = adsReadStream.ToArray();

                    GCHandle r_handle = GCHandle.Alloc(read_stream_buffer, GCHandleType.Pinned);     // Alloc(들어갈 byte 배열, 핸들값)
                    ADS_ServerData = (ADSServer_SystemData)Marshal.PtrToStructure(r_handle.AddrOfPinnedObject(), typeof(ADSServer_SystemData));
                    r_handle.Free();


                    UDP_Server_Data.Index1 = 0;
                    UDP_Server_Data.Index2 = 0;

                    UDP_Server_Data.left.x = ADS_ServerData.ModuleData_Left[0].cartesian_current_pose[0];
                    UDP_Server_Data.left.y = ADS_ServerData.ModuleData_Left[0].cartesian_current_pose[1];
                    UDP_Server_Data.left.z = ADS_ServerData.ModuleData_Left[0].cartesian_current_pose[2];
                    UDP_Server_Data.left.roll = ADS_ServerData.ModuleData_Left[0].actual_link_position[0];
                    UDP_Server_Data.left.pitch = ADS_ServerData.ModuleData_Left[0].actual_link_position[1];
                    UDP_Server_Data.left.yaw = ADS_ServerData.ModuleData_Left[0].actual_link_position[2];
                    UDP_Server_Data.left.button = Convert.ToUInt16(ADS_ServerData.m_button_left);
                    UDP_Server_Data.left.popc_state = 0;
                    UDP_Server_Data.left.m_energy_x = 0.0f;
                    UDP_Server_Data.left.m_energy_y = 0.0f;
                    UDP_Server_Data.left.m_energy_z = 0.0f;

                    UDP_Server_Data.right.x = ADS_ServerData.ModuleData_Right[0].cartesian_current_pose[0];
                    UDP_Server_Data.right.y = ADS_ServerData.ModuleData_Right[0].cartesian_current_pose[1];
                    UDP_Server_Data.right.z = ADS_ServerData.ModuleData_Right[0].cartesian_current_pose[2];
                    UDP_Server_Data.right.roll = ADS_ServerData.ModuleData_Right[0].actual_link_position[0];
                    UDP_Server_Data.right.pitch = ADS_ServerData.ModuleData_Right[0].actual_link_position[1];
                    UDP_Server_Data.right.yaw = ADS_ServerData.ModuleData_Right[0].actual_link_position[2];
                    UDP_Server_Data.right.button = Convert.ToUInt16(ADS_ServerData.m_button_right);
                    UDP_Server_Data.right.popc_state = 0;
                    UDP_Server_Data.right.m_energy_x = 0.0f;
                    UDP_Server_Data.right.m_energy_y = 0.0f;
                    UDP_Server_Data.right.m_energy_z = 0.0f;

                    if (UDP_connect_start == true)
                    {
                        

                        /*
                        /////////////////////////////////////////////////////////
                        //
                        // * UDP Server -> UDP Client Data
                        // 
                        /////////////////////////////////////////////////////////

                        // 데이터 수신
                        IPEndPoint endpoint = new IPEndPoint(IPAddress.Any, 0);
                        byte[] Rdatagram = srv.Receive(ref endpoint);
                        GCHandle handle = GCHandle.Alloc(Rdatagram, GCHandleType.Pinned);
                        UDP_Client_Data = (UDPClient_RECV)Marshal.PtrToStructure(handle.AddrOfPinnedObject(), typeof(UDPClient_RECV));
                        handle.Free();
                        */


                        /////////////////////////////////////////////////////////
                        //
                        // * UDP Client -> UDP Server Data
                        // 
                        /////////////////////////////////////////////////////////

                        // 데이터 송신
                        //IPEndPoint endpoint = new IPEndPoint(IPAddress.Any, listenPort);
                        byte[] Sdatagram = StructToByte(UDP_Server_Data);
                        // Client
                        //srv.Send(Sdatagram, Sdatagram.Length, ipaddress, sendPort);
                        // Server
                        srv.Send(Sdatagram, Sdatagram.Length, endpoint);
                    }
                                   
                    // ADS Client Data Update
                    tbLeftButton.Text = Convert.ToString(ADS_ServerData.m_button_left);

                    tbLeftABSPosion1.Text = Convert.ToString(ADS_ServerData.ModuleData_Left[0].actual_link_position[0]);
                    tbLeftABSPosion2.Text = Convert.ToString(ADS_ServerData.ModuleData_Left[0].actual_link_position[1]);
                    tbLeftABSPosion3.Text = Convert.ToString(ADS_ServerData.ModuleData_Left[0].actual_link_position[2]);

                    tbLeftPosion1.Text = Convert.ToString(ADS_ServerData.ModuleData_Left[0].actual_motor_position[0]);
                    tbLeftVelocity1.Text = Convert.ToString(ADS_ServerData.ModuleData_Left[0].actual_motor_velocity[0]);
                    tbLeftCurrent1.Text = Convert.ToString(ADS_ServerData.ModuleData_Left[0].actual_current[0]);

                    tbLeftPosion2.Text = Convert.ToString(ADS_ServerData.ModuleData_Left[0].actual_motor_position[1]);
                    tbLeftVelocity2.Text = Convert.ToString(ADS_ServerData.ModuleData_Left[0].actual_motor_velocity[1]);
                    tbLeftCurrent2.Text = Convert.ToString(ADS_ServerData.ModuleData_Left[0].actual_current[1]);

                    tbLeftPosion3.Text = Convert.ToString(ADS_ServerData.ModuleData_Left[0].actual_motor_position[2]);
                    tbLeftVelocity3.Text = Convert.ToString(ADS_ServerData.ModuleData_Left[0].actual_motor_velocity[2]);
                    tbLeftCurrent3.Text = Convert.ToString(ADS_ServerData.ModuleData_Left[0].actual_current[2]);

                    tbRightButton.Text = Convert.ToString(ADS_ServerData.m_button_right);

                    tbRightABSPosion1.Text = Convert.ToString(ADS_ServerData.ModuleData_Right[0].actual_link_position[0]);
                    tbRightABSPosion2.Text = Convert.ToString(ADS_ServerData.ModuleData_Right[0].actual_link_position[1]);
                    tbRightABSPosion3.Text = Convert.ToString(ADS_ServerData.ModuleData_Right[0].actual_link_position[2]);

                    tbRightPosion1.Text = Convert.ToString(ADS_ServerData.ModuleData_Right[0].actual_motor_position[0]);
                    tbRightVelocity1.Text = Convert.ToString(ADS_ServerData.ModuleData_Right[0].actual_motor_velocity[0]);
                    tbRightCurrent1.Text = Convert.ToString(ADS_ServerData.ModuleData_Right[0].actual_current[0]);

                    tbRightPosion2.Text = Convert.ToString(ADS_ServerData.ModuleData_Right[0].actual_motor_position[1]);
                    tbRightVelocity2.Text = Convert.ToString(ADS_ServerData.ModuleData_Right[0].actual_motor_velocity[1]);
                    tbRightCurrent2.Text = Convert.ToString(ADS_ServerData.ModuleData_Right[0].actual_current[1]);

                    tbRightPosion3.Text = Convert.ToString(ADS_ServerData.ModuleData_Right[0].actual_motor_position[2]);
                    tbRightVelocity3.Text = Convert.ToString(ADS_ServerData.ModuleData_Right[0].actual_motor_velocity[2]);
                    tbRightCurrent3.Text = Convert.ToString(ADS_ServerData.ModuleData_Right[0].actual_current[2]);

                    // Test Buffer Update
                    tbBuffUpdate11.Text = Convert.ToString(ADS_ServerData.TestBuffer1[0]);
                    tbBuffUpdate12.Text = Convert.ToString(ADS_ServerData.TestBuffer1[1]);
                    tbBuffUpdate13.Text = Convert.ToString(ADS_ServerData.TestBuffer1[2]);

                    tbBuffUpdate21.Text = Convert.ToString(ADS_ServerData.TestBuffer2[0]);
                    tbBuffUpdate22.Text = Convert.ToString(ADS_ServerData.TestBuffer2[1]);
                    tbBuffUpdate23.Text = Convert.ToString(ADS_ServerData.TestBuffer2[2]);

                    tbBuffUpdate31.Text = Convert.ToString(ADS_ServerData.TestBuffer3[0]);
                    tbBuffUpdate32.Text = Convert.ToString(ADS_ServerData.TestBuffer3[1]);
                    tbBuffUpdate33.Text = Convert.ToString(ADS_ServerData.TestBuffer3[2]);

                    //Log Cycle 
                    tbLogCycle.Text = Convert.ToString(ADS_ServerData.m_log_cnt);

                    //Cartesian Cur Pose
                    tbLeftPoseX.Text = ADS_ServerData.ModuleData_Left[0].cartesian_current_pose[0].ToString("F6");
                    tbLeftPoseY.Text = ADS_ServerData.ModuleData_Left[0].cartesian_current_pose[1].ToString("F6");
                    tbLeftPoseZ.Text = ADS_ServerData.ModuleData_Left[0].cartesian_current_pose[2].ToString("F6");

                    tbRightPoseX.Text = ADS_ServerData.ModuleData_Right[0].cartesian_current_pose[0].ToString("F6");
                    tbRightPoseY.Text = ADS_ServerData.ModuleData_Right[0].cartesian_current_pose[1].ToString("F6");
                    tbRightPoseZ.Text = ADS_ServerData.ModuleData_Right[0].cartesian_current_pose[2].ToString("F6");

                    // Status Check
                    pbUpdateData.Image = StatusOnImage;

                    /*
                    if (m_dChartMode == 0)
                    {
                        for (int i = 0; i <= ADS_ServerData.m_log_cnt; i = i + 5)
                            m_Chart.AddPoint(ADS_ServerData.m_Cnt[i],
                                ADS_ServerData.ModuleData[i].actual_link_position[2],
                                ADS_ServerData.ModuleData[i].target_position[2]);
                    }

                    if (m_dChartMode == 1)
                    {
                        for (int i = 0; i <= ADS_ServerData.m_log_cnt; i = i + 5)
                            m_Chart.AddPoint(ADS_ServerData.m_Cnt[i],
                                ADS_ServerData.ModuleData[i].actual_current[1],
                                ADS_ServerData.ModuleData[i].actual_current[2]);
                    }

                    if (m_dChartMode == 2)
                    {
                        for (int i = 0; i <= ADS_ServerData.m_log_cnt; i = i + 5)
                            m_Chart.AddPoint(ADS_ServerData.m_Cnt[i],
                                ADS_ServerData.ModuleData[i].actual_link_velocity[2],
                                ADS_ServerData.ModuleData[i].actual_motor_velocity[2]);
                    }

                    if (m_dChartMode == 3)
                    {
                        float[] _targetPose = new float[3];
                        float[] _currentPose = new float[3];

                        for (int i = 0; i <= ADS_ServerData.m_log_cnt; i = i + 5)
                        {
                            _targetPose[0] = ADS_ServerData.ModuleData[i].cartesian_target_pose[0];
                            _targetPose[1] = ADS_ServerData.ModuleData[i].cartesian_target_pose[1];
                            _targetPose[2] = ADS_ServerData.ModuleData[i].cartesian_target_pose[2];

                            _currentPose[0] = ADS_ServerData.ModuleData[i].cartesian_current_pose[0];
                            _currentPose[1] = ADS_ServerData.ModuleData[i].cartesian_current_pose[1];
                            _currentPose[2] = ADS_ServerData.ModuleData[i].cartesian_current_pose[2];
                            float x = (float)ADS_ServerData.m_Cnt[i];
                            m_Chart.AddPoint3D(x, _targetPose, _currentPose);
                        }

                    }
                    */

                    // Joint1 Status Check
                    if (ADS_ServerData.ModuleData_Left[0].status_word[0] == 576)
                    {
                        pbAuxPow.Image = StatusOnImage;
                        pbJoint1Servo.Image = StatusOffImage;
                    }
                    else if (ADS_ServerData.ModuleData_Left[0].status_word[0] == 592)
                    {
                        pbAuxPow.Image = StatusOnImage;
                        pbMainPow.Image = StatusOnImage;
                        pbJoint1Servo.Image = StatusOffImage;

                    }
                    else if ((ADS_ServerData.ModuleData_Left[0].status_word[0] == 4663) || (ADS_ServerData.ModuleData_Left[0].status_word[0] == 5687) || (ADS_ServerData.ModuleData_Left[0].status_word[0] == 1591))
                    {
                        pbAuxPow.Image = StatusOnImage;
                        pbMainPow.Image = StatusOnImage;
                        pbJoint1Servo.Image = StatusOnImage;
                    }
                    else
                    {
                        pbJoint1Servo.Image = StatusOffImage;

                    }

                    if ((ADS_ServerData.ModuleData_Left[0].mode_of_operation[0] == 1) || (ADS_ServerData.TorquePosition_Mode == 1))
                    {
                        pbPositionMode.Image = StatusOnImage;
                        pbTorqueMode.Image = StatusOffImage;
                    }

                    else if ((ADS_ServerData.ModuleData_Left[0].mode_of_operation[0] == 10) || (ADS_ServerData.TorquePosition_Mode == 0))
                    {
                        pbPositionMode.Image = StatusOffImage;
                        pbTorqueMode.Image = StatusOnImage;
                    }

                    // Joint2 Status Check
                    if ((ADS_ServerData.ModuleData_Left[0].status_word[1] == 4663) || (ADS_ServerData.ModuleData_Left[0].status_word[1] == 5687) || (ADS_ServerData.ModuleData_Left[0].status_word[1] == 1591))
                    {
                        pbJoint2Servo.Image = StatusOnImage;
                    }
                    else
                    {
                        pbJoint2Servo.Image = StatusOffImage;
                    }

                    // Joint3 Status Check
                    if ((ADS_ServerData.ModuleData_Left[0].status_word[2] == 4663) || (ADS_ServerData.ModuleData_Left[0].status_word[2] == 5687) || (ADS_ServerData.ModuleData_Left[0].status_word[2] == 1591))
                    {
                        pbJoint3Servo.Image = StatusOnImage;
                    }
                    else
                    {
                        pbJoint3Servo.Image = StatusOffImage;
                    }

                    // Joint4 Status Check
                    if ((ADS_ServerData.ModuleData_Right[0].status_word[0] == 4663) || (ADS_ServerData.ModuleData_Right[0].status_word[0] == 5687) || (ADS_ServerData.ModuleData_Right[0].status_word[0] == 1591))
                    {
                        pbJoint4Servo.Image = StatusOnImage;
                    }
                    else
                    {
                        pbJoint4Servo.Image = StatusOffImage;
                    }

                    // Joint5 Status Check
                    if ((ADS_ServerData.ModuleData_Right[0].status_word[1] == 4663) || (ADS_ServerData.ModuleData_Right[0].status_word[1] == 5687) || (ADS_ServerData.ModuleData_Right[0].status_word[1] == 1591))
                    {
                        pbJoint5Servo.Image = StatusOnImage;
                    }
                    else
                    {
                        pbJoint5Servo.Image = StatusOffImage;
                    }

                    // Joint6 Status Check
                    if ((ADS_ServerData.ModuleData_Right[0].status_word[2] == 4663) || (ADS_ServerData.ModuleData_Right[0].status_word[2] == 5687) || (ADS_ServerData.ModuleData_Right[0].status_word[2] == 1591))
                    {
                        pbJoint6Servo.Image = StatusOnImage;
                    }
                    else
                    {
                        pbJoint6Servo.Image = StatusOffImage;
                    }


                    // Target Reached Check
                    if (ADS_ServerData.target_reached == 1)
                        pbTargetReached.Image = StatusOnImage;
                    else
                        pbTargetReached.Image = StatusOffImage;

                    // Gravity Mode Check

                    if (ADS_ServerData.m_dSystemMode == 0)
                        pbGravityMode.Image = StatusOnImage;
                    else
                        pbGravityMode.Image = StatusOffImage;


                    

                    


                    if (m_logging_flag)
                    {

                        string left_str;
                        string right_str;
                       

                        FileStream fs_left = new FileStream("logging_left.csv", FileMode.Append, FileAccess.Write);
                        FileStream fs_right = new FileStream("logging_right.csv", FileMode.Append, FileAccess.Write);


                        StreamWriter write_left = new StreamWriter(fs_left, System.Text.Encoding.UTF8);
                        StreamWriter write_right = new StreamWriter(fs_right, System.Text.Encoding.UTF8);


                        for (int i = 0; i <= ADS_ServerData.m_log_cnt; i++)
                        {

                            left_str = String.Format("{0:d},{1:0.000000},{2:0.000000},{3:0.000000},{4:0.000000},{5:0.000000},{6:0.000000},{7:0.000000},{8:0.000000},{9:0.000000},{10:0.000000},{11:0.000000},{12:0.000000},{13:0.000000},{14:0.000000},{15:0.000000},{16:0.000000},{17:0.000000},{18:0.000000},{19:0.000000},{20:0.000000},{21:0.000000},{22:0.000000},{23:0.000000},{24:0.000000},{25:0.000000},{26:0.000000},{27:0.000000},{28:0.000000},{29:0.000000},{30:0.000000},{31:0.000000},{32:0.000000},{33:0.000000}", ADS_ServerData.m_Cnt[i],
                                ADS_ServerData.ModuleData_Left[i].actual_motor_position[0], ADS_ServerData.ModuleData_Left[i].actual_link_position[0], ADS_ServerData.ModuleData_Left[i].target_position[0], ADS_ServerData.ModuleData_Left[i].actual_motor_velocity[0], ADS_ServerData.ModuleData_Left[i].actual_link_velocity[0], ADS_ServerData.ModuleData_Left[i].target_current[0], ADS_ServerData.ModuleData_Left[i].actual_current[0], ADS_ServerData.accel_time[0], ADS_ServerData.target_reach_time[0], ADS_ServerData.ModuleData_Left[i].cartesian_target_pose[0], ADS_ServerData.ModuleData_Left[i].cartesian_current_pose[0],
                                ADS_ServerData.ModuleData_Left[i].actual_motor_position[1], ADS_ServerData.ModuleData_Left[i].actual_link_position[1], ADS_ServerData.ModuleData_Left[i].target_position[1], ADS_ServerData.ModuleData_Left[i].actual_motor_velocity[1], ADS_ServerData.ModuleData_Left[i].actual_link_velocity[1], ADS_ServerData.ModuleData_Left[i].target_current[1], ADS_ServerData.ModuleData_Left[i].actual_current[1], ADS_ServerData.accel_time[1], ADS_ServerData.target_reach_time[1], ADS_ServerData.ModuleData_Left[i].cartesian_target_pose[1], ADS_ServerData.ModuleData_Left[i].cartesian_current_pose[1],
                                ADS_ServerData.ModuleData_Left[i].actual_motor_position[2], ADS_ServerData.ModuleData_Left[i].actual_link_position[2], ADS_ServerData.ModuleData_Left[i].target_position[2], ADS_ServerData.ModuleData_Left[i].actual_motor_velocity[2], ADS_ServerData.ModuleData_Left[i].actual_link_velocity[2], ADS_ServerData.ModuleData_Left[i].target_current[2], ADS_ServerData.ModuleData_Left[i].actual_current[2], ADS_ServerData.accel_time[2], ADS_ServerData.target_reach_time[2], ADS_ServerData.ModuleData_Left[i].cartesian_target_pose[2], ADS_ServerData.ModuleData_Left[i].cartesian_current_pose[2]);

                            right_str = String.Format("{0:d},{1:0.000000},{2:0.000000},{3:0.000000},{4:0.000000},{5:0.000000},{6:0.000000},{7:0.000000},{8:0.000000},{9:0.000000},{10:0.000000},{11:0.000000},{12:0.000000},{13:0.000000},{14:0.000000},{15:0.000000},{16:0.000000},{17:0.000000},{18:0.000000},{19:0.000000},{20:0.000000},{21:0.000000},{22:0.000000},{23:0.000000},{24:0.000000},{25:0.000000},{26:0.000000},{27:0.000000},{28:0.000000},{29:0.000000},{30:0.000000},{31:0.000000},{32:0.000000},{33:0.000000}", ADS_ServerData.m_Cnt[i],
                                ADS_ServerData.ModuleData_Right[i].actual_motor_position[0], ADS_ServerData.ModuleData_Right[i].actual_link_position[0], ADS_ServerData.ModuleData_Right[i].target_position[0], ADS_ServerData.ModuleData_Right[i].actual_motor_velocity[0], ADS_ServerData.ModuleData_Right[i].actual_link_velocity[0], ADS_ServerData.ModuleData_Right[i].target_current[0], ADS_ServerData.ModuleData_Right[i].actual_current[0], ADS_ServerData.accel_time[0], ADS_ServerData.target_reach_time[0], ADS_ServerData.ModuleData_Right[i].cartesian_target_pose[0], ADS_ServerData.ModuleData_Right[i].cartesian_current_pose[0],
                                ADS_ServerData.ModuleData_Right[i].actual_motor_position[1], ADS_ServerData.ModuleData_Right[i].actual_link_position[1], ADS_ServerData.ModuleData_Right[i].target_position[1], ADS_ServerData.ModuleData_Right[i].actual_motor_velocity[1], ADS_ServerData.ModuleData_Right[i].actual_link_velocity[1], ADS_ServerData.ModuleData_Right[i].target_current[1], ADS_ServerData.ModuleData_Right[i].actual_current[1], ADS_ServerData.accel_time[1], ADS_ServerData.target_reach_time[1], ADS_ServerData.ModuleData_Right[i].cartesian_target_pose[1], ADS_ServerData.ModuleData_Right[i].cartesian_current_pose[1],
                                ADS_ServerData.ModuleData_Right[i].actual_motor_position[2], ADS_ServerData.ModuleData_Right[i].actual_link_position[2], ADS_ServerData.ModuleData_Right[i].target_position[2], ADS_ServerData.ModuleData_Right[i].actual_motor_velocity[2], ADS_ServerData.ModuleData_Right[i].actual_link_velocity[2], ADS_ServerData.ModuleData_Right[i].target_current[2], ADS_ServerData.ModuleData_Right[i].actual_current[2], ADS_ServerData.accel_time[2], ADS_ServerData.target_reach_time[2], ADS_ServerData.ModuleData_Right[i].cartesian_target_pose[2], ADS_ServerData.ModuleData_Right[i].cartesian_current_pose[2]);

                            
                            write_left.WriteLine(left_str);
                            write_right.WriteLine(right_str);
                        }

                        write_left.Close();
                        write_right.Close();
                        
                    }

                   // tb_convert_current.Text = ((double.Parse(ADS_Input.ModuleData[0].actual_current.ToString()) * double.Parse(tb_continuous.Text)) / 1000).ToString();
                }
            }
            catch (Exception err)
            {
                Debug.Write(err.Message);
            }
        }


        private void btnServoOn_Click(object sender, EventArgs e)
        {
            try
            {
                AdsBinaryWriter binWriter = new AdsBinaryWriter(adsWriteStream);
                adsWriteStream.Position = 0;

                _tcClient.ReadWrite(0x4, 0x1, adsReadStream, adsWriteStream);
                timer1.Enabled = true;
                m_UpdateData = true;
            }

            catch (Exception err)
            {
                Debug.Write(err.Message);
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            try
            {
                _tcClient.ReadWrite(0x4, 0x3, adsReadStream, adsWriteStream);

            }

            catch (Exception err)
            {
                Debug.Write(err.Message);
            }
        }

        private void btnHoming_Click(object sender, EventArgs e)
        {
            try
            {
                

                _tcClient.ReadWrite(0x4, 0x2, adsReadStream, adsWriteStream);

            }

            catch (Exception err)
            {
                Debug.Write(err.Message);
            }
        }

        private void btnReady_Click(object sender, EventArgs e)
        {
            try
            {
                
                _tcClient.ReadWrite(0x4, 0x5, adsReadStream, adsWriteStream);

            }

            catch (Exception err)
            {
                Debug.Write(err.Message);
            }
        }

        private void btnEmergencyStop_Click(object sender, EventArgs e)
        {
            try
            {
                _tcClient.ReadWrite(0x4, 0x8, adsReadStream, adsWriteStream);

            }

            catch (Exception err)
            {
                Debug.Write(err.Message);
            }
        }

        private void btnDemoRun_Click(object sender, EventArgs e)
        {
            try
            {
                _tcClient.ReadWrite(0x4, 0x7, adsReadStream, adsWriteStream);

            }

            catch (Exception err)
            {
                Debug.Write(err.Message);
            }
        }

        private void btnMoveP2P_Click(object sender, EventArgs e)
        {

            try
            {
                _tcClient.ReadWrite(0x4, 0x6, adsReadStream, adsWriteStream);

            }

            catch (Exception err)
            {
                Debug.Write(err.Message);
            }

           /*
            AdsBinaryWriter binWriter = new AdsBinaryWriter(adsWriteStream);
            adsWriteStream.Position = 0;
            binWriter.Write(float.Parse(tbPx.Text));
            _tcClient.ReadWrite(0x4, 0x9, adsReadStream, adsWriteStream);

            AdsBinaryWriter binWriter_1 = new AdsBinaryWriter(adsWriteStream);            
            adsWriteStream.Position = 0;
            binWriter_1.Write(float.Parse(tbPy.Text));
            _tcClient.ReadWrite(0x4, 0xa, adsReadStream, adsWriteStream);

            AdsBinaryWriter binWriter_2 = new AdsBinaryWriter(adsWriteStream);          
            adsWriteStream.Position = 0;
            binWriter_2.Write(float.Parse(tbPz.Text));
            _tcClient.ReadWrite(0x4, 0xb, adsReadStream, adsWriteStream);
            */
        }

        private void bt_logging_data_Click(object sender, EventArgs e)
        {
           // m_Dt = DateTime.Now;
            FileInfo f_left = new FileInfo("logging_left.csv");
            FileInfo f_right = new FileInfo("logging_right.csv");


            StreamWriter write_left = f_left.CreateText();
            StreamWriter write_right = f_right.CreateText();
            write_left.WriteLine(" ");
            write_right.WriteLine(" ");
            //write.WriteLine("Time Stamp,1st Motor Pos,1st Link Pos, 1st Target Pos, 1st Motor Vel,1st Link Vel, 1st Target Tor, 1st Cur Tor, 1st Aceel Time, 1st Reach Time, 1st Target pose, 1st Current pose,2st Motor Pos, 2st Link Pos, 2st Target Pos, 2st Motor Vel,2st Link Vel, 2st Target Tor, 2st Cur Tor, 2st Aceel Time, 2st Reach Time, 2st Target pose, 2st Current pose, 3st Motor Pos,3st Link Pos, 3st Target Pos, 3st Motor Vel,3st Link Vel, 3st Target Tor, 3st Cur Tor, 3st Aceel Time, 3st Reach Time, 3st Target pose, 3st Current pose");



            write_left.Close();
            write_right.Close();

            // Logging State
            pbLogging.Image = StatusOnImage;

            m_logging_flag = true;
        }

        private void btnSetPosPIDGainParam_Click(object sender, EventArgs e)
        {

            
                /////////////////////////////////////////////////////////
                //
                // * Joint 1 Axis
                // 
                ////////////////////////////////////////////////////////    
                m_joint_index = 0;

                AdsBinaryWriter ADS_Writer = new AdsBinaryWriter(adsWriteStream);
                adsWriteStream.Position = 0;

                ADS_Writer.Write(m_joint_index);//int.Parse(tbPy.Text));
                _tcClient.ReadWrite(0x4, 0x9, adsReadStream, adsWriteStream);

                //P gain 설정 보내기               
                adsWriteStream.Position = 0;
                ADS_Writer.Write(float.Parse(tbPosPGain1.Text));
                _tcClient.ReadWrite(0x4, 0xa, adsReadStream, adsWriteStream);

                //I gain 설정 보내기               
                adsWriteStream.Position = 0;
                ADS_Writer.Write(float.Parse(tbPosIGain1.Text));
                _tcClient.ReadWrite(0x4, 0xb, adsReadStream, adsWriteStream);

                //D gain 설정 보내기               
                adsWriteStream.Position = 0;
                ADS_Writer.Write(float.Parse(tbPosDGain1.Text));
                _tcClient.ReadWrite(0x4, 0xc, adsReadStream, adsWriteStream);

                /////////////////////////////////////////////////////////
                //
                // * Joint 2 Axis
                // 
                ////////////////////////////////////////////////////////    
                m_joint_index = 1;
               
                adsWriteStream.Position = 0;

                ADS_Writer.Write(m_joint_index);//int.Parse(tbPy.Text));
                _tcClient.ReadWrite(0x4, 0x9, adsReadStream, adsWriteStream);

                //P gain 설정 보내기               
                adsWriteStream.Position = 0;
                ADS_Writer.Write(float.Parse(tbPosPGain2.Text));
                _tcClient.ReadWrite(0x4, 0xa, adsReadStream, adsWriteStream);

                //I gain 설정 보내기               
                adsWriteStream.Position = 0;
                ADS_Writer.Write(float.Parse(tbPosIGain2.Text));
                _tcClient.ReadWrite(0x4, 0xb, adsReadStream, adsWriteStream);

                //D gain 설정 보내기               
                adsWriteStream.Position = 0;
                ADS_Writer.Write(float.Parse(tbPosDGain2.Text));
                _tcClient.ReadWrite(0x4, 0xc, adsReadStream, adsWriteStream);

                /////////////////////////////////////////////////////////
                //
                // * Joint 3 Axis
                // 
                ////////////////////////////////////////////////////////    
                m_joint_index = 2;
                           
                adsWriteStream.Position = 0;

                ADS_Writer.Write(m_joint_index);//int.Parse(tbPy.Text));
                _tcClient.ReadWrite(0x4, 0x9, adsReadStream, adsWriteStream);

              
                //P gain 설정 보내기               
                adsWriteStream.Position = 0;
                ADS_Writer.Write(float.Parse(tbPosPGain3.Text));
                _tcClient.ReadWrite(0x4, 0xa, adsReadStream, adsWriteStream);

                //I gain 설정 보내기               
                adsWriteStream.Position = 0;
                ADS_Writer.Write(float.Parse(tbPosIGain3.Text));
                _tcClient.ReadWrite(0x4, 0xb, adsReadStream, adsWriteStream);

                //D gain 설정 보내기               
                adsWriteStream.Position = 0;
                ADS_Writer.Write(float.Parse(tbPosDGain3.Text));
                _tcClient.ReadWrite(0x4, 0xc, adsReadStream, adsWriteStream);
           
          

        }

        private void btnSetTorquePIDGainParam_Click(object sender, EventArgs e)
        {


            /////////////////////////////////////////////////////////
            //
            // * Joint 1 Axis
            // 
            ////////////////////////////////////////////////////////    
            m_joint_index = 0;

            AdsBinaryWriter ADS_Writer = new AdsBinaryWriter(adsWriteStream);
            adsWriteStream.Position = 0;

            ADS_Writer.Write(m_joint_index);//int.Parse(tbPy.Text));
            _tcClient.ReadWrite(0x4, 0x9, adsReadStream, adsWriteStream);

            //P gain 설정 보내기               
            adsWriteStream.Position = 0;
            ADS_Writer.Write(float.Parse(tbTorquePGain1.Text));
            _tcClient.ReadWrite(0x4, 0xd, adsReadStream, adsWriteStream);

            //I gain 설정 보내기               
            adsWriteStream.Position = 0;
            ADS_Writer.Write(float.Parse(tbTorqueIGain1.Text));
            _tcClient.ReadWrite(0x4, 0xe, adsReadStream, adsWriteStream);

            //D gain 설정 보내기               
            adsWriteStream.Position = 0;
            ADS_Writer.Write(float.Parse(tbTorqueDGain1.Text));
            _tcClient.ReadWrite(0x4, 0xf, adsReadStream, adsWriteStream);

            /////////////////////////////////////////////////////////
            //
            // * Joint 2 Axis
            // 
            ////////////////////////////////////////////////////////    
            m_joint_index = 1;
                       
            adsWriteStream.Position = 0;

            ADS_Writer.Write(m_joint_index);//int.Parse(tbPy.Text));
            _tcClient.ReadWrite(0x4, 0x9, adsReadStream, adsWriteStream);

            //P gain 설정 보내기               
            adsWriteStream.Position = 0;
            ADS_Writer.Write(float.Parse(tbTorquePGain2.Text));
            _tcClient.ReadWrite(0x4, 0xd, adsReadStream, adsWriteStream);

            //I gain 설정 보내기               
            adsWriteStream.Position = 0;
            ADS_Writer.Write(float.Parse(tbTorqueIGain2.Text));
            _tcClient.ReadWrite(0x4, 0xe, adsReadStream, adsWriteStream);

            //D gain 설정 보내기               
            adsWriteStream.Position = 0;
            ADS_Writer.Write(float.Parse(tbTorqueDGain3.Text));
            _tcClient.ReadWrite(0x4, 0xf, adsReadStream, adsWriteStream);

            /////////////////////////////////////////////////////////
            //
            // * Joint 3 Axis
            // 
            ////////////////////////////////////////////////////////    
            m_joint_index = 2;

            adsWriteStream.Position = 0;
            ADS_Writer.Write(m_joint_index);//int.Parse(tbPy.Text));
            _tcClient.ReadWrite(0x4, 0x9, adsReadStream, adsWriteStream);

            //P gain 설정 보내기               
            adsWriteStream.Position = 0;
            ADS_Writer.Write(float.Parse(tbTorquePGain3.Text));
            _tcClient.ReadWrite(0x4, 0xd, adsReadStream, adsWriteStream);

            //I gain 설정 보내기               
            adsWriteStream.Position = 0;
            ADS_Writer.Write(float.Parse(tbTorqueIGain3.Text));
            _tcClient.ReadWrite(0x4, 0xe, adsReadStream, adsWriteStream);

            //D gain 설정 보내기               
            adsWriteStream.Position = 0;
            ADS_Writer.Write(float.Parse(tbTorqueDGain3.Text));
            _tcClient.ReadWrite(0x4, 0xf, adsReadStream, adsWriteStream);
           
          
        }

        private void btnSetJointConstantParam_Click(object sender, EventArgs e)
        {
            /////////////////////////////////////////////////////////
            //
            // * Joint 1 Axis
            // 
            ////////////////////////////////////////////////////////    
            m_joint_index = 0;

            AdsBinaryWriter ADS_Writer = new AdsBinaryWriter(adsWriteStream);
            adsWriteStream.Position = 0;
            ADS_Writer.Write(m_joint_index);//int.Parse(tbPy.Text));
            _tcClient.ReadWrite(0x4, 0x9, adsReadStream, adsWriteStream);

            // Effie Const  
            adsWriteStream.Position = 0;
            ADS_Writer.Write(float.Parse(tbJointEfficiency1.Text));
            _tcClient.ReadWrite(0x4, 0x10, adsReadStream, adsWriteStream);

            // * Joint Torque Const
            adsWriteStream.Position = 0;
            ADS_Writer.Write(float.Parse(tbJointTorqueConstant1.Text));
            _tcClient.ReadWrite(0x4, 0x11, adsReadStream, adsWriteStream);
                        
            // * Joint Spring Const     
            adsWriteStream.Position = 0;
            ADS_Writer.Write(float.Parse(tbJointSpringConstant1.Text));
            _tcClient.ReadWrite(0x4, 0x12, adsReadStream, adsWriteStream);

            /////////////////////////////////////////////////////////
            //
            // * Joint 2 Axis
            // 
            ////////////////////////////////////////////////////////    
            m_joint_index = 1;

            adsWriteStream.Position = 0;
            ADS_Writer.Write(m_joint_index);//int.Parse(tbPy.Text));
            _tcClient.ReadWrite(0x4, 0x9, adsReadStream, adsWriteStream);

            // Effie Const  
            adsWriteStream.Position = 0;
            ADS_Writer.Write(float.Parse(tbJointEfficiency2.Text));
            _tcClient.ReadWrite(0x4, 0x10, adsReadStream, adsWriteStream);

            // * Joint Torque Const
            adsWriteStream.Position = 0;
            ADS_Writer.Write(float.Parse(tbJointTorqueConstant2.Text));
            _tcClient.ReadWrite(0x4, 0x11, adsReadStream, adsWriteStream);

            // * Joint Spring Const     
            adsWriteStream.Position = 0;
            ADS_Writer.Write(float.Parse(tbJointSpringConstant2.Text));
            _tcClient.ReadWrite(0x4, 0x12, adsReadStream, adsWriteStream);

            /////////////////////////////////////////////////////////
            //
            // * Joint 3 Axis
            // 
            ////////////////////////////////////////////////////////    
            m_joint_index = 2;

            adsWriteStream.Position = 0;
            ADS_Writer.Write(m_joint_index);//int.Parse(tbPy.Text));
            _tcClient.ReadWrite(0x4, 0x9, adsReadStream, adsWriteStream);

            // Effie Const  
            adsWriteStream.Position = 0;
            ADS_Writer.Write(float.Parse(tbJointEfficiency3.Text));
            _tcClient.ReadWrite(0x4, 0x10, adsReadStream, adsWriteStream);

            // * Joint Torque Const
            adsWriteStream.Position = 0;
            ADS_Writer.Write(float.Parse(tbJointTorqueConstant3.Text));
            _tcClient.ReadWrite(0x4, 0x11, adsReadStream, adsWriteStream);

            // * Joint Spring Const     
            adsWriteStream.Position = 0;
            ADS_Writer.Write(float.Parse(tbJointSpringConstant3.Text));
            _tcClient.ReadWrite(0x4, 0x12, adsReadStream, adsWriteStream);
          
        }

        private void btnSetJointParam_Click(object sender, EventArgs e)
        {
            m_SetRTorqueRangeFlag = true;
        }

        private void btnSetBufferValue_Click(object sender, EventArgs e)
        {
            m_SetLTorqueRangeFlag = true;
        }

        private void btLogStop_Click(object sender, EventArgs e)
        {
            m_logging_flag = false;

            // Logging State
            pbLogging.Image = StatusOffImage;

        }

        private void btnShowChart_Click(object sender, EventArgs e)
        {
            if (m_dChartMode < 3) m_Chart.SetMode(0);
            else if (m_dChartMode == 3) m_Chart.SetMode(1);
            m_Chart.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            m_dChartMode = cbChartMode.SelectedIndex;
            m_Chart.ClearChart();
            if (m_dChartMode < 3) m_Chart.SetMode(0);
            else if (m_dChartMode == 3) m_Chart.SetMode(1);
        }

        private void btnSetGravityMode_Click(object sender, EventArgs e)
        {
            btnSetGravityMode.ForeColor = System.Drawing.Color.Black;
            btnSetJointMode.ForeColor = System.Drawing.Color.LightGray;
            btnSetCartesianMode.ForeColor = System.Drawing.Color.LightGray;

            btnSetGravityMode.BackColor = System.Drawing.Color.YellowGreen;
            btnSetJointMode.BackColor = System.Drawing.Color.DarkGreen;
            btnSetCartesianMode.BackColor = System.Drawing.Color.DarkGreen;

            //Set Gravity Mode
            _tcClient.ReadWrite(0x4, 0x3, adsReadStream, adsWriteStream);
        }

        private void btnSetJointMode_Click(object sender, EventArgs e)
        {
            btnSetGravityMode.ForeColor = System.Drawing.Color.LightGray;
            btnSetJointMode.ForeColor = System.Drawing.Color.Black;
            btnSetCartesianMode.ForeColor = System.Drawing.Color.LightGray;

            btnSetGravityMode.BackColor = System.Drawing.Color.DarkGreen;
            btnSetJointMode.BackColor = System.Drawing.Color.YellowGreen;
            btnSetCartesianMode.BackColor = System.Drawing.Color.DarkGreen;
           
            //Set Joint Mode
            _tcClient.ReadWrite(0x4, 0x19, adsReadStream, adsWriteStream);
        }

        private void btnSetCartesianMode_Click(object sender, EventArgs e)
        {
            btnSetGravityMode.ForeColor = System.Drawing.Color.LightGray;
            btnSetJointMode.ForeColor = System.Drawing.Color.LightGray;
            btnSetCartesianMode.ForeColor = System.Drawing.Color.Black;

            btnSetGravityMode.BackColor = System.Drawing.Color.DarkGreen;
            btnSetJointMode.BackColor = System.Drawing.Color.DarkGreen;
            btnSetCartesianMode.BackColor = System.Drawing.Color.YellowGreen;

            //Set Cartesian Mode
            _tcClient.ReadWrite(0x4, 0x20, adsReadStream, adsWriteStream);

        }

        private void btnSetCartesianPIDGain_Click(object sender, EventArgs e)
        {
            /////////////////////////////////////////////////////////
            //
            // * SetCartesianPIDGain P Gain
            // 
            ////////////////////////////////////////////////////////    
            m_joint_index = 0;

            AdsBinaryWriter ADS_Writer = new AdsBinaryWriter(adsWriteStream);
            adsWriteStream.Position = 0;
            ADS_Writer.Write(m_joint_index);//int.Parse(tbPy.Text));
            _tcClient.ReadWrite(0x4, 0x9, adsReadStream, adsWriteStream);

            // Cartesian Px gain 
            adsWriteStream.Position = 0;
            ADS_Writer.Write(float.Parse(tbPosXPGain.Text));
            _tcClient.ReadWrite(0x4, 0x21, adsReadStream, adsWriteStream);

            // Cartesian Py gain 
            adsWriteStream.Position = 0;
            ADS_Writer.Write(float.Parse(tbPosYPGain.Text));
            _tcClient.ReadWrite(0x4, 0x22, adsReadStream, adsWriteStream);

            // Cartesian Pz gain 
            adsWriteStream.Position = 0;
            ADS_Writer.Write(float.Parse(tbPosZPGain.Text));
            _tcClient.ReadWrite(0x4, 0x23, adsReadStream, adsWriteStream);

            /////////////////////////////////////////////////////////
            //
            // * SetCartesianPIDGain I Gain
            // 
            ////////////////////////////////////////////////////////    
            m_joint_index = 1;

            adsWriteStream.Position = 0;
            ADS_Writer.Write(m_joint_index);//int.Parse(tbPy.Text));
            _tcClient.ReadWrite(0x4, 0x9, adsReadStream, adsWriteStream);

            // Cartesian Px gain 
            adsWriteStream.Position = 0;
            ADS_Writer.Write(float.Parse(tbPosXIGain.Text));
            _tcClient.ReadWrite(0x4, 0x21, adsReadStream, adsWriteStream);

            // Cartesian Py gain 
            adsWriteStream.Position = 0;
            ADS_Writer.Write(float.Parse(tbPosYIGain.Text));
            _tcClient.ReadWrite(0x4, 0x22, adsReadStream, adsWriteStream);

            // Cartesian Pz gain 
            adsWriteStream.Position = 0;
            ADS_Writer.Write(float.Parse(tbPosZIGain.Text));
            _tcClient.ReadWrite(0x4, 0x23, adsReadStream, adsWriteStream);

            /////////////////////////////////////////////////////////
            //
            // * SetCartesianPIDGain D Gain
            // 
            ////////////////////////////////////////////////////////    
            m_joint_index = 2;

            adsWriteStream.Position = 0;
            ADS_Writer.Write(m_joint_index);//int.Parse(tbPy.Text));
            _tcClient.ReadWrite(0x4, 0x9, adsReadStream, adsWriteStream);

            // Cartesian Px gain 
            adsWriteStream.Position = 0;
            ADS_Writer.Write(float.Parse(tbPosXDGain.Text));
            _tcClient.ReadWrite(0x4, 0x21, adsReadStream, adsWriteStream);

            // Cartesian Py gain 
            adsWriteStream.Position = 0;
            ADS_Writer.Write(float.Parse(tbPosYDGain.Text));
            _tcClient.ReadWrite(0x4, 0x22, adsReadStream, adsWriteStream);

            // Cartesian Pz gain 
            adsWriteStream.Position = 0;
            ADS_Writer.Write(float.Parse(tbPosZDGain.Text));
            _tcClient.ReadWrite(0x4, 0x23, adsReadStream, adsWriteStream);
          

        }

        private void btnSetCartesianTrajectoryParam_Click(object sender, EventArgs e)
        {
            m_SetRVelRangeFlag = true;
        }

        private void btnSetJointBuff_Click(object sender, EventArgs e)
        {
            m_SetLVelRangeFlag = true;
        }

        private void btnReadyPose_Click(object sender, EventArgs e)
        {
            tbRBuff1J1.Text = "0.4";
            tbRBuff2J1.Text = "0.0";
            tbRBuff3J1.Text = "0.4";
            //btnSetCartesianTrajectoryParam_Click(null, null);
            btnSetGravityMode_Click(null, null);
            btnSetCartesianMode_Click(null, null);
            btnMoveP2P_Click(null, null);

            
        }

        private void btnDemoPose1_Click(object sender, EventArgs e)
        {
            //tbTargetPosX.Text = "0.3";
            //tbTargetPosY.Text = "0.2";
            //tbTargetPosZ.Text = "0.1";
            tbRBuff1J1.Text = "0.3";
            tbRBuff2J1.Text = "0.0";
            tbRBuff3J1.Text = "0.2";
            //btnSetCartesianTrajectoryParam_Click(null, null);
            btnSetGravityMode_Click(null, null);
            btnSetCartesianMode_Click(null, null);
            btnMoveP2P_Click(null, null);
        }

        private void btnDemoPose2_Click(object sender, EventArgs e)
        {
            //tbTargetPosX.Text = "0.7";
            //tbTargetPosY.Text = "0.2";
            //tbTargetPosZ.Text = "0.1";
            tbRBuff1J1.Text = "0.5";
            tbRBuff2J1.Text = "0.0";
            tbRBuff3J1.Text = "0.4";
            //btnSetCartesianTrajectoryParam_Click(null, null);
            btnSetGravityMode_Click(null, null);
            btnSetCartesianMode_Click(null, null);
            btnMoveP2P_Click(null, null);
        }

        private void btnDemoPose3_Click(object sender, EventArgs e)
        {
            //tbTargetPosX.Text = "0.7";
            //tbTargetPosY.Text = "-0.2";
            //tbTargetPosZ.Text = "0.1";
            tbRBuff1J1.Text = "0.6";
            tbRBuff2J1.Text = "0.0";
            tbRBuff3J1.Text = "0.3";
            //btnSetCartesianTrajectoryParam_Click(null, null);
            btnSetGravityMode_Click(null, null);
            btnSetCartesianMode_Click(null, null);
            btnMoveP2P_Click(null, null);
        }

        private void btnDemoPose4_Click(object sender, EventArgs e)
        {
            //tbTargetPosX.Text = "0.3";
            //tbTargetPosY.Text = "-0.2";
            //tbTargetPosZ.Text = "0.1";
            tbRBuff1J1.Text = "0.5";
            tbRBuff2J1.Text = "0.0";
            tbRBuff3J1.Text = "0.4";
            //btnSetCartesianTrajectoryParam_Click(null, null);
            btnSetGravityMode_Click(null, null);
            btnSetCartesianMode_Click(null, null);
            btnMoveP2P_Click(null, null);
        }

        private void tbJointTorqueConstant1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbTorqueDGain2_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbTargetTimePy_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbBuff22_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbPort_TextChanged(object sender, EventArgs e)
        {

        }
       
        private void UDP_Connect_Click(object sender, EventArgs e)
        {

            if (UDP_connect_start == false)
            {
               
                ipaddress = tbIPadress.Text.ToString();
                listenPort = int.Parse(tbUDPport.Text);


                pbUDPconnection.Image = StatusOnImage;
                //UDP_connect_start = true;

                srv = new UdpClient(listenPort);
                endpoint = new IPEndPoint(IPAddress.Any, listenPort);

                receiveThread = new Thread(ReceiveData);
                receiveThread.IsBackground = true;
                receiveThread.Start();
            }
            else
            {
                pbUDPconnection.Image = StatusOffImage;
                srv.Close();
                receiveThread.Abort();
                receiveThread.Join();
                Close();
                
                UDP_connect_start = false;
            }
        }


    }
}

