using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Retail : Form
    {
        public static String[] dishlist = new String[142];
        public static String[] dishcount = new String[142];
        public static String[] dishprice = new String[142];
        public int setvalueText4 = 0;
        public String setvalueText1 = "";
        public int setvalueText3 = 0;
        public int setvalueText2 = 0;
        public int counter1 = 0;
        public int counter2 = 0;
        public int counter3 = 0;
        public int counter4 = 0;
        public int counter5 = 0;
        public int counter6 = 0;
        public int counter7 = 0;
        public int counter8 = 0;
        public int counter9 = 0;
        public int counter10 = 0;
        public int counter11 = 0;
        public int counter12 = 0;
        public int counter13 = 0;
        public int counter14 = 0;
        public int counter15 = 0;
        public int counter16 = 0;
        public int counter17 = 0;
        public int counter18 = 0;
        public int counter19 = 0;
        public int counter20 = 0;
        public int counter21 = 0;
        public int counter22 = 0;
        public int counter23 = 0;
        public int counter24 = 0;
        public int counter25 = 0;
        public int counter26 = 0;
        public int counter27 = 0;
        public int counter28 = 0;
        public int counter29 = 0;
        public int counter30 = 0;
        public int counter31 = 0;
        public int counter32 = 0;
        public int counter33 = 0;
        public int counter34 = 0;
        public int counter35 = 0;
        public int counter36 = 0;
        public int counter37 = 0;
        public int counter38 = 0;
        public int counter39 = 0;
        public int counter40 = 0;
        public int counter41 = 0;
        public int counter42 = 0;
        public int counter43 = 0;
        public int counter44 = 0;
        public int counter45 = 0;
        public int counter46 = 0;
        public int counter47 = 0;
        public int counter48 = 0;
        public int counter49 = 0;
        public int counter50 = 0;
        public int counter51 = 0;
        public int counter52 = 0;
        public int counter53 = 0;
        public int counter54 = 0;
        public int counter55 = 0;
        public int counter56 = 0;
        public int counter57 = 0;
        public int counter58 = 0;
        public int counter59 = 0;
        public int counter60 = 0;
        public int counter61 = 0;
        public int counter62 = 0;
        public int counter63 = 0;
        public int counter64 = 0;
        public int counter65 = 0;
        public int counter66 = 0;
        public int counter67 = 0;
        public int counter68 = 0;
        public int counter69 = 0;
        public int counter70 = 0;
        public int counter71 = 0;
        public int counter72 = 0;
        public int counter73 = 0;
        public int counter74 = 0;
        public int counter75 = 0;
        public int counter76 = 0;
        public int counter77 = 0;
        public int counter78 = 0;
        public int counter79 = 0;
        public int counter80 = 0;
        public int counter81 = 0;
        public int counter82 = 0;
        public int counter83 = 0;
        public int counter84 = 0;
        public int counter85 = 0;
        public int counter86 = 0;
        public int counter87 = 0;
        public int counter88 = 0;
        public int counter89 = 0;
        public int counter90 = 0;
        public int counter91 = 0;
        public int counter92 = 0;
        public int counter93 = 0;
        public int counter94 = 0;
        public int counter95 = 0;
        public int counter96 = 0;
        public int counter97 = 0;
        public int counter98 = 0;
        public int counter99 = 0;
        public int counter100 = 0;
        public int counter101 = 0;
        public int counter102 = 0;
        public int counter103 = 0;
        public int counter104 = 0;
        public int counter105 = 0;
        public int counter106 = 0;
        public int counter107 = 0;
        public int counter108 = 0;
        public int counter109 = 0;
        public int counter110 = 0;
        public int counter111 = 0;
        public int counter112 = 0;
        public int counter113 = 0;
        public int counter114 = 0;
        public int counter115 = 0;
        public int counter116 = 0;
        public int counter117 = 0;
        public int counter118 = 0;
        public int counter119 = 0;
        public int counter120 = 0;
        public int counter121 = 0;
        public int counter122 = 0;
        public int counter123 = 0;
        public int counter124 = 0;
        public int counter125 = 0;
        public int counter126 = 0;
        public int counter127 = 0;
        public int counter128 = 0;
        public int counter129 = 0;
        public int counter130 = 0;
        public int counter131 = 0;
        public int counter132 = 0;
        public int counter133 = 0;
        public int counter134 = 0;
        public int counter135 = 0;
        public int counter136 = 0;
        public int counter137 = 0;
        public int counter138 = 0;
        public int counter139 = 0;
        public int counter140 = 0;
        public int counter141 = 0;
        public int counter142 = 0;

        public int price;
        public int FoodID;

        public Retail()
        {
            InitializeComponent();
        }

        private void Retail_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button22_Click(object sender, EventArgs e)
        {
            counter26 = counter26 + 1;
            price = counter26 * 250;
            setvalueText1 = "Bar BQ Sandwick";
            setvalueText2 = counter26;
            setvalueText3 = price;
            dishlist[25] = setvalueText1;
            dishcount[25] = setvalueText2.ToString();
            dishprice[25] = setvalueText3.ToString();
        }

        private void button33_Click(object sender, EventArgs e)
        {
            counter32 = counter32 + 1;
            price = counter32 * 400;
            setvalueText1 = "Baogee's Special (2 Qtr)";
            setvalueText2 = counter32;
            setvalueText3 = price;
            dishlist[31] = setvalueText1;
            dishcount[31] = setvalueText2.ToString();
            dishprice[31] = setvalueText3.ToString();
        }

        private void button54_Click(object sender, EventArgs e)
        {
            counter54 = counter54 + 1;
            price = counter54 * 250;
            setvalueText1 = "Beef Seekh Kabab";
            setvalueText2 = counter54;
            setvalueText3 = price;
            dishlist[53] = setvalueText1;
            dishcount[53] = setvalueText2.ToString();
            dishprice[53] = setvalueText3.ToString();
        }

        private void button70_Click(object sender, EventArgs e)
        {
            counter70 = counter70 + 1;
            price = counter70 * 120;
            setvalueText1 = "Beef Mayo Garlic Roll";
            setvalueText2 = counter70;
            setvalueText3 = price;
            dishlist[69] = setvalueText1;
            dishcount[69] = setvalueText2.ToString();
            dishprice[69] = setvalueText3.ToString();
        }

        private void button83_Click(object sender, EventArgs e)
        {
            string message = "YES for Full or NO for Half";
            string title = "Select";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                counter85 = counter85 + 1;
                price = counter85 * 1800;
                setvalueText1 = "Makhni Mutton Karahi Full";
                setvalueText2 = counter85;
                setvalueText3 = price;
                dishlist[84] = setvalueText1;
                dishcount[84] = setvalueText2.ToString();
                dishprice[84] = setvalueText3.ToString();
            }
            else
            {
                counter86 = counter86 + 1;
                price = counter86 * 950;
                setvalueText1 = "Makhni Mutton Karahi Half";
                setvalueText2 = counter86;
                setvalueText3 = price;
                dishlist[85] = setvalueText1;
                dishcount[85] = setvalueText2.ToString();
                dishprice[85] = setvalueText3.ToString();
            }
        }

        private void button87_Click(object sender, EventArgs e)
        {
            string message = "YES for Full or NO for Half";
            string title = "Select";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                counter93 = counter93 + 1;
                price = counter93 * 2000;
                setvalueText1 = "Baogee's Mutton Karachi Full";
                setvalueText2 = counter93;
                setvalueText3 = price;
                dishlist[92] = setvalueText1;
                dishcount[92] = setvalueText2.ToString();
                dishprice[92] = setvalueText3.ToString();
            }
            else
            {
                counter94 = counter94 + 1;
                price = counter94 * 1000;
                setvalueText1 = "Baogee's Mutton Karachi Half";
                setvalueText2 = counter94;
                setvalueText3 = price;
                dishlist[93] = setvalueText1;
                dishcount[93] = setvalueText2.ToString();
                dishprice[93] = setvalueText3.ToString();
            }
        }

        private void button88_Click(object sender, EventArgs e)
        {
            string message = "YES for Full or NO for Half";
            string title = "Select";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                counter89 = counter89 + 1;
                price = counter89 * 1800;
                setvalueText1 = "Mutton White Karachi Full";
                setvalueText2 = counter89;
                setvalueText3 = price;
                dishlist[88] = setvalueText1;
                dishcount[88] = setvalueText2.ToString();
                dishprice[88] = setvalueText3.ToString();
            }
            else
            {
                counter90 = counter90 + 1;
                price = counter90 * 950;
                setvalueText1 = "Mutton White Karachi Half";
                setvalueText2 = counter90;
                setvalueText3 = price;
                dishlist[89] = setvalueText1;
                dishcount[89] = setvalueText2.ToString();
                dishprice[89] = setvalueText3.ToString();
            }
        }

        private void button96_Click(object sender, EventArgs e)
        {
            string message = "YES for Full or NO for Half";
            string title = "Select";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                counter108 = counter108 + 1;
                price = counter108 * 1400;
                setvalueText1 = "Paneer Reshmi Handi Full";
                setvalueText2 = counter108;
                setvalueText3 = price;
                dishlist[107] = setvalueText1;
                dishcount[107] = setvalueText2.ToString();
                dishprice[107] = setvalueText3.ToString();
            }
            else
            {
                counter109 = counter109 + 1;
                price = counter109 * 750;
                setvalueText1 = "Paneer Reshmi Handi Half";
                setvalueText2 = counter109;
                setvalueText3 = price;
                dishlist[108] = setvalueText1;
                dishcount[108] = setvalueText2.ToString();
                dishprice[108] = setvalueText3.ToString();
            }
        }

        private void button100_Click(object sender, EventArgs e)
        {

        }

        private void button105_Click(object sender, EventArgs e)
        {
            counter120 = counter120 + 1;
            price = counter120 * 50;
            setvalueText1 = "Elaichi Chai";
            setvalueText2 = counter120;
            setvalueText3 = price;
            dishlist[119] = setvalueText1;
            dishcount[119] = setvalueText2.ToString();
            dishprice[119] = setvalueText3.ToString();
        }

        private void button111_Click(object sender, EventArgs e)
        {
            counter126 = counter126 + 1;
            price = counter126 * 90;
            setvalueText1 = "Cheese Aloo Paratha";
            setvalueText2 = counter126;
            setvalueText3 = price;
            dishlist[125] = setvalueText1;
            dishcount[125] = setvalueText2.ToString();
            dishprice[125] = setvalueText3.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            counter1 = counter1 + 1;
            price = counter1 * 200;
            setvalueText1 = "Mexican Wings";
            setvalueText2 = counter1;
            setvalueText3 = price;
            dishlist[0] = setvalueText1;
            dishcount[0] = setvalueText2.ToString();
            dishprice[0] = setvalueText3.ToString();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            counter2 = counter2 + 1;
            price = counter2 * 200;
            setvalueText1 = "Chicken Cheese Strips";
            setvalueText2 = counter2;
            setvalueText3 = price;
            dishlist[1] = setvalueText1;
            dishcount[1] = setvalueText2.ToString();
            dishprice[1] = setvalueText3.ToString();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
            Form2 frm2 = new Form2();
            frm2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            counter3 = counter3 + 1;
            price = counter3 * 150;
            setvalueText1 = "Chicken Corn Soup";
            setvalueText2 = counter3;
            setvalueText3 = price;
            dishlist[2] = setvalueText1;
            dishcount[2] = setvalueText2.ToString();
            dishprice[2] = setvalueText3.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            counter4 = counter4 + 1;
            price = counter4 * 160;
            setvalueText1 = "Crispy Nuggets";
            setvalueText2 = counter4;
            setvalueText3 = price;
            dishlist[3] = setvalueText1;
            dishcount[3] = setvalueText2.ToString();
            dishprice[3] = setvalueText3.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            counter5 = counter5 + 1;
            price = counter5 * 250;
            setvalueText1 = "Fish and Chips";
            setvalueText2 = counter5;
            setvalueText3 = price;
            dishlist[4] = setvalueText1;
            dishcount[4] = setvalueText2.ToString();
            dishprice[4] = setvalueText3.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            counter6 = counter6 + 1;
            price = counter6 * 100;
            setvalueText1 = "Vegetable Soup";
            setvalueText2 = counter6;
            setvalueText3 = price;
            dishlist[5] = setvalueText1;
            dishcount[5] = setvalueText2.ToString();
            dishprice[5] = setvalueText3.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            counter7 = counter7 + 1;
            price = counter7 * 200;
            setvalueText1 = "Honey Mustard Wings";
            setvalueText2 = counter7;
            setvalueText3 = price;
            dishlist[6] = setvalueText1;
            dishcount[6] = setvalueText2.ToString();
            dishprice[6] = setvalueText3.ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            counter8 = counter8 + 1;
            price = counter8 * 150;
            setvalueText1 = "Hot & Sour soup";
            setvalueText2 = counter8;
            setvalueText3 = price;
            dishlist[7] = setvalueText1;
            dishcount[7] = setvalueText2.ToString();
            dishprice[7] = setvalueText3.ToString();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            counter9 = counter9 + 1;
            price = counter9 * 120;
            setvalueText1 = "Masala Fries";
            setvalueText2 = counter9;
            setvalueText3 = price;
            dishlist[8] = setvalueText1;
            dishcount[8] = setvalueText2.ToString();
            dishprice[8] = setvalueText3.ToString();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            counter10 = counter10 + 1;
            price = counter10 * 140;
            setvalueText1 = "Mayo Garlic Fries";
            setvalueText2 = counter10;
            setvalueText3 = price;
            dishlist[9] = setvalueText1;
            dishcount[9] = setvalueText2.ToString();
            dishprice[9] = setvalueText3.ToString();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            counter11 = counter11 + 1;
            price = counter11 * 100;
            setvalueText1 = "Plain Fries";
            setvalueText2 = counter11;
            setvalueText3 = price;
            dishlist[10] = setvalueText1;
            dishcount[10] = setvalueText2.ToString();
            dishprice[10] = setvalueText3.ToString();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            counter12 = counter12 + 1;
            price = counter12 * 140;
            setvalueText1 = "Cheese Fries";
            setvalueText2 = counter12;
            setvalueText3 = price;
            dishlist[11] = setvalueText1;
            dishcount[11] = setvalueText2.ToString();
            dishprice[11] = setvalueText3.ToString();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            counter13 = counter13 + 1;
            price = counter13 * 350;
            setvalueText1 = "Baogee's Special Burger";
            setvalueText2 = counter13;
            setvalueText3 = price;
            dishlist[12] = setvalueText1;
            dishcount[12] = setvalueText2.ToString();
            dishprice[12] = setvalueText3.ToString();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            counter14 = counter14 + 1;
            price = counter14 * 230;
            setvalueText1 = "Cheese Melt Burger";
            setvalueText2 = counter14;
            setvalueText3 = price;
            dishlist[13] = setvalueText1;
            dishcount[13] = setvalueText2.ToString();
            dishprice[13] = setvalueText3.ToString();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            counter15 = counter15 + 1;
            price = counter15 * 200;
            setvalueText1 = "Cheese Melt";
            setvalueText2 = counter15;
            setvalueText3 = price;
            dishlist[14] = setvalueText1;
            dishcount[14] = setvalueText2.ToString();
            dishprice[14] = setvalueText3.ToString();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            counter16 = counter16 + 1;
            price = counter16 * 160;
            setvalueText1 = "Chicken Burger";
            setvalueText2 = counter16;
            setvalueText3 = price;
            dishlist[15] = setvalueText1;
            dishcount[15] = setvalueText2.ToString();
            dishprice[15] = setvalueText3.ToString();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            counter17 = counter17 + 1;
            price = counter17 * 200;
            setvalueText1 = "Crispy Zinger";
            setvalueText2 = counter17;
            setvalueText3 = price;
            dishlist[16] = setvalueText1;
            dishcount[16] = setvalueText2.ToString();
            dishprice[16] = setvalueText3.ToString();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            counter18 = counter18 + 1;
            price = counter18 * 200;
            setvalueText1 = "Friry Chicken";
            setvalueText2 = counter18;
            setvalueText3 = price;
            dishlist[17] = setvalueText1;
            dishcount[17] = setvalueText2.ToString();
            dishprice[17] = setvalueText3.ToString();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            counter19 = counter19 + 1;
            price = counter19 * 230;
            setvalueText1 = "Fiery Zinger";
            setvalueText2 = counter19;
            setvalueText3 = price;
            dishlist[18] = setvalueText1;
            dishcount[18] = setvalueText2.ToString();
            dishprice[18] = setvalueText3.ToString();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            counter20 = counter20 + 1;
            price = counter20 * 250;
            setvalueText1 = "Mighty Chicken";
            setvalueText2 = counter20;
            setvalueText3 = price;
            dishlist[19] = setvalueText1;
            dishcount[19] = setvalueText2.ToString();
            dishprice[19] = setvalueText3.ToString();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            counter21 = counter21 + 1;
            price = counter21 * 300;
            setvalueText1 = "Mighty Zinger";
            setvalueText2 = counter21;
            setvalueText3 = price;
            dishlist[20] = setvalueText1;
            dishcount[20] = setvalueText2.ToString();
            dishprice[20] = setvalueText3.ToString();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            counter22 = counter22 + 1;
            price = counter22 * 180;
            setvalueText1 = "Beef Burger";
            setvalueText2 = counter22;
            setvalueText3 = price;
            dishlist[21] = setvalueText1;
            dishcount[21] = setvalueText2.ToString();
            dishprice[21] = setvalueText3.ToString();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            counter23 = counter23 + 1;
            price = counter23 * 250;
            setvalueText1 = "Grilled Beef Burger";
            setvalueText2 = counter23;
            setvalueText3 = price;
            dishlist[22] = setvalueText1;
            dishcount[22] = setvalueText2.ToString();
            dishprice[22] = setvalueText3.ToString();
        }

        private void button25_Click(object sender, EventArgs e)
        {
            counter24 = counter24 + 1;
            price = counter24 * 200;
            setvalueText1 = "Jalapeeno Beef Burger";
            setvalueText2 = counter24;
            setvalueText3 = price;
            dishlist[23] = setvalueText1;
            dishcount[23] = setvalueText2.ToString();
            dishprice[23] = setvalueText3.ToString();
        }

        private void button26_Click(object sender, EventArgs e)
        {
            counter25 = counter25 + 1;
            price = counter25 * 250;
            setvalueText1 = "Might Beef Burger";
            setvalueText2 = counter25;
            setvalueText3 = price;
            dishlist[24] = setvalueText1;
            dishcount[24] = setvalueText2.ToString();
            dishprice[24] = setvalueText3.ToString();
        }

        private void button27_Click(object sender, EventArgs e)
        {
            counter27 = counter27 + 1;
            price = counter27 * 180;
            setvalueText1 = "Chicken Sandwich";
            setvalueText2 = counter27;
            setvalueText3 = price;
            dishlist[26] = setvalueText1;
            dishcount[26] = setvalueText2.ToString();
            dishprice[26] = setvalueText3.ToString();
        }

        private void button28_Click(object sender, EventArgs e)
        {
            counter28 = counter28 + 1;
            price = counter28 * 180;
            setvalueText1 = "Club Sandwich";
            setvalueText2 = counter28;
            setvalueText3 = price;
            dishlist[27] = setvalueText1;
            dishcount[27] = setvalueText2.ToString();
            dishprice[27] = setvalueText3.ToString();
        }

        private void button29_Click(object sender, EventArgs e)
        {
            counter29 = counter29 + 1;
            price = counter29 * 250;
            setvalueText1 = "Crispy Sandwich";
            setvalueText2 = counter29;
            setvalueText3 = price;
            dishlist[28] = setvalueText1;
            dishcount[28] = setvalueText2.ToString();
            dishprice[28] = setvalueText3.ToString();
        }

        private void button30_Click(object sender, EventArgs e)
        {
            counter30 = counter30 + 1;
            price = counter30 * 350;
            setvalueText1 = "Baogee's Special Sandwich";
            setvalueText2 = counter30;
            setvalueText3 = price;
            dishlist[29] = setvalueText1;
            dishcount[29] = setvalueText2.ToString();
            dishprice[29] = setvalueText3.ToString();
        }

        private void button32_Click(object sender, EventArgs e)
        {
            counter31 = counter31 + 1;
            price = counter31 * 250;
            setvalueText1 = "Mayo Garlic Broast";
            setvalueText2 = counter31;
            setvalueText3 = price;
            dishlist[30] = setvalueText1;
            dishcount[30] = setvalueText2.ToString();
            dishprice[30] = setvalueText3.ToString();
        }

        private void button34_Click(object sender, EventArgs e)
        {
            counter33 = counter33 + 1;
            price = counter33 * 230;
            setvalueText1 = "Chatpata Broast";
            setvalueText2 = counter33;
            setvalueText3 = price;
            dishlist[32] = setvalueText1;
            dishcount[32] = setvalueText2.ToString();
            dishprice[32] = setvalueText3.ToString();
        }

        private void button35_Click(object sender, EventArgs e)
        {
            counter34 = counter34 + 1;
            price = counter34 * 220;
            setvalueText1 = "Crispy Broast";
            setvalueText2 = counter34;
            setvalueText3 = price;
            dishlist[33] = setvalueText1;
            dishcount[33] = setvalueText2.ToString();
            dishprice[33] = setvalueText3.ToString();
        }

        private void button31_Click(object sender, EventArgs e)
        {
            counter35 = counter35 + 1;
            price = counter35 * 399;
            setvalueText1 = "Chicken Chilli dry with Rice";
            setvalueText2 = counter35;
            setvalueText3 = price;
            dishlist[34] = setvalueText1;
            dishcount[34] = setvalueText2.ToString();
            dishprice[34] = setvalueText3.ToString();
        }

        private void button36_Click(object sender, EventArgs e)
        {
            counter36 = counter36 + 1;
            price = counter36 * 250;
            setvalueText1 = "Chicken Chowmein";
            setvalueText2 = counter36;
            setvalueText3 = price;
            dishlist[35] = setvalueText1;
            dishcount[35] = setvalueText2.ToString();
            dishprice[35] = setvalueText3.ToString();
        }

        private void button37_Click(object sender, EventArgs e)
        {
            counter37 = counter37 + 1;
            price = counter37 * 399;
            setvalueText1 = "Chicken Jalfrezi with Rice";
            setvalueText2 = counter37;
            setvalueText3 = price;
            dishlist[36] = setvalueText1;
            dishcount[36] = setvalueText2.ToString();
            dishprice[36] = setvalueText3.ToString();
        }

        private void button38_Click(object sender, EventArgs e)
        {
            counter38 = counter38 + 1;
            price = counter38 * 399;
            setvalueText1 = "Chicken Shashlik with Rice";
            setvalueText2 = counter38;
            setvalueText3 = price;
            dishlist[37] = setvalueText1;
            dishcount[37] = setvalueText2.ToString();
            dishprice[37] = setvalueText3.ToString();
        }

        private void button39_Click(object sender, EventArgs e)
        {
            counter39 = counter39 + 1;
            price = counter39 * 399;
            setvalueText1 = "Chicken manchurian With Rice";
            setvalueText2 = counter39;
            setvalueText3 = price;
            dishlist[38] = setvalueText1;
            dishcount[38] = setvalueText2.ToString();
            dishprice[38] = setvalueText3.ToString();
        }

        private void button40_Click(object sender, EventArgs e)
        {
            counter40 = counter40 + 1;
            price = counter40 * 499;
            setvalueText1 = "Baogee's Special";
            setvalueText2 = counter40;
            setvalueText3 = price;
            dishlist[39] = setvalueText1;
            dishcount[39] = setvalueText2.ToString();
            dishprice[39] = setvalueText3.ToString();
        }

        private void button41_Click(object sender, EventArgs e)
        {
            counter41 = counter41 + 1;
            price = counter41 * 399;
            setvalueText1 = "Sweet Sour Chicken with rice";
            setvalueText2 = counter41;
            setvalueText3 = price;
            dishlist[40] = setvalueText1;
            dishcount[40] = setvalueText2.ToString();
            dishprice[40] = setvalueText3.ToString();
        }

        private void button42_Click(object sender, EventArgs e)
        {
            counter42 = counter42 + 1;
            price = counter42 * 200;
            setvalueText1 = "Vegetable Chowmein";
            setvalueText2 = counter42;
            setvalueText3 = price;
            dishlist[41] = setvalueText1;
            dishcount[41] = setvalueText2.ToString();
            dishprice[41] = setvalueText3.ToString();
        }

        private void button43_Click(object sender, EventArgs e)
        {
            counter43 = counter43 + 1;
            price = counter43 * 100;
            setvalueText1 = "Chicken Single Biryani";
            setvalueText2 = counter43;
            setvalueText3 = price;
            dishlist[42] = setvalueText1;
            dishcount[42] = setvalueText2.ToString();
            dishprice[42] = setvalueText3.ToString();
        }

        private void button45_Click(object sender, EventArgs e)
        {
            counter44 = counter44 + 1;
            price = counter44 * 150;
            setvalueText1 = "Egg Fried Rice";
            setvalueText2 = counter44;
            setvalueText3 = price;
            dishlist[43] = setvalueText1;
            dishcount[43] = setvalueText2.ToString();
            dishprice[43] = setvalueText3.ToString();
        }

        private void button46_Click(object sender, EventArgs e)
        {
            counter45 = counter45 + 1;
            price = counter45 * 200;
            setvalueText1 = "Fried Rice";
            setvalueText2 = counter45;
            setvalueText3 = price;
            dishlist[44] = setvalueText1;
            dishcount[44] = setvalueText2.ToString();
            dishprice[44] = setvalueText3.ToString();
        }

        private void button47_Click(object sender, EventArgs e)
        {
            counter46 = counter46 + 1;
            price = counter46 * 300;
            setvalueText1 = "Singaporean Fried Rice";
            setvalueText2 = counter46;
            setvalueText3 = price;
            dishlist[45] = setvalueText1;
            dishcount[45] = setvalueText2.ToString();
            dishprice[45] = setvalueText3.ToString();
        }

        private void button48_Click(object sender, EventArgs e)
        {
            counter47 = counter47 + 1;
            price = counter47 * 150;
            setvalueText1 = "Vegetable Fried rice";
            setvalueText2 = counter47;
            setvalueText3 = price;
            dishlist[46] = setvalueText1;
            dishcount[46] = setvalueText2.ToString();
            dishprice[46] = setvalueText3.ToString();
        }

        private void button44_Click(object sender, EventArgs e)
        {
            counter48 = counter48 + 1;
            price = counter48 * 160;
            setvalueText1 = "Chicken Biryani Double";
            setvalueText2 = counter48;
            setvalueText3 = price;
            dishlist[47] = setvalueText1;
            dishcount[47] = setvalueText2.ToString();
            dishprice[47] = setvalueText3.ToString();
        }

        private void button49_Click(object sender, EventArgs e)
        {
            counter49 = counter49 + 1;
            price = counter49 * 350;
            setvalueText1 = "Chicken Alfredo";
            setvalueText2 = counter49;
            setvalueText3 = price;
            dishlist[48] = setvalueText1;
            dishcount[48] = setvalueText2.ToString();
            dishprice[48] = setvalueText3.ToString();
        }

        private void button50_Click(object sender, EventArgs e)
        {
            counter50 = counter50 + 1;
            price = counter50 * 300;
            setvalueText1 = "Penne Arbiata";
            setvalueText2 = counter50;
            setvalueText3 = price;
            dishlist[49] = setvalueText1;
            dishcount[49] = setvalueText2.ToString();
            dishprice[49] = setvalueText3.ToString();
        }

        private void button51_Click(object sender, EventArgs e)
        {
            counter51 = counter51 + 1;
            price = counter51 * 350;
            setvalueText1 = "Spicy Chicken Alfredo";
            setvalueText2 = counter51;
            setvalueText3 = price;
            dishlist[50] = setvalueText1;
            dishcount[50] = setvalueText2.ToString();
            dishprice[50] = setvalueText3.ToString();
        }

        private void button52_Click(object sender, EventArgs e)
        {
            counter52 = counter52 + 1;
            price = counter52 * 300;
            setvalueText1 = "Afghani Boti";
            setvalueText2 = counter52;
            setvalueText3 = price;
            dishlist[51] = setvalueText1;
            dishcount[51] = setvalueText2.ToString();
            dishprice[51] = setvalueText3.ToString();
        }

        private void button53_Click(object sender, EventArgs e)
        {
            counter53 = counter53 + 1;
            price = counter53 * 1200;
            setvalueText1 = "Bar BQ VIP Sizzlings";
            setvalueText2 = counter53;
            setvalueText3 = price;
            dishlist[52] = setvalueText1;
            dishcount[52] = setvalueText2.ToString();
            dishprice[52] = setvalueText3.ToString();
        }

        private void button55_Click(object sender, EventArgs e)
        {
            counter55 = counter55 + 1;
            price = counter55 * 220;
            setvalueText1 = "Behari Tikka";
            setvalueText2 = counter55;
            setvalueText3 = price;
            dishlist[54] = setvalueText1;
            dishcount[54] = setvalueText2.ToString();
            dishprice[54] = setvalueText3.ToString();
        }

        private void button56_Click(object sender, EventArgs e)
        {
            counter56 = counter56 + 1;
            price = counter56 * 350;
            setvalueText1 = "Chicken Malai Boti";
            setvalueText2 = counter56;
            setvalueText3 = price;
            dishlist[55] = setvalueText1;
            dishcount[55] = setvalueText2.ToString();
            dishprice[55] = setvalueText3.ToString();
        }

        private void button57_Click(object sender, EventArgs e)
        {
            counter57 = counter57 + 1;
            price = counter57 * 300;
            setvalueText1 = "Chicken Reshmi Kabab";
            setvalueText2 = counter57;
            setvalueText3 = price;
            dishlist[56] = setvalueText1;
            dishcount[56] = setvalueText2.ToString();
            dishprice[56] = setvalueText3.ToString();
        }

        private void button58_Click(object sender, EventArgs e)
        {
            counter58 = counter58 + 1;
            price = counter58 * 300;
            setvalueText1 = "Chicken Bihari Boti";
            setvalueText2 = counter58;
            setvalueText3 = price;
            dishlist[57] = setvalueText1;
            dishcount[57] = setvalueText2.ToString();
            dishprice[57] = setvalueText3.ToString();
        }

        private void button59_Click(object sender, EventArgs e)
        {
            counter59 = counter59 + 1;
            price = counter59 * 220;
            setvalueText1 = "Malai Tikka";
            setvalueText2 = counter59;
            setvalueText3 = price;
            dishlist[58] = setvalueText1;
            dishcount[58] = setvalueText2.ToString();
            dishprice[58] = setvalueText3.ToString();
        }

        private void button60_Click(object sender, EventArgs e)
        {
            counter60 = counter60 + 1;
            price = counter60 * 300;
            setvalueText1 = "Chicken Namkeen Boti";
            setvalueText2 = counter60;
            setvalueText3 = price;
            dishlist[59] = setvalueText1;
            dishcount[59] = setvalueText2.ToString();
            dishprice[59] = setvalueText3.ToString();
        }

        private void button61_Click(object sender, EventArgs e)
        {
            counter61 = counter61 + 1;
            price = counter61 * 250;
            setvalueText1 = "Gola Kabab";
            setvalueText2 = counter61;
            setvalueText3 = price;
            dishlist[60] = setvalueText1;
            dishcount[60] = setvalueText2.ToString();
            dishprice[60] = setvalueText3.ToString();
        }

        private void button62_Click(object sender, EventArgs e)
        {
            counter62 = counter62 + 1;
            price = counter62 * 220;
            setvalueText1 = "Green Tikka";
            setvalueText2 = counter62;
            setvalueText3 = price;
            dishlist[61] = setvalueText1;
            dishcount[61] = setvalueText2.ToString();
            dishprice[61] = setvalueText3.ToString();
        }

        private void button63_Click(object sender, EventArgs e)
        {
            counter63 = counter63 + 1;
            price = counter63 * 200;
            setvalueText1 = "Red Tikka";
            setvalueText2 = counter63;
            setvalueText3 = price;
            dishlist[62] = setvalueText1;
            dishcount[62] = setvalueText2.ToString();
            dishprice[62] = setvalueText3.ToString();
        }

        private void button64_Click(object sender, EventArgs e)
        {
            counter64 = counter64 + 1;
            price = counter64 * 350;
            setvalueText1 = "Joja Shashlik Boti";
            setvalueText2 = counter64;
            setvalueText3 = price;
            dishlist[63] = setvalueText1;
            dishcount[63] = setvalueText2.ToString();
            dishprice[63] = setvalueText3.ToString();
        }

        private void button65_Click(object sender, EventArgs e)
        {
            counter65 = counter65 + 1;
            price = counter65 * 1500;
            setvalueText1 = "Baogee's Bar BQ Sizzlings";
            setvalueText2 = counter65;
            setvalueText3 = price;
            dishlist[64] = setvalueText1;
            dishcount[64] = setvalueText2.ToString();
            dishprice[64] = setvalueText3.ToString();
        }

        private void button66_Click(object sender, EventArgs e)
        {
            counter66 = counter66 + 1;
            price = counter66 * 300;
            setvalueText1 = "Turkish Kabab";
            setvalueText2 = counter66;
            setvalueText3 = price;
            dishlist[65] = setvalueText1;
            dishcount[65] = setvalueText2.ToString();
            dishprice[65] = setvalueText3.ToString();
        }

        private void button67_Click(object sender, EventArgs e)
        {
            counter67 = counter67 + 1;
            price = counter67 * 300;
            setvalueText1 = "Beef Bihari Boti";
            setvalueText2 = counter67;
            setvalueText3 = price;
            dishlist[66] = setvalueText1;
            dishcount[66] = setvalueText2.ToString();
            dishprice[66] = setvalueText3.ToString();
        }

        private void button68_Click(object sender, EventArgs e)
        {
            counter68 = counter68 + 1;
            price = counter68 * 100;
            setvalueText1 = "Beef Chatni Roll";
            setvalueText2 = counter68;
            setvalueText3 = price;
            dishlist[67] = setvalueText1;
            dishcount[67] = setvalueText2.ToString();
            dishprice[67] = setvalueText3.ToString();
        }

        private void button69_Click(object sender, EventArgs e)
        {
            counter69 = counter69 + 1;
            price = counter69 * 130;
            setvalueText1 = "Beef Cheese Roll";
            setvalueText2 = counter69;
            setvalueText3 = price;
            dishlist[68] = setvalueText1;
            dishcount[68] = setvalueText2.ToString();
            dishprice[68] = setvalueText3.ToString();
        }

        private void button71_Click(object sender, EventArgs e)
        {
            counter71 = counter71 + 1;
            price = counter71 * 100;
            setvalueText1 = "Chicken Chatni Roll";
            setvalueText2 = counter71;
            setvalueText3 = price;
            dishlist[70] = setvalueText1;
            dishcount[70] = setvalueText2.ToString();
            dishprice[70] = setvalueText3.ToString();
        }

        private void button72_Click(object sender, EventArgs e)
        {
            counter72 = counter72 + 1;
            price = counter72 * 130;
            setvalueText1 = "Chicken Cheese Roll";
            setvalueText2 = counter72;
            setvalueText3 = price;
            dishlist[71] = setvalueText1;
            dishcount[71] = setvalueText2.ToString();
            dishprice[71] = setvalueText3.ToString();
        }

        private void button73_Click(object sender, EventArgs e)
        {
            counter73 = counter73 + 1;
            price = counter73 * 160;
            setvalueText1 = "Crispy Cheese Roll";
            setvalueText2 = counter73;
            setvalueText3 = price;
            dishlist[72] = setvalueText1;
            dishcount[72] = setvalueText2.ToString();
            dishprice[72] = setvalueText3.ToString();
        }

        private void button74_Click(object sender, EventArgs e)
        {
            counter74 = counter74 + 1;
            price = counter74 * 140;
            setvalueText1 = "Crispy Garlic Mayo Roll";
            setvalueText2 = counter74;
            setvalueText3 = price;
            dishlist[73] = setvalueText1;
            dishcount[73] = setvalueText2.ToString();
            dishprice[73] = setvalueText3.ToString();
        }

        private void button75_Click(object sender, EventArgs e)
        {
            counter75 = counter75 + 1;
            price = counter75 * 130;
            setvalueText1 = "Crispy Chatni Roll";
            setvalueText2 = counter75;
            setvalueText3 = price;
            dishlist[74] = setvalueText1;
            dishcount[74] = setvalueText2.ToString();
            dishprice[74] = setvalueText3.ToString();
        }

        private void button76_Click(object sender, EventArgs e)
        {
            counter76 = counter76 + 1;
            price = counter76 * 120;
            setvalueText1 = "Chicken Mayo Garlic Roll";
            setvalueText2 = counter76;
            setvalueText3 = price;
            dishlist[75] = setvalueText1;
            dishcount[75] = setvalueText2.ToString();
            dishprice[75] = setvalueText3.ToString();
        }

        private void button77_Click(object sender, EventArgs e)
        {
            counter77 = counter77 + 1;
            price = counter77 * 100;
            setvalueText1 = "Malai Chatni Roll";
            setvalueText2 = counter77;
            setvalueText3 = price;
            dishlist[76] = setvalueText1;
            dishcount[76] = setvalueText2.ToString();
            dishprice[76] = setvalueText3.ToString();
        }

        private void button78_Click(object sender, EventArgs e)
        {
            counter78 = counter78 + 1;
            price = counter78 * 130;
            setvalueText1 = "Malai Cheese Roll";
            setvalueText2 = counter78;
            setvalueText3 = price;
            dishlist[77] = setvalueText1;
            dishcount[77] = setvalueText2.ToString();
            dishprice[77] = setvalueText3.ToString();
        }

        private void button79_Click(object sender, EventArgs e)
        {
            counter79 = counter79 + 1;
            price = counter79 * 120;
            setvalueText1 = "Malai Garlic Mayo Roll";
            setvalueText2 = counter79;
            setvalueText3 = price;
            dishlist[78] = setvalueText1;
            dishcount[78] = setvalueText2.ToString();
            dishprice[78] = setvalueText3.ToString();
        }

        private void button80_Click(object sender, EventArgs e)
        {
            counter80 = counter80 + 1;
            price = counter80 * 180;
            setvalueText1 = "Baogee's Special Roll";
            setvalueText2 = counter80;
            setvalueText3 = price;
            dishlist[79] = setvalueText1;
            dishcount[79] = setvalueText2.ToString();
            dishprice[79] = setvalueText3.ToString();
        }

        private void button81_Click(object sender, EventArgs e)
        {
            string message = "YES for Full or NO for Half";
            string title = "Select";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                counter81 = counter81 + 1;
                price = counter81 * 1100;
                setvalueText1 = "Baogee's Chicken Full Karahi";
                setvalueText2 = counter81;
                setvalueText3 = price;
                dishlist[80] = setvalueText1;
                dishcount[80] = setvalueText2.ToString();
                dishprice[80] = setvalueText3.ToString();
            }
            else
            {
                counter82 = counter82 + 1;
                price = counter82 * 600;
                setvalueText1 = "Baogee's Chicken Half Karahi";
                setvalueText2 = counter82;
                setvalueText3 = price;
                dishlist[81] = setvalueText1;
                dishcount[81] = setvalueText2.ToString();
                dishprice[81] = setvalueText3.ToString();
            }
        }

        private void button82_Click(object sender, EventArgs e)
        {
            string message = "YES for Full or NO for Half";
            string title = "Select";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                counter83 = counter83 + 1;
                price = counter83 * 950;
                setvalueText1 = "Makhni Chicken Karachi Full";
                setvalueText2 = counter83;
                setvalueText3 = price;
                dishlist[82] = setvalueText1;
                dishcount[82] = setvalueText2.ToString();
                dishprice[82] = setvalueText3.ToString();
            }
            else
            {
                counter84 = counter84 + 1;
                price = counter84 * 500;
                setvalueText1 = "Makhni Chicken Karachi Half";
                setvalueText2 = counter84;
                setvalueText3 = price;
                dishlist[83] = setvalueText1;
                dishcount[83] = setvalueText2.ToString();
                dishprice[83] = setvalueText3.ToString();
            }
        }

        private void button84_Click(object sender, EventArgs e)
        {
            string message = "YES for Full or NO for Half";
            string title = "Select";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                counter87 = counter87 + 1;
                price = counter87 * 1800;
                setvalueText1 = "Peshawari Chicken Karachi Full";
                setvalueText2 = counter87;
                setvalueText3 = price;
                dishlist[86] = setvalueText1;
                dishcount[86] = setvalueText2.ToString();
                dishprice[86] = setvalueText3.ToString();
            }
            else
            {
                counter88 = counter88 + 1;
                price = counter88 * 950;
                setvalueText1 = "Peshawari Chicken Karachi Half";
                setvalueText2 = counter88;
                setvalueText3 = price;
                dishlist[87] = setvalueText1;
                dishcount[87] = setvalueText2.ToString();
                dishprice[87] = setvalueText3.ToString();
            }
        }

        private void button86_Click(object sender, EventArgs e)
        {
            string message = "YES for Full or NO for Half";
            string title = "Select";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                counter91 = counter91 + 1;
                price = counter91 * 2400;
                setvalueText1 = "Prawns Karachi Full";
                setvalueText2 = counter91;
                setvalueText3 = price;
                dishlist[90] = setvalueText1;
                dishcount[90] = setvalueText2.ToString();
                dishprice[90] = setvalueText3.ToString();
            }
            else
            {
                counter92 = counter92 + 1;
                price = counter92 * 1250;
                setvalueText1 = "Prawns Karachi Half";
                setvalueText2 = counter92;
                setvalueText3 = price;
                dishlist[91] = setvalueText1;
                dishcount[91] = setvalueText2.ToString();
                dishprice[91] = setvalueText3.ToString();
            }
        }

        private void button85_Click(object sender, EventArgs e)
        {
            string message = "YES for Full or NO for Half";
            string title = "Select";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                counter95 = counter95 + 1;
                price = counter95 * 1800;
                setvalueText1 = "Peshawari Mutton Karahi Full";
                setvalueText2 = counter95;
                setvalueText3 = price;
                dishlist[94] = setvalueText1;
                dishcount[94] = setvalueText2.ToString();
                dishprice[94] = setvalueText3.ToString();
            }
            else
            {
                counter96 = counter96 + 1;
                price = counter96 * 950;
                setvalueText1 = "Peshawari Mutton Karachi Half";
                setvalueText2 = counter96;
                setvalueText3 = price;
                dishlist[95] = setvalueText1;
                dishcount[95] = setvalueText2.ToString();
                dishprice[95] = setvalueText3.ToString();
            }
        }

        private void button91_Click(object sender, EventArgs e)
        {
            string message = "YES for Full or NO for Half";
            string title = "Select";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                counter97 = counter97 + 1;
                price = counter97 * 950;
                setvalueText1 = "White Chicken Karahi Full";
                setvalueText2 = counter97;
                setvalueText3 = price;
                dishlist[96] = setvalueText1;
                dishcount[96] = setvalueText2.ToString();
                dishprice[96] = setvalueText3.ToString();
            }
            else
            {
                counter98 = counter98 + 1;
                price = counter98 * 500;
                setvalueText1 = "White Chicken Karachi Half";
                setvalueText2 = counter98;
                setvalueText3 = price;
                dishlist[97] = setvalueText1;
                dishcount[97] = setvalueText2.ToString();
                dishprice[97] = setvalueText3.ToString();
            }
        }

        private void button90_Click(object sender, EventArgs e)
        {
            string message = "YES for Full or NO for Half";
            string title = "Select";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                counter99 = counter99 + 1;
                price = counter99 * 1800;
                setvalueText1 = "Sulemani Mutton Karahi Full";
                setvalueText2 = counter99;
                setvalueText3 = price;
                dishlist[98] = setvalueText1;
                dishcount[98] = setvalueText2.ToString();
                dishprice[98] = setvalueText3.ToString();
            }
            else
            {
                counter100 = counter100 + 1;
                price = counter100 * 950;
                setvalueText1 = "Sulemani Mutton Karachi Half";
                setvalueText2 = counter100;
                setvalueText3 = price;
                dishlist[99] = setvalueText1;
                dishcount[99] = setvalueText2.ToString();
                dishprice[99] = setvalueText3.ToString();
            }
        }

        private void button89_Click(object sender, EventArgs e)
        {
            string message = "YES for Full or NO for Half";
            string title = "Select";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                counter101 = counter101 + 1;
                price = counter101 * 950;
                setvalueText1 = "Sulemani Chicken Karahi Full";
                setvalueText2 = counter101;
                setvalueText3 = price;
                dishlist[100] = setvalueText1;
                dishcount[100] = setvalueText2.ToString();
                dishprice[100] = setvalueText3.ToString();
            }
            else
            {
                counter102 = counter102 + 1;
                price = counter102 * 500;
                setvalueText1 = "Sulemani Chicken Karachi Half";
                setvalueText2 = counter102;
                setvalueText3 = price;
                dishlist[101] = setvalueText1;
                dishcount[101] = setvalueText2.ToString();
                dishprice[101] = setvalueText3.ToString();
            }
        }

        private void button92_Click(object sender, EventArgs e)
        {
            counter103 = counter103 + 1;
            price = counter103 * 500;
            setvalueText1 = "Brain Katakat";
            setvalueText2 = counter103;
            setvalueText3 = price;
            dishlist[102] = setvalueText1;
            dishcount[102] = setvalueText2.ToString();
            dishprice[102] = setvalueText3.ToString();
        }

        private void button93_Click(object sender, EventArgs e)
        {
            counter104 = counter104 + 1;
            price = counter104 * 750;
            setvalueText1 = "Mix Katakat";
            setvalueText2 = counter80;
            setvalueText3 = price;
            dishlist[103] = setvalueText1;
            dishcount[103] = setvalueText2.ToString();
            dishprice[103] = setvalueText3.ToString();
        }

        private void button94_Click(object sender, EventArgs e)
        {
            counter105 = counter105 + 1;
            price = counter105 * 850;
            setvalueText1 = "Special Katakat";
            setvalueText2 = counter105;
            setvalueText3 = price;
            dishlist[104] = setvalueText1;
            dishcount[104] = setvalueText2.ToString();
            dishprice[104] = setvalueText3.ToString();
        }

        private void button95_Click(object sender, EventArgs e)
        {
            string message = "YES for Full or NO for Half";
            string title = "Select";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                counter106 = counter106 + 1;
                price = counter106 * 1400;
                setvalueText1 = "Makhni Handi Full";
                setvalueText2 = counter106;
                setvalueText3 = price;
                dishlist[105] = setvalueText1;
                dishcount[105] = setvalueText2.ToString();
                dishprice[105] = setvalueText3.ToString();
            }
            else
            {
                counter107 = counter107 + 1;
                price = counter107 * 750;
                setvalueText1 = "Makhni Handi Half";
                setvalueText2 = counter107;
                setvalueText3 = price;
                dishlist[106] = setvalueText1;
                dishcount[106] = setvalueText2.ToString();
                dishprice[106] = setvalueText3.ToString();
            }
        }

        private void button97_Click(object sender, EventArgs e)
        {
            string message = "YES for Full or NO for Half";
            string title = "Select";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                counter110 = counter110 + 1;
                price = counter110 * 2800;
                setvalueText1 = "Baogee's Special Handi Full";
                setvalueText2 = counter110;
                setvalueText3 = price;
                dishlist[109] = setvalueText1;
                dishcount[109] = setvalueText2.ToString();
                dishprice[109] = setvalueText3.ToString();
            }
            else
            {
                counter111 = counter111 + 1;
                price = counter111 * 1500;
                setvalueText1 = "Baogee's Special Handi Half";
                setvalueText2 = counter111;
                setvalueText3 = price;
                dishlist[110] = setvalueText1;
                dishcount[110] = setvalueText2.ToString();
                dishprice[110] = setvalueText3.ToString();
            }
        }

        private void button99_Click(object sender, EventArgs e)
        {
            string message = "YES for Full or NO for Half";
            string title = "Select";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                counter112 = counter112 + 1;
                price = counter112 * 1400;
                setvalueText1 = "Tikka Masala Handi Full";
                setvalueText2 = counter112;
                setvalueText3 = price;
                dishlist[111] = setvalueText1;
                dishcount[111] = setvalueText2.ToString();
                dishprice[111] = setvalueText3.ToString();
            }
            else
            {
                counter113 = counter113 + 1;
                price = counter113 * 750;
                setvalueText1 = "Tikka Masala Handi Half";
                setvalueText2 = counter113;
                setvalueText3 = price;
                dishlist[112] = setvalueText1;
                dishcount[112] = setvalueText2.ToString();
                dishprice[112] = setvalueText3.ToString();
            }
        }

        private void button98_Click(object sender, EventArgs e)
        {
            counter114 = counter114 + 1;
            price = counter114 * 10;
            setvalueText1 = "Chapati";
            setvalueText2 = counter114;
            setvalueText3 = price;
            dishlist[113] = setvalueText1;
            dishcount[113] = setvalueText2.ToString();
            dishprice[113] = setvalueText3.ToString();
        }

        private void button100_Click_1(object sender, EventArgs e)
        {
            counter115 = counter115 + 1;
            price = counter115 * 100;
            setvalueText1 = "Cheese nan";
            setvalueText2 = counter115;
            setvalueText3 = price;
            dishlist[114] = setvalueText1;
            dishcount[114] = setvalueText2.ToString();
            dishprice[114] = setvalueText3.ToString();
        }

        private void button101_Click(object sender, EventArgs e)
        {
            counter116 = counter116 + 1;
            price = counter116 * 40;
            setvalueText1 = "Garlic nan";
            setvalueText2 = counter116;
            setvalueText3 = price;
            dishlist[115] = setvalueText1;
            dishcount[115] = setvalueText2.ToString();
            dishprice[115] = setvalueText3.ToString();
        }

        private void button102_Click(object sender, EventArgs e)
        {
            counter117 = counter117 + 1;
            price = counter117 * 15;
            setvalueText1 = "Plain nan";
            setvalueText2 = counter117;
            setvalueText3 = price;
            dishlist[116] = setvalueText1;
            dishcount[116] = setvalueText2.ToString();
            dishprice[116] = setvalueText3.ToString();
        }

        private void button103_Click(object sender, EventArgs e)
        {
            counter118 = counter118 + 1;
            price = counter118 * 50;
            setvalueText1 = "Puri Paratha";
            setvalueText2 = counter118;
            setvalueText3 = price;
            dishlist[117] = setvalueText1;
            dishcount[117] = setvalueText2.ToString();
            dishprice[117] = setvalueText3.ToString();
        }

        private void button104_Click(object sender, EventArgs e)
        {
            counter119 = counter119 + 1;
            price = counter119 * 40;
            setvalueText1 = "Dhood Patti";
            setvalueText2 = counter119;
            setvalueText3 = price;
            dishlist[118] = setvalueText1;
            dishcount[118] = setvalueText2.ToString();
            dishprice[118] = setvalueText3.ToString();
        }

        private void button106_Click(object sender, EventArgs e)
        {
            counter121 = counter121 + 1;
            price = counter121 * 100;
            setvalueText1 = "Expresso Coffee";
            setvalueText2 = counter121;
            setvalueText3 = price;
            dishlist[120] = setvalueText1;
            dishcount[120] = setvalueText2.ToString();
            dishprice[120] = setvalueText3.ToString();
        }

        private void button107_Click(object sender, EventArgs e)
        {
            counter122 = counter122 + 1;
            price = counter122 * 40;
            setvalueText1 = "Green Tea";
            setvalueText2 = counter122;
            setvalueText3 = price;
            dishlist[121] = setvalueText1;
            dishcount[121] = setvalueText2.ToString();
            dishprice[121] = setvalueText3.ToString();
        }

        private void button108_Click(object sender, EventArgs e)
        {
            counter123 = counter123 + 1;
            price = counter123 * 50;
            setvalueText1 = "Lemon Grass Tea";
            setvalueText2 = counter123;
            setvalueText3 = price;
            dishlist[122] = setvalueText1;
            dishcount[122] = setvalueText2.ToString();
            dishprice[122] = setvalueText3.ToString();
        }

        private void button109_Click(object sender, EventArgs e)
        {
            counter124 = counter124 + 1;
            price = counter124 * 60;
            setvalueText1 = "Aloo Paratha";
            setvalueText2 = counter124;
            setvalueText3 = price;
            dishlist[123] = setvalueText1;
            dishcount[123] = setvalueText2.ToString();
            dishprice[123] = setvalueText3.ToString();
        }

        private void button110_Click(object sender, EventArgs e)
        {
            counter125 = counter125 + 1;
            price = counter125 * 60;
            setvalueText1 = "Anda Paratha";
            setvalueText2 = counter125;
            setvalueText3 = price;
            dishlist[124] = setvalueText1;
            dishcount[124] = setvalueText2.ToString();
            dishprice[124] = setvalueText3.ToString();
        }

        private void button112_Click(object sender, EventArgs e)
        {
            counter127 = counter127 + 1;
            price = counter127 * 120;
            setvalueText1 = "Cheese Paratha";
            setvalueText2 = counter127;
            setvalueText3 = price;
            dishlist[126] = setvalueText1;
            dishcount[126] = setvalueText2.ToString();
            dishprice[126] = setvalueText3.ToString();
        }

        private void button113_Click(object sender, EventArgs e)
        {
            counter128 = counter128 + 1;
            price = counter128 * 150;
            setvalueText1 = "Chicken Cheese Paratha";
            setvalueText2 = counter128;
            setvalueText3 = price;
            dishlist[127] = setvalueText1;
            dishcount[127] = setvalueText2.ToString();
            dishprice[127] = setvalueText3.ToString();
        }

        private void button114_Click(object sender, EventArgs e)
        {
            counter129 = counter129 + 1;
            price = counter129 * 120;
            setvalueText1 = "Chicken Paratha";
            setvalueText2 = counter129;
            setvalueText3 = price;
            dishlist[128] = setvalueText1;
            dishcount[128] = setvalueText2.ToString();
            dishprice[128] = setvalueText3.ToString();
        }

        private void button115_Click(object sender, EventArgs e)
        {
            counter130 = counter130 + 1;
            price = counter130 * 120;
            setvalueText1 = "Qeema Paratha";
            setvalueText2 = counter130;
            setvalueText3 = price;
            dishlist[129] = setvalueText1;
            dishcount[129] = setvalueText2.ToString();
            dishprice[129] = setvalueText3.ToString();
        }

        private void button116_Click(object sender, EventArgs e)
        {
            counter131 = counter131 + 1;
            price = counter131 * 30;
            setvalueText1 = "Plain Paratha";
            setvalueText2 = counter131;
            setvalueText3 = price;
            dishlist[130] = setvalueText1;
            dishcount[130] = setvalueText2.ToString();
            dishprice[130] = setvalueText3.ToString();
        }

        private void button117_Click(object sender, EventArgs e)
        {
            counter132 = counter132 + 1;
            price = counter132 * 150;
            setvalueText1 = "Qeema Cheese Paratha";
            setvalueText2 = counter132;
            setvalueText3 = price;
            dishlist[131] = setvalueText1;
            dishcount[131] = setvalueText2.ToString();
            dishprice[131] = setvalueText3.ToString();
        }

        private void button118_Click(object sender, EventArgs e)
        {
            counter133 = counter133 + 1;
            price = counter133 * 70;
            setvalueText1 = "Soft drink (500 ml)";
            setvalueText2 = counter133;
            setvalueText3 = price;
            dishlist[132] = setvalueText1;
            dishcount[132] = setvalueText2.ToString();
            dishprice[132] = setvalueText3.ToString();
        }

        private void button119_Click(object sender, EventArgs e)
        {
            counter134 = counter134 + 1;
            price = counter134 * 40;
            setvalueText1 = "Cold drink (250 ml)";
            setvalueText2 = counter134;
            setvalueText3 = price;
            dishlist[133] = setvalueText1;
            dishcount[133] = setvalueText2.ToString();
            dishprice[133] = setvalueText3.ToString();
        }

        private void button120_Click(object sender, EventArgs e)
        {
            counter135 = counter135 + 1;
            price = counter135 * 100;
            setvalueText1 = "Fresh Lime";
            setvalueText2 = counter135;
            setvalueText3 = price;
            dishlist[134] = setvalueText1;
            dishcount[134] = setvalueText2.ToString();
            dishprice[134] = setvalueText3.ToString();
        }

        private void button121_Click(object sender, EventArgs e)
        {
            counter136 = counter136 + 1;
            price = counter136 * 60;
            setvalueText1 = "Cane (345 ml)";
            setvalueText2 = counter136;
            setvalueText3 = price;
            dishlist[135] = setvalueText1;
            dishcount[135] = setvalueText2.ToString();
            dishprice[135] = setvalueText3.ToString();
        }

        private void button122_Click(object sender, EventArgs e)
        {
            counter137 = counter137 + 1;
            price = counter137 * 40;
            setvalueText1 = "Mineral Water Small";
            setvalueText2 = counter137;
            setvalueText3 = price;
            dishlist[136] = setvalueText1;
            dishcount[136] = setvalueText2.ToString();
            dishprice[136] = setvalueText3.ToString();
        }

        private void button123_Click(object sender, EventArgs e)
        {
            counter138 = counter138 + 1;
            price = counter138 * 70;
            setvalueText1 = "Mineral Water 1.5 ltr";
            setvalueText2 = counter138;
            setvalueText3 = price;
            dishlist[137] = setvalueText1;
            dishcount[137] = setvalueText2.ToString();
            dishprice[137] = setvalueText3.ToString();
        }

        private void button124_Click(object sender, EventArgs e)
        {
            counter139 = counter139 + 1;
            price = counter139 * 20;
            setvalueText1 = "Bun";
            setvalueText2 = counter139;
            setvalueText3 = price;
            dishlist[138] = setvalueText1;
            dishcount[138] = setvalueText2.ToString();
            dishprice[138] = setvalueText3.ToString();
        }

        private void button125_Click(object sender, EventArgs e)
        {
            counter140 = counter140 + 1;
            price = counter140 * 30;
            setvalueText1 = "Cheese";
            setvalueText2 = counter140;
            setvalueText3 = price;
            dishlist[139] = setvalueText1;
            dishcount[139] = setvalueText2.ToString();
            dishprice[139] = setvalueText3.ToString();
        }

        private void button126_Click(object sender, EventArgs e)
        {
            counter141 = counter141 + 1;
            price = counter141 * 30;
            setvalueText1 = "Coleslaw";
            setvalueText2 = counter141;
            setvalueText3 = price;
            dishlist[140] = setvalueText1;
            dishcount[140] = setvalueText2.ToString();
            dishprice[140] = setvalueText3.ToString();
        }

        private void button127_Click(object sender, EventArgs e)
        {
            counter142 = counter142 + 1;
            price = counter142 * 40;
            setvalueText1 = "Deep Sauce";
            setvalueText2 = counter142;
            setvalueText3 = price;
            dishlist[141] = setvalueText1;
            dishcount[141] = setvalueText2.ToString();
            dishprice[141] = setvalueText3.ToString();
        }

        private void button128_Click(object sender, EventArgs e)
        {
            Form5 frm5 = new Form5();
            frm5.Show();
        }

        private void button129_Click(object sender, EventArgs e)
        {
            dishlist = new String[142];
            dishcount = new String[142];
            dishprice = new String[142];
            counter1 = 0;
            counter2 = 0;
            counter3 = 0;
            counter4 = 0;
            counter5 = 0;
            counter6 = 0;
            counter7 = 0;
            counter8 = 0;
            counter9 = 0;
            counter10 = 0;
            counter11 = 0;
            counter12 = 0;
            counter13 = 0;
            counter14 = 0;
            counter15 = 0;
            counter16 = 0;
            counter17 = 0;
            counter18 = 0;
            counter19 = 0;
            counter20 = 0;
            counter21 = 0;
            counter22 = 0;
            counter23 = 0;
            counter24 = 0;
            counter25 = 0;
            counter26 = 0;
            counter27 = 0;
            counter28 = 0;
            counter29 = 0;
            counter30 = 0;
            counter31 = 0;
            counter32 = 0;
            counter33 = 0;
            counter34 = 0;
            counter35 = 0;
            counter36 = 0;
            counter37 = 0;
            counter38 = 0;
            counter39 = 0;
            counter40 = 0;
            counter41 = 0;
            counter42 = 0;
            counter43 = 0;
            counter44 = 0;
            counter45 = 0;
            counter46 = 0;
            counter47 = 0;
            counter48 = 0;
            counter49 = 0;
            counter50 = 0;
            counter51 = 0;
            counter52 = 0;
            counter53 = 0;
            counter54 = 0;
            counter55 = 0;
            counter56 = 0;
            counter57 = 0;
            counter58 = 0;
            counter59 = 0;
            counter60 = 0;
            counter61 = 0;
            counter62 = 0;
            counter63 = 0;
            counter64 = 0;
            counter65 = 0;
            counter66 = 0;
            counter67 = 0;
            counter68 = 0;
            counter69 = 0;
            counter70 = 0;
            counter71 = 0;
            counter72 = 0;
            counter73 = 0;
            counter74 = 0;
            counter75 = 0;
            counter76 = 0;
            counter77 = 0;
            counter78 = 0;
            counter79 = 0;
            counter80 = 0;
            counter81 = 0;
            counter82 = 0;
            counter83 = 0;
            counter84 = 0;
            counter85 = 0;
            counter86 = 0;
            counter87 = 0;
            counter88 = 0;
            counter89 = 0;
            counter90 = 0;
            counter91 = 0;
            counter92 = 0;
            counter93 = 0;
            counter94 = 0;
            counter95 = 0;
            counter96 = 0;
            counter97 = 0;
            counter98 = 0;
            counter99 = 0;
            counter100 = 0;
            counter101 = 0;
            counter102 = 0;
            counter103 = 0;
            counter104 = 0;
            counter105 = 0;
            counter106 = 0;
            counter107 = 0;
            counter108 = 0;
            counter109 = 0;
            counter110 = 0;
            counter111 = 0;
            counter112 = 0;
            counter113 = 0;
            counter114 = 0;
            counter115 = 0;
            counter116 = 0;
            counter117 = 0;
            counter118 = 0;
            counter119 = 0;
            counter120 = 0;
            counter121 = 0;
            counter122 = 0;
            counter123 = 0;
            counter124 = 0;
            counter125 = 0;
            counter126 = 0;
            counter127 = 0;
            counter128 = 0;
            counter129 = 0;
            counter130 = 0;
            counter131 = 0;
            counter132 = 0;
            counter133 = 0;
            counter134 = 0;
            counter135 = 0;
            counter136 = 0;
            counter137 = 0;
            counter138 = 0;
            counter139 = 0;
            counter140 = 0;
            counter141 = 0;
            counter142 = 0;
    }
    }
}
