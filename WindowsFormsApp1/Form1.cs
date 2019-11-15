using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VoiceMananger;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            gHook = new GlobalKeyboardHook(); //根據作者的程式碼(class)創造一個新物件

            gHook.KeyDown += new KeyEventHandler(gHook_KeyDown);// 連結KeyDown事件

            foreach (Keys key in Enum.GetValues(typeof(Keys)))
                gHook.HookedKeys.Add(key);

            gHook.hook();//開始監控
        }

        GlobalKeyboardHook gHook;
        int kv;//將keyValue轉成整數用的變數
        bool ctrl, alt, shift;//按下功能鍵時就改為true

        private bool _isRecording = false;

        private ChromeMananger chrome = new ChromeMananger();

        private Map _map=new Map();

        private void button1_Click(object sender, EventArgs e)
        {
            gHook.unhook();

            Environment.Exit(0);
        }

        public void gHook_KeyDown(object sender, KeyEventArgs e)
        {
            kv = e.KeyValue;//把按下的按鍵號碼轉成整數存在kv中

            label1.Text = kv.ToString();

            //假設快捷鍵觸發
            if (kv is (int)Keys.F1)
            {
                if (_isRecording) return;
                _isRecording = true;
                try
                {
                    label1.Text = "";

                    var soundCheck = new SoundCheck();
                    soundCheck.CanStartMsg += x => { label1.Text = x; };
                    var whatYouSay = soundCheck.StartListen();
                    var url = _map.GetUrlByString(whatYouSay);
                    chrome.GoToPage(url);

                }
                catch (Exception exception)
                {
                }
                _isRecording = false;
            }
        }
    }
}
