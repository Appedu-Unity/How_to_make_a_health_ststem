using System;
public class HealthSystem
{
    /// <summary>
    /// 血條觸發事件
    /// </summary>
    public event EventHandler OnHealthChanged;  

    private int health;
    private int healthMax;
    /// <summary>
    /// 狀態
    /// </summary>
    /// <param name="health"></param>
    public HealthSystem(int healthMax) {
        this.healthMax = healthMax;
        health = healthMax;
    }
    /// <summary>
    /// 獲取血量信息
    /// </summary>
    /// <returns></returns>
    public int GetHealth()
    {
        return health;
    }
    /// <summary>
    /// 獲取血量百分比
    /// </summary>
    /// <returns></returns>
    public float GetHealthPercent()
    {
        return (float) health / healthMax;
    }
    /// <summary>
    /// 受到傷害
    /// </summary>
    /// <param name="damageAmount"></param>
    public void Damage(int damageAmount)
    {
        health -= damageAmount;
        if (health < 0) health = 0;//血量不得低於0
        if(OnHealthChanged != null) OnHealthChanged(this,EventArgs.Empty); //EventArgs為儲存重要信息之使用
    }
    /// <summary>
    /// 血量補給
    /// </summary>
    /// <param name="healAmount"></param>
    public void Heal(int healAmount)
    {
        health += healAmount;
        if (health > healthMax) health = healthMax;//血量不得高於100
        if (OnHealthChanged != null) OnHealthChanged(this, EventArgs.Empty); //EventArgs為儲存重要信息之使用
    }
}
