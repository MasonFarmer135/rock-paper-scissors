using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    [SerializeField] private Image Image_1;
    [SerializeField] private Image Image_2;

    private int Display;
    private float Timer = 4.0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Image_1.enabled = true;
        Image_2.enabled = false;

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
                Timer -= Time.deltaTime;
                if (Timer <= 0)
                {
                    Display = 2;
                    Timer = 4.0f;
                }
            }
            else if (Display == 2)
            {
                Image_2.enabled = false;
            }
        }
        else
        {
            Image_1.enabled = true;
            Image_2.enabled = false;
        }
    }
}
