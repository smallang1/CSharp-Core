namespace Lesson18_多态_抽象类和抽象方法
{
    #region 知识点一 抽象类
    //概念：被抽象关键字abstract修饰的类
    //特点：
    //1.不能被实例化的类
    //2.可以包含抽象方法
    //3.继承抽象类必须重写其他抽象方法

    abstract class Thing
    {
        //抽象类中 封装的所有知识点都可以在其中书写
        public string name;

        //可以在抽象类中写抽象函数
    }

    class Water : Thing
    {

    }
    #endregion

    #region 知识点二 抽象函数
    //又叫 纯虚方法
    //用abstract关键字修饰的方法
    //特点：
    //1.只能在抽象类中申明
    //2.没有方法体
    //3.不能是私有的
    //4.继承后必须实现 用override重写

    abstract class Fruits
    {
        public string name;

        //抽象方法 不能有函数体
        public abstract void Bad();

        public virtual void Test()
        {
            //虚方法可以选择是否写逻辑
        }
    }

    class Apple : Fruits
    {
        public override void Bad()
        {

        }
        //虚方法由子类选择性实现，抽象方法必须实现
    }

    class SuperApple : Apple
    {
        //虚方法和抽象方法 都可以被子类无限重写
        public override void Test()
        {
            base.Test();
        }

        public override void Bad()
        {
            base.Bad();
        }
    }
    #endregion
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("抽象类和抽象方法");
            //抽象类不能实例化
            //Thing t = new Thing();
            //但是 可以遵循里氏替换原则 用父类装子类
            Thing t = new Water();
        }
    }
}
