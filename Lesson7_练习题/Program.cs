using System.Reflection.Emit;

namespace Lesson7_练习题
{
    #region 练习题一 
    //请说出const和static的区别
    //相同点：
    //都可以通过类名点出来使用
    //不同点：
    //1.const必须初始化不能被修改，static没有这个要求
    //2.const只能修饰变量，static可以修饰成员变量、成员方法、属性
    //3.访问修饰符要写在const前面。static随意
    class Dome
    {
        public const float PI = 3.14f;
        //const public float P = 3.14f;   
        public static int Count = 0;
        static public int Count1 = 0;

    }
    #endregion

    #region 练习题二
    //使用静态成员相关知识实现
    //一个类对象，在整个应用程序的生命周期中，有且仅有一个该对象的存在
    //不能在外部实例化，直接通过该类类名就能得到唯一的对象

    class Test
    {
        //直接实例化静态成员变量
        private static Test t = new Test();

        //T为属性，返回的为t是静态成员变量，默认上面代码已经进行了实例化
        //就可以通过实例化出来的对象点出成员变量 testInt
        public int testInt = 10;

        public static Test T
        {
            get
            {
                return t;
            }
        }

        //构造函数私有，外部不能实例化
        private Test()
        {

        }
    }

    #endregion
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("静态成员练习题");

            Console.WriteLine(Test.T.testInt);
        }
    }
}
