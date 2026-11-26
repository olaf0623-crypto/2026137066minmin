using UnityEngine;

public class FunctionPractice : MonoBehaviour
{
    string GetGrade(int score)
    {
        if (score >= 90) return "A";
        if (score >= 70) return "B";
        return "C";

    }

    [ContextMenu("함수 실습")]

    void ShowGrades()
    {
        Debug.Log("95점" + GetGrade(95));
        Debug.Log("70점" + GetGrade(70));
        Debug.Log("10점" + GetGrade(10));
    }
}
