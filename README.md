# VoiceMananger
R6聲控開啟地圖

## Required
1.語音辨識的部分使用[Google.Cloud.Speech.V1](https://cloud.google.com/dotnet/docs/reference/Google.Cloud.Speech.V1/latest),
需要辦一個帳號去申請Token,**請注意免費額度避免收費**  
2.[Token的設定方式](https://cloud.google.com/docs/authentication/getting-started)

## GetStarted
開啟程式按下F1即開始收音(3秒)  
可用的語音指令請參考[KeyWords](VoiceMananger/KeyWord.cs)  
收音的狀態下語音輸入\[地圖]+\[樓層](例如[領事館]+[一樓])  
打開的Chome即會切換到指定的地圖+樓層
