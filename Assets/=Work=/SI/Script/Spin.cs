using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spin : MonoBehaviour
{
    public Transform Pannel;
    public float rotationDuration = 1f; // 회전 소요 시간 (초)
    public float returnDuration = 1f; // 회전 후 되돌아오는 소요 시간 (초)

    private bool isSpinning = false; // 회전 중인지 여부를 나타내는 변수

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

        // 시작 각도와 목표 각도 설정
        float startAngle = Pannel.localRotation.eulerAngles.z;
        float targetAngle = startAngle - 305f;

        // 회전 프레임 별로 끊어서 연결
        float t = 0f;
        while (t < 1f)
        {
            t += Time.deltaTime / rotationDuration;
            float currentAngle = Mathf.Lerp(startAngle, targetAngle, t);
            Pannel.localRotation = Quaternion.Euler(0, 0, currentAngle);
            yield return null;
        }

        // 회전 후 대기
        yield return new WaitForSeconds(returnDuration);

        // 되돌아오는 회전 프레임 별로 끊어서 연결
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

        // 시작 각도와 목표 각도 설정
        float startAngle = Pannel.localRotation.eulerAngles.z;
        float targetAngle = startAngle - 45f;

        // 회전 프레임 별로 끊어서 연결
        float t = 0f;
        while (t < 1f)
        {
            t += Time.deltaTime / rotationDuration;
            float currentAngle = Mathf.Lerp(startAngle, targetAngle, t);
            Pannel.localRotation = Quaternion.Euler(0, 0, currentAngle);
            yield return null;
        }

        // 회전 후 대기
        yield return new WaitForSeconds(returnDuration);

        // 되돌아오는 회전 프레임 별로 끊어서 연결
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

        // 시작 각도와 목표 각도 설정
        float startAngle = Pannel.localRotation.eulerAngles.z;
        float targetAngle = startAngle - 80f;

        // 회전 프레임 별로 끊어서 연결
        float t = 0f;
        while (t < 1f)
        {
            t += Time.deltaTime / rotationDuration;
            float currentAngle = Mathf.Lerp(startAngle, targetAngle, t);
            Pannel.localRotation = Quaternion.Euler(0, 0, currentAngle);
            yield return null;
        }

        // 회전 후 대기
        yield return new WaitForSeconds(returnDuration);

        // 되돌아오는 회전 프레임 별로 끊어서 연결
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

        // 시작 각도와 목표 각도 설정
        float startAngle = Pannel.localRotation.eulerAngles.z;
        float targetAngle = startAngle - 105f;

        // 회전 프레임 별로 끊어서 연결
        float t = 0f;
        while (t < 1f)
        {
            t += Time.deltaTime / rotationDuration;
            float currentAngle = Mathf.Lerp(startAngle, targetAngle, t);
            Pannel.localRotation = Quaternion.Euler(0, 0, currentAngle);
            yield return null;
        }

        // 회전 후 대기
        yield return new WaitForSeconds(returnDuration);

        // 되돌아오는 회전 프레임 별로 끊어서 연결
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

        // 시작 각도와 목표 각도 설정
        float startAngle = Pannel.localRotation.eulerAngles.z;
        float targetAngle = startAngle - 135f;

        // 회전 프레임 별로 끊어서 연결
        float t = 0f;
        while (t < 1f)
        {
            t += Time.deltaTime / rotationDuration;
            float currentAngle = Mathf.Lerp(startAngle, targetAngle, t);
            Pannel.localRotation = Quaternion.Euler(0, 0, currentAngle);
            yield return null;
        }

        // 회전 후 대기
        yield return new WaitForSeconds(returnDuration);

        // 되돌아오는 회전 프레임 별로 끊어서 연결
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

        // 시작 각도와 목표 각도 설정
        float startAngle = Pannel.localRotation.eulerAngles.z;
        float targetAngle = startAngle - 165f;

        // 회전 프레임 별로 끊어서 연결
        float t = 0f;
        while (t < 1f)
        {
            t += Time.deltaTime / rotationDuration;
            float currentAngle = Mathf.Lerp(startAngle, targetAngle, t);
            Pannel.localRotation = Quaternion.Euler(0, 0, currentAngle);
            yield return null;
        }

        // 회전 후 대기
        yield return new WaitForSeconds(returnDuration);

        // 되돌아오는 회전 프레임 별로 끊어서 연결
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

        // 시작 각도와 목표 각도 설정
        float startAngle = Pannel.localRotation.eulerAngles.z;
        float targetAngle = startAngle - 195f;

        // 회전 프레임 별로 끊어서 연결
        float t = 0f;
        while (t < 1f)
        {
            t += Time.deltaTime / rotationDuration;
            float currentAngle = Mathf.Lerp(startAngle, targetAngle, t);
            Pannel.localRotation = Quaternion.Euler(0, 0, currentAngle);
            yield return null;
        }

        // 회전 후 대기
        yield return new WaitForSeconds(returnDuration);

        // 되돌아오는 회전 프레임 별로 끊어서 연결
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

        // 시작 각도와 목표 각도 설정
        float startAngle = Pannel.localRotation.eulerAngles.z;
        float targetAngle = startAngle - 225f;

        // 회전 프레임 별로 끊어서 연결
        float t = 0f;
        while (t < 1f)
        {
            t += Time.deltaTime / rotationDuration;
            float currentAngle = Mathf.Lerp(startAngle, targetAngle, t);
            Pannel.localRotation = Quaternion.Euler(0, 0, currentAngle);
            yield return null;
        }

        // 회전 후 대기
        yield return new WaitForSeconds(returnDuration);

        // 되돌아오는 회전 프레임 별로 끊어서 연결
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

        // 시작 각도와 목표 각도 설정
        float startAngle = Pannel.localRotation.eulerAngles.z;
        float targetAngle = startAngle - 260f;

        // 회전 프레임 별로 끊어서 연결
        float t = 0f;
        while (t < 1f)
        {
            t += Time.deltaTime / rotationDuration;
            float currentAngle = Mathf.Lerp(startAngle, targetAngle, t);
            Pannel.localRotation = Quaternion.Euler(0, 0, currentAngle);
            yield return null;
        }

        // 회전 후 대기
        yield return new WaitForSeconds(returnDuration);

        // 되돌아오는 회전 프레임 별로 끊어서 연결
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

        // 시작 각도와 목표 각도 설정
        float startAngle = Pannel.localRotation.eulerAngles.z;
        float targetAngle = startAngle - 280f;

        // 회전 프레임 별로 끊어서 연결
        float t = 0f;
        while (t < 1f)
        {
            t += Time.deltaTime / rotationDuration;
            float currentAngle = Mathf.Lerp(startAngle, targetAngle, t);
            Pannel.localRotation = Quaternion.Euler(0, 0, currentAngle);
            yield return null;
        }

        // 회전 후 대기
        yield return new WaitForSeconds(returnDuration);

        // 되돌아오는 회전 프레임 별로 끊어서 연결
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
