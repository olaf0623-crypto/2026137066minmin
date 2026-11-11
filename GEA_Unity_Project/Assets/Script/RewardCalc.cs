using UnityEngine;

public class RewardCalc : MonoBehaviour
{
    public int playSeconds = 3725;
    public int gold = 1234;
    public int members = 4;
    public int kills = 7;
    public int expPerKill = 35;
    public int totalDamage = 250;
    public int hits = 20;
    public float expRate = 1.5f;
    [ContextMenu("정산")]

    void Reward()
    {
        Debug.Log("플레이타임" + playSeconds);
        Debug.Log("골드" + gold);
        Debug.Log("멤버" + members);
        Debug.Log("킬" + kills);
        Debug.Log("경험치" + expPerKill);
        Debug.Log("최대 데미지" + totalDamage);
        Debug.Log("타격" + hits);
        Debug.Log("경험치 획득 배율" + expRate);
    }

    void Start()
    {
        int hours = playSeconds / 3600;
        int minutes = playSeconds / 60 % 60;
        int seconds = playSeconds % 60;

        Debug.Log("플레이타임" + (hours) + "시간" + (minutes) + "분" + (seconds) + "초");

        int perGold = gold / members;
        int leaderBonus = gold % members;
        
        Debug.Log("1인당 " + perGold + "G, 리더 보너스 " + leaderBonus + "G");

        int baseExp = kills * expPerKill;
        int totalExp = (int)(baseExp * expRate);

        Debug.Log("경험치 " + totalExp + " (기본 " + baseExp + ")");

        int level = 1 + (totalExp / 100);
        int nextExp = 100 - (totalExp % 100);

        Debug.Log("Lv " + level + ", 다음 레벨까지 " + nextExp);

        float avgDamage = (float)totalDamage / hits;

        Debug.Log("평균 데미지 " + avgDamage);
    }
}
