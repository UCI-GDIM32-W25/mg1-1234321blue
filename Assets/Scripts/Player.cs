using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float _speed = 1.0f;
    [SerializeField] private Transform _playerTransform;
    [SerializeField] private GameObject _plantPrefab;
    [SerializeField] private int _numSeeds = 5; 
    [SerializeField] private PlantCountUI _plantCountUI;

    private int _numSeedsLeft;
    private int _numSeedsPlanted;

    private void Start ()
    {
        
    }

    private void Update()
    {
        if(Input.GetKey(KeyCode.W)||Input.GetKey(KeyCode.UpArrow))
        {
            _playerTransform.Translate(Vector2.up*_speed*Time.deltaTime);
        }
         if(Input.GetKey(KeyCode.S)||Input.GetKey(KeyCode.DownArrow))
        {
            _playerTransform.Translate(Vector2.down*_speed*Time.deltaTime);
        }
         if(Input.GetKey(KeyCode.A)||Input.GetKey(KeyCode.LeftArrow))
        {
            _playerTransform.Translate(Vector2.left*_speed*Time.deltaTime);
        }
         if(Input.GetKey(KeyCode.D)||Input.GetKey(KeyCode.RightArrow))
        {
            _playerTransform.Translate(Vector2.right*_speed*Time.deltaTime);
        }
    }

    public void PlantSeed ()
    {
        
    }
}
