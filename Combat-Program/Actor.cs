using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Combat_Program
{
    class Actor : ICanTakeActions
    {
        protected float m_HP;
        protected float m_Attack;
        protected float m_Defence;
        protected string m_Status;
    }
}
