using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeMonkeyBlazor.Pages
{
    public partial class About
    {
        private string title = "정보";
        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        private string subTitle = "정보관리";
        public string SubTitle
        {
            get { return subTitle; }
            set { subTitle = value; }
        }

        protected override void OnInitialized()
        {
            subTitle = DateTime.Now.ToLongTimeString();
        }

    }
}
