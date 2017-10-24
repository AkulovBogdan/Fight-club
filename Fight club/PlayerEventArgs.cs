using System;

namespace Fight_club
{
    class PlayerEventArgs : EventArgs
    {
        private string name;
        private int currentHealth;
        private BodyPart part;
        private int damage;

        public string Name { get { return name; } }
        public int CurrentHealth { get { return currentHealth; } }
        public BodyPart Part { get { return part; } }
        public int Damage { get { return damage; } }

        public PlayerEventArgs(string name, int currentHealth, BodyPart part, int damage)
        {
            this.name = name;
            this.currentHealth = currentHealth;
            this.part = part;
            this.damage = damage;
        }
    }
}
