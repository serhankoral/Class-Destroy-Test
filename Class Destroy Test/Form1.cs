using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Class_Destroy_Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "Test";
            this.button1.Text = "Class Oluştur";
            this.button2.Text = "Class Destroy";
            
        }        
      
        private void button1_Click(object sender, EventArgs e)
        {
            MyClass1 myClass = new MyClass1();  
            MyClass2 myClass2 = new MyClass2();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GC.Collect();
            
        }
    }
    class MyClass1
    {
         public MyClass1()
        {
            MessageBox.Show("MyClass Created 1");
        }
         ~MyClass1()
        {
            MessageBox.Show("MyClass Destroy 1");
        }

    }
    class MyClass2
    {
        public MyClass2()
        {
            MessageBox.Show("MyClass Created 2");
        }
        ~MyClass2()
        {
            MessageBox.Show("MyClass Destroy 2");
        }

    }
}
