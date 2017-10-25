namespace Fight_club
{
    /// <summary>
    ///  Represents Model part of the MVC pattern
    /// </summary>
    class Model : IModel
    {
        Player player;
        Player enemy;

        public Player Player { get { return player; } }
        public Player Enemy { get { return enemy; } }

        public Model(string playerName, string enemyName)
        {
            player = new Player(playerName);
            enemy = new Player(enemyName);
        }

        public void DamagePlayer(BodyPart part)
        {
            player.GetHit(part);
        }

        public void DamageEnemy(BodyPart part)
        {
            enemy.GetHit(part);
        }

        public void BlockPlayer(BodyPart part)
        {
            player.SetBlock(part);
        }

        public void BlockEnemy(BodyPart part)
        {
            enemy.SetBlock(part);
        }
    }
}
