# 개발자 매뉴얼
   
## 1. 개요
해당 프로젝트는 한양대학교 ERICA 캠퍼스의 '가상및증강현실프로그래맹'수업의 팀 프로젝트로 진행되었습니다.<br/>
안산 산업 역사 박물관의 VR/AR콘텐츠로써, 박물관에서 볼 수 있는 물품들을 콘텐츠 내에서도 발견하고, 현대 물품과의 사용법의 차이를 배울 수 있는 콘텐츠입니다.<br/>
*커밋 사항에는 URP가 기재되어 있지만, 본 프로젝트는 Built-in 렌더링 파이프를 사용합니다.*

## 2. 요구사항 및 설치
### 2.1 하드웨어 요구사항
Meta Quest2를 대상으로 만들어졌으므로, 해당 기기가 요구됩니다.<br/>
이외의 기기에서는 검증되지 않았습니다.

### 2.2 소프트웨어 요구사항
Unity: 2022.3.20f1<br/>
Oculus Integration Version: 57.0.1-deprecated

### 2.3 에셋 및 리소스 요구사항
본 프로젝트는 각종 라이센스를 포함한 에셋을 사용하고 있습니다.<br/>
사용된 에셋 목록들은 [AssetNotion](https://electric-scarf-ff3.notion.site/04ea9cb8ca04442e9c3b03f25d868af7?v=f1bf456884cf4011977100f0386b4ec8&pvs=4)에서 확인이 가능하며, 출처는 인게임 크레딧 패널에도 기재해놓았습니다.<br/>
그외에는 배포한 파일 상태 그대로 라이센스를 유지하고 있습니다.<br/>
사용한 에셋 파일들은 다음에 위치했습니다.
> Assets
> > Resources
> > > Asset

그 외의 에셋 패키지 '_Course Library'는 다음에 있습니다.
> Assets

### 2.4 설치 및 실행
1. 해당 프로젝트를 다운 받습니다.
2. 기본적으로 Android로 Platform이 설정되어 있습니다.<br/>
바로 Build하여 Apk 파일을 생성하면 됩니다.
3. Meta Quest Developer Hub를 다운로드하고 실행합니다.
4. 기기를 등록하고, USB로 연결합니다.
5. 디버깅 활성화 여부 팝업이 등장하면 "허용"을 누릅니다.
6. 실행하고자 하는 Apk 파일을 드래그하여 추가합니다.
7. 설치된 Apk 파일을 launch해주면 됩니다.

## 3. 플로우 차트
### 3.1 라디오
![Radio](https://github.com/TYParrot/TimeTravel/assets/73172379/dc2a3973-a7ae-4414-956b-3009d02cbaed)
### 3.2 전자레인지
![Microwave](https://github.com/TYParrot/TimeTravel/assets/73172379/f3dbb986-1fe9-4f5b-8be6-7d1951a4b3ec)
### 3.3 전화기
![Telephone](https://github.com/TYParrot/TimeTravel/assets/73172379/cb3767d8-79a4-4b5d-9fca-c0ac0b676209)
### 3.4 게임 시스템
![GameSystem](https://github.com/TYParrot/TimeTravel/assets/73172379/309524e2-e6e2-4004-9c36-b3b5695b4981)
   
## 4. 구현
### 4.1 화면 구성
모든 UI 캔버스는 World Space로 렌더링되고 있으며, 고정된 연출은 Main Camera의 아래에 놓는 것으로 진행하였습니다. 

### 4.2 씬 구성
씬은 Start, Prologue, House, TelephoneScene, MicrowaveScene, RadioScene으로 이루어져 있습니다.
그외에는 UI 작업용 씬으로 CanvasMaking씬이 남아있습니다.<br/>각 씬에 대한 이미지는 [README](https://github.com/TYParrot/TimeTravel)에서 확인할 수 있습니다. 

### 4.3 파일 구조
작업한 내용들은 다음 위치에서 확인할 수 있습니다.<br/>
이니셜로 이루어진 파일은 해당 파일에 있는 리소스 소유자이므로, 
관련 문의사항도 해당 파일의 소유자에게로 주시면 됩니다.<br/>
이메일은 [README](https://github.com/TYParrot/TimeTravel)에서 확인할 수 있습니다.
> Assets
> > =Work=
> > > MJ(라디오 관련 모든 리소스)
> > >
> > > SB(전자레인지 관련 모든 리소스)
> > > 
> > > SI(전화기 관련 모든 리소스)
> > > 
> > > TY(시스템, 인테리어 관련 모든 리소스)


## 기타 문의사항
이태윤 (taeyoon0305@hanyang.ac.kr)
