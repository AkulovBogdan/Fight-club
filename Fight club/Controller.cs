using System;

namespace Fight_club
{
    /// <summary>
    ///  Represents Controller part of the MVC pattern
    /// </summary>
    class Controller : IController
    {
        public Model ModelRef { get; set; }
        private bool playerTurn = true;

        private EventHandler<TurnEventArgs> turnEvent;
        public EventHandler<TurnEventArgs> RaiseTurnEvent { get { return turnEvent; } set { turnEvent = value; } }

        public void PlayerTurn(BodyPart part)
        {
            if (playerTurn)
                ModelRef.DamageEnemy(part);
            else
                ModelRef.BlockPlayer(part);

            EnemyTurn(EnemyDecision());
            playerTurn = !playerTurn;
            OnRaiseTurnEvent(new TurnEventArgs(playerTurn));
        }

        public void EnemyTurn(BodyPart part)
        {
            if (!playerTurn)
                ModelRef.DamagePlayer(part);
            else
                ModelRef.BlockEnemy(part);
        }

        public BodyPart EnemyDecision()
        {
            Random rng = new Random();
            return (BodyPart)rng.Next(3);
        }

        protected virtual void OnRaiseTurnEvent(TurnEventArgs e)
        {
            turnEvent?.Invoke(this, e);
        }
    }
}
