using System.Text;
using System.Xml;

namespace Lesson24_面向对象相关_StringBuilder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("StringBuilder");

            #region 知识回顾
            //string是特殊的引用
            //每次重新赋值或者拼接的时候都会分配新的内存空间
            //如果一个字符串经常改变会非常浪费空间
            #endregion

            #region 知识点 StringBuilder
            //C#提供的一个用于处理字符串的公共类
            //主要解决问题是：
            //修改字符而不创建新的对象，需要频繁修改和拼接的字符串可以使用它，可以提升性能
            //使用前 需要引用命名空间

            #region 初始化 直接指明内容
            StringBuilder str = new StringBuilder("123123123");
            Console.WriteLine(str);
            #endregion

            #region 容量
            //StringBuiler存在一个容量的问题，每次往里面增加时 会自动扩容
            //获得容量
            Console.WriteLine(str.Capacity);
            //获得长度(实际存储字符的长度)
            Console.WriteLine(str.Length);
            #endregion

            #region 增删查改替换
            //增
            str.Append("456");
            Console.WriteLine(str);
            Console.WriteLine(str.Capacity);
            Console.WriteLine(str.Length);

            str.AppendFormat("{0}{1}",100,200);
            Console.WriteLine(str);
            Console.WriteLine(str.Capacity);
            Console.WriteLine(str.Length);
            //插入
            str.Insert(0,"小强");
            Console.WriteLine(str);
            //删
            str.Remove(0,2);
            Console.WriteLine(str);
            //清空
            //str.Clear();
            //Console.WriteLine(str);
            //查
            Console.WriteLine(str[0]);
            //改
            str[0] = 'A';
            Console.WriteLine(str);
            //替换
            str.Replace("A","Z");
            Console.WriteLine(str);

            //重新赋值 StringBuilder
            str.Clear();
            str.Append("Hello World!");
            Console.WriteLine(str);

            //判断是否相等
            if(str.Equals("Hello World!"))
            {
                Console.WriteLine("相等");
            }
            #endregion

            #endregion

        }
    }
}
