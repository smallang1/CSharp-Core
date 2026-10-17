namespace Lesson8_练习题
{
    #region 练习题
    //写一个用于数学计算的静态类
    //该类中提供计算圆的面积，圆周长，矩形面积，矩形周长，取一个数的绝对值 等方法
    static class MathTool
    {
        public static float PI = 3.14f;
        /// <summary>
        /// 计算圆的面积
        /// </summary>
        /// <param name="r">半径</param>
        /// <returns>面积</returns>
        public static float CalcCircularArea(float r)
        {
            return PI * r * r;
        }

        public static float CalcCircularLength(float r)
        {
            return 2 * PI * r;
        }

        public  static float CalcRectArea(float width, float height)
        {
            return width * height;
        }

        public static float CalcRectLength(float width, float height)
        {
            return 2 * (width + height);
        }

        public static float GetABS(float value)
        {
            if(value < 0)
            {
                return -value;
            }
            return value;
        }
    } 
    #endregion
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Console.WriteLine(MathTool.CalcCircularArea(5));
        }
    }
}
