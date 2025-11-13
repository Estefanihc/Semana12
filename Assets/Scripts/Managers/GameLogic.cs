public class GameLogic
{
    public int ObjectivesToWin { get; private set; }
    public int ObjectivesCompleted { get; private set; }

    // ✅ Propiedad que evalúa si se cumplió la condición de victoria
    public bool IsVictoryConditionMet => ObjectivesCompleted >= ObjectivesToWin;

    // Constructor: define cuántos objetivos hay para ganar
    public GameLogic(int objectivesToWin)
    {
        ObjectivesToWin = objectivesToWin;
        ObjectivesCompleted = 0;
    }

    // Marca un objetivo como completado
    public void CompleteObjective()
    {
        if (ObjectivesCompleted < ObjectivesToWin)
            ObjectivesCompleted++;
    }
}
