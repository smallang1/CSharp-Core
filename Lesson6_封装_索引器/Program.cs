namespace Lesson6_封装_索引器
{
    #region 知识点一 索引器基本概念
    //基本概念
    //让对象可以像数组一样通过索引访问其中元素，使程序看起来更直观，更容易编写
    #endregion

    #region 知识点二 索引器语法
    //访问修饰符 返回值 this[参数类型 参数名，参数类型 参数名......]
    // {
    //       内部写法与规则和属性相同
    //       get{}
    //       set{}
    // }
    class Person
    {
        private string name;
        private int age;
        private Person[] friends;

        private int[,] array;

        #region 知识点五 索引器可以重载
        //重载的概念是 函数名相同 参数类型、数量、顺序不同
        public int this[int i, int j]
        {
            get
            {
                return array[i, j];
            }
            set
            {
                array[i, j] = value;
            }
        }
        #endregion

        public Person this[int index]
        {
            get
            {
                //可以写逻辑
                #region 知识点四 索引器中可以写逻辑
                if(friends == null ||
                    friends.Length - 1 < index)
                {
                    return null;
                }
                #endregion
                return friends[index];
            }
            set
            {
                //value代表传入的值
                if(friends == null)
                {
                    friends = new Person[] { value };
                }
                else if(friends.Length - 1 < index)
                {
                    //如果索引越界 就默认把最后一个朋友顶掉
                    friends[friends.Length - 1] = value;
                }
                friends[index] = value;
            }
        }
    }
    #endregion

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("索引器");
            #region 知识点三 索引器的使用
            Person p = new Person();
            p[0] = new Person();
            Console.WriteLine(p[0]);

            p[0,0] = 10;
            #endregion
        }
    }
}
