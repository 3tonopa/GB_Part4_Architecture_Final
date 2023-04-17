using UnityEngine;
namespace Snake
{
    public class CreateLevel
    {
        public CreateLevel()
        {
            GameObject left = new GameObject();
            left.name = "left wall";
            left.tag = "wall";
            left.transform.position = new Vector2(-8.89f,0f);
            left.GetComponent<Transform>().localScale = new Vector2(0.06f,10.0f);
            
            GameObject right = new GameObject();
            right.name = "right wall";
            right.tag = "wall";
            right.transform.position = new Vector2(8.89f,0f);
            right.GetComponent<Transform>().localScale = new Vector2(0.06f,10.0f);
            
            GameObject top = new GameObject();
            top.name = "top wall";
            top.tag = "wall";
            top.transform.position = new Vector2(0f,5f);
            top.GetComponent<Transform>().localScale = new Vector2(18f,0.06f);
            
            GameObject bottom = new GameObject();
            bottom.name = "bottom wall";
            bottom.tag = "wall";
            bottom.transform.position = new Vector2(0f,-5f);
            bottom.GetComponent<Transform>().localScale = new Vector2(18f,0.06f);


            GameObject[] walls = GameObject.FindGameObjectsWithTag("wall");
            for (int i = 0; i < walls.Length; i++)
            {
                walls[i].AddComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Square");

                walls[i].GetComponent<SpriteRenderer>().color = Color.grey;
                Rigidbody2D iRigidbody = walls[i].AddComponent<Rigidbody2D>();
                walls[i].AddComponent<BoxCollider2D>();
                iRigidbody.constraints = RigidbodyConstraints2D.FreezeAll;
            }
        }
    }    
}