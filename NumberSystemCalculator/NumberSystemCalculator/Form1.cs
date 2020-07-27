using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumberSystemCalculator
{


    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            rtbResult.Clear();
            binaryToHex();
        }

        //binary to hex
        private void binaryToHex()
        {
            string number1 = txtNum1.ToString();
            List<string> myList = new List<string>();
            int i = 3;



            do
            {
                foreach (var item in number1.splitByIndex(i))
                {
                    myList.Add(item);
                    rtbResult.AppendText(item + "\n");
                }
            } while (i == i);



        }

       
    }
    public static class StringExtensions
    {
        public static IEnumerable<string> splitByIndex(this string @string, params int[] indexs)
        {
            var previousIndex = 0;
            foreach (var index in indexs.OrderBy(i => i))
            {
                yield return @string.Substring(previousIndex, index - previousIndex);
                previousIndex = index;
            }

            yield return @string.Substring(previousIndex);
        }
    }
}
