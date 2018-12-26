using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemController : MonoBehaviour
{
    public Button button;

    void Start()
    {
        button.onClick.RemoveAllListeners();
        button.onClick.AddListener(ButtonClicked);
    }

    void ButtonClicked()
    {
        int prize = -1;
        int.TryParse(button.gameObject.transform.GetChild(0).gameObject.GetComponent<Text>().text, out prize);

        if (prize == -1 || prize > Utility.money)
            return;

        Utility.gameController.Initialize(prize/2);
    }
}
