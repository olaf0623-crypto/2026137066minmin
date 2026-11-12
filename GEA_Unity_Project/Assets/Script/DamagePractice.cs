using UnityEngine;
using UnityEngine.UI;

public class DamagePractice : MonoBehaviour
{
    public int attack;
    public int defense;
    public bool isCritical;
    public bool targetIsBoss;


    [ContextMenu("데미지")]
    void Calc()
    {
        int damage = attack - defense;

        if(damage < 1)
        {
            damage = 1;
        }
        if(isCritical)
        {
            damage = damage * 2;
        }
        if (targetIsBoss)
        {
            damage = damage / 2;
        }
        Debug.Log(damage);

    }

    [ContextMenu("계단")]
    void Stairs()
    {
        int height = 3;
        string text = "";

        for (int row = 1; row <= height; row++)
        {
            for (int col = 0; col < row; col++)
            {
                text += "*";
            }

            text += "\n";

        }
    }
    
}
