using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloDungeon
{
    /*private protected internal virtual*/ class Mayro
    {
        private string _name;
        private string _description;
        private int _attackLvL;
        private bool _isAnInstrument;
        private float _health;

        public Mayro()
        {

        }

        public Mayro(string name, string description, int attackLvL, bool isAnInstrument, float health)
        {
            _name = name;
            _description = description;
            _attackLvL = attackLvL;
            _isAnInstrument = isAnInstrument;
            _health = health;
        }

        public string GetName()
        {
            return _name;
        }
        public string GetDescription()
        {
            return _description;
        }
        public int GetAttackLvL()
        {
            return _attackLvL;
        }
        public bool InstrumentDilemma()
        {
            return _isAnInstrument;
        }
        public float GetHealth()
        {
            return _health;
        }
    }
}
