using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spin : MonoBehaviour
{
    public Transform Pannel;

    private bool IsSpinning = false; // ȸ�� ������ üũ�ϴ� ����

    public void Click_To_Spin0()
    {
        if (!IsSpinning)
        {
            StartCoroutine(SpinCoroutine0());
        }
    }

    IEnumerator SpinCoroutine0()
    {
        IsSpinning = true;

        //���� ����
        float StartAngle = Pannel.localRotation.eulerAngles.z;
        float CurrentAngle = StartAngle;
        float TargetAngle = StartAngle + 335f;

        //ȸ�� �ӵ�
        float SpinSpeed = 500f;

        //ȸ�� ����
        while (CurrentAngle < TargetAngle)
        {
            CurrentAngle += SpinSpeed * Time.deltaTime;
            Pannel.localRotation = Quaternion.Euler(0, 0, CurrentAngle);
            yield return null;
        }

        // ȸ�� �� ���
        yield return new WaitForSeconds(0.2f);

        //ȸ�� �� ����
        while (CurrentAngle > StartAngle)
        {
            CurrentAngle -= SpinSpeed * Time.deltaTime;

            if (CurrentAngle <= StartAngle)
            {
                CurrentAngle = StartAngle;
            }


            Pannel.localRotation = Quaternion.Euler(0, 0, CurrentAngle);
            yield return null;
        }

        IsSpinning = false;
    }

    public void Click_To_Spin1()
    {
        if (!IsSpinning)
        {
            StartCoroutine(SpinCoroutine1());
        }
    }

    IEnumerator SpinCoroutine1()
    {
        IsSpinning = true;

        //���� ����
        float StartAngle = Pannel.localRotation.eulerAngles.z;
        float CurrentAngle = StartAngle;
        float TargetAngle = StartAngle + 68f;

        //ȸ�� �ӵ�
        float SpinSpeed = 500f;

        //ȸ�� ����
        while (CurrentAngle < TargetAngle)
        {
            CurrentAngle += SpinSpeed * Time.deltaTime;
            Pannel.localRotation = Quaternion.Euler(0, 0, CurrentAngle);
            yield return null;
        }

        // ȸ�� �� ���
        yield return new WaitForSeconds(0.2f);

        //ȸ�� �� ����
        while (CurrentAngle > StartAngle)
        {
            CurrentAngle -= SpinSpeed * Time.deltaTime;

            if (CurrentAngle <= StartAngle)
            {
                CurrentAngle = StartAngle;
            }


            Pannel.localRotation = Quaternion.Euler(0, 0, CurrentAngle);
            yield return null;
        }

        IsSpinning = false;
    }

    public void Click_To_Spin2()
    {
        if (!IsSpinning)
        {
            StartCoroutine(SpinCoroutine2());
        }
    }

    IEnumerator SpinCoroutine2()
    {
        IsSpinning = true;

        //���� ����
        float StartAngle = Pannel.localRotation.eulerAngles.z;
        float CurrentAngle = StartAngle;
        float TargetAngle = StartAngle + 98f;

        //ȸ�� �ӵ�
        float SpinSpeed = 500f;

        //ȸ�� ����
        while (CurrentAngle < TargetAngle)
        {
            CurrentAngle += SpinSpeed * Time.deltaTime;
            Pannel.localRotation = Quaternion.Euler(0, 0, CurrentAngle);
            yield return null;
        }

        // ȸ�� �� ���
        yield return new WaitForSeconds(0.2f);

        //ȸ�� �� ����
        while (CurrentAngle > StartAngle)
        {
            CurrentAngle -= SpinSpeed * Time.deltaTime;

            if (CurrentAngle <= StartAngle)
            {
                CurrentAngle = StartAngle;
            }


            Pannel.localRotation = Quaternion.Euler(0, 0, CurrentAngle);
            yield return null;
        }

        IsSpinning = false;
    }

    public void Click_To_Spin3()
    {
        if (!IsSpinning)
        {
            StartCoroutine(SpinCoroutine3());
        }
    }

    IEnumerator SpinCoroutine3()
    {
        IsSpinning = true;

        //���� ����
        float StartAngle = Pannel.localRotation.eulerAngles.z;
        float CurrentAngle = StartAngle;
        float TargetAngle = StartAngle + 128f;

        //ȸ�� �ӵ�
        float SpinSpeed = 500f;

        //ȸ�� ����
        while (CurrentAngle < TargetAngle)
        {
            CurrentAngle += SpinSpeed * Time.deltaTime;
            Pannel.localRotation = Quaternion.Euler(0, 0, CurrentAngle);
            yield return null;
        }

        // ȸ�� �� ���
        yield return new WaitForSeconds(0.2f);

        //ȸ�� �� ����
        while (CurrentAngle > StartAngle)
        {
            CurrentAngle -= SpinSpeed * Time.deltaTime;

            if (CurrentAngle <= StartAngle)
            {
                CurrentAngle = StartAngle;
            }


            Pannel.localRotation = Quaternion.Euler(0, 0, CurrentAngle);
            yield return null;
        }

        IsSpinning = false;
    }

    public void Click_To_Spin4()
    {
        if (!IsSpinning)
        {
            StartCoroutine(SpinCoroutine4());
        }
    }

    IEnumerator SpinCoroutine4()
    {
        IsSpinning = true;

        //���� ����
        float StartAngle = Pannel.localRotation.eulerAngles.z;
        float CurrentAngle = StartAngle;
        float TargetAngle = StartAngle + 158f;

        //ȸ�� �ӵ�
        float SpinSpeed = 500f;

        //ȸ�� ����
        while (CurrentAngle < TargetAngle)
        {
            CurrentAngle += SpinSpeed * Time.deltaTime;
            Pannel.localRotation = Quaternion.Euler(0, 0, CurrentAngle);
            yield return null;
        }

        // ȸ�� �� ���
        yield return new WaitForSeconds(0.2f);

        //ȸ�� �� ����
        while (CurrentAngle > StartAngle)
        {
            CurrentAngle -= SpinSpeed * Time.deltaTime;

            if (CurrentAngle <= StartAngle)
            {
                CurrentAngle = StartAngle;
            }


            Pannel.localRotation = Quaternion.Euler(0, 0, CurrentAngle);
            yield return null;
        }

        IsSpinning = false;
    }

    public void Click_To_Spin5()
    {
        if (!IsSpinning)
        {
            StartCoroutine(SpinCoroutine5());
        }
    }

    IEnumerator SpinCoroutine5()
    {
        IsSpinning = true;

        //���� ����
        float StartAngle = Pannel.localRotation.eulerAngles.z;
        float CurrentAngle = StartAngle;
        float TargetAngle = StartAngle + 188f;

        //ȸ�� �ӵ�
        float SpinSpeed = 500f;

        //ȸ�� ����
        while (CurrentAngle < TargetAngle)
        {
            CurrentAngle += SpinSpeed * Time.deltaTime;
            Pannel.localRotation = Quaternion.Euler(0, 0, CurrentAngle);
            yield return null;
        }

        // ȸ�� �� ���
        yield return new WaitForSeconds(0.2f);

        //ȸ�� �� ����
        while (CurrentAngle > StartAngle)
        {
            CurrentAngle -= SpinSpeed * Time.deltaTime;

            if (CurrentAngle <= StartAngle)
            {
                CurrentAngle = StartAngle;
            }

            Pannel.localRotation = Quaternion.Euler(0, 0, CurrentAngle);
            yield return null;
        }

        IsSpinning = false;
    }

    public void Click_To_Spin6()
    {
        if (!IsSpinning)
        {
            StartCoroutine(SpinCoroutine6());
        }
    }

    IEnumerator SpinCoroutine6()
    {
        IsSpinning = true;

        //���� ����
        float StartAngle = Pannel.localRotation.eulerAngles.z;
        float CurrentAngle = StartAngle;
        float TargetAngle = StartAngle + 218f;

        //ȸ�� �ӵ�
        float SpinSpeed = 500f;

        //ȸ�� ����
        while (CurrentAngle < TargetAngle)
        {
            CurrentAngle += SpinSpeed * Time.deltaTime;
            Pannel.localRotation = Quaternion.Euler(0, 0, CurrentAngle);
            yield return null;
        }

        // ȸ�� �� ���
        yield return new WaitForSeconds(0.2f);

        //ȸ�� �� ����
        while (CurrentAngle > StartAngle)
        {
            CurrentAngle -= SpinSpeed * Time.deltaTime;

            if (CurrentAngle <= StartAngle)
            {
                CurrentAngle = StartAngle;
            }

            Pannel.localRotation = Quaternion.Euler(0, 0, CurrentAngle);
            yield return null;
        }

        IsSpinning = false;
    }

    public void Click_To_Spin7()
    {
        if (!IsSpinning)
        {
            StartCoroutine(SpinCoroutine7());
        }
    }

    IEnumerator SpinCoroutine7()
    {
        IsSpinning = true;

        //���� ����
        float StartAngle = Pannel.localRotation.eulerAngles.z;
        float CurrentAngle = StartAngle;
        float TargetAngle = StartAngle + 245f;

        //ȸ�� �ӵ�
        float SpinSpeed = 500f;

        //ȸ�� ����
        while (CurrentAngle < TargetAngle)
        {
            CurrentAngle += SpinSpeed * Time.deltaTime;
            Pannel.localRotation = Quaternion.Euler(0, 0, CurrentAngle);
            yield return null;
        }

        // ȸ�� �� ���
        yield return new WaitForSeconds(0.2f);

        //ȸ�� �� ����
        while (CurrentAngle > StartAngle)
        {
            CurrentAngle -= SpinSpeed * Time.deltaTime;

            if (CurrentAngle <= StartAngle)
            {
                CurrentAngle = StartAngle;
            }

            Pannel.localRotation = Quaternion.Euler(0, 0, CurrentAngle);
            yield return null;
        }

        IsSpinning = false;
    }

    public void Click_To_Spin8()
    {
        if (!IsSpinning)
        {
            StartCoroutine(SpinCoroutine8());
        }
    }

    IEnumerator SpinCoroutine8()
    {
        IsSpinning = true;

        //���� ����
        float StartAngle = Pannel.localRotation.eulerAngles.z;
        float CurrentAngle = StartAngle;
        float TargetAngle = StartAngle + 275f;

        //ȸ�� �ӵ�
        float SpinSpeed = 500f;

        //ȸ�� ����
        while (CurrentAngle < TargetAngle)
        {
            CurrentAngle += SpinSpeed * Time.deltaTime;
            Pannel.localRotation = Quaternion.Euler(0, 0, CurrentAngle);
            yield return null;
        }

        // ȸ�� �� ���
        yield return new WaitForSeconds(0.2f);

        //ȸ�� �� ����
        while (CurrentAngle > StartAngle)
        {
            CurrentAngle -= SpinSpeed * Time.deltaTime;

            if (CurrentAngle <= StartAngle)
            {
                CurrentAngle = StartAngle;
            }

            Pannel.localRotation = Quaternion.Euler(0, 0, CurrentAngle);
            yield return null;
        }

        IsSpinning = false;
    }

    public void Click_To_Spin9()
    {
        if (!IsSpinning)
        {
            StartCoroutine(SpinCoroutine9());
        }
    }

    IEnumerator SpinCoroutine9()
    {
        IsSpinning = true;

        //���� ����
        float StartAngle = Pannel.localRotation.eulerAngles.z;
        float CurrentAngle = StartAngle;
        float TargetAngle = StartAngle + 305f;

        //ȸ�� �ӵ�
        float SpinSpeed = 500f;

        //ȸ�� ����
        while (CurrentAngle < TargetAngle)
        {
            CurrentAngle += SpinSpeed * Time.deltaTime;
            Pannel.localRotation = Quaternion.Euler(0, 0, CurrentAngle);
            yield return null;
        }

        // ȸ�� �� ���
        yield return new WaitForSeconds(0.2f);

        //ȸ�� �� ����
        while (CurrentAngle > StartAngle)
        {
            CurrentAngle -= SpinSpeed * Time.deltaTime;

            if (CurrentAngle <= StartAngle)
            {
                CurrentAngle = StartAngle;
            }

            Pannel.localRotation = Quaternion.Euler(0, 0, CurrentAngle);
            yield return null;
        }

        IsSpinning = false;
    }
}
