# ntfy pusher Windows

本软件是 ntfy.sh Windows 的一个**增强的中文分支版本**。原版由 Lucas Bortoli 及贡献者开发。
ntfy.sh Windows 是一款轻量级的推送通知客户端，用于接收通过兼容 https://ntfy.sh 标准的服务器发送的通知。

## 核心功能 (原版功能)  
•	**轻量级**： 占用资源少。  
•	**多服务器支持**： 可同时接收来自多个不同 ntfy.sh 兼容服务器（包括但不限于官方 ntfy.sh）的通知。  
•	双协议支持： 通过 Websocket 或 HTTP 两种协议实时接收通知。  
•	**话题支持**： 支持订阅公开（无认证）和私有（认证）话题。  
•	**桌面通知**： 在 Windows 系统托盘中运行，收到消息时弹出桌面通知。   
## 新增与增强内容 (由本分支版提供)  
•	**多语言支持**： 软件界面、设置选项均有汉化和多语言支持，方便中文用户使用。  
•	**更现代的通知系统**： 使用toast替代简单的通知系统，以支持复制按钮一类的现代弹窗功能，支持自动复制  
•	**增加开机自启动功能**： 使得信息接收更加便捷  

## 软件截屏
### 主程序
<img width="668" height="516" alt="image" src="https://github.com/user-attachments/assets/5d414037-51a7-43ba-9239-54300396b52f" />
<img width="533" height="623" alt="image" src="https://github.com/user-attachments/assets/a4d0baf7-80a7-42ae-9b02-e1bc4da64e3e" />  
<img width="414" height="359" alt="image" src="https://github.com/user-attachments/assets/0849a087-76cb-4254-8181-feabcee63845" />



### 通知示例
<img width="565" height="280" alt="image" src="https://github.com/user-attachments/assets/0cb94c00-ad4b-45ac-b1f2-3872485bc954" />

## 命令行参数
### -h & --help
显示帮助菜单
### -t & --start-in-tray
以托盘模式启动ntfy pusher Windows，适用于登录时随系统自启动
### -m & --allow-multiple-instances
绕过实例检查，允许多个 ntfy.sh Windows 实例同时启动

## 自动更新
程序启动时会**静默检查一次更新**，也可通过 **帮助 → 检查更新** 菜单或托盘右键菜单的 **检查更新** 手动触发。

- **原理**：调用 [GitHub Releases API](https://api.github.com/repos/H2O-MERO/ntfy-pusher-Windows/releases/latest) 获取最新版本号，与本机程序集版本比较；
- 发现新版本后，下载 Release 中附带的 zip 更新包并显示下载进度；
- 下载完成后程序自动退出，由临时脚本替换程序文件并**沿用原启动参数重新启动**（更新全程无需人工干预）；
- 已是最新版本时手动检查会提示“当前已是最新版本”；检查失败（如无网络）不影响正常使用；
- 运行要求与主程序一致：系统需安装 **.NET 6 Desktop Runtime**。

### 如何发布新版本（维护者）
1. 推送一个形如 `v1.1.0` 的 tag（版本号以 tag 为准，`v` 前缀可省略）：
   ```
   git tag v1.1.0
   git push origin v1.1.0
   ```
2. GitHub Actions 会自动编译 win-x64 版本、打包成 zip 并创建 Release（见 `.github/workflows/release.yml`）；
3. 客户端下次检查更新时即可发现并自动更新。
