using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
/// Just use "csc pastefile.cs" to compile this project

namespace pastefile
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
		const string filename = @"C:\Downloads\ASPAJAXExtSetup.msi";
		FileStream fs = new FileStream(filename, FileMode.Open);
		
		private System.ComponentModel.IContainer components = null;
		private Button btnInvoke = null;
		
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
        }
		
		private void btnInvoke_Click(object sender, EventArgs e)
        {
			//MessageBox.Show("Invoke");
			try
			{
                StringCollection filelist = new StringCollection();
                filelist.Add(filename);
                Clipboard.Set​File​Drop​List(filelist);
            }
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
        }
		
		private void InitializeComponent()
        {
			this.btnInvoke = new Button();
			this.SuspendLayout();

			this.btnInvoke.Location = new System.Drawing.Point(5, 5);
			this.btnInvoke.Size = new System.Drawing.Size(120, 25);
			this.btnInvoke.Name = "btnInvoke";
			this.btnInvoke.Text = "Invoke";
			this.btnInvoke.TabIndex = 0;
            this.btnInvoke.UseVisualStyleBackColor = true;
            this.btnInvoke.Click += new System.EventHandler(this.btnInvoke_Click);
			
			
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 260);
            this.Controls.Add(this.btnInvoke);
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
