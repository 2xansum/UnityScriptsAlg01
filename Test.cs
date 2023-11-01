using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    //Здоровье NPC
    public int health = 1;
    //Уровень NPC
    public int level = 2;
    //Скорость NPC
    public int speed = 2;

    // Start is called before the first frame update
    void Start()
    {
        // команда прибавления к здоровью уровня
        health += level;
        // Команда вывода в консоль
        print(health);
    }

    // Update is called once per frame
    void Update()
    {

        Vector3 newPosition = transform.position;
        newPosition.z += speed * Time.deltaTime;
        transform.position = newPosition;
        print(Time.fixedTime);
    }

}
