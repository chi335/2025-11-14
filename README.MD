# 🎮 Unity 게임 프로그래밍 가이드 요약  
파일 순서별(Project 기준)로 정리된 Unity 학습 자료입니다.

---

## ⚙️ 1. 게임프로그래밍01: Unity 설치하기 (Unity Install)

Unity 개발 환경 구축을 위한 단계별 가이드입니다.

### 📌 설치 단계 요약

| 단계 | 설명 |
|------|------|
| **1. 접속** | Unity 공식 사이트 접속 → **Get Started** 클릭 |
| **2. 플랜 선택** | Student and hobbyist → **Personal(수익 $100K 미만)** 또는 Student 플랜 선택 |
| **3. 설치** | Unity Hub 다운로드 및 설치 후 실행 |
| **4. 로그인** | Unity ID 로그인 또는 계정 생성 |
| **5. 라이선스 등록** | Personal Edition License 획득 후 동의 |
| **6. 에디터 설치** | Unity Hub → **Installs 탭** → 필요한 Unity Editor 버전 설치 |

---

## 🖲️ 2. 게임프로그래밍02: Rolling Ball 예제 만들기

Unity 물리 엔진을 활용한 공 굴리기/튕기기 예제입니다.

---

### A. 프로젝트 생성 & Scene 구성

| 항목 | 설정 내용 | 비고 |
|------|-----------|------|
| **프로젝트** | Rolling Ball / 3D 템플릿 / Unity 2021.3.7f1 LTS | |
| **카메라 위치** | `X: 0, Y: 1, Z: -10` | 시점을 위해 Y=1로 조정 |
| **씬 방향** | X축(빨강)=오른쪽, Y축(초록)=위 | 촬영 시 필수 |
| **오브젝트 배치** | Floor / Wall / Ball 구성 (Cube, Sphere 활용) | |

### 📌 주요 오브젝트 설정 예시

| 오브젝트 | 종류 | Position | Scale |
|----------|-------|----------|--------|
| **Floor** | Cube | `X: 0, Y: 0, Z: 0` | `X: 10, Y: 0.5, Z: 5` |
| **Ball** | Sphere | `X: -4.4, Y: 9.58, Z: 0.7` | `X: 0.4, Y: 0.4, Z: 0.4` |

---

### B. 물리 동작 (Rigidbody & Bounce) 설정

| 단계 | 대상 | 컴포넌트/속성 | 설정 |
|------|-------|----------------|------|
| **1. 중력 적용** | Ball | Rigidbody 추가 | Use Gravity 체크 |
| **2. 탄성 재질 생성** | Project | Physic Material 생성(Bounce) | **Bounciness: 0.6** |
| **3. 콜라이더 적용** | Ball | Sphere Collider → Material | Bounce 지정 |
| **4. 테스트** | Play 버튼 | 공의 중력·탄성 동작 확인 |

---

## 🏃 3. 게임프로그래밍04: 캐릭터 움직임 구현 (Character Move)

Terrain 기반 환경에서 캐릭터 움직임을 구현하는 프로젝트입니다.

---

### A. 프로젝트 준비 & 리소스 Import

| 단계 | 설명 |
|------|------|
| **1. 새 프로젝트 생성** | 이름: *CharacterMove*, 템플릿: 3D, 버전: 2021.3.7f1 LTS |
| **2. 리소스 Import** | `Assets → Import Package → Custom Package` → **Chapter4 Terrain.unitypackage** Import |

---

### B. 씬 환경 & 캐릭터 배치

| 오브젝트 | 설명 | Position (예시) |
|----------|--------|----------------|
| **Terrain** | Paint Terrain 도구로 높이 & 텍스처 편집 | - |
| **PQchan (캐릭터)** | 플레이어 캐릭터 | `X: 50, Y: 0.2, Z: 50` |
| **Main Camera** | 캐릭터 뒤쪽에서 따라보도록 설정 | `X: 50, Y: 2.5, Z: 46` |

---

### C. 캐릭터 조작 테스트

| 조작 | 결과 |
|------|--------|
| **Play** | 게임 실행 |
| **←↑↓→ 방향키** | 캐릭터 이동 |
| **Space Bar** | 점프 또는 지정 동작 수행 |

---




