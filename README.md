# LoR-PassivePack
LoRのModパッシブ詰め合わせです  

# ☆使い方☆
`dotnet`でビルドして生成された.dllファイルをAssemblyフォルダに入れるだけ！  
`dotnet`は7を使用しています...  

# build binaly
- OS: Linux <= using shell
- dotnet: 7

レポジトリをcloneします。  
```sh
git clone https://github.com/TundraClimate/LoR-PassivePack
```

中身の各フォルダで
```sh
dotnet build
```
を実行してください。  

`./bin/Debug/net7.0`の中の.dllファイルをModの`Assembly`フォルダにペーストしてください。  
