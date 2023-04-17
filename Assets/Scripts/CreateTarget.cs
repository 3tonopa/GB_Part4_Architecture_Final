using UnityEngine;
namespace Snake
{
    public class CreateTarget
    {
        public CreateTarget()
        {
            GameObject go = new GameObject();
            go.name = "target";
            go.tag = "target";
            go.AddComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Square");
            go.GetComponent<SpriteRenderer>().color = Color.yellow;
            Rigidbody2D pRigidbody = go.AddComponent<Rigidbody2D>();
            go.AddComponent<CircleCollider2D>();
            go.AddComponent<Target>();
            go.GetComponent<Transform>().localScale = new Vector2(0.4f,0.4f);
            pRigidbody.constraints = RigidbodyConstraints2D.FreezeAll;
            go.transform.position = new Vector2(Random.Range(-8,9), Random.Range(-4,5));
        }
    }    
}