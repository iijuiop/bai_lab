using UnityEngine;
using System.Collections; 
using System.Collections.Generic;

public class LookWall : MonoBehaviour
{
    public GameObject obstacleObject; 

    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Sử dụng CompareTag để so sánh tag an toàn và hiệu quả hơn
        if (collision.gameObject.CompareTag("Ground"))
        {
            // Lật hướng di chuyển của obstacleObject bằng cách nhân tọa độ X với -1
            obstacleObject.transform.localScale = new Vector3(
                -obstacleObject.transform.localScale.x, 
                obstacleObject.transform.localScale.y,
                obstacleObject.transform.localScale.z
            );
        }
    }

    // Hàm Start và Update để trống nếu không có logic cụ thể trong script này
    void Start()
    {
        
    }

    void Update()
    {
        
    }
}