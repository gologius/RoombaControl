# RoombaControl
Roombaを制御することができるGUIアプリケーションです。

![ファイル名表示](https://github.com/gologius/RoombaControl/blob/master/screenshot.png)

# 必要なもの

* Roomba (500シリーズで動作確認済み)
* PCのUSBポートと、ルンバを接続するケーブル

# 使用方法

1. COMとBaudRateを指定して接続する
2. 最初にStartを押して，そのあとに安全装置？が働くSafeか，働かないFullを選ぶ．

機能

* Cleanは掃除し始めます
* Driveは下のトラックバーのパラメータ通りに動きます
* Blush，Vacuumはブラシ等のON,OFF
* Front,Back等のボタンはトラックバーで指定したスピードで前進，後退
* Turn Left,Rightはその場で回転
* Key Controlはクリックでそこにフォーカスすると，方向キーで操作できるようになります(スペースキーで止まる)

# 参考

* RoombaをVisual C#で制御する（その２）: 花岡ちゃんに花束を (http://cyberworks.cocolog-nifty.com/blog/2012/10/roombavisual-c-.html)
* 公式リファレンス http://www.irobot.lv/uploaded_files/File/iRobot_Roomba_500_Open_Interface_Spec.pdf
