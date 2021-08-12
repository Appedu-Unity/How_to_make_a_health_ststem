using UnityEngine;
using CodeMonkey;

public class GameHandler : MonoBehaviour {
    [Tooltip("預製物位置")]
    public Transform pfHealthBar;
    private void Start() {
        HealthSystem healthSystem = new HealthSystem(100);

        Transform healthBarTransform = Instantiate(pfHealthBar, new Vector3(0, 10), Quaternion.identity);
        HealthBar healthBar = healthBarTransform.GetComponent<HealthBar>();//獲取物件信息
        healthBar.Setup(healthSystem);

        Debug.Log("Health: " + healthSystem.GetHealthPercent());
        healthSystem.Damage(10);
        Debug.Log("Health:" + healthSystem.GetHealthPercent());

        CMDebug.ButtonUI(new Vector2(100, 100), "damage", () => //Codemonkey物件按鈕系統(損失血量)
        {
            healthSystem.Damage(10);
            Debug.Log("Damaged: " + healthSystem.GetHealth());
        });
        CMDebug.ButtonUI(new Vector2(-100, 100), "heal", () =>  //Codemonkey物件按鈕系統(增加血量)
        {
            healthSystem.Heal(10);
            Debug.Log("Healed: " + healthSystem.GetHealth());
        });
    }
}

