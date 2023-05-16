using System;

public class HealthSystem{
    private int healthMax;
    private int health;
    public EventHandler OnHealthChanged;
   public HealthSystem(int healthMax)
    {
        this.healthMax= healthMax;
        health = healthMax;
    }
    public int GetHealth()
    {
        return health;
    }
    public void Damage(int damageAmount)
    {
        health -= damageAmount;
        if(health < 0)
        {
            health = 0;
            

        }
        if (OnHealthChanged != null)
        {
            OnHealthChanged(this, EventArgs.Empty);
        }
    }
    public float GetHealthPercent()
    {
        return (float)health / healthMax;
    }
}
