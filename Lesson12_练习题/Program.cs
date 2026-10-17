namespace Lesson12_练习题
{
    #region 练习题
    //写一个人类，人类中有姓名，年龄属性，有说话行为
    //战士继承人类，有攻击行为

    class Person
    {
        public string Name
        {
            get;
            set;
        }
        public int Age
        {
            get;
            set;
        }
        public void Speak(string str)
        {
            Console.WriteLine(str);
        }
    }

    class Warrior : Person
    {
        public void Atk(Warrior otherWarrior)
        {
            Console.WriteLine("{0} 攻击 {1}",Name,otherWarrior.Name);
        }
    }

    #endregion
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("继承练习题");

            Warrior w1 = new Warrior();
            w1.Name = "张三";

            Warrior w2 = new Warrior();
            w2.Name = "李四";

            w1.Atk(w2);
        }
    }
}
