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
        //?? tạo mảng  random
        int[] arr = { 64, 34, 25, 12, 22, 11, 90, 50 };
        public Form1()
        {
            InitializeComponent();
            bb_can = false;
        
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
           
            public void bb_sort(int[] arr, Graphics g)
            {
                int n = arr.Length;

                for (int i = 0; i < n - 1; i++)
                {
                    for (int j = 0; j < n - i - 1; j++)
                    {
                        if (arr[j] > arr[j + 1])
                        {
                            // swap temp and arr[i]
                            int temp = arr[j];
                            arr[j] = arr[j + 1];
                            arr[j + 1] = temp;
                        }
                        g.Clear(Color.White);
                        
                        vemang(arr, g);
                        Thread.Sleep(1000);
                        //timer1.Tick += timer1_Tick;

                    }

                }

            }
        }
        public class Insert : Sort
        {
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
                    Thread.Sleep(1000);
                    //timer1.Tick = vemang(arr, g);
                    arr[j + 1] = key;
                }
            }
        }
        Bubble bb = new Bubble();
        Insert ins = new Insert();
        private void button1_Click(object sender, EventArgs e)
        {
            Task t1 = new Task(
                    () => {
                        if (bb_can == true)
                        {
                            bb_g = Bubble_panel.CreateGraphics();
                            ///tạo bubble sort
                            bb.bb_sort(arr, bb_g);

                            //bb_g.DrawLine(Pens.Black, 0, 0, 100, 100);
                            bb_can = false;
                        }
                        else
                        {
                            // bb_g.Clear(Color.White);
                            bb_can = true;
                        }
                    });
            t1.Start();
           
        }

        private void Insert_button_Click(object sender, EventArgs e)
        {
            Task t2 = new Task(
                    () => {
                        if (ins_can == true)
                        {
                            ins_g = Insert_panel.CreateGraphics();
                            ///tạo bubble sort

                            ins.ins_sort(arr, ins_g);
                            //bb_g.DrawLine(Pens.Black, 0, 0, 100, 100);
                            ins_can = false;
                        }
                        else
                        {
                            // ins_g.Clear(Color.White);
                            ins_can = true;
                        }

                    }
                    );
            t2.Start();
            
        }

        
    }
}
