using UnityEngine;
using System.Collections.Generic;
// using Unity.visualScripting; // Dòng này thường không cần thiết trừ khi bạn dùng Visual Scripting

public class LookGap : MonoBehaviour
{
    public GameObject obstacleObject; 
    private void OnTriggerExit2D(Collider2D collision)
    {
        // Điều kiện 'if' và nội dung của nó phải nằm bên trong khối {} của hàm.
        if (collision.gameObject.tag == "Ground")
        {
            obstacleObject.transform.position = new Vector3(-obstacleObject.transform.position.x, obstacleObject.transform.position.y, obstacleObject.transform.position.z);
        }
    }

    void Start()
    {
        // Logic khởi tạo của bạn ở đây (nếu có)
    }

    void Update()
    {
        // Logic cập nhật của bạn ở đây (nếu có)
    }
}