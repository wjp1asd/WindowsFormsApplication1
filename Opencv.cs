using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using Emgu.CV.Util;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Opencv : Form
    {
        public Opencv()
        {
            InitializeComponent();
        }

        private void Opencv_Load(object sender, EventArgs e)
        {
            ///图片颜色识别
            //Mat srcImg = CvInvoke.Imread(@"C:\Users\U59021\OneDrive - Bühler\Desktop\opencv\z.png");
            //CvInvoke.Imshow("input", srcImg);

            //Mat hsvImg = new Mat();
            //Mat mask = new Mat();

            // double h_min = 81, s_min = 77, v_min = 93;
            // double h_max = 125, s_max = 255, v_max = 255;
            //ScalarArray hsv_min = new ScalarArray(new MCvScalar(h_min, s_min, v_min));
            //ScalarArray hsv_max = new ScalarArray(new MCvScalar(h_max, s_max, v_max));

            //CvInvoke.CvtColor(srcImg, hsvImg, ColorConversion.Bgr2Hsv);
            //CvInvoke.InRange(hsvImg, hsv_min, hsv_max, mask);   //输出为符合要求的图像掩膜
            //CvInvoke.MedianBlur(mask, mask, 5);
            //CvInvoke.Imshow("mask", mask);
            //VectorOfVectorOfPoint contours = new VectorOfVectorOfPoint();
            //VectorOfRect hierarchy = new VectorOfRect();

            //CvInvoke.FindContours(mask, contours,hierarchy, RetrType.External, ChainApproxMethod.ChainApproxNone);
            //VectorOfVectorOfPoint contours_approx = new VectorOfVectorOfPoint(contours.Size);
            //Rectangle rect = new Rectangle();
            //for (int i =0; i < contours.Size;i++)
            //{
            //    CvInvoke.ApproxPolyDP(contours[i], contours_approx[i], 3, true);
            //    CvInvoke.DrawContours(srcImg, contours_approx, i, new MCvScalar(255, 0, 0), 1, LineType.EightConnected, hierarchy, 0);
            //    CvInvoke.Imshow("red", srcImg);
            //   rect = CvInvoke.BoundingRectangle(contours_approx[i]);
            //   CvInvoke.Rectangle(srcImg, rect, new MCvScalar(0, 0, 255), 1);
            //    CvInvoke.PutText(srcImg, "blue", new Point(rect.X, rect.Y), FontFace.HersheyComplexSmall, 1.2, new MCvScalar(0, 255, 0));
            //}
            //CvInvoke.WaitKey(0);
            VideoCapture cap = new VideoCapture(0);
            if (!cap.IsOpened)     //打开文件失败
            {
                Console.WriteLine("Open video failed!");
                return;
            }
            Mat frame = new Mat();
            while (true)
            {
                frame = cap.QueryFrame();   //实验读取到最后一帧有异常
                cap.Read(frame);
                if (frame.IsEmpty)
                {
                    Console.WriteLine("frame is empty...");
                    break;
                }
                Mat hsvimg = new Mat();
                Mat mask_red = new Mat();
                Mat mask_green = new Mat();

                double h_min_red = 0, s_min_red = 127, v_min_red = 128;
                double h_max_red = 10, s_max_red = 255, v_max_red = 255;

                double h_min_green = 35, s_min_green = 110, v_min_green = 106;
                double h_max_green = 77, s_max_green = 255, v_max_green = 255;

                ScalarArray hsv_min_red = new ScalarArray(new MCvScalar(h_min_red, s_min_red, v_min_red));
                ScalarArray hsv_max_red = new ScalarArray(new MCvScalar(h_max_red, s_max_red, v_max_red));
                ScalarArray hsv_min_green = new ScalarArray(new MCvScalar(h_min_green, s_min_green, v_min_green));
                ScalarArray hsv_max_green = new ScalarArray(new MCvScalar(h_max_green, s_max_green, v_max_green));

                CvInvoke.CvtColor(frame, hsvimg, ColorConversion.Bgr2Hsv);
                CvInvoke.InRange(hsvimg, hsv_min_red, hsv_max_red, mask_red);
                CvInvoke.InRange(hsvimg, hsv_min_green, hsv_max_green, mask_green);
                CvInvoke.MedianBlur(mask_red, mask_red, 5);
                CvInvoke.MedianBlur(mask_green, mask_green, 5);

                Mat mask = new Mat();
                CvInvoke.Add(mask_red, mask_green, mask);  //掩膜相加
                CvInvoke.Imshow("mask", mask);          //显示合在一起的掩膜

                VectorOfVectorOfPoint contours_red = new VectorOfVectorOfPoint();
                VectorOfRect hierachy_red = new VectorOfRect();
                CvInvoke.FindContours(mask_red, contours_red, hierachy_red, RetrType.External, ChainApproxMethod.ChainApproxNone);

                for (int i = 0; i < contours_red.Size; i++)
                {
                    Rectangle rect = CvInvoke.BoundingRectangle(contours_red[i]);
                    if (rect.Width < 10 || rect.Height < 10)                //对于太小的外接矩形，删除掉
                        continue;
                    CvInvoke.Rectangle(frame, rect, new MCvScalar(255, 0, 0), 1);
                    CvInvoke.PutText(frame, "red", new Point(rect.X, rect.Y - 5), FontFace.HersheyComplexSmall, 1.2, new MCvScalar(0, 255, 0));
                }

                VectorOfVectorOfPoint contours_green = new VectorOfVectorOfPoint();
                VectorOfRect hierachy_green = new VectorOfRect();
                CvInvoke.FindContours(mask_green, contours_green, hierachy_green, RetrType.External, ChainApproxMethod.ChainApproxNone);

                for (int i = 0; i < contours_green.Size; i++)
                {
                    Rectangle rect = CvInvoke.BoundingRectangle(contours_green[i]);
                    if (rect.Width < 10 || rect.Height < 10)                //对于太小的外接矩形，删除掉
                        continue;
                    CvInvoke.Rectangle(frame, rect, new MCvScalar(255, 0, 0), 1);
                    CvInvoke.PutText(frame, "green", new Point(rect.X, rect.Y - 5), FontFace.HersheyComplexSmall, 1.2, new MCvScalar(0, 255, 0));
                }
                CvInvoke.Imshow("hsv_track", frame);
                if (CvInvoke.WaitKey(30) == 27)
                {
                    break;
                }
            }

        }



    }

}
