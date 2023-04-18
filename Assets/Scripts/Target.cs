using UnityEngine;
namespace Snake
{
    public class Target : MonoBehaviour
    {
        public GameObject master;
        public Vector3 mDirection;
        public Vector3 lastPosition;
       
        private void Start()
        {
            this.gameObject.tag = "slave";
            lastPosition = master.transform.position;
            Debug.Log(master.name);
        }

        public void Move()
        {
            if (master != null)
            {
                Vector3 destination;
                if (master.GetComponent<Player>() != null)
                    destination = master.GetComponent<Player>().lastPosition;
                else
                    destination = master.GetComponent<Target>().lastPosition;

                transform.position = destination;
                lastPosition = transform.position;
            }
        }
    }
}