namespace BashMonster;
public class Gubbe
{
    public float maxhp;
    public float hp;
    public float mass;
    public float dmg;
    public float critdmg;

    public Gubbe()
    {
        Resethp();
    }

    public void Resethp()
    {
        hp = maxhp;
    }
}
