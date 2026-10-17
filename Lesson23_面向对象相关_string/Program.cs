namespace Lesson23_面向对象相关_string
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("string");

            //注意，在进行字符串的修改时，并不会直接对原字符串进行修改，而是要重新创建一个新的字符串对象

            #region 知识点一 字符串指定位置的获取
            //字符串本质是char数组
            string str = "小强同学";
            Console.WriteLine(str[0]);
            //转为char数组
            char[] chars = str.ToCharArray();
            Console.WriteLine(chars[1]);
            Console.WriteLine(str.Length);

            for (int i = 0; i < str.Length; i++)
            {
                Console.WriteLine(str[i]);
            }
            #endregion

            #region 知识点二 字符串拼接
            str = string.Format("{0}{1}",1,666);
            Console.WriteLine(str);
            #endregion

            #region 知识点三 正向查找字符位置
            str = "我是小强同学";
            int index = str.IndexOf("小");
            Console.WriteLine(index);
            //如果查找不到的话，默认输出-1
            index = str.IndexOf("你");
            Console.WriteLine(index);
            #endregion

            #region 知识点四 反向查找指定字符位置
            str = "我是小强同学的同学";

            index = str.LastIndexOf("同学");
            Console.WriteLine(index);
            //如果查找不到的话，默认输出-1
            #endregion

            #region 知识点五 移除指定位置及后面的字符
            str = "我是小强小强";
            str.Remove(4);
            Console.WriteLine(str);
            str = str.Remove(4);
            Console.WriteLine(str);

            //执行两个参数进行移除
            //参数1：起始位置  参数2：移除的字符数
            str = str.Remove(0, 2);
            Console.WriteLine(str);
            #endregion

            #region 知识点六 替换指定字符串
            str = "我是小强同学小强同学";
            str = str.Replace("小强", "小明");
            Console.WriteLine(str);
            #endregion

            #region 知识点七 大小写转换
            str = "sjcmioenowncusw";
            str.ToUpper();
            Console.WriteLine(str);
            str = str.ToUpper();
            Console.WriteLine(str);

            str = str.ToLower();
            Console.WriteLine(str);
            #endregion

            #region 知识点八 字符串截取
            str = "我是小强同学";
            //截取从指定位置开始及之后的字符串
            str =  str.Substring(2);
            Console.WriteLine(str);

            //截取从指定位置开始及指定长度的字符串
            str = str.Substring(2, 2);
            Console.WriteLine(str);
            #endregion

            #region 知识点九 字符串切割
            str = "1,2,3,4,5,6,7,8";
            string[] strs = str.Split(',');
            //foreach (string s in strs)
            //{
            //    Console.WriteLine(s);
            //}
            for (int i = 0; i < str.Length; i++)
            {
                Console.WriteLine(strs[i]);
            }
            #endregion
        }
    }
}
