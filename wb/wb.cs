using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

/// Just use "csc wb.cs" to compile this project

namespace wb
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
	
	class Form1: Form
	{
		private System.ComponentModel.IContainer components = null;
		private Button btnInvoke = null;
		private WebBrowser webbrowser1 = null;
		
		protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
		
		private void Form1_Load(object sender, EventArgs e)
        {
			//MessageBox.Show("Load");
			this.webbrowser1.Navigate(AppDomain.CurrentDomain.BaseDirectory + "dblclick.html");
        }
		
		private void btnInvoke_Click(object sender, EventArgs e)
        {
			//MessageBox.Show("Invoke");
			HtmlElement element = this.webbrowser1.Document.GetElementById("btnSample");
			element.InvokeMember("ondblclick");
        }
		
		private void InitializeComponent()
        {
			this.btnInvoke = new Button();
			this.webbrowser1 = new WebBrowser();
			this.SuspendLayout();

			this.btnInvoke.Location = new System.Drawing.Point(5, 5);
			this.btnInvoke.Size = new System.Drawing.Size(120, 25);
			this.btnInvoke.Name = "btnInvoke";
			this.btnInvoke.Text = "Invoke";
			this.btnInvoke.TabIndex = 0;
            this.btnInvoke.UseVisualStyleBackColor = true;
            this.btnInvoke.Click += new System.EventHandler(this.btnInvoke_Click);
			
			this.webbrowser1.Location = new System.Drawing.Point(5, 30);
			this.webbrowser1.Size = new System.Drawing.Size(280, 230);
			this.webbrowser1.Name = "webbrowser1";
			this.webbrowser1.TabIndex = 1;
            this.webbrowser1.TabStop = false;
			
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 260);
            this.Controls.Add(this.btnInvoke);
            this.Controls.Add(this.webbrowser1);
            this.Name = "Form1";
            this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			
			this.ResumeLayout(false);
		}
		
		public Form1()
        {
            InitializeComponent();
        }
	}
}