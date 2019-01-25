#define GAME_TIME

using LiveSplit.Model;
using LiveSplit.Options;
using LiveSplit.TimeFormatters;
using LiveSplit.UI.Components;
using LiveSplit.Web;
using LiveSplit.Web.Share;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Timers;
using System.Windows.Forms;
using System.IO;

/*
 * TODO LIST
 * Split seeds.
 * Reset count.
 * Reset time.
 */
namespace LiveSplit.UI.Components
{
    class Component : IComponent
    {
        // Stuff I don't really need (no graphical part)
        public float PaddingBottom { get { return 0; } }
        public float PaddingTop { get { return 0; } }
        public float PaddingLeft { get { return 0; } }
        public float PaddingRight { get { return 0; } }
        public float VerticalHeight { get { return 0; } }
        public float MinimumWidth { get { return 0; } }
        public void DrawHorizontal(Graphics g, LiveSplitState state, float height, Region clipRegion) { }
        public void DrawVertical(Graphics g, LiveSplitState state, float width, Region clipRegion) { }
        public float HorizontalWidth { get { return 0; } }
        public float MinimumHeight { get { return 0; } }
        public IDictionary<string, Action> ContextMenuControls { get; protected set; }

        // Settings (taken from LiveSplit.Title)
        private ComponentSettings settings { get; set; }
        public System.Xml.XmlNode GetSettings(System.Xml.XmlDocument document) { return settings.GetSettings(document); }
        public Control GetSettingsControl(LayoutMode mode) { return settings; }
        public void SetSettings(System.Xml.XmlNode newsettings) { settings.SetSettings(newsettings); }

        // Name
        public string ComponentName
        {
            get { return "TBOI:R Auto Splitter"; }
        }

        // My private vars
        private long byteNum { get; set; }
        private string fullpath { get; set; }
        private TimerModel model { get; set; }

        // Constructor
        public Component()
        {
            //Settings = new ComponentSettings();

            //ContextMenuControls = new Dictionary<String, Action>();

            fullpath = Environment.GetEnvironmentVariable("USERPROFILE") + "/Documents/My Games/Binding of Isaac Rebirth/log.txt";

            byteNum = (new FileInfo(fullpath)).Length;

            settings = new ComponentSettings();

            //System.Windows.Forms.MessageBox.Show(byteNum.ToString());
        }
        
        // Destructor
        public void Dispose()
        {
        }

        // All the stuff
        public void Update(IInvalidator invalidator, LiveSplitState state, float width, float height, LayoutMode mode)
        {
            if (model == null)
            {
                model = new TimerModel() { CurrentState = state };
            }

            long newLength = (new FileInfo(fullpath)).Length;

            if (newLength < byteNum)
            {
                // Game restart probably, wiping out the log
                byteNum = newLength;
            }
            else if (newLength > byteNum)
            {
                using (FileStream fs = File.Open(fullpath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                {
                    // Go to last previous read message
                    fs.Seek(byteNum, SeekOrigin.Begin);
                    using (StreamReader sr = new StreamReader(fs))
                    {
                        string l;
                        // Read all the lines
                        while ((l = sr.ReadLine()) != null)
                        {
                            if (l.StartsWith("RNG Start Seed:"))
                            {
                                // Character begin or reset; only reset if first character
                                if (state.CurrentSplitIndex == 0 && settings.autoReset)
                                {
                                    model.Reset();
                                }
                                if (settings.autoStart)
                                {
                                    model.Start();
                                }
                            }
                            else if (l.StartsWith("playing cutscene ") && !l.StartsWith("playing cutscene 1 (Intro)."))
                            {
                                // Playing end game cutscene
                                if (settings.autoSplit)
                                {
                                    model.Split();
                                }
                            }
                        }
                    }
                }
                byteNum = newLength;
            }

            return;
        }
    }
}
