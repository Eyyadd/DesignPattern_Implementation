using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public class Character : IPrototype<Character>
    {
        public string Name { get; set; }
        private int _Health;
        private int _Power;

        public Character(string name, int health, int power)
        {
            this.Name = name;
            this._Health = health;
            this._Power = power;
        }
        public Character Clone()
        {
            //return new Character(this.Name, this._Power, this._Health);
            return (Character)this.MemberwiseClone();
        }

        public override string ToString()
        {
            return $"my name is {this.Name}, and my health is {this._Health}. also i have power {_Power}";
        }
    }
}
