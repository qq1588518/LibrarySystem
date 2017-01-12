using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    /// <summary>
    /// 图书归还（存取数据）
    /// </summary>
    public class Back
    {
        private string tbBackBookId;
        private string cbBackLost;
        private string cbBackDamage;
        private string tbBackMemo;

        public string TbBackBookId
        {
            get { return tbBackBookId; }
            set { tbBackBookId = value; }
        }

        public string CbBackLost
        {
            get { return cbBackLost; }
            set { cbBackLost = value; }
        }

        public string CbBackDamage
        {
            get { return cbBackDamage; }
            set { cbBackDamage = value; }
        }

        public string TbBackMemo
        {
            get { return tbBackMemo; }
            set { tbBackMemo = value; }
        }


    }
}
