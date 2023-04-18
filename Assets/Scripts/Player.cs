using UnityEngine;
namespace Snake
{
    public class Player : MonoBehaviour
    {
        public GameObject lastSlave;
        public Vector3 mDirection;
        public Vector3 lastPosition;
        public GameObject target;
        public bool step = true;
        public bool imprit = false;
        public float timestamp;
        private void Awake()
        {
            lastPosition = transform.position;
            lastSlave = this.gameObject;
            mDirection = Vector3.right;
            timestamp = Time.time;
        }

        private void Update()
        {
            Direction();
            Movement();
            Imprit();
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
                lastPosition = transform.position;
                transform.position = transform.position + mDirection / 2;
                step = false;
                Target[] slaves = FindObjectsOfType<Target>();
                for (int i = 0; i < slaves.Length; i++)
                {
                    slaves[i].Move();
                }
                timestamp = Time.time;
            }
        }
        private void StepCounter()
        {
            if (Time.time > timestamp + FindObjectOfType<Launcher>().nextTime)
                step = true;
        }
        private void Imprit()
        {
            if (imprit)
            {
                target.AddComponent<Target>().master = lastSlave;
                lastSlave = target;
                FindObjectOfType<Launcher>().deploy = true;
                FindObjectOfType<Launcher>().score += 1;
                imprit = false;
            }
        }
        private void OnCollisionEnter2D(Collision2D other)
        {
            if (other.gameObject.tag == "wall" || other.gameObject.tag == "slave")
            {

                FindObjectOfType<Launcher>().GameOver();
            }
            if (other.gameObject.tag == "target")
            {
                target = other.gameObject;
                Debug.Log(target.name);
                imprit = true;
            }

        }
    }
}