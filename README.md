# Uni Compile Tester

各プラットフォームにおいてコンパイルエラーが発生しないか確認できるテストコード  

## 使用例

```cs
using UnityEngine;

public class Example : MonoBehaviour
{
    private void Awake()
    {
#if UNITY_ANDROID

        ここでコンパイルエラー
#endif
    }
}
```

上記のように Android プラットフォームにおいて  
コンパイルエラーが発生するスクリプトが存在するプロジェクトで  

![2020-04-23_234547](https://user-images.githubusercontent.com/6134875/80113059-c4c7dd80-85bc-11ea-8831-8e456213023b.png)

Unity Test Runner でテストを実行すると  

![2020-04-23_234626](https://user-images.githubusercontent.com/6134875/80113064-c691a100-85bc-11ea-9482-ea522ee41fae.png)

Android プラットフォームだとコンパイルエラーが発生することがテスト結果でわかります  
