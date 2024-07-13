using MaterialSkin;
using MaterialSkin.Controls;
using SplashScreen.WindowsForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultipleIntelligentBotManager
{
    public partial class MainForm : MaterialForm
    {
        MaterialSkinManager msm = MaterialSkinManager.Instance;
        private Splasher splasher;
        //Logger logger = new Logger();

        public MainForm()
        {
            // 메인 폼 초기화
            Splash();
            InitializeComponent();

            // 메인 폼 수동 설정
            this.Font = new Font("Noto Sans KR", 9, FontStyle.Regular);
        }

        // ##### ▼▼스플래시 화면 초기화▼▼ #####
        private void Splash()
        {
            splasher = new Splasher("Multiple Intelligent Bot Manager", "v0.1.0-experimental");
            splasher.Show(); Thread.Sleep(2000);
        }

        private void MainForm_Shown(object sender, EventArgs e) { splasher.Close(); }
        // ##### ▲▲스플래시 화면 초기화▲▲ #####

        private void MainForm_Load(object sender, EventArgs e)
        {
            splasher.Close();
            this.Activate();
            //ThemeChanger();
        }
    }
}
