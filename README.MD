# 📚 Unity 게임 프로그래밍 가이드 요약 (파일 순서별 정리)

Unity 입문자를 위한 프로젝트 기반 실습 문서 요약본입니다.  
(게임프로그래밍01 → 02 → 04 순서)

---

# ⚙️ 1. 게임프로그래밍01: Unity 설치하기 (Unity Install)

Unity 개발 환경을 구축하는 단계별 과정입니다.

## 📌 Unity 설치 절차

| 구분 | 단계 | 세부 내용 및 참고 사항 |
|------|------|------------------------|
| **1. 접속** | Unity 공식 사이트 방문 | https://unity.com 접속 후 **Get Started** 버튼 클릭 |
| **2. 플랜 선택** | 개인 및 학생 플랜 선택 | Student and hobbyist → **Personal(수익 $100K 미만)** 또는 Student 선택 후 다운로드 |
| **3. 설치** | Unity Hub 다운로드 및 설치 | 설치 파일 실행 → Unity Hub 설치 → **마침** |
| **4. 로그인** | Unity ID 로그인 | Unity Hub에서 로그인 또는 신규 계정 생성 |
| **5. 라이선스** | Personal Edition License 획득 | 라이선스 동의 후 Personal Edition License 등록 |
| **6. 에디터 설치** | Unity Editor 설치 | Unity Hub → **Installs** 탭 → 필요한 버전 설치 |

---

# 🖲️ 2. 게임프로그래밍02: Rolling Ball 프로젝트

Unity Rigidbody 물리 엔진을 활용해 공이 굴러가고 튕기는 환경을 만드는 실습입니다.

---

## A. 프로젝트 생성 및 씬(Scene) 구성

### 📌 기본 설정

| 항목 | 설정 값 / 구성 내용 | 비고 |
|------|---------------------|------|
| **프로젝트** | Rolling Ball / 3D 템플릿 / Unity 2021.3.7f1 LTS | |
| **카메라** | Position: **X 0, Y 1, Z -10** | Y축을 1로 조정 |
| **씬 방향** | X축(빨강)=오른쪽, Y축(녹색)=위 | 기즈모 방향 조정 |
| **오브젝트 배치** | Floor, Wall, Ball 등 배치 | Cube & Sphere 사용 |

### 📌 배치 오브젝트 예시

| 오브젝트 | 종류 | Position | Scale |
|----------|-------|----------|--------|
| **Floor(바닥)** | Cube | X: 0, Y: 0, Z: 0 | X: 10, Y: 0.5, Z: 5 |
| **Ball(공)** | Sphere | X: -4.4, Y: 9.58, Z: 0.7 | X: 0.4, Y: 0.4, Z: 0.4 |

---

## B. 물리 동작 (Rigidbody & Bounce) 설정

| 단계 | 오브젝트 | 컴포넌트 / 속성 | 설정 값 |
|------|----------|------------------|---------|
| **1. 중력 적용** | Ball | Rigidbody 추가 | Use Gravity 체크 |
| **2. 탄성 재질 생성** | Project 뷰 | Physic Material 생성 (**Bounce**) | Bounciness: 0.6 |
| **3. 속성 적용** | Ball | Sphere Collider → Material | Bounce 지정 |
| **4. 테스트** | Play 버튼 | 공이 중력 및 탄성에 의해 굴러 떨어지고 튕기는지 확인 |

---

# 🏃 3. 게임프로그래밍04: 캐릭터 움직임 구현 (Character Move)

Terrain 환경에 캐릭터 모델을 배치하고 키보드 입력을 통한 조작 기능을 확인합니다.

---

## A. 프로젝트 준비 및 리소스 Import

| 단계 | 항목 | 설정 및 조치 |
|------|------|---------------|
| **1. 새 프로젝트 생성** | 프로젝트 생성 | 이름: **CharacterMove**, 템플릿: 3D, 버전: 2021.3.7f1 LTS |
| **2. 리소스 가져오기** | Terrain & 캐릭터 리소스 | `Assets → Import Package → Custom Package` → **Chapter4 Terrain.unitypackage** Import |

---

## B. 씬 환경 및 캐릭터 배치

| 오브젝트 | 역할 및 주요 작업 | Transform Position (예시) |
|----------|--------------------|---------------------------|
| **Terrain (지형)** | 배경 환경 구성, Paint Terrain으로 높이·텍스처 편집 | - |
| **PQchan (캐릭터)** | 플레이어 조작 캐릭터 | X: 50, Y: 0.2, Z: 50 |
| **Main Camera** | 캐릭터 시점 설정 | X: 50, Y: 2.5, Z: 46 |

---

## C. 캐릭터 조작 확인

| 단계 | 조작 | 결과 |
|------|--------|--------|
| **1** | Play 버튼 클릭 | 게임 실행 |
| **2** | 방향 키 입력 | 캐릭터가 해당 방향으로 이동 |
| **3** | Space Bar | 점프 또는 설정된 행동 수행 |

---


