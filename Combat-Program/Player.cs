using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Combat_Program
{
    class Player : Actor, IControllable
    {
        private string m_Input;

        public string Input
        {
            get
            {
                return m_Input;
            }

            set
            {
                m_Input = value;
            }
        }

        public Player(float a, float b, float c, string d)
        {
            m_HP = a;
            m_Attack = b;
            m_Defence = c;
            m_Status = d;
        }
    }
}
