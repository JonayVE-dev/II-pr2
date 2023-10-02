using UnityEngine;

public class Ejer1 : MonoBehaviour
{
    public int minNumber = 0;
    public int maxNumber = 25;
    int[] numbers = new int[8];
    // Start is called before the first frame update
    void Start()
    {
        ++maxNumber;
        for(int number = 0; number < numbers.Length; ++number) { 
            numbers[number] = Random.Range(minNumber, maxNumber);
        }
    }

    // Update is called once per frame
    void Update()
    {
        int randomPosition = Random.Range(0, numbers.Length);
        numbers[randomPosition] = Random.Range(minNumber, maxNumber);
        string numbersToPrint = "";
        for (int number = 0; number < numbers.Length; ++number) {
            if (numbers[number] > 15) {
                numbersToPrint += numbers[number];
                if (number < numbers.Length - 1) {
                    numbersToPrint += ", ";
                }
            }
        }
        Debug.Log(numbersToPrint);
    }
}
