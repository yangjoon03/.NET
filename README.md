# .NET
Tutorial : [NET Multi-Platform App UI](https://learn.microsoft.com/ko-kr/training/paths/build-apps-with-dotnet-maui/?WT.mc_id=dotnet-35129-website)

| 항목         | .NET MAUI                    | Flutter                                  |
| ---------- | ---------------------------- | ---------------------------------------- |
| **사용 언어**  | C#                           | Dart                                     |
| **개발사**    | Microsoft                    | Google                                   |
| **UI 방식**  | 플랫폼의 **네이티브 UI 래핑**          | **스스로 렌더링** (Skia 엔진 사용)                 |
| **지원 플랫폼** | Android, iOS, Windows, macOS | Android, iOS, Web, Windows, macOS, Linux |
| **출시 시기**  | 2022년 정식 출시                  | 2018년 정식 출시                              |


| 항목            | .NET MAUI          | Flutter                    |
| ------------- | ------------------ | -------------------------- |
| **UI 렌더링 방식** | 플랫폼 네이티브 UI 사용     | Skia로 직접 렌더링               |
| **UI 일관성**    | 플랫폼에 따라 약간 다름      | 모든 플랫폼에서 픽셀 단위로 동일         |
| **성능**        | 괜찮지만 플랫폼별 성능 차이 있음 | 빠르고 일관된 성능                 |
| **커스텀 UI**    | 복잡한 UI는 구현 난이도 있음  | 복잡하고 멋진 UI도 상대적으로 쉽게 구현 가능 |

## Chapter3 요약
### 바인딩
데이터 변경 시 UI가 자동으로 업데이트되고, UI 변경 시 데이터도 자동으로 반영되도록 실시간 동기화

## Chapter4 요약
### HR
2주, 3일, 4시간 = 13.5일
5day = 1week
1day = 8hour


Model (비즈니스 로직):
데이터는 "13.5일"이라는 숫자로만 제공됩니다.
이건 계산, 저장, 전송하기엔 편리한 형태예요.

View (사용자 화면):
사용자는 **"13.5일"**을 보고 싶지 않아요.
**"2주, 3일, 4시간"**처럼 사람이 이해하기 쉬운 형식으로 보고 싶어요.

ViewModel의 역할:
ViewModel은 모델의 13.5일을 받아서, 보기 좋은 형식(예: "2주, 3일, 4시간")으로 바꿔줍니다.

