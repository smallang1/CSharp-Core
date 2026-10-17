namespace Lesson17_多态
{
    #region 知识点一 多态的概念
    // 多态按字面意思就是“多种形态”
    // 让继承同一父类的子类们 在执行相同方法时有不同的表现（状态）
    // 主要目的
    // 同一父类的对象 执行相同行为（方法）有不同的表现
    // 解决的问题
    // 让同一个对象有唯一行为的特征
    #endregion

    #region 知识点二 解决的问题
    class Father()
    {
        public void SpeakName()
        {
            Console.WriteLine("Father的方法");
        }
    }

    class Son() : Father()
    {
        public new void SpeakName()
        {
            Console.WriteLine("Son的方法");
        }
    }
    #endregion

    #region 知识点三 多态的实现
    //编译时多态—函数重载，开始就写好的

    //将要学习的：
    //运行时多态（vob、抽象函数、接口）
    //今天学习 vob
    //V: virtual（函数）
    //O: override（重写）
    //B: base （父类）

    class GameObject
    {
        public string name;
        public GameObject(string name)
        {
            this.name = name;
        }

        //虚函数 可以被子类重写，但不能被子类调用
        public virtual void Atk()
        {
            Console.WriteLine("游戏对象进行攻击");
        }
    }

    class Player : GameObject
    {
        public Player(string name) : base(name)
        {

        }

        //重写虚函数
        public override void Atk()
        {
            //base的作用，代表父类
            //可以通过base保留父类的行为
            base.Atk();
            Console.WriteLine("玩家对象进行攻击");
        }
        

    }

    class Monster : GameObject
    {
        public Monster(string name) : base(name)
        {

        }

        public override void Atk()
        {
            Console.WriteLine("怪物对象进行攻击");
        }
    }
    #endregion

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("多态vob");

            #region 解决的问题
            Father f = new Son();
            f.SpeakName();
            (f as Son).SpeakName();
            #endregion

            #region 多态的使用
            GameObject p = new Player("小明");
            p.Atk();
            //(p as Player).Atk();

            GameObject m = new Monster("小怪");
            m.Atk();
            //(m as Monster).Atk();
            #endregion
        }
    }
}
