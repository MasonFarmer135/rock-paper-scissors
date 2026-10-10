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

    private int Display;
    private float Timer = 0.0f;
    private int userChoice = 2;
    private string userSelection = "";

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
                if (Timer >= 2)
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
                if (Timer >= 2)
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
                if (Timer >= 2)
                {
                    Timer = 0.0f;
                    Display = 7;
                }
            }
            else if (Display == 7)
            {
                Image_9.enabled = false;
                Image_10.enabled = true;

                Timer += Time.deltaTime;
                if (Timer >= 2)
                {
                    Timer = 0.0f;
                    Display = 8;
                }
            }
            else if (Display == 8)
            {
                Image_10.enabled = false;
            }
        }
        else
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
                    Debug.Log(userSelection);
                }
                else if (userChoice == 2)
                {
                    userSelection = "PAPER";
                    Debug.Log(userSelection);
                }
                else if (userChoice == 3)
                {
                    userSelection = "SCISSORS";
                    Debug.Log(userSelection);
                }
                
                Display = 4;
            }
        }
    }

    public void Up(InputAction.CallbackContext context)
    {
        if (context.started == true)
        {
            Debug.Log("Up!");
        }
    }

    public void Down(InputAction.CallbackContext context)
    {
        if (context.started == true)
        {
            Debug.Log("Down!");
        }
    }

    public void Left(InputAction.CallbackContext context)
    {
        if (context.started == true)
        {
            if (Display == 2)
            {
                Display = 3;
                userChoice = userChoice - 1;
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
                userChoice = userChoice + 1;
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
