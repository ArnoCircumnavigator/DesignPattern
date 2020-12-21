using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A30.FrontControllerPattern
{
    /// <summary>
    /// 调度器
    /// 调度显示那个页面用的
    /// </summary>
    class Dispatcher
    {
        StudentView _studentView;
        HomeView _homeView;

        public Dispatcher()
        {
            _studentView = new StudentView();
            _homeView = new HomeView();
        }
        public void Dispatch(string request)
        {
            if (string.Equals(request, "STUDENT"))
                this._studentView.Show();
            else
                this._studentView.Show();
        }
    }
}
