using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Flag : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // �÷��̾ ��߿� �������� ���� ó��
            GameOver();
        }
    }

    void GameOver()
    {
        // ���� ���� �Ǵ� �¸� ȭ�� ǥ��
        // ��: SceneManager.LoadScene("WinScene");
        UnityEngine.Debug.Log("Game Over");
    }
}
