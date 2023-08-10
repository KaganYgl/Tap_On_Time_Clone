using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject[] tapLocations;

    public void Spawn()
    {
        System.Random rnd = new();
        int i = rnd.Next(0,3);
        int degrees = rnd.Next(1,12) * 30;
        foreach (GameObject t in tapLocations)
        {
            t.SetActive(false);
        }
        tapLocations[i].transform.rotation = Quaternion.Euler(Vector3.forward * degrees);
        tapLocations[i].SetActive(true);
    }
}
