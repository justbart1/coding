using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp3.Properties;
using WindowsFormsApp3.SDK;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            Init();
        }
        public void Init()
        {
            var CSGO = Process.GetProcessesByName("csgo");
            if (CSGO.Length != 0)
            {
                Memory.g_pProcess = CSGO[0];
                Memory.g_pProcessHandle = Memory.OpenProcess(0x0008 | 0x0010 | 0x0020, false, Memory.g_pProcess.Id);
                foreach (ProcessModule Module in Memory.g_pProcess.Modules)
                {
                    if ((Module.ModuleName == "client_panorama.dll"))
                        Memory.g_pClient = Module.BaseAddress;

                    if ((Module.ModuleName == "engine.dll"))
                        Memory.g_pEngine = Module.BaseAddress;
                }
                Thread tStart = new Thread(start);
                tStart.Start();
            }
            else
            {
                MessageBox.Show("Start your csgo.exe retart!", "paint.exe", MessageBoxButtons.OK);
                Environment.Exit(1);
            }

        }

        public static void start()
        {
            while (true)
            {
                int Local = Memory.ReadMemory<int>((int)Memory.g_pClient + Offsets.dwLocalPlayer);
                int LocalTeam = Memory.ReadMemory<int>(Local + Offsets.m_iTeamNum);
                bool LocalScope = Memory.ReadMemory<bool>(Local + Offsets.m_bIsScoped);
                int LocalFlash = Memory.ReadMemory<int>(Local + Offsets.m_flFlashMaxAlpha);
                int LocalFlags = Memory.ReadMemory<int>(Local + Offsets.m_fFlags);
                int GlowBase = Memory.ReadMemory<int>((int)Memory.g_pClient + Offsets.dwGlowObjectManager);
                GlowObject GlowObj = new GlowObject();

                {
                    if (Settings.Flash.enabled == true)
                    {
                        Memory.WriteMemory<int>(Local + Offsets.m_flFlashMaxAlpha, 0);
                    }
                    else
                    {
                        Memory.WriteMemory<int>(Local + Offsets.m_flFlashMaxAlpha, 255);
                    }
                }


                {
                    if (Settings.Bunnyhop.enabled == true)
                    {
                        var bunnyhopKey = Imports.GetAsyncKeyState(Settings.Bunnyhop.key);
                        //KEY NOT PRESSED / DOWN = 0; KEY PRESSED / DOWN = not 0
                        // == , !=
                        if ((bunnyhopKey & 0x8000) > 0)
                        {
                            if (LocalFlags == 257 || LocalFlags == 263 || LocalFlags == 1281 || LocalFlags == 1287)
                            {
                                Memory.WriteMemory<int>((int)Memory.g_pClient + Offsets.dwForceJump, 6);
                            }
                        }
                    }
                }


                {
                    for (int i = 0; i <= 64; i++)
                    {
                        int EntityBase = Memory.ReadMemory<int>((int)Memory.g_pClient + Offsets.dwEntityList + i * 0x10);
                        int EntityTeam = Memory.ReadMemory<int>(EntityBase + Offsets.m_iTeamNum);
                        int EntityHealth = Memory.ReadMemory<int>(EntityBase + Offsets.m_iHealth);
                        bool EntitySpotted = Memory.ReadMemory<bool>(EntityBase + Offsets.m_bSpotted);
                        int GlowIndex = Memory.ReadMemory<int>(EntityBase + Offsets.m_iGlowIndex);

                        GlowObj = Memory.ReadMemory<GlowObject>(GlowBase + GlowIndex * 0x38);

                        if (Settings.Glowteam.enabled == true)
                        {
                            if (EntityTeam == LocalTeam)
                            {
                                //TEAMMATE
                                GlowObj.r = 0f;
                                GlowObj.g = 0f;
                                GlowObj.b = 1;
                            }
                        }

                        if (Settings.Glowenemy.enabled == true)
                        {
                            if (EntityTeam != LocalTeam)
                            {
                                //ENEMY
                                //HAS OVER 50HP RED
                                //LESS THAN 50HP ORANGE - R = 1; G = 0.5; B = 0;
                                // if ::: health == 0  ; health != 0 ;  health > 50 || health < 50
                                if (EntityHealth > 50)
                                {
                                    //OVER 50HP
                                    GlowObj.r = 1f;
                                    GlowObj.g = 0f;
                                }
                                else
                                {
                                    //UNDER 50HP
                                    GlowObj.r = 1f;
                                    GlowObj.g = 0.4f;
                                }
                                GlowObj.b = 0f;
                            }
                        }

                        //IF TEAMMATE: RED = 0; GREEN 0; BLUE = 1;
                        //IF ENEMY: RED = 1; GREEN 0; BLUE = 0;
                        //
                        //ENEMY GLOW BY HEALTH
                        GlowObj.a = 1f;
                        GlowObj.m_bRenderWhenOccluded = true;
                        GlowObj.m_bRenderWhenUnoccluded = false;
                        GlowObj.m_bFullBloom = false;
                        if (Settings.Glow.enabled == true)
                            Memory.WriteMemory<GlowObject>(GlowBase + GlowIndex * 0x38, GlowObj);

                        if (Settings.Radar.enabled == true)
                        {
                            if (EntityTeam != LocalTeam)
                            {
                                if (EntitySpotted == false)
                                {
                                    Memory.WriteMemory<bool>(EntityBase + Offsets.m_bSpotted, true);
                                }
                            }
                        }
                    }
                }
                Thread.Sleep(1);
            }
        }

        #region controlsAdd
        UserControl uc = new AIMBOT();
        UserControl uc2 = new VISUALS();
        UserControl uc3 = new skins();
        UserControl uc4 = new not_working();
        UserControl uc5 = new Bhop();
        private void button1_Click(object sender, EventArgs e)
        {
            panel4.Controls.Remove(uc2);
            panel4.Controls.Remove(uc3);
            panel4.Controls.Remove(uc4);
            panel4.Controls.Remove(uc5);
            panel4.Controls.Add(uc);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel4.Controls.Remove(uc);
            panel4.Controls.Remove(uc3);
            panel4.Controls.Remove(uc4);
            panel4.Controls.Remove(uc5);
            panel4.Controls.Add(uc2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel4.Controls.Remove(uc);
            panel4.Controls.Remove(uc2);
            panel4.Controls.Remove(uc4);
            panel4.Controls.Remove(uc5);
            panel4.Controls.Add(uc3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel4.Controls.Remove(uc);
            panel4.Controls.Remove(uc2);
            panel4.Controls.Remove(uc3);
            panel4.Controls.Remove(uc5);
            panel4.Controls.Add(uc4);
        }

        private void Bhop_Click(object sender, EventArgs e)
        {
            panel4.Controls.Remove(uc);
            panel4.Controls.Remove(uc2);
            panel4.Controls.Remove(uc3);
            panel4.Controls.Remove(uc4);
            panel4.Controls.Add(uc5);
        }
        #endregion controlsAdd
    }
}
