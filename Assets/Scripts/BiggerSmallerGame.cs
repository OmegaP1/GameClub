using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class BiggerSmallerGame : MonoBehaviour
{
    public Image card;
    public Sprite[] DeckOfCards;
    public Text FinalText;
    public Text PlayerName;

    public GameObject UpArrow;
    public GameObject DownArrow;
    public GameObject EqualsButton;
    public GameObject PickACardButton;
    public GameObject CardBack;
    public GameObject Card;
    public GameObject[] Beers;


    public Text[] PlayersList;
    public List<string> ActivePlayers;
    public GameObject CanvasPlayer;
    public GameObject CanvasGame;

    private int CardGenarated;
    private int NumberOFBeer;

    // Start is called before the first frame update
    void Start()
    {
        GeneratePlayers();
    }

    // Update is called once per frame
    void Update()
    {
       

    }

    public void ChangeCard()
    {
        GeneratePlayers();
        GenerateNumberOfDrinks();
        UpArrow.SetActive(true);
        DownArrow.SetActive(true);
        EqualsButton.SetActive(true);
        PickACardButton.SetActive(false);

        Card.SetActive(true);
        CardBack.SetActive(false);

        CardChange();
        
    }

    public void EqualsButtonPressed()
    {
        int helperBeer = NumberOFBeer;
        int helperCard = ValidateCard(CardGenarated);
        CardChange();
        GenerateNumberOfDrinks();
        GeneratePlayers();
        int newhelperCard = ValidateCard(CardGenarated);
        print(helperCard);
        print(newhelperCard);
        if (helperCard == newhelperCard)
        {
            FinalText.color = Color.green;
            FinalText.text = "U Win - Congratz";
        }
        else
        {
            FinalText.color = Color.red;
            FinalText.text = "U lost - Drink   " + (helperBeer + 1) + " sips";
        }
    }

    public void UpButtonPressed()
    {
        int helperBeer = NumberOFBeer;
        int helperCard = ValidateCard(CardGenarated);
        CardChange();
        GenerateNumberOfDrinks();
        GeneratePlayers();
        int newhelperCard = ValidateCard(CardGenarated);
        print(helperCard);
        print(newhelperCard);
        if (helperCard < newhelperCard)
        {
            FinalText.color = Color.green;
            FinalText.text = "U Win - Congratz";
        }
        else
        {
            FinalText.color = Color.red;
            FinalText.text = "U lost - Drink   " + (helperBeer + 1) + " sips";
        }
    }
    public void DownButtonPressed()
    {
        int helperBeer = NumberOFBeer;
        int helperCard = ValidateCard(CardGenarated);
        CardChange();
        GenerateNumberOfDrinks();
        GeneratePlayers();
        int newhelperCard = ValidateCard(CardGenarated);
        print(helperCard);
        print(newhelperCard);
        if (helperCard > newhelperCard)
        {
            FinalText.color = Color.green;
            FinalText.text = "U Win - Congratz";
        }
        else
        {
            FinalText.color = Color.red;
            FinalText.text = "U lost - Drink   " + (helperBeer + 1) + " sips";
        }
    }

    public void PlayBiggerSmaller()
    {
        PlayersVerification();
        CanvasGame.SetActive(true);
        CanvasPlayer.SetActive(false);
    }

    public void PlayersVerification()
    {

        for (int i = 0, b = 0; i < PlayersList.Length; i++)
        {

            if (PlayersList[i].text == "")
            {

            }
            else
            {
                ActivePlayers.Add(PlayersList[i].text);
                b++;
            }

        }
    }


    public void GeneratePlayers()
    {
        PlayerName.text = ActivePlayers[Random.Range(0,ActivePlayers.Count)];
    }


    void CardChange()
    {
        CardGenarated = Random.Range(0, 52);
        card.sprite = DeckOfCards[CardGenarated];

    }
    void GenerateNumberOfDrinks()
    {
        NumberOFBeer = Random.Range(0, 5);
        switch (NumberOFBeer)
        {
            case 0:
                SetBeers(true, false, false, false, false);
                break;
            case 1:
                SetBeers(true, true, false, false, false);
                break;
            case 2:
                SetBeers(true, true, true, false, false);
                break;
            case 3:
                SetBeers(true, true, true, true, false);
                break;
            case 4:
                SetBeers(true, true, true, true, true);
                break;
        }
    }

    void SetBeers(bool a,bool b,bool c,bool d, bool e)
    {
        Beers[0].SetActive(a);
        Beers[1].SetActive(b);
        Beers[2].SetActive(c);
        Beers[3].SetActive(d);
        Beers[4].SetActive(e);
    }
    int ValidateCard(int card)
    {
        if (card == 0 || card == 1 || card == 2 || card == 3)
            return 2;
        else if (card == 4 || card == 5 || card == 6 || card == 7)
            return 3;
        else if (card == 8 || card == 18 || card == 29 || card == 40)
            return 4;
        else if (card == 9 || card == 19 || card == 30 || card == 41)
            return 5;
        else if (card == 10 || card == 20 || card == 31 || card == 42)
            return 6;
        else if (card == 11 || card == 21 || card == 32 || card == 43)
            return 7;
        else if (card == 12 || card == 22 || card == 33 || card == 44)
            return 8;
        else if (card == 13 || card == 23 || card == 34 || card == 45)
            return 9;
        else if (card == 14 || card == 24 || card == 35 || card == 46)
            return 10;
        else if (card == 15 || card == 25 || card == 36 || card == 47)
            return 100;
        else if (card == 16 || card == 26 || card == 37 || card == 48)
            return 12;
        else if (card == 17 || card == 27 || card == 38 || card == 49)
            return 13;
        else if (card == 51 || card == 28 || card == 39 || card == 50)
            return 11;
        else
            return 0;
    }
}
  
