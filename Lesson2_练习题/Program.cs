namespace Lesson2_练习题
{
    #region 练习题一
    //3P是什么？
    //public 公共 内外
    //private 私有的 内
    //protected 保护的 內部和子类
    #endregion

    internal class Program
    {
        //值类型有栈无堆
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            #region 练习题二
            //Person p = new Person();
            //p.age = 10;
            //Person p2 = new Person();
            //p2.age = 20;
            //p.age=多少？ 10
            #endregion

            #region 练习题三
            //Person p = new Person();
            //p.age = 10;
            //Person p2 = p;
            //p2.age =20;
            //p.age是多少？ 20
            #endregion

            #region 练习题四
            //Student s = new Student();
            //s.age = 10;
            //int age = s.age;
            //age = 20;
            //s.age是多少？ 10
            #endregion

            #region 练习题五
            //Student s = new Student();
            //s.deskmate = new Student();
            //s.deskmate.age = 10;
            //Student s2 = s.deskmate;
            //s2.age = 20;
            //问：s.deskmate.age是多少？ 20
            #endregion
        }
    }
}
