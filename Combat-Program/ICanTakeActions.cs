﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Combat_Program
{
    interface ICanTakeActions
    {
        void Attack(Actor other);
        void Fire(Actor other);
        void Heal();
        void Freeze(Actor other);
        void Poison(Actor other);

        float AttackP
        {
            get; set;
        }

        float HP
        {
            get; set;
        }

        float Defence
        {
            get; set;
        }

        string Status
        {
            get; set;
        }
    }
}
