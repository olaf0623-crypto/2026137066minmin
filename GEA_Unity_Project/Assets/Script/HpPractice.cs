using UnityEngine;

public class HpPractice : MonoBehaviour
{
    public int currentHP;
    public int maxHP;

    [ContextMenu("체력")]

    void PrintHP()
    {
        int b = 100 * currentHP / maxHP;
        Debug.Log("HP" + b + "%");
    }
}
