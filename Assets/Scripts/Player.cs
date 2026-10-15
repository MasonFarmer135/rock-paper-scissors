using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    [SerializeField] private Image Image_1;
    [SerializeField] private Image Image_2;
    [SerializeField] private Image Image_3;
    [SerializeField] private Image Image_4;
    [SerializeField] private Image Image_5;
    [SerializeField] private Image Image_6;
    [SerializeField] private Image Image_7;
    [SerializeField] private Image Image_8;
    [SerializeField] private Image Image_9;
    [SerializeField] private Image Image_10;
    [SerializeField] private Image Image_11;
    [SerializeField] private Image Image_12;
    [SerializeField] private Image Image_13;
    [SerializeField] private Image Image_14;
    [SerializeField] private Image Image_15;
    [SerializeField] private Image Image_16;
    [SerializeField] private Image Image_17;
    [SerializeField] private Image Image_18;

    private int Display;
    private float Timer = 0.0f;
    private int userChoice = 0;
    private string userSelection = "";
    private int computerChoice = 0;
    private string computerSelection = "";

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Image_1.enabled = true;
        Image_2.enabled = false;
        Image_3.enabled = false;
        Image_4.enabled = false;
        Image_5.enabled = false;
        Image_6.enabled = false;
        Image_7.enabled = false;
        Image_8.enabled = false;
        Image_9.enabled = false;
        Image_10.enabled = false;
        Image_11.enabled = false;
        Image_12.enabled = false;
        Image_13.enabled = false;
        Image_14.enabled = false;
        Image_15.enabled = false;
        Image_16.enabled = false;
        Image_17.enabled = false;
        Image_18.enabled = false;

        Display = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (Gamepad.all.Count > 0)
        {
            Image_1.enabled = false;

            if (Display == 1)
            {
                Image_2.enabled = true;
                Timer += Time.deltaTime;
                if (Timer >= 4)
                {
                    Timer = 0.0f;
                    Display = 2;
                }
            }
            else if (Display == 2)
            {
                Image_2.enabled = false;
                Image_3.enabled = true;
            }
            else if (Display == 3)
            {
                Image_3.enabled = false;

                if (userChoice == 1)
                {
                    Image_4.enabled = true;
                    Image_5.enabled = false;
                    Image_6.enabled = false;
                }
                else if (userChoice == 2)
                {
                    Image_4.enabled = false;
                    Image_5.enabled = true;
                    Image_6.enabled = false;
                }
                else if (userChoice == 3)
                {
                    Image_4.enabled = false;
                    Image_5.enabled = false;
                    Image_6.enabled = true;
                }
            }
            else if (Display == 4)
            {
                Image_4.enabled = false;
                Image_5.enabled = false;
                Image_6.enabled = false;
                Image_7.enabled = true;

                Timer += Time.deltaTime;
                if (Timer >= 1)
                {
                    Timer = 0.0f;
                    Display = 5;
                }
            }
            else if (Display == 5)
            {
                Image_7.enabled = false;
                Image_8.enabled = true;

                Timer += Time.deltaTime;
                if (Timer >= 1)
                {
                    Timer = 0.0f;
                    Display = 6;
                }
            }
            else if (Display == 6)
            {
                Image_8.enabled = false;
                Image_9.enabled = true;

                Timer += Time.deltaTime;
                if (Timer >= 1)
                {
                    Timer = 0.0f;
                    Display = 7;
                }
            }
            else if (Display == 7)
            {
                Image_9.enabled = false;
                Image_10.enabled = true;

                if (computerChoice == 0)
                {
                    computerChoice = Random.Range(1,4);

                    if (computerChoice == 1)
                    {
                        computerSelection = "ROCK";
                    }
                    else if (computerChoice == 2)
                    {
                        computerSelection = "PAPER";
                    }
                    else if (computerChoice == 3)
                    {
                        computerSelection = "SCISSORS";
                    }
                }

                Timer += Time.deltaTime;
                if (Timer >= 1.5)
                {
                    Timer = 0.0f;
                    Display = 8;
                }
            }
            else if (Display == 8)
            {
                Image_10.enabled = false;

                if (computerSelection == "ROCK")
                {
                    Image_11.enabled = true;

                    Timer += Time.deltaTime;
                    if (Timer >= 3)
                    {
                        Timer = 0.0f;
                        computerChoice = 0;
                        Display = 9;
                    }
                }
                else if (computerSelection == "PAPER")
                {
                    Image_12.enabled = true;

                    Timer += Time.deltaTime;
                    if (Timer >= 3)
                    {
                        Timer = 0.0f;
                        computerChoice = 0;
                        Display = 9;
                    }
                }
                else if (computerSelection == "SCISSORS")
                {
                    Image_13.enabled = true;
                    
                    Timer += Time.deltaTime;
                    if (Timer >= 3)
                    {
                        Timer = 0.0f;
                        computerChoice = 0;
                        Display = 9;
                    }
                }
            }
            else if (Display == 9)
            {
                Image_11.enabled = false;
                Image_12.enabled = false;
                Image_13.enabled = false;

                if (userSelection == computerSelection)
                {
                    Image_1.enabled = true;
                    Image_2.enabled = false;
                    Image_3.enabled = false;
                    Image_4.enabled = false;
                    Image_5.enabled = false;
                    Image_6.enabled = false;
                    Image_7.enabled = false;
                    Image_8.enabled = false;
                    Image_9.enabled = false;
                    Image_10.enabled = false;
                    Image_11.enabled = false;
                    Image_12.enabled = false;
                    Image_13.enabled = false;
                    Image_14.enabled = false;
                    Image_15.enabled = false;
                    Image_16.enabled = false;
                    Image_17.enabled = false;
                    Image_18.enabled = false;

                    Display = 2;
                    Timer = 0.0f;
                    userChoice = 0;
                    userSelection = "";
                    computerChoice = 0;
                    computerSelection = "";
                }
                else if (userSelection == "ROCK" && computerSelection == "PAPER")
                {
                    Image_15.enabled = true;

                    Timer += Time.deltaTime;
                    if (Timer >= 3)
                    {
                        Timer = 0.0f;
                        userSelection = "";
                        computerSelection = "";
                        Display = 10;
                    }
                }
                else if (userSelection == "ROCK" && computerSelection == "SCISSORS")
                {
                    Image_14.enabled = true;

                    Timer += Time.deltaTime;
                    if (Timer >= 3)
                    {
                        Timer = 0.0f;
                        userSelection = "";
                        computerSelection = "";
                        Display = 10;
                    }
                }
                else if (userSelection == "PAPER" && computerSelection == "ROCK")
                {
                    Image_14.enabled = true;

                    Timer += Time.deltaTime;
                    if (Timer >= 3)
                    {
                        Timer = 0.0f;
                        userSelection = "";
                        computerSelection = "";
                        Display = 10;
                    }
                }
                else if (userSelection == "PAPER" && computerSelection == "SCISSORS")
                {
                    Image_15.enabled = true;

                    Timer += Time.deltaTime;
                    if (Timer >= 3)
                    {
                        Timer = 0.0f;
                        userSelection = "";
                        computerSelection = "";
                        Display = 10;
                    }
                }
                else if (userSelection == "SCISSORS" && computerSelection == "ROCK")
                {
                    Image_15.enabled = true;

                    Timer += Time.deltaTime;
                    if (Timer >= 3)
                    {
                        Timer = 0.0f;
                        userSelection = "";
                        computerSelection = "";
                        Display = 10;
                    }
                }
                else if (userSelection == "SCISSORS" && computerSelection == "PAPER")
                {
                    Image_14.enabled = true;

                    Timer += Time.deltaTime;
                    if (Timer >= 3)
                    {
                        Timer = 0.0f;
                        userSelection = "";
                        computerSelection = "";
                        Display = 10;
                    }
                }
            }
            else if (Display == 10)
            {
                Image_14.enabled = false;
                Image_15.enabled = false;
                Image_16.enabled = true;
            }
            else if (Display == 11)
            {
                Image_16.enabled = false;

                if (userChoice == 1)
                {
                    Image_17.enabled = false;
                    Image_18.enabled = true;
                }
                else if (userChoice == 2)
                {
                    Image_17.enabled = true;
                    Image_18.enabled = false;
                }

            }
            else if (Display == 12)
            {
                Image_17.enabled = false;
                Image_18.enabled = true;
                
                Application.Quit();
            }
        }
        else
        {
            if (Display != 12)
            {
                Image_1.enabled = true;
                Image_2.enabled = false;
                Image_3.enabled = false;
                Image_4.enabled = false;
                Image_5.enabled = false;
                Image_6.enabled = false;
                Image_7.enabled = false;
                Image_8.enabled = false;
                Image_9.enabled = false;
                Image_10.enabled = false;
                Image_11.enabled = false;
                Image_12.enabled = false;
                Image_13.enabled = false;
                Image_14.enabled = false;
                Image_15.enabled = false;
                Image_16.enabled = false;
                Image_17.enabled = false;
                Image_18.enabled = false;
            }
        }
    }

    public void Select(InputAction.CallbackContext context)
    {
        if (context.started == true)
        {
            if (Display == 3)
            {
                if (userChoice == 1)
                {
                    userSelection = "ROCK";
                    userChoice = 0;
                }
                else if (userChoice == 2)
                {
                    userSelection = "PAPER";
                    userChoice = 0;
                }
                else if (userChoice == 3)
                {
                    userSelection = "SCISSORS";
                    userChoice = 0;
                }
                
                Display = 4;
            }
            else if (Display == 11)
            {
                if (userChoice == 1)
                {
                    Display = 12;
                }
                else if (userChoice == 2)
                {
                    Image_1.enabled = true;
                    Image_2.enabled = false;
                    Image_3.enabled = false;
                    Image_4.enabled = false;
                    Image_5.enabled = false;
                    Image_6.enabled = false;
                    Image_7.enabled = false;
                    Image_8.enabled = false;
                    Image_9.enabled = false;
                    Image_10.enabled = false;
                    Image_11.enabled = false;
                    Image_12.enabled = false;
                    Image_13.enabled = false;
                    Image_14.enabled = false;
                    Image_15.enabled = false;
                    Image_16.enabled = false;
                    Image_17.enabled = false;
                    Image_18.enabled = false;

                    Display = 2;
                    Timer = 0.0f;
                    userChoice = 0;
                    userSelection = "";
                    computerChoice = 0;
                    computerSelection = "";
                }
            }
        }
    }

    public void Up(InputAction.CallbackContext context)
    {
        if (context.started == true)
        {
            if (Display == 10)
            {
                Display = 11;
                userChoice = 2;
            }
            else if (Display == 11)
            {
                if (userChoice < 2)
                {
                    userChoice = userChoice + 1;
                }
                else
                {
                    userChoice = 1;
                }
            }
        }
    }

    public void Down(InputAction.CallbackContext context)
    {
        if (context.started == true)
        {
            if (Display == 10)
            {
                Display = 11;
                userChoice = 1;
            }
            else if (Display == 11)
            {
                if (userChoice > 1)
                {
                    userChoice = userChoice - 1;
                }
                else
                {
                    userChoice = 2;
                }
            }
        }
    }

    public void Left(InputAction.CallbackContext context)
    {
        if (context.started == true)
        {
            if (Display == 2)
            {
                Display = 3;
                userChoice = 1;
            }
            else if (Display == 3)
            {
                if (userChoice > 1)
                {
                    userChoice = userChoice - 1;
                }
                else
                {
                    userChoice = 3;
                }
            }
        }
    }

    public void Right(InputAction.CallbackContext context)
    {
        if (context.started == true)
        {
            if (Display == 2)
            {
                Display = 3;
                userChoice = 2;
            }
            else if (Display == 3)
            {
                if (userChoice < 3)
                {
                    userChoice = userChoice + 1;
                }
                else
                {
                    userChoice = 1;
                }
            }
        }
    }
}
