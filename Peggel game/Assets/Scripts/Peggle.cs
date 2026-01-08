using System.Xml.Schema;
using Unity.VisualScripting;
using UnityEngine;

public class Peggle : MonoBehaviour
{
    int totalePeggles = 10;
    int peggleHits = 1;
    int waardeHit = 100;
    bool geraakt = true;
    void OnCollisionEnter2D(Collision2D collision)
{
    if (geraakt == true)
        {
            peggleHits= 0;
            ScoreManager.Instance.AddScore(waardeHit);
            Destroy(gameObject);
            totalePeggles -=1;
    
        }

         if (geraakt == false)
        {
            peggleHits = 1;
        }


    void Start()
    {
            
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

}
