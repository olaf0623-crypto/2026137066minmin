using UnityEngine;

public class StartPractice : MonoBehaviour
{
    public string playerName = "오승민";
    public int Level = 99;
    public float Attack = 12.5f;
    public bool isBoss = false;

    [ContextMenu("스탯")]
    void ShowStat()
    {
        Debug.Log("플레이어 이름: " + playerName);
        Debug.Log("레벨 : " + Level);
        Debug.Log("공격력 : " + Attack);
        Debug.Log("보스 여부 : " + isBoss);
    }

    public string itemName = "포션";
    public int price = 30;
    public float discount = 0.5f;
    public bool isSoldOut = false;

    [ContextMenu("가격")]
    void ShowPrice()
    {
        float finalPrice = price * discount;
        Debug.Log(itemName + " " + finalPrice);
    }

}
