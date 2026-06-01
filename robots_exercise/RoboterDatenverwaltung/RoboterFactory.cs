namespace RoboterDatenverwaltung;

public static class RoboterFactory
{
    public static Roboter ErzeugeRoboter(string name, string typ, int energielevel)
    {
        return new Roboter(name, typ, energielevel);
    }

    public static Lieferroboter ErzeugeLieferroboter(string name, int energielevel, int lieferkapazität)
    {
        return new Lieferroboter(name, energielevel, lieferkapazität);
    }
}
