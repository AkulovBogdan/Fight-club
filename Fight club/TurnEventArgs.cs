using System;

namespace Fight_club
{
    class TurnEventArgs : EventArgs
    {
        private bool playerTurn;
        
        public bool PlayerTurn { get { return playerTurn; } }

        public TurnEventArgs(bool playerTurn)
        {
            this.playerTurn = playerTurn;
        }
    }
}
