using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;


namespace Form_sort
{
    public partial class Form1 : Form
    {
        Graphics bb_g;
        Graphics ins_g;
        bool bb_can;
        bool ins_can;
        Bubble bb = new Bubble();
        Insert ins = new Insert();
        
        

        static public int[] RandomNum(int n)
        {
            Random rd = new Random();
            int[] a = new int[n];
            a[0] = rd.Next(5);

            for (int i = 1; i < n; i++)
            {
                a[i] =  rd.Next(100);
            }
            return a;
        }

        public Form1()
        {
            InitializeComponent();
            bb_can = false;
            ins_can = false;
            bb_g = Bubble_panel.CreateGraphics();
            ins_g = Insert_panel.CreateGraphics();
            
        }
        public class Sort
        {
            public void vemang(int[] arr, Graphics g)
            {
                int n = arr.Length;
                int w = 10;
                for (int i = 0; i < n; i++)
                {

                    g.DrawRectangle(Pens.BlueViolet, i * 10, 0, w, arr[i]);
                }
            }

        };
        public class Bubble : Sort
        {

            int fps = 50;
            public void bb_sort(int[] arr, Graphics g)
            {
                int n = arr.Length;

                for (int i = 0; i < n - 1; i++)
                {
                    for (int j = 0; j < n - i - 1; j++)
                    {
                        if (arr[j] > arr[j + 1])
                        {
                            
                            int temp = arr[j];
                            arr[j] = arr[j + 1];
                            arr[j + 1] = temp;
                        }
                        g.Clear(Color.White);
                        
                        vemang(arr, g);
                        Thread.Sleep(fps);
                        

                    }

                }

            }

        }
        public class Insert : Sort
        {
            int fps = 100;
            public void ins_sort(int[] arr, Graphics g)
            {
                int n = arr.Length;
                //dat thoi gian
                //tu chay timer




                for (int i = 1; i < n; ++i)
                {
                    int key = arr[i];
                    int j = i - 1;

                    // Move elements of arr[0..i-1],
                    // that are greater than key,
                    // to one position ahead of
                    // their current position
                    while (j >= 0 && arr[j] > key)
                    {
                        arr[j + 1] = arr[j];
                        j = j - 1;
                    }
                    g.Clear(Color.White);
                    vemang(arr, g);
                    // goi tick de ve mang
                    Thread.Sleep(fps);
                    //timer1.Tick = vemang(arr, g);
                    arr[j + 1] = key;
                }
            }
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            Bubble_button.Enabled = false;
           
            if (Bubble_button.Text == "Delete")
            {
                Bubble_button.Text = "Sort";
            }
            else
            {
                Bubble_button.Text = "Sorting ...";
            }
            int n = 10;
            int[] arr1 = RandomNum(n);
            int[] arr2 = new int[n];
            Array.Copy(arr1, arr2, arr1.Length);
            //bb.bb_sort(arr, bb_g);
            Task t1 = new Task(() =>
            {
                if (bb_can == false)
                {

                    ///tạo bubble sort
                    bb.bb_sort(arr1, bb_g);

                    //bb_g.DrawLine(Pens.Black, 0, 0, 100, 100);
                    bb_can = true;
                }
                else
                {
                    bb_g.Clear(Color.White);
                    bb_can = false;
                }
            }
            );
            Task t2 = new Task(
                    () => {
                        if (ins_can == false)
                        {
                            ins_g = Insert_panel.CreateGraphics();
                            ///tạo bubble sort

                            ins.ins_sort(arr2, ins_g);
                            //bb_g.DrawLine(Pens.Black, 0, 0, 100, 100);
                            ins_can = true;
                        }
                        else
                        {
                            ins_g.Clear(Color.White);
                            ins_can = false;
                        }

                    }
                    );
            t1.Start();
            
            t2.Start();
            Task.WaitAll(t1, t2);
            Bubble_button.Enabled = true;
            if (Bubble_button.Text == "Sorting ...")
            {
                Bubble_button.Text = "Delete";
            }

        }

        

        
    }
}
