using UnityEngine;

public class NPC : MonoBehaviour
{
   public  int health = 5;

 public   int level = 1;

  public  float speed = 1.2f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Изменение количества здоровья
        health += level;
        print("Здровье игрока" + health);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPosition = transform.position;
        newPosition.z += speed * Time.deltaTime;
        transform.position = newPosition;
    }
}
