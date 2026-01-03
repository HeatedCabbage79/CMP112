using UnityEngine;


public class bananaspawner : MonoBehaviour
{
    public GameObject banana;

    void Start()
    {
        InvokeRepeating(nameof(spawn), 0.2f, 6.0f);
    }
   
    public void spawn()
    {
        //randomly assigns coordinates 
        int spawnPointX = Random.Range(-5, 5);
        int spawnPointY = 1;
        int spawnPointZ = Random.Range(10, 20);

        Vector3 spawnPos=new Vector3(spawnPointX, spawnPointY, spawnPointZ);
        Instantiate(banana, spawnPos, Quaternion.identity); 
    }

   



}
