﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace textRPG_ver._2
{
    public enum MonsterType
    {
        None=0,
        Slime=1,
        Orc=2,
        Skeleton=3
    }
  
    class Monster : Creature
    {
        protected MonsterType type = MonsterType.None;
        protected Monster(MonsterType type) : base(CreatureType.Monster)
        {
            this.type = type;
        }
        public MonsterType GetMonsterType() { return type; }
    }

    class Slime : Monster
    {
        public Slime() : base(MonsterType.Slime)
        {
            SetInfo(10, 1);
        }
    }
    class Orc : Monster
    {
        public Orc() : base(MonsterType.Orc)
        {
            SetInfo(20, 2);
        }
    }
    class Skelleton : Monster
    {
        public Skelleton() : base(MonsterType.Skeleton)
        {
            SetInfo(15, 5);
        }
    }
}
