using UnityEngine;
using CodeMonkey;

public class GameHandler : MonoBehaviour {
    private void Start() {
        HealthSystem healthSystem = new HealthSystem(100);

        Debug.Log("Health: " + healthSystem.GetHealth());
        CMDebug.ButtonUI(new Vector2(100, 100), "damage", () =>
        {
            healthSystem.Damage(10);
            Debug.Log("Damaged: " + healthSystem.GetHealth());
        });
        CMDebug.ButtonUI(new Vector2(-100, 100), "heal", () =>
        {
            healthSystem.Heal(10);
            Debug.Log("Healed: " + healthSystem.GetHealth());
        });
    }
}

