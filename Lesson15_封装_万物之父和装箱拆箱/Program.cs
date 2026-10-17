namespace Lesson15_封装_万物之父和装箱拆箱
{
    #region 里氏替换知识点回顾
    //概念：父类容器装子类对象
    //作用：方便进行对象存储和管理
    //使用：is和as关键字
    //is 用于判断  as 用于转换
    class Father
    {

    }
    class Son : Father
    {
        public void Speak()
        {

        }
    }

    #endregion

    #region 知识点一 万物之父
    //关键字：object
    //概念：object是所有类型的基类，它是一个类（引用类型）
    //作用：
    //1.可以利用里氏替换原则，用object容器装所有对象
    //2.可以用来表示不确定类型，作为函数参数类型
    #endregion
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("万物之父和装箱拆箱");
            #region 知识点二
            Father f = new Son();
            if (f is Son)
            {
                (f as Son).Speak();
            }
            //引用类型
            object o = new Son();
            //用is as 来判断和转换即可
            if (o is Son) 
            {
                (o as Son).Speak();
            }
            //值类型
            object o2 = 1f;
            //用强转
            float fl= (float)o2;
            //特殊的string类型
            object str = "123123";
            string str2 = str.ToString();

            //数组
            object arr = new int[10];
            int[] arr2 = arr as int[];
            #endregion

            #region 知识点三
            //发生条件
            //用object存值类型（装箱）
            //再把object转为值类型 （拆箱）

            //装箱
            //把值类型用引用类型存储
            //栈内存会迁移到堆内存中

            //拆箱
            //把引用类型存储的值类型取出来
            //堆内存会迁移到栈内存中

            //好处:不确定类型时 可以方便参数的存储和传递
            //坏处：存在内存迁移，增加性能消耗

            //装箱
            object v = 3;
            //拆箱
            int intValue = (int)v;

            TestFun(0,123,"你好");

            #endregion
        }

        static void TestFun(params object[] array)
        {

        }
    }
}
