using UnityEngine;
namespace Snake
{
    public class Target : MonoBehaviour
    {
        public GameObject master;
        public Vector3 mDirection;
        public bool active = false;
        public float timestamp;
        private void Awake()
        {

        }

        private void Update()
        {
            if (master != null)
            {
                transform.position = master.transform.position - FindObjectOfType<Player>().mDirection/2;
            }
        }
            

        private void OnCollisionEnter2D(Collision2D other)
        {
            if (other.gameObject.tag == "Player" && !active)
            {
                master = other.gameObject.GetComponent<Player>().slave;
                FindObjectOfType<Launcher>().deploy = true;
                active = true;
            }
        }
    }
}