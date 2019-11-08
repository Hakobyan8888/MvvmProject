using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UwpMVVM
{
    public class MainViewModel : MainViewModelBase
    {
        private Calculator calculator_ = null;
        private int result_ = 0;
        private int value1_ = 0;
        private int value2_ = 0;
        private bool isAddChecked = false;
        private bool isSubChecked = false;
        private bool isMulChecked = false;
        private bool isDivChecked = false;
    }
}
