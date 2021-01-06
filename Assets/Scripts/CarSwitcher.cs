using UnityEngine;

public class CarSwitcher : MonoBehaviour
{
    public GameObject[] cars;
    public int carIndex = 1;
    public GameObject currCar;


    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.H))
        {
            carIndex++;
            carIndex %= cars.Length;
            UpdateCar();
        }
    }


    private void UpdateCar()
    {
        GameObject car = cars[carIndex];
        Vector3 position = currCar.transform.position;

        Destroy(currCar);

        currCar = Instantiate(car, position, Quaternion.identity * Quaternion.AngleAxis(90, Vector3.up));
    }
}
