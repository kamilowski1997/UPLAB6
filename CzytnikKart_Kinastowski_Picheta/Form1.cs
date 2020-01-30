
using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PCSC;


namespace CzytnikKart_Kinastowski_Picheta
{
    public partial class Form1 : Form
    {
        private static SCardContext mySContext;
        private static SCardReader mySReader;
        private static System.IntPtr myProtocol;
        string[] list;

        public Form1()
        {
            InitializeComponent();
        }

        private void BConnect_Click(object sender, EventArgs e)
        {
            mySContext = new SCardContext();
            mySContext.Establish(SCardScope.System);
            mySReader = new SCardReader(mySContext);
            list = mySContext.GetReaders();
            mySReader.Connect(list[0], SCardShareMode.Shared, SCardProtocol.T0 | SCardProtocol.T1);

            if (mySReader.ActiveProtocol == SCardProtocol.T0)
            {
                myProtocol = SCardPCI.T0;
            }
            if (mySReader.ActiveProtocol == SCardProtocol.T1)
            {
                myProtocol = SCardPCI.T1;
            }
            label1.Text = "connected to " + list[0];

        }

        private void BDisconnect_Click(object sender, EventArgs e)
        {
            mySReader.Disconnect(SCardReaderDisposition.Unpower);
            label1.Text = "not connected";
        }

        private void BSendCommand_Click(object sender, EventArgs e)
        {
            byte[] sendBytes = new byte[256];
            byte[] receiveBytes = new byte[256];
            sendBytes = StringToByteArray(richTextBox1.Text);
            mySReader.Transmit(myProtocol, sendBytes, ref receiveBytes);

            richTextBox2.Text += "odpowiedź: ";
            for (int i = 0; i < receiveBytes.Length; i++)
            {
                richTextBox2.Text += String.Format("{0:X2}", receiveBytes[i]) + " ";
            }
            richTextBox2.Text += "\n";
        
            richTextBox2.Text += System.Text.Encoding.ASCII.GetString(receiveBytes);//receiveBytes[i];

            richTextBox2.Text += "\n";

        }

        public static byte[] StringToByteArray(string hex)
        {
            return Enumerable.Range(0, hex.Length)
                             .Where(x => x % 2 == 0)
                             .Select(x => Convert.ToByte(hex.Substring(x, 2), 16))
                             .ToArray();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
//A0F2000001

//A0A4000000026F3C
//A0C000000F

//A0A40000027F10
//A0A40000026F3A
