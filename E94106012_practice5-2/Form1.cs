using System.Xml.Linq;

namespace E94106012_practice5_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<string> selectedServant = new List<string>();
        List<Servant> selectedServant1 = new List<Servant>();
        int countdown, countup;
        bool readysec = true;
        bool battlesec = false;
        bool endsec = false;
        int choosenum = 0;
        int turn = 0;
        int roundnum = 1;



        Saber saber = new Saber();
        Caster caster = new Caster();
        Berserker berserker = new Berserker();
        Beast beast = new Beast();


        //---------- �����_ʼ�[�� ----------
        private void ResetAll()
        {
            saber.reset();
            caster.reset();
            berserker.reset();
            beast.reset();
            choosenum = 0;
            countdown = 10;
            countup = 0;
            label1.Visible = false;
            label1.Text = "�ʂ��A��";
            label1.Location = new Point(356, 9);
            label2.Visible = false;
            Leftlabel.Visible = false;
            Rightlabel.Visible = false;
            Turnlabel.Visible = false;
            Btn1.Visible = false;
            Btn2.Visible = false;
            Btn3.Visible = false;
            Startbutton.Visible = true;
            Btn1.Text = "Berserker";
            Btn2.Text = "Saber";
            Btn3.Text = "Caster";
            timer1.Enabled = false;
            timer2.Enabled = false;// ��ͣӋ�r��
            timer1.Interval = 1000;//(1��)
            timer2.Interval = 1000;//(1��)
            readysec = true;



        }
        private void Form1_Load(object sender, EventArgs e)
        {
            ResetAll();
        }

        private void Startbutton_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            label2.Visible = true;
            Btn1.Visible = true;
            Btn2.Visible = true;
            Btn3.Visible = true;
            Startbutton.Visible = false;
            timer1.Enabled = true;	     // ����Ӌ�r��
            timer2.Enabled = false;
        }
        //--------------------�չ�--------------------------------
        private void Btn1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            if (Btn1.Text == "Berserker")
            {
                if (Btn1.BackColor == Color.White)
                {
                    if (choosenum == 2)
                    {
                        MessageBox.Show("ֻ���x�ɂ�Servant", "", MessageBoxButtons.OK);
                    }
                    else
                    {
                        Btn1.BackColor = Color.LimeGreen;
                        choosenum++;
                        selectedServant.Add(Btn1.Text);
                    }
                }
                else
                {
                    Btn1.BackColor = Color.White;
                    choosenum--;
                    selectedServant.Remove(Btn1.Text);
                }
            }
            else
            {
                Random rnd = new Random();
                int CriticalOrNot = rnd.Next(0, 2);
                int NormalValue = rnd.Next(20, 26);
                int CritialValue = 30;
                //�@߅���չ��ĺ���
                if (CriticalOrNot == 0)
                {
                    beast.Injured(selectedServant1[turn].GetAttack());
                    selectedServant1[turn].charge += NormalValue;
                    timer1.Enabled = false;
                }
                else
                {
                    beast.Injured(selectedServant1[turn].GetAttack() * (2));
                    selectedServant1[turn].charge += CritialValue;
                    timer1.Enabled = false;
                    MessageBox.Show(string.Format("��Beast�����{0}�c�������", selectedServant1[turn].GetAttack() * (2)), "", MessageBoxButtons.OK);
                }
                if (turn == (selectedServant1.Count - 1) && !(selectedServant1[0] == beast))
                {

                    selectedServant1[turn].skillCD++;
                    turn = 0;
                    timer1.Enabled = true;
                }
                else if(selectedServant1[0] == beast)
                {
                    selectedServant1[1].skillCD++;
                    timer1.Enabled = true;
                }
                else
                {

                    roundnum++;
                    selectedServant1[turn].skillCD++;
                    turn++;
                    timer1.Enabled = true;
                }
            }
        }
        //-------------------����-------------------------
        private void Btn2_Click(object sender, EventArgs e)
        {
            if (Btn2.Text == "Saber")
            {
                if (Btn2.BackColor == Color.White)
                {
                    if (choosenum == 2)
                    {
                        MessageBox.Show("ֻ���x�ɂ�Servant", "", MessageBoxButtons.OK);
                    }
                    else
                    {
                        Btn2.BackColor = Color.LimeGreen;
                        choosenum++;
                        selectedServant.Add(Btn2.Text);
                    }

                }
                else
                {
                    Btn2.BackColor = Color.White;
                    choosenum--;
                    selectedServant.Remove(Btn2.Text);
                }
            }
            else
            {
                //�@߅��ܵĺ���
                timer1.Enabled = false;
                if (selectedServant1[turn].skillCD >= 3)
                {
                    selectedServant1[turn].Skill();
                    MessageBox.Show("������s��(ʣ�N�غ�:3)", "", MessageBoxButtons.OK);
                }

                else
                {
                    MessageBox.Show(string.Format("������s��(ʣ�N�غ�:{0})", (3 - selectedServant1[turn].skillCD)), "", MessageBoxButtons.OK);
                }


            }

        }
        //-----------------����--------------------------------
        private void Btn3_Click(object sender, EventArgs e)
        {
            if (Btn3.Text == "Caster")
            {
                if (Btn3.BackColor == Color.White)
                {
                    if (choosenum == 2)
                    {
                        MessageBox.Show("ֻ���x�ɂ�Servant", "", MessageBoxButtons.OK);
                    }
                    else
                    {
                        Btn3.BackColor = Color.LimeGreen;
                        choosenum++;
                        selectedServant.Add(Btn3.Text);
                    }

                }
                else
                {
                    Btn3.BackColor = Color.White;
                    choosenum--;
                    selectedServant.Remove(Btn3.Text);
                }
            }
            else
            {
                //�@߅��ߵĺ���
                if (selectedServant1[turn].charge >= 100)
                {
                    selectedServant1[turn].charge -= 100;
                    timer1.Enabled = false;
                    if (selectedServant1[turn] == saber)
                    {
                        SaberTreasure();
                    }
                    else if (selectedServant1[turn] == berserker)
                    {
                        BerserkerTreasure();
                    }
                    else if (selectedServant1[turn] == caster)
                    {
                        CasterTreasure();
                    }

                    if (turn == (selectedServant1.Count - 1))
                    {
                        selectedServant1[turn].skillCD++;
                        turn = 0;
                        timer1.Enabled = true;
                    }
                    else
                    {
                        roundnum++;
                        selectedServant1[turn].skillCD++;
                        turn++;
                        timer1.Enabled = true;
                    }
                }
                else
                {
                    MessageBox.Show("���ܲ��㣬�o��ʩ�Ō���", "", MessageBoxButtons.OK);
                }
            }

        }
        //------------------ˢ��---------------------
        private void timer1_Tick(object sender, EventArgs e)
        {

            if (readysec == true)
            {
                label2.Text = countdown.ToString();
                if (countdown == 0)
                {
                    timer1.Enabled = false;
                    Startbutton.Enabled = true;
                    //MessageBox.Show("�r�g����", "�r�g������", MessageBoxButtons.OK);
                    Turnlabel.Visible = true;
                    readysec = false;
                    battlesec = true;
                    timer1.Enabled = true;
                    label1.Text = "�r�g";
                    label1.Location = new Point(370, 9);
                    AutoChoose();
                    Rearrange();

                    ChangeButtons();

                }
                countdown--;
            }
            else
            {

                Leftlabel.Visible = true;
                Rightlabel.Visible = true;
                timer2.Enabled = true;
                Rightlabel.Text = GetAll(beast);

                if (selectedServant1[turn].character == "Beast")
                {
                    BeastSkill();
                    GoOn();
                    BeastAttack();
                }
                ChangeTurnLabel();

                if (selectedServant1.All(servant => servant == beast) && selectedServant1.Count == 1)
                {
                    timer1.Enabled = false;
                    timer2.Enabled = false;
                    MessageBox.Show(string.Format("You Lose\nͨ�P�r�g: {0}", countup), "", MessageBoxButtons.OK);
                    ResetAll();
                }
                if (selectedServant1[turn].hp <= 0 && !(selectedServant1[turn] == beast))
                {
                    timer1.Enabled = false;
                    MessageBox.Show(string.Format("{0}������", selectedServant1[turn].character), "", MessageBoxButtons.OK);
                    
                    selectedServant1.Remove(selectedServant1[turn]);
                    turn = 0;
                    if (selectedServant1[0] == beast)
                    {
                        Servant temp = selectedServant1[0];
                        selectedServant1[0] = selectedServant1[1];
                        selectedServant1[1] = temp;
                    }
                }

                if (beast.hp <= 0)
                {
                    timer1.Enabled = false;
                    timer2.Enabled = false;
                    MessageBox.Show(string.Format("You Win!\nͨ�P�r�g: {0}", countup), "", MessageBoxButtons.OK);
                    ResetAll();
                }
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (readysec == true)
            {

            }
            else
            {
                label2.Text = countup.ToString();
                countup++;

                if(selectedServant1[turn] == beast)
                {
                    
                }
                else
                {
                    Leftlabel.Text = GetAll(selectedServant1[turn]);
                }
                

                if (selectedServant1.All(servant => servant == beast) && selectedServant1.Count == 1)
                {
                    timer1.Enabled = false;
                    timer2.Enabled = false;
                    MessageBox.Show(string.Format("You Lose\nͨ�P�r�g: {0}", countup), "", MessageBoxButtons.OK);
                    ResetAll();
                }
                if (beast.hp <= 0)
                {
                    timer1.Enabled = false;
                    timer2.Enabled = false;

                    MessageBox.Show(string.Format("You Win!\nͨ�P�r�g: {0}", countup), "", MessageBoxButtons.OK);
                    ResetAll();
                }
            }
        }

        private string GetAll(Servant servant)
        {

            return string.Format("{0}\nHp: {1}\nCharge: {2}%\nAttack: {3}", servant.GetCharacter(), servant.GetHp(), servant.GetCharge(), servant.GetAttack());
        }

        private void AutoChoose()
        {
            if (choosenum < 2)
            {
                if (selectedServant.Contains(Btn3.Text))
                {
                    selectedServant.Add(Btn1.Text);
                    Btn1.BackColor = Color.LimeGreen;
                }
                else if (selectedServant.Contains(Btn2.Text))
                {
                    selectedServant.Add(Btn1.Text);
                    Btn1.BackColor = Color.LimeGreen;
                }
                else if (selectedServant.Contains(Btn1.Text))
                {
                    selectedServant.Add(Btn2.Text);
                    Btn2.BackColor = Color.LimeGreen;
                }
                else
                {
                    selectedServant.Add(Btn1.Text);
                    Btn1.BackColor = Color.LimeGreen;
                    selectedServant.Add(Btn2.Text);
                    Btn2.BackColor = Color.LimeGreen;
                }
            }
        }
        private void Rearrange()
        {
            if (!selectedServant.Contains("Saber"))
            {
                selectedServant1 = new List<Servant> { caster, beast, berserker };
            }
            else if (!selectedServant.Contains("Caster"))
            {
                selectedServant1 = new List<Servant> { saber, beast, berserker };
            }
            else if (!selectedServant.Contains("Berserker"))
            {
                selectedServant1 = new List<Servant> { saber, caster, beast };
            }
            //Turnlabel.Text = string.Format("{0}{1}{2}", selectedServant[0], selectedServant[1], selectedServant[2]);
        }
        private void ChangeButtons()
        {
            Btn1.Text = "�չ�";
            Btn2.Text = "����";
            Btn3.Text = "����";
            Btn1.BackColor = Color.White;
            Btn2.BackColor = Color.White;
            Btn3.BackColor = Color.White;
        }

        private void BeastAttack()
        {
            if (beast.charge >= 100)
            {
                timer1.Enabled = true;
                beast.charge -= 100;
                foreach (Servant friend in selectedServant1)
                {
                    if (friend.character != "Beast")
                    {
                        friend.Injured(beast.GetAttack() * 2);

                    }
                }
                MessageBox.Show(string.Format("Beastʹ���ˌ���\n��ȫ�w������{0}�c����", beast.GetAttack() * 2), "", MessageBoxButtons.OK);
                roundnum++;
                beast.skillCD++;
                timer1.Enabled = true;
            }
            else
            {
                foreach (Servant friend in selectedServant1)
                {
                    if (friend.character != "Beast")
                    {
                        friend.Injured(beast.GetAttack());

                    }
                }
                beast.charge += 20;
                MessageBox.Show(string.Format("Beast��ȫ�w������{0}�c����", beast.GetAttack()), "", MessageBoxButtons.OK);
                roundnum++;
                beast.skillCD++;
                timer1.Enabled = true;
            }
        }
        private void BeastSkill()
        {
            if (beast.skillCD % 4 == 0 && !(beast.skillCD == 0))
            {
                beast.Skill();
                timer1.Enabled = false;
                MessageBox.Show(string.Format("Beastʹ���˼���\n��ǰATK: {0}", beast.attack), "", MessageBoxButtons.OK);
            }
        }
        private void GoOn()
        {
            if (turn == (selectedServant1.Count - 1) && !(selectedServant1[0] == beast))
            {
                turn = 0;
            }
            else if (selectedServant1[0] == beast)
            {
                selectedServant1[1].skillCD++;
            }
            else
            {
                turn++;
                roundnum++;
            }
        }
        private void ChangeTurnLabel()
        {
            if (turn == (selectedServant1.Count))
            {
                turn = 0;
                Turnlabel.Text = string.Format("{0} turn", selectedServant1[turn].character);
            }
            else
            {
                if (selectedServant1[turn].character == "Beast")
                {

                    if (turn == (selectedServant1.Count - 1) && !(selectedServant1[0] == beast))
                    {
                        turn = 0;
                        Turnlabel.Text = string.Format("{0} turn", selectedServant1[turn].character);
                    }
                    else if (selectedServant1[0] == beast)
                    {

                    }
                    else
                    {
                        turn++;
                        roundnum++;
                    }
                }
                else
                {
                    Turnlabel.Text = string.Format("{0} turn", selectedServant1[turn].character);
                }
            }
            Leftlabel.Text = GetAll(selectedServant1[turn]);
        }
        private void SaberTreasure()
        {
            beast.Injured((saber.attack + 25));
            saber.hp += 5;
            MessageBox.Show(string.Format("Saberʹ���ˌ���:\n��Beast���{0}�c�����K�؏�5�cѪ��", (saber.attack + 25)), "", MessageBoxButtons.OK);
        }
        private void CasterTreasure()
        {
            foreach (Servant friend in selectedServant1)
            {
                if (friend.character != "Beast")
                {
                    friend.attack += 1;
                    friend.hp += 10;
                }
            }
            MessageBox.Show("Casterʹ���ˌ���:\nȫ�w��Ѽ�1�c�������؏�5�cѪ��", "", MessageBoxButtons.OK);
        }
        private void BerserkerTreasure()
        {
            beast.Injured((berserker.attack + 50));
            MessageBox.Show(string.Format("Berserkerʹ���ˌ���:\n��Beast���{0}�c�����K�؏�5�cѪ��", (berserker.attack + 50)), "", MessageBoxButtons.OK);
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Turnlabel_Click(object sender, EventArgs e)
        {

        }




    }
}