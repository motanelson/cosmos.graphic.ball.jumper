using Cosmos.System.Graphics;
using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using Cosmos.System.Graphics;
using Sys = Cosmos.System;
using System.Security.Cryptography;
using System.Threading;
using Cosmos.Core.IOGroup;

namespace Cball
{
    class graf
    {
        public static Canvas canvas;
        public static Bitmap bitmap;

        public static void Points(int x, int y)
        {


            Pen p = new Pen(Color.FromArgb(0, 0, 0));
            canvas.DrawPoint(p, x, y);





        }

        public static void starts()
        {


            canvas = FullScreenCanvas.GetFullScreenCanvas();
            Sys.MouseManager.ScreenWidth = (uint)1020;
            Sys.MouseManager.ScreenHeight = (uint)798;



        }
        public static void displays()
        {

            canvas.Display();


        }
        public static void cls(Color c)
        {


            canvas.Clear(c);

        }

    }


    public class Kernel : Sys.Kernel
    {
        static int x = 0; static int y = 0;
        protected override void BeforeRun()
        {
            Console.WriteLine("Cosmos booted successfully. Type a line of text to get it echoed back.");
        }

        protected override void Run()
        {
            while (true)
            {
                graf.starts();

                while (true)
                {
                    Thread.Sleep(200);

                    tests.mainLoop();



                    ;

                }
            }


        }
    }





    class tests



    {
        static int x=80;static int y=80;static int xxx = 10;static int yyy = 10;

        public static void mainLoop()
        {
            //


            Pen p = new Pen(Color.Black, 1);
            graf.canvas.Clear(Color.White);

            
            graf.canvas.DrawCircle(p,x,y,60);
            x = x + xxx;
            y= y + yyy;
            if (x > 940 || x < 70) xxx = -xxx;
            if (y > 650 || y < 70) yyy = -yyy;

            graf.displays();
            

        }

    }





}
