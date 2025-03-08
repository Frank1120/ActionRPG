using UnityEngine;
using CreatorKitCode;

public class WeaponSpawn : MonoBehaviour
{
    public GameObject ObjectToSpawn;

    void Start()
    {
        LootAngle1 myLootAngle1 = new LootAngle1(45);
        weaponSpawn(myLootAngle1.nextAngle1());

    }

    void weaponSpawn(int angle){
        int radius = 5;
        Vector3 direction = Quaternion.Euler(0, angle, 0) * Vector3.right;
        Vector3 spawnPosition = transform.position + direction * radius;
        Instantiate(ObjectToSpawn, spawnPosition, Quaternion.identity);
    }
}

public class LootAngle1{
    int angle;
    int step;

    public LootAngle1(int increment){
        step = increment;
        angle = 0;
    }

    public int nextAngle1(){
        int currentAngle = angle;
        angle = Helpers.WrapAngle(angle + step);

        return currentAngle;
    }
}

