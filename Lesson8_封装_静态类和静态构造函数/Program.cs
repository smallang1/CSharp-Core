namespace Lesson8_封装_静态类和静态构造函数
{
    #region 知识点一 静态类
    //概念
    //用static修饰类

    //特点：
    //只能包含静态成员
    //不能被实例化

    //作用
    //1.将常用的静态成员写在静态类中 方便使用
    //2.静态类不能被实例化，更能体现工具类的 唯一性
    //比如 Console就是一个静态类

    static class Tools
    {
        //静态成员变量
        public static int testIndex = 0;

        public static void TestFun()
        {

        }

        public static int TestIndex
        {
            get;
            set;
        }
    }

    #endregion

    #region 知识点二 静态构造函数
    //概念
    // 在构造函数加上 static 修饰

    //特点
    //1.静态类和普通类都可以有静态构造函数
    //2.不能使用访问修饰符
    //3.不能有参数
    //4.只会自动调用一次

    //作用
    //在静态构造函数中初始化 静态变量

    //使用
    //1.静态类中的静态构造函数
    static class StaticClass
    {
        public static int testInt = 100;
        public static int testInt2 = 100;

        static StaticClass()
        {
            Console.WriteLine("静态构造函数");
            testInt = 200;
            testInt2 = 300;
        }
    }

    //2.普通类中的静态构造函数
    class Test
    {
        public static int testInt = 200;

        static Test()
        {
            Console.WriteLine("静态构造函数");
        }

        public Test()
        {
            Console.WriteLine("普通构造");
        }
    }

    #endregion

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("静态类和静态构造函数!");

            Console.WriteLine(StaticClass.testInt);
            Console.WriteLine(StaticClass.testInt2);

            Test t = new Test();
            Test t2 = new Test();
        }
    }
}
