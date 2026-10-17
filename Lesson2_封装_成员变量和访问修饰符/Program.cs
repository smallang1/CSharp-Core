namespace Lesson2_封装_成员变量和访问修饰符
{
    #region 知识点一 成员变量
    //基本规则
    //1.申明在类语句块中
    //2.用来描述对象的特征
    //3.可以是任意变量类型
    //4.数量不做限制
    //5.是否赋值根据需求来定

    //性别枚举
    enum E_SexType
    {
        Man,
        Woman,
    }

    //位置结构体
    struct Position
    {

    }

    //宠物类
    class Pet
    {

    }
    class Person
    {
        //特征—成员变量
        //姓名
        public string name = "熊大";
        //年龄
        public int age;
        //性别
        public E_SexType sex;
        //女朋友
        //注意：如果在类中声明一个和自己相同类型的成员变量时，不能对它进行实例化
        public Person girlfriend = null;
        //朋友
        public Person[] boyfriend;
        //位置
        public Position pos;
        //宠物
        public Pet pet;

        
    }
    #endregion

    #region 知识点二 访问修饰符
    //public:公共的 自己（内部）和别人（外部都能访问和使用）
    //private:私有的 自己（内部）才能访问和使用 不写 默认为private
    //protected: 保护的 自己（内部）和子类才能访问和使用 （继承）
    //internal: 内部的 只有自己（当前程序集）才能访问和使用
    #endregion

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("成员变量和访问修饰符");

            Person p = new Person();
            #region 知识点三 成员变量的使用和初始值
            //值类型来说 数字类型 默认值都是0  bool类型 false;
            //引用类型 null
            //小技巧 default(变量类型)  关键字打印类型的默认值
            Console.WriteLine(default(Person));

            p.age = 10;
            Console.WriteLine(p.age);
            #endregion



        }
    }
}
