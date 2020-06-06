using System;
using System.Collections.Generic;

namespace qlthpt.Models
{
    public partial class ChitietChucvu
    {
        public TimeSpan CtCvId { get; set; }
        public string ChucvuCvMa { get; set; }
        public string CanboCbMa { get; set; }

        public virtual Canbo CanboCbMaNavigation { get; set; }
        public virtual Chucvu ChucvuCvMaNavigation { get; set; }
    }
}
