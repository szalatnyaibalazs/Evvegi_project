using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evvegi_project
{
    class Jatekos
    {
        int attack;
        public int Attack { get { return attack; } }
        int hp;
        public int Hp { get { return hp; } }
        int luck;
        public int Luck { get { return luck; } }
        int maxattack;
        public int Maxattack { get { return maxattack; } }
        int maxhp;
        public int Maxhp { get { return maxhp; } }
        int maxluck;
        public int Maxluck { get { return maxluck; } }
        string ital;
        public string Ital { get { return ital; } }

        public Jatekos(int attack, int hp, int luck, int maxattack, int maxhp, int maxluck, string ital)
        {
            this.attack = attack;
            this.hp = hp;
            this.luck = luck;
            this.maxattack = maxattack;
            this.maxhp = maxhp;
            this.maxluck = maxluck;
            this.ital = ital;
        }
    }
}
