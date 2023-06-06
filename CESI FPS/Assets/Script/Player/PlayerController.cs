using UnityEngine;

[RequireComponent(typeof(PlayerMotor))]
public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private float Speed = 5f;

    [SerializeField, Range(1,40)]
    private float verticalMouseSensitivity = 3f;

    [SerializeField, Range(1, 40)]
    private float horizontalMouseSensitivity = 3f;

    private PlayerMotor motor;

    private void Start()
    {
        //Récupération du script PlayerMotor de l'objet
        motor = GetComponent<PlayerMotor>();
    }

    private void Update()
    {
        CalculateVelocity();
        CalculatePlayerRotation();
    }

    private void CalculateVelocity()
    {
        //Calcul de la vitesse (vélocité) de déplacement du joueur
        float xMov = Input.GetAxisRaw("Horizontal");
        float zMov = Input.GetAxisRaw("Vertical");

        Vector3 moveHorizontal = transform.right * xMov;
        Vector3 moveVertical = transform.forward * zMov;

        Vector3 velocity = (moveHorizontal + moveVertical).normalized * Speed;

        motor.Move(velocity);
    }

    private void CalculatePlayerRotation()
    {
        //On calcul la rotation du joueur dans un Vector3
        float yRot = Input.GetAxisRaw("Mouse X");
        //On calcul la rotation de la caméra dans un Vector3
        float xRot = Input.GetAxisRaw("Mouse Y");

        Vector3 rotation = new Vector3(0, yRot, 0) * horizontalMouseSensitivity;
        Vector3 cameraRotation = new Vector3(xRot, 0, 0) * verticalMouseSensitivity;

        motor.Rotate(rotation);
        motor.RotateCamera(cameraRotation);
    }
}
