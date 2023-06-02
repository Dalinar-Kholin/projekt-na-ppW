using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt_na_ppW
{
    public partial class myTreeView : TreeView
    {
        List<string> paths ;
        List<myTreeView> children ;
        public myTreeView() 
        {
            paths = new List<string>();
            children = new List<myTreeView>();
        }
    }
}
