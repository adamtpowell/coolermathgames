using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class WingdingsGame : MonoBehaviour
{

    private float secondsLeft = 60;
    private int score = 0;
    private bool running = true;
    private char currentWingding;

    public TextMeshPro scoreLabel;
    public TextMeshPro timeLabel;
    public TextMeshPro wingdingLabel;

    // Start is called before the first frame update
    void Start()
    {
        currentWingding = GetDing();
    }

    private char GetDing()
    {
        // Generate alphabetical ascii code
        return (char) (Random.value > 0.5f ? Random.Range(65, 91) : Random.Range(97, 123));
    }

    private void UIReact()
    {
        timeLabel.text = Mathf.Floor(secondsLeft).ToString();
        scoreLabel.text = score.ToString();
        wingdingLabel.text = currentWingding.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        UIReact();
        foreach (KeyCode keyCode in System.Enum.GetValues(typeof(KeyCode)))
        {
            char wingdingLower = System.Char.ToLower(currentWingding);
            bool isShiftPressed = Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift);
            bool isKeycodePressed = Input.GetKey(keyCode);
            if ((wingdingLower == currentWingding && (char)keyCode == wingdingLower && !isShiftPressed && isKeycodePressed) || // lowercase
                (wingdingLower != currentWingding && (char)keyCode == wingdingLower && isShiftPressed && isKeycodePressed)) // uppercase
            {
                score += 100;
                currentWingding = GetDing();
            }
        }

        if (secondsLeft < 0.0f)
        {
            //running = false;
        }
        secondsLeft = running ? secondsLeft - Time.deltaTime : 0.0f;
    }
}
