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
            components = new Container();
            label1 = new Label();
            ConnectionTimer = new Timer(components);
            panel_1 = new Panel();
            btn_static_lara = new Button();
            trackbarPlayer = new TrackBar();
            btn_player_nudge_dist_down = new Button();
            btn_player_nudge_dist_up = new Button();
            btn_warpdown = new Button();
            btn_warpup = new Button();
            btn_warpeast = new Button();
            btn_warpwest = new Button();
            btn_warpsouth = new Button();
            btn_warpnorth = new Button();
            btn_edit_PlayerZ = new Button();
            btn_edit_PlayerY = new Button();
            btn_edit_PlayerX = new Button();
            btn_restore_position = new Button();
            btn_save_potition = new Button();
            btn_noclip = new Button();
            label2 = new Label();
            btn_levitate = new Button();
            btn_hover_down = new Button();
            btn_hover_up = new Button();
            btn_hover_none = new Button();
            panel_2 = new Panel();
            trackbarcamera = new TrackBar();
            btn_nudge_dist_down = new Button();
            btn_nudge_dist_up = new Button();
            label13 = new Label();
            btn_no_wobble = new Button();
            btn_cam_zoom = new Button();
            btn_camchasefar = new Button();
            label6 = new Label();
            btn_nudge_cam_down = new Button();
            btn_nudge_cam_up = new Button();
            btn_nudge_cam_east = new Button();
            btn_nudge_cam_west = new Button();
            btn_nudge_cam_south = new Button();
            btn_nudge_cam_north = new Button();
            btn_edit_cam_z = new Button();
            btn_edit_cam_y = new Button();
            btn_edit_cam_x = new Button();
            btn_invisible_lara = new Button();
            btn_lock_cam_yaw = new Button();
            btn_lock_cam_pitch = new Button();
            btn_lock_cam_z = new Button();
            btn_lock_cam_y = new Button();
            btn_lock_cam_x = new Button();
            panel_0 = new Panel();
            linkLabel3 = new LinkLabel();
            btn_runspeed_walk = new Button();
            btn_normal_ammo = new Button();
            btn_spawnwolves = new Button();
            btn_salvagearrows = new Button();
            btn_runspeedplusplus = new Button();
            btn_runspeedplus = new Button();
            btn_runspeednormal = new Button();
            btn_jumpheight_2 = new Button();
            label12 = new Label();
            btn_jumpheight_3 = new Button();
            statusLabel = new Label();
            btn_jumpheight_1 = new Button();
            btn_jumpheight_0 = new Button();
            linkLabel2 = new LinkLabel();
            linkLabel1 = new LinkLabel();
            btn_salvagepoints = new Button();
            btn_ammo = new Button();
            btn_health = new Button();
            btn_damagesquared = new Button();
            btn_upgrades = new Button();
            btn_reload = new Button();
            btn_skillpoints = new Button();
            label4 = new Label();
            panel_3 = new Panel();
            btn_contrast_low = new Button();
            btn_contrast_norm = new Button();
            btn_contrast_hi = new Button();
            btn_rgb_boost = new Button();
            btn_bright_norm = new Button();
            btn_bright_4 = new Button();
            btn_bright_3 = new Button();
            btn_bright_2 = new Button();
            btn_bright_1 = new Button();
            btn_bright_0 = new Button();
            btn_no_weaps = new Button();
            btn_clean_lara = new Button();
            btn_smalltits = new Button();
            btn_biggertits = new Button();
            btn_bigtits = new Button();
            btn_jiggletitsmega = new Button();
            btn_jiggletitson = new Button();
            btn_jiggletitsoff = new Button();
            btn_normaltits = new Button();
            label5 = new Label();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            tabPage10 = new TabPage();
            tabPage11 = new TabPage();
            tabPage4 = new TabPage();
            tabPage3 = new TabPage();
            savebox = new RichTextBox();
            label7 = new Label();
            timer2 = new Timer(components);
            label11 = new Label();
            blitTimer = new Timer(components);
            fontLabel = new Label();
            blitLengthTimer = new Timer(components);
            settingsBox = new RichTextBox();
            cbAutoUpdate = new CheckBox();
            cbOverlay = new CheckBox();
            label3 = new Label();
            button2 = new Button();
            panel_4 = new Panel();
            richTextBox3 = new RichTextBox();
            cbKeybinds = new CheckBox();
            richTextBox2 = new RichTextBox();
            label10 = new Label();
            label9 = new Label();
            Debugging = new Label();
            label8 = new Label();
            richTextBox1 = new RichTextBox();
            btn_outfits = new Button();
            panel_1.SuspendLayout();
            ((ISupportInitialize)(trackbarPlayer)).BeginInit();
            panel_2.SuspendLayout();
            ((ISupportInitialize)(trackbarcamera)).BeginInit();
            panel_0.SuspendLayout();
            panel_3.SuspendLayout();
            tabControl1.SuspendLayout();
            panel_4.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(2861, 144);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(60, 24);
            label1.TabIndex = 1;
            label1.Text = "label1";
            // 
            // ConnectionTimer
            // 
            ConnectionTimer.Tick += timer1_Tick;
            // 
            // panel_1
            // 
            panel_1.BorderStyle = BorderStyle.FixedSingle;
            panel_1.Controls.Add(btn_static_lara);
            panel_1.Controls.Add(trackbarPlayer);
            panel_1.Controls.Add(btn_player_nudge_dist_down);
            panel_1.Controls.Add(btn_player_nudge_dist_up);
            panel_1.Controls.Add(btn_warpdown);
            panel_1.Controls.Add(btn_warpup);
            panel_1.Controls.Add(btn_warpeast);
            panel_1.Controls.Add(btn_warpwest);
            panel_1.Controls.Add(btn_warpsouth);
            panel_1.Controls.Add(btn_warpnorth);
            panel_1.Controls.Add(btn_edit_PlayerZ);
            panel_1.Controls.Add(btn_edit_PlayerY);
            panel_1.Controls.Add(btn_edit_PlayerX);
            panel_1.Controls.Add(btn_restore_position);
            panel_1.Controls.Add(btn_save_potition);
            panel_1.Controls.Add(btn_noclip);
            panel_1.Controls.Add(label2);
            panel_1.Controls.Add(btn_levitate);
            panel_1.Controls.Add(btn_hover_down);
            panel_1.Controls.Add(btn_hover_up);
            panel_1.Controls.Add(btn_hover_none);
            panel_1.Location = new System.Drawing.Point(554, 22);
            panel_1.Margin = new Padding(4, 3, 4, 3);
            panel_1.Name = "panel_1";
            panel_1.Size = new System.Drawing.Size(525, 506);
            panel_1.TabIndex = 24;
            panel_1.Tag = "2";
            // 
            // btn_static_lara
            // 
            btn_static_lara.Location = new System.Drawing.Point(19, 262);
            btn_static_lara.Margin = new Padding(4, 3, 4, 3);
            btn_static_lara.Name = "btn_static_lara";
            btn_static_lara.Size = new System.Drawing.Size(233, 37);
            btn_static_lara.TabIndex = 56;
            btn_static_lara.Text = "static lara";
            btn_static_lara.UseVisualStyleBackColor = true;
            // 
            // trackbarPlayer
            // 
            trackbarPlayer.Location = new System.Drawing.Point(14, 458);
            trackbarPlayer.Margin = new Padding(4, 3, 4, 3);
            trackbarPlayer.Maximum = 100;
            trackbarPlayer.Minimum = 1;
            trackbarPlayer.Name = "trackbarPlayer";
            trackbarPlayer.Size = new System.Drawing.Size(485, 45);
            trackbarPlayer.TabIndex = 55;
            trackbarPlayer.TickStyle = TickStyle.TopLeft;
            trackbarPlayer.Value = 50;
            // 
            // btn_player_nudge_dist_down
            // 
            btn_player_nudge_dist_down.Location = new System.Drawing.Point(9, 417);
            btn_player_nudge_dist_down.Margin = new Padding(4, 3, 4, 3);
            btn_player_nudge_dist_down.Name = "btn_player_nudge_dist_down";
            btn_player_nudge_dist_down.Size = new System.Drawing.Size(233, 37);
            btn_player_nudge_dist_down.TabIndex = 54;
            btn_player_nudge_dist_down.Text = "warpdown";
            btn_player_nudge_dist_down.UseVisualStyleBackColor = true;
            // 
            // btn_player_nudge_dist_up
            // 
            btn_player_nudge_dist_up.Location = new System.Drawing.Point(271, 417);
            btn_player_nudge_dist_up.Margin = new Padding(4, 3, 4, 3);
            btn_player_nudge_dist_up.Name = "btn_player_nudge_dist_up";
            btn_player_nudge_dist_up.Size = new System.Drawing.Size(233, 37);
            btn_player_nudge_dist_up.TabIndex = 53;
            btn_player_nudge_dist_up.Text = "warpdown";
            btn_player_nudge_dist_up.UseVisualStyleBackColor = true;
            // 
            // btn_warpdown
            // 
            btn_warpdown.Location = new System.Drawing.Point(271, 366);
            btn_warpdown.Margin = new Padding(4, 3, 4, 3);
            btn_warpdown.Name = "btn_warpdown";
            btn_warpdown.Size = new System.Drawing.Size(233, 37);
            btn_warpdown.TabIndex = 52;
            btn_warpdown.Text = "warpdown";
            btn_warpdown.UseVisualStyleBackColor = true;
            // 
            // btn_warpup
            // 
            btn_warpup.Location = new System.Drawing.Point(271, 325);
            btn_warpup.Margin = new Padding(4, 3, 4, 3);
            btn_warpup.Name = "btn_warpup";
            btn_warpup.Size = new System.Drawing.Size(233, 37);
            btn_warpup.TabIndex = 51;
            btn_warpup.Text = "warpup";
            btn_warpup.UseVisualStyleBackColor = true;
            // 
            // btn_warpeast
            // 
            btn_warpeast.Location = new System.Drawing.Point(271, 284);
            btn_warpeast.Margin = new Padding(4, 3, 4, 3);
            btn_warpeast.Name = "btn_warpeast";
            btn_warpeast.Size = new System.Drawing.Size(233, 37);
            btn_warpeast.TabIndex = 50;
            btn_warpeast.Text = "warpeast";
            btn_warpeast.UseVisualStyleBackColor = true;
            // 
            // btn_warpwest
            // 
            btn_warpwest.Location = new System.Drawing.Point(271, 244);
            btn_warpwest.Margin = new Padding(4, 3, 4, 3);
            btn_warpwest.Name = "btn_warpwest";
            btn_warpwest.Size = new System.Drawing.Size(233, 37);
            btn_warpwest.TabIndex = 49;
            btn_warpwest.Text = "warpwest";
            btn_warpwest.UseVisualStyleBackColor = true;
            // 
            // btn_warpsouth
            // 
            btn_warpsouth.Location = new System.Drawing.Point(271, 203);
            btn_warpsouth.Margin = new Padding(4, 3, 4, 3);
            btn_warpsouth.Name = "btn_warpsouth";
            btn_warpsouth.Size = new System.Drawing.Size(233, 37);
            btn_warpsouth.TabIndex = 48;
            btn_warpsouth.Text = "warpsouth";
            btn_warpsouth.UseVisualStyleBackColor = true;
            // 
            // btn_warpnorth
            // 
            btn_warpnorth.Location = new System.Drawing.Point(271, 162);
            btn_warpnorth.Margin = new Padding(4, 3, 4, 3);
            btn_warpnorth.Name = "btn_warpnorth";
            btn_warpnorth.Size = new System.Drawing.Size(233, 37);
            btn_warpnorth.TabIndex = 47;
            btn_warpnorth.Text = "warpnorth";
            btn_warpnorth.UseVisualStyleBackColor = true;
            // 
            // btn_edit_PlayerZ
            // 
            btn_edit_PlayerZ.Location = new System.Drawing.Point(271, 111);
            btn_edit_PlayerZ.Margin = new Padding(4, 3, 4, 3);
            btn_edit_PlayerZ.Name = "btn_edit_PlayerZ";
            btn_edit_PlayerZ.Size = new System.Drawing.Size(233, 37);
            btn_edit_PlayerZ.TabIndex = 46;
            btn_edit_PlayerZ.Text = "playerZ";
            btn_edit_PlayerZ.UseVisualStyleBackColor = true;
            // 
            // btn_edit_PlayerY
            // 
            btn_edit_PlayerY.Location = new System.Drawing.Point(271, 70);
            btn_edit_PlayerY.Margin = new Padding(4, 3, 4, 3);
            btn_edit_PlayerY.Name = "btn_edit_PlayerY";
            btn_edit_PlayerY.Size = new System.Drawing.Size(233, 37);
            btn_edit_PlayerY.TabIndex = 45;
            btn_edit_PlayerY.Text = "playerY";
            btn_edit_PlayerY.UseVisualStyleBackColor = true;
            // 
            // btn_edit_PlayerX
            // 
            btn_edit_PlayerX.Location = new System.Drawing.Point(271, 30);
            btn_edit_PlayerX.Margin = new Padding(4, 3, 4, 3);
            btn_edit_PlayerX.Name = "btn_edit_PlayerX";
            btn_edit_PlayerX.Size = new System.Drawing.Size(233, 37);
            btn_edit_PlayerX.TabIndex = 44;
            btn_edit_PlayerX.Text = "playerX";
            btn_edit_PlayerX.UseVisualStyleBackColor = true;
            // 
            // btn_restore_position
            // 
            btn_restore_position.Location = new System.Drawing.Point(19, 366);
            btn_restore_position.Margin = new Padding(4, 3, 4, 3);
            btn_restore_position.Name = "btn_restore_position";
            btn_restore_position.Size = new System.Drawing.Size(233, 37);
            btn_restore_position.TabIndex = 43;
            btn_restore_position.Text = "restoreposition";
            btn_restore_position.UseVisualStyleBackColor = true;
            // 
            // btn_save_potition
            // 
            btn_save_potition.Location = new System.Drawing.Point(19, 325);
            btn_save_potition.Margin = new Padding(4, 3, 4, 3);
            btn_save_potition.Name = "btn_save_potition";
            btn_save_potition.Size = new System.Drawing.Size(233, 37);
            btn_save_potition.TabIndex = 42;
            btn_save_potition.Text = "saveposition";
            btn_save_potition.UseVisualStyleBackColor = true;
            // 
            // btn_noclip
            // 
            btn_noclip.Location = new System.Drawing.Point(19, 218);
            btn_noclip.Margin = new Padding(4, 3, 4, 3);
            btn_noclip.Name = "btn_noclip";
            btn_noclip.Size = new System.Drawing.Size(233, 37);
            btn_noclip.TabIndex = 41;
            btn_noclip.Text = "noclip";
            btn_noclip.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.Location = new System.Drawing.Point(28, 15);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(51, 15);
            label2.TabIndex = 28;
            label2.Text = "Position";
            // 
            // btn_levitate
            // 
            btn_levitate.Location = new System.Drawing.Point(19, 174);
            btn_levitate.Margin = new Padding(4, 3, 4, 3);
            btn_levitate.Name = "btn_levitate";
            btn_levitate.Size = new System.Drawing.Size(233, 37);
            btn_levitate.TabIndex = 26;
            btn_levitate.Text = "levitate";
            btn_levitate.UseVisualStyleBackColor = true;
            // 
            // btn_hover_down
            // 
            btn_hover_down.Location = new System.Drawing.Point(19, 126);
            btn_hover_down.Margin = new Padding(4, 3, 4, 3);
            btn_hover_down.Name = "btn_hover_down";
            btn_hover_down.Size = new System.Drawing.Size(233, 37);
            btn_hover_down.TabIndex = 25;
            btn_hover_down.Text = "hover down";
            btn_hover_down.UseVisualStyleBackColor = true;
            // 
            // btn_hover_up
            // 
            btn_hover_up.Location = new System.Drawing.Point(19, 85);
            btn_hover_up.Margin = new Padding(4, 3, 4, 3);
            btn_hover_up.Name = "btn_hover_up";
            btn_hover_up.Size = new System.Drawing.Size(233, 37);
            btn_hover_up.TabIndex = 24;
            btn_hover_up.Text = "hover up";
            btn_hover_up.UseVisualStyleBackColor = true;
            // 
            // btn_hover_none
            // 
            btn_hover_none.Location = new System.Drawing.Point(19, 44);
            btn_hover_none.Margin = new Padding(4, 3, 4, 3);
            btn_hover_none.Name = "btn_hover_none";
            btn_hover_none.Size = new System.Drawing.Size(233, 37);
            btn_hover_none.TabIndex = 23;
            btn_hover_none.Text = "hover none";
            btn_hover_none.UseVisualStyleBackColor = true;
            // 
            // panel_2
            // 
            panel_2.BorderStyle = BorderStyle.FixedSingle;
            panel_2.Controls.Add(trackbarcamera);
            panel_2.Controls.Add(btn_nudge_dist_down);
            panel_2.Controls.Add(btn_nudge_dist_up);
            panel_2.Controls.Add(label13);
            panel_2.Controls.Add(btn_no_wobble);
            panel_2.Controls.Add(btn_cam_zoom);
            panel_2.Controls.Add(btn_camchasefar);
            panel_2.Controls.Add(label6);
            panel_2.Controls.Add(btn_nudge_cam_down);
            panel_2.Controls.Add(btn_nudge_cam_up);
            panel_2.Controls.Add(btn_nudge_cam_east);
            panel_2.Controls.Add(btn_nudge_cam_west);
            panel_2.Controls.Add(btn_nudge_cam_south);
            panel_2.Controls.Add(btn_nudge_cam_north);
            panel_2.Controls.Add(btn_edit_cam_z);
            panel_2.Controls.Add(btn_edit_cam_y);
            panel_2.Controls.Add(btn_edit_cam_x);
            panel_2.Controls.Add(btn_invisible_lara);
            panel_2.Controls.Add(btn_lock_cam_yaw);
            panel_2.Controls.Add(btn_lock_cam_pitch);
            panel_2.Controls.Add(btn_lock_cam_z);
            panel_2.Controls.Add(btn_lock_cam_y);
            panel_2.Controls.Add(btn_lock_cam_x);
            panel_2.Location = new System.Drawing.Point(1101, 22);
            panel_2.Margin = new Padding(4, 3, 4, 3);
            panel_2.Name = "panel_2";
            panel_2.Size = new System.Drawing.Size(525, 506);
            panel_2.TabIndex = 25;
            panel_2.Tag = "4";
            panel_2.Paint += panel_5_Paint;
            // 
            // trackbarcamera
            // 
            trackbarcamera.Location = new System.Drawing.Point(23, 458);
            trackbarcamera.Margin = new Padding(4, 3, 4, 3);
            trackbarcamera.Maximum = 100;
            trackbarcamera.Minimum = 1;
            trackbarcamera.Name = "trackbarcamera";
            trackbarcamera.Size = new System.Drawing.Size(485, 45);
            trackbarcamera.TabIndex = 51;
            trackbarcamera.TickStyle = TickStyle.TopLeft;
            trackbarcamera.Value = 50;
            // 
            // btn_nudge_dist_down
            // 
            btn_nudge_dist_down.Location = new System.Drawing.Point(19, 417);
            btn_nudge_dist_down.Margin = new Padding(4, 3, 4, 3);
            btn_nudge_dist_down.Name = "btn_nudge_dist_down";
            btn_nudge_dist_down.Size = new System.Drawing.Size(233, 37);
            btn_nudge_dist_down.TabIndex = 50;
            btn_nudge_dist_down.Text = "warpdown";
            btn_nudge_dist_down.UseVisualStyleBackColor = true;
            // 
            // btn_nudge_dist_up
            // 
            btn_nudge_dist_up.Location = new System.Drawing.Point(280, 417);
            btn_nudge_dist_up.Margin = new Padding(4, 3, 4, 3);
            btn_nudge_dist_up.Name = "btn_nudge_dist_up";
            btn_nudge_dist_up.Size = new System.Drawing.Size(233, 37);
            btn_nudge_dist_up.TabIndex = 49;
            btn_nudge_dist_up.Text = "warpdown";
            btn_nudge_dist_up.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label13.Location = new System.Drawing.Point(271, 11);
            label13.Margin = new Padding(4, 0, 4, 0);
            label13.Name = "label13";
            label13.Size = new System.Drawing.Size(115, 15);
            label13.TabIndex = 48;
            label13.Text = "Lock cam to modify:";
            // 
            // btn_no_wobble
            // 
            btn_no_wobble.Location = new System.Drawing.Point(19, 248);
            btn_no_wobble.Margin = new Padding(4, 3, 4, 3);
            btn_no_wobble.Name = "btn_no_wobble";
            btn_no_wobble.Size = new System.Drawing.Size(233, 37);
            btn_no_wobble.TabIndex = 47;
            btn_no_wobble.Text = "no wobble/wind";
            btn_no_wobble.UseVisualStyleBackColor = true;
            // 
            // btn_cam_zoom
            // 
            btn_cam_zoom.Location = new System.Drawing.Point(19, 329);
            btn_cam_zoom.Margin = new Padding(4, 3, 4, 3);
            btn_cam_zoom.Name = "btn_cam_zoom";
            btn_cam_zoom.Size = new System.Drawing.Size(233, 37);
            btn_cam_zoom.TabIndex = 46;
            btn_cam_zoom.Text = "cam zoom";
            btn_cam_zoom.UseVisualStyleBackColor = true;
            // 
            // btn_camchasefar
            // 
            btn_camchasefar.Location = new System.Drawing.Point(19, 288);
            btn_camchasefar.Margin = new Padding(4, 3, 4, 3);
            btn_camchasefar.Name = "btn_camchasefar";
            btn_camchasefar.Size = new System.Drawing.Size(233, 37);
            btn_camchasefar.TabIndex = 45;
            btn_camchasefar.Text = "cam chase far";
            btn_camchasefar.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label6.Location = new System.Drawing.Point(14, 7);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(51, 15);
            label6.TabIndex = 44;
            label6.Text = "Camera";
            // 
            // btn_nudge_cam_down
            // 
            btn_nudge_cam_down.Location = new System.Drawing.Point(271, 369);
            btn_nudge_cam_down.Margin = new Padding(4, 3, 4, 3);
            btn_nudge_cam_down.Name = "btn_nudge_cam_down";
            btn_nudge_cam_down.Size = new System.Drawing.Size(233, 37);
            btn_nudge_cam_down.TabIndex = 43;
            btn_nudge_cam_down.Text = "warpdown";
            btn_nudge_cam_down.UseVisualStyleBackColor = true;
            // 
            // btn_nudge_cam_up
            // 
            btn_nudge_cam_up.Location = new System.Drawing.Point(271, 329);
            btn_nudge_cam_up.Margin = new Padding(4, 3, 4, 3);
            btn_nudge_cam_up.Name = "btn_nudge_cam_up";
            btn_nudge_cam_up.Size = new System.Drawing.Size(233, 37);
            btn_nudge_cam_up.TabIndex = 42;
            btn_nudge_cam_up.Text = "warpup";
            btn_nudge_cam_up.UseVisualStyleBackColor = true;
            // 
            // btn_nudge_cam_east
            // 
            btn_nudge_cam_east.Location = new System.Drawing.Point(271, 288);
            btn_nudge_cam_east.Margin = new Padding(4, 3, 4, 3);
            btn_nudge_cam_east.Name = "btn_nudge_cam_east";
            btn_nudge_cam_east.Size = new System.Drawing.Size(233, 37);
            btn_nudge_cam_east.TabIndex = 41;
            btn_nudge_cam_east.Text = "warpeast";
            btn_nudge_cam_east.UseVisualStyleBackColor = true;
            // 
            // btn_nudge_cam_west
            // 
            btn_nudge_cam_west.Location = new System.Drawing.Point(271, 247);
            btn_nudge_cam_west.Margin = new Padding(4, 3, 4, 3);
            btn_nudge_cam_west.Name = "btn_nudge_cam_west";
            btn_nudge_cam_west.Size = new System.Drawing.Size(233, 37);
            btn_nudge_cam_west.TabIndex = 40;
            btn_nudge_cam_west.Text = "warpwest";
            btn_nudge_cam_west.UseVisualStyleBackColor = true;
            // 
            // btn_nudge_cam_south
            // 
            btn_nudge_cam_south.Location = new System.Drawing.Point(271, 207);
            btn_nudge_cam_south.Margin = new Padding(4, 3, 4, 3);
            btn_nudge_cam_south.Name = "btn_nudge_cam_south";
            btn_nudge_cam_south.Size = new System.Drawing.Size(233, 37);
            btn_nudge_cam_south.TabIndex = 39;
            btn_nudge_cam_south.Text = "warpsouth";
            btn_nudge_cam_south.UseVisualStyleBackColor = true;
            // 
            // btn_nudge_cam_north
            // 
            btn_nudge_cam_north.Location = new System.Drawing.Point(271, 166);
            btn_nudge_cam_north.Margin = new Padding(4, 3, 4, 3);
            btn_nudge_cam_north.Name = "btn_nudge_cam_north";
            btn_nudge_cam_north.Size = new System.Drawing.Size(233, 37);
            btn_nudge_cam_north.TabIndex = 38;
            btn_nudge_cam_north.Text = "warpnorth";
            btn_nudge_cam_north.UseVisualStyleBackColor = true;
            // 
            // btn_edit_cam_z
            // 
            btn_edit_cam_z.Location = new System.Drawing.Point(271, 114);
            btn_edit_cam_z.Margin = new Padding(4, 3, 4, 3);
            btn_edit_cam_z.Name = "btn_edit_cam_z";
            btn_edit_cam_z.Size = new System.Drawing.Size(233, 37);
            btn_edit_cam_z.TabIndex = 37;
            btn_edit_cam_z.Text = "playerZ";
            btn_edit_cam_z.UseVisualStyleBackColor = true;
            // 
            // btn_edit_cam_y
            // 
            btn_edit_cam_y.Location = new System.Drawing.Point(271, 74);
            btn_edit_cam_y.Margin = new Padding(4, 3, 4, 3);
            btn_edit_cam_y.Name = "btn_edit_cam_y";
            btn_edit_cam_y.Size = new System.Drawing.Size(233, 37);
            btn_edit_cam_y.TabIndex = 36;
            btn_edit_cam_y.Text = "playerY";
            btn_edit_cam_y.UseVisualStyleBackColor = true;
            // 
            // btn_edit_cam_x
            // 
            btn_edit_cam_x.Location = new System.Drawing.Point(271, 33);
            btn_edit_cam_x.Margin = new Padding(4, 3, 4, 3);
            btn_edit_cam_x.Name = "btn_edit_cam_x";
            btn_edit_cam_x.Size = new System.Drawing.Size(233, 37);
            btn_edit_cam_x.TabIndex = 35;
            btn_edit_cam_x.Text = "playerX";
            btn_edit_cam_x.UseVisualStyleBackColor = true;
            // 
            // btn_invisible_lara
            // 
            btn_invisible_lara.Location = new System.Drawing.Point(18, 369);
            btn_invisible_lara.Margin = new Padding(4, 3, 4, 3);
            btn_invisible_lara.Name = "btn_invisible_lara";
            btn_invisible_lara.Size = new System.Drawing.Size(233, 37);
            btn_invisible_lara.TabIndex = 29;
            btn_invisible_lara.Text = "invisible lara";
            btn_invisible_lara.UseVisualStyleBackColor = true;
            // 
            // btn_lock_cam_yaw
            // 
            btn_lock_cam_yaw.Location = new System.Drawing.Point(18, 196);
            btn_lock_cam_yaw.Margin = new Padding(4, 3, 4, 3);
            btn_lock_cam_yaw.Name = "btn_lock_cam_yaw";
            btn_lock_cam_yaw.Size = new System.Drawing.Size(233, 37);
            btn_lock_cam_yaw.TabIndex = 28;
            btn_lock_cam_yaw.Text = "lockyaw";
            btn_lock_cam_yaw.UseVisualStyleBackColor = true;
            // 
            // btn_lock_cam_pitch
            // 
            btn_lock_cam_pitch.Location = new System.Drawing.Point(18, 155);
            btn_lock_cam_pitch.Margin = new Padding(4, 3, 4, 3);
            btn_lock_cam_pitch.Name = "btn_lock_cam_pitch";
            btn_lock_cam_pitch.Size = new System.Drawing.Size(233, 37);
            btn_lock_cam_pitch.TabIndex = 27;
            btn_lock_cam_pitch.Text = "lockpitch";
            btn_lock_cam_pitch.UseVisualStyleBackColor = true;
            // 
            // btn_lock_cam_z
            // 
            btn_lock_cam_z.Location = new System.Drawing.Point(18, 114);
            btn_lock_cam_z.Margin = new Padding(4, 3, 4, 3);
            btn_lock_cam_z.Name = "btn_lock_cam_z";
            btn_lock_cam_z.Size = new System.Drawing.Size(233, 37);
            btn_lock_cam_z.TabIndex = 26;
            btn_lock_cam_z.Text = "lock z";
            btn_lock_cam_z.UseVisualStyleBackColor = true;
            // 
            // btn_lock_cam_y
            // 
            btn_lock_cam_y.Location = new System.Drawing.Point(18, 74);
            btn_lock_cam_y.Margin = new Padding(4, 3, 4, 3);
            btn_lock_cam_y.Name = "btn_lock_cam_y";
            btn_lock_cam_y.Size = new System.Drawing.Size(233, 37);
            btn_lock_cam_y.TabIndex = 25;
            btn_lock_cam_y.Text = "lock y";
            btn_lock_cam_y.UseVisualStyleBackColor = true;
            // 
            // btn_lock_cam_x
            // 
            btn_lock_cam_x.Location = new System.Drawing.Point(18, 33);
            btn_lock_cam_x.Margin = new Padding(4, 3, 4, 3);
            btn_lock_cam_x.Name = "btn_lock_cam_x";
            btn_lock_cam_x.Size = new System.Drawing.Size(233, 37);
            btn_lock_cam_x.TabIndex = 24;
            btn_lock_cam_x.Text = "lock x";
            btn_lock_cam_x.UseVisualStyleBackColor = true;
            // 
            // panel_0
            // 
            panel_0.BorderStyle = BorderStyle.FixedSingle;
            panel_0.Controls.Add(linkLabel3);
            panel_0.Controls.Add(btn_runspeed_walk);
            panel_0.Controls.Add(btn_normal_ammo);
            panel_0.Controls.Add(btn_spawnwolves);
            panel_0.Controls.Add(btn_salvagearrows);
            panel_0.Controls.Add(btn_runspeedplusplus);
            panel_0.Controls.Add(btn_runspeedplus);
            panel_0.Controls.Add(btn_runspeednormal);
            panel_0.Controls.Add(btn_jumpheight_2);
            panel_0.Controls.Add(label12);
            panel_0.Controls.Add(btn_jumpheight_3);
            panel_0.Controls.Add(statusLabel);
            panel_0.Controls.Add(btn_jumpheight_1);
            panel_0.Controls.Add(btn_jumpheight_0);
            panel_0.Controls.Add(linkLabel2);
            panel_0.Controls.Add(linkLabel1);
            panel_0.Controls.Add(btn_salvagepoints);
            panel_0.Controls.Add(btn_ammo);
            panel_0.Controls.Add(btn_health);
            panel_0.Controls.Add(btn_damagesquared);
            panel_0.Controls.Add(btn_upgrades);
            panel_0.Controls.Add(btn_reload);
            panel_0.Controls.Add(btn_skillpoints);
            panel_0.Controls.Add(label4);
            panel_0.Location = new System.Drawing.Point(0, 22);
            panel_0.Margin = new Padding(4, 3, 4, 3);
            panel_0.Name = "panel_0";
            panel_0.Size = new System.Drawing.Size(525, 506);
            panel_0.TabIndex = 26;
            panel_0.Tag = "0";
            // 
            // linkLabel3
            // 
            linkLabel3.AutoSize = true;
            linkLabel3.Location = new System.Drawing.Point(319, 439);
            linkLabel3.Margin = new Padding(4, 0, 4, 0);
            linkLabel3.Name = "linkLabel3";
            linkLabel3.Size = new System.Drawing.Size(125, 12);
            linkLabel3.TabIndex = 78;
            linkLabel3.TabStop = true;
            linkLabel3.Text = "Edit : File(pgh268400)";
            // 
            // btn_runspeed_walk
            // 
            btn_runspeed_walk.Location = new System.Drawing.Point(271, 340);
            btn_runspeed_walk.Margin = new Padding(4, 3, 4, 3);
            btn_runspeed_walk.Name = "btn_runspeed_walk";
            btn_runspeed_walk.Size = new System.Drawing.Size(233, 37);
            btn_runspeed_walk.TabIndex = 77;
            btn_runspeed_walk.Text = "Runspeed Walk";
            btn_runspeed_walk.UseVisualStyleBackColor = true;
            // 
            // btn_normal_ammo
            // 
            btn_normal_ammo.Location = new System.Drawing.Point(19, 340);
            btn_normal_ammo.Margin = new Padding(4, 3, 4, 3);
            btn_normal_ammo.Name = "btn_normal_ammo";
            btn_normal_ammo.Size = new System.Drawing.Size(233, 37);
            btn_normal_ammo.TabIndex = 76;
            btn_normal_ammo.Text = "Normal ammo";
            btn_normal_ammo.UseVisualStyleBackColor = true;
            // 
            // btn_spawnwolves
            // 
            btn_spawnwolves.Location = new System.Drawing.Point(19, 421);
            btn_spawnwolves.Margin = new Padding(4, 3, 4, 3);
            btn_spawnwolves.Name = "btn_spawnwolves";
            btn_spawnwolves.Size = new System.Drawing.Size(233, 37);
            btn_spawnwolves.TabIndex = 74;
            btn_spawnwolves.Text = "wolf arrows";
            btn_spawnwolves.UseVisualStyleBackColor = true;
            // 
            // btn_salvagearrows
            // 
            btn_salvagearrows.Location = new System.Drawing.Point(19, 380);
            btn_salvagearrows.Margin = new Padding(4, 3, 4, 3);
            btn_salvagearrows.Name = "btn_salvagearrows";
            btn_salvagearrows.Size = new System.Drawing.Size(233, 37);
            btn_salvagearrows.TabIndex = 73;
            btn_salvagearrows.Text = "salvage arrows";
            btn_salvagearrows.UseVisualStyleBackColor = true;
            // 
            // btn_runspeedplusplus
            // 
            btn_runspeedplusplus.Location = new System.Drawing.Point(271, 281);
            btn_runspeedplusplus.Margin = new Padding(4, 3, 4, 3);
            btn_runspeedplusplus.Name = "btn_runspeedplusplus";
            btn_runspeedplusplus.Size = new System.Drawing.Size(233, 37);
            btn_runspeedplusplus.TabIndex = 71;
            btn_runspeedplusplus.Text = "Runspeed ++";
            btn_runspeedplusplus.UseVisualStyleBackColor = true;
            // 
            // btn_runspeedplus
            // 
            btn_runspeedplus.Location = new System.Drawing.Point(271, 240);
            btn_runspeedplus.Margin = new Padding(4, 3, 4, 3);
            btn_runspeedplus.Name = "btn_runspeedplus";
            btn_runspeedplus.Size = new System.Drawing.Size(233, 37);
            btn_runspeedplus.TabIndex = 70;
            btn_runspeedplus.Text = "Runspeed +";
            btn_runspeedplus.UseVisualStyleBackColor = true;
            // 
            // btn_runspeednormal
            // 
            btn_runspeednormal.Location = new System.Drawing.Point(271, 199);
            btn_runspeednormal.Margin = new Padding(4, 3, 4, 3);
            btn_runspeednormal.Name = "btn_runspeednormal";
            btn_runspeednormal.Size = new System.Drawing.Size(233, 37);
            btn_runspeednormal.TabIndex = 69;
            btn_runspeednormal.Text = "Normal Runspeed";
            btn_runspeednormal.UseVisualStyleBackColor = true;
            // 
            // btn_jumpheight_2
            // 
            btn_jumpheight_2.Location = new System.Drawing.Point(271, 103);
            btn_jumpheight_2.Margin = new Padding(4, 3, 4, 3);
            btn_jumpheight_2.Name = "btn_jumpheight_2";
            btn_jumpheight_2.Size = new System.Drawing.Size(233, 37);
            btn_jumpheight_2.TabIndex = 68;
            btn_jumpheight_2.Text = "jump 2";
            btn_jumpheight_2.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label12.Location = new System.Drawing.Point(28, 473);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new System.Drawing.Size(52, 17);
            label12.TabIndex = 37;
            label12.Text = "Status:";
            // 
            // btn_jumpheight_3
            // 
            btn_jumpheight_3.Location = new System.Drawing.Point(271, 63);
            btn_jumpheight_3.Margin = new Padding(4, 3, 4, 3);
            btn_jumpheight_3.Name = "btn_jumpheight_3";
            btn_jumpheight_3.Size = new System.Drawing.Size(233, 37);
            btn_jumpheight_3.TabIndex = 67;
            btn_jumpheight_3.Text = "jump 3";
            btn_jumpheight_3.UseVisualStyleBackColor = true;
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            statusLabel.Location = new System.Drawing.Point(103, 473);
            statusLabel.Margin = new Padding(4, 0, 4, 0);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new System.Drawing.Size(99, 17);
            statusLabel.TabIndex = 31;
            statusLabel.Text = "KAPOW POW!";
            statusLabel.Click += statusLabel_Click;
            // 
            // btn_jumpheight_1
            // 
            btn_jumpheight_1.Location = new System.Drawing.Point(271, 144);
            btn_jumpheight_1.Margin = new Padding(4, 3, 4, 3);
            btn_jumpheight_1.Name = "btn_jumpheight_1";
            btn_jumpheight_1.Size = new System.Drawing.Size(233, 37);
            btn_jumpheight_1.TabIndex = 66;
            btn_jumpheight_1.Text = "jump 1";
            btn_jumpheight_1.UseVisualStyleBackColor = true;
            // 
            // btn_jumpheight_0
            // 
            btn_jumpheight_0.Location = new System.Drawing.Point(271, 22);
            btn_jumpheight_0.Margin = new Padding(4, 3, 4, 3);
            btn_jumpheight_0.Name = "btn_jumpheight_0";
            btn_jumpheight_0.Size = new System.Drawing.Size(233, 37);
            btn_jumpheight_0.TabIndex = 65;
            btn_jumpheight_0.Text = "jump 0";
            btn_jumpheight_0.UseVisualStyleBackColor = true;
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.Location = new System.Drawing.Point(301, 421);
            linkLabel2.Margin = new Padding(4, 0, 4, 0);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new System.Drawing.Size(163, 12);
            linkLabel2.TabIndex = 49;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Homepage: sicklebrick.com";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new System.Drawing.Point(281, 403);
            linkLabel1.Margin = new Padding(4, 0, 4, 0);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new System.Drawing.Size(207, 12);
            linkLabel1.TabIndex = 48;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "TombraiderForums Release Thread";
            // 
            // btn_salvagepoints
            // 
            btn_salvagepoints.Location = new System.Drawing.Point(19, 247);
            btn_salvagepoints.Margin = new Padding(4, 3, 4, 3);
            btn_salvagepoints.Name = "btn_salvagepoints";
            btn_salvagepoints.Size = new System.Drawing.Size(233, 37);
            btn_salvagepoints.TabIndex = 42;
            btn_salvagepoints.Text = "salvagepoints";
            btn_salvagepoints.UseVisualStyleBackColor = true;
            // 
            // btn_ammo
            // 
            btn_ammo.Location = new System.Drawing.Point(19, 89);
            btn_ammo.Margin = new Padding(4, 3, 4, 3);
            btn_ammo.Name = "btn_ammo";
            btn_ammo.Size = new System.Drawing.Size(233, 37);
            btn_ammo.TabIndex = 41;
            btn_ammo.Text = "ammo";
            btn_ammo.UseVisualStyleBackColor = true;
            // 
            // btn_health
            // 
            btn_health.Location = new System.Drawing.Point(19, 44);
            btn_health.Margin = new Padding(4, 3, 4, 3);
            btn_health.Name = "btn_health";
            btn_health.Size = new System.Drawing.Size(233, 37);
            btn_health.TabIndex = 40;
            btn_health.Text = "health";
            btn_health.UseVisualStyleBackColor = true;
            // 
            // btn_damagesquared
            // 
            btn_damagesquared.Location = new System.Drawing.Point(19, 162);
            btn_damagesquared.Margin = new Padding(4, 3, 4, 3);
            btn_damagesquared.Name = "btn_damagesquared";
            btn_damagesquared.Size = new System.Drawing.Size(233, 37);
            btn_damagesquared.TabIndex = 39;
            btn_damagesquared.Text = "damagesquared";
            btn_damagesquared.UseVisualStyleBackColor = true;
            // 
            // btn_upgrades
            // 
            btn_upgrades.Location = new System.Drawing.Point(19, 284);
            btn_upgrades.Margin = new Padding(4, 3, 4, 3);
            btn_upgrades.Name = "btn_upgrades";
            btn_upgrades.Size = new System.Drawing.Size(233, 37);
            btn_upgrades.TabIndex = 32;
            btn_upgrades.Text = "upgrades";
            btn_upgrades.UseVisualStyleBackColor = true;
            // 
            // btn_reload
            // 
            btn_reload.Location = new System.Drawing.Point(19, 126);
            btn_reload.Margin = new Padding(4, 3, 4, 3);
            btn_reload.Name = "btn_reload";
            btn_reload.Size = new System.Drawing.Size(233, 37);
            btn_reload.TabIndex = 31;
            btn_reload.Text = "reload";
            btn_reload.UseVisualStyleBackColor = true;
            // 
            // btn_skillpoints
            // 
            btn_skillpoints.Location = new System.Drawing.Point(19, 210);
            btn_skillpoints.Margin = new Padding(4, 3, 4, 3);
            btn_skillpoints.Name = "btn_skillpoints";
            btn_skillpoints.Size = new System.Drawing.Size(233, 37);
            btn_skillpoints.TabIndex = 30;
            btn_skillpoints.Text = "skillpoints";
            btn_skillpoints.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label4.Location = new System.Drawing.Point(23, 15);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(46, 15);
            label4.TabIndex = 29;
            label4.Text = "Trainer";
            // 
            // panel_3
            // 
            panel_3.BorderStyle = BorderStyle.FixedSingle;
            panel_3.Controls.Add(btn_contrast_low);
            panel_3.Controls.Add(btn_contrast_norm);
            panel_3.Controls.Add(btn_contrast_hi);
            panel_3.Controls.Add(btn_rgb_boost);
            panel_3.Controls.Add(btn_bright_norm);
            panel_3.Controls.Add(btn_bright_4);
            panel_3.Controls.Add(btn_bright_3);
            panel_3.Controls.Add(btn_bright_2);
            panel_3.Controls.Add(btn_bright_1);
            panel_3.Controls.Add(btn_bright_0);
            panel_3.Controls.Add(btn_no_weaps);
            panel_3.Controls.Add(btn_clean_lara);
            panel_3.Controls.Add(btn_smalltits);
            panel_3.Controls.Add(btn_biggertits);
            panel_3.Controls.Add(btn_bigtits);
            panel_3.Controls.Add(btn_jiggletitsmega);
            panel_3.Controls.Add(btn_jiggletitson);
            panel_3.Controls.Add(btn_jiggletitsoff);
            panel_3.Controls.Add(btn_normaltits);
            panel_3.Controls.Add(label5);
            panel_3.Location = new System.Drawing.Point(1643, 22);
            panel_3.Margin = new Padding(4, 3, 4, 3);
            panel_3.Name = "panel_3";
            panel_3.Size = new System.Drawing.Size(522, 506);
            panel_3.TabIndex = 27;
            panel_3.Tag = "3";
            panel_3.Paint += panel_4_Paint;
            // 
            // btn_contrast_low
            // 
            btn_contrast_low.Location = new System.Drawing.Point(271, 414);
            btn_contrast_low.Margin = new Padding(4, 3, 4, 3);
            btn_contrast_low.Name = "btn_contrast_low";
            btn_contrast_low.Size = new System.Drawing.Size(233, 37);
            btn_contrast_low.TabIndex = 67;
            btn_contrast_low.Text = "contrast low";
            btn_contrast_low.UseVisualStyleBackColor = true;
            // 
            // btn_contrast_norm
            // 
            btn_contrast_norm.Location = new System.Drawing.Point(271, 373);
            btn_contrast_norm.Margin = new Padding(4, 3, 4, 3);
            btn_contrast_norm.Name = "btn_contrast_norm";
            btn_contrast_norm.Size = new System.Drawing.Size(233, 37);
            btn_contrast_norm.TabIndex = 66;
            btn_contrast_norm.Text = "contrast norm";
            btn_contrast_norm.UseVisualStyleBackColor = true;
            // 
            // btn_contrast_hi
            // 
            btn_contrast_hi.Location = new System.Drawing.Point(271, 332);
            btn_contrast_hi.Margin = new Padding(4, 3, 4, 3);
            btn_contrast_hi.Name = "btn_contrast_hi";
            btn_contrast_hi.Size = new System.Drawing.Size(233, 37);
            btn_contrast_hi.TabIndex = 65;
            btn_contrast_hi.Text = "contrast hi";
            btn_contrast_hi.UseVisualStyleBackColor = true;
            // 
            // btn_rgb_boost
            // 
            btn_rgb_boost.Location = new System.Drawing.Point(271, 273);
            btn_rgb_boost.Margin = new Padding(4, 3, 4, 3);
            btn_rgb_boost.Name = "btn_rgb_boost";
            btn_rgb_boost.Size = new System.Drawing.Size(233, 37);
            btn_rgb_boost.TabIndex = 64;
            btn_rgb_boost.Text = "RGB Bright Boost";
            btn_rgb_boost.UseVisualStyleBackColor = true;
            // 
            // btn_bright_norm
            // 
            btn_bright_norm.Location = new System.Drawing.Point(271, 41);
            btn_bright_norm.Margin = new Padding(4, 3, 4, 3);
            btn_bright_norm.Name = "btn_bright_norm";
            btn_bright_norm.Size = new System.Drawing.Size(233, 37);
            btn_bright_norm.TabIndex = 63;
            btn_bright_norm.Text = "Normal Light";
            btn_bright_norm.UseVisualStyleBackColor = true;
            // 
            // btn_bright_4
            // 
            btn_bright_4.Location = new System.Drawing.Point(271, 225);
            btn_bright_4.Margin = new Padding(4, 3, 4, 3);
            btn_bright_4.Name = "btn_bright_4";
            btn_bright_4.Size = new System.Drawing.Size(233, 37);
            btn_bright_4.TabIndex = 62;
            btn_bright_4.Text = "Mega Glow";
            btn_bright_4.UseVisualStyleBackColor = true;
            // 
            // btn_bright_3
            // 
            btn_bright_3.Location = new System.Drawing.Point(271, 188);
            btn_bright_3.Margin = new Padding(4, 3, 4, 3);
            btn_bright_3.Name = "btn_bright_3";
            btn_bright_3.Size = new System.Drawing.Size(233, 37);
            btn_bright_3.TabIndex = 61;
            btn_bright_3.Text = "Glowier";
            btn_bright_3.UseVisualStyleBackColor = true;
            // 
            // btn_bright_2
            // 
            btn_bright_2.Location = new System.Drawing.Point(271, 151);
            btn_bright_2.Margin = new Padding(4, 3, 4, 3);
            btn_bright_2.Name = "btn_bright_2";
            btn_bright_2.Size = new System.Drawing.Size(233, 37);
            btn_bright_2.TabIndex = 60;
            btn_bright_2.Text = "Glow";
            btn_bright_2.UseVisualStyleBackColor = true;
            // 
            // btn_bright_1
            // 
            btn_bright_1.Location = new System.Drawing.Point(271, 114);
            btn_bright_1.Margin = new Padding(4, 3, 4, 3);
            btn_bright_1.Name = "btn_bright_1";
            btn_bright_1.Size = new System.Drawing.Size(233, 37);
            btn_bright_1.TabIndex = 59;
            btn_bright_1.Text = "Slight glow";
            btn_bright_1.UseVisualStyleBackColor = true;
            // 
            // btn_bright_0
            // 
            btn_bright_0.Location = new System.Drawing.Point(271, 78);
            btn_bright_0.Margin = new Padding(4, 3, 4, 3);
            btn_bright_0.Name = "btn_bright_0";
            btn_bright_0.Size = new System.Drawing.Size(233, 37);
            btn_bright_0.TabIndex = 58;
            btn_bright_0.Text = "Silhouette";
            btn_bright_0.UseVisualStyleBackColor = true;
            // 
            // btn_no_weaps
            // 
            btn_no_weaps.Location = new System.Drawing.Point(19, 81);
            btn_no_weaps.Margin = new Padding(4, 3, 4, 3);
            btn_no_weaps.Name = "btn_no_weaps";
            btn_no_weaps.Size = new System.Drawing.Size(233, 37);
            btn_no_weaps.TabIndex = 57;
            btn_no_weaps.Text = "noweaps";
            btn_no_weaps.UseVisualStyleBackColor = true;
            // 
            // btn_clean_lara
            // 
            btn_clean_lara.Location = new System.Drawing.Point(19, 41);
            btn_clean_lara.Margin = new Padding(4, 3, 4, 3);
            btn_clean_lara.Name = "btn_clean_lara";
            btn_clean_lara.Size = new System.Drawing.Size(233, 37);
            btn_clean_lara.TabIndex = 56;
            btn_clean_lara.Text = "cleanlara";
            btn_clean_lara.UseVisualStyleBackColor = true;
            // 
            // btn_smalltits
            // 
            btn_smalltits.Location = new System.Drawing.Point(19, 266);
            btn_smalltits.Margin = new Padding(4, 3, 4, 3);
            btn_smalltits.Name = "btn_smalltits";
            btn_smalltits.Size = new System.Drawing.Size(233, 37);
            btn_smalltits.TabIndex = 38;
            btn_smalltits.Text = "smalltits";
            btn_smalltits.UseVisualStyleBackColor = true;
            // 
            // btn_biggertits
            // 
            btn_biggertits.Location = new System.Drawing.Point(19, 388);
            btn_biggertits.Margin = new Padding(4, 3, 4, 3);
            btn_biggertits.Name = "btn_biggertits";
            btn_biggertits.Size = new System.Drawing.Size(233, 37);
            btn_biggertits.TabIndex = 37;
            btn_biggertits.Text = "biggertits";
            btn_biggertits.UseVisualStyleBackColor = true;
            // 
            // btn_bigtits
            // 
            btn_bigtits.Location = new System.Drawing.Point(19, 347);
            btn_bigtits.Margin = new Padding(4, 3, 4, 3);
            btn_bigtits.Name = "btn_bigtits";
            btn_bigtits.Size = new System.Drawing.Size(233, 37);
            btn_bigtits.TabIndex = 36;
            btn_bigtits.Text = "bigtits";
            btn_bigtits.UseVisualStyleBackColor = true;
            // 
            // btn_jiggletitsmega
            // 
            btn_jiggletitsmega.Location = new System.Drawing.Point(19, 214);
            btn_jiggletitsmega.Margin = new Padding(4, 3, 4, 3);
            btn_jiggletitsmega.Name = "btn_jiggletitsmega";
            btn_jiggletitsmega.Size = new System.Drawing.Size(233, 37);
            btn_jiggletitsmega.TabIndex = 35;
            btn_jiggletitsmega.Text = "jiggletitsmega";
            btn_jiggletitsmega.UseVisualStyleBackColor = true;
            // 
            // btn_jiggletitson
            // 
            btn_jiggletitson.Location = new System.Drawing.Point(19, 174);
            btn_jiggletitson.Margin = new Padding(4, 3, 4, 3);
            btn_jiggletitson.Name = "btn_jiggletitson";
            btn_jiggletitson.Size = new System.Drawing.Size(233, 37);
            btn_jiggletitson.TabIndex = 34;
            btn_jiggletitson.Text = "jiggletitson";
            btn_jiggletitson.UseVisualStyleBackColor = true;
            // 
            // btn_jiggletitsoff
            // 
            btn_jiggletitsoff.Location = new System.Drawing.Point(19, 133);
            btn_jiggletitsoff.Margin = new Padding(4, 3, 4, 3);
            btn_jiggletitsoff.Name = "btn_jiggletitsoff";
            btn_jiggletitsoff.Size = new System.Drawing.Size(233, 37);
            btn_jiggletitsoff.TabIndex = 33;
            btn_jiggletitsoff.Text = "jiggletitsoff";
            btn_jiggletitsoff.UseVisualStyleBackColor = true;
            // 
            // btn_normaltits
            // 
            btn_normaltits.Location = new System.Drawing.Point(19, 306);
            btn_normaltits.Margin = new Padding(4, 3, 4, 3);
            btn_normaltits.Name = "btn_normaltits";
            btn_normaltits.Size = new System.Drawing.Size(233, 37);
            btn_normaltits.TabIndex = 31;
            btn_normaltits.Text = "normaltits";
            btn_normaltits.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label5.Location = new System.Drawing.Point(12, 15);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(86, 15);
            label5.TabIndex = 30;
            label5.Text = "Cosmetic / Tits";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage10);
            tabControl1.Controls.Add(tabPage11);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.HotTrack = true;
            tabControl1.Location = new System.Drawing.Point(0, 0);
            tabControl1.Margin = new Padding(4, 3, 4, 3);
            tabControl1.Multiline = true;
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new System.Drawing.Size(527, 22);
            tabControl1.TabIndex = 28;
            tabControl1.Selected += tabControl1_Selected;
            // 
            // tabPage1
            // 
            tabPage1.Location = new System.Drawing.Point(4, 22);
            tabPage1.Margin = new Padding(4, 3, 4, 3);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(4, 3, 4, 3);
            tabPage1.Size = new System.Drawing.Size(519, 0);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Standard";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Location = new System.Drawing.Point(4, 22);
            tabPage2.Margin = new Padding(4, 3, 4, 3);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(4, 3, 4, 3);
            tabPage2.Size = new System.Drawing.Size(519, 0);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Position";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage10
            // 
            tabPage10.Location = new System.Drawing.Point(4, 22);
            tabPage10.Margin = new Padding(4, 3, 4, 3);
            tabPage10.Name = "tabPage10";
            tabPage10.Size = new System.Drawing.Size(519, 0);
            tabPage10.TabIndex = 2;
            tabPage10.Text = "Camera";
            tabPage10.UseVisualStyleBackColor = true;
            // 
            // tabPage11
            // 
            tabPage11.Location = new System.Drawing.Point(4, 22);
            tabPage11.Margin = new Padding(4, 3, 4, 3);
            tabPage11.Name = "tabPage11";
            tabPage11.Size = new System.Drawing.Size(519, 0);
            tabPage11.TabIndex = 3;
            tabPage11.Text = "Cosmetic";
            tabPage11.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            tabPage4.Location = new System.Drawing.Point(4, 22);
            tabPage4.Margin = new Padding(4, 3, 4, 3);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new System.Drawing.Size(519, 0);
            tabPage4.TabIndex = 5;
            tabPage4.Text = "About";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            tabPage3.Location = new System.Drawing.Point(4, 22);
            tabPage3.Margin = new Padding(4, 3, 4, 3);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new System.Drawing.Size(519, 0);
            tabPage3.TabIndex = 4;
            tabPage3.Text = "All";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // savebox
            // 
            savebox.Location = new System.Drawing.Point(2852, 184);
            savebox.Margin = new Padding(4, 3, 4, 3);
            savebox.Name = "savebox";
            savebox.Size = new System.Drawing.Size(226, 28);
            savebox.TabIndex = 31;
            savebox.Text = "Chunkey chicken widdle";
            savebox.Visible = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label7.Location = new System.Drawing.Point(2862, 113);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(100, 17);
            label7.TabIndex = 33;
            label7.Text = "Last keypress:";
            // 
            // timer2
            // 
            timer2.Enabled = true;
            timer2.Interval = 10;
            timer2.Tick += timer2_Tick;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label11.Location = new System.Drawing.Point(1010, 27);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(0, 18);
            label11.TabIndex = 36;
            // 
            // blitTimer
            // 
            blitTimer.Interval = 1;
            blitTimer.Tick += timer3_Tick;
            // 
            // fontLabel
            // 
            fontLabel.AutoSize = true;
            fontLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            fontLabel.Location = new System.Drawing.Point(2861, 243);
            fontLabel.Margin = new Padding(4, 0, 4, 0);
            fontLabel.Name = "fontLabel";
            fontLabel.Size = new System.Drawing.Size(121, 46);
            fontLabel.TabIndex = 44;
            fontLabel.Text = "FOO!";
            // 
            // blitLengthTimer
            // 
            blitLengthTimer.Interval = 2500;
            blitLengthTimer.Tick += blitLengthTimer_Tick;
            // 
            // settingsBox
            // 
            settingsBox.Location = new System.Drawing.Point(2856, 213);
            settingsBox.Margin = new Padding(4, 3, 4, 3);
            settingsBox.Name = "settingsBox";
            settingsBox.Size = new System.Drawing.Size(116, 23);
            settingsBox.TabIndex = 47;
            settingsBox.Text = "";
            // 
            // cbAutoUpdate
            // 
            cbAutoUpdate.AutoSize = true;
            cbAutoUpdate.Enabled = false;
            cbAutoUpdate.Location = new System.Drawing.Point(2865, 85);
            cbAutoUpdate.Margin = new Padding(4, 3, 4, 3);
            cbAutoUpdate.Name = "cbAutoUpdate";
            cbAutoUpdate.Size = new System.Drawing.Size(155, 16);
            cbAutoUpdate.TabIndex = 50;
            cbAutoUpdate.Text = "Disable Editor updates.";
            cbAutoUpdate.UseVisualStyleBackColor = true;
            // 
            // cbOverlay
            // 
            cbOverlay.AutoSize = true;
            cbOverlay.Enabled = false;
            cbOverlay.Location = new System.Drawing.Point(2865, 66);
            cbOverlay.Margin = new Padding(4, 3, 4, 3);
            cbOverlay.Name = "cbOverlay";
            cbOverlay.Size = new System.Drawing.Size(111, 16);
            cbOverlay.TabIndex = 49;
            cbOverlay.Text = "Disable overlay";
            cbOverlay.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.Location = new System.Drawing.Point(2324, 502);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(214, 17);
            label3.TabIndex = 51;
            label3.Text = "Hiya. Dont tell anyone I\'m here ;)";
            // 
            // button2
            // 
            button2.Location = new System.Drawing.Point(2884, 332);
            button2.Margin = new Padding(4, 3, 4, 3);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(88, 21);
            button2.TabIndex = 52;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // panel_4
            // 
            panel_4.BorderStyle = BorderStyle.FixedSingle;
            panel_4.Controls.Add(richTextBox3);
            panel_4.Controls.Add(cbKeybinds);
            panel_4.Controls.Add(richTextBox2);
            panel_4.Controls.Add(label10);
            panel_4.Controls.Add(label9);
            panel_4.Controls.Add(Debugging);
            panel_4.Controls.Add(label8);
            panel_4.Controls.Add(richTextBox1);
            panel_4.Location = new System.Drawing.Point(2184, 22);
            panel_4.Margin = new Padding(4, 3, 4, 3);
            panel_4.Name = "panel_4";
            panel_4.Size = new System.Drawing.Size(516, 506);
            panel_4.TabIndex = 53;
            panel_4.Tag = "3";
            // 
            // richTextBox3
            // 
            richTextBox3.BackColor = System.Drawing.SystemColors.Control;
            richTextBox3.BorderStyle = BorderStyle.None;
            richTextBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            richTextBox3.Location = new System.Drawing.Point(15, 193);
            richTextBox3.Margin = new Padding(4, 3, 4, 3);
            richTextBox3.Name = "richTextBox3";
            richTextBox3.Size = new System.Drawing.Size(231, 37);
            richTextBox3.TabIndex = 71;
            richTextBox3.Text = "For v 1.1.748.0 (steam)\n Size: 19,474,944 bytes";
            // 
            // cbKeybinds
            // 
            cbKeybinds.AutoSize = true;
            cbKeybinds.Location = new System.Drawing.Point(29, 241);
            cbKeybinds.Margin = new Padding(4, 3, 4, 3);
            cbKeybinds.Name = "cbKeybinds";
            cbKeybinds.Size = new System.Drawing.Size(123, 16);
            cbKeybinds.TabIndex = 70;
            cbKeybinds.Text = "Disable Keybinds";
            cbKeybinds.UseVisualStyleBackColor = true;
            // 
            // richTextBox2
            // 
            richTextBox2.BackColor = System.Drawing.SystemColors.Control;
            richTextBox2.BorderStyle = BorderStyle.None;
            richTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            richTextBox2.Location = new System.Drawing.Point(15, 122);
            richTextBox2.Margin = new Padding(4, 3, 4, 3);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new System.Drawing.Size(231, 46);
            richTextBox2.TabIndex = 69;
            richTextBox2.Text = "Questions? Comments? Ideas? Head on over to the release thread on tombraiderforum" +
    "s.";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label10.Location = new System.Drawing.Point(66, 77);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(97, 18);
            label10.TabIndex = 66;
            label10.Text = "by sicklebrick";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label9.Location = new System.Drawing.Point(20, 54);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(154, 20);
            label9.TabIndex = 68;
            label9.Text = "YAMATAIPatch   R5";
            // 
            // Debugging
            // 
            Debugging.AutoSize = true;
            Debugging.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Debugging.Location = new System.Drawing.Point(19, 30);
            Debugging.Margin = new Padding(4, 0, 4, 0);
            Debugging.Name = "Debugging";
            Debugging.Size = new System.Drawing.Size(38, 15);
            Debugging.TabIndex = 64;
            Debugging.Text = "About";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label8.Location = new System.Drawing.Point(26, 256);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(88, 17);
            label8.TabIndex = 67;
            label8.Text = "Debug spam";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new System.Drawing.Point(10, 277);
            richTextBox1.Margin = new Padding(4, 3, 4, 3);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new System.Drawing.Size(488, 116);
            richTextBox1.TabIndex = 65;
            richTextBox1.Text = "";
            // 
            // btn_outfits
            // 
            btn_outfits.Location = new System.Drawing.Point(2856, 358);
            btn_outfits.Margin = new Padding(4, 3, 4, 3);
            btn_outfits.Name = "btn_outfits";
            btn_outfits.Size = new System.Drawing.Size(233, 37);
            btn_outfits.TabIndex = 54;
            btn_outfits.Text = "outfits";
            btn_outfits.UseVisualStyleBackColor = true;
            // 
            // main
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1924, 531);
            Controls.Add(btn_outfits);
            Controls.Add(panel_4);
            Controls.Add(button2);
            Controls.Add(label3);
            Controls.Add(cbAutoUpdate);
            Controls.Add(cbOverlay);
            Controls.Add(settingsBox);
            Controls.Add(fontLabel);
            Controls.Add(label11);
            Controls.Add(label7);
            Controls.Add(savebox);
            Controls.Add(panel_3);
            Controls.Add(label1);
            Controls.Add(panel_0);
            Controls.Add(panel_2);
            Controls.Add(panel_1);
            Controls.Add(tabControl1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(4, 3, 4, 3);
            Name = "main";
            Text = "YamataiPatch R5";
            Load += Form1_Load;
            panel_1.ResumeLayout(false);
            panel_1.PerformLayout();
            ((ISupportInitialize)(trackbarPlayer)).EndInit();
            panel_2.ResumeLayout(false);
            panel_2.PerformLayout();
            ((ISupportInitialize)(trackbarcamera)).EndInit();
            panel_0.ResumeLayout(false);
            panel_0.PerformLayout();
            panel_3.ResumeLayout(false);
            panel_3.PerformLayout();
            tabControl1.ResumeLayout(false);
            panel_4.ResumeLayout(false);
            panel_4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

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
            loadSettings();
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
            CheatButton.loadHotkeys();
        }

        // 이 함수는 주어진 Button 객체를 제거하고 대신 CheatButton 객체를 생성하여 추가하는 역할을 합니다.
        // 이외에도 메모리를 어떻게 변조할지 리스트 값으로 받음
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

        /*
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {
        }
        */

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
            const int show_range = 50;
            for (int index = 0; index < panelList.Count; ++index)
            {
                // ALL 이 아닌 경우
                if (panelNum != panelList.Count)
                {
                    panelTargs[index] = index == panelNum ? 0.0f : panelLeft;
                    if (index != panelNum)
                        panelList[index].Parent.Controls.SetChildIndex(panelList[index], 0);
                    Width = panelWidth + show_range;
                }
                // ALL 인 경우
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

        public void saveSettings()
        {
            settingsBox.Text = "";
            for (int index = 0; index < saveableCheckBoxes.Length; ++index)
            {
                CheckBox saveableCheckBox = saveableCheckBoxes[index];
                settingsBox.AppendText(saveableCheckBox.Text + "," + saveableCheckBox.Checked.ToString() + "|");
            }

            settingsBox.SaveFile("settings.dat");
        }

        public void loadSettings()
        {
            settingsBox.Text = "";
            if (File.Exists("settings.dat"))
            {
                settingsBox.LoadFile("settings.dat");
                string[] strArray1 = settingsBox.Text.Split('|');
                if (settingsBox.Text.Length > 1)
                {
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
                }

                GameHooks.hotkeysDisabled = cbKeybinds.Checked;
            }
            else
                addText("No settings found , they will be created");
        }

        private void button1_Click_3(object sender, EventArgs e) => saveSettings();

        private void button2_Click(object sender, EventArgs e) => loadSettings();

        private void cbKeybinds_CheckedChanged(object sender, EventArgs e) => saveSettings();

        private void cbOverlay_CheckedChanged(object sender, EventArgs e) => saveSettings();

        private void cbAutoUpdate_CheckedChanged(object sender, EventArgs e) => saveSettings();

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

        private void linkLabel2_Click(object sender, EventArgs e) => Process.Start("http://sicklebrick.com/?p=513");

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) =>
            Process.Start("http://www.tombraiderforums.com/showthread.php?p=6784668");

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