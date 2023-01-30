using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework17EntityFramework
{
    public partial class AdonetDbEntities
    {
        public AdonetDbEntities(string connectionSting) : base(connectionSting)
        {
        }
    }
}
