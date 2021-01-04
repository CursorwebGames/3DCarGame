using UnityEngine;

public class PlayerCam : MonoBehaviour
{
    public GameObject thirdPerson;
    public GameObject firstPerson;
    public bool isFirstPerson = true;

    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.C))
        {
            isFirstPerson = !isFirstPerson;
            UpdateCam();
        }
    }

    private void UpdateCam()
    {
        if (isFirstPerson)
        {
            thirdPerson.SetActive(false);
            firstPerson.SetActive(true);
        }
        else
        {
            thirdPerson.SetActive(true);
            firstPerson.SetActive(false);
        }
    }
}
