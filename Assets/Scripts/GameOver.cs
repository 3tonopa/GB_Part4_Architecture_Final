using UnityEngine;
using UnityEngine.UI;
namespace Snake
{
    public class GameOver
    {
        public GameOver()
        {


            GameObject canvas = new GameObject();
            canvas.name = "Canvas";
            canvas.AddComponent<Canvas>();
            canvas.AddComponent<CanvasScaler>();
            canvas.AddComponent<GraphicRaycaster>();
            Vector2 screen;
            if (Screen.width < Screen.height)
                screen = new Vector2(Screen.width, Screen.width / 1.78f);
            else
                screen = new Vector2(Screen.width, Screen.height);
            canvas.transform.position = screen;
            canvas.GetComponent<RectTransform>().sizeDelta = screen;
            canvas.GetComponent<Canvas>().sortingOrder = 4;
            canvas.GetComponent<Canvas>().renderMode = RenderMode.ScreenSpaceOverlay;


            GameObject textHandler = new GameObject();
            textHandler.name = "Text";
            RectTransform handler = textHandler.AddComponent(typeof(RectTransform)) as RectTransform;
            textHandler.transform.SetParent(canvas.transform);
            handler.sizeDelta = new Vector2(1000, 450);
            Text screenText = textHandler.AddComponent<Text>();
            screenText.alignment = TextAnchor.MiddleCenter;
            screenText.font = Resources.Load<Font>("foo");
            screenText.fontSize = 100;
            screenText.color = Color.red;
            screenText.transform.localPosition = new Vector2(0, 0);
            screenText.text = "GAME OVER";
        }

    }
}
