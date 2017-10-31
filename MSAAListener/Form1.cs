using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Runtime.InteropServices;
using System.Windows.Forms;


namespace MSAAListener
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        internal struct POINT
        {
            public int x;
            public int y;
            public POINT(int x, int y)
            {
                this.x = x;
                this.y = y;
            }
        }

        [DllImport("User32.dll")]
        private static extern bool GetCursorPos(out POINT lpPoint);

        [DllImport("User32.dll", ExactSpelling = true, CharSet = CharSet.Auto)]
        private static extern IntPtr WindowFromPhysicalPoint(POINT pt);

        internal enum OBJID : uint
        {
            WINDOW = 0x00000000,
            SYSMENU = 0xFFFFFFFF,
            TITLEBAR = 0xFFFFFFFE,
            MENU = 0xFFFFFFFD,
            CLIENT = 0xFFFFFFFC,
            VSCROLL = 0xFFFFFFFB,
            HSCROLL = 0xFFFFFFFA,
            SIZEGRIP = 0xFFFFFFF9,
            CARET = 0xFFFFFFF8,
            CURSOR = 0xFFFFFFF7,
            ALERT = 0xFFFFFFF6,
            SOUND = 0xFFFFFFF5,
        }

        [DllImport("oleacc.dll")]
        internal static extern int AccessibleObjectFromWindow(
              IntPtr hwnd,
              uint id,
              ref Guid iid,
              [In, Out, MarshalAs(UnmanagedType.IUnknown)] ref object ppvObject);

        private Thread workerThread = null;
        private readonly AutoResetEvent isCanceled = new AutoResetEvent(false);
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;

        delegate void SetTextCallback(string text);
        private void SetText(string text)
        {
            if (this.label1.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.label1.Text = text;
            }
        }

        private void SetText2(string text)
        {
            if (this.label2.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText2);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.label2.Text = text;
            }
        }

        private void BackgroundTask()
        {
            for (; !isCanceled.WaitOne(0);)
            {
                POINT pt;
                GetCursorPos(out pt);
                IntPtr hWnd = WindowFromPhysicalPoint(pt);
                SetText(String.Format("{0:X}", hWnd.ToInt32()));

                object pvObject = null;
                Guid IID_IAccessible = new Guid("{618736E0-3C3D-11CF-810C-00AA00389B71}");
                int aaVal = AccessibleObjectFromWindow(hWnd, (uint)OBJID.WINDOW, ref IID_IAccessible, ref pvObject);

                dynamic accessible = pvObject;
                SetText2(accessible.accName);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            #region Form1 Initialization

            this.SuspendLayout();

            this.label1 = new System.Windows.Forms.Label();
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            this.Controls.Add(this.label1);

            this.label2 = new System.Windows.Forms.Label();
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            this.Controls.Add(this.label2);

            this.ResumeLayout();

            #endregion Form1 Initialization

            workerThread = new Thread(BackgroundTask);
            workerThread.IsBackground = true;
            workerThread.Name = "Background Task";
            workerThread.Start();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            workerThread.Abort();
        }
    }
}
