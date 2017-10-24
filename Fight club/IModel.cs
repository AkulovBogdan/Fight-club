namespace Fight_club
{
    interface IModel
    {
        void DamagePlayer(BodyPart part);

        void DamageEnemy(BodyPart part);

        void BlockPlayer(BodyPart part);

        void BlockEnemy(BodyPart part);
    }
}
