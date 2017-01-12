using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    /// <summary>
    /// 初始化类别编号，类别说明的（Sort）类
    /// 图书类别方法（存取数据）
    /// </summary>
    public class Sort
    {
        private string tbSortId;
        private string tbSortMemo;

        public string TbSortMemo
        {
            get { return tbSortMemo; }
            set { tbSortMemo = value; }
        }  

        public string TbSortId
        {
            get { return tbSortId; }
            set { tbSortId = value; }
        }
    }
}
