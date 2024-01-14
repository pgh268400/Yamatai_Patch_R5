// Decompiled with JetBrains decompiler
// Type: WindowsFormsApplication1.btn_runspeed
// Assembly: YAMATAIPatch R4, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5B3BBAAE-6003-4740-8AF6-CC1446CB3A90
// Assembly location: F:\Download\Compressed\yamatai4 (2)\YAMATAIPatch R4.exe

using CheatComponents;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public class main : Form
    {


        private IContainer components;
        private Label label1;
        private Timer ConnectionTimer;
        private Panel panel_1;
        private Button btn_levitate;
        private Button btn_hover_down;
        private Button btn_hover_up;
        private Button btn_hover_none;
        private Label label2;
        private Panel panel_2;
        private Panel panel_0;
        private Button btn_upgrades;
        private Button btn_reload;
        private Button btn_skillpoints;
        private Label label4;
        private Panel panel_3;
        private Button btn_jiggletitsmega;
        private Button btn_jiggletitson;
        private Button btn_jiggletitsoff;
        private Button btn_normaltits;
        private Label label5;
        private Button btn_damagesquared;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private RichTextBox savebox;
        private Label label7;
        private Timer timer2;
        private Label statusLabel;
        private Label label11;
        private Label label12;
        private Timer blitTimer;
        private Label fontLabel;
        private Timer blitLengthTimer;
        private RichTextBox settingsBox;
        private Button btn_salvagepoints;
        private Button btn_ammo;
        private Button btn_health;
        private Button btn_biggertits;
        private Button btn_bigtits;
        private Button btn_noclip;
        private LinkLabel linkLabel1;
        private LinkLabel linkLabel2;
        private Button btn_restore_position;
        private Button btn_save_potition;
        private CheckBox cbAutoUpdate;
        private CheckBox cbOverlay;
        private Label label3;
        private Button btn_smalltits;
        private Button btn_runspeedplusplus;
        private Button btn_runspeedplus;
        private Button btn_runspeednormal;
        private Button btn_jumpheight_2;
        private Button btn_jumpheight_3;
        private Button btn_jumpheight_1;
        private Button btn_jumpheight_0;
        private Button btn_warpdown;
        private Button btn_warpup;
        private Button btn_warpeast;
        private Button btn_warpwest;
        private Button btn_warpsouth;
        private Button btn_warpnorth;
        private Button btn_edit_PlayerZ;
        private Button btn_edit_PlayerY;
        private Button btn_edit_PlayerX;
        private Label label6;
        private Button btn_nudge_cam_down;
        private Button btn_nudge_cam_up;
        private Button btn_nudge_cam_east;
        private Button btn_nudge_cam_west;
        private Button btn_nudge_cam_south;
        private Button btn_nudge_cam_north;
        private Button btn_edit_cam_z;
        private Button btn_edit_cam_y;
        private Button btn_edit_cam_x;
        private Button btn_invisible_lara;
        private Button btn_lock_cam_yaw;
        private Button btn_lock_cam_pitch;
        private Button btn_lock_cam_z;
        private Button btn_lock_cam_y;
        private Button btn_lock_cam_x;
        private Button btn_camchasefar;
        private Button btn_cam_zoom;
        private Button btn_no_wobble;
        private TabPage tabPage10;
        private TabPage tabPage11;
        private TabPage tabPage3;
        private Label label13;
        private Button btn_salvagearrows;
        private Button btn_spawnwolves;
        private Button button2;
        private TrackBar trackbarcamera;
        private Button btn_nudge_dist_down;
        private Button btn_nudge_dist_up;
        private TrackBar trackbarPlayer;
        private Button btn_player_nudge_dist_down;
        private Button btn_player_nudge_dist_up;
        private Button btn_clean_lara;
        private Button btn_normal_ammo;
        private Button btn_no_weaps;
        private Button btn_static_lara;
        private Button btn_bright_norm;
        private Button btn_bright_4;
        private Button btn_bright_3;
        private Button btn_bright_2;
        private Button btn_bright_1;
        private Button btn_bright_0;
        private Button btn_rgb_boost;
        private Button btn_contrast_hi;
        private Button btn_contrast_low;
        private Button btn_contrast_norm;
        private Panel panel_4;
        private RichTextBox richTextBox3;
        private CheckBox cbKeybinds;
        private RichTextBox richTextBox2;
        private Label label10;
        private Label label9;
        private Label Debugging;
        private Label label8;
        private RichTextBox richTextBox1;
        private TabPage tabPage4;
        private Button btn_runspeed_walk;
        private Button btn_outfits;
        public static Label sLabel;
        public float panelLeft = -550f;
        public int panelWidth = 450;
        public static CheatButton lastButton;
        public static main staticSelf;
        public static RichTextBox sBox;

        public List<float> panelTargs = new List<float>()
        {
            0.0f,
            -550f,
            -550f,
            -550f,
            -550f,
            -550f,
            -550f,
            -550f,
            -550f
        };

        public List<float> panelCurrent = new List<float>()
        {
            0.0f,
            -550f,
            -550f,
            -550f,
            -550f,
            -550f,
            -550f,
            -550f,
            -550f
        };

        public List<Panel> panelList = new List<Panel>();
        public CheckBox[] saveableCheckBoxes;
        public CheatButton cheatButton_playerX;
        public CheatButton cheatButton_playerY;
        public CheatButton cheatButton_playerZ;
        public CheatButton cheatButton_camX;
        public CheatButton cheatButton_camY;
        public CheatButton cheatButton_camZ;
        private bool positionSaved;
        private float savedX;
        private float savedY;
        private LinkLabel linkLabel3;
        private float savedZ;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();
            base.Dispose(disposing);
        }

        // 폼 디자인 시작 함수
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.ConnectionTimer = new System.Windows.Forms.Timer(this.components);
            this.panel_1 = new System.Windows.Forms.Panel();
            this.btn_static_lara = new System.Windows.Forms.Button();
            this.trackbarPlayer = new System.Windows.Forms.TrackBar();
            this.btn_player_nudge_dist_down = new System.Windows.Forms.Button();
            this.btn_player_nudge_dist_up = new System.Windows.Forms.Button();
            this.btn_warpdown = new System.Windows.Forms.Button();
            this.btn_warpup = new System.Windows.Forms.Button();
            this.btn_warpeast = new System.Windows.Forms.Button();
            this.btn_warpwest = new System.Windows.Forms.Button();
            this.btn_warpsouth = new System.Windows.Forms.Button();
            this.btn_warpnorth = new System.Windows.Forms.Button();
            this.btn_edit_PlayerZ = new System.Windows.Forms.Button();
            this.btn_edit_PlayerY = new System.Windows.Forms.Button();
            this.btn_edit_PlayerX = new System.Windows.Forms.Button();
            this.btn_restore_position = new System.Windows.Forms.Button();
            this.btn_save_potition = new System.Windows.Forms.Button();
            this.btn_noclip = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_levitate = new System.Windows.Forms.Button();
            this.btn_hover_down = new System.Windows.Forms.Button();
            this.btn_hover_up = new System.Windows.Forms.Button();
            this.btn_hover_none = new System.Windows.Forms.Button();
            this.panel_2 = new System.Windows.Forms.Panel();
            this.trackbarcamera = new System.Windows.Forms.TrackBar();
            this.btn_nudge_dist_down = new System.Windows.Forms.Button();
            this.btn_nudge_dist_up = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.btn_no_wobble = new System.Windows.Forms.Button();
            this.btn_cam_zoom = new System.Windows.Forms.Button();
            this.btn_camchasefar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_nudge_cam_down = new System.Windows.Forms.Button();
            this.btn_nudge_cam_up = new System.Windows.Forms.Button();
            this.btn_nudge_cam_east = new System.Windows.Forms.Button();
            this.btn_nudge_cam_west = new System.Windows.Forms.Button();
            this.btn_nudge_cam_south = new System.Windows.Forms.Button();
            this.btn_nudge_cam_north = new System.Windows.Forms.Button();
            this.btn_edit_cam_z = new System.Windows.Forms.Button();
            this.btn_edit_cam_y = new System.Windows.Forms.Button();
            this.btn_edit_cam_x = new System.Windows.Forms.Button();
            this.btn_invisible_lara = new System.Windows.Forms.Button();
            this.btn_lock_cam_yaw = new System.Windows.Forms.Button();
            this.btn_lock_cam_pitch = new System.Windows.Forms.Button();
            this.btn_lock_cam_z = new System.Windows.Forms.Button();
            this.btn_lock_cam_y = new System.Windows.Forms.Button();
            this.btn_lock_cam_x = new System.Windows.Forms.Button();
            this.panel_0 = new System.Windows.Forms.Panel();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.btn_runspeed_walk = new System.Windows.Forms.Button();
            this.btn_normal_ammo = new System.Windows.Forms.Button();
            this.btn_spawnwolves = new System.Windows.Forms.Button();
            this.btn_salvagearrows = new System.Windows.Forms.Button();
            this.btn_runspeedplusplus = new System.Windows.Forms.Button();
            this.btn_runspeedplus = new System.Windows.Forms.Button();
            this.btn_runspeednormal = new System.Windows.Forms.Button();
            this.btn_jumpheight_2 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.btn_jumpheight_3 = new System.Windows.Forms.Button();
            this.statusLabel = new System.Windows.Forms.Label();
            this.btn_jumpheight_1 = new System.Windows.Forms.Button();
            this.btn_jumpheight_0 = new System.Windows.Forms.Button();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.btn_salvagepoints = new System.Windows.Forms.Button();
            this.btn_ammo = new System.Windows.Forms.Button();
            this.btn_health = new System.Windows.Forms.Button();
            this.btn_damagesquared = new System.Windows.Forms.Button();
            this.btn_upgrades = new System.Windows.Forms.Button();
            this.btn_reload = new System.Windows.Forms.Button();
            this.btn_skillpoints = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.panel_3 = new System.Windows.Forms.Panel();
            this.btn_contrast_low = new System.Windows.Forms.Button();
            this.btn_contrast_norm = new System.Windows.Forms.Button();
            this.btn_contrast_hi = new System.Windows.Forms.Button();
            this.btn_rgb_boost = new System.Windows.Forms.Button();
            this.btn_bright_norm = new System.Windows.Forms.Button();
            this.btn_bright_4 = new System.Windows.Forms.Button();
            this.btn_bright_3 = new System.Windows.Forms.Button();
            this.btn_bright_2 = new System.Windows.Forms.Button();
            this.btn_bright_1 = new System.Windows.Forms.Button();
            this.btn_bright_0 = new System.Windows.Forms.Button();
            this.btn_no_weaps = new System.Windows.Forms.Button();
            this.btn_clean_lara = new System.Windows.Forms.Button();
            this.btn_smalltits = new System.Windows.Forms.Button();
            this.btn_biggertits = new System.Windows.Forms.Button();
            this.btn_bigtits = new System.Windows.Forms.Button();
            this.btn_jiggletitsmega = new System.Windows.Forms.Button();
            this.btn_jiggletitson = new System.Windows.Forms.Button();
            this.btn_jiggletitsoff = new System.Windows.Forms.Button();
            this.btn_normaltits = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage10 = new System.Windows.Forms.TabPage();
            this.tabPage11 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.savebox = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.label11 = new System.Windows.Forms.Label();
            this.blitTimer = new System.Windows.Forms.Timer(this.components);
            this.fontLabel = new System.Windows.Forms.Label();
            this.blitLengthTimer = new System.Windows.Forms.Timer(this.components);
            this.settingsBox = new System.Windows.Forms.RichTextBox();
            this.cbAutoUpdate = new System.Windows.Forms.CheckBox();
            this.cbOverlay = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.panel_4 = new System.Windows.Forms.Panel();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.cbKeybinds = new System.Windows.Forms.CheckBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Debugging = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btn_outfits = new System.Windows.Forms.Button();
            this.panel_1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackbarPlayer)).BeginInit();
            this.panel_2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackbarcamera)).BeginInit();
            this.panel_0.SuspendLayout();
            this.panel_3.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.panel_4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2861, 144);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // ConnectionTimer
            // 
            this.ConnectionTimer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel_1
            // 
            this.panel_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_1.Controls.Add(this.btn_static_lara);
            this.panel_1.Controls.Add(this.trackbarPlayer);
            this.panel_1.Controls.Add(this.btn_player_nudge_dist_down);
            this.panel_1.Controls.Add(this.btn_player_nudge_dist_up);
            this.panel_1.Controls.Add(this.btn_warpdown);
            this.panel_1.Controls.Add(this.btn_warpup);
            this.panel_1.Controls.Add(this.btn_warpeast);
            this.panel_1.Controls.Add(this.btn_warpwest);
            this.panel_1.Controls.Add(this.btn_warpsouth);
            this.panel_1.Controls.Add(this.btn_warpnorth);
            this.panel_1.Controls.Add(this.btn_edit_PlayerZ);
            this.panel_1.Controls.Add(this.btn_edit_PlayerY);
            this.panel_1.Controls.Add(this.btn_edit_PlayerX);
            this.panel_1.Controls.Add(this.btn_restore_position);
            this.panel_1.Controls.Add(this.btn_save_potition);
            this.panel_1.Controls.Add(this.btn_noclip);
            this.panel_1.Controls.Add(this.label2);
            this.panel_1.Controls.Add(this.btn_levitate);
            this.panel_1.Controls.Add(this.btn_hover_down);
            this.panel_1.Controls.Add(this.btn_hover_up);
            this.panel_1.Controls.Add(this.btn_hover_none);
            this.panel_1.Location = new System.Drawing.Point(554, 22);
            this.panel_1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel_1.Name = "panel_1";
            this.panel_1.Size = new System.Drawing.Size(525, 506);
            this.panel_1.TabIndex = 24;
            this.panel_1.Tag = "2";
            // 
            // btn_static_lara
            // 
            this.btn_static_lara.Location = new System.Drawing.Point(19, 262);
            this.btn_static_lara.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_static_lara.Name = "btn_static_lara";
            this.btn_static_lara.Size = new System.Drawing.Size(233, 37);
            this.btn_static_lara.TabIndex = 56;
            this.btn_static_lara.Text = "static lara";
            this.btn_static_lara.UseVisualStyleBackColor = true;
            // 
            // trackbarPlayer
            // 
            this.trackbarPlayer.Location = new System.Drawing.Point(14, 458);
            this.trackbarPlayer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.trackbarPlayer.Maximum = 100;
            this.trackbarPlayer.Minimum = 1;
            this.trackbarPlayer.Name = "trackbarPlayer";
            this.trackbarPlayer.Size = new System.Drawing.Size(485, 45);
            this.trackbarPlayer.TabIndex = 55;
            this.trackbarPlayer.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.trackbarPlayer.Value = 50;
            // 
            // btn_player_nudge_dist_down
            // 
            this.btn_player_nudge_dist_down.Location = new System.Drawing.Point(9, 417);
            this.btn_player_nudge_dist_down.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_player_nudge_dist_down.Name = "btn_player_nudge_dist_down";
            this.btn_player_nudge_dist_down.Size = new System.Drawing.Size(233, 37);
            this.btn_player_nudge_dist_down.TabIndex = 54;
            this.btn_player_nudge_dist_down.Text = "warpdown";
            this.btn_player_nudge_dist_down.UseVisualStyleBackColor = true;
            // 
            // btn_player_nudge_dist_up
            // 
            this.btn_player_nudge_dist_up.Location = new System.Drawing.Point(271, 417);
            this.btn_player_nudge_dist_up.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_player_nudge_dist_up.Name = "btn_player_nudge_dist_up";
            this.btn_player_nudge_dist_up.Size = new System.Drawing.Size(233, 37);
            this.btn_player_nudge_dist_up.TabIndex = 53;
            this.btn_player_nudge_dist_up.Text = "warpdown";
            this.btn_player_nudge_dist_up.UseVisualStyleBackColor = true;
            // 
            // btn_warpdown
            // 
            this.btn_warpdown.Location = new System.Drawing.Point(271, 366);
            this.btn_warpdown.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_warpdown.Name = "btn_warpdown";
            this.btn_warpdown.Size = new System.Drawing.Size(233, 37);
            this.btn_warpdown.TabIndex = 52;
            this.btn_warpdown.Text = "warpdown";
            this.btn_warpdown.UseVisualStyleBackColor = true;
            // 
            // btn_warpup
            // 
            this.btn_warpup.Location = new System.Drawing.Point(271, 325);
            this.btn_warpup.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_warpup.Name = "btn_warpup";
            this.btn_warpup.Size = new System.Drawing.Size(233, 37);
            this.btn_warpup.TabIndex = 51;
            this.btn_warpup.Text = "warpup";
            this.btn_warpup.UseVisualStyleBackColor = true;
            // 
            // btn_warpeast
            // 
            this.btn_warpeast.Location = new System.Drawing.Point(271, 284);
            this.btn_warpeast.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_warpeast.Name = "btn_warpeast";
            this.btn_warpeast.Size = new System.Drawing.Size(233, 37);
            this.btn_warpeast.TabIndex = 50;
            this.btn_warpeast.Text = "warpeast";
            this.btn_warpeast.UseVisualStyleBackColor = true;
            // 
            // btn_warpwest
            // 
            this.btn_warpwest.Location = new System.Drawing.Point(271, 244);
            this.btn_warpwest.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_warpwest.Name = "btn_warpwest";
            this.btn_warpwest.Size = new System.Drawing.Size(233, 37);
            this.btn_warpwest.TabIndex = 49;
            this.btn_warpwest.Text = "warpwest";
            this.btn_warpwest.UseVisualStyleBackColor = true;
            // 
            // btn_warpsouth
            // 
            this.btn_warpsouth.Location = new System.Drawing.Point(271, 203);
            this.btn_warpsouth.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_warpsouth.Name = "btn_warpsouth";
            this.btn_warpsouth.Size = new System.Drawing.Size(233, 37);
            this.btn_warpsouth.TabIndex = 48;
            this.btn_warpsouth.Text = "warpsouth";
            this.btn_warpsouth.UseVisualStyleBackColor = true;
            // 
            // btn_warpnorth
            // 
            this.btn_warpnorth.Location = new System.Drawing.Point(271, 162);
            this.btn_warpnorth.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_warpnorth.Name = "btn_warpnorth";
            this.btn_warpnorth.Size = new System.Drawing.Size(233, 37);
            this.btn_warpnorth.TabIndex = 47;
            this.btn_warpnorth.Text = "warpnorth";
            this.btn_warpnorth.UseVisualStyleBackColor = true;
            // 
            // btn_edit_PlayerZ
            // 
            this.btn_edit_PlayerZ.Location = new System.Drawing.Point(271, 111);
            this.btn_edit_PlayerZ.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_edit_PlayerZ.Name = "btn_edit_PlayerZ";
            this.btn_edit_PlayerZ.Size = new System.Drawing.Size(233, 37);
            this.btn_edit_PlayerZ.TabIndex = 46;
            this.btn_edit_PlayerZ.Text = "playerZ";
            this.btn_edit_PlayerZ.UseVisualStyleBackColor = true;
            // 
            // btn_edit_PlayerY
            // 
            this.btn_edit_PlayerY.Location = new System.Drawing.Point(271, 70);
            this.btn_edit_PlayerY.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_edit_PlayerY.Name = "btn_edit_PlayerY";
            this.btn_edit_PlayerY.Size = new System.Drawing.Size(233, 37);
            this.btn_edit_PlayerY.TabIndex = 45;
            this.btn_edit_PlayerY.Text = "playerY";
            this.btn_edit_PlayerY.UseVisualStyleBackColor = true;
            // 
            // btn_edit_PlayerX
            // 
            this.btn_edit_PlayerX.Location = new System.Drawing.Point(271, 30);
            this.btn_edit_PlayerX.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_edit_PlayerX.Name = "btn_edit_PlayerX";
            this.btn_edit_PlayerX.Size = new System.Drawing.Size(233, 37);
            this.btn_edit_PlayerX.TabIndex = 44;
            this.btn_edit_PlayerX.Text = "playerX";
            this.btn_edit_PlayerX.UseVisualStyleBackColor = true;
            // 
            // btn_restore_position
            // 
            this.btn_restore_position.Location = new System.Drawing.Point(19, 366);
            this.btn_restore_position.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_restore_position.Name = "btn_restore_position";
            this.btn_restore_position.Size = new System.Drawing.Size(233, 37);
            this.btn_restore_position.TabIndex = 43;
            this.btn_restore_position.Text = "restoreposition";
            this.btn_restore_position.UseVisualStyleBackColor = true;
            // 
            // btn_save_potition
            // 
            this.btn_save_potition.Location = new System.Drawing.Point(19, 325);
            this.btn_save_potition.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_save_potition.Name = "btn_save_potition";
            this.btn_save_potition.Size = new System.Drawing.Size(233, 37);
            this.btn_save_potition.TabIndex = 42;
            this.btn_save_potition.Text = "saveposition";
            this.btn_save_potition.UseVisualStyleBackColor = true;
            // 
            // btn_noclip
            // 
            this.btn_noclip.Location = new System.Drawing.Point(19, 218);
            this.btn_noclip.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_noclip.Name = "btn_noclip";
            this.btn_noclip.Size = new System.Drawing.Size(233, 37);
            this.btn_noclip.TabIndex = 41;
            this.btn_noclip.Text = "noclip";
            this.btn_noclip.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 15);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 15);
            this.label2.TabIndex = 28;
            this.label2.Text = "Position";
            // 
            // btn_levitate
            // 
            this.btn_levitate.Location = new System.Drawing.Point(19, 174);
            this.btn_levitate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_levitate.Name = "btn_levitate";
            this.btn_levitate.Size = new System.Drawing.Size(233, 37);
            this.btn_levitate.TabIndex = 26;
            this.btn_levitate.Text = "levitate";
            this.btn_levitate.UseVisualStyleBackColor = true;
            // 
            // btn_hover_down
            // 
            this.btn_hover_down.Location = new System.Drawing.Point(19, 126);
            this.btn_hover_down.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_hover_down.Name = "btn_hover_down";
            this.btn_hover_down.Size = new System.Drawing.Size(233, 37);
            this.btn_hover_down.TabIndex = 25;
            this.btn_hover_down.Text = "hover down";
            this.btn_hover_down.UseVisualStyleBackColor = true;
            // 
            // btn_hover_up
            // 
            this.btn_hover_up.Location = new System.Drawing.Point(19, 85);
            this.btn_hover_up.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_hover_up.Name = "btn_hover_up";
            this.btn_hover_up.Size = new System.Drawing.Size(233, 37);
            this.btn_hover_up.TabIndex = 24;
            this.btn_hover_up.Text = "hover up";
            this.btn_hover_up.UseVisualStyleBackColor = true;
            // 
            // btn_hover_none
            // 
            this.btn_hover_none.Location = new System.Drawing.Point(19, 44);
            this.btn_hover_none.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_hover_none.Name = "btn_hover_none";
            this.btn_hover_none.Size = new System.Drawing.Size(233, 37);
            this.btn_hover_none.TabIndex = 23;
            this.btn_hover_none.Text = "hover none";
            this.btn_hover_none.UseVisualStyleBackColor = true;
            this.btn_hover_none.Click += new System.EventHandler(this.editButton_weapons_Click);
            // 
            // panel_2
            // 
            this.panel_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_2.Controls.Add(this.trackbarcamera);
            this.panel_2.Controls.Add(this.btn_nudge_dist_down);
            this.panel_2.Controls.Add(this.btn_nudge_dist_up);
            this.panel_2.Controls.Add(this.label13);
            this.panel_2.Controls.Add(this.btn_no_wobble);
            this.panel_2.Controls.Add(this.btn_cam_zoom);
            this.panel_2.Controls.Add(this.btn_camchasefar);
            this.panel_2.Controls.Add(this.label6);
            this.panel_2.Controls.Add(this.btn_nudge_cam_down);
            this.panel_2.Controls.Add(this.btn_nudge_cam_up);
            this.panel_2.Controls.Add(this.btn_nudge_cam_east);
            this.panel_2.Controls.Add(this.btn_nudge_cam_west);
            this.panel_2.Controls.Add(this.btn_nudge_cam_south);
            this.panel_2.Controls.Add(this.btn_nudge_cam_north);
            this.panel_2.Controls.Add(this.btn_edit_cam_z);
            this.panel_2.Controls.Add(this.btn_edit_cam_y);
            this.panel_2.Controls.Add(this.btn_edit_cam_x);
            this.panel_2.Controls.Add(this.btn_invisible_lara);
            this.panel_2.Controls.Add(this.btn_lock_cam_yaw);
            this.panel_2.Controls.Add(this.btn_lock_cam_pitch);
            this.panel_2.Controls.Add(this.btn_lock_cam_z);
            this.panel_2.Controls.Add(this.btn_lock_cam_y);
            this.panel_2.Controls.Add(this.btn_lock_cam_x);
            this.panel_2.Location = new System.Drawing.Point(1101, 22);
            this.panel_2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel_2.Name = "panel_2";
            this.panel_2.Size = new System.Drawing.Size(525, 506);
            this.panel_2.TabIndex = 25;
            this.panel_2.Tag = "4";
            this.panel_2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_5_Paint);
            // 
            // trackbarcamera
            // 
            this.trackbarcamera.Location = new System.Drawing.Point(23, 458);
            this.trackbarcamera.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.trackbarcamera.Maximum = 100;
            this.trackbarcamera.Minimum = 1;
            this.trackbarcamera.Name = "trackbarcamera";
            this.trackbarcamera.Size = new System.Drawing.Size(485, 45);
            this.trackbarcamera.TabIndex = 51;
            this.trackbarcamera.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.trackbarcamera.Value = 50;
            // 
            // btn_nudge_dist_down
            // 
            this.btn_nudge_dist_down.Location = new System.Drawing.Point(19, 417);
            this.btn_nudge_dist_down.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_nudge_dist_down.Name = "btn_nudge_dist_down";
            this.btn_nudge_dist_down.Size = new System.Drawing.Size(233, 37);
            this.btn_nudge_dist_down.TabIndex = 50;
            this.btn_nudge_dist_down.Text = "warpdown";
            this.btn_nudge_dist_down.UseVisualStyleBackColor = true;
            // 
            // btn_nudge_dist_up
            // 
            this.btn_nudge_dist_up.Location = new System.Drawing.Point(280, 417);
            this.btn_nudge_dist_up.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_nudge_dist_up.Name = "btn_nudge_dist_up";
            this.btn_nudge_dist_up.Size = new System.Drawing.Size(233, 37);
            this.btn_nudge_dist_up.TabIndex = 49;
            this.btn_nudge_dist_up.Text = "warpdown";
            this.btn_nudge_dist_up.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(271, 11);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(115, 15);
            this.label13.TabIndex = 48;
            this.label13.Text = "Lock cam to modify:";
            // 
            // btn_no_wobble
            // 
            this.btn_no_wobble.Location = new System.Drawing.Point(19, 248);
            this.btn_no_wobble.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_no_wobble.Name = "btn_no_wobble";
            this.btn_no_wobble.Size = new System.Drawing.Size(233, 37);
            this.btn_no_wobble.TabIndex = 47;
            this.btn_no_wobble.Text = "no wobble/wind";
            this.btn_no_wobble.UseVisualStyleBackColor = true;
            // 
            // btn_cam_zoom
            // 
            this.btn_cam_zoom.Location = new System.Drawing.Point(19, 329);
            this.btn_cam_zoom.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_cam_zoom.Name = "btn_cam_zoom";
            this.btn_cam_zoom.Size = new System.Drawing.Size(233, 37);
            this.btn_cam_zoom.TabIndex = 46;
            this.btn_cam_zoom.Text = "cam zoom";
            this.btn_cam_zoom.UseVisualStyleBackColor = true;
            // 
            // btn_camchasefar
            // 
            this.btn_camchasefar.Location = new System.Drawing.Point(19, 288);
            this.btn_camchasefar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_camchasefar.Name = "btn_camchasefar";
            this.btn_camchasefar.Size = new System.Drawing.Size(233, 37);
            this.btn_camchasefar.TabIndex = 45;
            this.btn_camchasefar.Text = "cam chase far";
            this.btn_camchasefar.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(14, 7);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 15);
            this.label6.TabIndex = 44;
            this.label6.Text = "Camera";
            // 
            // btn_nudge_cam_down
            // 
            this.btn_nudge_cam_down.Location = new System.Drawing.Point(271, 369);
            this.btn_nudge_cam_down.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_nudge_cam_down.Name = "btn_nudge_cam_down";
            this.btn_nudge_cam_down.Size = new System.Drawing.Size(233, 37);
            this.btn_nudge_cam_down.TabIndex = 43;
            this.btn_nudge_cam_down.Text = "warpdown";
            this.btn_nudge_cam_down.UseVisualStyleBackColor = true;
            // 
            // btn_nudge_cam_up
            // 
            this.btn_nudge_cam_up.Location = new System.Drawing.Point(271, 329);
            this.btn_nudge_cam_up.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_nudge_cam_up.Name = "btn_nudge_cam_up";
            this.btn_nudge_cam_up.Size = new System.Drawing.Size(233, 37);
            this.btn_nudge_cam_up.TabIndex = 42;
            this.btn_nudge_cam_up.Text = "warpup";
            this.btn_nudge_cam_up.UseVisualStyleBackColor = true;
            // 
            // btn_nudge_cam_east
            // 
            this.btn_nudge_cam_east.Location = new System.Drawing.Point(271, 288);
            this.btn_nudge_cam_east.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_nudge_cam_east.Name = "btn_nudge_cam_east";
            this.btn_nudge_cam_east.Size = new System.Drawing.Size(233, 37);
            this.btn_nudge_cam_east.TabIndex = 41;
            this.btn_nudge_cam_east.Text = "warpeast";
            this.btn_nudge_cam_east.UseVisualStyleBackColor = true;
            // 
            // btn_nudge_cam_west
            // 
            this.btn_nudge_cam_west.Location = new System.Drawing.Point(271, 247);
            this.btn_nudge_cam_west.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_nudge_cam_west.Name = "btn_nudge_cam_west";
            this.btn_nudge_cam_west.Size = new System.Drawing.Size(233, 37);
            this.btn_nudge_cam_west.TabIndex = 40;
            this.btn_nudge_cam_west.Text = "warpwest";
            this.btn_nudge_cam_west.UseVisualStyleBackColor = true;
            // 
            // btn_nudge_cam_south
            // 
            this.btn_nudge_cam_south.Location = new System.Drawing.Point(271, 207);
            this.btn_nudge_cam_south.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_nudge_cam_south.Name = "btn_nudge_cam_south";
            this.btn_nudge_cam_south.Size = new System.Drawing.Size(233, 37);
            this.btn_nudge_cam_south.TabIndex = 39;
            this.btn_nudge_cam_south.Text = "warpsouth";
            this.btn_nudge_cam_south.UseVisualStyleBackColor = true;
            // 
            // btn_nudge_cam_north
            // 
            this.btn_nudge_cam_north.Location = new System.Drawing.Point(271, 166);
            this.btn_nudge_cam_north.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_nudge_cam_north.Name = "btn_nudge_cam_north";
            this.btn_nudge_cam_north.Size = new System.Drawing.Size(233, 37);
            this.btn_nudge_cam_north.TabIndex = 38;
            this.btn_nudge_cam_north.Text = "warpnorth";
            this.btn_nudge_cam_north.UseVisualStyleBackColor = true;
            // 
            // btn_edit_cam_z
            // 
            this.btn_edit_cam_z.Location = new System.Drawing.Point(271, 114);
            this.btn_edit_cam_z.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_edit_cam_z.Name = "btn_edit_cam_z";
            this.btn_edit_cam_z.Size = new System.Drawing.Size(233, 37);
            this.btn_edit_cam_z.TabIndex = 37;
            this.btn_edit_cam_z.Text = "playerZ";
            this.btn_edit_cam_z.UseVisualStyleBackColor = true;
            // 
            // btn_edit_cam_y
            // 
            this.btn_edit_cam_y.Location = new System.Drawing.Point(271, 74);
            this.btn_edit_cam_y.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_edit_cam_y.Name = "btn_edit_cam_y";
            this.btn_edit_cam_y.Size = new System.Drawing.Size(233, 37);
            this.btn_edit_cam_y.TabIndex = 36;
            this.btn_edit_cam_y.Text = "playerY";
            this.btn_edit_cam_y.UseVisualStyleBackColor = true;
            // 
            // btn_edit_cam_x
            // 
            this.btn_edit_cam_x.Location = new System.Drawing.Point(271, 33);
            this.btn_edit_cam_x.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_edit_cam_x.Name = "btn_edit_cam_x";
            this.btn_edit_cam_x.Size = new System.Drawing.Size(233, 37);
            this.btn_edit_cam_x.TabIndex = 35;
            this.btn_edit_cam_x.Text = "playerX";
            this.btn_edit_cam_x.UseVisualStyleBackColor = true;
            // 
            // btn_invisible_lara
            // 
            this.btn_invisible_lara.Location = new System.Drawing.Point(18, 369);
            this.btn_invisible_lara.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_invisible_lara.Name = "btn_invisible_lara";
            this.btn_invisible_lara.Size = new System.Drawing.Size(233, 37);
            this.btn_invisible_lara.TabIndex = 29;
            this.btn_invisible_lara.Text = "invisible lara";
            this.btn_invisible_lara.UseVisualStyleBackColor = true;
            // 
            // btn_lock_cam_yaw
            // 
            this.btn_lock_cam_yaw.Location = new System.Drawing.Point(18, 196);
            this.btn_lock_cam_yaw.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_lock_cam_yaw.Name = "btn_lock_cam_yaw";
            this.btn_lock_cam_yaw.Size = new System.Drawing.Size(233, 37);
            this.btn_lock_cam_yaw.TabIndex = 28;
            this.btn_lock_cam_yaw.Text = "lockyaw";
            this.btn_lock_cam_yaw.UseVisualStyleBackColor = true;
            // 
            // btn_lock_cam_pitch
            // 
            this.btn_lock_cam_pitch.Location = new System.Drawing.Point(18, 155);
            this.btn_lock_cam_pitch.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_lock_cam_pitch.Name = "btn_lock_cam_pitch";
            this.btn_lock_cam_pitch.Size = new System.Drawing.Size(233, 37);
            this.btn_lock_cam_pitch.TabIndex = 27;
            this.btn_lock_cam_pitch.Text = "lockpitch";
            this.btn_lock_cam_pitch.UseVisualStyleBackColor = true;
            // 
            // btn_lock_cam_z
            // 
            this.btn_lock_cam_z.Location = new System.Drawing.Point(18, 114);
            this.btn_lock_cam_z.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_lock_cam_z.Name = "btn_lock_cam_z";
            this.btn_lock_cam_z.Size = new System.Drawing.Size(233, 37);
            this.btn_lock_cam_z.TabIndex = 26;
            this.btn_lock_cam_z.Text = "lock z";
            this.btn_lock_cam_z.UseVisualStyleBackColor = true;
            // 
            // btn_lock_cam_y
            // 
            this.btn_lock_cam_y.Location = new System.Drawing.Point(18, 74);
            this.btn_lock_cam_y.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_lock_cam_y.Name = "btn_lock_cam_y";
            this.btn_lock_cam_y.Size = new System.Drawing.Size(233, 37);
            this.btn_lock_cam_y.TabIndex = 25;
            this.btn_lock_cam_y.Text = "lock y";
            this.btn_lock_cam_y.UseVisualStyleBackColor = true;
            // 
            // btn_lock_cam_x
            // 
            this.btn_lock_cam_x.Location = new System.Drawing.Point(18, 33);
            this.btn_lock_cam_x.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_lock_cam_x.Name = "btn_lock_cam_x";
            this.btn_lock_cam_x.Size = new System.Drawing.Size(233, 37);
            this.btn_lock_cam_x.TabIndex = 24;
            this.btn_lock_cam_x.Text = "lock x";
            this.btn_lock_cam_x.UseVisualStyleBackColor = true;
            // 
            // panel_0
            // 
            this.panel_0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_0.Controls.Add(this.linkLabel3);
            this.panel_0.Controls.Add(this.btn_runspeed_walk);
            this.panel_0.Controls.Add(this.btn_normal_ammo);
            this.panel_0.Controls.Add(this.btn_spawnwolves);
            this.panel_0.Controls.Add(this.btn_salvagearrows);
            this.panel_0.Controls.Add(this.btn_runspeedplusplus);
            this.panel_0.Controls.Add(this.btn_runspeedplus);
            this.panel_0.Controls.Add(this.btn_runspeednormal);
            this.panel_0.Controls.Add(this.btn_jumpheight_2);
            this.panel_0.Controls.Add(this.label12);
            this.panel_0.Controls.Add(this.btn_jumpheight_3);
            this.panel_0.Controls.Add(this.statusLabel);
            this.panel_0.Controls.Add(this.btn_jumpheight_1);
            this.panel_0.Controls.Add(this.btn_jumpheight_0);
            this.panel_0.Controls.Add(this.linkLabel2);
            this.panel_0.Controls.Add(this.linkLabel1);
            this.panel_0.Controls.Add(this.btn_salvagepoints);
            this.panel_0.Controls.Add(this.btn_ammo);
            this.panel_0.Controls.Add(this.btn_health);
            this.panel_0.Controls.Add(this.btn_damagesquared);
            this.panel_0.Controls.Add(this.btn_upgrades);
            this.panel_0.Controls.Add(this.btn_reload);
            this.panel_0.Controls.Add(this.btn_skillpoints);
            this.panel_0.Controls.Add(this.label4);
            this.panel_0.Location = new System.Drawing.Point(0, 22);
            this.panel_0.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel_0.Name = "panel_0";
            this.panel_0.Size = new System.Drawing.Size(525, 506);
            this.panel_0.TabIndex = 26;
            this.panel_0.Tag = "0";
            // 
            // linkLabel3
            // 
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.Location = new System.Drawing.Point(318, 439);
            this.linkLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(125, 12);
            this.linkLabel3.TabIndex = 78;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "Edit : File(pgh268400)";
            // 
            // btn_runspeed_walk
            // 
            this.btn_runspeed_walk.Location = new System.Drawing.Point(271, 340);
            this.btn_runspeed_walk.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_runspeed_walk.Name = "btn_runspeed_walk";
            this.btn_runspeed_walk.Size = new System.Drawing.Size(233, 37);
            this.btn_runspeed_walk.TabIndex = 77;
            this.btn_runspeed_walk.Text = "Runspeed Walk";
            this.btn_runspeed_walk.UseVisualStyleBackColor = true;
            // 
            // btn_normal_ammo
            // 
            this.btn_normal_ammo.Location = new System.Drawing.Point(19, 340);
            this.btn_normal_ammo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_normal_ammo.Name = "btn_normal_ammo";
            this.btn_normal_ammo.Size = new System.Drawing.Size(233, 37);
            this.btn_normal_ammo.TabIndex = 76;
            this.btn_normal_ammo.Text = "Normal ammo";
            this.btn_normal_ammo.UseVisualStyleBackColor = true;
            // 
            // btn_spawnwolves
            // 
            this.btn_spawnwolves.Location = new System.Drawing.Point(19, 421);
            this.btn_spawnwolves.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_spawnwolves.Name = "btn_spawnwolves";
            this.btn_spawnwolves.Size = new System.Drawing.Size(233, 37);
            this.btn_spawnwolves.TabIndex = 74;
            this.btn_spawnwolves.Text = "wolf arrows";
            this.btn_spawnwolves.UseVisualStyleBackColor = true;
            // 
            // btn_salvagearrows
            // 
            this.btn_salvagearrows.Location = new System.Drawing.Point(19, 380);
            this.btn_salvagearrows.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_salvagearrows.Name = "btn_salvagearrows";
            this.btn_salvagearrows.Size = new System.Drawing.Size(233, 37);
            this.btn_salvagearrows.TabIndex = 73;
            this.btn_salvagearrows.Text = "salvage arrows";
            this.btn_salvagearrows.UseVisualStyleBackColor = true;
            // 
            // btn_runspeedplusplus
            // 
            this.btn_runspeedplusplus.Location = new System.Drawing.Point(271, 281);
            this.btn_runspeedplusplus.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_runspeedplusplus.Name = "btn_runspeedplusplus";
            this.btn_runspeedplusplus.Size = new System.Drawing.Size(233, 37);
            this.btn_runspeedplusplus.TabIndex = 71;
            this.btn_runspeedplusplus.Text = "Runspeed ++";
            this.btn_runspeedplusplus.UseVisualStyleBackColor = true;
            // 
            // btn_runspeedplus
            // 
            this.btn_runspeedplus.Location = new System.Drawing.Point(271, 240);
            this.btn_runspeedplus.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_runspeedplus.Name = "btn_runspeedplus";
            this.btn_runspeedplus.Size = new System.Drawing.Size(233, 37);
            this.btn_runspeedplus.TabIndex = 70;
            this.btn_runspeedplus.Text = "Runspeed +";
            this.btn_runspeedplus.UseVisualStyleBackColor = true;
            // 
            // btn_runspeednormal
            // 
            this.btn_runspeednormal.Location = new System.Drawing.Point(271, 199);
            this.btn_runspeednormal.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_runspeednormal.Name = "btn_runspeednormal";
            this.btn_runspeednormal.Size = new System.Drawing.Size(233, 37);
            this.btn_runspeednormal.TabIndex = 69;
            this.btn_runspeednormal.Text = "Normal Runspeed";
            this.btn_runspeednormal.UseVisualStyleBackColor = true;
            // 
            // btn_jumpheight_2
            // 
            this.btn_jumpheight_2.Location = new System.Drawing.Point(271, 103);
            this.btn_jumpheight_2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_jumpheight_2.Name = "btn_jumpheight_2";
            this.btn_jumpheight_2.Size = new System.Drawing.Size(233, 37);
            this.btn_jumpheight_2.TabIndex = 68;
            this.btn_jumpheight_2.Text = "jump 2";
            this.btn_jumpheight_2.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(28, 473);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 17);
            this.label12.TabIndex = 37;
            this.label12.Text = "Status:";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // btn_jumpheight_3
            // 
            this.btn_jumpheight_3.Location = new System.Drawing.Point(271, 63);
            this.btn_jumpheight_3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_jumpheight_3.Name = "btn_jumpheight_3";
            this.btn_jumpheight_3.Size = new System.Drawing.Size(233, 37);
            this.btn_jumpheight_3.TabIndex = 67;
            this.btn_jumpheight_3.Text = "jump 3";
            this.btn_jumpheight_3.UseVisualStyleBackColor = true;
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusLabel.Location = new System.Drawing.Point(103, 473);
            this.statusLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(99, 17);
            this.statusLabel.TabIndex = 31;
            this.statusLabel.Text = "KAPOW POW!";
            this.statusLabel.Click += new System.EventHandler(this.statusLabel_Click);
            // 
            // btn_jumpheight_1
            // 
            this.btn_jumpheight_1.Location = new System.Drawing.Point(271, 144);
            this.btn_jumpheight_1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_jumpheight_1.Name = "btn_jumpheight_1";
            this.btn_jumpheight_1.Size = new System.Drawing.Size(233, 37);
            this.btn_jumpheight_1.TabIndex = 66;
            this.btn_jumpheight_1.Text = "jump 1";
            this.btn_jumpheight_1.UseVisualStyleBackColor = true;
            // 
            // btn_jumpheight_0
            // 
            this.btn_jumpheight_0.Location = new System.Drawing.Point(271, 22);
            this.btn_jumpheight_0.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_jumpheight_0.Name = "btn_jumpheight_0";
            this.btn_jumpheight_0.Size = new System.Drawing.Size(233, 37);
            this.btn_jumpheight_0.TabIndex = 65;
            this.btn_jumpheight_0.Text = "jump 0";
            this.btn_jumpheight_0.UseVisualStyleBackColor = true;
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(300, 421);
            this.linkLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(163, 12);
            this.linkLabel2.TabIndex = 49;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Homepage: sicklebrick.com";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            this.linkLabel2.Click += new System.EventHandler(this.linkLabel2_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(279, 405);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(207, 12);
            this.linkLabel1.TabIndex = 48;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "TombraiderForums Release Thread";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // btn_salvagepoints
            // 
            this.btn_salvagepoints.Location = new System.Drawing.Point(19, 247);
            this.btn_salvagepoints.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_salvagepoints.Name = "btn_salvagepoints";
            this.btn_salvagepoints.Size = new System.Drawing.Size(233, 37);
            this.btn_salvagepoints.TabIndex = 42;
            this.btn_salvagepoints.Text = "salvagepoints";
            this.btn_salvagepoints.UseVisualStyleBackColor = true;
            // 
            // btn_ammo
            // 
            this.btn_ammo.Location = new System.Drawing.Point(19, 89);
            this.btn_ammo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_ammo.Name = "btn_ammo";
            this.btn_ammo.Size = new System.Drawing.Size(233, 37);
            this.btn_ammo.TabIndex = 41;
            this.btn_ammo.Text = "ammo";
            this.btn_ammo.UseVisualStyleBackColor = true;
            // 
            // btn_health
            // 
            this.btn_health.Location = new System.Drawing.Point(19, 44);
            this.btn_health.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_health.Name = "btn_health";
            this.btn_health.Size = new System.Drawing.Size(233, 37);
            this.btn_health.TabIndex = 40;
            this.btn_health.Text = "health";
            this.btn_health.UseVisualStyleBackColor = true;
            this.btn_health.Click += new System.EventHandler(this.btn_jumpheight_0_Click);
            // 
            // btn_damagesquared
            // 
            this.btn_damagesquared.Location = new System.Drawing.Point(19, 162);
            this.btn_damagesquared.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_damagesquared.Name = "btn_damagesquared";
            this.btn_damagesquared.Size = new System.Drawing.Size(233, 37);
            this.btn_damagesquared.TabIndex = 39;
            this.btn_damagesquared.Text = "damagesquared";
            this.btn_damagesquared.UseVisualStyleBackColor = true;
            // 
            // btn_upgrades
            // 
            this.btn_upgrades.Location = new System.Drawing.Point(19, 284);
            this.btn_upgrades.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_upgrades.Name = "btn_upgrades";
            this.btn_upgrades.Size = new System.Drawing.Size(233, 37);
            this.btn_upgrades.TabIndex = 32;
            this.btn_upgrades.Text = "upgrades";
            this.btn_upgrades.UseVisualStyleBackColor = true;
            // 
            // btn_reload
            // 
            this.btn_reload.Location = new System.Drawing.Point(19, 126);
            this.btn_reload.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_reload.Name = "btn_reload";
            this.btn_reload.Size = new System.Drawing.Size(233, 37);
            this.btn_reload.TabIndex = 31;
            this.btn_reload.Text = "reload";
            this.btn_reload.UseVisualStyleBackColor = true;
            // 
            // btn_skillpoints
            // 
            this.btn_skillpoints.Location = new System.Drawing.Point(19, 210);
            this.btn_skillpoints.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_skillpoints.Name = "btn_skillpoints";
            this.btn_skillpoints.Size = new System.Drawing.Size(233, 37);
            this.btn_skillpoints.TabIndex = 30;
            this.btn_skillpoints.Text = "skillpoints";
            this.btn_skillpoints.UseVisualStyleBackColor = true;
            this.btn_skillpoints.Click += new System.EventHandler(this.trainer_hp_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 15);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 15);
            this.label4.TabIndex = 29;
            this.label4.Text = "Trainer";
            // 
            // panel_3
            // 
            this.panel_3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_3.Controls.Add(this.btn_contrast_low);
            this.panel_3.Controls.Add(this.btn_contrast_norm);
            this.panel_3.Controls.Add(this.btn_contrast_hi);
            this.panel_3.Controls.Add(this.btn_rgb_boost);
            this.panel_3.Controls.Add(this.btn_bright_norm);
            this.panel_3.Controls.Add(this.btn_bright_4);
            this.panel_3.Controls.Add(this.btn_bright_3);
            this.panel_3.Controls.Add(this.btn_bright_2);
            this.panel_3.Controls.Add(this.btn_bright_1);
            this.panel_3.Controls.Add(this.btn_bright_0);
            this.panel_3.Controls.Add(this.btn_no_weaps);
            this.panel_3.Controls.Add(this.btn_clean_lara);
            this.panel_3.Controls.Add(this.btn_smalltits);
            this.panel_3.Controls.Add(this.btn_biggertits);
            this.panel_3.Controls.Add(this.btn_bigtits);
            this.panel_3.Controls.Add(this.btn_jiggletitsmega);
            this.panel_3.Controls.Add(this.btn_jiggletitson);
            this.panel_3.Controls.Add(this.btn_jiggletitsoff);
            this.panel_3.Controls.Add(this.btn_normaltits);
            this.panel_3.Controls.Add(this.label5);
            this.panel_3.Location = new System.Drawing.Point(1643, 22);
            this.panel_3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel_3.Name = "panel_3";
            this.panel_3.Size = new System.Drawing.Size(522, 506);
            this.panel_3.TabIndex = 27;
            this.panel_3.Tag = "3";
            this.panel_3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_4_Paint);
            // 
            // btn_contrast_low
            // 
            this.btn_contrast_low.Location = new System.Drawing.Point(271, 414);
            this.btn_contrast_low.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_contrast_low.Name = "btn_contrast_low";
            this.btn_contrast_low.Size = new System.Drawing.Size(233, 37);
            this.btn_contrast_low.TabIndex = 67;
            this.btn_contrast_low.Text = "contrast low";
            this.btn_contrast_low.UseVisualStyleBackColor = true;
            // 
            // btn_contrast_norm
            // 
            this.btn_contrast_norm.Location = new System.Drawing.Point(271, 373);
            this.btn_contrast_norm.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_contrast_norm.Name = "btn_contrast_norm";
            this.btn_contrast_norm.Size = new System.Drawing.Size(233, 37);
            this.btn_contrast_norm.TabIndex = 66;
            this.btn_contrast_norm.Text = "contrast norm";
            this.btn_contrast_norm.UseVisualStyleBackColor = true;
            // 
            // btn_contrast_hi
            // 
            this.btn_contrast_hi.Location = new System.Drawing.Point(271, 332);
            this.btn_contrast_hi.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_contrast_hi.Name = "btn_contrast_hi";
            this.btn_contrast_hi.Size = new System.Drawing.Size(233, 37);
            this.btn_contrast_hi.TabIndex = 65;
            this.btn_contrast_hi.Text = "contrast hi";
            this.btn_contrast_hi.UseVisualStyleBackColor = true;
            // 
            // btn_rgb_boost
            // 
            this.btn_rgb_boost.Location = new System.Drawing.Point(271, 273);
            this.btn_rgb_boost.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_rgb_boost.Name = "btn_rgb_boost";
            this.btn_rgb_boost.Size = new System.Drawing.Size(233, 37);
            this.btn_rgb_boost.TabIndex = 64;
            this.btn_rgb_boost.Text = "RGB Bright Boost";
            this.btn_rgb_boost.UseVisualStyleBackColor = true;
            // 
            // btn_bright_norm
            // 
            this.btn_bright_norm.Location = new System.Drawing.Point(271, 41);
            this.btn_bright_norm.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_bright_norm.Name = "btn_bright_norm";
            this.btn_bright_norm.Size = new System.Drawing.Size(233, 37);
            this.btn_bright_norm.TabIndex = 63;
            this.btn_bright_norm.Text = "Normal Light";
            this.btn_bright_norm.UseVisualStyleBackColor = true;
            // 
            // btn_bright_4
            // 
            this.btn_bright_4.Location = new System.Drawing.Point(271, 225);
            this.btn_bright_4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_bright_4.Name = "btn_bright_4";
            this.btn_bright_4.Size = new System.Drawing.Size(233, 37);
            this.btn_bright_4.TabIndex = 62;
            this.btn_bright_4.Text = "Mega Glow";
            this.btn_bright_4.UseVisualStyleBackColor = true;
            this.btn_bright_4.Click += new System.EventHandler(this.button7_Click);
            // 
            // btn_bright_3
            // 
            this.btn_bright_3.Location = new System.Drawing.Point(271, 188);
            this.btn_bright_3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_bright_3.Name = "btn_bright_3";
            this.btn_bright_3.Size = new System.Drawing.Size(233, 37);
            this.btn_bright_3.TabIndex = 61;
            this.btn_bright_3.Text = "Glowier";
            this.btn_bright_3.UseVisualStyleBackColor = true;
            // 
            // btn_bright_2
            // 
            this.btn_bright_2.Location = new System.Drawing.Point(271, 151);
            this.btn_bright_2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_bright_2.Name = "btn_bright_2";
            this.btn_bright_2.Size = new System.Drawing.Size(233, 37);
            this.btn_bright_2.TabIndex = 60;
            this.btn_bright_2.Text = "Glow";
            this.btn_bright_2.UseVisualStyleBackColor = true;
            // 
            // btn_bright_1
            // 
            this.btn_bright_1.Location = new System.Drawing.Point(271, 114);
            this.btn_bright_1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_bright_1.Name = "btn_bright_1";
            this.btn_bright_1.Size = new System.Drawing.Size(233, 37);
            this.btn_bright_1.TabIndex = 59;
            this.btn_bright_1.Text = "Slight glow";
            this.btn_bright_1.UseVisualStyleBackColor = true;
            // 
            // btn_bright_0
            // 
            this.btn_bright_0.Location = new System.Drawing.Point(271, 78);
            this.btn_bright_0.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_bright_0.Name = "btn_bright_0";
            this.btn_bright_0.Size = new System.Drawing.Size(233, 37);
            this.btn_bright_0.TabIndex = 58;
            this.btn_bright_0.Text = "Silhouette";
            this.btn_bright_0.UseVisualStyleBackColor = true;
            // 
            // btn_no_weaps
            // 
            this.btn_no_weaps.Location = new System.Drawing.Point(19, 81);
            this.btn_no_weaps.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_no_weaps.Name = "btn_no_weaps";
            this.btn_no_weaps.Size = new System.Drawing.Size(233, 37);
            this.btn_no_weaps.TabIndex = 57;
            this.btn_no_weaps.Text = "noweaps";
            this.btn_no_weaps.UseVisualStyleBackColor = true;
            // 
            // btn_clean_lara
            // 
            this.btn_clean_lara.Location = new System.Drawing.Point(19, 41);
            this.btn_clean_lara.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_clean_lara.Name = "btn_clean_lara";
            this.btn_clean_lara.Size = new System.Drawing.Size(233, 37);
            this.btn_clean_lara.TabIndex = 56;
            this.btn_clean_lara.Text = "cleanlara";
            this.btn_clean_lara.UseVisualStyleBackColor = true;
            // 
            // btn_smalltits
            // 
            this.btn_smalltits.Location = new System.Drawing.Point(19, 266);
            this.btn_smalltits.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_smalltits.Name = "btn_smalltits";
            this.btn_smalltits.Size = new System.Drawing.Size(233, 37);
            this.btn_smalltits.TabIndex = 38;
            this.btn_smalltits.Text = "smalltits";
            this.btn_smalltits.UseVisualStyleBackColor = true;
            // 
            // btn_biggertits
            // 
            this.btn_biggertits.Location = new System.Drawing.Point(19, 388);
            this.btn_biggertits.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_biggertits.Name = "btn_biggertits";
            this.btn_biggertits.Size = new System.Drawing.Size(233, 37);
            this.btn_biggertits.TabIndex = 37;
            this.btn_biggertits.Text = "biggertits";
            this.btn_biggertits.UseVisualStyleBackColor = true;
            // 
            // btn_bigtits
            // 
            this.btn_bigtits.Location = new System.Drawing.Point(19, 347);
            this.btn_bigtits.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_bigtits.Name = "btn_bigtits";
            this.btn_bigtits.Size = new System.Drawing.Size(233, 37);
            this.btn_bigtits.TabIndex = 36;
            this.btn_bigtits.Text = "bigtits";
            this.btn_bigtits.UseVisualStyleBackColor = true;
            // 
            // btn_jiggletitsmega
            // 
            this.btn_jiggletitsmega.Location = new System.Drawing.Point(19, 214);
            this.btn_jiggletitsmega.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_jiggletitsmega.Name = "btn_jiggletitsmega";
            this.btn_jiggletitsmega.Size = new System.Drawing.Size(233, 37);
            this.btn_jiggletitsmega.TabIndex = 35;
            this.btn_jiggletitsmega.Text = "jiggletitsmega";
            this.btn_jiggletitsmega.UseVisualStyleBackColor = true;
            // 
            // btn_jiggletitson
            // 
            this.btn_jiggletitson.Location = new System.Drawing.Point(19, 174);
            this.btn_jiggletitson.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_jiggletitson.Name = "btn_jiggletitson";
            this.btn_jiggletitson.Size = new System.Drawing.Size(233, 37);
            this.btn_jiggletitson.TabIndex = 34;
            this.btn_jiggletitson.Text = "jiggletitson";
            this.btn_jiggletitson.UseVisualStyleBackColor = true;
            // 
            // btn_jiggletitsoff
            // 
            this.btn_jiggletitsoff.Location = new System.Drawing.Point(19, 133);
            this.btn_jiggletitsoff.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_jiggletitsoff.Name = "btn_jiggletitsoff";
            this.btn_jiggletitsoff.Size = new System.Drawing.Size(233, 37);
            this.btn_jiggletitsoff.TabIndex = 33;
            this.btn_jiggletitsoff.Text = "jiggletitsoff";
            this.btn_jiggletitsoff.UseVisualStyleBackColor = true;
            // 
            // btn_normaltits
            // 
            this.btn_normaltits.Location = new System.Drawing.Point(19, 306);
            this.btn_normaltits.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_normaltits.Name = "btn_normaltits";
            this.btn_normaltits.Size = new System.Drawing.Size(233, 37);
            this.btn_normaltits.TabIndex = 31;
            this.btn_normaltits.Text = "normaltits";
            this.btn_normaltits.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 15);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 15);
            this.label5.TabIndex = 30;
            this.label5.Text = "Cosmetic / Tits";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage10);
            this.tabControl1.Controls.Add(this.tabPage11);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.HotTrack = true;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(527, 22);
            this.tabControl1.TabIndex = 28;
            this.tabControl1.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl1_Selected);
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage1.Size = new System.Drawing.Size(519, 0);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Standard";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage2.Size = new System.Drawing.Size(519, 0);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Position";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage10
            // 
            this.tabPage10.Location = new System.Drawing.Point(4, 22);
            this.tabPage10.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage10.Name = "tabPage10";
            this.tabPage10.Size = new System.Drawing.Size(519, 0);
            this.tabPage10.TabIndex = 2;
            this.tabPage10.Text = "Camera";
            this.tabPage10.UseVisualStyleBackColor = true;
            // 
            // tabPage11
            // 
            this.tabPage11.Location = new System.Drawing.Point(4, 22);
            this.tabPage11.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage11.Name = "tabPage11";
            this.tabPage11.Size = new System.Drawing.Size(519, 0);
            this.tabPage11.TabIndex = 3;
            this.tabPage11.Text = "Cosmetic";
            this.tabPage11.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(519, 0);
            this.tabPage4.TabIndex = 5;
            this.tabPage4.Text = "About";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(519, 0);
            this.tabPage3.TabIndex = 4;
            this.tabPage3.Text = "All";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // savebox
            // 
            this.savebox.Location = new System.Drawing.Point(2852, 184);
            this.savebox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.savebox.Name = "savebox";
            this.savebox.Size = new System.Drawing.Size(226, 28);
            this.savebox.TabIndex = 31;
            this.savebox.Text = "Chunkey chicken widdle";
            this.savebox.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(2862, 113);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 17);
            this.label7.TabIndex = 33;
            this.label7.Text = "Last keypress:";
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 10;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(1010, 27);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(0, 18);
            this.label11.TabIndex = 36;
            // 
            // blitTimer
            // 
            this.blitTimer.Interval = 1;
            this.blitTimer.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // fontLabel
            // 
            this.fontLabel.AutoSize = true;
            this.fontLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fontLabel.Location = new System.Drawing.Point(2861, 243);
            this.fontLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.fontLabel.Name = "fontLabel";
            this.fontLabel.Size = new System.Drawing.Size(121, 46);
            this.fontLabel.TabIndex = 44;
            this.fontLabel.Text = "FOO!";
            // 
            // blitLengthTimer
            // 
            this.blitLengthTimer.Interval = 2500;
            this.blitLengthTimer.Tick += new System.EventHandler(this.blitLengthTimer_Tick);
            // 
            // settingsBox
            // 
            this.settingsBox.Location = new System.Drawing.Point(2856, 213);
            this.settingsBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.settingsBox.Name = "settingsBox";
            this.settingsBox.Size = new System.Drawing.Size(116, 23);
            this.settingsBox.TabIndex = 47;
            this.settingsBox.Text = "";
            // 
            // cbAutoUpdate
            // 
            this.cbAutoUpdate.AutoSize = true;
            this.cbAutoUpdate.Enabled = false;
            this.cbAutoUpdate.Location = new System.Drawing.Point(2865, 85);
            this.cbAutoUpdate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbAutoUpdate.Name = "cbAutoUpdate";
            this.cbAutoUpdate.Size = new System.Drawing.Size(155, 16);
            this.cbAutoUpdate.TabIndex = 50;
            this.cbAutoUpdate.Text = "Disable Editor updates.";
            this.cbAutoUpdate.UseVisualStyleBackColor = true;
            // 
            // cbOverlay
            // 
            this.cbOverlay.AutoSize = true;
            this.cbOverlay.Enabled = false;
            this.cbOverlay.Location = new System.Drawing.Point(2865, 66);
            this.cbOverlay.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbOverlay.Name = "cbOverlay";
            this.cbOverlay.Size = new System.Drawing.Size(111, 16);
            this.cbOverlay.TabIndex = 49;
            this.cbOverlay.Text = "Disable overlay";
            this.cbOverlay.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(2324, 502);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(214, 17);
            this.label3.TabIndex = 51;
            this.label3.Text = "Hiya. Dont tell anyone I\'m here ;)";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(2884, 332);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 21);
            this.button2.TabIndex = 52;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // panel_4
            // 
            this.panel_4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_4.Controls.Add(this.richTextBox3);
            this.panel_4.Controls.Add(this.cbKeybinds);
            this.panel_4.Controls.Add(this.richTextBox2);
            this.panel_4.Controls.Add(this.label10);
            this.panel_4.Controls.Add(this.label9);
            this.panel_4.Controls.Add(this.Debugging);
            this.panel_4.Controls.Add(this.label8);
            this.panel_4.Controls.Add(this.richTextBox1);
            this.panel_4.Location = new System.Drawing.Point(2184, 22);
            this.panel_4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel_4.Name = "panel_4";
            this.panel_4.Size = new System.Drawing.Size(516, 506);
            this.panel_4.TabIndex = 53;
            this.panel_4.Tag = "3";
            // 
            // richTextBox3
            // 
            this.richTextBox3.BackColor = System.Drawing.SystemColors.Control;
            this.richTextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox3.Location = new System.Drawing.Point(15, 193);
            this.richTextBox3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.Size = new System.Drawing.Size(231, 37);
            this.richTextBox3.TabIndex = 71;
            this.richTextBox3.Text = "For v 1.1.748.0 (steam)\n Size: 19,474,944 bytes";
            // 
            // cbKeybinds
            // 
            this.cbKeybinds.AutoSize = true;
            this.cbKeybinds.Location = new System.Drawing.Point(29, 241);
            this.cbKeybinds.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbKeybinds.Name = "cbKeybinds";
            this.cbKeybinds.Size = new System.Drawing.Size(123, 16);
            this.cbKeybinds.TabIndex = 70;
            this.cbKeybinds.Text = "Disable Keybinds";
            this.cbKeybinds.UseVisualStyleBackColor = true;
            // 
            // richTextBox2
            // 
            this.richTextBox2.BackColor = System.Drawing.SystemColors.Control;
            this.richTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox2.Location = new System.Drawing.Point(15, 122);
            this.richTextBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(231, 46);
            this.richTextBox2.TabIndex = 69;
            this.richTextBox2.Text = "Questions? Comments? Ideas? Head on over to the release thread on tombraiderforum" +
    "s.";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(66, 77);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(97, 18);
            this.label10.TabIndex = 66;
            this.label10.Text = "by sicklebrick";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(20, 54);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(154, 20);
            this.label9.TabIndex = 68;
            this.label9.Text = "YAMATAIPatch   R5";
            // 
            // Debugging
            // 
            this.Debugging.AutoSize = true;
            this.Debugging.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Debugging.Location = new System.Drawing.Point(19, 30);
            this.Debugging.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Debugging.Name = "Debugging";
            this.Debugging.Size = new System.Drawing.Size(38, 15);
            this.Debugging.TabIndex = 64;
            this.Debugging.Text = "About";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(26, 256);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 17);
            this.label8.TabIndex = 67;
            this.label8.Text = "Debug spam";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(10, 277);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(488, 116);
            this.richTextBox1.TabIndex = 65;
            this.richTextBox1.Text = "";
            // 
            // btn_outfits
            // 
            this.btn_outfits.Location = new System.Drawing.Point(2856, 358);
            this.btn_outfits.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_outfits.Name = "btn_outfits";
            this.btn_outfits.Size = new System.Drawing.Size(233, 37);
            this.btn_outfits.TabIndex = 54;
            this.btn_outfits.Text = "outfits";
            this.btn_outfits.UseVisualStyleBackColor = true;
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 531);
            this.Controls.Add(this.btn_outfits);
            this.Controls.Add(this.panel_4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbAutoUpdate);
            this.Controls.Add(this.cbOverlay);
            this.Controls.Add(this.settingsBox);
            this.Controls.Add(this.fontLabel);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.savebox);
            this.Controls.Add(this.panel_3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel_0);
            this.Controls.Add(this.panel_2);
            this.Controls.Add(this.panel_1);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "main";
            this.Text = "YamataiPatch R5";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel_1.ResumeLayout(false);
            this.panel_1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackbarPlayer)).EndInit();
            this.panel_2.ResumeLayout(false);
            this.panel_2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackbarcamera)).EndInit();
            this.panel_0.ResumeLayout(false);
            this.panel_0.PerformLayout();
            this.panel_3.ResumeLayout(false);
            this.panel_3.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.panel_4.ResumeLayout(false);
            this.panel_4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        // 프로그램 시작시 호출되는 함수
        public main()
        {
            InitializeComponent();
            staticSelf = this;
            sLabel = label1;
            sBox = savebox;
            cheat_buttons();
            registerSettingsBoxes();
            panelList.Add(panel_0);
            panelList.Add(panel_1);
            panelList.Add(panel_2);
            panelList.Add(panel_3);
            panelList.Add(panel_4);
            showPanel(0);
            ConnectionTimer.Enabled = true;
            GameHooks.Hookey();
            GameOverlay.setSourceFont(fontLabel);
        }

        // public int getNumPanels() => this.panelList.Count;

        public void registerSettingsBoxes()
        {
            saveableCheckBoxes = new CheckBox[3]
            {
                cbAutoUpdate,
                cbKeybinds,
                cbOverlay
            };
            load_settings();
        }

        public void updateEditBoxes()
        {
            if (!cheatButton_playerX.myEditBox.Focused && !cheatButton_playerX.Focused)
                cheatButton_playerX.myEditBox.Text = getXPos().ToString();
            if (!cheatButton_playerY.myEditBox.Focused && !cheatButton_playerY.Focused)
                cheatButton_playerY.myEditBox.Text = getYPos().ToString();
            if (!cheatButton_playerZ.myEditBox.Focused && !cheatButton_playerZ.Focused)
                cheatButton_playerZ.myEditBox.Text = getZPos().ToString();
            if (!cheatButton_camX.myEditBox.Focused && !cheatButton_camX.Focused)
                cheatButton_camX.myEditBox.Text = getXPosCam().ToString();
            if (!cheatButton_camY.myEditBox.Focused && !cheatButton_camY.Focused)
                cheatButton_camY.myEditBox.Text = getYPosCam().ToString();
            if (cheatButton_camZ.myEditBox.Focused || cheatButton_camZ.Focused)
                return;
            cheatButton_camZ.myEditBox.Text = getZPosCam().ToString();
        }

        public static void addText(string inString) => staticSelf.richTextBox1.AppendText(inString + "\n");

        public static void status(string inString) => staticSelf.statusLabel.Text = inString;

        private void timer1_Tick(object sender, EventArgs e)
        {
            GameConnector.checkConnection();
            if (!GameConnector.wrongVersion)
            {
                if (!GameConnector.gameFound)
                    return;
                updateEditBoxes();
                button1_Click_7(null, null);
            }
            else
                ConnectionTimer.Enabled = false;
        }

        // public static string intToStr(int inVal) => string.Format("0x{0:X}", (object)(uint)inVal);

        public void start_blit_timer()
        {
            blitTimer.Enabled = true;
            blitLengthTimer.Enabled = true;
        }

        public void cheat_buttons()
        {
            replace_button_to_cheat(btn_health, "btn_health", "Inf Health", null, new List<string>()
            {
                "|0074FA52|EB 1D |",
                "|0080F8F9|EB 0F |",
                "|00574D88|0F 84 20 FD FF FF 90 90 90 90 90 90 90 90 90 90 90 90 90 90 90 90 90 90 90 90 90 90 90 90 |"
            }, new List<string>()
            {
                "|0074FA52|74 1D |",
                "|0080F8F9|74 0F |",
                "|00574D88|74 1C 8D 54 24 50 52 56 E8 4B 9C FE FF 8B 4F 08 8D 44 24 58 50 51 E8 CD 1F 1A 00 83 C4 10 |"
            });
            replace_button_to_cheat(btn_ammo, "btn_ammo", "Inf Ammo", null, new List<string>()
            {
                "|0081FF1A|66 B8 55 02 90 90 |",
                "|0080B1C6|EB 15 |",
                "|0080B1DD|90 90 90 90 90 90 66 B8 55 02 |"
            }, new List<string>()
            {
                "|0081FF1A|66 8B 00 66 2B C6 |",
                "|0080B1C6|74 15 |",
                "|0080B1DD|33 C0 5E C2 04 00 66 8B 42 08 |"
            });
            replace_button_to_cheat(btn_reload, "btn_reload", "No Reloads", null,
                new List<string>()
                {
                    "|0082BD72|EB 06 |"
                }, new List<string>() { "|0082BD72|74 06 |" });
            replace_button_to_cheat(btn_damagesquared, "btn_damagesquared", "Damage Squared",
                null, new List<string>()
                {
                    "|0077D0FE|D9 44 E4 10 |"
                }, new List<string>() { "|0077D0FE|D9 44 24 38 |" });
            replace_button_to_cheat(btn_skillpoints, "btn_skillpoints", "Inf Skillpoints", null,
                new List<string>()
                {
                    "|00AC9460|8B 4C 24 04 B8 20 00 00 00 8B 4C 24 10 89 01 C3 |",
                    "|906c1b|90 90 90 C2 04 00 90 90 90 |"
                }, new List<string>()
                {
                    "|00AC9460|8B 4C 24 04 E8 07 89 F2 FF 8B 4C 24 10 89 01 C3 |",
                    "|906c1b|29 41 18 C2 04 00 29 51 18 |"
                });
            replace_button_to_cheat(btn_salvagepoints, "btn_salvagepoints", "Inf Salvage", null,
                new List<string>()
                {
                    "|009F1AC6|BE 55 02 00 00 90 90 90 |"
                }, new List<string>()
                {
                    "|009F1AC6|0F B7 F0 E8 32 03 08 00 |"
                });
            replace_button_to_cheat(btn_upgrades, "btn_upgrades", "All Upgrades", null,
                new List<string>()
                {
                    "|0080B754|B0 01 90 90 |"
                }, new List<string>() { "|0080B754|8A D8 8A C3 |" });
            replace_button_to_cheat(btn_clean_lara, "btn_clean_lara", "Clean Lara", null,
                new List<string>()
                {
                    "|93ed67|EB 15 |"
                }, new List<string>() { "|93ed67|74 15 |" });
            replace_button_to_cheat(btn_no_weaps, "btn_no_weaps", "No Weapons (Reload)", null,
                new List<string>()
                {
                    "|468340|EB 51 |",
                    "|80b1bb|90 90 90 90 90 90 90 90 90 |"
                }, new List<string>()
                {
                    "|468340|74 51 |",
                    "|80b1bb|F7 71 38 8B 49 2C 8B 14 91 |"
                });
            replace_button_to_cheat(btn_jumpheight_0, "btn_jumpheight_0", "Normal Jumps", new List<string>()
            {
                "|00969ED7|D9 1C 24 D9 41 14 68 20 6E DF 00 |"
            }, null, null);
            replace_button_to_cheat(btn_jumpheight_1, "btn_jumpheight_1", "Jump +++", new List<string>()
            {
                "|00969ED7|D9 EB D9 EC D8 F1 D9 E0 90 6A 00 |"
            }, null, null);
            replace_button_to_cheat(btn_jumpheight_2, "btn_jumpheight_2", "Jump ++", new List<string>()
            {
                "|00969ED7|D9 E8 D9 EC D8 F1 D9 E0 90 6A 00 |"
            }, null, null);
            replace_button_to_cheat(btn_jumpheight_3, "btn_jumpheight_3", "Jump +", new List<string>()
            {
                "|00969ED7|D9 ED D9 EC D8 F1 D9 E0 90 6A 00 |"
            }, null, null);
            replace_button_to_cheat(btn_noclip, "btn_noclip", "No Clip", null,
                new List<string>()
                {
                    "|0093D2AC|E9 6D 05 00 00 90 |"
                }, new List<string>()
                {
                    "|0093D2AC|0F 84 6C 05 00 00 |"
                });
            replace_button_to_cheat(btn_static_lara, "btn_static_lara", "static_lara", null,
                new List<string>()
                {
                    "|6f1aba|90 90 90 90 90 |"
                }, new List<string>() { "|6f1aba|E8 C1 64 FB FF |" });
            replace_button_to_cheat(btn_jiggletitsoff, "btn_jiggletitsoff", "JiggleTits Off",
                new List<string>()
                {
                    "|005101E4|DC C0 D8 4F 08 |"
                }, null, null);
            replace_button_to_cheat(btn_jiggletitson, "btn_jiggletitson", "JiggleTits On", new List<string>()
            {
                "|005101E4|90 90 D8 4F 08 |"
            }, null, null);
            replace_button_to_cheat(btn_jiggletitsmega, "btn_jiggletitsmega", "Super JiggleTits",
                new List<string>()
                {
                    "|005101E4|90 90 D8 4F 04 |"
                }, null, null);
            replace_button_to_cheat(btn_outfits, "btn_outfits", "Enable Outfit Menu", null,
                new List<string>()
                {
                    "|00AC953E|30 C0 FE C0 90 90 |"
                }, new List<string>()
                {
                    "|00AC953E|50 E8 2C 89 F2 FF |"
                });
            replace_button_to_cheat(btn_normaltits, "btn_normaltits", "Normal Tits", new List<string>()
            {
                "|005100CD|89 94 24 30 01 00 00 8B 96 8C 00 00 00 0F 14 C5 0F 14 F4 0F 28 64 18 30 0F 14 C6 0F 29 A4 24 50 01 00 00 8B 84 24 58 01 00 00 0F 29 84 24 C0 01 00 00 0F 28 46 40 0F 5C E0 0F 28 84 24 90 00 00 00 0F 5C C4 0F 28 E0 0F C6 E0 C9 0F 59 E1 0F 28 C8 0F C6 C8 D2 0F 59 CA 0F 5C CC |"
            }, null, null);
            replace_button_to_cheat(btn_bigtits, "btn_bigtits", "Big Tits", new List<string>()
            {
                "|005100CD|89 94 E4 30 01 00 00 8B 96 8C 00 00 00 0F 28 64 18 30 0F 29 A4 E4 50 01 00 00 0F 29 A4 E4 C0 01 00 00 90 0F BF 07 C1 E0 06 0F 28 44 18 30 0F 5C 44 18 50 0F 5C 44 18 50 90 90 90 90 90 0F 29 44 18 30 90 90 90 90 0F 28 46 40 0F 5C E0 0F 59 E1 0F 59 E1 0F 29 A4 E4 80 01 00 00 |"
            }, null, null);
            replace_button_to_cheat(btn_biggertits, "btn_biggertits", "Bigger Tits", new List<string>()
            {
                "|005100CD|89 94 E4 30 01 00 00 8B 96 8C 00 00 00 0F 28 64 18 30 0F 29 A4 E4 50 01 00 00 0F 29 A4 E4 C0 01 00 00 90 0F BF 07 C1 E0 06 0F 28 44 18 30 0F 5C 44 18 50 0F 5C 44 18 50 0F 5C 44 18 50 0F 29 44 18 30 90 90 90 90 0F 28 46 40 0F 5C E0 0F 59 E1 0F 59 E1 0F 29 A4 E4 80 01 00 00 |"
            }, null, null);
            replace_button_to_cheat(btn_smalltits, "btn_smalltits", "Small Tits", new List<string>()
            {
                "|005100CD|89 94 E4 30 01 00 00 8B 96 8C 00 00 00 0F 28 64 18 30 0F 29 A4 E4 50 01 00 00 0F 29 A4 E4 C0 01 00 00 90 0F BF 07 C1 E0 06 0F 28 44 18 30 0F 58 44 18 50 0F 58 44 18 50 90 90 90 90 90 0F 29 44 18 30 90 90 90 90 0F 28 46 40 0F 5C E0 90 90 90 90 90 90 0F 29 A4 E4 80 01 00 00 8B 84 E4 58 01 00 00 90 |"
            }, null, null);
            replace_button_to_cheat(btn_runspeednormal, "btn_runspeednormal", "Normal Speed",
                new List<string>()
                {
                    "|00944E37|D9 05 A8 35 23 02 |"
                }, null, null);
            replace_button_to_cheat(btn_runspeedplus, "btn_runspeedplus", "Runspeed +", new List<string>()
            {
                "|00944E37|D9 EA 90 90 90 90 |"
            }, null, null);
            replace_button_to_cheat(btn_runspeedplusplus, "btn_runspeedplusplus", "Runspeed ++",
                new List<string>()
                {
                    "|00944E37|D9 EB 90 90 90 90 |"
                }, null, null);
            replace_button_to_cheat(btn_runspeed_walk, "btn_runspeed_walk", "Runspeed Walk",
                null, new List<string>()
                {
                    "|961853|D9 EB 90 90 |"
                }, new List<string>() { "|961853|D9 44 24 3C |" });
            replace_button_to_cheat(btn_hover_none, "btn_hover_none", "Hovering Off", new List<string>()
            {
                "|009431C4|D9 44 24 68 |"
            }, null, null);
            replace_button_to_cheat(btn_hover_up, "btn_hover_up", "Hovering Up", new List<string>()
            {
                "|009431C4|D9 E8 90 90 |"
            }, null, null);
            replace_button_to_cheat(btn_hover_down, "btn_hover_down", "Hovering Down", new List<string>()
            {
                "|009431C4|D9 EE 90 90 |"
            }, null, null);
            replace_button_to_cheat(btn_levitate, "btn_levitate", "AirWalk (Lock Y)", null,
                new List<string>()
                {
                    "|0093279c|90 90 90 |",
                    "|009431B1|EB 18 |",
                    "|6eacbc|E9 8A 00 00 00 90 |"
                }, new List<string>()
                {
                    "|0093279c|89 48 08 |",
                    "|009431B1|74 18 |",
                    "|6eacbc|0F 87 89 00 00 00 |"
                });
            replace_button_to_cheat(btn_no_wobble, "btn_no_wobble", "No Cam Wobble/Wind", null,
                new List<string>()
                {
                    "|49A78C|EB 1F |"
                }, new List<string>() { "|49A78C|74 1F |" });
            replace_button_to_cheat(btn_normal_ammo, "btn_normal_ammo", "Normal Ammo", new List<string>()
            {
                "|82cb0c|6A 39 E8 DD C4 E6 FF 8B 4F 0C 50 6A 38 E8 D2 C4 E6 FF |",
                "|0082AB96|75 68 |",
                "|00A815A3|74 71 |"
            }, null, null);
            replace_button_to_cheat(btn_salvagearrows, "btn_salvagearrows", "Ammo = Salvage",
                new List<string>()
                {
                    "|82cb0c|8B 4F 0C 50 B8 96 03 00 00 90 90 90 90 90 90 90 90 90 |",
                    "|0082AB96|90 90 |",
                    "|00A815A3|EB 71 |"
                }, null, null);
            replace_button_to_cheat(btn_spawnwolves, "btn_spawnwolves", "Ammo = Wolves", new List<string>()
            {
                "|82cb0c|8B 4F 0C 50 B8 C9 00 00 00 90 90 90 90 90 90 90 90 90 |",
                "|0082AB96|90 90 |",
                "|00A815A3|EB 71 |"
            }, null, null);
            cheatButton_playerX = replace_button_to_cheat(btn_edit_PlayerX, "btn_edit_PlayerX",
                "Player X", new List<string>()
                {
                    "@editfloat_player_x 0@0.0@0"
                }, null, null);
            cheatButton_playerY = replace_button_to_cheat(btn_edit_PlayerY, "btn_edit_PlayerY",
                "Player Y", new List<string>()
                {
                    "@editfloat_player_y 1@0.0@0"
                }, null, null);
            cheatButton_playerZ = replace_button_to_cheat(btn_edit_PlayerZ, "btn_edit_PlayerX",
                "Player Z", new List<string>()
                {
                    "@editfloat_player_z 2@0.0@0"
                }, null, null);
            cheatButton_camX = replace_button_to_cheat(btn_edit_cam_x, "btn_edit_cam_x", "Cam X",
                new List<string>()
                {
                    "@editfloat_cam_x 0@0.0@0"
                }, null, null);
            cheatButton_camY = replace_button_to_cheat(btn_edit_cam_y, "btn_edit_cam_y", "Cam Y",
                new List<string>()
                {
                    "@editfloat_cam_y 1@0.0@0"
                }, null, null);
            cheatButton_camZ = replace_button_to_cheat(btn_edit_cam_z, "btn_edit_cam_z", "Cam Z",
                new List<string>()
                {
                    "@editfloat_cam_z 2@0.0@0"
                }, null, null);
            replace_button_to_cheat(btn_warpnorth, "btn_warpnorth", "Warp North", new List<string>()
            {
                "@warpnorth 0@0.0@0"
            }, null, null);
            replace_button_to_cheat(btn_warpsouth, "bth_warpsouth", "Warp South", new List<string>()
            {
                "@warpsouth 0@0.0@0"
            }, null, null);
            replace_button_to_cheat(btn_warpwest, "bth_warpwest", "Warp West", new List<string>()
            {
                "@warpwest 0@0.0@0"
            }, null, null);
            replace_button_to_cheat(btn_warpeast, "btn_warpeast", "Warp East", new List<string>()
            {
                "@warpeast 0@0.0@0"
            }, null, null);
            replace_button_to_cheat(btn_warpup, "btn_warpup", "Warp Up", new List<string>()
            {
                "@warpup 0@0.0@0"
            }, null, null);
            replace_button_to_cheat(btn_warpdown, "btn_warpdown", "Warp Down", new List<string>()
            {
                "@warpdown 0@0.0@0"
            }, null, null);
            replace_button_to_cheat(btn_nudge_cam_north, "btn_nudge_cam_north", "Nudge North",
                new List<string>()
                {
                    "@warpcamnorth 0@0.0@0"
                }, null, null);
            replace_button_to_cheat(btn_nudge_cam_south, "btn_nudge_cam_south", "Nudge South",
                new List<string>()
                {
                    "@warpcamsouth 0@0.0@0"
                }, null, null);
            replace_button_to_cheat(btn_nudge_cam_east, "btn_nudge_cam_east", "Nudge West", new List<string>()
            {
                "@warpcamwest 0@0.0@0"
            }, null, null);
            replace_button_to_cheat(btn_nudge_cam_west, "btn_nudge_cam_west", "Nudge East", new List<string>()
            {
                "@warpcameast 0@0.0@0"
            }, null, null);
            replace_button_to_cheat(btn_nudge_cam_up, "btn_nudge_cam_up", "Nudge Up", new List<string>()
            {
                "@warpcamup 0@0.0@0"
            }, null, null);
            replace_button_to_cheat(btn_nudge_cam_down, "btn_nudge_cam_down", "Nudge Down", new List<string>()
            {
                "@warpcamdown 0@0.0@0"
            }, null, null);
            replace_button_to_cheat(btn_nudge_dist_up, "btn_nudge_dist_up", "Nudge Amount +",
                new List<string>()
                {
                    "@nudgecamdistup 0@0.0@0"
                }, null, null);
            replace_button_to_cheat(btn_nudge_dist_down, "btn_nudge_dist_down", "Nudge Amount -",
                new List<string>()
                {
                    "@nudgecamdistdown 0@0.0@0"
                }, null, null);
            replace_button_to_cheat(btn_player_nudge_dist_up, "btn_player_nudge_dist_up", "Nudge Amount +",
                new List<string>()
                {
                    "@nudgeplayerdistup 0@0.0@0"
                }, null, null);
            replace_button_to_cheat(btn_player_nudge_dist_down, "btn_player_nudge_dist_down",
                "Nudge Amount -", new List<string>()
                {
                    "@nudgeplayerdistdown 0@0.0@0"
                }, null, null);
            replace_button_to_cheat(btn_save_potition, "btn_saveposition", "Save Position", new List<string>()
            {
                "@saveposition@0@0"
            }, null, null);
            replace_button_to_cheat(btn_restore_position, "btn_restoreposition", "Restore Position",
                new List<string>()
                {
                    "@restoreposition@0@0"
                }, null, null);
            replace_button_to_cheat(btn_lock_cam_x, "btn_lock_cam_x", "Lock Cam X.", null,
                new List<string>()
                {
                    "|48BB78|90 90 90 90 90 90 |"
                }, new List<string>()
                {
                    "|48BB78|89 8E 80 00 00 00 |"
                });
            replace_button_to_cheat(btn_lock_cam_y, "btn_lock_cam_y", "Lock Cam Y.", null,
                new List<string>()
                {
                    "|48BB84|90 90 90 90 90 90 |"
                }, new List<string>()
                {
                    "|48BB84|89 96 84 00 00 00 |"
                });
            replace_button_to_cheat(btn_lock_cam_z, "btn_lock_cam_z", "Lock Cam Z.", null,
                new List<string>()
                {
                    "|48BB90|90 90 90 90 90 90 |"
                }, new List<string>()
                {
                    "|48BB90|89 86 88 00 00 00 |"
                });
            replace_button_to_cheat(btn_lock_cam_yaw, "btn_lock_cam_yaw", "Lock Yaw (turn)",
                null, new List<string>()
                {
                    "|008D09B7|EB 23 |"
                }, new List<string>() { "|008D09B7|74 23 |" });
            replace_button_to_cheat(btn_lock_cam_pitch, "btn_lock_cam_pitch", "Lock Pitch",
                null, new List<string>()
                {
                    "|008D3790|EB 16 |"
                }, new List<string>() { "|008D3790|74 16 |" });
            replace_button_to_cheat(btn_invisible_lara, "btn_invisible_lara", "Invisible Lara",
                null, new List<string>()
                {
                    "|943eF7|90 90 90 |"
                }, new List<string>() { "|943eF7|0F 5C C1 |" });
            replace_button_to_cheat(btn_camchasefar, "btn_camchase_far", "Cam Chase Far", null,
                new List<string>()
                {
                    "|8D4421|D9 EB |"
                }, new List<string>() { "|8D4421|D9 E8 |" });
            replace_button_to_cheat(btn_cam_zoom, "btn_cam_zoom", "Cam Zoom (lens)", null,
                new List<string>()
                {
                    "|0048BBB0|D9 EC 90 90 90 90 |"
                }, new List<string>()
                {
                    "|0048BBB0|D9 87 A0 00 00 00 |"
                });
            replace_button_to_cheat(btn_rgb_boost, "btn_rgb_boost", "RGB Bright Boost", null,
                new List<string>()
                {
                    "|9D4B0C|D9 EB 90 90 |",
                    "|9D4B19|D9 EB 90 90 |",
                    "|9D4B35|D9 EB 90 90 |"
                }, new List<string>()
                {
                    "|9D4B0C|D9 44 24 24 |",
                    "|9D4B19|D9 44 24 24 |",
                    "|9D4B35|D9 44 24 28 |"
                });
            replace_button_to_cheat(btn_bright_norm, "btn_bright_norm", "Light Norm", new List<string>()
            {
                "|5A168D|D9 44 24 10 |"
            }, null, null);
            replace_button_to_cheat(btn_bright_0, "btn_bright_0", "Silhouette", new List<string>()
            {
                "|5A168D|D9 EE 90 90 |"
            }, null, null);
            replace_button_to_cheat(btn_bright_1, "btn_bright_1", "Glow", new List<string>()
            {
                "|5A168D|D9 ED 90 90 |"
            }, null, null);
            replace_button_to_cheat(btn_bright_2, "btn_bright_2", "Glow+", new List<string>()
            {
                "|5A168D|D9 E8 90 90 |"
            }, null, null);
            replace_button_to_cheat(btn_bright_3, "btn_bright_3", "Glow++", new List<string>()
            {
                "|5A168D|D9 EA 90 90 |"
            }, null, null);
            replace_button_to_cheat(btn_bright_4, "btn_bright_4", "Glow+++", new List<string>()
            {
                "|5A168D|D9 EB 90 90 |"
            }, null, null);
            replace_button_to_cheat(btn_contrast_norm, "btn_contrast_norm", "Contrast Norm",
                new List<string>()
                {
                    "|DC7380|00 00 00 A0 99 99 B9 3F |"
                }, null, null);
            replace_button_to_cheat(btn_contrast_hi, "btn_contrast_hi", "Contrast Hi", new List<string>()
            {
                "|DC7380|00 00 00 00 00 00 00 00 |"
            }, null, null);
            replace_button_to_cheat(btn_contrast_low, "btn_contrast_low", "Contrast Low", new List<string>()
            {
                "|DC7380|00 00 00 00 00 00 F0 3F |"
            }, null, null);
            CheatButton.load_hotkeys();
        }

        /*
            이 함수는 주어진 Button 객체를 제거하고 대신 CheatButton 객체를 생성하여 추가하는 역할을 함. (GPT)
            쉽게 말해 일반 버튼을 치트 버튼으로 치환시켜주는 함수
            List 인자엔 버튼을 눌렀을때 변조할 메모리 값을 제공한다.
         */
        public CheatButton replace_button_to_cheat(
            Button inButton,
            string _IDString,
            string _nameString,
            List<string> _ClickStrings,
            List<string> _EnableStrings,
            List<string> _DisableStrings)
        {
            int left = inButton.Left;
            int top = inButton.Top;
            Control parent = inButton.Parent;
            parent.Controls.Remove(inButton);
            inButton.Dispose();
            CheatButton cheatButton =
                new CheatButton(_IDString, _nameString, _ClickStrings, _EnableStrings, _DisableStrings);
            inButton = cheatButton;
            parent.Controls.Add(inButton);
            inButton.Left = left;
            inButton.Top = top;
            return cheatButton;
        }

        private void dynamicbutton_Click(object sender, EventArgs e) => addText("Worked!");

        public void functionCall(string inName, string inParam1, string inParam2)
        {
            if (inName.IndexOf("spawn") > -1)
            {
                int num1 = (int)uint.Parse(inParam1);
                int num2 = (int)uint.Parse(inParam2);
            }

            if (inName.IndexOf("warpnorth") > -1)
                setYPos(getYPos() - trackbarPlayer.Value);
            if (inName.IndexOf("warpsouth") > -1)
                setYPos(getYPos() + trackbarPlayer.Value);
            if (inName.IndexOf("warpwest") > -1)
                setXPos(getXPos() + trackbarPlayer.Value);
            if (inName.IndexOf("warpeast") > -1)
                setXPos(getXPos() - trackbarPlayer.Value);
            if (inName.IndexOf("warpup") > -1)
                setZPos(getZPos() + trackbarPlayer.Value);
            if (inName.IndexOf("warpdown") > -1)
                setZPos(getZPos() - trackbarPlayer.Value);
            if (inName.IndexOf("warpcamnorth") > -1)
                setYPosCam(getYPosCam() - trackbarcamera.Value);
            if (inName.IndexOf("warpcamsouth") > -1)
                setYPosCam(getYPosCam() + trackbarcamera.Value);
            if (inName.IndexOf("warpcamwest") > -1)
                setXPosCam(getXPosCam() + trackbarcamera.Value);
            if (inName.IndexOf("warpcameast") > -1)
                setXPosCam(getXPosCam() - trackbarcamera.Value);
            if (inName.IndexOf("warpcamup") > -1)
                setZPosCam(getZPosCam() + trackbarcamera.Value);
            if (inName.IndexOf("warpcamdown") > -1)
                setZPosCam(getZPosCam() - trackbarcamera.Value);
            if (inName.IndexOf("nudgecamdistup") > -1)
            {
                int num = trackbarcamera.Value + 5;
                if (num > 100)
                    num = 100;
                trackbarcamera.Value = num;
            }

            if (inName.IndexOf("nudgecamdistdown") > -1)
            {
                int num = trackbarcamera.Value - 5;
                if (num < 1)
                    num = 1;
                trackbarcamera.Value = num;
            }

            if (inName.IndexOf("nudgeplayerdistup") > -1)
            {
                int num = trackbarPlayer.Value + 5;
                if (num > 100)
                    num = 100;
                trackbarPlayer.Value = num;
            }

            if (inName.IndexOf("nudgeplayerdistdown") > -1)
            {
                int num = trackbarPlayer.Value - 5;
                if (num < 1)
                    num = 1;
                trackbarPlayer.Value = num;
            }

            if (inName.IndexOf("restoreposition") > -1)
                restorePlayerPosition();
            if (inName.IndexOf("saveposition") > -1)
                savePlayerPosition();
            if (inName.IndexOf("edit") <= -1)
                return;
            if (inName.IndexOf("editfloat") > -1)
            {
                if (inName.IndexOf("player_x") > -1)
                    setXPos(float.Parse(inParam1));
                if (inName.IndexOf("player_y") > -1)
                    setYPos(float.Parse(inParam1));
                if (inName.IndexOf("player_z") > -1)
                    setZPos(float.Parse(inParam1));
                if (inName.IndexOf("cam_x") > -1)
                    setXPosCam(float.Parse(inParam1));
                if (inName.IndexOf("cam_y") > -1)
                    setYPosCam(float.Parse(inParam1));
                if (inName.IndexOf("cam_z") <= -1)
                    return;
                setZPosCam(float.Parse(inParam1));
            }
            else
            {
                uint num = uint.Parse(inParam1);
                addText("offset is " + uint.Parse(inParam2).ToString() + "  butonval is " +
                                     num.ToString());
            }
        }


        private void tabControl1_Selected(object sender, TabControlEventArgs e) => showPanel(e.TabPageIndex);

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            for (int index1 = 0; index1 < panelList.Count; ++index1)
            {
                Panel panel = panelList[index1];
                if (panelTargs[index1] != (double)this.panelCurrent[index1])
                {
                    List<float> panelCurrent;
                    int index2;
                    (panelCurrent = this.panelCurrent)[index2 = index1] = panelCurrent[index2] +
                                                                          (float)((panelTargs[index1] -
                                                                                  (double)this.panelCurrent[index1]) /
                                                                              10.0);
                    panel.Left = (int)Math.Floor(this.panelCurrent[index1]);
                }

                if (Math.Abs(panelTargs[index1] - this.panelCurrent[index1]) < 5.0)
                {
                    panelCurrent[index1] = panelTargs[index1];
                    panel.Left = (int)Math.Floor(panelCurrent[index1]);
                }
            }
        }

        public void showButtonPanel()
        {
            if (lastButton == null || lastButton.Parent == null ||
                !(lastButton.Parent is Panel))
                return;
            int num = panelList.IndexOf(lastButton.Parent as Panel);
            if (num <= -1)
                return;
            tabControl1.SelectedIndex = num;
        }

        // 패널 보여줄 때 호출되는 함수 (화면 크기 설정하는 함수)
        public void showPanel(int panelNum)
        {
            const int show_range = 60;
            for (int index = 0; index < panelList.Count; ++index)
            {
                if (panelNum != panelList.Count)
                {
                    panelTargs[index] = index == panelNum ? 0.0f : panelLeft;
                    if (index != panelNum)
                        panelList[index].Parent.Controls.SetChildIndex(panelList[index], 0);
                    Width = panelWidth + show_range;
                }
                else
                {
                    panelTargs[index] = index * panelWidth;
                    Width = panelWidth * 4 + show_range;
                }
            }
        }

        private void panel_4_Paint(object sender, PaintEventArgs e)
        {
        }

        private void panel_5_Paint(object sender, PaintEventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void Debugging_Click(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void statusLabel_Click(object sender, EventArgs e)
        {
        }

        private void timer3_Tick(object sender, EventArgs e) => GameOverlay.tick();

        private void blitLengthTimer_Tick(object sender, EventArgs e) => GameOverlay.tick();

        private void button1_Click_1(object sender, EventArgs e) => GameOverlay.drawString("OHMIGOSH, What now?");

        private void button1_Click_2(object sender, EventArgs e)
        {
        }

        private void editButton_weapons_Click(object sender, EventArgs e)
        {
        }

        public void save_settings()
        {
            settingsBox.Text = "";
            for (int index = 0; index < saveableCheckBoxes.Length; ++index)
            {
                CheckBox saveableCheckBox = saveableCheckBoxes[index];
                settingsBox.AppendText(saveableCheckBox.Text + "," + saveableCheckBox.Checked.ToString() + "|");
            }

            settingsBox.SaveFile("settings.dat");
        }

        public void load_settings()
        {
            settingsBox.Text = "";
            if (!File.Exists("settings.dat"))
            {
                addText("No settings found , they will be created");
                return;
            }
            settingsBox.LoadFile("settings.dat");
            string[] strArray1 = settingsBox.Text.Split('|');
            if (settingsBox.Text.Length <= 1)
                return;

            for (int index1 = 0; index1 < strArray1.Length; ++index1)
            {
                string[] strArray2 = strArray1[index1].Split(',');
                if (strArray1[index1].Length > 5)
                {
                    bool flag = bool.Parse(strArray2[1]);
                    for (int index2 = 0; index2 < saveableCheckBoxes.Length; ++index2)
                    {
                        CheckBox saveableCheckBox = saveableCheckBoxes[index2];
                        if (saveableCheckBox.Text == strArray2[0])
                            saveableCheckBox.Checked = flag;
                    }
                }
            }


            GameHooks.hotkeysDisabled = cbKeybinds.Checked;

        }

        private void button1_Click_3(object sender, EventArgs e) => save_settings();

        private void button2_Click(object sender, EventArgs e) => load_settings();

        private void cbKeybinds_CheckedChanged(object sender, EventArgs e) => save_settings();

        private void cbOverlay_CheckedChanged(object sender, EventArgs e) => save_settings();

        private void cbAutoUpdate_CheckedChanged(object sender, EventArgs e) => save_settings();

        private void button1_Click_4(object sender, EventArgs e)
        {
        }

        private void trainer_hp_Click(object sender, EventArgs e)
        {
        }

        private int getPlayerLocAddress() => GameConnector.ReadPointerAdjusted(9712532U);

        private int getCamLocAddress() => GameConnector.ReadPointerAdjusted(38917784U) + 1104 + 144;

        private void savePlayerPosition()
        {
            positionSaved = true;
            savedX = getXPos();
            savedY = getYPos();
            savedZ = getZPos();
        }

        private void restorePlayerPosition()
        {
            if (!positionSaved)
                return;
            float xpos = getXPos();
            float ypos = getYPos();
            float zpos = getZPos();
            setXPos(savedX);
            setYPos(savedY);
            setZPos(savedZ);
            savedX = xpos;
            savedY = ypos;
            savedZ = zpos;
        }

        private float getXPos()
        {
            int playerLocAddress = getPlayerLocAddress();
            return playerLocAddress > 0
                ? BitConverter.ToSingle(BitConverter.GetBytes(GameConnector.ReadPointer((uint)playerLocAddress)), 0)
                : 0.0f;
        }

        private float getYPos()
        {
            int pointer = getPlayerLocAddress() + 4;
            return pointer > 0
                ? BitConverter.ToSingle(BitConverter.GetBytes(GameConnector.ReadPointer((uint)pointer)), 0)
                : 0.0f;
        }

        private float getZPos()
        {
            int pointer = getPlayerLocAddress() + 8;
            return pointer > 0
                ? BitConverter.ToSingle(BitConverter.GetBytes(GameConnector.ReadPointer((uint)pointer)), 0)
                : 0.0f;
        }

        private void setXPos(float inFloat)
        {
            int playerLocAddress = getPlayerLocAddress();
            GameConnector.ReadPointer((uint)playerLocAddress);
            GameConnector.writeMem((IntPtr)(playerLocAddress - (int)GameConnector.gameModuleOffset),
                BitConverter.GetBytes(inFloat));
        }

        private void setYPos(float inFloat)
        {
            int pointer = getPlayerLocAddress() + 4;
            GameConnector.ReadPointer((uint)pointer);
            GameConnector.writeMem((IntPtr)(pointer - (int)GameConnector.gameModuleOffset),
                BitConverter.GetBytes(inFloat));
        }

        private void setZPos(float inFloat)
        {
            int pointer = getPlayerLocAddress() + 8;
            GameConnector.ReadPointer((uint)pointer);
            GameConnector.writeMem((IntPtr)(pointer - (int)GameConnector.gameModuleOffset),
                BitConverter.GetBytes(inFloat));
        }

        private void addXPos(float inFloat) => setXPos(getXPos() + inFloat);

        private void addYPos(float inFloat) => setYPos(getYPos() + inFloat);

        private void addZPos(float inFloat) => setZPos(getZPos() + inFloat);

        private float getXPosCam()
        {
            int camLocAddress = getCamLocAddress();
            return camLocAddress > 0
                ? BitConverter.ToSingle(BitConverter.GetBytes(GameConnector.ReadPointer((uint)camLocAddress)), 0)
                : 0.0f;
        }

        private float getYPosCam()
        {
            int pointer = getCamLocAddress() + 4;
            return pointer > 0
                ? BitConverter.ToSingle(BitConverter.GetBytes(GameConnector.ReadPointer((uint)pointer)), 0)
                : 0.0f;
        }

        private float getZPosCam()
        {
            int pointer = getCamLocAddress() + 8;
            return pointer > 0
                ? BitConverter.ToSingle(BitConverter.GetBytes(GameConnector.ReadPointer((uint)pointer)), 0)
                : 0.0f;
        }

        private void setXPosCam(float inFloat)
        {
            int camLocAddress = getCamLocAddress();
            GameConnector.ReadPointer((uint)camLocAddress);
            GameConnector.writeMem((IntPtr)(camLocAddress - (int)GameConnector.gameModuleOffset),
                BitConverter.GetBytes(inFloat));
        }

        private void setYPosCam(float inFloat)
        {
            int pointer = getCamLocAddress() + 4;
            GameConnector.ReadPointer((uint)pointer);
            GameConnector.writeMem((IntPtr)(pointer - (int)GameConnector.gameModuleOffset),
                BitConverter.GetBytes(inFloat));
        }

        private void setZPosCam(float inFloat)
        {
            int pointer = getCamLocAddress() + 8;
            GameConnector.ReadPointer((uint)pointer);
            GameConnector.writeMem((IntPtr)(pointer - (int)GameConnector.gameModuleOffset),
                BitConverter.GetBytes(inFloat));
        }

        private void addXPosCam(float inFloat) => setXPosCam(getXPosCam() + inFloat);

        private void addYPosCam(float inFloat) => setYPosCam(getYPosCam() + inFloat);

        private void addZPosCam(float inFloat) => setZPosCam(getZPosCam() + inFloat);

        private void button1_Click_5(object sender, EventArgs e)
        {
        }

        private void btn_jumpheight_0_Click(object sender, EventArgs e)
        {
        }

        private void linkLabel2_Click(object sender, EventArgs e)
        {
            Process.Start("http://sicklebrick.com/?p=513");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://www.tombraiderforums.com/showthread.php?p=6784668");
        }

        private void button1_Click_6(object sender, EventArgs e)
        {
            int num1 = GameConnector.ReadPointer(38917784U);
            int num2 = num1 + 1104 + 144;
            int num3 = (int)MessageBox.Show("constant val is " + num1.ToString("X"));
            int num4 = (int)MessageBox.Show("constant val is " + num2.ToString("X"));
        }

        private void label12_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click_7(object sender, EventArgs e)
        {
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            int camLocAddress = getCamLocAddress();
            float single =
                BitConverter.ToSingle(BitConverter.GetBytes(GameConnector.ReadPointer((uint)(camLocAddress + 16 + 8))),
                    0);
            float num1 =
                (float)Math.Atan2(
                    BitConverter.ToSingle(
                        BitConverter.GetBytes(GameConnector.ReadPointer((uint)(camLocAddress + 16 + 8 + 4))), 0),
                    single) * -114.59156f + 0.1f;
            float num2 = (float)Math.Cos(num1 * Math.PI / 180.0 * -0.5);
            float num3 = (float)Math.Sin(num1 * Math.PI / 180.0 * -0.5);
            int gameModuleOffset = (int)GameConnector.gameModuleOffset;
            GameConnector.writeMem((IntPtr)(camLocAddress + 16 + 8 - gameModuleOffset), BitConverter.GetBytes(num2));
            GameConnector.writeMem((IntPtr)(camLocAddress + 16 + 8 + 4 - gameModuleOffset),
                BitConverter.GetBytes(num3));
        }

        private void button7_Click(object sender, EventArgs e)
        {
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}