using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class busMovement : MonoBehaviour
{
    private string constant;
    public Text busHealth;
    public int health = 100;
    // Start is called before the first frame update
    public AudioSource horn;
    public AudioSource carEngine;
    public Text childrenScore;
    public int childrenCount =0;
    public Text dropped;
    public int droppedCount = 0;
    public bool collisionOccured = false;
    public bool droppedOccured = false;
    void Start()
    {
        busHealth.text = "Bus Health :" +health.ToString();
        childrenScore.text = "picked up childs:" + childrenCount.ToString();
        carEngine.Play();
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.H))
        {
            horn.Play();
        }
        //else {
        //  horn.Pause();
        //}
        
        if (constant == "yes") {
            transform.Translate(0, 0, 0.2f);

        }
        if (Input.GetKey(KeyCode.UpArrow)) {
            
            constant = "yes";
            transform.Translate(0, 0, 0.5f);
        }
       if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(0, 0.5f,0);
        }
       if (Input.GetKey(KeyCode.LeftArrow))
           {
               transform.Rotate(0, -0.5f,0);
           }
       if (Input.GetKey(KeyCode.DownArrow))
           {
            constant = "no";
               transform.Translate(0, 0, -0.5f);
            }
        if (health <= 0) {
            SceneManager.LoadScene("reloadScene");
        }
        if ((collisionOccured == true) && (Input.GetKey(KeyCode.P))) {
            childrenCount += 10;
            childrenScore.text = "picked up childs: " + childrenCount.ToString();
            collisionOccured = false;
        }
        if ((droppedOccured == true) && Input.GetKey(KeyCode.D)) {
            droppedCount = childrenCount + droppedCount;
            dropped.text = "dropped childs: " + droppedCount.ToString();

            childrenCount = 0;
            childrenScore.text = "picked up childs: " + childrenCount.ToString();
            droppedOccured = false;

        }
        if (droppedCount == 50) {
            SceneManager.LoadScene("gameWon");
        }
    }
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name.StartsWith("traffic") || collision.gameObject.name.StartsWith("Cube")) {
            health -= 1;
            busHealth.text = "Bus Health:" + health.ToString();
        }
        if (collision.gameObject.name.StartsWith("parking") || collision.gameObject.name.StartsWith("rod"))
        {
            collisionOccured = true;
        }
        if (collision.gameObject.name.StartsWith("drop"))
        {
            droppedOccured = true;
        }
    }
}
