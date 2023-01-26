using UnityEngine;

public enum PilihKarakter
{
    boy,
    girl,
}

public class SetKarakter: MonoBehaviour
{
    public PilihKarakter pilihKarakter;
   public void SetChar()
    {
        switch (pilihKarakter) 
        {
            case PilihKarakter.boy:
                PlayerPrefs.SetInt("Karakter", 1);
                break;
        }
    }
}
