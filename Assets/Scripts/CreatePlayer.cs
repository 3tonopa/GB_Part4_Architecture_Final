using UnityEngine;
namespace Snake
{
    public class CreatePlayer
    {
        public CreatePlayer()
        {
            GameObject go = new GameObject();
            go.name = "Player";
            go.tag = "Player";
            go.AddComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Circle");
            go.GetComponent<SpriteRenderer>().color = Color.green;
            go.GetComponent<SpriteRenderer>().sortingOrder = 2;
            Rigidbody2D pRigidbody = go.AddComponent<Rigidbody2D>();
            go.AddComponent<CircleCollider2D>();
            go.AddComponent<Player>();
            go.GetComponent<Transform>().localScale = new Vector2(0.5f, 0.5f);
            pRigidbody.constraints = RigidbodyConstraints2D.FreezeAll;
        }
    }
}