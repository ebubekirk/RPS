using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour {

    public Image[] opponentImages, playerImages;

    private int prize, opponentSelection;

    public void Initialize(int prize)
    {
        Utility.mainObject.SetActive(false);
        gameObject.SetActive(true);
        this.prize = prize;

        Reset();

        for (int i = 0; i < playerImages.Length; i++)
        {
            playerImages[i].fillAmount = 1;
            playerImages[i].GetComponent<Button>().onClick.RemoveAllListeners();
            int temp = i;
            playerImages[i].GetComponent<Button>().onClick.AddListener(() => PlayerButtonClicked(temp));
        }
    }

    void Reset()
    {
        opponentSelection = Random.Range(0, 3);
        for (int i = 0; i < opponentImages.Length; i++)
            opponentImages[i].fillAmount = 0;
        opponentImages[opponentSelection].fillAmount = 1;
    }

    void PlayerButtonClicked(int playerSelection)
    {
        if ( playerSelection == opponentSelection)
        {
            Reset();
            return;
        }

        if ((playerSelection - opponentSelection) == 1 || (playerSelection - opponentSelection) == -2)
            PlayerWin();
        else
            OpponentWin();
    }

    void PlayerWin()
    {
        Utility.money += prize;

        Utility.uiController.Initialize();
    }

    void OpponentWin()
    {
        Utility.money -= prize*2;

        Utility.uiController.Initialize();
    }
}
