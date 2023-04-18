using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Snake
{
    public class Launcher : MonoBehaviour
    {
        public float nextTime = 0.5f;
        public int score = 0;
        public bool deploy = true;
        private int targetNum = 0;
        private Text screenText;
        private Text scoreText;

        void Start()
        {
            new CreateLevel();
            new CreatePlayer();
            CreateUI();
        }
        private void CreateUI()
        {
            new CreateGUI().CreateCanvas();
            screenText = new CreateGUI().ScreenText();
            scoreText = new CreateGUI().ScoreText();
        }
        public void GameOver()
        {
            Time.timeScale = 0;
            screenText.text = "GAME OVER";
        }

        void Update()
        {
            if (deploy)
            {
                new CreateTarget(targetNum);
                targetNum += 1;
                nextTime -= 0.01f;
                scoreText.text = $"{score}";
                deploy = false;
            }
        }
    }
}