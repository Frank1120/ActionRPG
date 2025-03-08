using UnityEngine;
using CreatorKitCode;

public class EquipmentSpawn : MonoBehaviour
{
    public GameObject ObjectToSpawn;

    void Start()
    {
        LootAngleLocation myLootAngleLocation = new LootAngleLocation(45);
        equipmentSpawn(myLootAngleLocation.nextAngleLocation());

    }

    void equipmentSpawn(int angle){
        int radius = 5;
        Vector3 direction = Quaternion.Euler(0, angle, 0) * Vector3.right;
        Vector3 spawnPosition = transform.position + direction * radius;
        Instantiate(ObjectToSpawn, spawnPosition, Quaternion.identity);
    }
}

public class LootAngleLocation{
    int angle;
    int step;

    public LootAngleLocation(int increment){
        step = increment;
        angle = 0;
    }

    public int nextAngleLocation(){
        int currentAngle = angle;
        angle = Helpers.WrapAngle(angle + step);

        return currentAngle;
    }
}

