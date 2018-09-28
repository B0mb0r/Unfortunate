using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConditionsUppgifter : MonoBehaviour
{
    private int userValue;
    private int Dice = 10;
    private int DragonHP;
    private int DragonATK;
    private int PlayerHP = 100;
    private int secondD;
    private int MinATK;
    private int MaxATK;
    private int CRIT;
    private int HLNum = 50;
    private int oldHLNum;
    private int HLScore;
    private int HLHighscore;
    // Use this for initialization
    void Start()
    {
        //dragon game
        DragonHP = Random.Range(100, 151);
        secondD = secondD + Random.Range(1, 11);
        if(secondD == 1)
        {
            DragonHP = DragonHP * 2;
        }
        MinATK = Random.Range(1, 11);
        MaxATK = Random.Range(20, 31);
        //Higher lower game
        print(string.Format("Higher or lower than:" + HLNum));
    }

    // Update is called once per frame
    void Update()
    {
        //Numbers game
        if (Input.GetKeyDown(KeyCode.LeftArrow)) 
        {
            userValue = userValue + 2;
        }
        if (Input.GetKeyDown(KeyCode.RightArrow)) 
        {
            userValue = userValue / 2;
        }
        if (Input.GetKeyDown(KeyCode.UpArrow)) 
        {
            print(userValue);
        }
        //Dice game
        if (Input.GetKeyDown(KeyCode.R))
        {
            Dice = Dice + Random.Range(1, 7);
            Dice = Dice - Random.Range(1, 7);
            print(Dice);
        }
        if(Dice >= 20)
        {
            print("YOU WIN");
        }
        if(Dice <= 0)
        {
            print("YOU LOSE");
        }
        //Dragon game
        if (Input.GetKeyDown(KeyCode.Space))
        {
            DragonATK = Random.Range(1, 3);
            if (DragonATK == 2)
            {
                PlayerHP = PlayerHP - Random.Range(10, 21);
            }
            DragonHP = DragonHP - Random.Range(MinATK, MaxATK);
            CRIT = Random.Range(1, 21);
            if(CRIT == 1)
            {
                DragonHP = 0;
            }

            print(string.Format(
                "DragonHP:" + DragonHP));
            print(string.Format(
                "PlayerHP:" + PlayerHP));

            if (DragonHP <= 0)
            {
                print("Player wins!");
            }
            if (PlayerHP <= 0)
            {
                print("Dragon wins!");
            }
        }
        //Higher Lower game
        if (Input.GetKeyDown(KeyCode.Y))
        {
            oldHLNum = HLNum;
            HLNum = Random.Range(1, 101);
            if(HLNum >= oldHLNum)
            {
                HLScore = HLScore + 1;
                print(string.Format(
                    "Score:" + HLScore));
                print(string.Format(
                    "Higher or lower than:" + HLNum));
            }
            if(HLNum < oldHLNum)
            {
                print(string.Format(
                    "YOU LOSE, your score:" + HLScore));
                print(string.Format(
                    "Highscore:" + HLHighscore));
                HLNum = 50;
                print(string.Format(
                    "Higher or lower than:" + HLNum));
            }
            
        }
        if (Input.GetKeyDown(KeyCode.H))
        {
            oldHLNum = HLNum;
            HLNum = Random.Range(1, 101);
            if(HLNum <= oldHLNum)
            {
                HLScore = HLScore + 1;
                print(string.Format(
                    "Score:" + HLScore));
                print(string.Format(
                    "Higher or lower than:" + HLNum));
            }
            if (HLNum > oldHLNum)
            {
                print(string.Format(
                    "YOU LOSE, your score:" + HLScore));
                print(string.Format(
                    "Highscore:" + HLHighscore));
                HLNum = 50;
                print(string.Format(
                    "Higher or lower than:" + HLNum));
            }
            
        }
        if (HLScore > HLHighscore)
        {
            HLHighscore = HLScore;
        }
    }
}
