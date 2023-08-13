using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject[] tapLocations;

    public void Spawn()
    {
        int i = UnityEngine.Random.Range(0, 4);
        int degrees = UnityEngine.Random.Range(1, 12) * 30;

        foreach (GameObject t in tapLocations)
        {
            t.SetActive(false);
        }

        tapLocations[i].transform.rotation = Quaternion.Euler((Vector3.forward * degrees) + tapLocations[i].transform.rotation.eulerAngles);
        tapLocations[i].SetActive(true);
    }
}
