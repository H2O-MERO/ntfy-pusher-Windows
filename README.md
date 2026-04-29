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
•	**完整中文界面**： 软件界面、设置选项已全面中文化，方便中文用户使用。  
•	**更现代的通知系统**： 使用toast替代简单的通知系统，以支持复制按钮一类的现代弹窗功能  

## 软件截屏
### 主程序
<img width="668" height="516" alt="image" src="https://github.com/user-attachments/assets/5d414037-51a7-43ba-9239-54300396b52f" />
<img width="855" height="770" alt="image" src="https://github.com/user-attachments/assets/e74cd7cd-3735-4204-b133-0c350367c8b2" />

### 通知示例
<img width="565" height="280" alt="image" src="https://github.com/user-attachments/assets/0cb94c00-ad4b-45ac-b1f2-3872485bc954" />

## 命令行参数
### -h & --help
显示帮助菜单
### -t & --start-in-tray
以托盘模式启动ntfy pusher Windows，适用于登录时随系统自启动
### -m & --allow-multiple-instances
绕过实例检查，允许多个 ntfy.sh Windows 实例同时启动
