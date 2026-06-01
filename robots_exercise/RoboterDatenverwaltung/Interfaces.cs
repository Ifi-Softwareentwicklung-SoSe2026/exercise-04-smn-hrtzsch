namespace RoboterDatenverwaltung;

public interface IRoboterSerializer
{
    void Speichern(Roboter roboter, string dateipfad);
    Roboter Laden(string dateipfad);
}
