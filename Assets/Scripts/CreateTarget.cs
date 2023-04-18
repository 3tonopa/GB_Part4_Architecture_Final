using UnityEngine;
namespace Snake
{
    public class CreateTarget
    {
        public CreateTarget(int number)
        {
            GameObject go = new GameObject();
            go.name = $"target0{number}";
            go.tag = "target";
            go.AddComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Circle");
            go.GetComponent<SpriteRenderer>().color = Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f);
            go.GetComponent<SpriteRenderer>().sortingOrder = 1;
            Rigidbody2D pRigidbody = go.AddComponent<Rigidbody2D>();
            go.AddComponent<CircleCollider2D>();
            go.GetComponent<Transform>().localScale = new Vector2(0.45f,0.45f);
            pRigidbody.constraints = RigidbodyConstraints2D.FreezeAll;
            go.transform.position = new Vector2(Random.Range(-8,9), Random.Range(-4,5));
        }
    }    
}