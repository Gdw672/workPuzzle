using UnityEngine;

public class powerEnemyConrollerScript : MonoBehaviour
{
    public powerEnemy[] powerEnemyMass;
    System.Random random = new System.Random();
    int power;
    bool isWasVoid = false;

    private void Start()
    {

        
    }

   

    private void Update()
    {
       
       
    }

    private void LateUpdate()
    {
        if (isWasVoid == false)
        {
            powerEnemyMass = GameObject.FindObjectsOfType<powerEnemy>();
            randomArray(powerEnemyMass);
            givePowerEnemy();
            isWasVoid = true;
        }
    }
    void givePowerEnemy()
    {
        power = random.Next(5, powerPlayer.powerOfPlayer);
        for (int i = 0; i < powerEnemyMass.Length; i++)
        {
            if (i == 0)
            {
                powerEnemyMass[i].powerEnemyInt = power;
            }
            if (i > 0)
            {
                int predlast = lastsEnemy(i - 1, powerEnemyMass);
                int lastEnemy = lastsEnemy(i, powerEnemyMass);
                powerEnemyMass[i].powerEnemyInt = random.Next(predlast + 1, lastEnemy);

            }
        }

    }

    int lastsEnemy(int numOfEnemy, powerEnemy[] array)
    {
        int sum = power;
        for (int i = 0; i < numOfEnemy; i++)
        {
            sum += array[i].powerEnemyInt;
        }
        return sum;
    }

    void randomArray(powerEnemy[] array)
    {
        if (array.Length < 1) return;
        for (var i = 0; i < array.Length; i++)
        {
            var key = array[i];
            var rnd = random.Next(i, array.Length);
            array[i] = array[rnd];
            array[rnd] = key;
        }
    }
}
