using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject[] TapLocations;

    public void Spawn()
    {
        System.Random rnd = new();
        int i = rnd.Next(0,3);
        int degrees = rnd.Next(3,34);
        foreach (GameObject t in TapLocations)
        {
            t.SetActive(false);
        }
        TapLocations[i].transform.rotation = Quaternion.Euler(Vector3.forward * degrees*10);
        TapLocations[i].SetActive(true);
    }
}
