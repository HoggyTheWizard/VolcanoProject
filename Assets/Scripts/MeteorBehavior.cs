using UnityEngine;
public class MeteorBehavior : MonoBehaviour
{
    [SerializeField] float speed;
    void Update()
    {
        transform.Translate(speed * Time.deltaTime * Vector3.down);
        
        if (transform.position.y < -5)
        {
            transform.position = new Vector3(Random.Range(-5, 5), 5, 0);
        }
    }
        
}

