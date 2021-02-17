using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class BSGame1 : MonoBehaviour
{
    public Image card;
    public Sprite[] DeckOfCards;

    public GameObject UpArrow;
    public GameObject DownArrow;
    public GameObject EqualsButton;
    public GameObject PickACardButton;
    public GameObject CardBack;
    public GameObject Card;
    public GameObject[] Beers;

    private int GameCard;
    private int CardGenarated;
    private int NewCardGenarated;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {


    }

    public void ChangeCard()
    {
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
        validateCard(CardGenarated);
        CardChange();
        GenerateNumberOfDrinks();
        validateCard(NewCardGenarated);
        if (CardGenarated == NewCardGenarated)
        {
            //Gannho
            print("ganhou");
        }
        else
        {
            //bebe
            print("bebe");
        }
    }

    public void UpButtonPressed()
    {
        validateCard(CardGenarated);
        CardChange();
        GenerateNumberOfDrinks();
        validateCard(NewCardGenarated);
        if (CardGenarated > NewCardGenarated)
        {
            //Gannho
            print("ganhou");
        }
        else
        {
            //bebe
            print("bebe");
        }
    }
    public void DownButtonPressed()
    {
        validateCard(CardGenarated);
        CardChange();
        GenerateNumberOfDrinks();
        validateCard(NewCardGenarated);
        if (CardGenarated < NewCardGenarated)
        {
            //Gannho
            print("ganhou");
        }
        else
        {
            //bebe
            print("bebe");
        }
    }


    void CardChange()
    {
        CardGenarated = Random.Range(0, 52);
        NewCardGenarated = Random.Range(0, 52);
        card.sprite = DeckOfCards[CardGenarated];

    }
    void GenerateNumberOfDrinks()
    {
        switch (Random.Range(0,5))
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
    void validateCard(int card)
    {
        switch (card)
        {
            case 0 or 1 or 2 or 3:
                //2
                GameCard = 2;
                break;
            case 4 or 5 or 6 or 7:
                //3
                GameCard = 3;
                break;
            case 8 or 18 or 29 or 40:
                //4
                GameCard = 4;
                break;
            case 9 or 19 or 30 or 41:
                //5
                GameCard = 5;
                break;
            case 10 or 20 or 31 or 42:
                //6
                GameCard = 6;
                break;
            case 11 or 21 or 32 or 43:
                //7
                GameCard = 7;
                break;
            case 12 or 22 or 33 or 44:
                //8
                GameCard = 8;
                break;
            case 13 or 23 or 34 or 45:
                //9
                GameCard = 9;
                break;
            case 14 or 24 or 35 or 46:
                //10
                GameCard = 10;
                break;
            case 15 or 25 or 36 or 47:
                //Ace
                GameCard = 100;
                break;
            case 16 or 26 or 37 or 48:
                //J
                GameCard = 12;
                break;
            case 17 or 27 or 38 or 49:
                //K
                GameCard = 13;
                break;
            case 51 or 28 or 39 or 50:
                //Q
                GameCard = 11;
                break;
        }
    }
}
  
