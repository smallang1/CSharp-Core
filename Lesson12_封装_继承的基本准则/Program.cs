namespace Lesson12_封装_继承的基本准则
{
    #region 知识点一 基本准则
    //一个类A继承一个类B
    //类A会继承类B的所有成员
    //A类将拥有B类的所以特征和行为

    //被继承的类
    //称为 父类、基类、超类

    //继承的类
    //称为子类、派生类

    //子类可以有自己的特征和行为

    //特点
    //1.单根性 子类只能有一个父类
    //2.传递性 子类可以间接继承父类的父类
    #endregion

    #region 知识点二 基本语法
    //class 类名:被继承的类名
    //{
    //
    //}
    #endregion

    #region 知识点三 实例
    class Teacher
    {
        public string name;
        //职工号
        protected int number;

        public void SpeakName()
        {
            number = 10;
            Console.WriteLine(name);
        }
    }

    class TeachingTeacher : Teacher 
    {
        //教授科目
        public string subject;

        public void SpeakSubject()
        {
            Console.WriteLine(subject + "老师");
        }
    }

    class ChineseTeacher : TeachingTeacher
    {
        public void Skill()
        {
            Console.WriteLine("一行白鹭上青天");
        }
    }

    #endregion

    #region 知识点四 访问修饰符的影响
    //public 内外
    //private 内
    //protected 保护 内部和子类访问 

    //命名空间中
    //internal 内部的 只有在同一个程序集的文件中，内部类型或者是成员才可以访问
    #endregion

    #region 知识点五 子类和父类的同名成员
    //概念
    //C#中允许子类存在和父类同名的成员
    //但不建议使用
    #endregion
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("继承的基本准则");

            TeachingTeacher tt = new TeachingTeacher();
            tt.name = "张三";
            //tt.number = 1001;
            tt.SpeakName();

            tt.subject = "数学"; 
            tt.SpeakSubject();

            ChineseTeacher ct = new ChineseTeacher();
            ct.name = "小航";
            //ct.number = 1002;
            ct.subject = "语文";

            ct.SpeakName();
            ct.SpeakSubject();
            ct.Skill();
        }
    }
}
