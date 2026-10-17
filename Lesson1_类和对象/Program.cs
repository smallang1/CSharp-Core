namespace Lesson1_类和对象
{
    #region 知识点一 什么是类
    //具有相同特征、相同行为，一切事物的抽象
    //类是对象的模板，可以通过类创建对象
    //关键字 class
    #endregion

    #region 知识点二 类申明在哪里
    //类声明在namespace语句中
    #endregion
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                     
    #region 知识点三 类申明的语法
    class 类名
    {
        //特征—成员变量
        //行为—成员方法
        //保护特征—成员属性

        //构造函数和析构函数
        //索引器
        //运算符重载
        //静态成员
    }
    #endregion

    #region 知识点四 类申明的实例
    //这个类是用来形容人类的
    //命名：帕斯卡命名法
    //注意：同一个语句块中的不同类 不能重名
    class Person
    {
        //特征—成员变量
        //行为—成员方法
        //保护特征—成员属性

        //构造函数和析构函数
        //索引器
        //运算符重载
        //静态成员
    }
    #endregion

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("类和对象");

            #region 知识点五 什么是（类）对象
            //类的申明 和 类对象（变量）申明是两个概念
            //类的申明 类似 枚举和结构体的申明 类的申明相当于申明了一个自定义变量类型
            //而对象 是 类的实例化，是类的具体实现
            //类对象创建的过程 称为 实例化
            //类对象 都是引用类型的
            #endregion

            #region 知识点六 实例化对象基本语法
            //类名 变量类型;
            //类名 变量名 = null;  (null代表空)
            //类名 变量名 = new 类名();
            #endregion

            #region 知识点七 实例化对象
            Person p;
            Person p2 = null; //代表空 不分配内存空间
            Person p3 = new Person(); //相当于一个人对象 
            Person p4 = new Person(); //相当于又是一个人对象

            //注意
            //虽然他们是来自一个类的实例化对象
            //但是他们的 特征 行为等信息 都是它们独有的
            #endregion


        }
    }
}