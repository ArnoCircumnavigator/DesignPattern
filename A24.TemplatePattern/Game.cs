using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A24.TemplatePattern
{
    abstract class Game
    {
        public abstract void Initialize();
        public abstract void StartPlay();
        public abstract void EndPlay();

        /// <summary>
        /// 注意
        /// 这个方法是一定不允许被子类重写的
        /// 应为在模板设计模式中，这个就是模板，
        /// 所有的子类都应该按照这个来操作
        /// 如果子类改变了这个过程，那么就不应该用模板模式
        /// 强行用，只会增加系统的维护成本
        /// 这个模式，我个人感觉用来做整体的状态机不错，流程一致的情况
        /// </summary>
        public void Play()
        {
            Initialize();

            StartPlay();

            EndPlay();
        }
    }
}
