using Studio_Audio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studio_Audio.Context
{
    public class ConnectContext
    {
        public static dbaudioEntities db = new dbaudioEntities();
    }
}
