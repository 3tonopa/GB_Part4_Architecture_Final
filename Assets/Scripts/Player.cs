using UnityEngine;
namespace Snake
{
    public class Player : MonoBehaviour
    {
        public GameObject slave;
        public Vector3 mDirection;
        public bool step = true;
        public float timestamp;
        private void Awake()
        {
            mDirection = Vector3.right;
            timestamp = Time.time;
            slave = this.gameObject;
        }
        
        private void Update()
        {
            Direction();
            Movement();
            StepCounter();
        }
        private void Direction()
        {
            if (Input.GetKeyDown(KeyCode.A))
                mDirection = Vector3.left;
            if (Input.GetKeyDown(KeyCode.W))
                mDirection = Vector3.up;
            if (Input.GetKeyDown(KeyCode.S))
                mDirection = Vector3.down;
            if (Input.GetKeyDown(KeyCode.D))
                mDirection = Vector3.right;
        }
        private void Movement()
        {
            if (step)
            {
                transform.position = transform.position + mDirection/2;
                step = false;
                timestamp = Time.time;
            }
        }
        private void StepCounter()
        {
            if (Time.time > timestamp + 0.5f )
                step = true;
        }
        private void OnCollisionEnter2D(Collision2D other)
        {
            if(other.gameObject.tag == "wall")
            {
                Time.timeScale = 0;
                new GameOver();
            }
            if(other.gameObject.tag == "target")
            {
                slave = other.gameObject;
            }
                
        }
    }
}