using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class RoundKeeper : MonoBehaviour
{
    public TMP_Text roundDisplay;
    public int roundCount = 1;

    private void Start()
    {
        UpdateRoundDisplay();
    }
    public void AddRound(int round)
    {
        roundCount += round;
        UpdateRoundDisplay();
    }

    public void UpdateRoundDisplay()
    {
        roundDisplay.text = $"ROUND: {roundCount}";
    }
}
