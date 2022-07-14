using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yoketoru_VS_22
{
    public partial class Form1 : Form
    {
        enum State
        {
            None = -1,//無効
            Title,    //タイトル
            Game,     //ゲーム
            Gameover, //ゲームオーバー
            Clear     //クリア
        }
        State currentState = State.None;
        State nextState = State.Title;
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(nextState != State.None)
            {
                initProc();
            }
            
        }

        void initProc()
        {
            currentState = nextState;
            nextState = State.None;

            switch(currentState)
            {
                case State.Title:
                    titlelabel.Visible = true;
                    titlebutton.Visible = false;
                    crlabel.Visible = true;
                    highscorelabel.Visible = true;
                    gameoverlabel.Visible = false;
                    clearlabel.Visible = false;
                    sutartbutton.Visible = true;
                    break;

                case State.Game:
                    titlelabel.Visible = false;
                    highscorelabel.Visible = false;
                    sutartbutton.Visible = false;
                    crlabel.Visible = false;
                    break;
            }
        }

        private void sutartbutton_Click(object sender, EventArgs e)
        {
            nextState = State.Game;
        }
    }
}
