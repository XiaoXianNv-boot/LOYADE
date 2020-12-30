using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Drawing.Imaging;

namespace LOYADE
{
    public class ActionImageComparator
    {
        private bool _issame;
        public bool IsSame { get { return _issame; } }

        private float _result;
        public float Result { get { return _result; } }

        public ActionImageComparator(Image actualImage, Image expectedImage)
        {
            _issame = false;
            _result = ImgComp(actualImage, expectedImage);
            if (1 == _result)
                _issame = true;
        }

        public ActionImageComparator(string actualImageFile, string expectedImageFile)
        {
            Image actualImage = Image.FromFile(actualImageFile);
            Image expectedImage = Image.FromFile(expectedImageFile);
            _issame = false;
            _result = ImgComp(actualImage, expectedImage);
            if (1 == _result)
                _issame = true;
        }

        /// <summary>
        /// 比较两张图片是否一致
        /// </summary>
        /// <param name="actualImage">被测图片</param>
        /// <param name="expectedImage">参照图片</param>
        /// <returns>如果为真，两张图片一样否则不一样</returns>
        public float ImgComp(Image actualImage, Image expectedImage)
        {
            //现将两张图片都变成256 X 256 大小
            Bitmap actualBmp = Resize(actualImage);
            Bitmap expectBmp = Resize(expectedImage);

            //获取转换后的图片的直方图
            int[] actualHisogram = GetHisogram(actualBmp);
            int[] expectHisogram = GetHisogram(expectBmp);

            //比较两个直方图数据的相似性
            return GetFinalResult(actualHisogram, expectHisogram);

            //如果仅仅只是要比较两个直方图是不是一样的，完全可以比较数组中相应的index的元素是不是相等即可
        }

        /// <summary>
        /// 将图片的转化为目标大小并返回转化后的图片
        /// </summary>
        /// <param name="originImage">待转化图片</param>
        /// <param name="width">转化后的宽度</param>
        /// <param name="height">转化后的高度</param>
        /// <returns>转化后的图片</returns>
        private Bitmap Resize(Image originImage, int width, int height)
        {
            Bitmap outImg = new Bitmap(originImage, width, height);
            //outImg.Dispose();
            return outImg;
        }

        /// <summary>
        /// 将图片转化为256 X 256大小并返回转化后的图片
        /// </summary>
        /// <param name="originImage">待转化图片</param>
        /// <returns>转化后的图片</returns>
        private Bitmap Resize(Image originImage)
        {
            return Resize(originImage, 256, 256);

        }

        /// <summary>
        /// 获取位图文件的直方图数据
        /// </summary>
        /// <param name="bmpImg">位图文件</param>
        /// <returns>位图文件的直方图数组</returns>
        private int[] GetHisogram(Bitmap bmpImg)
        {
            BitmapData data = bmpImg.LockBits(new System.Drawing.Rectangle(0, 0, bmpImg.Width, bmpImg.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            int[] histogram = new int[256];
            unsafe
            {
                byte* ptr = (byte*)data.Scan0;
                int remain = data.Stride - data.Width * 3;
                for (int i = 0; i < histogram.Length; i++)
                    histogram[i] = 0;
                for (int i = 0; i < data.Height; i++)
                {
                    for (int j = 0; j < data.Width; j++)
                    {
                        int mean = ptr[0] + ptr[1] + ptr[2];
                        mean /= 3;
                        histogram[mean]++;
                        ptr += 3;
                    }
                    ptr += remain;
                }
            }
            bmpImg.UnlockBits(data);
            return histogram;
        }

        #region 公式计算
        /// <summary>
        /// 计算两个整数相减后的绝对值除以两数中的较大值
        /// </summary>
        /// <param name="firstNum">被减数</param>
        /// <param name="secondNum">减数</param>
        /// <returns>计算结果</returns>
        private float GetAbs(int firstNum, int secondNum)
        {
            int abs = Math.Abs(firstNum - secondNum);
            int maxNum = Math.Max(firstNum, secondNum);
            return (float)abs / ((maxNum == 0) ? 1 : maxNum);
        }

        /// <summary>
        /// 计算两个直方图的相似度
        /// </summary>
        /// <param name="actualHisogram">待测图片的直方图</param>
        /// <param name="expectedHisogram">参考图片的直方图</param>
        /// <returns>得到直方图的相似度</returns>
        private float GetFinalResult(int[] actualHisogram, int[] expectedHisogram)
        {
            if (actualHisogram.Length != expectedHisogram.Length)
            {
                return 0;
            }
            float result = 0;
            int j = actualHisogram.Length;
            for (int i = 0; i < j; i++)
            {
                result += 1 - GetAbs(actualHisogram[i], expectedHisogram[i]);
            }
            return result / j;
        }
        #endregion
    }
}

