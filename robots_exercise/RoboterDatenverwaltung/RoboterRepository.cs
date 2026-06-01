namespace RoboterDatenverwaltung;

public class RoboterRepository
{
    private readonly IRoboterSerializer serializer;

    public RoboterRepository(IRoboterSerializer serializer)
    {
        this.serializer = serializer;
    }

    public void Speichern(Roboter roboter, string dateipfad)
    {
        serializer.Speichern(roboter, dateipfad);
    }

    public Roboter Laden(string dateipfad)
    {
        return serializer.Laden(dateipfad);
    }
}
