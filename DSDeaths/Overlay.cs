using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;
using Utilities;

namespace DSDeaths
{
    public partial class Overlay : Form
    {
        //Hotkey stuff
        globalKeyboardHook gkh = new globalKeyboardHook();

        private class Segment
        {
            public int BossDeaths = 0;
            public string BossName = "Boss (???)";
            public int AreaDeaths = 0;
            public int FallDeaths = 0;
            public int SoulsLost = 0;
            public bool active = false;
            public Segment() { }
            public Segment(string bossName, int bossDeaths, int areaDeaths, int fallDeaths, int soulsLost)
            {
                this.BossName = bossName;
                this.BossDeaths = bossDeaths;
                this.AreaDeaths = areaDeaths;
                this.FallDeaths = fallDeaths;
                this.SoulsLost = soulsLost;
            }
        }
        class SegmentList<T> : List<Segment>
        {
            public int TotalDeaths = 0;
            public int TotalSouls = 0;
            public new void Add(Segment item)
            {
                TotalDeaths = 0;
                foreach (Segment segment in this)
                {
                    if (segment.active)
                        segment.active = false;

                    TotalDeaths += segment.BossDeaths;
                    TotalDeaths += segment.AreaDeaths;
                    TotalSouls += segment.SoulsLost;
                }

                item.active = true;
                base.Add(item);
            }
        }
        private SegmentList<Segment> Segments = new SegmentList<Segment>();

        private Segment CurrSegment;
        private string bossName;
        public string BossName
        {
            get { return bossName; }
            set
            {
                labBoss.Text = string.Format("{0}: {1}", value, bossDeaths);
                tbxBossName.Text = value;
                bossName = value;
                CurrSegment.BossName = value;
            }
        }
        private int bossDeaths;
        public int BossDeaths
        {
            get { return bossDeaths; }
            set
            {
                labBoss.Text = string.Format("{0}: {1}", bossName, value);
                tbxBossDeaths.Text = value.ToString();
                bossDeaths = value;
                CurrSegment.BossDeaths = value;
                labTotal.Text = string.Format("Deaths: {0}", GetTotalDeaths());
            }
        }
        private int areaDeaths;
        public int AreaDeaths
        {
            get { return areaDeaths; }
            set
            {
                labArea.Text = string.Format("Area: {0}", value);
                tbxAreaDeaths.Text = value.ToString();
                areaDeaths = value;
                CurrSegment.AreaDeaths = value;
                labTotal.Text = string.Format("Deaths: {0}", GetTotalDeaths());
            }
        }
        private int fallDeaths;
        public int FallDeaths
        {
            get { return fallDeaths; }
            set
            {
                if (value < 0)
                    value = 0;
                labFall.Text = string.Format(": {0}", value);
                tbxFallDeaths.Text = value.ToString();
                fallDeaths = value;
                CurrSegment.FallDeaths = value;
            }
        }
        private int soulsLost;
        public int SoulsLost
        {
            get { return soulsLost; }
            set
            {
                if (value < 0)
                    value = 0;
                labSouls.Text = string.Format("Lost: {0}", value);
                tbxSoulsLost.Text = value.ToString();
                Size textSize = TextRenderer.MeasureText(labSouls.Text, labSouls.Font);
                imgSouls.Location = new Point(labSouls.Width - textSize.Width - 50, labSouls.Location.Y);
                soulsLost = value;
                CurrSegment.SoulsLost = value;
            }
        }
        private IrcClient irc;

        private List<string> Mods = new List<string>();

        private bool expanded;
        private Size expandSize;
        private Size smallSize = new Size(566, 290 + 38); //38 is the surrounding frame dimensions
        public bool Expanded
        {
            get { return expanded; }
            set
            {
                //Store expanded size
                btnExpand.Text = value ? "^" : "v";
                if (value)
                    this.Size = expandSize;
                else
                    this.Size = smallSize;

                expanded = value;
            }
        }

        public Overlay()
        {
            InitializeComponent();

            //UI
            expandSize = this.Size;
            Expanded = false;

            //Load Data
            if (!LoadData())
            {
                CurrSegment = new Segment(BossName, BossDeaths, AreaDeaths, FallDeaths, SoulsLost);
                Segments.Add(CurrSegment);
                SetCurrentSegment(CurrSegment);
            }

            //Load Mods
            LoadMods();

            //Initialize Chat Component
            string oauthKey = System.IO.File.ReadAllText(@"oauthkey.txt");
            irc = new IrcClient("irc.twitch.tv", 6667,
                "pertdies", oauthKey);

            irc.joinRoom("perterter");
            bgwChat.RunWorkerAsync();

            //Hook Hotkeys
            gkh.HookedKeys.Add(Keys.F5);
            gkh.HookedKeys.Add(Keys.F6);
            gkh.HookedKeys.Add(Keys.F7);
            gkh.HookedKeys.Add(Keys.F8);
            gkh.KeyDown += new KeyEventHandler(gkh_KeyDown);
            gkh.KeyUp += new KeyEventHandler(gkh_KeyUp);
        }

        void gkh_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F5:
                    AddDeath(1, "a", true);
                    break;
                case Keys.F6:
                    AddDeath(1, "b", true);
                    break;
                case Keys.F7:
                    AddDeath(1, "f", true);
                    break;

                case Keys.F9:
                    RemoveDeath(1, "b", true);
                    break;
                case Keys.F10:
                    RemoveDeath(1, "b", true);
                    break;
                case Keys.F11:
                    RemoveDeath(1, "b", true);
                    break;
            }
            e.Handled = true;
        }
        void gkh_KeyUp(object sender, KeyEventArgs e)
        {
            e.Handled = true;
        }


        private void Save()
        {
            using (System.IO.StreamWriter file = new System.IO.StreamWriter("data.txt"))
            {
                foreach (Segment segment in Segments)
                {
                    String[] data =
                    {
                        segment.BossName,
                        segment.BossDeaths.ToString(),
                        segment.AreaDeaths.ToString(),
                        segment.FallDeaths.ToString(),
                        segment.SoulsLost.ToString()
                    };
                    file.WriteLine(string.Join(",", data));
                }
            }

            using (System.IO.StreamWriter file = new System.IO.StreamWriter("mods.txt"))
            {
                foreach (string mod in Mods)
                {
                    file.WriteLine(mod);
                }
            }

            using (System.IO.StreamWriter file = new System.IO.StreamWriter("config.txt"))
            {
                file.WriteLine("BGColor=" + panel1.BackColor);
            }
        }

        private bool LoadData()
        {
            if (File.Exists("data.txt"))
            {
                string[] lines = System.IO.File.ReadAllLines("data.txt");
                foreach (string line in lines)
                {
                    string[] values = line.Split(',');
                    try
                    {
                        Segment newSegment = new Segment(values[0], Int32.Parse(values[1]), Int32.Parse(values[2]), Int32.Parse(values[3]), Int32.Parse(values[4]));
                        Segments.Add(newSegment);
                    } catch (Exception e) { Console.WriteLine("EX:" + e); return false; }
                }
                SetCurrentSegment(Segments[lines.Length - 1]);
                UpdateSegmentList();
                return true;
            }

            return false;
        }

        private bool LoadMods()
        {
            if (File.Exists("mods.txt"))
            {
                string[] lines = System.IO.File.ReadAllLines("mods.txt");
                foreach (string line in lines)
                {
                    string[] values = line.Split(',');
                    try
                    {
                        Mods.Add(line);
                    }
                    catch (Exception e) { Console.WriteLine("EX:" + e); return false; }
                }
                RefreshModList();
                return true;
            }

            return false;
        }

        private void SetCurrentSegment(Segment segment)
        {
            //Can this be done procedurally because variable names match?
            CurrSegment = segment;
            BossName = segment.BossName;
            BossDeaths = segment.BossDeaths;
            AreaDeaths = segment.AreaDeaths;
            FallDeaths = segment.FallDeaths;
            SoulsLost = segment.SoulsLost;
            segment.active = true;
        }

        private class CommandDeathType
        {
            public int fall = 0;
            public int boss = 0;
            public int area = 0;
        }
        private CommandDeathType ParseDeathType(string type)
        {
            CommandDeathType deathType = new CommandDeathType();

            if (type.Length < 1 || type.Length > 2)
                return null;

            switch (type)
            {
                case "af":
                    deathType.fall = 1;
                    deathType.area = 1;
                    break;
                case "a":
                    deathType.area = 1;
                    break;
                case "bf":
                    deathType.boss = 1;
                    deathType.fall = 1;
                    break;
                case "b":
                    deathType.boss = 1;
                    break;
                case "f":
                    deathType.fall = 1;
                    break;
                default:
                    return null;
            }

            return deathType;
        }

        private void AddDeath(int amount, string type, bool suppress = false)
        {
            CommandDeathType dt = ParseDeathType(type);
            if (dt == null)
            {
                irc.sendChatMessage("Usage: !ded [type] [+/-] [amount] Type is a (area), b (boss), af (area fall), or bf (boss fall).");
                return;
            }

            string plural = amount > 1 ? "s" : "";
            string deathType = "";
            deathType = deathType + (dt.boss == 1 ? "boss " : "");
            deathType = deathType + (dt.area == 1 ? "area " : "");
            deathType = deathType + (dt.fall == 1 ? "fall " : "");

            BossDeaths += amount * dt.boss;
            FallDeaths += amount * dt.fall;
            AreaDeaths += amount * dt.area;

            if (!suppress)
                irc.sendChatMessage(string.Format("Added {0} {1}death{2}.", amount, deathType, plural));
        }

        private void RemoveDeath(int amount, string type, bool suppress = false)
        {
            CommandDeathType dt = ParseDeathType(type);
            if (dt == null)
            {
                irc.sendChatMessage("Usage: !ded [type] [+/-] [amount] Type is a (area), b (boss), af (area fall), or bf (boss fall).");
                return;
            }

            string plural = amount > 1 ? "s" : "";
            string deathType = "";
            deathType = deathType + (dt.boss == 1 ? "boss " : "");
            deathType = deathType + (dt.area == 1 ? "area " : "");
            deathType = deathType + (dt.fall == 1 ? "fall " : "");

            BossDeaths -= amount * dt.boss;
            FallDeaths -= amount * dt.fall;
            AreaDeaths -= amount * dt.area;

            if (!suppress)
                irc.sendChatMessage(string.Format("Removed {0} {1}death{2}.", amount, deathType, plural));
        }

        private int GetTotalDeaths()
        {
            return Segments.TotalDeaths + BossDeaths + AreaDeaths;
        }

        private int GetTotalSouls()
        {
            return Segments.TotalSouls + SoulsLost;
        }

        private string[] GetBossProgress()
        {
            List<string> progress = new List<string>();

            progress.Add("/me Dark Souls 1 Boss Progress");
            progress.Add("/me Boss Name: Deaths (Area Deaths) [Falls]");
            foreach (Segment segment in Segments) {
                progress.Add(string.Format("{0}: {1} ({2}) [{3}]", segment.BossName, segment.BossDeaths, segment.AreaDeaths, segment.FallDeaths));
            }

            return progress.ToArray();
        }

        private void NewSegment()
        {
            Segment newSegment = new Segment();
            Segments.Add(newSegment);
            UpdateSegmentList();
            SetCurrentSegment(newSegment);
        }

        private void UpdateSegmentList()
        {
            listView1.Items.Clear();
            foreach (Segment segment in Segments)
            {
                ListViewItem lvi = new ListViewItem(segment.BossName);
                lvi.SubItems.Add(segment.BossDeaths.ToString());
                lvi.SubItems.Add(segment.AreaDeaths.ToString());
                lvi.SubItems.Add(segment.FallDeaths.ToString());
                lvi.SubItems.Add(segment.SoulsLost.ToString());
                listView1.Items.Add(lvi);
            }
        }

        private void Overlay_FormClosing(object sender, FormClosingEventArgs e)
        {
            Save();
        }

        private void bossMinus_Click(object sender, EventArgs e)
        {
            RemoveDeath(1, "a");
        }

        private void bossPlus_Click(object sender, EventArgs e)
        {
            AddDeath(1, "a");
        }

        private void bossSet_Click(object sender, EventArgs e)
        {
            BossName = tbxBossName.Text;
        }

        private void btnNewSeg_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Start New Segment?", "New Segment",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                NewSegment();
            }
        }

        private void tbxBossName_TextChanged(object sender, EventArgs e)
        {
            BossName = ((TextBox)sender).Text;
        }

        private void tbxBossDeaths_TextChanged(object sender, EventArgs e)
        {
            Regex rgx = new Regex("[^(0-9)]");
            string text = rgx.Replace(((TextBox)sender).Text, "");
            ((TextBox)sender).Text = text;
            if (text.Length > 0)
                BossDeaths = Int32.Parse(text);
            else
                BossDeaths = 0;
        }

        private void tbxAreaDeaths_TextChanged(object sender, EventArgs e)
        {
            Regex rgx = new Regex("[^(0-9)]");
            string text = rgx.Replace(((TextBox)sender).Text, "");
            ((TextBox)sender).Text = text;
            if (text.Length > 0)
                AreaDeaths = Int32.Parse(rgx.Replace(((TextBox)sender).Text, ""));
            else
                AreaDeaths = 0;
        }

        private void tbxFallDeaths_TextChanged(object sender, EventArgs e)
        {
            Regex rgx = new Regex("[^(0-9)]");
            string text = rgx.Replace(((TextBox)sender).Text, "");
            ((TextBox)sender).Text = text;
            if (text.Length > 0)
                FallDeaths = Int32.Parse(rgx.Replace(((TextBox)sender).Text, ""));
            else
                FallDeaths = 0;
        }

        private void bgwChat_DoWork(object sender, DoWorkEventArgs e)
        {
            while (true)
            {
                string ircMsg = irc.readMessage();
                ParseChatMsg(ircMsg);
            }
        }

        private void ParseChatMsg(string ircMsg)
        {
            if (ircMsg != null && ircMsg != "" && ircMsg.Length > 0)
            {
                Console.WriteLine(ircMsg);
                if (ircMsg.Equals("PING :tmi.twitch.tv"))
                {
                    irc.sendIrcMessage("PONG :tmi.twitch.tv");
                }
                else
                {
                    string user = "";
                    string message = "";
                    Regex regex = new Regex(@":(.*)!.*@.*.tmi.twitch.tv PRIVMSG #perterter :(.*)");
                    Match match = regex.Match(ircMsg);
                    if (match.Success)
                    {
                        user = match.Groups[1].Value;
                        message = match.Groups[2].Value;
                        if (message.StartsWith("!"))
                        {
                            string[] args = message.Split(' ');
                            string command = args[0];
                            switch (command)
                            {
                                case "!progress":
                                    {
                                        foreach (string bossMsg in GetBossProgress())
                                        {
                                            irc.sendChatMessage(bossMsg);
                                        }
                                        break;
                                    }
                                case "!ded":
                                    {
                                        if (args.Length >= 3 && Mods.Contains(user))
                                        {
                                            int amount = 1;
                                            if (args.Length >= 4)
                                                try { amount = Int32.Parse(args[3]); } catch (Exception) { break; }
                                            if (args[2] == "+")
                                                BeginInvoke((Action)(delegate { AddDeath(amount, args[1]); }));
                                            else if (args[2] == "-")
                                                BeginInvoke((Action)(delegate { RemoveDeath(amount, args[1]); }));
                                        }
                                        else
                                        {
                                            irc.sendChatMessage(string.Format("Total Deaths: {0} (!progress for more details)", GetTotalDeaths()));
                                        }
                                        break;
                                    }
                                case "!souls":
                                    {
                                        if (args.Length == 3 && Mods.Contains(user))
                                        {
                                            int amount = 0;
                                            try { amount = Int32.Parse(args[2]); } catch (Exception) { break; }
                                            if (args[1] == "+")
                                                BeginInvoke((Action)(delegate { AddSouls(amount); }));
                                            else if (args[1] == "-")
                                                BeginInvoke((Action)(delegate { RemoveSouls(amount); }));
                                        }
                                        else
                                        {
                                            irc.sendChatMessage(string.Format("Total Souls Lost: {0}", GetTotalSouls()));
                                        }
                                        break;
                                    }
                                case "!dedmod":
                                    if (args.Length == 3 && user == "perterter")
                                    {
                                        if (args[1] == "+" || args[1] == "add")
                                            AddMod(args[2]);
                                        else if (args[1] == "-" || args[1] == "remove")
                                            RemoveMod(args[2]);
                                        else
                                            irc.sendChatMessage("Usage: !dedmod [+/-] [user]");
                                    }
                                    break;
                                default:
                                    break;
                            }
                        }
                    }
                }
            }
        }

        private void tbxTest_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TextBox tbxTest = (TextBox)sender;
                ParseChatMsg(":perterter!.*@.*.tmi.twitch.tv PRIVMSG #perterter :" + tbxTest.Text);
                tbxTest.Clear();
            }
        }

        private void btnExpand_Click(object sender, EventArgs e)
        {
            Expanded = !Expanded;
        }

        private void btnAddMod_Click(object sender, EventArgs e)
        {
            AddMod(tbxMod.Text);
            tbxMod.Clear();
        }

        private void AddMod(string modName)
        {
            if (!Mods.Contains(modName))
            {
                Mods.Add(modName);
                irc.sendChatMessage(String.Format("{0} added as a DS death mod!", modName));
            }
            else
            {
                irc.sendChatMessage(String.Format("{0} already  modded.", modName));
            }
            RefreshModList(); //TODO: Update dynamically, instead of full refresh
        }

        private void RemoveMod(string modName)
        {
            if (Mods.Contains(modName))
            {
                Mods.RemoveAll(x => x == modName);
            }
            RefreshModList(); //TODO: Update dynamically, instead of full refresh
        }

        private void RefreshModList()
        {
            listMods.Clear();
            foreach (string mod in Mods)
            {
                listMods.Items.Add(new ListViewItem(mod));
            }
        }

        private void listMods_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                if (listMods.FocusedItem.Bounds.Contains(e.Location) == true)
                    cntxtMenMod.Show(Cursor.Position);
        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveMod(listMods.FocusedItem.Text);
        }

        private void AddSouls(int amount, bool suppress = false)
        {
            SoulsLost += amount;

            if (!suppress)
                irc.sendChatMessage(string.Format("Added {0} lost souls.", amount));
        }

        private void RemoveSouls(int amount, bool suppress = false)
        {
            SoulsLost -= amount;

            if (!suppress)
                irc.sendChatMessage(string.Format("Removed {0} lost souls.", amount));
        }

        private void btnBGColor_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            panel1.BackColor = colorDialog1.Color;
            btnBGColor.BackColor = colorDialog1.Color;
        }
    }

}
