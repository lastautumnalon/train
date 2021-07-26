using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace 平片假训练
{
    public partial class Form1 : Form
    {
        string[] map = { "a","i","u","e","o",
                       "ka" ,"ki","ku","ke","ko",
    "sa","si","su","se","so",
    "ta","chi","tsu","te","to",
    "na","ni","nu","ne","no",
    "ha","hi","fu","he","ho",
    "ma","mi","mu","me","mo",
    "ya","i","yu","e","yo",
    "ra","ri","ru","re","ro",
    "wa","i","u","e","o","n" };
        string[] a = { "あ","い","う","え","お",
                       "か" ,"き","く","け","こ",
    "さ","し","す","せ","そ",
    "た","ち","つ","て","と",
    "な","に","ぬ","ね","の",
    "は","ひ","ふ","へ","ほ",
    "ま","み","む","め","も",
    "や","い","ゆ","え","よ",
    "ら","り","る","れ","ろ",
    "わ","い","う","え","を","ん" };

        string[] b={
            "ア","イ","ウ","エ","オ",
            "カ" ,"キ","ク","ケ","コ",
            "サ","シ","ス","セ","ソ",
            "タ","チ","ツ","テ","ト",
            "ナ","ニ","ヌ","ネ","ノ",
            "ハ","ヒ","フ","ヘ","ホ",
            "マ","ミ","ム","メ","モ",
            "ヤ","イ","ユ","エ","ヨ",
            "ラ","リ","ル","レ","ロ",
            "ワ","イ","ウ","エ","ヲ","ン"
    };
        int mode; //0 1 2
        int cnt = 0;
        int ind;
        bool isTrue = false;
        public Form1()
        {
            InitializeComponent();
        }
        private int random()
        {
            Random r = new Random((int)DateTime.Now.Ticks);
            int tmp  =r.Next(0, 51);
            return tmp;
        }
        private void button1_Click(object sender, EventArgs e)//pinjia
        {//arg=0
            mode = 0;
            ind = random();
            view.Text = a[ind];
        }

        private void pianj_Click(object sender, EventArgs e)//pianjia
        {//arg=1
            mode = 1;
            ind = random();
            view.Text = b[ind];
        }

        private void button2_Click(object sender, EventArgs e)//fixed
        {//arg=2
            mode = 2;
            Random r = new Random((int)DateTime.Now.Ticks);
            int tmp = r.Next(0, 2);
            if (tmp == 0)
            {
                ind = random();
                view.Text = a[ind];
            }
            else
            {
                ind = random();
                view.Text = b[ind];
            }
        }
        bool t = false;//last answer true
        private void submit_Click(object sender, EventArgs e)
        {
            if (ans.Text == map[ind] && (!t))
            {
                label1.Text = "正确的答案";
                t = true;
                cnt++;
                tB1.Text = cnt.ToString();
            }else if (ans.Text != map[ind] && (!t))
            {
                label1.Text = "错误的答案";
            }
            if (t)
            {
                switch (mode)
                {
                    case 0:
                        ind = random();
                        view.Text = a[ind];
                        t = false;
                        break;
                    case 1:
                        ind = random();
                        view.Text = b[ind];
                        t = false;
                        break;
                    case 2:
                        Random r = new Random((int)DateTime.Now.Ticks);
                        int tmp = r.Next(0, 2);
                        if (tmp == 0)
                        {
                            ind = random();
                            view.Text = a[ind];
                            t = false;
                        }
                        else
                        {
                            ind = random();
                            view.Text = b[ind];
                            t = false;
                        }
                        break;
                    default:
                        break;
                }
            }
        }
        private void label1_Click(object sender,EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
