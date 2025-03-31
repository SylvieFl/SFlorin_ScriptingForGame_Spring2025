using UnityEngine;

public class Mammal : Animal
{
    protected virtual void Start() //"protected" will make this public to children classes, but nothing else.
    {
        bType = BloodType.WarmBlooded;
    }

    public override void Eat(int energyGained)
    {
        Debug.Log("Chomp Chomp eating with my mouth");
        base.Eat(energyGained);
    }

    public virtual void GiveBirth()
    {
        Debug.Log("Giving birth to a mammal");
    }
}
