namespace Fight_club
{
    interface IController
    {
        Model ModelRef { get; set; }
        void PlayerTurn(BodyPart part);
        void EnemyTurn(BodyPart part);
        BodyPart EnemyDecision();
    }
}
