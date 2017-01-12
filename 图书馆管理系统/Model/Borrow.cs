using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    /// <summary>
    /// 借阅信息（Borrow）类
    /// 借阅信息方法（存取数据）
    /// </summary>
    public class BorrowInfo
    {
        private string tbBorrowReadId;
        private string tbBorrowBookId;   

        public string TbBorrowReadId
        {
            get { return tbBorrowReadId; }
            set { tbBorrowReadId = value; }
        }       

        public string TbBorrowBookId
        {
            get { return tbBorrowBookId; }
            set { tbBorrowBookId = value; }
        }
    }
}
