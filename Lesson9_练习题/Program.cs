namespace Lesson9_练习题
{
    #region 练习题一
    //为整型拓展一个求平方的方法

    static class Tools
    {
        public static int Square(this int value)
        {
            return value * value;
        }

        public static void KillSeif(this Player p)
        {
            Console.WriteLine("玩家" + p.name + "自杀");
        }
    }
    #endregion

    #region 练习题二
    //写一个玩家类，包含姓名，血量，攻击力，防御力等特征，攻击，移动，受伤等方法
    //为该玩家类拓展一个自杀的方法
    class Player
    {
        public string name;
        public int hp;
        public int atk;
        public int def;

        public void Atk(Player othjerPlayer)
        {

        }

        public void Move()
        {

        }

        public void Wound(Player othjerPlayer)
        {

        }

    }
    #endregion
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("拓展方法练习题");

            int i = 10;
            Console.WriteLine(i.Square());

            Player p = new Player();
            p.name = "小明";
            p.KillSeif();
        }
    }
}
