 using System;
using System.Drawing;
using System.IO;
using System.Text;
namespace Common
{
    public class ImageDValidate
    {
        int n;

        public ImageDValidate(int x)
        {
            n = x;

        }
        public string GetCode()
        {
            string a = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            StringBuilder sb = new StringBuilder();
            //随机生成字符串
            for (int i = 0; i < n; i++)
            {
                sb.Append(a[new Random(Guid.NewGuid().GetHashCode()).Next(0, a.Length - 1)]);
            }

            return sb.ToString();
        }

        public MemoryStream GetImageCode(string Str)
        {
            //num1获取文字长度计算出图片宽度
            int num1 = Convert.ToInt32((double)(Str.Length * 17));
            //num2图片高度
            int num2 = 24;
            //定义图片
            Bitmap bitmap1 = new Bitmap(num1, num2);
            //定义画板
            Graphics graphics1 = Graphics.FromImage(bitmap1);
            //清空画板
            graphics1.Clear(Color.White);
            //文字颜色集
            Color[] colorArray1 = new Color[] { Color.Black, Color.Red, Color.DarkBlue, Color.Green, Color.Brown, Color.DarkCyan, Color.Purple };
            //线条颜色集
            Color[] colorArray2 = new Color[] { Color.LightBlue, Color.LightCoral, Color.LightCyan, Color.LightGoldenrodYellow, Color.LightGray, Color.LightGreen, Color.LightPink, Color.LightSalmon, Color.LightSeaGreen, Color.LightSkyBlue, Color.LightYellow };
            //定义随机变量
            Random random1 = new Random();
            //定义画笔
            Pen pen1 = new Pen(Color.LightBlue, 0f);
            //定义线条数
            int num3 = 20;
            for (int num4 = 0; num4 < num3; num4++)
            {
                //定义画笔颜色
                pen1 = new Pen(colorArray2[random1.Next(11)], 0f);
                //定义四点
                Point point1 = new Point(random1.Next(num1), random1.Next(num2));
                Point point2 = new Point(random1.Next(num1), random1.Next(num2));
                Point point3 = new Point(random1.Next(num1), random1.Next(num2));
                Point point4 = new Point(random1.Next(num1), random1.Next(num2));
                //画出曲线
                graphics1.DrawBezier(pen1, point1, point2, point3, point4);
            }
            //存放字符
            string text1 = string.Empty;
            //字符位置每次间隔15
            int num5 = 2;
            for (int num6 = 0; num6 < Str.Length; num6++)
            {
                //获取字符
                text1 = Str.Substring(num6, 1);
                //画出字符                            字体                                   画笔                                   X           Y
                graphics1.DrawString(text1, new Font("Arial", 12f, FontStyle.Italic | FontStyle.Bold), new SolidBrush(colorArray1[random1.Next(6)]), (float)num5, 2f);
                num5 += 15;
            }
            MemoryStream ms = new MemoryStream();
            //保存成流
            bitmap1.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            return ms;
        }
    }
}