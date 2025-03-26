using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIStatus : UIBase
{
    public TextMeshProUGUI playerAttackTxt;
    public TextMeshProUGUI playerDefenseTxt;
    public TextMeshProUGUI playerHealthTxt;
    public TextMeshProUGUI playerCriticalTxt;

    private void Start()
    {
        SetUI();
    }

    public void SetUI()
    {
        Character info = GameManager.Instance.CharacterInfo;
        playerAttackTxt.text = info.Attack.ToString();
        playerDefenseTxt.text = info.Defense.ToString();
        playerHealthTxt.text = info.Health.ToString();
        playerCriticalTxt.text = info.Critical.ToString();
    }

    public override void RefreshUI()
    {
        SetUI();
    }
}
