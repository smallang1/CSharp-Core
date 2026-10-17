//引用MyGame命名空间
//using MyGame;
using System;

#region 知识点一 命名空间基本概念
//概念：命名空间是用来组织和重用代码的
//作用：就像是一个工具包，类就像是一件一件的工具，都是申明在命名空间中的
#endregion

#region 知识点二 命名空间的使用
//基本语法
//namespace 命名空间名
//{
//   类定义
//}
namespace MyGame
{
    class GameObject
    {

    }
}
namespace MyGame
{
    class Player : GameObject
    {

    }
}
#endregion

#region 知识点四 不同命名空间中允许有同名类
namespace MyGame2
{
    //在不同命名空间中允许有同名类
    class GameObject
    {

    }
}

#endregion

#region 知识点五 命名空间可以包裹命名空间
namespace MyGame
{
    namespace UI
    {
        class Image
        {

        }
    }

    namespace Game
    {
        class Image
        {

        }
    }
}
#endregion

#region 知识点六 关于修饰类的访问修饰符
//public
//internal 只能在该程序集中使用
//sealed 密封类
//partial 分部类
#endregion
namespace Lesson21_面向对象相关_命名空间
{
 
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("命名空间");
            #region 知识点三 不同命名空间中相互使用 需要引用命名空间或指明出处
            MyGame.GameObject g = new MyGame.GameObject();
            //或者引用命名空间，在最上面加using MyGame;
            //GameObject g = new GameObject();

            MyGame2.GameObject g2 = new MyGame2.GameObject();

            //指明出处
            MyGame.UI.Image i = new MyGame.UI.Image();
            MyGame.Game.Image i2 = new MyGame.Game.Image();
            #endregion
        }
    }
}
