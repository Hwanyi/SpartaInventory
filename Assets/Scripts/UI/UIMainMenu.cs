using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIMainMenu : UIBase
{
    UIManager manager;

    public GameObject buttons;
    public Button returnBtn;
    public Button statusBtn;
    public Button inventoryBtn;

    public TextMeshProUGUI playerNameTxt;
    public TextMeshProUGUI playerDescriptionTxt;
    public TextMeshProUGUI playerLevelTxt;
    public TextMeshProUGUI playerExpTxt;
    public Image playerExpImage;

    public TextMeshProUGUI goldTxt;

    private void Start()
    {
        manager = UIManager.instance;
        returnBtn.onClick.AddListener(OpenMainMenu);
        statusBtn.onClick.AddListener(OpenStatus);
        inventoryBtn.onClick.AddListener(OpenInventory);

        SetUI();
    }

    public void OpenMainMenu()
    {
        buttons.SetActive(true);
        returnBtn.gameObject.SetActive(false);
        manager.UIInventory.gameObject.SetActive(false);
        manager.UIStatus.gameObject.SetActive(false);
    }

    public void OpenStatus()
    {
        buttons.SetActive(false);
        returnBtn.gameObject.SetActive(true);
        manager.UIStatus.gameObject.SetActive(true);
    } 
    
    public void OpenInventory()
    {
        buttons.SetActive(false);
        returnBtn.gameObject.SetActive(true);
        manager.UIInventory.gameObject.SetActive(true);
    }

    public void SetUI()
    {
        Character info = GameManager.Instance.CharacterInfo;
        playerNameTxt.text = info.PlayerName;
        playerDescriptionTxt.text = info.PlayerDescription;
        playerLevelTxt.text = $"LV. {info.Level}";
        playerExpTxt.text = $"{info.Exp} / {info.maxExp[info.Level]}";
        playerExpImage.fillAmount = (float)info.Exp / info.maxExp[info.Level];
        goldTxt.text = info.Gold.ToString("N0");
    }
}
