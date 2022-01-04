using TwinCAT.Ads;
namespace adsClientVisu
{
    partial class form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tbPort = new System.Windows.Forms.TextBox();
            this.tbNetId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btConnect = new System.Windows.Forms.Button();
            this.btnServoOn = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tbLeftCurrent1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tbLeftVelocity1 = new System.Windows.Forms.TextBox();
            this.tbLeftPosion1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.btnHoming = new System.Windows.Forms.Button();
            this.btnEmergencyStop = new System.Windows.Forms.Button();
            this.btnDemoRun = new System.Windows.Forms.Button();
            this.btnReady = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.tbPx = new System.Windows.Forms.TextBox();
            this.tbPy = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbPz = new System.Windows.Forms.TextBox();
            this.btnMoveP2P = new System.Windows.Forms.Button();
            this.bt_logging_data = new System.Windows.Forms.Button();
            this.tbLeftPosion2 = new System.Windows.Forms.TextBox();
            this.tbLeftVelocity2 = new System.Windows.Forms.TextBox();
            this.tbLeftCurrent2 = new System.Windows.Forms.TextBox();
            this.tbLeftPosion3 = new System.Windows.Forms.TextBox();
            this.tbLeftVelocity3 = new System.Windows.Forms.TextBox();
            this.tbLeftCurrent3 = new System.Windows.Forms.TextBox();
            this.gbActualParam = new System.Windows.Forms.GroupBox();
            this.label36 = new System.Windows.Forms.Label();
            this.tbLeftABSPosion1 = new System.Windows.Forms.TextBox();
            this.label37 = new System.Windows.Forms.Label();
            this.tbLeftABSPosion2 = new System.Windows.Forms.TextBox();
            this.tbLeftABSPosion3 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.tbRightCurrent3 = new System.Windows.Forms.TextBox();
            this.tbRightCurrent2 = new System.Windows.Forms.TextBox();
            this.tbRightCurrent1 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.tbRightVelocity3 = new System.Windows.Forms.TextBox();
            this.tbRightVelocity2 = new System.Windows.Forms.TextBox();
            this.tbRightVelocity1 = new System.Windows.Forms.TextBox();
            this.tbRightPosion3 = new System.Windows.Forms.TextBox();
            this.tbRightPosion2 = new System.Windows.Forms.TextBox();
            this.tbRightPosion1 = new System.Windows.Forms.TextBox();
            this.gbTargetParam = new System.Windows.Forms.GroupBox();
            this.label79 = new System.Windows.Forms.Label();
            this.tbRightABSPosion1 = new System.Windows.Forms.TextBox();
            this.label80 = new System.Windows.Forms.Label();
            this.tbRightABSPosion2 = new System.Windows.Forms.TextBox();
            this.tbRightABSPosion3 = new System.Windows.Forms.TextBox();
            this.tbPosDGain3 = new System.Windows.Forms.TextBox();
            this.tbPosDGain2 = new System.Windows.Forms.TextBox();
            this.tbPosDGain1 = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.tbPosIGain3 = new System.Windows.Forms.TextBox();
            this.tbPosIGain2 = new System.Windows.Forms.TextBox();
            this.tbPosIGain1 = new System.Windows.Forms.TextBox();
            this.tbPosPGain3 = new System.Windows.Forms.TextBox();
            this.tbPosPGain2 = new System.Windows.Forms.TextBox();
            this.tbPosPGain1 = new System.Windows.Forms.TextBox();
            this.gbPositionPIDGain = new System.Windows.Forms.GroupBox();
            this.btnSetPosPIDGainParam = new System.Windows.Forms.Button();
            this.tbJointSpringConstant3 = new System.Windows.Forms.TextBox();
            this.tbJointSpringConstant2 = new System.Windows.Forms.TextBox();
            this.tbJointSpringConstant1 = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.tbJointTorqueConstant3 = new System.Windows.Forms.TextBox();
            this.tbJointTorqueConstant2 = new System.Windows.Forms.TextBox();
            this.tbJointTorqueConstant1 = new System.Windows.Forms.TextBox();
            this.tbJointEfficiency3 = new System.Windows.Forms.TextBox();
            this.tbJointEfficiency2 = new System.Windows.Forms.TextBox();
            this.tbJointEfficiency1 = new System.Windows.Forms.TextBox();
            this.gbConstantParam = new System.Windows.Forms.GroupBox();
            this.btnSetJointConstantParam = new System.Windows.Forms.Button();
            this.tbRBuff33 = new System.Windows.Forms.TextBox();
            this.tbRBuff32 = new System.Windows.Forms.TextBox();
            this.tbRBuff31 = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.tbRBuff23 = new System.Windows.Forms.TextBox();
            this.tbRBuff22 = new System.Windows.Forms.TextBox();
            this.tbRBuff21 = new System.Windows.Forms.TextBox();
            this.tbRBuff13 = new System.Windows.Forms.TextBox();
            this.tbRBuff12 = new System.Windows.Forms.TextBox();
            this.tbRBuff11 = new System.Windows.Forms.TextBox();
            this.gbJointTargetParam = new System.Windows.Forms.GroupBox();
            this.btnSetRBufferValue = new System.Windows.Forms.Button();
            this.tbLBuff33 = new System.Windows.Forms.TextBox();
            this.tbLBuff32 = new System.Windows.Forms.TextBox();
            this.tbLBuff31 = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.tbLBuff23 = new System.Windows.Forms.TextBox();
            this.tbLBuff22 = new System.Windows.Forms.TextBox();
            this.tbLBuff21 = new System.Windows.Forms.TextBox();
            this.tbLBuff13 = new System.Windows.Forms.TextBox();
            this.tbLBuff12 = new System.Windows.Forms.TextBox();
            this.tbLBuff11 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSetLBufferValue = new System.Windows.Forms.Button();
            this.btnShowGraph = new System.Windows.Forms.Button();
            this.tbTorqueDGain3 = new System.Windows.Forms.TextBox();
            this.tbTorqueDGain2 = new System.Windows.Forms.TextBox();
            this.tbTorqueDGain1 = new System.Windows.Forms.TextBox();
            this.label30 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.tbTorqueIGain3 = new System.Windows.Forms.TextBox();
            this.tbTorqueIGain2 = new System.Windows.Forms.TextBox();
            this.tbTorqueIGain1 = new System.Windows.Forms.TextBox();
            this.tbTorquePGain3 = new System.Windows.Forms.TextBox();
            this.tbTorquePGain2 = new System.Windows.Forms.TextBox();
            this.tbTorquePGain1 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSetTorquePIDGainParam = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tbBuffUpdate33 = new System.Windows.Forms.TextBox();
            this.tbBuffUpdate11 = new System.Windows.Forms.TextBox();
            this.tbBuffUpdate32 = new System.Windows.Forms.TextBox();
            this.tbBuffUpdate12 = new System.Windows.Forms.TextBox();
            this.tbBuffUpdate31 = new System.Windows.Forms.TextBox();
            this.tbBuffUpdate13 = new System.Windows.Forms.TextBox();
            this.label33 = new System.Windows.Forms.Label();
            this.tbBuffUpdate21 = new System.Windows.Forms.TextBox();
            this.label34 = new System.Windows.Forms.Label();
            this.tbBuffUpdate22 = new System.Windows.Forms.TextBox();
            this.label35 = new System.Windows.Forms.Label();
            this.tbBuffUpdate23 = new System.Windows.Forms.TextBox();
            this.btLogStop = new System.Windows.Forms.Button();
            this.tbLogCycle = new System.Windows.Forms.TextBox();
            this.label38 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.pbJoint6Servo = new System.Windows.Forms.PictureBox();
            this.pbJoint3Servo = new System.Windows.Forms.PictureBox();
            this.label77 = new System.Windows.Forms.Label();
            this.label51 = new System.Windows.Forms.Label();
            this.label76 = new System.Windows.Forms.Label();
            this.label75 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.label48 = new System.Windows.Forms.Label();
            this.pbJoint4Servo = new System.Windows.Forms.PictureBox();
            this.label49 = new System.Windows.Forms.Label();
            this.pbJoint1Servo = new System.Windows.Forms.PictureBox();
            this.pbConnect = new System.Windows.Forms.PictureBox();
            this.label41 = new System.Windows.Forms.Label();
            this.pbJoint5Servo = new System.Windows.Forms.PictureBox();
            this.label40 = new System.Windows.Forms.Label();
            this.pbJoint2Servo = new System.Windows.Forms.PictureBox();
            this.pbMainPow = new System.Windows.Forms.PictureBox();
            this.pbAuxPow = new System.Windows.Forms.PictureBox();
            this.pbLogging = new System.Windows.Forms.PictureBox();
            this.label43 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label50 = new System.Windows.Forms.Label();
            this.pbUpdateData = new System.Windows.Forms.PictureBox();
            this.label44 = new System.Windows.Forms.Label();
            this.label71 = new System.Windows.Forms.Label();
            this.label45 = new System.Windows.Forms.Label();
            this.label46 = new System.Windows.Forms.Label();
            this.label47 = new System.Windows.Forms.Label();
            this.pbTargetReached = new System.Windows.Forms.PictureBox();
            this.pbUDPconnection = new System.Windows.Forms.PictureBox();
            this.pbGravityMode = new System.Windows.Forms.PictureBox();
            this.pbTorqueMode = new System.Windows.Forms.PictureBox();
            this.pbPositionMode = new System.Windows.Forms.PictureBox();
            this.btnShowChart = new System.Windows.Forms.Button();
            this.cbChartMode = new System.Windows.Forms.ComboBox();
            this.btnSetGravityMode = new System.Windows.Forms.Button();
            this.btnSetJointMode = new System.Windows.Forms.Button();
            this.btnSetCartesianMode = new System.Windows.Forms.Button();
            this.tbPosZDGain = new System.Windows.Forms.TextBox();
            this.tbPosZIGain = new System.Windows.Forms.TextBox();
            this.tbPosZPGain = new System.Windows.Forms.TextBox();
            this.label52 = new System.Windows.Forms.Label();
            this.label53 = new System.Windows.Forms.Label();
            this.label54 = new System.Windows.Forms.Label();
            this.tbPosYDGain = new System.Windows.Forms.TextBox();
            this.tbPosYIGain = new System.Windows.Forms.TextBox();
            this.tbPosYPGain = new System.Windows.Forms.TextBox();
            this.tbPosXDGain = new System.Windows.Forms.TextBox();
            this.tbPosXIGain = new System.Windows.Forms.TextBox();
            this.tbPosXPGain = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnSetCartesianPIDGain = new System.Windows.Forms.Button();
            this.label57 = new System.Windows.Forms.Label();
            this.label56 = new System.Windows.Forms.Label();
            this.label55 = new System.Windows.Forms.Label();
            this.btnSetRJointBuff = new System.Windows.Forms.Button();
            this.tbRBuff3J3 = new System.Windows.Forms.TextBox();
            this.tbRBuff3J2 = new System.Windows.Forms.TextBox();
            this.tbRBuff3J1 = new System.Windows.Forms.TextBox();
            this.label61 = new System.Windows.Forms.Label();
            this.label62 = new System.Windows.Forms.Label();
            this.label63 = new System.Windows.Forms.Label();
            this.tbRBuff2J3 = new System.Windows.Forms.TextBox();
            this.tbRBuff2J2 = new System.Windows.Forms.TextBox();
            this.tbRBuff2J1 = new System.Windows.Forms.TextBox();
            this.tbRBuff1J3 = new System.Windows.Forms.TextBox();
            this.tbRBuff1J2 = new System.Windows.Forms.TextBox();
            this.tbRBuff1J1 = new System.Windows.Forms.TextBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.btnSetLJointBuff = new System.Windows.Forms.Button();
            this.tbLBuff3J3 = new System.Windows.Forms.TextBox();
            this.tbLBuff3J2 = new System.Windows.Forms.TextBox();
            this.tbLBuff3J1 = new System.Windows.Forms.TextBox();
            this.label67 = new System.Windows.Forms.Label();
            this.label68 = new System.Windows.Forms.Label();
            this.label69 = new System.Windows.Forms.Label();
            this.tbLBuff2J3 = new System.Windows.Forms.TextBox();
            this.tbLBuff2J2 = new System.Windows.Forms.TextBox();
            this.tbLBuff2J1 = new System.Windows.Forms.TextBox();
            this.tbLBuff1J3 = new System.Windows.Forms.TextBox();
            this.tbLBuff1J2 = new System.Windows.Forms.TextBox();
            this.tbLBuff1J1 = new System.Windows.Forms.TextBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.tbLeftPoseX = new System.Windows.Forms.TextBox();
            this.tbLeftPoseY = new System.Windows.Forms.TextBox();
            this.tbLeftPoseZ = new System.Windows.Forms.TextBox();
            this.label70 = new System.Windows.Forms.Label();
            this.btnDemoPose1 = new System.Windows.Forms.Button();
            this.btnDemoPose2 = new System.Windows.Forms.Button();
            this.btnDemoPose3 = new System.Windows.Forms.Button();
            this.btnDemoPose4 = new System.Windows.Forms.Button();
            this.btnReadyPose = new System.Windows.Forms.Button();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.UDP_Connect = new System.Windows.Forms.Button();
            this.label73 = new System.Windows.Forms.Label();
            this.label72 = new System.Windows.Forms.Label();
            this.tbUDPport = new System.Windows.Forms.TextBox();
            this.tbIPadress = new System.Windows.Forms.TextBox();
            this.tbLeftButton = new System.Windows.Forms.TextBox();
            this.label74 = new System.Windows.Forms.Label();
            this.label78 = new System.Windows.Forms.Label();
            this.tbRightPoseZ = new System.Windows.Forms.TextBox();
            this.tbRightPoseY = new System.Windows.Forms.TextBox();
            this.tbRightPoseX = new System.Windows.Forms.TextBox();
            this.label81 = new System.Windows.Forms.Label();
            this.tbRightButton = new System.Windows.Forms.TextBox();
            this.gbActualParam.SuspendLayout();
            this.gbTargetParam.SuspendLayout();
            this.gbPositionPIDGain.SuspendLayout();
            this.gbConstantParam.SuspendLayout();
            this.gbJointTargetParam.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbJoint6Servo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbJoint3Servo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbJoint4Servo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbJoint1Servo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbConnect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbJoint5Servo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbJoint2Servo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMainPow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAuxPow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogging)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUpdateData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTargetReached)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUDPconnection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGravityMode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTorqueMode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPositionMode)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbPort
            // 
            this.tbPort.Location = new System.Drawing.Point(182, 17);
            this.tbPort.Name = "tbPort";
            this.tbPort.Size = new System.Drawing.Size(56, 21);
            this.tbPort.TabIndex = 0;
            this.tbPort.Text = "0x8003";
            this.tbPort.TextChanged += new System.EventHandler(this.tbPort_TextChanged);
            // 
            // tbNetId
            // 
            this.tbNetId.Location = new System.Drawing.Point(59, 17);
            this.tbNetId.Name = "tbNetId";
            this.tbNetId.Size = new System.Drawing.Size(78, 21);
            this.tbNetId.TabIndex = 0;
            this.tbNetId.Text = "127.0.0.1.1.1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "NetID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(145, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "Port:";
            // 
            // btConnect
            // 
            this.btConnect.Location = new System.Drawing.Point(244, 17);
            this.btConnect.Name = "btConnect";
            this.btConnect.Size = new System.Drawing.Size(65, 21);
            this.btConnect.TabIndex = 3;
            this.btConnect.Text = "Connect";
            this.btConnect.UseVisualStyleBackColor = true;
            this.btConnect.Click += new System.EventHandler(this.btConnect_Click);
            // 
            // btnServoOn
            // 
            this.btnServoOn.Location = new System.Drawing.Point(16, 44);
            this.btnServoOn.Name = "btnServoOn";
            this.btnServoOn.Size = new System.Drawing.Size(85, 21);
            this.btnServoOn.TabIndex = 5;
            this.btnServoOn.Text = "Servo On";
            this.btnServoOn.UseVisualStyleBackColor = true;
            this.btnServoOn.Click += new System.EventHandler(this.btnServoOn_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tbLeftCurrent1
            // 
            this.tbLeftCurrent1.Location = new System.Drawing.Point(101, 210);
            this.tbLeftCurrent1.Name = "tbLeftCurrent1";
            this.tbLeftCurrent1.ReadOnly = true;
            this.tbLeftCurrent1.Size = new System.Drawing.Size(75, 21);
            this.tbLeftCurrent1.TabIndex = 36;
            this.tbLeftCurrent1.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(29, 192);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 12);
            this.label8.TabIndex = 35;
            this.label8.Text = "Velocity";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(29, 213);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 12);
            this.label11.TabIndex = 34;
            this.label11.Text = "Current";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(29, 171);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 12);
            this.label10.TabIndex = 33;
            this.label10.Text = "Position";
            // 
            // tbLeftVelocity1
            // 
            this.tbLeftVelocity1.Location = new System.Drawing.Point(101, 189);
            this.tbLeftVelocity1.Name = "tbLeftVelocity1";
            this.tbLeftVelocity1.ReadOnly = true;
            this.tbLeftVelocity1.Size = new System.Drawing.Size(75, 21);
            this.tbLeftVelocity1.TabIndex = 32;
            this.tbLeftVelocity1.Text = "0";
            // 
            // tbLeftPosion1
            // 
            this.tbLeftPosion1.Location = new System.Drawing.Point(101, 168);
            this.tbLeftPosion1.Name = "tbLeftPosion1";
            this.tbLeftPosion1.ReadOnly = true;
            this.tbLeftPosion1.Size = new System.Drawing.Size(75, 21);
            this.tbLeftPosion1.TabIndex = 31;
            this.tbLeftPosion1.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(332, 171);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 12);
            this.label6.TabIndex = 39;
            this.label6.Text = "Count";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(332, 192);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 12);
            this.label12.TabIndex = 40;
            this.label12.Text = "Count/sec";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(332, 213);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(64, 12);
            this.label20.TabIndex = 39;
            this.label20.Text = "Command";
            // 
            // btnHoming
            // 
            this.btnHoming.Location = new System.Drawing.Point(16, 72);
            this.btnHoming.Name = "btnHoming";
            this.btnHoming.Size = new System.Drawing.Size(85, 21);
            this.btnHoming.TabIndex = 5;
            this.btnHoming.Text = "Homing";
            this.btnHoming.UseVisualStyleBackColor = true;
            this.btnHoming.Click += new System.EventHandler(this.btnHoming_Click);
            // 
            // btnEmergencyStop
            // 
            this.btnEmergencyStop.Location = new System.Drawing.Point(207, 71);
            this.btnEmergencyStop.Name = "btnEmergencyStop";
            this.btnEmergencyStop.Size = new System.Drawing.Size(98, 48);
            this.btnEmergencyStop.TabIndex = 25;
            this.btnEmergencyStop.Text = "Emergency \r\n\r\nStop";
            this.btnEmergencyStop.UseVisualStyleBackColor = true;
            this.btnEmergencyStop.Click += new System.EventHandler(this.btnEmergencyStop_Click);
            // 
            // btnDemoRun
            // 
            this.btnDemoRun.Location = new System.Drawing.Point(322, 72);
            this.btnDemoRun.Name = "btnDemoRun";
            this.btnDemoRun.Size = new System.Drawing.Size(75, 48);
            this.btnDemoRun.TabIndex = 5;
            this.btnDemoRun.Text = "Domo Run";
            this.btnDemoRun.UseVisualStyleBackColor = true;
            this.btnDemoRun.Click += new System.EventHandler(this.btnDemoRun_Click);
            // 
            // btnReady
            // 
            this.btnReady.Location = new System.Drawing.Point(16, 98);
            this.btnReady.Name = "btnReady";
            this.btnReady.Size = new System.Drawing.Size(85, 21);
            this.btnReady.TabIndex = 5;
            this.btnReady.Text = "Ready";
            this.btnReady.UseVisualStyleBackColor = true;
            this.btnReady.Click += new System.EventHandler(this.btnReady_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(118, 44);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(187, 21);
            this.btnStop.TabIndex = 53;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // tbPx
            // 
            this.tbPx.Location = new System.Drawing.Point(337, 12);
            this.tbPx.Name = "tbPx";
            this.tbPx.Size = new System.Drawing.Size(54, 21);
            this.tbPx.TabIndex = 31;
            this.tbPx.Text = "0.4";
            // 
            // tbPy
            // 
            this.tbPy.Location = new System.Drawing.Point(337, 33);
            this.tbPy.Name = "tbPy";
            this.tbPy.Size = new System.Drawing.Size(54, 21);
            this.tbPy.TabIndex = 32;
            this.tbPy.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(313, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 12);
            this.label3.TabIndex = 33;
            this.label3.Text = "Px:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(313, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 12);
            this.label4.TabIndex = 34;
            this.label4.Text = "Pz:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(313, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 12);
            this.label5.TabIndex = 35;
            this.label5.Text = "Py:";
            // 
            // tbPz
            // 
            this.tbPz.Location = new System.Drawing.Point(337, 54);
            this.tbPz.Name = "tbPz";
            this.tbPz.Size = new System.Drawing.Size(54, 21);
            this.tbPz.TabIndex = 36;
            this.tbPz.Text = "0.4";
            // 
            // btnMoveP2P
            // 
            this.btnMoveP2P.Location = new System.Drawing.Point(118, 71);
            this.btnMoveP2P.Name = "btnMoveP2P";
            this.btnMoveP2P.Size = new System.Drawing.Size(83, 48);
            this.btnMoveP2P.TabIndex = 54;
            this.btnMoveP2P.Text = "Move";
            this.btnMoveP2P.UseVisualStyleBackColor = true;
            this.btnMoveP2P.Click += new System.EventHandler(this.btnMoveP2P_Click);
            // 
            // bt_logging_data
            // 
            this.bt_logging_data.Location = new System.Drawing.Point(1242, 248);
            this.bt_logging_data.Name = "bt_logging_data";
            this.bt_logging_data.Size = new System.Drawing.Size(84, 37);
            this.bt_logging_data.TabIndex = 55;
            this.bt_logging_data.Text = "Logging";
            this.bt_logging_data.UseVisualStyleBackColor = true;
            this.bt_logging_data.Click += new System.EventHandler(this.bt_logging_data_Click);
            // 
            // tbLeftPosion2
            // 
            this.tbLeftPosion2.Location = new System.Drawing.Point(177, 168);
            this.tbLeftPosion2.Name = "tbLeftPosion2";
            this.tbLeftPosion2.ReadOnly = true;
            this.tbLeftPosion2.Size = new System.Drawing.Size(75, 21);
            this.tbLeftPosion2.TabIndex = 31;
            this.tbLeftPosion2.Text = "0";
            // 
            // tbLeftVelocity2
            // 
            this.tbLeftVelocity2.Location = new System.Drawing.Point(177, 189);
            this.tbLeftVelocity2.Name = "tbLeftVelocity2";
            this.tbLeftVelocity2.ReadOnly = true;
            this.tbLeftVelocity2.Size = new System.Drawing.Size(75, 21);
            this.tbLeftVelocity2.TabIndex = 32;
            this.tbLeftVelocity2.Text = "0";
            // 
            // tbLeftCurrent2
            // 
            this.tbLeftCurrent2.Location = new System.Drawing.Point(177, 210);
            this.tbLeftCurrent2.Name = "tbLeftCurrent2";
            this.tbLeftCurrent2.ReadOnly = true;
            this.tbLeftCurrent2.Size = new System.Drawing.Size(75, 21);
            this.tbLeftCurrent2.TabIndex = 36;
            this.tbLeftCurrent2.Text = "0";
            // 
            // tbLeftPosion3
            // 
            this.tbLeftPosion3.Location = new System.Drawing.Point(254, 168);
            this.tbLeftPosion3.Name = "tbLeftPosion3";
            this.tbLeftPosion3.ReadOnly = true;
            this.tbLeftPosion3.Size = new System.Drawing.Size(75, 21);
            this.tbLeftPosion3.TabIndex = 31;
            this.tbLeftPosion3.Text = "0";
            // 
            // tbLeftVelocity3
            // 
            this.tbLeftVelocity3.Location = new System.Drawing.Point(254, 189);
            this.tbLeftVelocity3.Name = "tbLeftVelocity3";
            this.tbLeftVelocity3.ReadOnly = true;
            this.tbLeftVelocity3.Size = new System.Drawing.Size(75, 21);
            this.tbLeftVelocity3.TabIndex = 32;
            this.tbLeftVelocity3.Text = "0";
            // 
            // tbLeftCurrent3
            // 
            this.tbLeftCurrent3.Location = new System.Drawing.Point(254, 210);
            this.tbLeftCurrent3.Name = "tbLeftCurrent3";
            this.tbLeftCurrent3.ReadOnly = true;
            this.tbLeftCurrent3.Size = new System.Drawing.Size(75, 21);
            this.tbLeftCurrent3.TabIndex = 36;
            this.tbLeftCurrent3.Text = "0";
            // 
            // gbActualParam
            // 
            this.gbActualParam.Controls.Add(this.label36);
            this.gbActualParam.Controls.Add(this.tbLeftABSPosion1);
            this.gbActualParam.Controls.Add(this.label37);
            this.gbActualParam.Controls.Add(this.tbLeftABSPosion2);
            this.gbActualParam.Controls.Add(this.tbLeftABSPosion3);
            this.gbActualParam.Location = new System.Drawing.Point(16, 125);
            this.gbActualParam.Name = "gbActualParam";
            this.gbActualParam.Size = new System.Drawing.Size(398, 115);
            this.gbActualParam.TabIndex = 56;
            this.gbActualParam.TabStop = false;
            this.gbActualParam.Text = "Left PVC";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(316, 21);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(38, 12);
            this.label36.TabIndex = 145;
            this.label36.Text = "Count";
            // 
            // tbLeftABSPosion1
            // 
            this.tbLeftABSPosion1.Location = new System.Drawing.Point(85, 18);
            this.tbLeftABSPosion1.Name = "tbLeftABSPosion1";
            this.tbLeftABSPosion1.ReadOnly = true;
            this.tbLeftABSPosion1.Size = new System.Drawing.Size(75, 21);
            this.tbLeftABSPosion1.TabIndex = 143;
            this.tbLeftABSPosion1.Text = "0";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(13, 21);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(55, 12);
            this.label37.TabIndex = 144;
            this.label37.Text = "ABS Pos";
            // 
            // tbLeftABSPosion2
            // 
            this.tbLeftABSPosion2.Location = new System.Drawing.Point(161, 18);
            this.tbLeftABSPosion2.Name = "tbLeftABSPosion2";
            this.tbLeftABSPosion2.ReadOnly = true;
            this.tbLeftABSPosion2.Size = new System.Drawing.Size(75, 21);
            this.tbLeftABSPosion2.TabIndex = 142;
            this.tbLeftABSPosion2.Text = "0";
            // 
            // tbLeftABSPosion3
            // 
            this.tbLeftABSPosion3.Location = new System.Drawing.Point(238, 18);
            this.tbLeftABSPosion3.Name = "tbLeftABSPosion3";
            this.tbLeftABSPosion3.ReadOnly = true;
            this.tbLeftABSPosion3.Size = new System.Drawing.Size(75, 21);
            this.tbLeftABSPosion3.TabIndex = 141;
            this.tbLeftABSPosion3.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(332, 310);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 71;
            this.label7.Text = "Count/sec";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(332, 331);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 12);
            this.label9.TabIndex = 69;
            this.label9.Text = "Command";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(332, 289);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(38, 12);
            this.label13.TabIndex = 70;
            this.label13.Text = "Count";
            // 
            // tbRightCurrent3
            // 
            this.tbRightCurrent3.Location = new System.Drawing.Point(254, 328);
            this.tbRightCurrent3.Name = "tbRightCurrent3";
            this.tbRightCurrent3.ReadOnly = true;
            this.tbRightCurrent3.Size = new System.Drawing.Size(75, 21);
            this.tbRightCurrent3.TabIndex = 66;
            this.tbRightCurrent3.Text = "0";
            // 
            // tbRightCurrent2
            // 
            this.tbRightCurrent2.Location = new System.Drawing.Point(177, 328);
            this.tbRightCurrent2.Name = "tbRightCurrent2";
            this.tbRightCurrent2.ReadOnly = true;
            this.tbRightCurrent2.Size = new System.Drawing.Size(75, 21);
            this.tbRightCurrent2.TabIndex = 67;
            this.tbRightCurrent2.Text = "0";
            // 
            // tbRightCurrent1
            // 
            this.tbRightCurrent1.Location = new System.Drawing.Point(101, 328);
            this.tbRightCurrent1.Name = "tbRightCurrent1";
            this.tbRightCurrent1.ReadOnly = true;
            this.tbRightCurrent1.Size = new System.Drawing.Size(75, 21);
            this.tbRightCurrent1.TabIndex = 68;
            this.tbRightCurrent1.Text = "0";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(29, 310);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(50, 12);
            this.label14.TabIndex = 65;
            this.label14.Text = "Velocity";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(29, 331);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(46, 12);
            this.label15.TabIndex = 64;
            this.label15.Text = "Current";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(29, 289);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(50, 12);
            this.label16.TabIndex = 63;
            this.label16.Text = "Position";
            // 
            // tbRightVelocity3
            // 
            this.tbRightVelocity3.Location = new System.Drawing.Point(254, 307);
            this.tbRightVelocity3.Name = "tbRightVelocity3";
            this.tbRightVelocity3.ReadOnly = true;
            this.tbRightVelocity3.Size = new System.Drawing.Size(75, 21);
            this.tbRightVelocity3.TabIndex = 60;
            this.tbRightVelocity3.Text = "0";
            // 
            // tbRightVelocity2
            // 
            this.tbRightVelocity2.Location = new System.Drawing.Point(177, 307);
            this.tbRightVelocity2.Name = "tbRightVelocity2";
            this.tbRightVelocity2.ReadOnly = true;
            this.tbRightVelocity2.Size = new System.Drawing.Size(75, 21);
            this.tbRightVelocity2.TabIndex = 61;
            this.tbRightVelocity2.Text = "0";
            // 
            // tbRightVelocity1
            // 
            this.tbRightVelocity1.Location = new System.Drawing.Point(101, 307);
            this.tbRightVelocity1.Name = "tbRightVelocity1";
            this.tbRightVelocity1.ReadOnly = true;
            this.tbRightVelocity1.Size = new System.Drawing.Size(75, 21);
            this.tbRightVelocity1.TabIndex = 62;
            this.tbRightVelocity1.Text = "0";
            // 
            // tbRightPosion3
            // 
            this.tbRightPosion3.Location = new System.Drawing.Point(254, 286);
            this.tbRightPosion3.Name = "tbRightPosion3";
            this.tbRightPosion3.ReadOnly = true;
            this.tbRightPosion3.Size = new System.Drawing.Size(75, 21);
            this.tbRightPosion3.TabIndex = 57;
            this.tbRightPosion3.Text = "0";
            // 
            // tbRightPosion2
            // 
            this.tbRightPosion2.Location = new System.Drawing.Point(177, 286);
            this.tbRightPosion2.Name = "tbRightPosion2";
            this.tbRightPosion2.ReadOnly = true;
            this.tbRightPosion2.Size = new System.Drawing.Size(75, 21);
            this.tbRightPosion2.TabIndex = 58;
            this.tbRightPosion2.Text = "0";
            // 
            // tbRightPosion1
            // 
            this.tbRightPosion1.Location = new System.Drawing.Point(101, 286);
            this.tbRightPosion1.Name = "tbRightPosion1";
            this.tbRightPosion1.ReadOnly = true;
            this.tbRightPosion1.Size = new System.Drawing.Size(75, 21);
            this.tbRightPosion1.TabIndex = 59;
            this.tbRightPosion1.Text = "0";
            // 
            // gbTargetParam
            // 
            this.gbTargetParam.Controls.Add(this.label79);
            this.gbTargetParam.Controls.Add(this.tbRightABSPosion1);
            this.gbTargetParam.Controls.Add(this.label80);
            this.gbTargetParam.Controls.Add(this.tbRightABSPosion2);
            this.gbTargetParam.Controls.Add(this.tbRightABSPosion3);
            this.gbTargetParam.Location = new System.Drawing.Point(16, 244);
            this.gbTargetParam.Name = "gbTargetParam";
            this.gbTargetParam.Size = new System.Drawing.Size(398, 120);
            this.gbTargetParam.TabIndex = 72;
            this.gbTargetParam.TabStop = false;
            this.gbTargetParam.Text = "Right PVC";
            // 
            // label79
            // 
            this.label79.AutoSize = true;
            this.label79.Location = new System.Drawing.Point(316, 17);
            this.label79.Name = "label79";
            this.label79.Size = new System.Drawing.Size(38, 12);
            this.label79.TabIndex = 150;
            this.label79.Text = "Count";
            // 
            // tbRightABSPosion1
            // 
            this.tbRightABSPosion1.Location = new System.Drawing.Point(85, 14);
            this.tbRightABSPosion1.Name = "tbRightABSPosion1";
            this.tbRightABSPosion1.ReadOnly = true;
            this.tbRightABSPosion1.Size = new System.Drawing.Size(75, 21);
            this.tbRightABSPosion1.TabIndex = 148;
            this.tbRightABSPosion1.Text = "0";
            // 
            // label80
            // 
            this.label80.AutoSize = true;
            this.label80.Location = new System.Drawing.Point(13, 17);
            this.label80.Name = "label80";
            this.label80.Size = new System.Drawing.Size(55, 12);
            this.label80.TabIndex = 149;
            this.label80.Text = "ABS Pos";
            // 
            // tbRightABSPosion2
            // 
            this.tbRightABSPosion2.Location = new System.Drawing.Point(161, 14);
            this.tbRightABSPosion2.Name = "tbRightABSPosion2";
            this.tbRightABSPosion2.ReadOnly = true;
            this.tbRightABSPosion2.Size = new System.Drawing.Size(75, 21);
            this.tbRightABSPosion2.TabIndex = 147;
            this.tbRightABSPosion2.Text = "0";
            // 
            // tbRightABSPosion3
            // 
            this.tbRightABSPosion3.Location = new System.Drawing.Point(238, 14);
            this.tbRightABSPosion3.Name = "tbRightABSPosion3";
            this.tbRightABSPosion3.ReadOnly = true;
            this.tbRightABSPosion3.Size = new System.Drawing.Size(75, 21);
            this.tbRightABSPosion3.TabIndex = 146;
            this.tbRightABSPosion3.Text = "0";
            // 
            // tbPosDGain3
            // 
            this.tbPosDGain3.Location = new System.Drawing.Point(254, 432);
            this.tbPosDGain3.Name = "tbPosDGain3";
            this.tbPosDGain3.Size = new System.Drawing.Size(75, 21);
            this.tbPosDGain3.TabIndex = 82;
            this.tbPosDGain3.Text = "0";
            // 
            // tbPosDGain2
            // 
            this.tbPosDGain2.Location = new System.Drawing.Point(177, 432);
            this.tbPosDGain2.Name = "tbPosDGain2";
            this.tbPosDGain2.Size = new System.Drawing.Size(75, 21);
            this.tbPosDGain2.TabIndex = 83;
            this.tbPosDGain2.Text = "0";
            // 
            // tbPosDGain1
            // 
            this.tbPosDGain1.Location = new System.Drawing.Point(101, 432);
            this.tbPosDGain1.Name = "tbPosDGain1";
            this.tbPosDGain1.Size = new System.Drawing.Size(75, 21);
            this.tbPosDGain1.TabIndex = 84;
            this.tbPosDGain1.Text = "0";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(29, 414);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(38, 12);
            this.label21.TabIndex = 81;
            this.label21.Text = "I Gain";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(29, 435);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(43, 12);
            this.label22.TabIndex = 80;
            this.label22.Text = "D Gain";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(29, 393);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(43, 12);
            this.label23.TabIndex = 79;
            this.label23.Text = "P Gain";
            // 
            // tbPosIGain3
            // 
            this.tbPosIGain3.Location = new System.Drawing.Point(254, 411);
            this.tbPosIGain3.Name = "tbPosIGain3";
            this.tbPosIGain3.Size = new System.Drawing.Size(75, 21);
            this.tbPosIGain3.TabIndex = 76;
            this.tbPosIGain3.Text = "0";
            // 
            // tbPosIGain2
            // 
            this.tbPosIGain2.Location = new System.Drawing.Point(177, 411);
            this.tbPosIGain2.Name = "tbPosIGain2";
            this.tbPosIGain2.Size = new System.Drawing.Size(75, 21);
            this.tbPosIGain2.TabIndex = 77;
            this.tbPosIGain2.Text = "0";
            // 
            // tbPosIGain1
            // 
            this.tbPosIGain1.Location = new System.Drawing.Point(101, 411);
            this.tbPosIGain1.Name = "tbPosIGain1";
            this.tbPosIGain1.Size = new System.Drawing.Size(75, 21);
            this.tbPosIGain1.TabIndex = 78;
            this.tbPosIGain1.Text = "0";
            // 
            // tbPosPGain3
            // 
            this.tbPosPGain3.Location = new System.Drawing.Point(254, 390);
            this.tbPosPGain3.Name = "tbPosPGain3";
            this.tbPosPGain3.Size = new System.Drawing.Size(75, 21);
            this.tbPosPGain3.TabIndex = 73;
            this.tbPosPGain3.Text = "0";
            // 
            // tbPosPGain2
            // 
            this.tbPosPGain2.Location = new System.Drawing.Point(177, 390);
            this.tbPosPGain2.Name = "tbPosPGain2";
            this.tbPosPGain2.Size = new System.Drawing.Size(75, 21);
            this.tbPosPGain2.TabIndex = 74;
            this.tbPosPGain2.Text = "0";
            // 
            // tbPosPGain1
            // 
            this.tbPosPGain1.Location = new System.Drawing.Point(101, 390);
            this.tbPosPGain1.Name = "tbPosPGain1";
            this.tbPosPGain1.Size = new System.Drawing.Size(75, 21);
            this.tbPosPGain1.TabIndex = 75;
            this.tbPosPGain1.Text = "0";
            // 
            // gbPositionPIDGain
            // 
            this.gbPositionPIDGain.Controls.Add(this.btnSetPosPIDGainParam);
            this.gbPositionPIDGain.Location = new System.Drawing.Point(16, 370);
            this.gbPositionPIDGain.Name = "gbPositionPIDGain";
            this.gbPositionPIDGain.Size = new System.Drawing.Size(398, 93);
            this.gbPositionPIDGain.TabIndex = 88;
            this.gbPositionPIDGain.TabStop = false;
            this.gbPositionPIDGain.Text = "Position PID Gain Param";
            // 
            // btnSetPosPIDGainParam
            // 
            this.btnSetPosPIDGainParam.Location = new System.Drawing.Point(320, 20);
            this.btnSetPosPIDGainParam.Name = "btnSetPosPIDGainParam";
            this.btnSetPosPIDGainParam.Size = new System.Drawing.Size(72, 63);
            this.btnSetPosPIDGainParam.TabIndex = 0;
            this.btnSetPosPIDGainParam.Text = "Set\r\n\r\nPID Gain";
            this.btnSetPosPIDGainParam.UseVisualStyleBackColor = true;
            this.btnSetPosPIDGainParam.Click += new System.EventHandler(this.btnSetPosPIDGainParam_Click);
            // 
            // tbJointSpringConstant3
            // 
            this.tbJointSpringConstant3.Location = new System.Drawing.Point(659, 309);
            this.tbJointSpringConstant3.Name = "tbJointSpringConstant3";
            this.tbJointSpringConstant3.Size = new System.Drawing.Size(75, 21);
            this.tbJointSpringConstant3.TabIndex = 98;
            this.tbJointSpringConstant3.Text = "1700";
            // 
            // tbJointSpringConstant2
            // 
            this.tbJointSpringConstant2.Location = new System.Drawing.Point(582, 309);
            this.tbJointSpringConstant2.Name = "tbJointSpringConstant2";
            this.tbJointSpringConstant2.Size = new System.Drawing.Size(75, 21);
            this.tbJointSpringConstant2.TabIndex = 99;
            this.tbJointSpringConstant2.Text = "1700";
            // 
            // tbJointSpringConstant1
            // 
            this.tbJointSpringConstant1.Location = new System.Drawing.Point(506, 309);
            this.tbJointSpringConstant1.Name = "tbJointSpringConstant1";
            this.tbJointSpringConstant1.Size = new System.Drawing.Size(75, 21);
            this.tbJointSpringConstant1.TabIndex = 100;
            this.tbJointSpringConstant1.Text = "1700";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(434, 291);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(45, 12);
            this.label17.TabIndex = 97;
            this.label17.Text = "Torque";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(434, 312);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(41, 12);
            this.label18.TabIndex = 96;
            this.label18.Text = "Spring";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(434, 270);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(60, 12);
            this.label19.TabIndex = 95;
            this.label19.Text = "Efficiency";
            // 
            // tbJointTorqueConstant3
            // 
            this.tbJointTorqueConstant3.Location = new System.Drawing.Point(659, 288);
            this.tbJointTorqueConstant3.Name = "tbJointTorqueConstant3";
            this.tbJointTorqueConstant3.Size = new System.Drawing.Size(75, 21);
            this.tbJointTorqueConstant3.TabIndex = 92;
            this.tbJointTorqueConstant3.Text = "0.097";
            // 
            // tbJointTorqueConstant2
            // 
            this.tbJointTorqueConstant2.Location = new System.Drawing.Point(582, 288);
            this.tbJointTorqueConstant2.Name = "tbJointTorqueConstant2";
            this.tbJointTorqueConstant2.Size = new System.Drawing.Size(75, 21);
            this.tbJointTorqueConstant2.TabIndex = 93;
            this.tbJointTorqueConstant2.Text = "0.097";
            // 
            // tbJointTorqueConstant1
            // 
            this.tbJointTorqueConstant1.Location = new System.Drawing.Point(506, 288);
            this.tbJointTorqueConstant1.Name = "tbJointTorqueConstant1";
            this.tbJointTorqueConstant1.Size = new System.Drawing.Size(75, 21);
            this.tbJointTorqueConstant1.TabIndex = 94;
            this.tbJointTorqueConstant1.Text = "0.097";
            this.tbJointTorqueConstant1.TextChanged += new System.EventHandler(this.tbJointTorqueConstant1_TextChanged);
            // 
            // tbJointEfficiency3
            // 
            this.tbJointEfficiency3.Location = new System.Drawing.Point(659, 267);
            this.tbJointEfficiency3.Name = "tbJointEfficiency3";
            this.tbJointEfficiency3.Size = new System.Drawing.Size(75, 21);
            this.tbJointEfficiency3.TabIndex = 89;
            this.tbJointEfficiency3.Text = "0.7";
            // 
            // tbJointEfficiency2
            // 
            this.tbJointEfficiency2.Location = new System.Drawing.Point(582, 267);
            this.tbJointEfficiency2.Name = "tbJointEfficiency2";
            this.tbJointEfficiency2.Size = new System.Drawing.Size(75, 21);
            this.tbJointEfficiency2.TabIndex = 90;
            this.tbJointEfficiency2.Text = "0.7";
            // 
            // tbJointEfficiency1
            // 
            this.tbJointEfficiency1.Location = new System.Drawing.Point(506, 267);
            this.tbJointEfficiency1.Name = "tbJointEfficiency1";
            this.tbJointEfficiency1.Size = new System.Drawing.Size(75, 21);
            this.tbJointEfficiency1.TabIndex = 91;
            this.tbJointEfficiency1.Text = "0.7";
            // 
            // gbConstantParam
            // 
            this.gbConstantParam.Controls.Add(this.btnSetJointConstantParam);
            this.gbConstantParam.Location = new System.Drawing.Point(421, 247);
            this.gbConstantParam.Name = "gbConstantParam";
            this.gbConstantParam.Size = new System.Drawing.Size(398, 93);
            this.gbConstantParam.TabIndex = 101;
            this.gbConstantParam.TabStop = false;
            this.gbConstantParam.Text = "Joint Constant Param";
            // 
            // btnSetJointConstantParam
            // 
            this.btnSetJointConstantParam.Location = new System.Drawing.Point(320, 20);
            this.btnSetJointConstantParam.Name = "btnSetJointConstantParam";
            this.btnSetJointConstantParam.Size = new System.Drawing.Size(72, 63);
            this.btnSetJointConstantParam.TabIndex = 0;
            this.btnSetJointConstantParam.Text = "Set\r\nJoint\r\nConstant";
            this.btnSetJointConstantParam.UseVisualStyleBackColor = true;
            this.btnSetJointConstantParam.Click += new System.EventHandler(this.btnSetJointConstantParam_Click);
            // 
            // tbRBuff33
            // 
            this.tbRBuff33.Location = new System.Drawing.Point(659, 408);
            this.tbRBuff33.Name = "tbRBuff33";
            this.tbRBuff33.Size = new System.Drawing.Size(75, 21);
            this.tbRBuff33.TabIndex = 111;
            this.tbRBuff33.Text = "-2.0";
            // 
            // tbRBuff32
            // 
            this.tbRBuff32.Location = new System.Drawing.Point(582, 408);
            this.tbRBuff32.Name = "tbRBuff32";
            this.tbRBuff32.Size = new System.Drawing.Size(75, 21);
            this.tbRBuff32.TabIndex = 112;
            this.tbRBuff32.Text = "2.0";
            // 
            // tbRBuff31
            // 
            this.tbRBuff31.Location = new System.Drawing.Point(506, 408);
            this.tbRBuff31.Name = "tbRBuff31";
            this.tbRBuff31.Size = new System.Drawing.Size(75, 21);
            this.tbRBuff31.TabIndex = 113;
            this.tbRBuff31.Text = "-0.1";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(430, 390);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(43, 12);
            this.label24.TabIndex = 110;
            this.label24.Text = "Buffer2";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(430, 411);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(43, 12);
            this.label25.TabIndex = 109;
            this.label25.Text = "Buffer3";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(430, 369);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(43, 12);
            this.label26.TabIndex = 108;
            this.label26.Text = "Buffer1";
            // 
            // tbRBuff23
            // 
            this.tbRBuff23.Location = new System.Drawing.Point(659, 387);
            this.tbRBuff23.Name = "tbRBuff23";
            this.tbRBuff23.Size = new System.Drawing.Size(75, 21);
            this.tbRBuff23.TabIndex = 105;
            this.tbRBuff23.Text = "-2.0";
            // 
            // tbRBuff22
            // 
            this.tbRBuff22.Location = new System.Drawing.Point(582, 387);
            this.tbRBuff22.Name = "tbRBuff22";
            this.tbRBuff22.Size = new System.Drawing.Size(75, 21);
            this.tbRBuff22.TabIndex = 106;
            this.tbRBuff22.Text = "2.0";
            // 
            // tbRBuff21
            // 
            this.tbRBuff21.Location = new System.Drawing.Point(506, 387);
            this.tbRBuff21.Name = "tbRBuff21";
            this.tbRBuff21.Size = new System.Drawing.Size(75, 21);
            this.tbRBuff21.TabIndex = 107;
            this.tbRBuff21.Text = "-0.025";
            // 
            // tbRBuff13
            // 
            this.tbRBuff13.Location = new System.Drawing.Point(659, 366);
            this.tbRBuff13.Name = "tbRBuff13";
            this.tbRBuff13.Size = new System.Drawing.Size(75, 21);
            this.tbRBuff13.TabIndex = 102;
            this.tbRBuff13.Text = "-1.3";
            // 
            // tbRBuff12
            // 
            this.tbRBuff12.Location = new System.Drawing.Point(582, 366);
            this.tbRBuff12.Name = "tbRBuff12";
            this.tbRBuff12.Size = new System.Drawing.Size(75, 21);
            this.tbRBuff12.TabIndex = 103;
            this.tbRBuff12.Text = "1.3";
            // 
            // tbRBuff11
            // 
            this.tbRBuff11.ForeColor = System.Drawing.Color.Black;
            this.tbRBuff11.Location = new System.Drawing.Point(506, 366);
            this.tbRBuff11.Name = "tbRBuff11";
            this.tbRBuff11.Size = new System.Drawing.Size(75, 21);
            this.tbRBuff11.TabIndex = 104;
            this.tbRBuff11.Text = "0.0";
            // 
            // gbJointTargetParam
            // 
            this.gbJointTargetParam.Controls.Add(this.btnSetRBufferValue);
            this.gbJointTargetParam.Location = new System.Drawing.Point(421, 346);
            this.gbJointTargetParam.Name = "gbJointTargetParam";
            this.gbJointTargetParam.Size = new System.Drawing.Size(398, 93);
            this.gbJointTargetParam.TabIndex = 114;
            this.gbJointTargetParam.TabStop = false;
            this.gbJointTargetParam.Text = "Right Gravity n Friction Param";
            // 
            // btnSetRBufferValue
            // 
            this.btnSetRBufferValue.Location = new System.Drawing.Point(320, 20);
            this.btnSetRBufferValue.Name = "btnSetRBufferValue";
            this.btnSetRBufferValue.Size = new System.Drawing.Size(72, 63);
            this.btnSetRBufferValue.TabIndex = 0;
            this.btnSetRBufferValue.Text = "Set\r\nBuffer Value";
            this.btnSetRBufferValue.UseVisualStyleBackColor = true;
            this.btnSetRBufferValue.Click += new System.EventHandler(this.btnSetJointParam_Click);
            // 
            // tbLBuff33
            // 
            this.tbLBuff33.Location = new System.Drawing.Point(659, 507);
            this.tbLBuff33.Name = "tbLBuff33";
            this.tbLBuff33.Size = new System.Drawing.Size(75, 21);
            this.tbLBuff33.TabIndex = 124;
            this.tbLBuff33.Text = "-2.0";
            // 
            // tbLBuff32
            // 
            this.tbLBuff32.Location = new System.Drawing.Point(582, 507);
            this.tbLBuff32.Name = "tbLBuff32";
            this.tbLBuff32.Size = new System.Drawing.Size(75, 21);
            this.tbLBuff32.TabIndex = 125;
            this.tbLBuff32.Text = "2.0";
            // 
            // tbLBuff31
            // 
            this.tbLBuff31.Location = new System.Drawing.Point(506, 507);
            this.tbLBuff31.Name = "tbLBuff31";
            this.tbLBuff31.Size = new System.Drawing.Size(75, 21);
            this.tbLBuff31.TabIndex = 126;
            this.tbLBuff31.Text = "-0.1";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(430, 489);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(47, 12);
            this.label27.TabIndex = 123;
            this.label27.Text = "Buffer 2";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(430, 510);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(47, 12);
            this.label28.TabIndex = 122;
            this.label28.Text = "Buffer 3";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(430, 468);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(47, 12);
            this.label29.TabIndex = 121;
            this.label29.Text = "Buffer 1";
            // 
            // tbLBuff23
            // 
            this.tbLBuff23.Location = new System.Drawing.Point(659, 486);
            this.tbLBuff23.Name = "tbLBuff23";
            this.tbLBuff23.Size = new System.Drawing.Size(75, 21);
            this.tbLBuff23.TabIndex = 118;
            this.tbLBuff23.Text = "-2.0";
            // 
            // tbLBuff22
            // 
            this.tbLBuff22.Location = new System.Drawing.Point(582, 486);
            this.tbLBuff22.Name = "tbLBuff22";
            this.tbLBuff22.Size = new System.Drawing.Size(75, 21);
            this.tbLBuff22.TabIndex = 119;
            this.tbLBuff22.Text = "2.0";
            this.tbLBuff22.TextChanged += new System.EventHandler(this.tbBuff22_TextChanged);
            // 
            // tbLBuff21
            // 
            this.tbLBuff21.Location = new System.Drawing.Point(506, 486);
            this.tbLBuff21.Name = "tbLBuff21";
            this.tbLBuff21.Size = new System.Drawing.Size(75, 21);
            this.tbLBuff21.TabIndex = 120;
            this.tbLBuff21.Text = "-0.025";
            // 
            // tbLBuff13
            // 
            this.tbLBuff13.Location = new System.Drawing.Point(659, 465);
            this.tbLBuff13.Name = "tbLBuff13";
            this.tbLBuff13.Size = new System.Drawing.Size(75, 21);
            this.tbLBuff13.TabIndex = 115;
            this.tbLBuff13.Text = "2.0";
            // 
            // tbLBuff12
            // 
            this.tbLBuff12.Location = new System.Drawing.Point(582, 465);
            this.tbLBuff12.Name = "tbLBuff12";
            this.tbLBuff12.Size = new System.Drawing.Size(75, 21);
            this.tbLBuff12.TabIndex = 116;
            this.tbLBuff12.Text = "-2.0";
            // 
            // tbLBuff11
            // 
            this.tbLBuff11.Location = new System.Drawing.Point(506, 465);
            this.tbLBuff11.Name = "tbLBuff11";
            this.tbLBuff11.Size = new System.Drawing.Size(75, 21);
            this.tbLBuff11.TabIndex = 117;
            this.tbLBuff11.Text = "0";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSetLBufferValue);
            this.groupBox1.Location = new System.Drawing.Point(421, 445);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(398, 93);
            this.groupBox1.TabIndex = 127;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Left Gravity n Friction Param";
            // 
            // btnSetLBufferValue
            // 
            this.btnSetLBufferValue.Location = new System.Drawing.Point(320, 20);
            this.btnSetLBufferValue.Name = "btnSetLBufferValue";
            this.btnSetLBufferValue.Size = new System.Drawing.Size(72, 63);
            this.btnSetLBufferValue.TabIndex = 0;
            this.btnSetLBufferValue.Text = "Set\r\nBuffer\r\nValue";
            this.btnSetLBufferValue.UseVisualStyleBackColor = true;
            this.btnSetLBufferValue.Click += new System.EventHandler(this.btnSetBufferValue_Click);
            // 
            // btnShowGraph
            // 
            this.btnShowGraph.Location = new System.Drawing.Point(403, 73);
            this.btnShowGraph.Name = "btnShowGraph";
            this.btnShowGraph.Size = new System.Drawing.Size(74, 46);
            this.btnShowGraph.TabIndex = 54;
            this.btnShowGraph.Text = "Show\r\nGraph";
            this.btnShowGraph.UseVisualStyleBackColor = true;
            this.btnShowGraph.Click += new System.EventHandler(this.btnMoveP2P_Click);
            // 
            // tbTorqueDGain3
            // 
            this.tbTorqueDGain3.Location = new System.Drawing.Point(254, 537);
            this.tbTorqueDGain3.Name = "tbTorqueDGain3";
            this.tbTorqueDGain3.Size = new System.Drawing.Size(75, 21);
            this.tbTorqueDGain3.TabIndex = 137;
            this.tbTorqueDGain3.Text = "1.2";
            // 
            // tbTorqueDGain2
            // 
            this.tbTorqueDGain2.Location = new System.Drawing.Point(177, 537);
            this.tbTorqueDGain2.Name = "tbTorqueDGain2";
            this.tbTorqueDGain2.Size = new System.Drawing.Size(75, 21);
            this.tbTorqueDGain2.TabIndex = 138;
            this.tbTorqueDGain2.Text = "1.2";
            this.tbTorqueDGain2.TextChanged += new System.EventHandler(this.tbTorqueDGain2_TextChanged);
            // 
            // tbTorqueDGain1
            // 
            this.tbTorqueDGain1.Location = new System.Drawing.Point(101, 537);
            this.tbTorqueDGain1.Name = "tbTorqueDGain1";
            this.tbTorqueDGain1.ReadOnly = true;
            this.tbTorqueDGain1.Size = new System.Drawing.Size(75, 21);
            this.tbTorqueDGain1.TabIndex = 139;
            this.tbTorqueDGain1.Text = "0";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(29, 519);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(38, 12);
            this.label30.TabIndex = 136;
            this.label30.Text = "I Gain";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(29, 540);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(43, 12);
            this.label31.TabIndex = 135;
            this.label31.Text = "D Gain";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(29, 498);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(43, 12);
            this.label32.TabIndex = 134;
            this.label32.Text = "P Gain";
            // 
            // tbTorqueIGain3
            // 
            this.tbTorqueIGain3.Location = new System.Drawing.Point(254, 516);
            this.tbTorqueIGain3.Name = "tbTorqueIGain3";
            this.tbTorqueIGain3.Size = new System.Drawing.Size(75, 21);
            this.tbTorqueIGain3.TabIndex = 131;
            this.tbTorqueIGain3.Text = "0";
            // 
            // tbTorqueIGain2
            // 
            this.tbTorqueIGain2.Location = new System.Drawing.Point(177, 516);
            this.tbTorqueIGain2.Name = "tbTorqueIGain2";
            this.tbTorqueIGain2.Size = new System.Drawing.Size(75, 21);
            this.tbTorqueIGain2.TabIndex = 132;
            this.tbTorqueIGain2.Text = "0";
            // 
            // tbTorqueIGain1
            // 
            this.tbTorqueIGain1.Location = new System.Drawing.Point(101, 516);
            this.tbTorqueIGain1.Name = "tbTorqueIGain1";
            this.tbTorqueIGain1.ReadOnly = true;
            this.tbTorqueIGain1.Size = new System.Drawing.Size(75, 21);
            this.tbTorqueIGain1.TabIndex = 133;
            this.tbTorqueIGain1.Text = "0";
            // 
            // tbTorquePGain3
            // 
            this.tbTorquePGain3.Location = new System.Drawing.Point(254, 495);
            this.tbTorquePGain3.Name = "tbTorquePGain3";
            this.tbTorquePGain3.Size = new System.Drawing.Size(75, 21);
            this.tbTorquePGain3.TabIndex = 128;
            this.tbTorquePGain3.Text = "1.5";
            // 
            // tbTorquePGain2
            // 
            this.tbTorquePGain2.Location = new System.Drawing.Point(177, 495);
            this.tbTorquePGain2.Name = "tbTorquePGain2";
            this.tbTorquePGain2.Size = new System.Drawing.Size(75, 21);
            this.tbTorquePGain2.TabIndex = 129;
            this.tbTorquePGain2.Text = "1.5";
            // 
            // tbTorquePGain1
            // 
            this.tbTorquePGain1.Location = new System.Drawing.Point(101, 495);
            this.tbTorquePGain1.Name = "tbTorquePGain1";
            this.tbTorquePGain1.ReadOnly = true;
            this.tbTorquePGain1.Size = new System.Drawing.Size(75, 21);
            this.tbTorquePGain1.TabIndex = 130;
            this.tbTorquePGain1.Text = "0";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSetTorquePIDGainParam);
            this.groupBox2.Location = new System.Drawing.Point(16, 475);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(398, 93);
            this.groupBox2.TabIndex = 140;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Torque PID Gain Param";
            // 
            // btnSetTorquePIDGainParam
            // 
            this.btnSetTorquePIDGainParam.Location = new System.Drawing.Point(320, 20);
            this.btnSetTorquePIDGainParam.Name = "btnSetTorquePIDGainParam";
            this.btnSetTorquePIDGainParam.Size = new System.Drawing.Size(72, 63);
            this.btnSetTorquePIDGainParam.TabIndex = 0;
            this.btnSetTorquePIDGainParam.Text = "Set\r\n\r\nPID Gain";
            this.btnSetTorquePIDGainParam.UseVisualStyleBackColor = true;
            this.btnSetTorquePIDGainParam.Click += new System.EventHandler(this.btnSetTorquePIDGainParam_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tbBuffUpdate33);
            this.groupBox3.Controls.Add(this.tbBuffUpdate11);
            this.groupBox3.Controls.Add(this.tbBuffUpdate32);
            this.groupBox3.Controls.Add(this.tbBuffUpdate12);
            this.groupBox3.Controls.Add(this.tbBuffUpdate31);
            this.groupBox3.Controls.Add(this.tbBuffUpdate13);
            this.groupBox3.Controls.Add(this.label33);
            this.groupBox3.Controls.Add(this.tbBuffUpdate21);
            this.groupBox3.Controls.Add(this.label34);
            this.groupBox3.Controls.Add(this.tbBuffUpdate22);
            this.groupBox3.Controls.Add(this.label35);
            this.groupBox3.Controls.Add(this.tbBuffUpdate23);
            this.groupBox3.Location = new System.Drawing.Point(483, 29);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(375, 90);
            this.groupBox3.TabIndex = 73;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Test Buffer Update";
            // 
            // tbBuffUpdate33
            // 
            this.tbBuffUpdate33.Location = new System.Drawing.Point(261, 61);
            this.tbBuffUpdate33.Name = "tbBuffUpdate33";
            this.tbBuffUpdate33.ReadOnly = true;
            this.tbBuffUpdate33.Size = new System.Drawing.Size(75, 21);
            this.tbBuffUpdate33.TabIndex = 150;
            this.tbBuffUpdate33.Text = "0";
            // 
            // tbBuffUpdate11
            // 
            this.tbBuffUpdate11.Location = new System.Drawing.Point(108, 19);
            this.tbBuffUpdate11.Name = "tbBuffUpdate11";
            this.tbBuffUpdate11.ReadOnly = true;
            this.tbBuffUpdate11.Size = new System.Drawing.Size(75, 21);
            this.tbBuffUpdate11.TabIndex = 143;
            this.tbBuffUpdate11.Text = "0";
            // 
            // tbBuffUpdate32
            // 
            this.tbBuffUpdate32.Location = new System.Drawing.Point(184, 61);
            this.tbBuffUpdate32.Name = "tbBuffUpdate32";
            this.tbBuffUpdate32.ReadOnly = true;
            this.tbBuffUpdate32.Size = new System.Drawing.Size(75, 21);
            this.tbBuffUpdate32.TabIndex = 151;
            this.tbBuffUpdate32.Text = "0";
            // 
            // tbBuffUpdate12
            // 
            this.tbBuffUpdate12.Location = new System.Drawing.Point(184, 19);
            this.tbBuffUpdate12.Name = "tbBuffUpdate12";
            this.tbBuffUpdate12.ReadOnly = true;
            this.tbBuffUpdate12.Size = new System.Drawing.Size(75, 21);
            this.tbBuffUpdate12.TabIndex = 142;
            this.tbBuffUpdate12.Text = "0";
            // 
            // tbBuffUpdate31
            // 
            this.tbBuffUpdate31.Location = new System.Drawing.Point(108, 61);
            this.tbBuffUpdate31.Name = "tbBuffUpdate31";
            this.tbBuffUpdate31.ReadOnly = true;
            this.tbBuffUpdate31.Size = new System.Drawing.Size(75, 21);
            this.tbBuffUpdate31.TabIndex = 152;
            this.tbBuffUpdate31.Text = "0";
            // 
            // tbBuffUpdate13
            // 
            this.tbBuffUpdate13.Location = new System.Drawing.Point(261, 19);
            this.tbBuffUpdate13.Name = "tbBuffUpdate13";
            this.tbBuffUpdate13.ReadOnly = true;
            this.tbBuffUpdate13.Size = new System.Drawing.Size(75, 21);
            this.tbBuffUpdate13.TabIndex = 141;
            this.tbBuffUpdate13.Text = "0";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(36, 43);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(43, 12);
            this.label33.TabIndex = 149;
            this.label33.Text = "Buffer2";
            // 
            // tbBuffUpdate21
            // 
            this.tbBuffUpdate21.Location = new System.Drawing.Point(108, 40);
            this.tbBuffUpdate21.Name = "tbBuffUpdate21";
            this.tbBuffUpdate21.ReadOnly = true;
            this.tbBuffUpdate21.Size = new System.Drawing.Size(75, 21);
            this.tbBuffUpdate21.TabIndex = 146;
            this.tbBuffUpdate21.Text = "0";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(36, 64);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(43, 12);
            this.label34.TabIndex = 148;
            this.label34.Text = "Buffer3";
            // 
            // tbBuffUpdate22
            // 
            this.tbBuffUpdate22.Location = new System.Drawing.Point(184, 40);
            this.tbBuffUpdate22.Name = "tbBuffUpdate22";
            this.tbBuffUpdate22.ReadOnly = true;
            this.tbBuffUpdate22.Size = new System.Drawing.Size(75, 21);
            this.tbBuffUpdate22.TabIndex = 145;
            this.tbBuffUpdate22.Text = "0";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(36, 22);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(43, 12);
            this.label35.TabIndex = 147;
            this.label35.Text = "Buffer1";
            // 
            // tbBuffUpdate23
            // 
            this.tbBuffUpdate23.Location = new System.Drawing.Point(261, 40);
            this.tbBuffUpdate23.Name = "tbBuffUpdate23";
            this.tbBuffUpdate23.ReadOnly = true;
            this.tbBuffUpdate23.Size = new System.Drawing.Size(75, 21);
            this.tbBuffUpdate23.TabIndex = 144;
            this.tbBuffUpdate23.Text = "0";
            // 
            // btLogStop
            // 
            this.btLogStop.Location = new System.Drawing.Point(1242, 291);
            this.btLogStop.Name = "btLogStop";
            this.btLogStop.Size = new System.Drawing.Size(84, 37);
            this.btLogStop.TabIndex = 141;
            this.btLogStop.Text = "Logging Stop";
            this.btLogStop.UseVisualStyleBackColor = true;
            this.btLogStop.Click += new System.EventHandler(this.btLogStop_Click);
            // 
            // tbLogCycle
            // 
            this.tbLogCycle.Location = new System.Drawing.Point(790, 3);
            this.tbLogCycle.Name = "tbLogCycle";
            this.tbLogCycle.ReadOnly = true;
            this.tbLogCycle.Size = new System.Drawing.Size(34, 21);
            this.tbLogCycle.TabIndex = 153;
            this.tbLogCycle.Text = "0";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(647, 9);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(139, 12);
            this.label38.TabIndex = 153;
            this.label38.Text = "RealTime Update Cycle";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(832, 9);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(23, 12);
            this.label39.TabIndex = 153;
            this.label39.Text = "ms";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.pbJoint6Servo);
            this.groupBox4.Controls.Add(this.pbJoint3Servo);
            this.groupBox4.Controls.Add(this.label77);
            this.groupBox4.Controls.Add(this.label51);
            this.groupBox4.Controls.Add(this.label76);
            this.groupBox4.Controls.Add(this.label75);
            this.groupBox4.Controls.Add(this.label42);
            this.groupBox4.Controls.Add(this.label48);
            this.groupBox4.Controls.Add(this.pbJoint4Servo);
            this.groupBox4.Controls.Add(this.label49);
            this.groupBox4.Controls.Add(this.pbJoint1Servo);
            this.groupBox4.Controls.Add(this.pbConnect);
            this.groupBox4.Controls.Add(this.label41);
            this.groupBox4.Controls.Add(this.pbJoint5Servo);
            this.groupBox4.Controls.Add(this.label40);
            this.groupBox4.Controls.Add(this.pbJoint2Servo);
            this.groupBox4.Controls.Add(this.pbMainPow);
            this.groupBox4.Controls.Add(this.pbAuxPow);
            this.groupBox4.Location = new System.Drawing.Point(421, 125);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(377, 115);
            this.groupBox4.TabIndex = 154;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Robot Status";
            // 
            // pbJoint6Servo
            // 
            this.pbJoint6Servo.Location = new System.Drawing.Point(330, 81);
            this.pbJoint6Servo.Name = "pbJoint6Servo";
            this.pbJoint6Servo.Size = new System.Drawing.Size(33, 28);
            this.pbJoint6Servo.TabIndex = 168;
            this.pbJoint6Servo.TabStop = false;
            // 
            // pbJoint3Servo
            // 
            this.pbJoint3Servo.Location = new System.Drawing.Point(204, 81);
            this.pbJoint3Servo.Name = "pbJoint3Servo";
            this.pbJoint3Servo.Size = new System.Drawing.Size(33, 28);
            this.pbJoint3Servo.TabIndex = 168;
            this.pbJoint3Servo.TabStop = false;
            // 
            // label77
            // 
            this.label77.AutoSize = true;
            this.label77.Location = new System.Drawing.Point(248, 91);
            this.label77.Name = "label77";
            this.label77.Size = new System.Drawing.Size(73, 12);
            this.label77.TabIndex = 167;
            this.label77.Text = "Joint6 Servo";
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.Location = new System.Drawing.Point(122, 91);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(73, 12);
            this.label51.TabIndex = 167;
            this.label51.Text = "Joint3 Servo";
            // 
            // label76
            // 
            this.label76.AutoSize = true;
            this.label76.Location = new System.Drawing.Point(248, 56);
            this.label76.Name = "label76";
            this.label76.Size = new System.Drawing.Size(73, 12);
            this.label76.TabIndex = 166;
            this.label76.Text = "Joint5 Servo";
            // 
            // label75
            // 
            this.label75.AutoSize = true;
            this.label75.Location = new System.Drawing.Point(249, 22);
            this.label75.Name = "label75";
            this.label75.Size = new System.Drawing.Size(73, 12);
            this.label75.TabIndex = 165;
            this.label75.Text = "Joint4 Servo";
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Location = new System.Drawing.Point(123, 56);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(73, 12);
            this.label42.TabIndex = 166;
            this.label42.Text = "Joint2 Servo";
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Location = new System.Drawing.Point(123, 22);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(73, 12);
            this.label48.TabIndex = 165;
            this.label48.Text = "Joint1 Servo";
            // 
            // pbJoint4Servo
            // 
            this.pbJoint4Servo.Location = new System.Drawing.Point(330, 14);
            this.pbJoint4Servo.Name = "pbJoint4Servo";
            this.pbJoint4Servo.Size = new System.Drawing.Size(33, 28);
            this.pbJoint4Servo.TabIndex = 164;
            this.pbJoint4Servo.TabStop = false;
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.Location = new System.Drawing.Point(9, 21);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(52, 12);
            this.label49.TabIndex = 162;
            this.label49.Text = "Connect";
            // 
            // pbJoint1Servo
            // 
            this.pbJoint1Servo.Location = new System.Drawing.Point(204, 14);
            this.pbJoint1Servo.Name = "pbJoint1Servo";
            this.pbJoint1Servo.Size = new System.Drawing.Size(33, 28);
            this.pbJoint1Servo.TabIndex = 164;
            this.pbJoint1Servo.TabStop = false;
            // 
            // pbConnect
            // 
            this.pbConnect.Location = new System.Drawing.Point(82, 11);
            this.pbConnect.Name = "pbConnect";
            this.pbConnect.Size = new System.Drawing.Size(33, 28);
            this.pbConnect.TabIndex = 163;
            this.pbConnect.TabStop = false;
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(9, 86);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(73, 12);
            this.label41.TabIndex = 159;
            this.label41.Text = "Main Power";
            // 
            // pbJoint5Servo
            // 
            this.pbJoint5Servo.Location = new System.Drawing.Point(330, 47);
            this.pbJoint5Servo.Name = "pbJoint5Servo";
            this.pbJoint5Servo.Size = new System.Drawing.Size(33, 28);
            this.pbJoint5Servo.TabIndex = 157;
            this.pbJoint5Servo.TabStop = false;
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(9, 54);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(67, 12);
            this.label40.TabIndex = 155;
            this.label40.Text = "Aux Power";
            // 
            // pbJoint2Servo
            // 
            this.pbJoint2Servo.Location = new System.Drawing.Point(204, 47);
            this.pbJoint2Servo.Name = "pbJoint2Servo";
            this.pbJoint2Servo.Size = new System.Drawing.Size(33, 28);
            this.pbJoint2Servo.TabIndex = 157;
            this.pbJoint2Servo.TabStop = false;
            // 
            // pbMainPow
            // 
            this.pbMainPow.Location = new System.Drawing.Point(82, 78);
            this.pbMainPow.Name = "pbMainPow";
            this.pbMainPow.Size = new System.Drawing.Size(33, 28);
            this.pbMainPow.TabIndex = 156;
            this.pbMainPow.TabStop = false;
            // 
            // pbAuxPow
            // 
            this.pbAuxPow.Location = new System.Drawing.Point(82, 44);
            this.pbAuxPow.Name = "pbAuxPow";
            this.pbAuxPow.Size = new System.Drawing.Size(33, 28);
            this.pbAuxPow.TabIndex = 155;
            this.pbAuxPow.TabStop = false;
            // 
            // pbLogging
            // 
            this.pbLogging.Location = new System.Drawing.Point(213, 85);
            this.pbLogging.Name = "pbLogging";
            this.pbLogging.Size = new System.Drawing.Size(33, 28);
            this.pbLogging.TabIndex = 158;
            this.pbLogging.TabStop = false;
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Location = new System.Drawing.Point(147, 92);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(50, 12);
            this.label43.TabIndex = 161;
            this.label43.Text = "Logging";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label50);
            this.groupBox5.Controls.Add(this.pbUpdateData);
            this.groupBox5.Controls.Add(this.label44);
            this.groupBox5.Controls.Add(this.label71);
            this.groupBox5.Controls.Add(this.label45);
            this.groupBox5.Controls.Add(this.label43);
            this.groupBox5.Controls.Add(this.label46);
            this.groupBox5.Controls.Add(this.label47);
            this.groupBox5.Controls.Add(this.pbTargetReached);
            this.groupBox5.Controls.Add(this.pbUDPconnection);
            this.groupBox5.Controls.Add(this.pbGravityMode);
            this.groupBox5.Controls.Add(this.pbLogging);
            this.groupBox5.Controls.Add(this.pbTorqueMode);
            this.groupBox5.Controls.Add(this.pbPositionMode);
            this.groupBox5.Location = new System.Drawing.Point(804, 125);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(352, 115);
            this.groupBox5.TabIndex = 162;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Master Mode";
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Location = new System.Drawing.Point(15, 93);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(73, 12);
            this.label50.TabIndex = 163;
            this.label50.Text = "Update Data";
            // 
            // pbUpdateData
            // 
            this.pbUpdateData.Location = new System.Drawing.Point(90, 85);
            this.pbUpdateData.Name = "pbUpdateData";
            this.pbUpdateData.Size = new System.Drawing.Size(33, 28);
            this.pbUpdateData.TabIndex = 162;
            this.pbUpdateData.TabStop = false;
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Location = new System.Drawing.Point(129, 61);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(81, 12);
            this.label44.TabIndex = 161;
            this.label44.Text = "Target Reach";
            // 
            // label71
            // 
            this.label71.AutoSize = true;
            this.label71.Location = new System.Drawing.Point(256, 32);
            this.label71.Name = "label71";
            this.label71.Size = new System.Drawing.Size(80, 12);
            this.label71.TabIndex = 160;
            this.label71.Text = "UDP Connect";
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Location = new System.Drawing.Point(149, 27);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(44, 12);
            this.label45.TabIndex = 160;
            this.label45.Text = "Gravity";
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Location = new System.Drawing.Point(7, 61);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(81, 12);
            this.label46.TabIndex = 159;
            this.label46.Text = "Torque Mode";
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Location = new System.Drawing.Point(3, 27);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(86, 12);
            this.label47.TabIndex = 155;
            this.label47.Text = "Position Mode";
            // 
            // pbTargetReached
            // 
            this.pbTargetReached.Location = new System.Drawing.Point(213, 53);
            this.pbTargetReached.Name = "pbTargetReached";
            this.pbTargetReached.Size = new System.Drawing.Size(33, 28);
            this.pbTargetReached.TabIndex = 158;
            this.pbTargetReached.TabStop = false;
            // 
            // pbUDPconnection
            // 
            this.pbUDPconnection.Location = new System.Drawing.Point(278, 54);
            this.pbUDPconnection.Name = "pbUDPconnection";
            this.pbUDPconnection.Size = new System.Drawing.Size(33, 28);
            this.pbUDPconnection.TabIndex = 157;
            this.pbUDPconnection.TabStop = false;
            // 
            // pbGravityMode
            // 
            this.pbGravityMode.Location = new System.Drawing.Point(213, 18);
            this.pbGravityMode.Name = "pbGravityMode";
            this.pbGravityMode.Size = new System.Drawing.Size(33, 28);
            this.pbGravityMode.TabIndex = 157;
            this.pbGravityMode.TabStop = false;
            // 
            // pbTorqueMode
            // 
            this.pbTorqueMode.Location = new System.Drawing.Point(90, 53);
            this.pbTorqueMode.Name = "pbTorqueMode";
            this.pbTorqueMode.Size = new System.Drawing.Size(33, 28);
            this.pbTorqueMode.TabIndex = 156;
            this.pbTorqueMode.TabStop = false;
            // 
            // pbPositionMode
            // 
            this.pbPositionMode.Location = new System.Drawing.Point(90, 20);
            this.pbPositionMode.Name = "pbPositionMode";
            this.pbPositionMode.Size = new System.Drawing.Size(33, 28);
            this.pbPositionMode.TabIndex = 155;
            this.pbPositionMode.TabStop = false;
            // 
            // btnShowChart
            // 
            this.btnShowChart.Location = new System.Drawing.Point(403, 12);
            this.btnShowChart.Name = "btnShowChart";
            this.btnShowChart.Size = new System.Drawing.Size(74, 36);
            this.btnShowChart.TabIndex = 163;
            this.btnShowChart.Text = "Show Chart";
            this.btnShowChart.UseVisualStyleBackColor = true;
            this.btnShowChart.Click += new System.EventHandler(this.btnShowChart_Click);
            // 
            // cbChartMode
            // 
            this.cbChartMode.FormattingEnabled = true;
            this.cbChartMode.Items.AddRange(new object[] {
            "Pos",
            "Torq",
            "Colis",
            "Pose"});
            this.cbChartMode.Location = new System.Drawing.Point(403, 49);
            this.cbChartMode.Name = "cbChartMode";
            this.cbChartMode.Size = new System.Drawing.Size(74, 20);
            this.cbChartMode.TabIndex = 164;
            this.cbChartMode.Text = "Pos";
            this.cbChartMode.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnSetGravityMode
            // 
            this.btnSetGravityMode.Location = new System.Drawing.Point(1242, 338);
            this.btnSetGravityMode.Name = "btnSetGravityMode";
            this.btnSetGravityMode.Size = new System.Drawing.Size(86, 63);
            this.btnSetGravityMode.TabIndex = 0;
            this.btnSetGravityMode.Text = "Set\r\nGravity\r\nMode";
            this.btnSetGravityMode.UseVisualStyleBackColor = true;
            this.btnSetGravityMode.Click += new System.EventHandler(this.btnSetGravityMode_Click);
            // 
            // btnSetJointMode
            // 
            this.btnSetJointMode.Location = new System.Drawing.Point(1242, 407);
            this.btnSetJointMode.Name = "btnSetJointMode";
            this.btnSetJointMode.Size = new System.Drawing.Size(86, 63);
            this.btnSetJointMode.TabIndex = 0;
            this.btnSetJointMode.Text = "Set\r\nJoint\r\nMode";
            this.btnSetJointMode.UseVisualStyleBackColor = true;
            this.btnSetJointMode.Click += new System.EventHandler(this.btnSetJointMode_Click);
            // 
            // btnSetCartesianMode
            // 
            this.btnSetCartesianMode.Location = new System.Drawing.Point(1242, 476);
            this.btnSetCartesianMode.Name = "btnSetCartesianMode";
            this.btnSetCartesianMode.Size = new System.Drawing.Size(86, 63);
            this.btnSetCartesianMode.TabIndex = 0;
            this.btnSetCartesianMode.Text = "Set \r\nCartesian\r\nMode";
            this.btnSetCartesianMode.UseVisualStyleBackColor = true;
            this.btnSetCartesianMode.Click += new System.EventHandler(this.btnSetCartesianMode_Click);
            // 
            // tbPosZDGain
            // 
            this.tbPosZDGain.Location = new System.Drawing.Point(1063, 310);
            this.tbPosZDGain.Name = "tbPosZDGain";
            this.tbPosZDGain.Size = new System.Drawing.Size(75, 21);
            this.tbPosZDGain.TabIndex = 174;
            this.tbPosZDGain.Text = "600";
            // 
            // tbPosZIGain
            // 
            this.tbPosZIGain.Location = new System.Drawing.Point(986, 310);
            this.tbPosZIGain.Name = "tbPosZIGain";
            this.tbPosZIGain.Size = new System.Drawing.Size(75, 21);
            this.tbPosZIGain.TabIndex = 175;
            this.tbPosZIGain.Text = "600";
            // 
            // tbPosZPGain
            // 
            this.tbPosZPGain.Location = new System.Drawing.Point(910, 310);
            this.tbPosZPGain.Name = "tbPosZPGain";
            this.tbPosZPGain.Size = new System.Drawing.Size(75, 21);
            this.tbPosZPGain.TabIndex = 176;
            this.tbPosZPGain.Text = "600";
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.Location = new System.Drawing.Point(189, 12);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(20, 12);
            this.label52.TabIndex = 173;
            this.label52.Text = "Py";
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.Location = new System.Drawing.Point(270, 12);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(20, 12);
            this.label53.TabIndex = 172;
            this.label53.Text = "Pz";
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.Location = new System.Drawing.Point(107, 12);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(20, 12);
            this.label54.TabIndex = 171;
            this.label54.Text = "Px";
            // 
            // tbPosYDGain
            // 
            this.tbPosYDGain.Location = new System.Drawing.Point(1063, 289);
            this.tbPosYDGain.Name = "tbPosYDGain";
            this.tbPosYDGain.Size = new System.Drawing.Size(75, 21);
            this.tbPosYDGain.TabIndex = 168;
            this.tbPosYDGain.Text = "0";
            // 
            // tbPosYIGain
            // 
            this.tbPosYIGain.Location = new System.Drawing.Point(986, 289);
            this.tbPosYIGain.Name = "tbPosYIGain";
            this.tbPosYIGain.Size = new System.Drawing.Size(75, 21);
            this.tbPosYIGain.TabIndex = 169;
            this.tbPosYIGain.Text = "0";
            // 
            // tbPosYPGain
            // 
            this.tbPosYPGain.Location = new System.Drawing.Point(910, 289);
            this.tbPosYPGain.Name = "tbPosYPGain";
            this.tbPosYPGain.Size = new System.Drawing.Size(75, 21);
            this.tbPosYPGain.TabIndex = 170;
            this.tbPosYPGain.Text = "0";
            // 
            // tbPosXDGain
            // 
            this.tbPosXDGain.Location = new System.Drawing.Point(1063, 268);
            this.tbPosXDGain.Name = "tbPosXDGain";
            this.tbPosXDGain.Size = new System.Drawing.Size(75, 21);
            this.tbPosXDGain.TabIndex = 165;
            this.tbPosXDGain.Text = "3000";
            // 
            // tbPosXIGain
            // 
            this.tbPosXIGain.Location = new System.Drawing.Point(986, 268);
            this.tbPosXIGain.Name = "tbPosXIGain";
            this.tbPosXIGain.Size = new System.Drawing.Size(75, 21);
            this.tbPosXIGain.TabIndex = 166;
            this.tbPosXIGain.Text = "3000";
            // 
            // tbPosXPGain
            // 
            this.tbPosXPGain.Location = new System.Drawing.Point(910, 268);
            this.tbPosXPGain.Name = "tbPosXPGain";
            this.tbPosXPGain.Size = new System.Drawing.Size(75, 21);
            this.tbPosXPGain.TabIndex = 167;
            this.tbPosXPGain.Text = "3000";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btnSetCartesianPIDGain);
            this.groupBox6.Controls.Add(this.label57);
            this.groupBox6.Controls.Add(this.label56);
            this.groupBox6.Controls.Add(this.label55);
            this.groupBox6.Controls.Add(this.label54);
            this.groupBox6.Controls.Add(this.label52);
            this.groupBox6.Controls.Add(this.label53);
            this.groupBox6.Location = new System.Drawing.Point(825, 241);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(398, 97);
            this.groupBox6.TabIndex = 177;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Cartesian PID Param";
            // 
            // btnSetCartesianPIDGain
            // 
            this.btnSetCartesianPIDGain.Location = new System.Drawing.Point(320, 29);
            this.btnSetCartesianPIDGain.Name = "btnSetCartesianPIDGain";
            this.btnSetCartesianPIDGain.Size = new System.Drawing.Size(72, 60);
            this.btnSetCartesianPIDGain.TabIndex = 0;
            this.btnSetCartesianPIDGain.Text = "Set\r\nCartesianPIDGain";
            this.btnSetCartesianPIDGain.UseVisualStyleBackColor = true;
            this.btnSetCartesianPIDGain.Click += new System.EventHandler(this.btnSetCartesianPIDGain_Click);
            // 
            // label57
            // 
            this.label57.AutoSize = true;
            this.label57.Location = new System.Drawing.Point(31, 74);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(43, 12);
            this.label57.TabIndex = 171;
            this.label57.Text = "D Gain";
            // 
            // label56
            // 
            this.label56.AutoSize = true;
            this.label56.Location = new System.Drawing.Point(31, 53);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(38, 12);
            this.label56.TabIndex = 171;
            this.label56.Text = "I Gain";
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.label55.Location = new System.Drawing.Point(31, 29);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(43, 12);
            this.label55.TabIndex = 171;
            this.label55.Text = "P Gain";
            // 
            // btnSetRJointBuff
            // 
            this.btnSetRJointBuff.Location = new System.Drawing.Point(320, 29);
            this.btnSetRJointBuff.Name = "btnSetRJointBuff";
            this.btnSetRJointBuff.Size = new System.Drawing.Size(72, 60);
            this.btnSetRJointBuff.TabIndex = 0;
            this.btnSetRJointBuff.Text = "Set Right Friction";
            this.btnSetRJointBuff.UseVisualStyleBackColor = true;
            this.btnSetRJointBuff.Click += new System.EventHandler(this.btnSetCartesianTrajectoryParam_Click);
            // 
            // tbRBuff3J3
            // 
            this.tbRBuff3J3.Location = new System.Drawing.Point(1063, 409);
            this.tbRBuff3J3.Name = "tbRBuff3J3";
            this.tbRBuff3J3.Size = new System.Drawing.Size(75, 21);
            this.tbRBuff3J3.TabIndex = 187;
            this.tbRBuff3J3.Text = "0.0";
            // 
            // tbRBuff3J2
            // 
            this.tbRBuff3J2.Location = new System.Drawing.Point(986, 409);
            this.tbRBuff3J2.Name = "tbRBuff3J2";
            this.tbRBuff3J2.Size = new System.Drawing.Size(75, 21);
            this.tbRBuff3J2.TabIndex = 188;
            this.tbRBuff3J2.Text = "0.5";
            // 
            // tbRBuff3J1
            // 
            this.tbRBuff3J1.Location = new System.Drawing.Point(910, 409);
            this.tbRBuff3J1.Name = "tbRBuff3J1";
            this.tbRBuff3J1.Size = new System.Drawing.Size(75, 21);
            this.tbRBuff3J1.TabIndex = 189;
            this.tbRBuff3J1.Text = "-0.5";
            // 
            // label61
            // 
            this.label61.AutoSize = true;
            this.label61.Location = new System.Drawing.Point(838, 391);
            this.label61.Name = "label61";
            this.label61.Size = new System.Drawing.Size(32, 12);
            this.label61.TabIndex = 186;
            this.label61.Text = "Buff2";
            // 
            // label62
            // 
            this.label62.AutoSize = true;
            this.label62.Location = new System.Drawing.Point(838, 412);
            this.label62.Name = "label62";
            this.label62.Size = new System.Drawing.Size(32, 12);
            this.label62.TabIndex = 185;
            this.label62.Text = "Buff3";
            // 
            // label63
            // 
            this.label63.AutoSize = true;
            this.label63.Location = new System.Drawing.Point(838, 370);
            this.label63.Name = "label63";
            this.label63.Size = new System.Drawing.Size(32, 12);
            this.label63.TabIndex = 184;
            this.label63.Text = "Buff1";
            // 
            // tbRBuff2J3
            // 
            this.tbRBuff2J3.Location = new System.Drawing.Point(1063, 388);
            this.tbRBuff2J3.Name = "tbRBuff2J3";
            this.tbRBuff2J3.Size = new System.Drawing.Size(75, 21);
            this.tbRBuff2J3.TabIndex = 181;
            this.tbRBuff2J3.Text = "0.0";
            // 
            // tbRBuff2J2
            // 
            this.tbRBuff2J2.Location = new System.Drawing.Point(986, 388);
            this.tbRBuff2J2.Name = "tbRBuff2J2";
            this.tbRBuff2J2.Size = new System.Drawing.Size(75, 21);
            this.tbRBuff2J2.TabIndex = 182;
            this.tbRBuff2J2.Text = "0.5";
            this.tbRBuff2J2.TextChanged += new System.EventHandler(this.tbTargetTimePy_TextChanged);
            // 
            // tbRBuff2J1
            // 
            this.tbRBuff2J1.Location = new System.Drawing.Point(910, 388);
            this.tbRBuff2J1.Name = "tbRBuff2J1";
            this.tbRBuff2J1.Size = new System.Drawing.Size(75, 21);
            this.tbRBuff2J1.TabIndex = 183;
            this.tbRBuff2J1.Text = "-0.5";
            // 
            // tbRBuff1J3
            // 
            this.tbRBuff1J3.Location = new System.Drawing.Point(1063, 367);
            this.tbRBuff1J3.Name = "tbRBuff1J3";
            this.tbRBuff1J3.Size = new System.Drawing.Size(75, 21);
            this.tbRBuff1J3.TabIndex = 178;
            this.tbRBuff1J3.Text = "0.0";
            // 
            // tbRBuff1J2
            // 
            this.tbRBuff1J2.Location = new System.Drawing.Point(986, 367);
            this.tbRBuff1J2.Name = "tbRBuff1J2";
            this.tbRBuff1J2.Size = new System.Drawing.Size(75, 21);
            this.tbRBuff1J2.TabIndex = 179;
            this.tbRBuff1J2.Text = "0.1";
            // 
            // tbRBuff1J1
            // 
            this.tbRBuff1J1.Location = new System.Drawing.Point(910, 367);
            this.tbRBuff1J1.Name = "tbRBuff1J1";
            this.tbRBuff1J1.Size = new System.Drawing.Size(75, 21);
            this.tbRBuff1J1.TabIndex = 180;
            this.tbRBuff1J1.Text = "-0.1";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.btnSetRJointBuff);
            this.groupBox7.Location = new System.Drawing.Point(825, 340);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(398, 97);
            this.groupBox7.TabIndex = 190;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Right Friction Param 2";
            // 
            // btnSetLJointBuff
            // 
            this.btnSetLJointBuff.Location = new System.Drawing.Point(320, 29);
            this.btnSetLJointBuff.Name = "btnSetLJointBuff";
            this.btnSetLJointBuff.Size = new System.Drawing.Size(72, 60);
            this.btnSetLJointBuff.TabIndex = 0;
            this.btnSetLJointBuff.Text = "Set Left Friciton";
            this.btnSetLJointBuff.UseVisualStyleBackColor = true;
            this.btnSetLJointBuff.Click += new System.EventHandler(this.btnSetJointBuff_Click);
            // 
            // tbLBuff3J3
            // 
            this.tbLBuff3J3.Location = new System.Drawing.Point(1063, 510);
            this.tbLBuff3J3.Name = "tbLBuff3J3";
            this.tbLBuff3J3.Size = new System.Drawing.Size(75, 21);
            this.tbLBuff3J3.TabIndex = 200;
            this.tbLBuff3J3.Text = "0";
            // 
            // tbLBuff3J2
            // 
            this.tbLBuff3J2.Location = new System.Drawing.Point(986, 510);
            this.tbLBuff3J2.Name = "tbLBuff3J2";
            this.tbLBuff3J2.Size = new System.Drawing.Size(75, 21);
            this.tbLBuff3J2.TabIndex = 201;
            this.tbLBuff3J2.Text = "0.5";
            // 
            // tbLBuff3J1
            // 
            this.tbLBuff3J1.Location = new System.Drawing.Point(910, 510);
            this.tbLBuff3J1.Name = "tbLBuff3J1";
            this.tbLBuff3J1.Size = new System.Drawing.Size(75, 21);
            this.tbLBuff3J1.TabIndex = 202;
            this.tbLBuff3J1.Text = "-0.5";
            // 
            // label67
            // 
            this.label67.AutoSize = true;
            this.label67.Location = new System.Drawing.Point(838, 492);
            this.label67.Name = "label67";
            this.label67.Size = new System.Drawing.Size(32, 12);
            this.label67.TabIndex = 199;
            this.label67.Text = "Buff2";
            // 
            // label68
            // 
            this.label68.AutoSize = true;
            this.label68.Location = new System.Drawing.Point(838, 513);
            this.label68.Name = "label68";
            this.label68.Size = new System.Drawing.Size(32, 12);
            this.label68.TabIndex = 198;
            this.label68.Text = "Buff3";
            // 
            // label69
            // 
            this.label69.AutoSize = true;
            this.label69.Location = new System.Drawing.Point(838, 471);
            this.label69.Name = "label69";
            this.label69.Size = new System.Drawing.Size(32, 12);
            this.label69.TabIndex = 197;
            this.label69.Text = "Buff1";
            // 
            // tbLBuff2J3
            // 
            this.tbLBuff2J3.Location = new System.Drawing.Point(1063, 489);
            this.tbLBuff2J3.Name = "tbLBuff2J3";
            this.tbLBuff2J3.Size = new System.Drawing.Size(75, 21);
            this.tbLBuff2J3.TabIndex = 194;
            this.tbLBuff2J3.Text = "0";
            // 
            // tbLBuff2J2
            // 
            this.tbLBuff2J2.Location = new System.Drawing.Point(986, 489);
            this.tbLBuff2J2.Name = "tbLBuff2J2";
            this.tbLBuff2J2.Size = new System.Drawing.Size(75, 21);
            this.tbLBuff2J2.TabIndex = 195;
            this.tbLBuff2J2.Text = "0.5";
            // 
            // tbLBuff2J1
            // 
            this.tbLBuff2J1.Location = new System.Drawing.Point(910, 489);
            this.tbLBuff2J1.Name = "tbLBuff2J1";
            this.tbLBuff2J1.Size = new System.Drawing.Size(75, 21);
            this.tbLBuff2J1.TabIndex = 196;
            this.tbLBuff2J1.Text = "-0.5";
            // 
            // tbLBuff1J3
            // 
            this.tbLBuff1J3.Location = new System.Drawing.Point(1063, 468);
            this.tbLBuff1J3.Name = "tbLBuff1J3";
            this.tbLBuff1J3.Size = new System.Drawing.Size(75, 21);
            this.tbLBuff1J3.TabIndex = 191;
            this.tbLBuff1J3.Text = "0";
            // 
            // tbLBuff1J2
            // 
            this.tbLBuff1J2.Location = new System.Drawing.Point(986, 468);
            this.tbLBuff1J2.Name = "tbLBuff1J2";
            this.tbLBuff1J2.Size = new System.Drawing.Size(75, 21);
            this.tbLBuff1J2.TabIndex = 192;
            this.tbLBuff1J2.Text = "0.5";
            // 
            // tbLBuff1J1
            // 
            this.tbLBuff1J1.Location = new System.Drawing.Point(910, 468);
            this.tbLBuff1J1.Name = "tbLBuff1J1";
            this.tbLBuff1J1.Size = new System.Drawing.Size(75, 21);
            this.tbLBuff1J1.TabIndex = 193;
            this.tbLBuff1J1.Text = "-0.5";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.btnSetLJointBuff);
            this.groupBox8.Location = new System.Drawing.Point(825, 441);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(398, 97);
            this.groupBox8.TabIndex = 203;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Left Friction Param 2";
            // 
            // tbLeftPoseX
            // 
            this.tbLeftPoseX.Location = new System.Drawing.Point(950, 6);
            this.tbLeftPoseX.Name = "tbLeftPoseX";
            this.tbLeftPoseX.ReadOnly = true;
            this.tbLeftPoseX.Size = new System.Drawing.Size(75, 21);
            this.tbLeftPoseX.TabIndex = 155;
            this.tbLeftPoseX.Text = "0";
            // 
            // tbLeftPoseY
            // 
            this.tbLeftPoseY.Location = new System.Drawing.Point(1026, 6);
            this.tbLeftPoseY.Name = "tbLeftPoseY";
            this.tbLeftPoseY.ReadOnly = true;
            this.tbLeftPoseY.Size = new System.Drawing.Size(75, 21);
            this.tbLeftPoseY.TabIndex = 154;
            this.tbLeftPoseY.Text = "0";
            // 
            // tbLeftPoseZ
            // 
            this.tbLeftPoseZ.Location = new System.Drawing.Point(1103, 6);
            this.tbLeftPoseZ.Name = "tbLeftPoseZ";
            this.tbLeftPoseZ.ReadOnly = true;
            this.tbLeftPoseZ.Size = new System.Drawing.Size(75, 21);
            this.tbLeftPoseZ.TabIndex = 153;
            this.tbLeftPoseZ.Text = "0";
            // 
            // label70
            // 
            this.label70.AutoSize = true;
            this.label70.Location = new System.Drawing.Point(878, 9);
            this.label70.Name = "label70";
            this.label70.Size = new System.Drawing.Size(45, 12);
            this.label70.TabIndex = 156;
            this.label70.Text = "L Pose";
            // 
            // btnDemoPose1
            // 
            this.btnDemoPose1.Location = new System.Drawing.Point(926, 58);
            this.btnDemoPose1.Name = "btnDemoPose1";
            this.btnDemoPose1.Size = new System.Drawing.Size(49, 63);
            this.btnDemoPose1.TabIndex = 0;
            this.btnDemoPose1.Text = "Pose1";
            this.btnDemoPose1.UseVisualStyleBackColor = true;
            this.btnDemoPose1.Click += new System.EventHandler(this.btnDemoPose1_Click);
            // 
            // btnDemoPose2
            // 
            this.btnDemoPose2.Location = new System.Drawing.Point(980, 57);
            this.btnDemoPose2.Name = "btnDemoPose2";
            this.btnDemoPose2.Size = new System.Drawing.Size(49, 63);
            this.btnDemoPose2.TabIndex = 0;
            this.btnDemoPose2.Text = "Pose2";
            this.btnDemoPose2.UseVisualStyleBackColor = true;
            this.btnDemoPose2.Click += new System.EventHandler(this.btnDemoPose2_Click);
            // 
            // btnDemoPose3
            // 
            this.btnDemoPose3.Location = new System.Drawing.Point(1034, 57);
            this.btnDemoPose3.Name = "btnDemoPose3";
            this.btnDemoPose3.Size = new System.Drawing.Size(49, 63);
            this.btnDemoPose3.TabIndex = 0;
            this.btnDemoPose3.Text = "Pose3";
            this.btnDemoPose3.UseVisualStyleBackColor = true;
            this.btnDemoPose3.Click += new System.EventHandler(this.btnDemoPose3_Click);
            // 
            // btnDemoPose4
            // 
            this.btnDemoPose4.Location = new System.Drawing.Point(1087, 57);
            this.btnDemoPose4.Name = "btnDemoPose4";
            this.btnDemoPose4.Size = new System.Drawing.Size(49, 63);
            this.btnDemoPose4.TabIndex = 0;
            this.btnDemoPose4.Text = "Pose4";
            this.btnDemoPose4.UseVisualStyleBackColor = true;
            this.btnDemoPose4.Click += new System.EventHandler(this.btnDemoPose4_Click);
            // 
            // btnReadyPose
            // 
            this.btnReadyPose.Location = new System.Drawing.Point(871, 58);
            this.btnReadyPose.Name = "btnReadyPose";
            this.btnReadyPose.Size = new System.Drawing.Size(49, 63);
            this.btnReadyPose.TabIndex = 0;
            this.btnReadyPose.Text = "Ready Pose";
            this.btnReadyPose.UseVisualStyleBackColor = true;
            this.btnReadyPose.Click += new System.EventHandler(this.btnReadyPose_Click);
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.UDP_Connect);
            this.groupBox9.Controls.Add(this.label73);
            this.groupBox9.Controls.Add(this.label72);
            this.groupBox9.Controls.Add(this.tbUDPport);
            this.groupBox9.Controls.Add(this.tbIPadress);
            this.groupBox9.Location = new System.Drawing.Point(1162, 59);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(173, 186);
            this.groupBox9.TabIndex = 204;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "UDP connect";
            // 
            // UDP_Connect
            // 
            this.UDP_Connect.Location = new System.Drawing.Point(8, 117);
            this.UDP_Connect.Name = "UDP_Connect";
            this.UDP_Connect.Size = new System.Drawing.Size(156, 59);
            this.UDP_Connect.TabIndex = 0;
            this.UDP_Connect.Text = "UDP Connect";
            this.UDP_Connect.UseVisualStyleBackColor = true;
            this.UDP_Connect.Click += new System.EventHandler(this.UDP_Connect_Click);
            // 
            // label73
            // 
            this.label73.AutoSize = true;
            this.label73.Location = new System.Drawing.Point(6, 69);
            this.label73.Name = "label73";
            this.label73.Size = new System.Drawing.Size(27, 12);
            this.label73.TabIndex = 160;
            this.label73.Text = "Port";
            // 
            // label72
            // 
            this.label72.AutoSize = true;
            this.label72.Location = new System.Drawing.Point(6, 23);
            this.label72.Name = "label72";
            this.label72.Size = new System.Drawing.Size(66, 12);
            this.label72.TabIndex = 160;
            this.label72.Text = "IP address";
            // 
            // tbUDPport
            // 
            this.tbUDPport.Location = new System.Drawing.Point(8, 88);
            this.tbUDPport.Name = "tbUDPport";
            this.tbUDPport.Size = new System.Drawing.Size(156, 21);
            this.tbUDPport.TabIndex = 167;
            this.tbUDPport.Text = "5000";
            // 
            // tbIPadress
            // 
            this.tbIPadress.Location = new System.Drawing.Point(8, 42);
            this.tbIPadress.Name = "tbIPadress";
            this.tbIPadress.Size = new System.Drawing.Size(156, 21);
            this.tbIPadress.TabIndex = 167;
            this.tbIPadress.Text = "192.168.255.207";
            // 
            // tbLeftButton
            // 
            this.tbLeftButton.Location = new System.Drawing.Point(1260, 6);
            this.tbLeftButton.Name = "tbLeftButton";
            this.tbLeftButton.ReadOnly = true;
            this.tbLeftButton.Size = new System.Drawing.Size(75, 21);
            this.tbLeftButton.TabIndex = 155;
            this.tbLeftButton.Text = "0";
            // 
            // label74
            // 
            this.label74.AutoSize = true;
            this.label74.Location = new System.Drawing.Point(1196, 9);
            this.label74.Name = "label74";
            this.label74.Size = new System.Drawing.Size(40, 12);
            this.label74.TabIndex = 156;
            this.label74.Text = "Button";
            // 
            // label78
            // 
            this.label78.AutoSize = true;
            this.label78.Location = new System.Drawing.Point(879, 33);
            this.label78.Name = "label78";
            this.label78.Size = new System.Drawing.Size(46, 12);
            this.label78.TabIndex = 156;
            this.label78.Text = "R Pose";
            // 
            // tbRightPoseZ
            // 
            this.tbRightPoseZ.Location = new System.Drawing.Point(1103, 30);
            this.tbRightPoseZ.Name = "tbRightPoseZ";
            this.tbRightPoseZ.ReadOnly = true;
            this.tbRightPoseZ.Size = new System.Drawing.Size(75, 21);
            this.tbRightPoseZ.TabIndex = 153;
            this.tbRightPoseZ.Text = "0";
            // 
            // tbRightPoseY
            // 
            this.tbRightPoseY.Location = new System.Drawing.Point(1026, 30);
            this.tbRightPoseY.Name = "tbRightPoseY";
            this.tbRightPoseY.ReadOnly = true;
            this.tbRightPoseY.Size = new System.Drawing.Size(75, 21);
            this.tbRightPoseY.TabIndex = 154;
            this.tbRightPoseY.Text = "0";
            // 
            // tbRightPoseX
            // 
            this.tbRightPoseX.Location = new System.Drawing.Point(950, 30);
            this.tbRightPoseX.Name = "tbRightPoseX";
            this.tbRightPoseX.ReadOnly = true;
            this.tbRightPoseX.Size = new System.Drawing.Size(75, 21);
            this.tbRightPoseX.TabIndex = 155;
            this.tbRightPoseX.Text = "0";
            // 
            // label81
            // 
            this.label81.AutoSize = true;
            this.label81.Location = new System.Drawing.Point(1196, 33);
            this.label81.Name = "label81";
            this.label81.Size = new System.Drawing.Size(40, 12);
            this.label81.TabIndex = 156;
            this.label81.Text = "Button";
            // 
            // tbRightButton
            // 
            this.tbRightButton.Location = new System.Drawing.Point(1260, 30);
            this.tbRightButton.Name = "tbRightButton";
            this.tbRightButton.ReadOnly = true;
            this.tbRightButton.Size = new System.Drawing.Size(75, 21);
            this.tbRightButton.TabIndex = 155;
            this.tbRightButton.Text = "0";
            // 
            // form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1358, 604);
            this.Controls.Add(this.groupBox9);
            this.Controls.Add(this.tbRightButton);
            this.Controls.Add(this.tbLeftButton);
            this.Controls.Add(this.tbRightPoseX);
            this.Controls.Add(this.tbLeftPoseX);
            this.Controls.Add(this.tbLBuff3J3);
            this.Controls.Add(this.tbRightPoseY);
            this.Controls.Add(this.tbLeftPoseY);
            this.Controls.Add(this.tbRightPoseZ);
            this.Controls.Add(this.tbLBuff3J2);
            this.Controls.Add(this.tbLeftPoseZ);
            this.Controls.Add(this.label78);
            this.Controls.Add(this.label81);
            this.Controls.Add(this.label74);
            this.Controls.Add(this.label70);
            this.Controls.Add(this.tbLBuff3J1);
            this.Controls.Add(this.label67);
            this.Controls.Add(this.label68);
            this.Controls.Add(this.label69);
            this.Controls.Add(this.tbLBuff2J3);
            this.Controls.Add(this.tbLBuff2J2);
            this.Controls.Add(this.tbLBuff2J1);
            this.Controls.Add(this.tbLBuff1J3);
            this.Controls.Add(this.tbLBuff1J2);
            this.Controls.Add(this.tbLBuff1J1);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.tbRBuff3J3);
            this.Controls.Add(this.tbRBuff3J2);
            this.Controls.Add(this.tbRBuff3J1);
            this.Controls.Add(this.label61);
            this.Controls.Add(this.label62);
            this.Controls.Add(this.label63);
            this.Controls.Add(this.tbRBuff2J3);
            this.Controls.Add(this.tbRBuff2J2);
            this.Controls.Add(this.tbRBuff2J1);
            this.Controls.Add(this.tbRBuff1J3);
            this.Controls.Add(this.tbRBuff1J2);
            this.Controls.Add(this.tbRBuff1J1);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.tbPosZDGain);
            this.Controls.Add(this.tbPosZIGain);
            this.Controls.Add(this.tbPosZPGain);
            this.Controls.Add(this.tbPosYDGain);
            this.Controls.Add(this.tbPosYIGain);
            this.Controls.Add(this.tbPosYPGain);
            this.Controls.Add(this.tbPosXDGain);
            this.Controls.Add(this.tbPosXIGain);
            this.Controls.Add(this.tbPosXPGain);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.btnSetCartesianMode);
            this.Controls.Add(this.btnSetJointMode);
            this.Controls.Add(this.btnDemoPose4);
            this.Controls.Add(this.btnDemoPose3);
            this.Controls.Add(this.btnDemoPose2);
            this.Controls.Add(this.btnReadyPose);
            this.Controls.Add(this.btnDemoPose1);
            this.Controls.Add(this.btnSetGravityMode);
            this.Controls.Add(this.cbChartMode);
            this.Controls.Add(this.btnShowChart);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.label39);
            this.Controls.Add(this.label38);
            this.Controls.Add(this.tbLogCycle);
            this.Controls.Add(this.btLogStop);
            this.Controls.Add(this.btnDemoRun);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.tbTorqueDGain3);
            this.Controls.Add(this.tbTorqueDGain2);
            this.Controls.Add(this.tbTorqueDGain1);
            this.Controls.Add(this.btnMoveP2P);
            this.Controls.Add(this.label30);
            this.Controls.Add(this.label31);
            this.Controls.Add(this.label32);
            this.Controls.Add(this.tbTorqueIGain3);
            this.Controls.Add(this.tbTorqueIGain2);
            this.Controls.Add(this.tbTorqueIGain1);
            this.Controls.Add(this.tbTorquePGain3);
            this.Controls.Add(this.tbTorquePGain2);
            this.Controls.Add(this.tbTorquePGain1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.tbLBuff33);
            this.Controls.Add(this.tbLBuff32);
            this.Controls.Add(this.tbLBuff31);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.label29);
            this.Controls.Add(this.tbLBuff23);
            this.Controls.Add(this.tbLBuff22);
            this.Controls.Add(this.tbLBuff21);
            this.Controls.Add(this.tbLBuff13);
            this.Controls.Add(this.tbLBuff12);
            this.Controls.Add(this.tbLBuff11);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tbRBuff33);
            this.Controls.Add(this.tbRBuff32);
            this.Controls.Add(this.tbRBuff31);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.tbRBuff23);
            this.Controls.Add(this.tbRBuff22);
            this.Controls.Add(this.tbRBuff21);
            this.Controls.Add(this.tbRBuff13);
            this.Controls.Add(this.tbRBuff12);
            this.Controls.Add(this.tbRBuff11);
            this.Controls.Add(this.gbJointTargetParam);
            this.Controls.Add(this.tbJointSpringConstant3);
            this.Controls.Add(this.tbJointSpringConstant2);
            this.Controls.Add(this.tbJointSpringConstant1);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.tbJointTorqueConstant3);
            this.Controls.Add(this.tbJointTorqueConstant2);
            this.Controls.Add(this.tbJointTorqueConstant1);
            this.Controls.Add(this.tbJointEfficiency3);
            this.Controls.Add(this.tbJointEfficiency2);
            this.Controls.Add(this.tbJointEfficiency1);
            this.Controls.Add(this.gbConstantParam);
            this.Controls.Add(this.tbPosDGain3);
            this.Controls.Add(this.tbPosDGain2);
            this.Controls.Add(this.tbPosDGain1);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.tbPosIGain3);
            this.Controls.Add(this.tbPosIGain2);
            this.Controls.Add(this.tbPosIGain1);
            this.Controls.Add(this.tbPosPGain3);
            this.Controls.Add(this.tbPosPGain2);
            this.Controls.Add(this.tbPosPGain1);
            this.Controls.Add(this.gbPositionPIDGain);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.tbRightCurrent3);
            this.Controls.Add(this.tbRightCurrent2);
            this.Controls.Add(this.tbRightCurrent1);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.tbRightVelocity3);
            this.Controls.Add(this.tbRightVelocity2);
            this.Controls.Add(this.tbRightVelocity1);
            this.Controls.Add(this.tbRightPosion3);
            this.Controls.Add(this.tbRightPosion2);
            this.Controls.Add(this.tbRightPosion1);
            this.Controls.Add(this.gbTargetParam);
            this.Controls.Add(this.bt_logging_data);
            this.Controls.Add(this.btnShowGraph);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbPz);
            this.Controls.Add(this.tbLeftCurrent3);
            this.Controls.Add(this.tbLeftCurrent2);
            this.Controls.Add(this.tbLeftCurrent1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbPy);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tbPx);
            this.Controls.Add(this.tbLeftVelocity3);
            this.Controls.Add(this.tbLeftVelocity2);
            this.Controls.Add(this.tbLeftVelocity1);
            this.Controls.Add(this.tbLeftPosion3);
            this.Controls.Add(this.tbLeftPosion2);
            this.Controls.Add(this.tbLeftPosion1);
            this.Controls.Add(this.btnEmergencyStop);
            this.Controls.Add(this.btnReady);
            this.Controls.Add(this.btnHoming);
            this.Controls.Add(this.btnServoOn);
            this.Controls.Add(this.btConnect);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbNetId);
            this.Controls.Add(this.tbPort);
            this.Controls.Add(this.gbActualParam);
            this.Name = "form";
            this.Text = "ADS Client UI";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbActualParam.ResumeLayout(false);
            this.gbActualParam.PerformLayout();
            this.gbTargetParam.ResumeLayout(false);
            this.gbTargetParam.PerformLayout();
            this.gbPositionPIDGain.ResumeLayout(false);
            this.gbConstantParam.ResumeLayout(false);
            this.gbJointTargetParam.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbJoint6Servo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbJoint3Servo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbJoint4Servo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbJoint1Servo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbConnect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbJoint5Servo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbJoint2Servo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMainPow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAuxPow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogging)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUpdateData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTargetReached)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUDPconnection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGravityMode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTorqueMode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPositionMode)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbPort;
        private System.Windows.Forms.TextBox tbNetId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        
        private TcAdsClient _tcClient;
        private AdsStream adsWriteStream;
        private AdsStream adsReadStream;
        private System.Windows.Forms.Button btConnect;
        private System.Windows.Forms.Button btnServoOn;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox tbLeftCurrent1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbLeftVelocity1;
        private System.Windows.Forms.TextBox tbLeftPosion1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button btnHoming;
        private System.Windows.Forms.Button btnEmergencyStop;
        private System.Windows.Forms.Button btnDemoRun;
        private System.Windows.Forms.Button btnReady;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.TextBox tbPx;
        private System.Windows.Forms.TextBox tbPy;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbPz;
        private System.Windows.Forms.Button btnMoveP2P;
        private System.Windows.Forms.Button bt_logging_data;
        private System.Windows.Forms.TextBox tbLeftPosion2;
        private System.Windows.Forms.TextBox tbLeftVelocity2;
        private System.Windows.Forms.TextBox tbLeftCurrent2;
        private System.Windows.Forms.TextBox tbLeftPosion3;
        private System.Windows.Forms.TextBox tbLeftVelocity3;
        private System.Windows.Forms.TextBox tbLeftCurrent3;
        private System.Windows.Forms.GroupBox gbActualParam;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbRightCurrent3;
        private System.Windows.Forms.TextBox tbRightCurrent2;
        private System.Windows.Forms.TextBox tbRightCurrent1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox tbRightVelocity3;
        private System.Windows.Forms.TextBox tbRightVelocity2;
        private System.Windows.Forms.TextBox tbRightVelocity1;
        private System.Windows.Forms.TextBox tbRightPosion3;
        private System.Windows.Forms.TextBox tbRightPosion2;
        private System.Windows.Forms.TextBox tbRightPosion1;
        private System.Windows.Forms.GroupBox gbTargetParam;
        private System.Windows.Forms.TextBox tbPosDGain3;
        private System.Windows.Forms.TextBox tbPosDGain2;
        private System.Windows.Forms.TextBox tbPosDGain1;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox tbPosIGain3;
        private System.Windows.Forms.TextBox tbPosIGain2;
        private System.Windows.Forms.TextBox tbPosIGain1;
        private System.Windows.Forms.TextBox tbPosPGain3;
        private System.Windows.Forms.TextBox tbPosPGain2;
        private System.Windows.Forms.TextBox tbPosPGain1;
        private System.Windows.Forms.GroupBox gbPositionPIDGain;
        private System.Windows.Forms.Button btnSetPosPIDGainParam;
        private System.Windows.Forms.TextBox tbJointSpringConstant3;
        private System.Windows.Forms.TextBox tbJointSpringConstant2;
        private System.Windows.Forms.TextBox tbJointSpringConstant1;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox tbJointTorqueConstant3;
        private System.Windows.Forms.TextBox tbJointTorqueConstant2;
        private System.Windows.Forms.TextBox tbJointTorqueConstant1;
        private System.Windows.Forms.TextBox tbJointEfficiency3;
        private System.Windows.Forms.TextBox tbJointEfficiency2;
        private System.Windows.Forms.TextBox tbJointEfficiency1;
        private System.Windows.Forms.GroupBox gbConstantParam;
        private System.Windows.Forms.Button btnSetJointConstantParam;
        private System.Windows.Forms.TextBox tbRBuff33;
        private System.Windows.Forms.TextBox tbRBuff32;
        private System.Windows.Forms.TextBox tbRBuff31;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox tbRBuff23;
        private System.Windows.Forms.TextBox tbRBuff22;
        private System.Windows.Forms.TextBox tbRBuff21;
        private System.Windows.Forms.TextBox tbRBuff13;
        private System.Windows.Forms.TextBox tbRBuff12;
        private System.Windows.Forms.TextBox tbRBuff11;
        private System.Windows.Forms.GroupBox gbJointTargetParam;
        private System.Windows.Forms.Button btnSetRBufferValue;
        private System.Windows.Forms.TextBox tbLBuff33;
        private System.Windows.Forms.TextBox tbLBuff32;
        private System.Windows.Forms.TextBox tbLBuff31;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.TextBox tbLBuff23;
        private System.Windows.Forms.TextBox tbLBuff22;
        private System.Windows.Forms.TextBox tbLBuff21;
        private System.Windows.Forms.TextBox tbLBuff13;
        private System.Windows.Forms.TextBox tbLBuff12;
        private System.Windows.Forms.TextBox tbLBuff11;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSetLBufferValue;
        private System.Windows.Forms.Button btnShowGraph;
        private System.Windows.Forms.TextBox tbTorqueDGain3;
        private System.Windows.Forms.TextBox tbTorqueDGain2;
        private System.Windows.Forms.TextBox tbTorqueDGain1;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.TextBox tbTorqueIGain3;
        private System.Windows.Forms.TextBox tbTorqueIGain2;
        private System.Windows.Forms.TextBox tbTorqueIGain1;
        private System.Windows.Forms.TextBox tbTorquePGain3;
        private System.Windows.Forms.TextBox tbTorquePGain2;
        private System.Windows.Forms.TextBox tbTorquePGain1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSetTorquePIDGainParam;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox tbBuffUpdate33;
        private System.Windows.Forms.TextBox tbBuffUpdate11;
        private System.Windows.Forms.TextBox tbBuffUpdate32;
        private System.Windows.Forms.TextBox tbBuffUpdate12;
        private System.Windows.Forms.TextBox tbBuffUpdate31;
        private System.Windows.Forms.TextBox tbBuffUpdate13;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.TextBox tbBuffUpdate21;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.TextBox tbBuffUpdate22;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.TextBox tbBuffUpdate23;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.TextBox tbLeftABSPosion1;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.TextBox tbLeftABSPosion2;
        private System.Windows.Forms.TextBox tbLeftABSPosion3;
        private System.Windows.Forms.Button btLogStop;
        private System.Windows.Forms.TextBox tbLogCycle;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.Label label49;
        private System.Windows.Forms.PictureBox pbJoint1Servo;
        private System.Windows.Forms.PictureBox pbConnect;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.PictureBox pbLogging;
        private System.Windows.Forms.PictureBox pbJoint2Servo;
        private System.Windows.Forms.PictureBox pbMainPow;
        private System.Windows.Forms.PictureBox pbAuxPow;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.PictureBox pbTargetReached;
        private System.Windows.Forms.PictureBox pbGravityMode;
        private System.Windows.Forms.PictureBox pbTorqueMode;
        private System.Windows.Forms.PictureBox pbPositionMode;
        private System.Windows.Forms.Label label50;
        private System.Windows.Forms.PictureBox pbUpdateData;
        private System.Windows.Forms.PictureBox pbJoint3Servo;
        private System.Windows.Forms.Label label51;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.Button btnShowChart;
        private System.Windows.Forms.ComboBox cbChartMode;
        private System.Windows.Forms.Button btnSetGravityMode;
        private System.Windows.Forms.Button btnSetJointMode;
        private System.Windows.Forms.Button btnSetCartesianMode;
        private System.Windows.Forms.TextBox tbPosZDGain;
        private System.Windows.Forms.TextBox tbPosZIGain;
        private System.Windows.Forms.TextBox tbPosZPGain;
        private System.Windows.Forms.Label label52;
        private System.Windows.Forms.Label label53;
        private System.Windows.Forms.Label label54;
        private System.Windows.Forms.TextBox tbPosYDGain;
        private System.Windows.Forms.TextBox tbPosYIGain;
        private System.Windows.Forms.TextBox tbPosYPGain;
        private System.Windows.Forms.TextBox tbPosXDGain;
        private System.Windows.Forms.TextBox tbPosXIGain;
        private System.Windows.Forms.TextBox tbPosXPGain;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btnSetCartesianPIDGain;
        private System.Windows.Forms.Label label57;
        private System.Windows.Forms.Label label56;
        private System.Windows.Forms.Label label55;
        private System.Windows.Forms.Button btnSetRJointBuff;
        private System.Windows.Forms.TextBox tbRBuff3J3;
        private System.Windows.Forms.TextBox tbRBuff3J2;
        private System.Windows.Forms.TextBox tbRBuff3J1;
        private System.Windows.Forms.Label label61;
        private System.Windows.Forms.Label label62;
        private System.Windows.Forms.Label label63;
        private System.Windows.Forms.TextBox tbRBuff2J3;
        private System.Windows.Forms.TextBox tbRBuff2J2;
        private System.Windows.Forms.TextBox tbRBuff2J1;
        private System.Windows.Forms.TextBox tbRBuff1J3;
        private System.Windows.Forms.TextBox tbRBuff1J2;
        private System.Windows.Forms.TextBox tbRBuff1J1;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button btnSetLJointBuff;
        private System.Windows.Forms.TextBox tbLBuff3J3;
        private System.Windows.Forms.TextBox tbLBuff3J2;
        private System.Windows.Forms.TextBox tbLBuff3J1;
        private System.Windows.Forms.Label label67;
        private System.Windows.Forms.Label label68;
        private System.Windows.Forms.Label label69;
        private System.Windows.Forms.TextBox tbLBuff2J3;
        private System.Windows.Forms.TextBox tbLBuff2J2;
        private System.Windows.Forms.TextBox tbLBuff2J1;
        private System.Windows.Forms.TextBox tbLBuff1J3;
        private System.Windows.Forms.TextBox tbLBuff1J2;
        private System.Windows.Forms.TextBox tbLBuff1J1;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.TextBox tbLeftPoseX;
        private System.Windows.Forms.TextBox tbLeftPoseY;
        private System.Windows.Forms.TextBox tbLeftPoseZ;
        private System.Windows.Forms.Label label70;
        private System.Windows.Forms.Button btnDemoPose1;
        private System.Windows.Forms.Button btnDemoPose2;
        private System.Windows.Forms.Button btnDemoPose3;
        private System.Windows.Forms.Button btnDemoPose4;
        private System.Windows.Forms.Button btnReadyPose;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.Button UDP_Connect;
        private System.Windows.Forms.Label label71;
        private System.Windows.Forms.PictureBox pbUDPconnection;
        private System.Windows.Forms.Label label73;
        private System.Windows.Forms.Label label72;
        private System.Windows.Forms.TextBox tbUDPport;
        private System.Windows.Forms.TextBox tbIPadress;
        private System.Windows.Forms.TextBox tbLeftButton;
        private System.Windows.Forms.Label label74;
        private System.Windows.Forms.PictureBox pbJoint6Servo;
        private System.Windows.Forms.Label label77;
        private System.Windows.Forms.Label label76;
        private System.Windows.Forms.Label label75;
        private System.Windows.Forms.PictureBox pbJoint4Servo;
        private System.Windows.Forms.PictureBox pbJoint5Servo;
        private System.Windows.Forms.Label label78;
        private System.Windows.Forms.TextBox tbRightPoseZ;
        private System.Windows.Forms.TextBox tbRightPoseY;
        private System.Windows.Forms.TextBox tbRightPoseX;
        private System.Windows.Forms.Label label79;
        private System.Windows.Forms.TextBox tbRightABSPosion1;
        private System.Windows.Forms.Label label80;
        private System.Windows.Forms.TextBox tbRightABSPosion2;
        private System.Windows.Forms.TextBox tbRightABSPosion3;
        private System.Windows.Forms.Label label81;
        private System.Windows.Forms.TextBox tbRightButton;
    }
}

