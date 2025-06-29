using UnityEngine;
using UnityEngine.UI;

public class CubeGameController : MonoBehaviour
{
    public GameObject[] cubes; // 0 - Cube1, 1 - Cube2, 2 - Cube3
    public Text resultText; // Для отображения "YOU WIN" / "YOU LOSE"
    
    private int correctCubeIndex;
    private bool gameOver = false;

    void Start()
    {
        // Выбираем случайный правильный куб
        correctCubeIndex = Random.Range(0, 3);
        
        // Отключаем все Rigidbody для старта (кубы "висят")
        foreach (var cube in cubes)
        {
            cube.GetComponent<Rigidbody>().isKinematic = true;
        }
    }

    public void OnButtonPressed(int playerChoiceIndex)
    {
        if (gameOver) return;

        // Активируем физику у всех кубов, кроме выбранного пользователем
        for (int i = 0; i < cubes.Length; i++)
        {
            Rigidbody rb = cubes[i].GetComponent<Rigidbody>();
            if (i != playerChoiceIndex)
            {
                rb.isKinematic = false;
            }
        }

        // Проверяем результат
        if (playerChoiceIndex == correctCubeIndex)
        {
            resultText.text = "YOU WIN";
        }
        else
        {
            resultText.text = "YOU LOSE";
        }

        gameOver = true;
    }
}