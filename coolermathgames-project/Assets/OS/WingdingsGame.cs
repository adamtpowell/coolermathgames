using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class WingdingsGame : MonoBehaviour
{

    private float secondsLeft = 0;
    private int score = 0;
    private bool running = false;
    private char currentWingding;

    public TextMeshPro scoreLabel;
    public TextMeshPro timeLabel;
    public TextMeshPro wingdingLabel;
    public TextMeshPro gameoverLabel;

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

        gameoverLabel.GetComponent<MeshRenderer>().enabled = !running;
        wingdingLabel.GetComponent<MeshRenderer>().enabled = running;

    }

    private void RestartGame()
    {
        secondsLeft = 60f;
        score = 0;
        running = true;
        currentWingding = GetDing();
    }

    // Update is called once per frame
    void Update()
    {
        UIReact();
        if (running)
        {
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
        } else
        {
            if (Input.GetKey(KeyCode.Space))
            {
                RestartGame();
            }
        }
        
        if (secondsLeft < 0.0f)
        {
            running = false;
        }
        secondsLeft = running ? secondsLeft - Time.deltaTime : 0.0f;
    }
}
