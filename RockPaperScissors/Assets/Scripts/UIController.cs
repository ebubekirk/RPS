using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    public Text moneyText;
    private int money = 0;

    public GameObject mainMenu;
    public GameController gameMenu;

    public void Initialize()
    {
        Utility.mainObject = mainMenu;
        Utility.gameController = gameMenu;

        gameObject.SetActive(true);

        mainMenu.SetActive(true);
        gameMenu.gameObject.SetActive(false);
    }


    void Update()
    {
        if (money == Utility.money)
            return;

        money = Utility.money;
        moneyText.text = money + "";
    }
}
