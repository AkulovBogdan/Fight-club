using System;

namespace Fight_club
{
    class Player
    {
        public string Name { get; set; }

        private int health;
        private BodyPart partBlocked;
        private static double criticalChance = 0.2;
        private static double criticalModifier = 2;

        private EventHandler<PlayerEventArgs> blockEvent;
        private EventHandler<PlayerEventArgs> woundEvent;
        private EventHandler<PlayerEventArgs> deathEvent;

        public EventHandler<PlayerEventArgs> RaiseBlockEvent { get { return blockEvent; } set { blockEvent = value; } }
        public EventHandler<PlayerEventArgs> RaiseWoundEvent { get { return woundEvent; } set { woundEvent = value; } }
        public EventHandler<PlayerEventArgs> RaiseDeathEvent { get { return deathEvent; } set { deathEvent = value; } }

        public Player(string name)
        {
            Name = name;
            health = 100;
        }


        public void GetHit(BodyPart part)
        {
            if (partBlocked == part)
            {
                OnRaiseBlockEvent(new PlayerEventArgs(Name, health, part, 0));
            }
            else
            {
                int damage = (int)(20 * (IsCritical() ? criticalModifier : 1));
                health -= damage;
                if (health <= 0)
                    OnRaiseDeathEvent(new PlayerEventArgs(Name, health, part, damage));
                else
                    OnRaiseWoundEvent(new PlayerEventArgs(Name, health, part, damage));
            }
        }

        public void SetBlock(BodyPart part)
        {
            partBlocked = part;
        }

        private bool IsCritical()
        {
            Random rnd = new Random();
            return  (rnd.Next(11) <= criticalChance * 10) ? true : false;
        }

        protected virtual void OnRaiseBlockEvent(PlayerEventArgs e)
        {
            blockEvent?.Invoke(this, e);
        }

        protected virtual void OnRaiseWoundEvent(PlayerEventArgs e)
        {
            woundEvent?.Invoke(this, e);
        }

        protected virtual void OnRaiseDeathEvent(PlayerEventArgs e)
        {
            deathEvent?.Invoke(this, e);
        }
    }
}
