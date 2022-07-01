using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace B0226497_段昱如_PDPR_week3_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            student stu_1 = new student();
            stu_1.setSID("B0226497_1");
            stu_1.setSName("段昱如_1");
            stu_1.setSTEL("000001");
            stu_1.setCHI(122);
            stu_1.setMATH(314);
            stu_1.setENG(554);
            student stu_2 = new student();
            stu_2.setSID("B0226497_2");
            stu_2.setSName("段昱如_2");
            stu_2.setSTEL("000002");
            stu_2.setCHI(-86);
            stu_2.setMATH(-45);
            stu_2.setENG(-45);
            student stu_3 = new student();
            stu_3.setSID("B0226497_3");
            stu_3.setSName("段昱如_3");
            stu_3.setSTEL("000003");
            stu_3.setCHI(333);
            stu_3.setMATH(-54);
            stu_3.setENG(354);
            student stu_4 = new student();
            stu_4.setSID("B0226497_4");
            stu_4.setSName("段昱如_4");
            stu_4.setSTEL("000004");
            stu_4.setCHI(433);
            stu_4.setMATH(878);
            stu_4.setENG(868);
            student stu_5 = new student();
            stu_5.setSID("B0226497_5");
            stu_5.setSName("段昱如_5");
            stu_5.setSTEL("000005");
            stu_5.setCHI(-453);
            stu_5.setMATH(-43);
            stu_5.setENG(-43);
            string str= "學生各項資料:";
            str += $"\n學號:{stu_1.getSID()},姓名:{stu_1.getSName()},電話:{stu_1.getSTEL()},國文:{stu_1.getCHI()},數學:{stu_1.getMATH()},英文:{stu_1.getENG()},平均:{(stu_1.getCHI() + stu_1.getMATH() + stu_1.getENG()) / 3}";
            str += $"\n學號:{stu_2.getSID()},姓名:{stu_2.getSName()},電話:{stu_2.getSTEL()},國文:{stu_2.getCHI()},數學:{stu_2.getMATH()},英文:{stu_2.getENG()},平均:{(stu_2.getCHI() + stu_2.getMATH() + stu_2.getENG()) / 3}";
            str += $"\n學號:{stu_3.getSID()},姓名:{stu_3.getSName()},電話:{stu_3.getSTEL()},國文:{stu_3.getCHI()},數學:{stu_3.getMATH()},英文:{stu_3.getENG()},平均:{(stu_3.getCHI() + stu_3.getMATH() + stu_3.getENG()) / 3}";
            str += $"\n學號:{stu_4.getSID()},姓名:{stu_4.getSName()},電話:{stu_4.getSTEL()},國文:{stu_4.getCHI()},數學:{stu_4.getMATH()},英文:{stu_4.getENG()},平均:{(stu_4.getCHI() + stu_4.getMATH() + stu_4.getENG()) / 3}";
            str += $"\n學號:{stu_5.getSID()},姓名:{stu_5.getSName()},電話:{stu_5.getSTEL()},國文:{stu_5.getCHI()},數學:{stu_5.getMATH()},英文:{stu_5.getENG()},平均:{(stu_5.getCHI() + stu_5.getMATH() + stu_5.getENG()) / 3}";
            lblresult.Text = str;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        class student
        {
            private string SID;
            private string SName;
            private string STEL;
            private int CHI;
            private int MATH;
            private int ENG;
            public void setSID(String sid)
            {
                SID = sid;
            }
            public String getSID()
            {
                return SID;
            }
            public void setSName(string sname)
            {
                SName = sname;
            }
            public string getSName()
            {
                return SName;
            }
            public void setSTEL(String stel)
            {
                STEL = stel;
            }
            public String getSTEL()
            {
                return STEL;
            }
            public void setCHI(int chi)
            {
                if (chi > 100)
                    chi = 100;
                else if (chi < 0)
                    chi = 0;
                CHI = chi;
            }
            public int getCHI()
            {
                return CHI;
            }
            public void setMATH(int math)
            {
                if (math > 100)
                    math = 100;
                else if (math < 0)
                    math = 0;
                MATH = math;
            }
            public int getMATH()
            {
                return MATH;
            }
            public void setENG(int eng)
            {
                if (eng > 100)
                    eng = 100;
                else if (eng < 0)
                    eng = 0;
                ENG = eng;
            }
            public int getENG()
            {
                return ENG;
            }
        }

        private void lblresult_Click(object sender, EventArgs e)
        {

        }
    }
}
