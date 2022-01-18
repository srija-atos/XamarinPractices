using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Management_1
{
    public class ViewFlyoutPageFlyoutMenuItem
    {
        public ViewFlyoutPageFlyoutMenuItem()
        {
            TargetType = typeof(ViewFlyoutPageFlyoutMenuItem);
        }
        public int Id { get; set; }
        public string Title { get; set; }

        public Type TargetType { get; set; }
    }
}