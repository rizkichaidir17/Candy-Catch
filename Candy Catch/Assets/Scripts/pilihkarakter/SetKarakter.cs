using UnityEngine;



public class SetKarakter: MonoBehaviour
{
    public EnumPilihKarakter pilihKarakter;
    private readonly string selectedCharacter = "SelectedCharacter";
    public void SetChar()
    {
        switch (pilihKarakter) 
        {
            case EnumPilihKarakter.boy:
                PlayerPrefs.SetInt(selectedCharacter, 1);
                break;
            case EnumPilihKarakter.girl:
                PlayerPrefs.SetInt(selectedCharacter, 2);
                break;
            default:
                PlayerPrefs.SetInt(selectedCharacter, 1);
                break;
        }
    }
}
