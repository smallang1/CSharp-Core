namespace Lesson1_练习题
{
    class GameObject
    {

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("类和对象练习题");

            #region 练习题一
            //GameObject A = new GameObject();
            //GameObject B = A;
            //B = null;
            //A目前等于多少？  new GameObject()
            #endregion

            #region 练习题二
            //GameObject A = new GameObject();
            //GameObject B = A;
            //B = new GameObject();
            //A和B有什么关系？  A和B是两个不同的对象，它们都有自己的内存空间，互不影响。
            #endregion
        }
    }
}
