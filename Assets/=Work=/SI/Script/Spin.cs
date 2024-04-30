using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spin : MonoBehaviour
{
    public Transform Pannel;
    public float rotationDuration = 1f; // ȸ�� �ҿ� �ð� (��)
    public float returnDuration = 1f; // ȸ�� �� �ǵ��ƿ��� �ҿ� �ð� (��)

    private bool isSpinning = false; // ȸ�� ������ ���θ� ��Ÿ���� ����

    public void Click_To_Spin0()
    {
        if (!isSpinning)
        {
            StartCoroutine(SpinCoroutine0());
        }
    }

    IEnumerator SpinCoroutine0()
    {
        isSpinning = true;

        // ���� ������ ��ǥ ���� ����
        float startAngle = Pannel.localRotation.eulerAngles.z;
        float targetAngle = startAngle - 305f;

        // ȸ�� ������ ���� ��� ����
        float t = 0f;
        while (t < 1f)
        {
            t += Time.deltaTime / rotationDuration;
            float currentAngle = Mathf.Lerp(startAngle, targetAngle, t);
            Pannel.localRotation = Quaternion.Euler(0, 0, currentAngle);
            yield return null;
        }

        // ȸ�� �� ���
        yield return new WaitForSeconds(returnDuration);

        // �ǵ��ƿ��� ȸ�� ������ ���� ��� ����
        t = 0f;
        while (t < 1f)
        {
            t += Time.deltaTime / returnDuration;
            float currentAngle = Mathf.Lerp(targetAngle, startAngle, t);
            Pannel.localRotation = Quaternion.Euler(0, 0, currentAngle);
            yield return null;
        }

        isSpinning = false;
    }

    public void Click_To_Spin1()
    {
        if (!isSpinning)
        {
            StartCoroutine(SpinCoroutine1());
        }
    }

    IEnumerator SpinCoroutine1()
    {
        isSpinning = true;

        // ���� ������ ��ǥ ���� ����
        float startAngle = Pannel.localRotation.eulerAngles.z;
        float targetAngle = startAngle - 45f;

        // ȸ�� ������ ���� ��� ����
        float t = 0f;
        while (t < 1f)
        {
            t += Time.deltaTime / rotationDuration;
            float currentAngle = Mathf.Lerp(startAngle, targetAngle, t);
            Pannel.localRotation = Quaternion.Euler(0, 0, currentAngle);
            yield return null;
        }

        // ȸ�� �� ���
        yield return new WaitForSeconds(returnDuration);

        // �ǵ��ƿ��� ȸ�� ������ ���� ��� ����
        t = 0f;
        while (t < 1f)
        {
            t += Time.deltaTime / returnDuration;
            float currentAngle = Mathf.Lerp(targetAngle, startAngle, t);
            Pannel.localRotation = Quaternion.Euler(0, 0, currentAngle);
            yield return null;
        }

        isSpinning = false;
    }

    public void Click_To_Spin2()
    {
        if (!isSpinning)
        {
            StartCoroutine(SpinCoroutine2());
        }
    }

    IEnumerator SpinCoroutine2()
    {
        isSpinning = true;

        // ���� ������ ��ǥ ���� ����
        float startAngle = Pannel.localRotation.eulerAngles.z;
        float targetAngle = startAngle - 80f;

        // ȸ�� ������ ���� ��� ����
        float t = 0f;
        while (t < 1f)
        {
            t += Time.deltaTime / rotationDuration;
            float currentAngle = Mathf.Lerp(startAngle, targetAngle, t);
            Pannel.localRotation = Quaternion.Euler(0, 0, currentAngle);
            yield return null;
        }

        // ȸ�� �� ���
        yield return new WaitForSeconds(returnDuration);

        // �ǵ��ƿ��� ȸ�� ������ ���� ��� ����
        t = 0f;
        while (t < 1f)
        {
            t += Time.deltaTime / returnDuration;
            float currentAngle = Mathf.Lerp(targetAngle, startAngle, t);
            Pannel.localRotation = Quaternion.Euler(0, 0, currentAngle);
            yield return null;
        }

        isSpinning = false;
    }

    public void Click_To_Spin3()
    {
        if (!isSpinning)
        {
            StartCoroutine(SpinCoroutine3());
        }
    }

    IEnumerator SpinCoroutine3()
    {
        isSpinning = true;

        // ���� ������ ��ǥ ���� ����
        float startAngle = Pannel.localRotation.eulerAngles.z;
        float targetAngle = startAngle - 105f;

        // ȸ�� ������ ���� ��� ����
        float t = 0f;
        while (t < 1f)
        {
            t += Time.deltaTime / rotationDuration;
            float currentAngle = Mathf.Lerp(startAngle, targetAngle, t);
            Pannel.localRotation = Quaternion.Euler(0, 0, currentAngle);
            yield return null;
        }

        // ȸ�� �� ���
        yield return new WaitForSeconds(returnDuration);

        // �ǵ��ƿ��� ȸ�� ������ ���� ��� ����
        t = 0f;
        while (t < 1f)
        {
            t += Time.deltaTime / returnDuration;
            float currentAngle = Mathf.Lerp(targetAngle, startAngle, t);
            Pannel.localRotation = Quaternion.Euler(0, 0, currentAngle);
            yield return null;
        }

        isSpinning = false;
    }

    public void Click_To_Spin4()
    {
        if (!isSpinning)
        {
            StartCoroutine(SpinCoroutine4());
        }
    }

    IEnumerator SpinCoroutine4()
    {
        isSpinning = true;

        // ���� ������ ��ǥ ���� ����
        float startAngle = Pannel.localRotation.eulerAngles.z;
        float targetAngle = startAngle - 135f;

        // ȸ�� ������ ���� ��� ����
        float t = 0f;
        while (t < 1f)
        {
            t += Time.deltaTime / rotationDuration;
            float currentAngle = Mathf.Lerp(startAngle, targetAngle, t);
            Pannel.localRotation = Quaternion.Euler(0, 0, currentAngle);
            yield return null;
        }

        // ȸ�� �� ���
        yield return new WaitForSeconds(returnDuration);

        // �ǵ��ƿ��� ȸ�� ������ ���� ��� ����
        t = 0f;
        while (t < 1f)
        {
            t += Time.deltaTime / returnDuration;
            float currentAngle = Mathf.Lerp(targetAngle, startAngle, t);
            Pannel.localRotation = Quaternion.Euler(0, 0, currentAngle);
            yield return null;
        }

        isSpinning = false;
    }

    public void Click_To_Spin5()
    {
        if (!isSpinning)
        {
            StartCoroutine(SpinCoroutine5());
        }
    }

    IEnumerator SpinCoroutine5()
    {
        isSpinning = true;

        // ���� ������ ��ǥ ���� ����
        float startAngle = Pannel.localRotation.eulerAngles.z;
        float targetAngle = startAngle - 165f;

        // ȸ�� ������ ���� ��� ����
        float t = 0f;
        while (t < 1f)
        {
            t += Time.deltaTime / rotationDuration;
            float currentAngle = Mathf.Lerp(startAngle, targetAngle, t);
            Pannel.localRotation = Quaternion.Euler(0, 0, currentAngle);
            yield return null;
        }

        // ȸ�� �� ���
        yield return new WaitForSeconds(returnDuration);

        // �ǵ��ƿ��� ȸ�� ������ ���� ��� ����
        t = 0f;
        while (t < 1f)
        {
            t += Time.deltaTime / returnDuration;
            float currentAngle = Mathf.Lerp(targetAngle, startAngle, t);
            Pannel.localRotation = Quaternion.Euler(0, 0, currentAngle);
            yield return null;
        }

        isSpinning = false;
    }

    public void Click_To_Spin6()
    {
        if (!isSpinning)
        {
            StartCoroutine(SpinCoroutine6());
        }
    }

    IEnumerator SpinCoroutine6()
    {
        isSpinning = true;

        // ���� ������ ��ǥ ���� ����
        float startAngle = Pannel.localRotation.eulerAngles.z;
        float targetAngle = startAngle - 195f;

        // ȸ�� ������ ���� ��� ����
        float t = 0f;
        while (t < 1f)
        {
            t += Time.deltaTime / rotationDuration;
            float currentAngle = Mathf.Lerp(startAngle, targetAngle, t);
            Pannel.localRotation = Quaternion.Euler(0, 0, currentAngle);
            yield return null;
        }

        // ȸ�� �� ���
        yield return new WaitForSeconds(returnDuration);

        // �ǵ��ƿ��� ȸ�� ������ ���� ��� ����
        t = 0f;
        while (t < 1f)
        {
            t += Time.deltaTime / returnDuration;
            float currentAngle = Mathf.Lerp(targetAngle, startAngle, t);
            Pannel.localRotation = Quaternion.Euler(0, 0, currentAngle);
            yield return null;
        }

        isSpinning = false;
    }

    public void Click_To_Spin7()
    {
        if (!isSpinning)
        {
            StartCoroutine(SpinCoroutine7());
        }
    }

    IEnumerator SpinCoroutine7()
    {
        isSpinning = true;

        // ���� ������ ��ǥ ���� ����
        float startAngle = Pannel.localRotation.eulerAngles.z;
        float targetAngle = startAngle - 225f;

        // ȸ�� ������ ���� ��� ����
        float t = 0f;
        while (t < 1f)
        {
            t += Time.deltaTime / rotationDuration;
            float currentAngle = Mathf.Lerp(startAngle, targetAngle, t);
            Pannel.localRotation = Quaternion.Euler(0, 0, currentAngle);
            yield return null;
        }

        // ȸ�� �� ���
        yield return new WaitForSeconds(returnDuration);

        // �ǵ��ƿ��� ȸ�� ������ ���� ��� ����
        t = 0f;
        while (t < 1f)
        {
            t += Time.deltaTime / returnDuration;
            float currentAngle = Mathf.Lerp(targetAngle, startAngle, t);
            Pannel.localRotation = Quaternion.Euler(0, 0, currentAngle);
            yield return null;
        }

        isSpinning = false;
    }

    public void Click_To_Spin8()
    {
        if (!isSpinning)
        {
            StartCoroutine(SpinCoroutine8());
        }
    }

    IEnumerator SpinCoroutine8()
    {
        isSpinning = true;

        // ���� ������ ��ǥ ���� ����
        float startAngle = Pannel.localRotation.eulerAngles.z;
        float targetAngle = startAngle - 260f;

        // ȸ�� ������ ���� ��� ����
        float t = 0f;
        while (t < 1f)
        {
            t += Time.deltaTime / rotationDuration;
            float currentAngle = Mathf.Lerp(startAngle, targetAngle, t);
            Pannel.localRotation = Quaternion.Euler(0, 0, currentAngle);
            yield return null;
        }

        // ȸ�� �� ���
        yield return new WaitForSeconds(returnDuration);

        // �ǵ��ƿ��� ȸ�� ������ ���� ��� ����
        t = 0f;
        while (t < 1f)
        {
            t += Time.deltaTime / returnDuration;
            float currentAngle = Mathf.Lerp(targetAngle, startAngle, t);
            Pannel.localRotation = Quaternion.Euler(0, 0, currentAngle);
            yield return null;
        }

        isSpinning = false;
    }

    public void Click_To_Spin9()
    {
        if (!isSpinning)
        {
            StartCoroutine(SpinCoroutine9());
        }
    }

    IEnumerator SpinCoroutine9()
    {
        isSpinning = true;

        // ���� ������ ��ǥ ���� ����
        float startAngle = Pannel.localRotation.eulerAngles.z;
        float targetAngle = startAngle - 280f;

        // ȸ�� ������ ���� ��� ����
        float t = 0f;
        while (t < 1f)
        {
            t += Time.deltaTime / rotationDuration;
            float currentAngle = Mathf.Lerp(startAngle, targetAngle, t);
            Pannel.localRotation = Quaternion.Euler(0, 0, currentAngle);
            yield return null;
        }

        // ȸ�� �� ���
        yield return new WaitForSeconds(returnDuration);

        // �ǵ��ƿ��� ȸ�� ������ ���� ��� ����
        t = 0f;
        while (t < 1f)
        {
            t += Time.deltaTime / returnDuration;
            float currentAngle = Mathf.Lerp(targetAngle, startAngle, t);
            Pannel.localRotation = Quaternion.Euler(0, 0, currentAngle);
            yield return null;
        }

        isSpinning = false;
    }
}
