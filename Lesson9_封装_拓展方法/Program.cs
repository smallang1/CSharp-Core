namespace Lesson9_封装_拓展方法
{
    #region 知识点一 拓展方法的基本概念
    //概念
    //为现有非静态 变量类型 添加 新方法
    //作用
    //1.提升程序拓展性
    //2.不需要在对象中重写方法
    //3.不需要继承来添加方法
    //4.为别人封装的类型写额外的方法
    //特点
    //1.一定是在静态类中
    //2.一定是个静态函数
    //3.第一个参数为拓展方法
    //4.第一个参数用this表示
    #endregion

    #region 知识点二 基本语法
    //访问修饰符 static 返回值 函数名(this 拓展类名 参数名，参数类型 参数名.....)
    #endregion

    #region 知识点三 实例

    static class Tools
    {
       //为int拓展了一个成员方法
       //成员方法是需要实例化之后才能使用的
       //value 代表 使用该方法的 实例化对象
        public static void SpeakValue(this int value)
        {
            //拓展方法的逻辑
            Console.WriteLine("拓展的方法" + value);
        }

        public static void SpeakStringInfo(this string str,string str2,string str3)
        {
            Console.WriteLine("为string拓展的方法");
            Console.WriteLine("调用方法的对象" + str);
            Console.WriteLine("传的参数" + str2 + str3);
        }

        public static void Fun3(this Test t)
        {
            Console.WriteLine("为Test拓展的方法");
        }
    }
    #endregion

    #region 知识点五 为自定义的类型拓展方法
    class Test
    {
        public int i = 10;

        public void Fun1()
        {
            Console.WriteLine("123");

        }

        public void Fun2()
        {
            Console.WriteLine("456");
        }
    }
    #endregion
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("拓展方法");
            #region 知识点四 使用
            int i = 10;
            i.SpeakValue();

            string str = "000";
            str.SpeakStringInfo("111","222");

            Test t = new Test();
            t.Fun3();
            #endregion
        }
    }
}
